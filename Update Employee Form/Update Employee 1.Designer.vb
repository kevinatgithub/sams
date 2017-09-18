<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update_Employee_1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Update_Employee_1))
        Me.cbo_position = New MetroFramework.Controls.MetroComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_next = New MetroFramework.Controls.MetroButton()
        Me.btn_cancel = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.cbo_office_id = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.txt_address = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.dt_dob = New System.Windows.Forms.DateTimePicker()
        Me.cbo_gender = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txt_mname = New MetroFramework.Controls.MetroTextBox()
        Me.txt_lname = New MetroFramework.Controls.MetroTextBox()
        Me.txt_fname = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txt_employee_no = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'cbo_position
        '
        Me.cbo_position.FormattingEnabled = True
        Me.cbo_position.ItemHeight = 23
        Me.cbo_position.Location = New System.Drawing.Point(175, 346)
        Me.cbo_position.Name = "cbo_position"
        Me.cbo_position.Size = New System.Drawing.Size(299, 29)
        Me.cbo_position.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(153, 358)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 20)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(153, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 20)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(153, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 20)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(153, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 20)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(153, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 20)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "*"
        '
        'btn_next
        '
        Me.btn_next.Location = New System.Drawing.Point(318, 426)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(75, 23)
        Me.btn_next.TabIndex = 40
        Me.btn_next.Text = "Next"
        Me.btn_next.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(399, 426)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 42
        Me.btn_cancel.Text = "Cancel"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(84, 358)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(55, 19)
        Me.MetroLabel9.TabIndex = 45
        Me.MetroLabel9.Text = "Position"
        '
        'cbo_office_id
        '
        Me.cbo_office_id.FormattingEnabled = True
        Me.cbo_office_id.ItemHeight = 23
        Me.cbo_office_id.Location = New System.Drawing.Point(175, 311)
        Me.cbo_office_id.Name = "cbo_office_id"
        Me.cbo_office_id.Size = New System.Drawing.Size(300, 29)
        Me.cbo_office_id.TabIndex = 38
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(48, 321)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(93, 19)
        Me.MetroLabel8.TabIndex = 44
        Me.MetroLabel8.Text = "Office/Division"
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(175, 280)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(299, 23)
        Me.txt_address.TabIndex = 36
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(84, 285)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel7.TabIndex = 43
        Me.MetroLabel7.Text = "Address"
        '
        'dt_dob
        '
        Me.dt_dob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_dob.Location = New System.Drawing.Point(174, 254)
        Me.dt_dob.Name = "dt_dob"
        Me.dt_dob.Size = New System.Drawing.Size(300, 20)
        Me.dt_dob.TabIndex = 34
        '
        'cbo_gender
        '
        Me.cbo_gender.FormattingEnabled = True
        Me.cbo_gender.ItemHeight = 23
        Me.cbo_gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbo_gender.Location = New System.Drawing.Point(174, 216)
        Me.cbo_gender.Name = "cbo_gender"
        Me.cbo_gender.Size = New System.Drawing.Size(300, 29)
        Me.cbo_gender.TabIndex = 33
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(73, 255)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel6.TabIndex = 41
        Me.MetroLabel6.Text = "Birth Date"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(88, 226)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel5.TabIndex = 39
        Me.MetroLabel5.Text = "Gender"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(69, 191)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel4.TabIndex = 37
        Me.MetroLabel4.Text = "Last Name"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(50, 162)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(90, 19)
        Me.MetroLabel3.TabIndex = 35
        Me.MetroLabel3.Text = "Middle Name"
        '
        'txt_mname
        '
        Me.txt_mname.Location = New System.Drawing.Point(174, 158)
        Me.txt_mname.Name = "txt_mname"
        Me.txt_mname.PromptText = "Middle Name"
        Me.txt_mname.Size = New System.Drawing.Size(300, 23)
        Me.txt_mname.TabIndex = 31
        '
        'txt_lname
        '
        Me.txt_lname.Location = New System.Drawing.Point(174, 187)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.PromptText = "Last Name"
        Me.txt_lname.Size = New System.Drawing.Size(300, 23)
        Me.txt_lname.TabIndex = 32
        '
        'txt_fname
        '
        Me.txt_fname.Location = New System.Drawing.Point(174, 129)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.PromptText = "First Name"
        Me.txt_fname.Size = New System.Drawing.Size(300, 23)
        Me.txt_fname.TabIndex = 30
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(67, 129)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel2.TabIndex = 29
        Me.MetroLabel2.Text = "First Name"
        '
        'txt_employee_no
        '
        Me.txt_employee_no.Location = New System.Drawing.Point(174, 93)
        Me.txt_employee_no.Name = "txt_employee_no"
        Me.txt_employee_no.PromptText = "Employee No."
        Me.txt_employee_no.ReadOnly = True
        Me.txt_employee_no.Size = New System.Drawing.Size(300, 23)
        Me.txt_employee_no.TabIndex = 28
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(48, 97)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(92, 19)
        Me.MetroLabel1.TabIndex = 27
        Me.MetroLabel1.Text = "Employee No."
        '
        'Update_Employee_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(523, 480)
        Me.Controls.Add(Me.cbo_position)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.cbo_office_id)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.dt_dob)
        Me.Controls.Add(Me.cbo_gender)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txt_mname)
        Me.Controls.Add(Me.txt_lname)
        Me.Controls.Add(Me.txt_fname)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.txt_employee_no)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Update_Employee_1"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Update Employee (Step 1 of 4)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbo_position As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_next As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_cancel As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbo_office_id As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_address As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dt_dob As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbo_gender As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_mname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_lname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_fname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_employee_no As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
