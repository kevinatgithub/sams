Imports MySql.Data.MySqlClient

Public Class New_Employee
    Inherits MetroFramework.Forms.MetroForm

    Public Caller As List
    Public CurrentEmployee As New Employee
    Public offices As Collection = Office.GetAllOffices
    Public NextStep As New_Employee_2

    Sub New(caller As List)
        InitializeComponent()
        Me.Caller = caller
        Office.LoadOfficesToComboBox(offices, cbo_office_id)
        LoadPositions(cbo_position)
        NextStep = New New_Employee_2(Me, CurrentEmployee)
    End Sub


    Public Shared Sub LoadPositions(ByVal cbo As ComboBox)
        cbo.Items.Add("--New--")
        Dim positions As MySqlDataReader = Database.DB.Execute("SELECT DISTINCT(position) FROM employee WHERE position <> '--New--' ORDER BY position ASC")
        While positions.Read
            cbo.Items.Add(positions("position"))
        End While
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click

        Dim result As MySqlDataReader = Database.DB.Execute("SELECT * FROM employee WHERE employee_no = '" & txt_employee_no.Text & "'")


        If Not CheckIfFormValid() Then
            MsgBox("Please provide value for required fields")
        ElseIf result.HasRows Then
            MsgBox("Employee Number already registered!")

        Else
            CurrentEmployee.Employee_no = txt_employee_no.Text
            CurrentEmployee.Fname = txt_fname.Text
            CurrentEmployee.Mname = txt_mname.Text
            CurrentEmployee.Lname = txt_lname.Text
            CurrentEmployee.Gender = cbo_gender.SelectedItem
            CurrentEmployee.Dob = dt_dob.Value.Date
            CurrentEmployee.Home_address = txt_address.Text
            CurrentEmployee.Position = cbo_position.SelectedItem
            Dim office As Office = office.FindOfficeByIndex(cbo_office_id.SelectedIndex, offices)
            If Not office Is Nothing Then
                CurrentEmployee.Office = office
            End If
            CurrentEmployee.Registered_by = "admin"


            NextStep.Show()
            Me.Hide()
        End If
    End Sub

    Public Function CheckIfFormValid() As Boolean
        Try
            If txt_employee_no.Enabled = True Then
                If String.IsNullOrEmpty(txt_employee_no.Text) Then
                    Return False
                End If
            End If

            If String.IsNullOrEmpty(txt_fname.Text) Then
                Return False
            End If

            If String.IsNullOrEmpty(txt_lname.Text) Then
                Return False
            End If

            If String.IsNullOrEmpty(cbo_office_id.SelectedItem) Then
                Return False
            End If

            If String.IsNullOrEmpty(cbo_position.SelectedItem) Or cbo_position.SelectedItem.Equals("--New--") Then
                Return False
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Return True

    End Function
    
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Caller.Focus()
        Me.Close()
    End Sub

    Private Sub Bye(sender As Object, e As EventArgs) Handles Me.FormClosed
        Caller.Focus()
    End Sub

    Private Sub cbo_position_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_position.SelectedIndexChanged
        If cbo_position.SelectedItem.Equals("--New--") Then
            cbo_position.Items.Add(InputBox("Enter Employee Position"))
        End If
    End Sub


End Class