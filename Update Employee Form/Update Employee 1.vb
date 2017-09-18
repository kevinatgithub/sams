Imports MySql.Data.MySqlClient

Public Class Update_Employee_1

    Inherits MetroFramework.Forms.MetroForm

    Public Caller As List
    Public CurrentEmployee As New Employee
    Public offices As Collection = Office.GetAllOffices
    Public NextStep As Update_Employee_2

    Sub New(ByVal Caller As Object, ByVal CurrentEmployee As Employee)

        InitializeComponent()
        Me.Caller = Caller
        Me.CurrentEmployee = CurrentEmployee
        Office.LoadOfficesToComboBox(offices, cbo_office_id)
        New_Employee.LoadPositions(cbo_position)
        FillInForm()
        NextStep = New Update_Employee_2(Me, CurrentEmployee)
    End Sub

    Sub FillInForm()
        txt_employee_no.Text = CurrentEmployee.Employee_no
        txt_fname.Text = CurrentEmployee.Fname
        txt_mname.Text = CurrentEmployee.Mname
        txt_lname.Text = CurrentEmployee.Lname
        If String.Equals(CurrentEmployee.Gender, "M") Then
            cbo_gender.SelectedIndex = 0
        ElseIf String.Equals(CurrentEmployee.Gender, "F") Then
            cbo_gender.SelectedIndex = 1
        End If

        If CurrentEmployee.Dob IsNot Nothing Then
            dt_dob.Value = Date.Parse(CurrentEmployee.Dob)
        End If
        txt_address.Text = CurrentEmployee.Home_address


        For i = 0 To cbo_office_id.Items.Count - 1
            If String.Equals(CurrentEmployee.Office.Name, cbo_office_id.Items(i)) Then
                cbo_office_id.SelectedIndex = i
            End If
        Next

        For i = 0 To cbo_position.Items.Count - 1
            If String.Equals(cbo_position.Items(i), CurrentEmployee.Position) Then
                cbo_position.SelectedIndex = i
            End If
        Next

    End Sub

    
    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        If Not CheckIfFormValid() Then
            MsgBox("Please provide value for required fields")
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

            If String.IsNullOrEmpty(cbo_position.SelectedItem) Then
                Return False
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Return True

    End Function

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub cbo_position_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_position.SelectedIndexChanged
        If cbo_position.SelectedItem.Equals("--New--") Then
            cbo_position.Items.Add(InputBox("Enter Employee Position"))
        End If
    End Sub

    Private Sub Bye(sender As Object, e As EventArgs) Handles Me.FormClosed
        Caller.Focus()
    End Sub
End Class