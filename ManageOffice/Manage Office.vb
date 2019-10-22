Public Class ManageOffices
    Inherits MetroFramework.Forms.MetroForm
    Private _Caller As List

    Sub New(caller As List)
        InitializeComponent()
        _Caller = caller
        CanYou.Please.PopulateList(lv_offices, "SELECT * FROM office", ColumnsForOfficeList())
        FormNewOffice()

    End Sub

    Function ColumnsForOfficeList()
        Dim columns As New Collection
        columns.Add("id")
        columns.Add("name")
        columns.Add("signatory")
        columns.Add("signatory_position")
        Return columns
    End Function


    Private Sub lv_offices_MouseUp(sender As Object, e As MouseEventArgs) Handles lv_offices.MouseUp
        If lv_offices.Items.Count = 0 Then
            Return
        End If
        If e.Button = MouseButtons.Right Then
            If lv_offices.FocusedItem.Bounds.Contains(e.Location) Then
                cm_offices.Show(Cursor.Position)
                If lv_offices.SelectedItems.Count > 1 Then
                    cmi_update.Visible = False
                Else
                    cmi_update.Visible = True
                End If
            End If
        End If
    End Sub


    Private Sub cmi_update_Click(sender As Object, e As EventArgs) Handles cmi_update.Click
        For Each item As ListViewItem In lv_offices.SelectedItems
            Dim office As Office = office.FindById(item.Text)
            FormUpdateOffice(office)
        Next
    End Sub



    Private CurrentOffice As Office = Nothing

    Sub FormNewOffice()
        CurrentOffice = Nothing
        txt_officeName.Text = Nothing
        txt_signatory.Text = Nothing
        txt_signatory_position.Text = Nothing
        btn_cancel.Visible = False
        lbl_formstate.Text = "Create New Office"

    End Sub

    Sub FormUpdateOffice(office As Office)
        CurrentOffice = office
        txt_officeName.Text = office.Name
        txt_signatory.Text = office.Signatory
        txt_signatory_position.Text = office.SignatoryPosition
        btn_cancel.Visible = True
        lbl_formstate.Text = "Update Office"
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click

        FormNewOffice()
    End Sub

    Private Sub cmi_delete_Click(sender As Object, e As EventArgs) Handles cmi_delete.Click
        Dim confirm As Integer = MessageBox.Show("Delete " & lv_offices.SelectedItems.Count & " Selected Items?", "Delete", MessageBoxButtons.YesNo)
        If confirm = DialogResult.Yes Then
            Dim ids(lv_offices.SelectedItems.Count) As String
            Dim i = 0
            For Each item As ListViewItem In lv_offices.SelectedItems
                ids(i) = item.Text
                i += 1
            Next
            ReDim Preserve ids(ids.GetUpperBound(0) - 1)
            Dim ids_str As String = String.Join("','", ids)
            Database.DB.Execute("DELETE FROM office WHERE id IN ('" & ids_str & "')")

            CanYou.Please.PopulateList(lv_offices, "SELECT * FROM office", ColumnsForOfficeList())
        End If
    End Sub

    Private Sub btn_newOffice_Click(sender As Object, e As EventArgs) Handles btn_newOffice.Click
        If txt_officeName.Text = "" Or txt_signatory.Text = "" Or txt_signatory_position.Text = "" Then
            MsgBox("Please Provide Office Name, Signatory, and Signatory Position")
            Return
        End If

        If CurrentOffice Is Nothing Then
            Database.DB.Execute("INSERT INTO office VALUES(null,'" & txt_officeName.Text & "','" & txt_signatory.Text & "','" & txt_signatory_position.Text & "')")
        Else
            Database.DB.Execute("UPDATE office SET name = '" & txt_officeName.Text & "', signatory = '" & txt_signatory.Text & "' , signatory_position = '" & txt_signatory_position.Text & "' WHERE id = ' " & CurrentOffice.ID & "'")
        End If

        
        CanYou.Please.PopulateList(lv_offices, "SELECT * FROM office", ColumnsForOfficeList())
        Time_Keeper.Office.Offices = Office.GetAllOffices
        Dim offices As Collection = Time_Keeper.Office.Offices
        offices.Add(Time_Keeper.Office.GetBlankForShowAll)
        Office.LoadOfficesToComboBox(offices, _Caller.cbo_division)
        FormNewOffice()
    End Sub
End Class