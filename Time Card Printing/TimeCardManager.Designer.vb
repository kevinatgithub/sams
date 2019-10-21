<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeCardManager
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_employee_name = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_employee_position = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_employee_office = New System.Windows.Forms.Label()
        Me.cb_year = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cb_month = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cb_cutoff = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_signatory = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_position = New System.Windows.Forms.TextBox()
        Me.txt_holidays = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_holidays_no_remarks = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_absents = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_off = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_halfdays = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_clear_entries = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_shifting_days = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btn_cancel = New MetroFramework.Controls.MetroButton()
        Me.btn_save = New MetroFramework.Controls.MetroButton()
        Me.c_show_ot_remarks = New System.Windows.Forms.CheckBox()
        Me.lv_dtrs = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lbl_employee_name
        '
        Me.lbl_employee_name.AutoSize = True
        Me.lbl_employee_name.Location = New System.Drawing.Point(31, 78)
        Me.lbl_employee_name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_employee_name.Name = "lbl_employee_name"
        Me.lbl_employee_name.Size = New System.Drawing.Size(170, 17)
        Me.lbl_employee_name.TabIndex = 1
        Me.lbl_employee_name.Text = "Kevin Porferio D. Cainday"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(435, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'lbl_employee_position
        '
        Me.lbl_employee_position.AutoSize = True
        Me.lbl_employee_position.Location = New System.Drawing.Point(31, 106)
        Me.lbl_employee_position.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_employee_position.Name = "lbl_employee_position"
        Me.lbl_employee_position.Size = New System.Drawing.Size(86, 17)
        Me.lbl_employee_position.TabIndex = 3
        Me.lbl_employee_position.Text = "I.T. Officer 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(423, 106)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Position"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(435, 138)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Office"
        '
        'lbl_employee_office
        '
        Me.lbl_employee_office.AutoSize = True
        Me.lbl_employee_office.Location = New System.Drawing.Point(31, 138)
        Me.lbl_employee_office.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_employee_office.Name = "lbl_employee_office"
        Me.lbl_employee_office.Size = New System.Drawing.Size(91, 17)
        Me.lbl_employee_office.TabIndex = 6
        Me.lbl_employee_office.Text = "NVBSP - IMU"
        '
        'cb_year
        '
        Me.cb_year.FormattingEnabled = True
        Me.cb_year.Location = New System.Drawing.Point(332, 198)
        Me.cb_year.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_year.Name = "cb_year"
        Me.cb_year.Size = New System.Drawing.Size(148, 24)
        Me.cb_year.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 202)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "DTR Year"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 244)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Month"
        '
        'cb_month
        '
        Me.cb_month.FormattingEnabled = True
        Me.cb_month.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "Jully", "August", "September", "October", "November", "December"})
        Me.cb_month.Location = New System.Drawing.Point(332, 244)
        Me.cb_month.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_month.Name = "cb_month"
        Me.cb_month.Size = New System.Drawing.Size(148, 24)
        Me.cb_month.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 292)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 17)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Cut-off"
        '
        'cb_cutoff
        '
        Me.cb_cutoff.FormattingEnabled = True
        Me.cb_cutoff.Items.AddRange(New Object() {"1st Cut-off", "2nd Cut-off", "Full Month"})
        Me.cb_cutoff.Location = New System.Drawing.Point(332, 288)
        Me.cb_cutoff.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_cutoff.Name = "cb_cutoff"
        Me.cb_cutoff.Size = New System.Drawing.Size(148, 24)
        Me.cb_cutoff.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(31, 719)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 17)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Signatory"
        '
        'txt_signatory
        '
        Me.txt_signatory.Location = New System.Drawing.Point(281, 715)
        Me.txt_signatory.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_signatory.Name = "txt_signatory"
        Me.txt_signatory.Size = New System.Drawing.Size(199, 22)
        Me.txt_signatory.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(31, 761)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 17)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Position"
        '
        'txt_position
        '
        Me.txt_position.Location = New System.Drawing.Point(281, 757)
        Me.txt_position.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_position.Name = "txt_position"
        Me.txt_position.Size = New System.Drawing.Size(199, 22)
        Me.txt_position.TabIndex = 18
        '
        'txt_holidays
        '
        Me.txt_holidays.Location = New System.Drawing.Point(281, 338)
        Me.txt_holidays.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_holidays.Name = "txt_holidays"
        Me.txt_holidays.Size = New System.Drawing.Size(199, 22)
        Me.txt_holidays.TabIndex = 20
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(31, 342)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 17)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Holidays"
        '
        'txt_holidays_no_remarks
        '
        Me.txt_holidays_no_remarks.Location = New System.Drawing.Point(281, 385)
        Me.txt_holidays_no_remarks.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_holidays_no_remarks.Name = "txt_holidays_no_remarks"
        Me.txt_holidays_no_remarks.Size = New System.Drawing.Size(199, 22)
        Me.txt_holidays_no_remarks.TabIndex = 22
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(31, 389)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(154, 17)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Holidays (No Remarks)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(31, 436)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(134, 17)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Show O.T. Remarks"
        '
        'txt_absents
        '
        Me.txt_absents.Location = New System.Drawing.Point(281, 479)
        Me.txt_absents.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_absents.Name = "txt_absents"
        Me.txt_absents.Size = New System.Drawing.Size(199, 22)
        Me.txt_absents.TabIndex = 26
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(31, 482)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 17)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Absents"
        '
        'txt_off
        '
        Me.txt_off.Location = New System.Drawing.Point(281, 523)
        Me.txt_off.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_off.Name = "txt_off"
        Me.txt_off.Size = New System.Drawing.Size(199, 22)
        Me.txt_off.TabIndex = 28
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(31, 527)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 17)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "Off Duties"
        '
        'txt_halfdays
        '
        Me.txt_halfdays.Location = New System.Drawing.Point(281, 575)
        Me.txt_halfdays.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_halfdays.Name = "txt_halfdays"
        Me.txt_halfdays.Size = New System.Drawing.Size(199, 22)
        Me.txt_halfdays.TabIndex = 30
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(31, 578)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 17)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Half Days"
        '
        'txt_clear_entries
        '
        Me.txt_clear_entries.Location = New System.Drawing.Point(281, 623)
        Me.txt_clear_entries.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_clear_entries.Name = "txt_clear_entries"
        Me.txt_clear_entries.Size = New System.Drawing.Size(199, 22)
        Me.txt_clear_entries.TabIndex = 32
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(31, 626)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 17)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Clear Entries"
        '
        'txt_shifting_days
        '
        Me.txt_shifting_days.Location = New System.Drawing.Point(281, 668)
        Me.txt_shifting_days.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_shifting_days.Name = "txt_shifting_days"
        Me.txt_shifting_days.Size = New System.Drawing.Size(199, 22)
        Me.txt_shifting_days.TabIndex = 34
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(31, 672)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(91, 17)
        Me.Label20.TabIndex = 33
        Me.Label20.Text = "Shifting Days"
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(381, 801)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(100, 28)
        Me.btn_cancel.TabIndex = 35
        Me.btn_cancel.Text = "Clear"
        Me.btn_cancel.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(260, 801)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(100, 28)
        Me.btn_save.TabIndex = 36
        Me.btn_save.Text = "Save"
        Me.btn_save.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'c_show_ot_remarks
        '
        Me.c_show_ot_remarks.AutoSize = True
        Me.c_show_ot_remarks.Location = New System.Drawing.Point(281, 434)
        Me.c_show_ot_remarks.Margin = New System.Windows.Forms.Padding(4)
        Me.c_show_ot_remarks.Name = "c_show_ot_remarks"
        Me.c_show_ot_remarks.Size = New System.Drawing.Size(54, 21)
        Me.c_show_ot_remarks.TabIndex = 37
        Me.c_show_ot_remarks.Text = "Yes"
        Me.c_show_ot_remarks.UseVisualStyleBackColor = True
        '
        'lv_dtrs
        '
        Me.lv_dtrs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lv_dtrs.GridLines = True
        Me.lv_dtrs.Location = New System.Drawing.Point(546, 78)
        Me.lv_dtrs.Name = "lv_dtrs"
        Me.lv_dtrs.Size = New System.Drawing.Size(345, 751)
        Me.lv_dtrs.TabIndex = 38
        Me.lv_dtrs.UseCompatibleStateImageBehavior = False
        Me.lv_dtrs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Year / Month"
        Me.ColumnHeader1.Width = 122
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Cutoff"
        Me.ColumnHeader2.Width = 101
        '
        'TimeCardManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 862)
        Me.Controls.Add(Me.lv_dtrs)
        Me.Controls.Add(Me.c_show_ot_remarks)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.txt_shifting_days)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txt_clear_entries)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txt_halfdays)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txt_off)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txt_absents)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_holidays_no_remarks)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt_holidays)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_position)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_signatory)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cb_cutoff)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cb_month)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cb_year)
        Me.Controls.Add(Me.lbl_employee_office)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_employee_position)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_employee_name)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "TimeCardManager"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow
        Me.Text = "Manage Time Cards"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_employee_name As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_employee_position As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_employee_office As Label
    Friend WithEvents cb_year As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cb_month As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cb_cutoff As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_signatory As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_position As TextBox
    Friend WithEvents txt_holidays As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_holidays_no_remarks As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_absents As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_off As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_halfdays As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_clear_entries As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_shifting_days As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents btn_cancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_save As MetroFramework.Controls.MetroButton
    Friend WithEvents c_show_ot_remarks As CheckBox
    Friend WithEvents lv_dtrs As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
End Class
