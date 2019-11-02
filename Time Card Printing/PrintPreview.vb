Imports MySql.Data.MySqlClient

Public Class PrintPreview
    Inherits MetroFramework.Forms.MetroForm

    Private config As AppConfig
    Private dtr As Dtr
    Private database As Database


    Public Sub New(ByVal dtr As Dtr)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        config = CanYou.Please.ReadConfigFile
        Me.dtr = dtr
    End Sub

    Public Sub form_load() Handles Me.Load

        wb_dtr.Width = Me.Width - 20

        'wb_dtr.ScriptErrorsSuppressed = True
        loadDtr()
    End Sub

    Private Sub loadDtr()
        Dim month_number = (dtr.month + 1).ToString

        Dim month_str As String = month_number.PadLeft(2, "0")
        Dim last_day_str As String = DateTime.DaysInMonth(dtr.year, month_number).ToString
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
        url_str += "&month=" + month_number
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
                thatDays.Add(FromDate.Day)
            End If

            FromDate += aDay
        End While

        Return thatDays
    End Function

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        wb_dtr.Print()
        MsgBox("DTR Printed")
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_reload_Click(sender As Object, e As EventArgs) Handles btn_reload.Click
        Dim id As Integer = dtr.id
        Dim reader As MySqlDataReader = Database.DB.Execute("SELECT * FROM dtr WHERE id = " + id.ToString)
        reader.Read()
        dtr = readerAsDtr(reader)
        loadDtr()
    End Sub

    Private Function readerAsDtr(ByVal reader As MySqlDataReader) As Dtr
        Dim state As New Dtr
        state.id = reader("id")
        state.employee = dtr.employee
        state.year = reader("year")
        state.month = reader("month") - 1
        state.cutoff = reader("cutoff")
        state.holidays = reader("holidays")
        state.holidays_no_remarks = reader("holidays_no_remarks")
        state.show_ot_remarks = reader("show_ot_remarks")
        state.absents = reader("absents")
        state.off_duties = reader("off_duties")
        state.half_days = reader("half_days")
        state.clear_entries = reader("clear_entries")
        state.shifting_days = reader("shifting_days")
        state.signatory = reader("signatory")
        state.position = reader("position")
        Return state
    End Function

    Private Sub btn_copy_url_Click(sender As Object, e As EventArgs) Handles btn_copy_url.Click
        Dim url As Uri = wb_dtr.Url
        Clipboard.SetText(url.ToString)

    End Sub
End Class