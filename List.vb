Imports MySql.Data.MySqlClient

Delegate Sub FunctionCall(ByVal param)


Public Class List
    Inherits MetroFramework.Forms.MetroForm
    Private Offices As Collection = Office.Offices
    Private Positions As Collection = Employee.GetPositions
    Private currentUser As User

    Sub New()
        InitializeComponent()
        Offices.Add(Office.GetBlankForShowAll)
        Positions.Add("Show All")
        Employee.LoadPositionsToComboBox(Positions, cbo_position)
        currentUser = User.GetCurrent

    End Sub

    Function QueryForEmployeeList()
        Dim filter As String = ""
        If Not String.IsNullOrEmpty(cbo_division.SelectedItem) Then
            If Not cbo_division.SelectedItem = "Show All" Then
                Dim office As Office = office.FindOfficeByIndex(cbo_division.SelectedIndex, Offices)
                filter = filter & "AND office = '" & office.ID & "'"
            End If
        End If

        If Not String.IsNullOrEmpty(txt_fname.Text) Then
            filter = filter & "AND fname like '%" & txt_fname.Text & "%'"
        End If

        If Not String.IsNullOrEmpty(txt_mname.Text) Then
            filter = filter & "AND mname like '%" & txt_mname.Text & "%'"
        End If

        If Not String.IsNullOrEmpty(txt_lname.Text) Then
            filter = filter & "AND lname like '%" & txt_lname.Text & "%'"
        End If

        If Not String.IsNullOrEmpty(txt_employee_no.Text) Then
            filter = filter & "AND employee_no = '" & txt_employee_no.Text & "'"
        End If

        If Not String.IsNullOrEmpty(cbo_gender.SelectedItem) Then
            If cbo_gender.SelectedIndex = 0 Then
                filter = filter & "AND gender = 'M'"
            ElseIf cbo_gender.SelectedIndex = 1 Then
                filter = filter & "AND gender = 'F'"
            End If
        End If

        If Not String.IsNullOrEmpty(cbo_position.SelectedItem) Then
            If Not cbo_position.SelectedItem = "Show All" Then
                filter = filter & "AND position = '" & cbo_position.SelectedItem & "'"
            End If
        End If

        Return "SELECT e.employee_no, e.fname, e.mname, e.lname, e.gender, e.dob, e.position, o.name " &
            "FROM employee e INNER JOIN office o ON (e.office = o.id) WHERE e.disabled_dt IS NULL " & filter
    End Function

    Function ColumnsForEmployeeList()
        Dim columns As New Collection
        columns.Add("employee_no")
        columns.Add("fname")
        columns.Add("mname")
        columns.Add("lname")
        columns.Add("gender")
        columns.Add("dob")
        columns.Add("position")
        columns.Add("name")
        Return columns
    End Function

    Public CurrentEmployee As New Employee
    
    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        Dim newEmployeeForm As New New_Employee(Me)
        newEmployeeForm.Show()
    End Sub

    Private Sub lv_employees_MouseUp(sender As Object, e As MouseEventArgs) Handles lv_employees.MouseUp
        If lv_employees.Items.Count = 0 Then
            Return
        End If
        If e.Button = MouseButtons.Right Then
            If lv_employees.FocusedItem.Bounds.Contains(e.Location) Then
                cm_list.Show(Cursor.Position)
                If lv_employees.SelectedItems.Count > 1 Then
                    cmi_show.Visible = False
                    cmi_update.Visible = False
                    cmi_overrides.Visible = False
                    cmi_dtr.Visible = False
                Else
                    cmi_show.Visible = True
                    cmi_update.Visible = True
                    cmi_overrides.Visible = True
                    cmi_dtr.Visible = True
                End If
            End If
        End If

    End Sub

    Private Sub cmi_update_Click(sender As Object, e As EventArgs) Handles cmi_update.Click
        For Each item As ListViewItem In lv_employees.SelectedItems
            Dim employee As Employee = employee.FindByEmployeeNo(item.Text)
            Dim updateForm As New Update_Employee_1(Me, employee)
            updateForm.Show()
        Next
    End Sub

    Private Sub cmi_remove_Click(sender As Object, e As EventArgs) Handles cmi_remove.Click
        Dim confirm As Integer = MessageBox.Show("Remove/Disable " & lv_employees.SelectedItems.Count & " Selected Items?", "Remove/Disable", MessageBoxButtons.YesNo)
        If confirm = DialogResult.Yes Then
            Dim ids(lv_employees.SelectedItems.Count) As String
            Dim i = 0
            For Each item As ListViewItem In lv_employees.SelectedItems
                ids(i) = item.Text
                i += 1
            Next
            ReDim Preserve ids(ids.GetUpperBound(0) - 1)
            Dim ids_str As String = String.Join("','", ids)

            Database.DB.Execute("UPDATE employee SET disabled_dt = Now() WHERE employee_no IN ('" & ids_str & "')")

            CanYou.Please.PopulateList(lv_employees, QueryForEmployeeList(), ColumnsForEmployeeList())
        End If
    End Sub


    Private Sub cmi_show_Click(sender As Object, e As EventArgs) Handles cmi_show.Click
        For Each item As ListViewItem In lv_employees.SelectedItems
            Dim employee As Employee = employee.FindByEmployeeNo(item.Text)
            Dim showEmployee As New Show_Employee(employee, Me)
            showEmployee.Show()
        Next
    End Sub



    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        CanYou.Please.PopulateList(lv_employees, QueryForEmployeeList(), ColumnsForEmployeeList())
    End Sub

    Private Sub List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_currentuser.Text = currentUser.name
        CanYou.Please.PopulateList(lv_employees, QueryForEmployeeList(), ColumnsForEmployeeList())
        Me.Height = My.Computer.Screen.Bounds.Height
        Office.LoadOfficesToComboBox(Offices, cbo_division)
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Dim tk As New Time_Keeping
        tk.Show()
        Me.Hide()
    End Sub

    Private Sub btn_manageOffices_Click(sender As Object, e As EventArgs) Handles btn_manageOffices.Click
        Dim manageOffices As New ManageOffices(Me)
        manageOffices.Show()
    End Sub

    Private Sub cmi_overrides_Click(sender As Object, e As EventArgs) Handles cmi_overrides.Click
        For Each item As ListViewItem In lv_employees.SelectedItems
            Dim employee As Employee = employee.FindByEmployeeNo(item.Text)
            Dim override As New Override(Me, employee)
            override.Show()
        Next
    End Sub


    Private Sub cmi_dtr_Click(sender As Object, e As EventArgs) Handles cmi_dtr.Click
        For Each item As ListViewItem In lv_employees.SelectedItems
            Dim employee As Employee = employee.FindByEmployeeNo(item.Text)
            Dim dtr As New TimeCard(Me, employee)
            dtr.Show()
        Next
    End Sub

    Private Sub btn_verify_employee_Click(sender As Object, e As EventArgs) Handles btn_verify_employee.Click
        Dim verify = New VerifyEmployee
        verify.Show()
    End Sub
End Class
