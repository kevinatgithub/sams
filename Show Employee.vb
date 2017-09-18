Public Class Show_Employee

    Inherits MetroFramework.Forms.MetroForm

    Dim Employee As Employee
    Dim Caller As List
    
    Sub New(ByVal employee As Employee, ByVal caller As List)
        InitializeComponent()
        Me.Employee = employee
        Me.Caller = caller
    End Sub



    Private Sub Show_Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_name.Text = Employee.Fname & " " & Employee.Mname & " " & Employee.Lname
        lbl_employee_no.Text = Employee.Employee_no
        lbl_position.Text = Employee.Position
        lbl_office.Text = Employee.Office.Name
        If Not String.IsNullOrEmpty(Employee.Gender) Then
            If Employee.Gender.Equals("M") Then
                lbl_gender.Text = "Male"
            ElseIf Employee.Gender.Equals("F") Then
                lbl_gender.Text = "Female"
            End If
        End If
        
        lbl_dob.Text = Employee.Dob
        lbl_address.Text = Employee.Home_address
        pb_pic.Image = Employee.Profile_pic_img
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim Update As New Update_Employee_1(Caller, Employee)
        Update.Show()
        Me.Close()
    End Sub

    Private Sub btn_disable_Click(sender As Object, e As EventArgs) Handles btn_disable.Click
        Dim confirm As Integer = MessageBox.Show("Remove/Disable Record?", "Remove/Disable", MessageBoxButtons.YesNo)
        If confirm = DialogResult.Yes Then
            Database.DB.Execute("UPDATE employee SET disabled_dt = now() WHERE employee_no = '" & Employee.Employee_no & "'")
            CanYou.Please.PopulateList(Caller.lv_employees, Caller.QueryForEmployeeList, Caller.ColumnsForEmployeeList)

            Me.Close()
            Caller.Focus()
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
        Caller.Focus()
    End Sub
End Class