<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class List
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(List))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txt_fname = New MetroFramework.Controls.MetroTextBox()
        Me.txt_mname = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txt_lname = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.btn_search = New MetroFramework.Controls.MetroButton()
        Me.btn_register = New MetroFramework.Controls.MetroButton()
        Me.txt_employee_no = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.cbo_division = New MetroFramework.Controls.MetroComboBox()
        Me.lv_employees = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.cm_list = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmi_show = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmi_update = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmi_overrides = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmi_dtr = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmi_remove = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_currentuser = New MetroFramework.Controls.MetroLabel()
        Me.btn_logout = New MetroFramework.Controls.MetroButton()
        Me.btn_manageOffices = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.cbo_gender = New MetroFramework.Controls.MetroComboBox()
        Me.cbo_position = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.btn_verify_employee = New MetroFramework.Controls.MetroButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cm_list.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(142, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 35)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 203)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "First Name"
        '
        'txt_fname
        '
        Me.txt_fname.Location = New System.Drawing.Point(23, 225)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(163, 23)
        Me.txt_fname.TabIndex = 3
        '
        'txt_mname
        '
        Me.txt_mname.Location = New System.Drawing.Point(23, 273)
        Me.txt_mname.Name = "txt_mname"
        Me.txt_mname.Size = New System.Drawing.Size(163, 23)
        Me.txt_mname.TabIndex = 5
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 251)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(90, 19)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Middle Name"
        '
        'txt_lname
        '
        Me.txt_lname.Location = New System.Drawing.Point(23, 321)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(163, 23)
        Me.txt_lname.TabIndex = 7
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 299)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "Last Name"
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(23, 469)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 23)
        Me.btn_search.TabIndex = 8
        Me.btn_search.Text = "Search"
        Me.btn_search.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'btn_register
        '
        Me.btn_register.Location = New System.Drawing.Point(23, 513)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(162, 23)
        Me.btn_register.TabIndex = 9
        Me.btn_register.Text = "New Employee"
        '
        'txt_employee_no
        '
        Me.txt_employee_no.Location = New System.Drawing.Point(23, 177)
        Me.txt_employee_no.Name = "txt_employee_no"
        Me.txt_employee_no.Size = New System.Drawing.Size(163, 23)
        Me.txt_employee_no.TabIndex = 11
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(23, 155)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(120, 19)
        Me.MetroLabel4.TabIndex = 10
        Me.MetroLabel4.Text = "Employee Number"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(23, 101)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(53, 19)
        Me.MetroLabel5.TabIndex = 12
        Me.MetroLabel5.Text = "Division"
        '
        'cbo_division
        '
        Me.cbo_division.FormattingEnabled = True
        Me.cbo_division.ItemHeight = 23
        Me.cbo_division.Location = New System.Drawing.Point(23, 123)
        Me.cbo_division.Name = "cbo_division"
        Me.cbo_division.Size = New System.Drawing.Size(163, 29)
        Me.cbo_division.TabIndex = 14
        '
        'lv_employees
        '
        Me.lv_employees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lv_employees.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lv_employees.FullRowSelect = True
        Me.lv_employees.GridLines = True
        Me.lv_employees.Location = New System.Drawing.Point(213, 101)
        Me.lv_employees.Name = "lv_employees"
        Me.lv_employees.Size = New System.Drawing.Size(923, 687)
        Me.lv_employees.TabIndex = 15
        Me.lv_employees.UseCompatibleStateImageBehavior = False
        Me.lv_employees.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Employee No."
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "First Name"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Middle Name"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Last Name"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Gender"
        Me.ColumnHeader5.Width = 50
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Birth Date"
        Me.ColumnHeader6.Width = 80
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Position"
        Me.ColumnHeader7.Width = 200
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Office/Division"
        Me.ColumnHeader8.Width = 200
        '
        'cm_list
        '
        Me.cm_list.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmi_show, Me.cmi_update, Me.cmi_overrides, Me.cmi_dtr, Me.cmi_remove})
        Me.cm_list.Name = "cm_list"
        Me.cm_list.Size = New System.Drawing.Size(170, 114)
        Me.cm_list.Text = "Edit Record"
        '
        'cmi_show
        '
        Me.cmi_show.Name = "cmi_show"
        Me.cmi_show.Size = New System.Drawing.Size(169, 22)
        Me.cmi_show.Text = "Show"
        '
        'cmi_update
        '
        Me.cmi_update.Name = "cmi_update"
        Me.cmi_update.Size = New System.Drawing.Size(169, 22)
        Me.cmi_update.Text = "Update"
        '
        'cmi_overrides
        '
        Me.cmi_overrides.Name = "cmi_overrides"
        Me.cmi_overrides.Size = New System.Drawing.Size(169, 22)
        Me.cmi_overrides.Text = "Override"
        '
        'cmi_dtr
        '
        Me.cmi_dtr.Name = "cmi_dtr"
        Me.cmi_dtr.Size = New System.Drawing.Size(169, 22)
        Me.cmi_dtr.Text = "Print Time Record"
        '
        'cmi_remove
        '
        Me.cmi_remove.Name = "cmi_remove"
        Me.cmi_remove.Size = New System.Drawing.Size(169, 22)
        Me.cmi_remove.Text = "Remove/Disable"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(824, 36)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(84, 19)
        Me.MetroLabel6.TabIndex = 16
        Me.MetroLabel6.Text = "Logged In as"
        '
        'lbl_currentuser
        '
        Me.lbl_currentuser.AutoSize = True
        Me.lbl_currentuser.Location = New System.Drawing.Point(934, 36)
        Me.lbl_currentuser.Name = "lbl_currentuser"
        Me.lbl_currentuser.Size = New System.Drawing.Size(69, 19)
        Me.lbl_currentuser.TabIndex = 17
        Me.lbl_currentuser.Text = "Full Name"
        '
        'btn_logout
        '
        Me.btn_logout.Location = New System.Drawing.Point(1054, 72)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(82, 23)
        Me.btn_logout.TabIndex = 18
        Me.btn_logout.Text = "Logout"
        '
        'btn_manageOffices
        '
        Me.btn_manageOffices.Location = New System.Drawing.Point(23, 542)
        Me.btn_manageOffices.Name = "btn_manageOffices"
        Me.btn_manageOffices.Size = New System.Drawing.Size(162, 23)
        Me.btn_manageOffices.TabIndex = 19
        Me.btn_manageOffices.Text = "Manage Offices"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(23, 347)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel7.TabIndex = 20
        Me.MetroLabel7.Text = "Gender"
        '
        'cbo_gender
        '
        Me.cbo_gender.FormattingEnabled = True
        Me.cbo_gender.ItemHeight = 23
        Me.cbo_gender.Items.AddRange(New Object() {"Male", "Female", "Show All"})
        Me.cbo_gender.Location = New System.Drawing.Point(23, 369)
        Me.cbo_gender.Name = "cbo_gender"
        Me.cbo_gender.Size = New System.Drawing.Size(163, 29)
        Me.cbo_gender.TabIndex = 22
        '
        'cbo_position
        '
        Me.cbo_position.FormattingEnabled = True
        Me.cbo_position.ItemHeight = 23
        Me.cbo_position.Location = New System.Drawing.Point(24, 423)
        Me.cbo_position.Name = "cbo_position"
        Me.cbo_position.Size = New System.Drawing.Size(163, 29)
        Me.cbo_position.TabIndex = 24
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(24, 401)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(54, 19)
        Me.MetroLabel8.TabIndex = 23
        Me.MetroLabel8.Text = "Position"
        '
        'btn_verify_employee
        '
        Me.btn_verify_employee.Location = New System.Drawing.Point(24, 571)
        Me.btn_verify_employee.Name = "btn_verify_employee"
        Me.btn_verify_employee.Size = New System.Drawing.Size(162, 23)
        Me.btn_verify_employee.TabIndex = 25
        Me.btn_verify_employee.Text = "Verify Employee"
        '
        'List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1159, 788)
        Me.Controls.Add(Me.btn_verify_employee)
        Me.Controls.Add(Me.cbo_position)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.cbo_gender)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.btn_manageOffices)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.lbl_currentuser)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.lv_employees)
        Me.Controls.Add(Me.cbo_division)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.txt_employee_no)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.btn_register)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.txt_lname)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txt_mname)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.txt_fname)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "List"
        Me.Resizable = false
        Me.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Employees"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.cm_list.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_fname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_mname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_lname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_search As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_register As MetroFramework.Controls.MetroButton
    Friend WithEvents txt_employee_no As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbo_division As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lv_employees As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cm_list As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmi_show As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmi_update As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmi_remove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_currentuser As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_logout As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_manageOffices As MetroFramework.Controls.MetroButton
    Friend WithEvents cmi_overrides As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmi_dtr As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbo_gender As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbo_position As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_verify_employee As MetroFramework.Controls.MetroButton
End Class
