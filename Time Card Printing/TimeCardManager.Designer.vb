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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(367, 63)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(462, 611)
        Me.DataGridView1.TabIndex = 0
        '
        'lbl_employee_name
        '
        Me.lbl_employee_name.AutoSize = True
        Me.lbl_employee_name.Location = New System.Drawing.Point(23, 63)
        Me.lbl_employee_name.Name = "lbl_employee_name"
        Me.lbl_employee_name.Size = New System.Drawing.Size(128, 13)
        Me.lbl_employee_name.TabIndex = 1
        Me.lbl_employee_name.Text = "Kevin Porferio D. Cainday"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(326, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'lbl_employee_position
        '
        Me.lbl_employee_position.AutoSize = True
        Me.lbl_employee_position.Location = New System.Drawing.Point(23, 86)
        Me.lbl_employee_position.Name = "lbl_employee_position"
        Me.lbl_employee_position.Size = New System.Drawing.Size(66, 13)
        Me.lbl_employee_position.TabIndex = 3
        Me.lbl_employee_position.Text = "I.T. Officer 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(317, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Position"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(326, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Office"
        '
        'lbl_employee_office
        '
        Me.lbl_employee_office.AutoSize = True
        Me.lbl_employee_office.Location = New System.Drawing.Point(23, 112)
        Me.lbl_employee_office.Name = "lbl_employee_office"
        Me.lbl_employee_office.Size = New System.Drawing.Size(72, 13)
        Me.lbl_employee_office.TabIndex = 6
        Me.lbl_employee_office.Text = "NVBSP - IMU"
        '
        'cb_year
        '
        Me.cb_year.FormattingEnabled = True
        Me.cb_year.Location = New System.Drawing.Point(249, 161)
        Me.cb_year.Name = "cb_year"
        Me.cb_year.Size = New System.Drawing.Size(112, 21)
        Me.cb_year.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "DTR Year"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Month"
        '
        'cb_month
        '
        Me.cb_month.FormattingEnabled = True
        Me.cb_month.Location = New System.Drawing.Point(249, 198)
        Me.cb_month.Name = "cb_month"
        Me.cb_month.Size = New System.Drawing.Size(112, 21)
        Me.cb_month.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 237)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Cut-off"
        '
        'cb_cutoff
        '
        Me.cb_cutoff.FormattingEnabled = True
        Me.cb_cutoff.Location = New System.Drawing.Point(249, 234)
        Me.cb_cutoff.Name = "cb_cutoff"
        Me.cb_cutoff.Size = New System.Drawing.Size(112, 21)
        Me.cb_cutoff.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 584)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Signatory"
        '
        'txt_signatory
        '
        Me.txt_signatory.Location = New System.Drawing.Point(211, 581)
        Me.txt_signatory.Name = "txt_signatory"
        Me.txt_signatory.Size = New System.Drawing.Size(150, 20)
        Me.txt_signatory.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(23, 618)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Position"
        '
        'txt_position
        '
        Me.txt_position.Location = New System.Drawing.Point(211, 615)
        Me.txt_position.Name = "txt_position"
        Me.txt_position.Size = New System.Drawing.Size(150, 20)
        Me.txt_position.TabIndex = 18
        '
        'txt_holidays
        '
        Me.txt_holidays.Location = New System.Drawing.Point(211, 275)
        Me.txt_holidays.Name = "txt_holidays"
        Me.txt_holidays.Size = New System.Drawing.Size(150, 20)
        Me.txt_holidays.TabIndex = 20
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 278)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Holidays"
        '
        'txt_holidays_no_remarks
        '
        Me.txt_holidays_no_remarks.Location = New System.Drawing.Point(211, 313)
        Me.txt_holidays_no_remarks.Name = "txt_holidays_no_remarks"
        Me.txt_holidays_no_remarks.Size = New System.Drawing.Size(150, 20)
        Me.txt_holidays_no_remarks.TabIndex = 22
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(23, 316)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(115, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Holidays (No Remarks)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(23, 354)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 13)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Show O.T. Remarks"
        '
        'txt_absents
        '
        Me.txt_absents.Location = New System.Drawing.Point(211, 389)
        Me.txt_absents.Name = "txt_absents"
        Me.txt_absents.Size = New System.Drawing.Size(150, 20)
        Me.txt_absents.TabIndex = 26
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(23, 392)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Absents"
        '
        'txt_off
        '
        Me.txt_off.Location = New System.Drawing.Point(211, 425)
        Me.txt_off.Name = "txt_off"
        Me.txt_off.Size = New System.Drawing.Size(150, 20)
        Me.txt_off.TabIndex = 28
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(23, 428)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 13)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "Off Duties"
        '
        'txt_halfdays
        '
        Me.txt_halfdays.Location = New System.Drawing.Point(211, 467)
        Me.txt_halfdays.Name = "txt_halfdays"
        Me.txt_halfdays.Size = New System.Drawing.Size(150, 20)
        Me.txt_halfdays.TabIndex = 30
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(23, 470)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 13)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Half Days"
        '
        'txt_clear_entries
        '
        Me.txt_clear_entries.Location = New System.Drawing.Point(211, 506)
        Me.txt_clear_entries.Name = "txt_clear_entries"
        Me.txt_clear_entries.Size = New System.Drawing.Size(150, 20)
        Me.txt_clear_entries.TabIndex = 32
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(23, 509)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 13)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Clear Entries"
        '
        'txt_shifting_days
        '
        Me.txt_shifting_days.Location = New System.Drawing.Point(211, 543)
        Me.txt_shifting_days.Name = "txt_shifting_days"
        Me.txt_shifting_days.Size = New System.Drawing.Size(150, 20)
        Me.txt_shifting_days.TabIndex = 34
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(23, 546)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 13)
        Me.Label20.TabIndex = 33
        Me.Label20.Text = "Shifting Days"
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(286, 651)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 35
        Me.btn_cancel.Text = "Clear"
        Me.btn_cancel.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(195, 651)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 36
        Me.MetroButton1.Text = "Save"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(211, 353)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(44, 17)
        Me.CheckBox1.TabIndex = 37
        Me.CheckBox1.Text = "Yes"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TimeCardManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 700)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.MetroButton1)
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
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "TimeCardManager"
        Me.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow
        Me.Text = "Manage Time Cards"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
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
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents CheckBox1 As CheckBox
End Class
