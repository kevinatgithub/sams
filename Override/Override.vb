Public Class Override
    Inherits MetroFramework.Forms.MetroForm

    Private Caller As List
    Private CurrentEmployee As Employee
 
    Sub New(caller As List, employee As Employee)
        InitializeComponent()
        CurrentEmployee = employee
        Me.Caller = caller
        RefreshList()

        If User.GetCurrent.ulevel = 0 Then
            item_approve.Visible = True
        Else
            item_approve.Visible = False
        End If

        lbl_employee_fullname.Text = CurrentEmployee.Fname & " " & CurrentEmployee.Mname & " " & CurrentEmployee.Lname
        lbl_office_and_position.Text = CurrentEmployee.Office.Name & " | " & CurrentEmployee.Position

    End Sub

    Public Sub RefreshList()
        CanYou.Please.PopulateList(lv_overrides, QueryForList(), ColumnsForList())
    End Sub

    Function QueryForList()
        Return "SELECT * FROM override WHERE employee_id = '" & CurrentEmployee.Id & "' AND disabled_dt IS NULL"
    End Function


    Function ColumnsForList()
        Dim columns As New Collection
        columns.Add("id")
        columns.Add("date")
        columns.Add("type")
        columns.Add("time")
        columns.Add("reason")
        columns.Add("created_by")
        columns.Add("approved_by")
        Return columns
    End Function


    Private Sub lv_overrides_MouseUp(sender As Object, e As MouseEventArgs) Handles lv_overrides.MouseUp
        If lv_overrides.Items.Count = 0 Then
            Return
        End If
        If e.Button = MouseButtons.Right Then
            If lv_overrides.FocusedItem.Bounds.Contains(e.Location) Then
                cm_overrides.Show(Cursor.Position)
                If lv_overrides.SelectedItems.Count > 1 Then
                    item_delete.Visible = False
                Else
                    item_delete.Visible = True
                End If
            End If
        End If
    End Sub



    Private Sub item_delete_Click(sender As Object, e As EventArgs) Handles item_delete.Click
        Dim confirm As Integer = MessageBox.Show("Remove/Disable Selected Item?", "Remove/Disable", MessageBoxButtons.YesNo)
        If confirm = DialogResult.Yes Then
            Dim ids(lv_overrides.SelectedItems.Count) As String
            Dim i = 0
            For Each item As ListViewItem In lv_overrides.SelectedItems
                ids(i) = item.Text
                i += 1
            Next
            ReDim Preserve ids(ids.GetUpperBound(0) - 1)
            Dim ids_str As String = String.Join("','", ids)

            Database.DB.Execute("UPDATE override SET disabled_dt = Now(), disabled_by = '" & User.GetCurrent.user_id & "' WHERE id IN ('" & ids_str & "')")

            CanYou.Please.PopulateList(lv_overrides, QueryForList(), ColumnsForList())
        End If
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        Dim form As New OverrideForm(Me, CurrentEmployee, 0)
        form.Show()
    End Sub

    Private Sub item_approve_Click(sender As Object, e As EventArgs) Handles item_approve.Click
        Dim confirm As Integer = MessageBox.Show("Approve Override Entry?", "Approve Override", MessageBoxButtons.YesNo)
        If confirm = DialogResult.Yes Then
            For Each item As ListViewItem In lv_overrides.SelectedItems
                Dim id = item.Text
                Database.DB.Execute("UPDATE override SET approved_by = '" & User.GetCurrent.user_id & "', approved_dt = now() WHERE id = '" & id & "'")

            Next
        End If
        RefreshList()
    End Sub
End Class