Imports MySql.Data.MySqlClient
Imports Time_Keeper

Public Class TimeCardManager

    Dim employee As Employee
    Dim current As State

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

    Private Function getDefaultState() As State
        Dim state = New State
        state.employee = employee
        state.year = Date.Today.Year
        state.month = Date.Today.Month
        state.cutoff = 0
        If Date.Today.Day > 15 Then
            state.cutoff = 1
        End If
        current = state
        Return state
    End Function

    Private Sub loadFormState(ByVal state As State)
        lbl_employee_name.Text = state.employee.Fname + " " + state.employee.Mname + " " + state.employee.Lname
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

    Private Class State
        Public id As Integer = 0
        Public employee As Employee
        Public year As String
        Public month As String
        Public cutoff As String
        Public holidays As String
        Public holidays_no_remarks As String
        Public show_ot_remarks As String = "Y"
        Public absents As String
        Public off_duties As String
        Public half_days As String
        Public clear_entries As String
        Public shifting_days As String
        Public signatory As String
        Public position As String
    End Class

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        loadFormState(getDefaultState())
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If current.id = 0 Then
            performSave()
        Else

        End If



    End Sub

    Private Sub performSave()
        Dim query As String = "INSERT INTO `dtr`(`id`, `employee_id`, `year`, `month`, `cutoff`, `holidays`, `holidays_no_remarks`, `show_ot_remarks`, `absents`, `off_duties`, `half_days`, `clear_entries`, `shifting_days`, `signatory`, `position`) 
        VALUES(0,@employee_id,@year,@month,@cutoff,@holidays,@holidays_no_remarks,@show_ot_remarks,@absents,@off_duties,@half_days,@clear_entries,@shifting_days,@signatory,@position)"
        Dim con As New Database
        con.OpenConnection()
        Dim command As New MySqlCommand(query, con.Connection)
        command.Parameters.AddWithValue("@employee_id", employee.Id)
        command.Parameters.AddWithValue("@year", cb_year.SelectedItem)
        command.Parameters.AddWithValue("@month", cb_month.SelectedIndex)
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

    Private select_query As String = "SELECT concat_ws(' / ',year,month) as yearmonth, 
        case
            when cutoff = 0 then '1st Cutoff'
            when cutoff = 1 then '2nd Cutoff'
            when cutoff = 2 then 'Full month'
        end as cutoff
        from dtr
        where employee_id = ?"

    Function ColumnsForDtrList()
        Dim columns As New Collection
        columns.Add("yearmonth")
        columns.Add("cutoff")
        Return columns
    End Function
End Class