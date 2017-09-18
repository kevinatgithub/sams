Public Class OverrideForm
    Inherits MetroFramework.Forms.MetroForm

    Private State As Integer
    Private Employee As Employee
    Private Caller As Override

    Sub New(caller As Override, employee As Employee, state As Integer)
        InitializeComponent()
        Me.Caller = caller
        Me.Employee = employee
        Me.State = state
    End Sub


    Private Sub OverrideForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_employee_fullname.Text = Employee.Fname & " " & Employee.Mname & " " & Employee.Lname

    End Sub


    Private Sub cbo_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_type.SelectedIndexChanged
        If cbo_type.SelectedIndex = 0 Then
            txt_h.Enabled = False
            txt_m.Enabled = False
            txt_h.Text = ""
            txt_m.Text = ""
        Else
            txt_h.Enabled = True
            txt_m.Enabled = True
        End If
    End Sub


    Private Sub txt_h_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_h.KeyUp
        Dim Hour As Double
        Try
            If Not IsNumeric(Double.TryParse(txt_h.Text, Hour)) Or (txt_h.Text < 1 Or txt_h.Text > 24) Then
                txt_h.Text = ""
            End If
        Catch ex As Exception
            txt_h.Text = ""
        End Try
        
    End Sub


    Private Sub txt_m_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_m.KeyUp
        Dim Minute As Double
        Try
            If Not IsNumeric(Double.TryParse(txt_m.Text, Minute)) Or (txt_m.Text < 0 Or txt_m.Text > 59) Then
                txt_m.Text = ""
            End If
        Catch ex As Exception
            txt_m.Text = ""
        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If cbo_type.SelectedIndex = -1 Then
            Return
        End If

        If cbo_type.SelectedIndex > 0 Then
            If txt_h.Text = "" Or txt_m.Text = "" Then
                Return
            End If
        End If

        If txt_reason.Text = "" Then
            Return
        End If

        Dim time
        If cbo_type.SelectedIndex = 0 Then
            time = ""
        Else
            time = txt_h.Text & ":" & txt_m.Text
        End If
        Dim o_date = Date.Parse(dt_date.Value.Date)
        Database.DB.Execute("INSERT INTO `override`(`id`, `employee_id`, `type`, `date`, `time`, `reason`, `created_by`, `approved_by`, `approved_dt`, `disabled_dt`, `disabled_by`) VALUES (null,'" & Employee.Id & "','" & cbo_type.SelectedIndex & "','" & o_date & "', '" & time & "' , '" & txt_reason.Text & "' , '" & User.GetCurrent.user_id & "',null,null,null,null)")

        Me.Close()
        Caller.RefreshList()
    End Sub
End Class