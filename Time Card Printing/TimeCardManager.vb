Imports MySql.Data.MySqlClient
Imports Time_Keeper

Public Class TimeCardManager

    Dim employee As Employee
    Dim current As Dtr
    Private select_query As String = "SELECT id, concat_ws(' ',year,
            case month
                when month = 0 then 'January'
                when month = 1 then 'February'
                when month = 2 then 'March'
                when month = 3 then 'April'
                when month = 4 then 'May'
                when month = 5 then 'June'
                when month = 6 then 'July'
                when month = 7 then 'August'
                when month = 8 then 'September'
                when month = 9 then 'October'
                when month = 10 then 'November'
                when month = 11 then 'December'
            end
        ) as yearmonth, 
        case
            when cutoff = 0 then '1st Cutoff'
            when cutoff = 1 then '2nd Cutoff'
            when cutoff = 2 then 'Full month'
        end as cutoff
        from dtr
        where employee_id = ? ORDER BY id desc"

    Public Sub New(ByVal parent As List, ByVal employee As Employee)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.employee = employee

        select_query = select_query.Replace("?", employee.Id)

        Dim y = Date.Today.Year
        For i As Integer = 0 To 3
            cb_year.Items.Add(y - i)
        Next



        loadFormState(getDefaultState())
    End Sub



    Private Function getDefaultState() As Dtr
        Dim state = New Dtr
        state.employee = employee
        state.year = Date.Today.Year
        state.month = Date.Today.Month
        state.cutoff = 1
        If Date.Today.Day > 15 Then
            state.cutoff = 0
        End If
        state.signatory = employee.Office.Signatory
        state.position = employee.Office.SignatoryPosition
        current = state
        Return state
    End Function

    Private Sub loadFormState(ByVal state As Dtr)
        lbl_employee_name.Text = CanYou.HandleDBNull(state.employee.Fname) + " " + CanYou.HandleDBNull(state.employee.Mname) + " " + CanYou.HandleDBNull(state.employee.Lname)
        lbl_employee_position.Text = state.employee.Position
        lbl_employee_office.Text = state.employee.Office.Name

        cb_year.SelectedIndex = cb_year.FindStringExact(state.year)
        cb_month.SelectedIndex = state.month
        cb_cutoff.SelectedIndex = state.cutoff
        txt_holidays.Text = state.holidays
        txt_holidays_no_remarks.Text = state.holidays_no_remarks
        If state.show_ot_remarks.Equals("Y") Then
            c_show_ot_remarks.Checked = True
        End If
        txt_absents.Text = state.absents
        txt_off.Text = state.off_duties
        txt_halfdays.Text = state.half_days
        txt_clear_entries.Text = state.clear_entries
        txt_shifting_days.Text = state.shifting_days
        txt_signatory.Text = state.signatory
        txt_position.Text = state.position

        CanYou.Please.PopulateList(lv_dtrs, select_query, ColumnsForDtrList)
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        loadFormState(getDefaultState())
        lv_dtrs.Enabled = True
        lbl_state.Text = "Creating a new DTR"
        btn_save.Text = "Save"
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If current.id = 0 Then
            performSave()
        Else
            performUpdate()
            lv_dtrs.Enabled = True
            btn_save.Text = "Save"
            loadFormState(getDefaultState())
            lbl_state.Text = "Creating a new DTR"
        End If



    End Sub

    Private Sub performUpdate()
        Dim query As String = "UPDATE `dtr` SET 
            `year`=@year,`month`=@month,`cutoff`=@cutoff,`holidays`=@holidays,
            `holidays_no_remarks`=@holidays_no_remarks,`show_ot_remarks`=@show_ot_remarks,`absents`=@absents,
            `off_duties`=@off_duties,`half_days`=@half_days,`clear_entries`=@clear_entries,
            `shifting_days`=@shifting_days,`signatory`=@signatory,`position`=@position WHERE id = @id"
        Dim con As New Database
        con.OpenConnection()
        Dim command As New MySqlCommand(query, con.Connection)
        command.Parameters.AddWithValue("@year", cb_year.SelectedItem)
        command.Parameters.AddWithValue("@month", cb_month.SelectedIndex + 1)
        command.Parameters.AddWithValue("@cutoff", cb_cutoff.SelectedIndex)
        command.Parameters.AddWithValue("@holidays", txt_holidays.Text)
        command.Parameters.AddWithValue("@holidays_no_remarks", txt_holidays_no_remarks.Text)
        Dim show_ot_remarks_value = "Y"
        If Not c_show_ot_remarks.Checked Then
            show_ot_remarks_value = "N"
        End If
        command.Parameters.AddWithValue("@show_ot_remarks", show_ot_remarks_value)
        command.Parameters.AddWithValue("@absents", txt_absents.Text)
        command.Parameters.AddWithValue("@off_duties", txt_off.Text)
        command.Parameters.AddWithValue("@half_days", txt_halfdays.Text)
        command.Parameters.AddWithValue("@clear_entries", txt_clear_entries.Text)
        command.Parameters.AddWithValue("@shifting_days", txt_shifting_days.Text)
        command.Parameters.AddWithValue("@signatory", txt_signatory.Text)
        command.Parameters.AddWithValue("@position", txt_position.Text)
        command.Parameters.AddWithValue("@id", current.id)

        Try
            command.ExecuteNonQuery()
            con.CloseConnection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub performSave()
        Dim query As String = "INSERT INTO `dtr`(`id`, `employee_id`, `year`, `month`, `cutoff`, `holidays`, `holidays_no_remarks`, `show_ot_remarks`, `absents`, `off_duties`, `half_days`, `clear_entries`, `shifting_days`, `signatory`, `position`) 
        VALUES(0,@employee_id,@year,@month,@cutoff,@holidays,@holidays_no_remarks,@show_ot_remarks,@absents,@off_duties,@half_days,@clear_entries,@shifting_days,@signatory,@position)"
        Dim con As New Database
        con.OpenConnection()
        Dim command As New MySqlCommand(query, con.Connection)
        command.Parameters.AddWithValue("@employee_id", employee.Id)
        command.Parameters.AddWithValue("@year", cb_year.SelectedItem)
        command.Parameters.AddWithValue("@month", cb_month.SelectedIndex + 1)
        command.Parameters.AddWithValue("@cutoff", cb_cutoff.SelectedIndex)
        command.Parameters.AddWithValue("@holidays", txt_holidays.Text)
        command.Parameters.AddWithValue("@holidays_no_remarks", txt_holidays_no_remarks.Text)
        Dim show_ot_remarks_value = "Y"
        If Not c_show_ot_remarks.Checked Then
            show_ot_remarks_value = "N"
        End If
        command.Parameters.AddWithValue("@show_ot_remarks", show_ot_remarks_value)
        command.Parameters.AddWithValue("@absents", txt_absents.Text)
        command.Parameters.AddWithValue("@off_duties", txt_off.Text)
        command.Parameters.AddWithValue("@half_days", txt_halfdays.Text)
        command.Parameters.AddWithValue("@clear_entries", txt_clear_entries.Text)
        command.Parameters.AddWithValue("@shifting_days", txt_shifting_days.Text)
        command.Parameters.AddWithValue("@signatory", txt_signatory.Text)
        command.Parameters.AddWithValue("@position", txt_position.Text)

        Try
            command.ExecuteNonQuery()
            con.CloseConnection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        loadFormState(getDefaultState)
    End Sub



    Function ColumnsForDtrList()
        Dim columns As New Collection
        columns.Add("id")
        columns.Add("yearmonth")
        columns.Add("cutoff")
        Return columns
    End Function

    Private Sub lv_dtrs_MouseUp(sender As Object, e As MouseEventArgs) Handles lv_dtrs.MouseUp
        If lv_dtrs.Items.Count = 0 Then
            Return
        End If
        If e.Button = MouseButtons.Right Then
            If lv_dtrs.FocusedItem.Bounds.Contains(e.Location) Then
                cm_dtr.Show(Cursor.Position)
                If lv_dtrs.SelectedItems.Count > 1 Then
                    PrintPreviewToolStripMenuItem.Visible = False
                    UpdateToolStripMenuItem.Visible = False
                Else
                    PrintPreviewToolStripMenuItem.Visible = True
                    UpdateToolStripMenuItem.Visible = True
                End If
            End If
        End If

    End Sub

    Private Sub cmi_preview_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        For Each item As ListViewItem In lv_dtrs.SelectedItems
            Dim id As Integer = item.Text
            Dim reader As MySqlDataReader = Database.DB.Execute("SELECT * FROM dtr WHERE id = " + id.ToString)
            reader.Read()
            Dim dtr As Dtr = readerAsDtr(reader)
            Dim printPreview As New PrintPreview(dtr)
            printPreview.Show()
        Next
    End Sub

    Private Sub cmi_update_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        For Each item As ListViewItem In lv_dtrs.SelectedItems
            Dim id As Integer = item.Text
            Dim reader As MySqlDataReader = Database.DB.Execute("SELECT * FROM dtr WHERE id = " + id.ToString)
            If reader.HasRows Then
                reader.Read()
                Dim state As Dtr = readerAsDtr(reader)
                current = state
                loadFormState(state)
                btn_save.Text = "Update"
                lv_dtrs.Enabled = False
                lbl_state.Text = "Updating record for DTR with ID " + state.id.ToString
            End If
        Next
    End Sub

    Private Function readerAsDtr(ByVal reader As MySqlDataReader) As Dtr
        Dim state As New Dtr
        state.id = reader("id")
        state.employee = employee
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

    Private Sub cmi_delete_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim confirm As Integer = MessageBox.Show("Delete " & lv_dtrs.SelectedItems.Count & " DTR/s?", "Delete", MessageBoxButtons.YesNo)
        If confirm = DialogResult.Yes Then
            Dim ids(lv_dtrs.SelectedItems.Count) As String
            Dim i = 0
            For Each item As ListViewItem In lv_dtrs.SelectedItems
                ids(i) = item.Text
                i += 1
            Next
            ReDim Preserve ids(ids.GetUpperBound(0) - 1)
            Dim ids_str As String = String.Join("','", ids)

            Database.DB.Execute("DELETE FROM dtr WHERE id IN ('" & ids_str & "')")

            CanYou.Please.PopulateList(lv_dtrs, select_query, ColumnsForDtrList())
        End If
    End Sub

    Private Sub lbl_state_Click(sender As Object, e As EventArgs) Handles lbl_state.Click

    End Sub
End Class