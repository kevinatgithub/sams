Imports MySql.Data.MySqlClient
Public Class Update_Employee_4

    Inherits MetroFramework.Forms.MetroForm


    Public PreviosStep As Update_Employee_3
    Public CurrentEmployee As Employee

    Sub New(PreviosStep As Update_Employee_3, CurrentEmployee As Employee)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.PreviosStep = PreviosStep
        Me.CurrentEmployee = CurrentEmployee
    End Sub


    Private Sub New_Employee_4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pb_profile.Image = CurrentEmployee.Profile_pic_img
        lbl_employee_no.Text = CurrentEmployee.Employee_no
        lbl_name.Text = CurrentEmployee.Fname & " " & CurrentEmployee.Mname & " " & CurrentEmployee.Lname
        lbl_position.Text = CurrentEmployee.Position
        lbl_department.Text = CurrentEmployee.Office.Name
        lbl_gender.Text = CurrentEmployee.Gender
        lbl_dob.Text = CurrentEmployee.Dob
        lbl_address.Text = CurrentEmployee.Home_address

        If CurrentEmployee.Left_finger Is Nothing Then
            pb_left_not_ok.Show()
        Else
            pb_left_ok.Show()
        End If

        If CurrentEmployee.Right_finger Is Nothing Then
            pb_right_not_ok.Show()
        Else
            pb_right_ok.Show()
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        PreviosStep.Show()
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim con As New Database
        con.OpenConnection()
        Dim command As New MySqlCommand("UPDATE employee SET " &
                                        "fname = @fname, " &
                                        "mname = @mname, " &
                                        "lname = @lname, " &
                                        "gender = @gender, " &
                                        "dob = @dob, " &
                                        "home_address = @address, " &
                                        "position = @position, " &
                                        "office = @office, " &
                                        "left_finger = @left, " &
                                        "right_finger = @right " & 
                                        "WHERE employee_no = @employee_no", con.Connection)
        command.Parameters.AddWithValue("@employee_no", CurrentEmployee.Employee_no)
        command.Parameters.AddWithValue("@fname", CurrentEmployee.Fname)
        command.Parameters.AddWithValue("@mname", CurrentEmployee.Mname)
        command.Parameters.AddWithValue("@lname", CurrentEmployee.Lname)
        command.Parameters.AddWithValue("@gender", CurrentEmployee.Gender)
        command.Parameters.AddWithValue("@dob", Date.Parse(CurrentEmployee.Dob))
        command.Parameters.AddWithValue("@address", CurrentEmployee.Home_address)
        command.Parameters.AddWithValue("@position", CurrentEmployee.Position)
        command.Parameters.AddWithValue("@office", CurrentEmployee.Office.Id)
        If CurrentEmployee.Left_finger IsNot Nothing Then
            command.Parameters.AddWithValue("@left", CurrentEmployee.Left_finger)
        Else
            command.Parameters.AddWithValue("@left", DBNull.Value)
        End If

        If CurrentEmployee.Right_finger IsNot Nothing Then
            command.Parameters.AddWithValue("@right", CurrentEmployee.Right_finger)
        Else
            command.Parameters.AddWithValue("@right", DBNull.Value)
        End If
        
        Try
            command.ExecuteNonQuery()
            con.CloseConnection()
            If PreviosStep.PreviousStep.PictureChanged Then
                Dim con2 As New Database
                con2.OpenConnection()
                Dim cmd As New MySqlCommand("UPDATE employee SET profile_pic = @profile_pic WHERE employee_no = @employee_no", con2.Connection)
                cmd.Parameters.AddWithValue("@employee_no", CurrentEmployee.Employee_no)
                cmd.Parameters.AddWithValue("@profile_pic", CanYou.ConvertImageToByteArray(CurrentEmployee.Profile_pic_img))
                cmd.ExecuteNonQuery()
                con2.CloseConnection()
            End If
        Catch ex As Exception

            MsgBox(ex.Message & command.CommandText)
        End Try

        Dim list As List = PreviosStep.PreviousStep.PreviousStep.Caller
        list.lv_employees.Items.Clear()
        CanYou.Please.PopulateList(list.lv_employees, list.QueryForEmployeeList(), list.ColumnsForEmployeeList())
        Me.Close()
        PreviosStep.PreviousStep.PreviousStep.Caller.Focus()
    End Sub

    Private Sub Bye(sender As Object, e As EventArgs) Handles Me.FormClosed
        PreviosStep.PreviousStep.PreviousStep.Caller.Focus()
    End Sub
End Class