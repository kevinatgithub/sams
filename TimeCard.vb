Public Class TimeCard
    Inherits MetroFramework.Forms.MetroForm

    Private _Caller As List
    Private _Employee As Employee

    Sub New(caller As List, employee As Employee)
        InitializeComponent()
        _Caller = caller
        _Employee = employee

        Dim year = Today.Date.Year
        Dim yearLess3Years = year - 3
        While year > yearLess3Years
            cbo_year.Items.Add(year)
            year = year - 1
        End While
    End Sub

    Private Sub TimeCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_employee_fullname.Text = _Employee.Fname & " " & _Employee.Mname & " " & _Employee.Lname
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        wb_dtr.Print()
    End Sub

    Private Sub btn_generate_Click(sender As Object, e As EventArgs) Handles btn_generate.Click
        If cbo_year.SelectedIndex = -1 Then
            Return
        End If

        If cbo_month.SelectedIndex = -1 Then
            Return
        End If

        If cbo_cutoff.SelectedIndex = -1 Then
            Return
        End If

        Dim month = cbo_month.SelectedIndex + 1
        Dim year = cbo_year.SelectedItem
        Dim cutoff = cbo_cutoff.SelectedIndex + 1
        Dim config As AppConfig = CanYou.Please.ReadConfigFile

        Dim url As New Uri(config.ServerURL & "?employee_no=" & _Employee.Id & "&year=" & year & "&month=" & month & "&cutoff=" & cutoff)
        wb_dtr.Url = url

    End Sub
End Class