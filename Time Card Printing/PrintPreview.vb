Imports MySql.Data.MySqlClient

Public Class PrintPreview
    Inherits MetroFramework.Forms.MetroForm

    Private config As AppConfig
    Private dtr As Dtr


    Public Sub New(ByVal dtr As Dtr)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        config = CanYou.Please.ReadConfigFile
        Me.dtr = dtr
    End Sub

    Public Sub form_load() Handles Me.Load
        'wb_dtr.ScriptErrorsSuppressed = True
        Dim month_str As String = dtr.month.PadLeft(2, "0")
        Dim last_day_str As String = DateTime.DaysInMonth(dtr.year, dtr.month).ToString
        Dim frm_str As String = dtr.year + "-" + month_str + "-1"
        If dtr.cutoff = 0 Then
            last_day_str = "15"
        End If
        Dim to_str As String = dtr.year + "-" + month_str + "-" + last_day_str

        Dim frm As Date = Date.Parse(frm_str)
        Dim tod As Date = Date.Parse(to_str)

        Dim sats As List(Of String) = getThatDays(frm, tod, DayOfWeek.Saturday)
        Dim suns As List(Of String) = getThatDays(frm, tod, DayOfWeek.Sunday)
        Dim mons As List(Of String) = getThatDays(frm, tod, DayOfWeek.Monday)

        Dim saturdays As String = String.Join(",", sats)
        Dim sundays As String = String.Join(",", suns)
        Dim mondays As String = String.Join(",", mons)

        Dim url_str As String = config.ServerURL
        url_str += "?employee_no=" + dtr.employee.Id
        url_str += "&year=" + dtr.year
        url_str += "&month=" + dtr.month
        url_str += "&cutoff=" + (dtr.cutoff + 1).ToString
        url_str += "&signatory=" + dtr.signatory
        url_str += "&position=" + dtr.position
        url_str += "&saturdays=" + saturdays
        url_str += "&sundays=" + sundays
        url_str += "&mondays=" + mondays
        url_str += "&holidays=" + dtr.holidays
        url_str += "&holidays_no_remarks=" + dtr.holidays_no_remarks
        If dtr.show_ot_remarks.Equals("Y") Then
            url_str += "&ot=on"
        Else
            url_str += "&ot=off"
        End If
        url_str += "&absents=" + dtr.absents
        url_str += "&off=" + dtr.off_duties
        url_str += "&shifting_days=" + dtr.shifting_days
        url_str += "&half_days=" + dtr.half_days
        url_str += "&clear_entries=" + dtr.clear_entries

        Dim url As New Uri(url_str)

        wb_dtr.Url = url
    End Sub

    Private Function getThatDays(FromDate As Date, ToDate As Date, ByRef whatDay As Integer) As List(Of String)

        Dim thatDays As New List(Of String)
        Dim aDay As TimeSpan = TimeSpan.FromDays(1)

        While ToDate > FromDate

            If FromDate.DayOfWeek = whatDay Then
                thatDays.Add(FromDate.DayOfWeek.ToString)
            End If

            FromDate += aDay
        End While

        Return thatDays
    End Function


End Class