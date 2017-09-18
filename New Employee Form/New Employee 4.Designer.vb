<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Employee_4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(New_Employee_4))
        Me.btn_back = New MetroFramework.Controls.MetroButton()
        Me.btn_save = New MetroFramework.Controls.MetroButton()
        Me.btn_cancel = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_employee_no = New MetroFramework.Controls.MetroLabel()
        Me.lbl_name = New MetroFramework.Controls.MetroLabel()
        Me.lbl_position = New MetroFramework.Controls.MetroLabel()
        Me.lbl_department = New MetroFramework.Controls.MetroLabel()
        Me.pb_profile = New System.Windows.Forms.PictureBox()
        Me.pb_left_ok = New System.Windows.Forms.PictureBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.pb_right_ok = New System.Windows.Forms.PictureBox()
        Me.pb_left_not_ok = New System.Windows.Forms.PictureBox()
        Me.pb_right_not_ok = New System.Windows.Forms.PictureBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_gender = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_dob = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_address = New MetroFramework.Controls.MetroLabel()
        CType(Me.pb_profile,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pb_left_ok,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pb_right_ok,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pb_left_not_ok,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pb_right_not_ok,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(395, 416)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 31
        Me.btn_back.Text = "Back"
        Me.btn_back.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(476, 416)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 30
        Me.btn_save.Text = "Save"
        Me.btn_save.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(557, 416)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 29
        Me.btn_cancel.Text = "Cancel"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel1.Location = New System.Drawing.Point(20, 122)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(78, 15)
        Me.MetroLabel1.TabIndex = 32
        Me.MetroLabel1.Text = "Employee No."
        '
        'lbl_employee_no
        '
        Me.lbl_employee_no.AutoSize = True
        Me.lbl_employee_no.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lbl_employee_no.Location = New System.Drawing.Point(121, 122)
        Me.lbl_employee_no.Name = "lbl_employee_no"
        Me.lbl_employee_no.Size = New System.Drawing.Size(48, 15)
        Me.lbl_employee_no.TabIndex = 33
        Me.lbl_employee_no.Text = "12 - 456"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbl_name.Location = New System.Drawing.Point(20, 88)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(126, 25)
        Me.lbl_name.TabIndex = 35
        Me.lbl_name.Text = "Juan Dela Cruz"
        '
        'lbl_position
        '
        Me.lbl_position.AutoSize = True
        Me.lbl_position.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lbl_position.Location = New System.Drawing.Point(121, 152)
        Me.lbl_position.Name = "lbl_position"
        Me.lbl_position.Size = New System.Drawing.Size(66, 15)
        Me.lbl_position.TabIndex = 37
        Me.lbl_position.Text = "I.T. Officer 1"
        '
        'lbl_department
        '
        Me.lbl_department.AutoSize = True
        Me.lbl_department.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lbl_department.Location = New System.Drawing.Point(121, 178)
        Me.lbl_department.Name = "lbl_department"
        Me.lbl_department.Size = New System.Drawing.Size(75, 15)
        Me.lbl_department.TabIndex = 39
        Me.lbl_department.Text = "NVBSP - IMU"
        '
        'pb_profile
        '
        Me.pb_profile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_profile.Location = New System.Drawing.Point(432, 88)
        Me.pb_profile.Name = "pb_profile"
        Me.pb_profile.Size = New System.Drawing.Size(200, 200)
        Me.pb_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_profile.TabIndex = 40
        Me.pb_profile.TabStop = False
        '
        'pb_left_ok
        '
        Me.pb_left_ok.Image = CType(resources.GetObject("pb_left_ok.Image"), System.Drawing.Image)
        Me.pb_left_ok.Location = New System.Drawing.Point(427, 299)
        Me.pb_left_ok.Name = "pb_left_ok"
        Me.pb_left_ok.Size = New System.Drawing.Size(24, 24)
        Me.pb_left_ok.TabIndex = 41
        Me.pb_left_ok.TabStop = False
        Me.pb_left_ok.Visible = False
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(457, 304)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(102, 19)
        Me.MetroLabel9.TabIndex = 42
        Me.MetroLabel9.Text = "Left Finger Print"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(457, 323)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(111, 19)
        Me.MetroLabel10.TabIndex = 44
        Me.MetroLabel10.Text = "Right Finger Print"
        '
        'pb_right_ok
        '
        Me.pb_right_ok.Image = CType(resources.GetObject("pb_right_ok.Image"), System.Drawing.Image)
        Me.pb_right_ok.Location = New System.Drawing.Point(427, 318)
        Me.pb_right_ok.Name = "pb_right_ok"
        Me.pb_right_ok.Size = New System.Drawing.Size(24, 24)
        Me.pb_right_ok.TabIndex = 43
        Me.pb_right_ok.TabStop = False
        Me.pb_right_ok.Visible = False
        '
        'pb_left_not_ok
        '
        Me.pb_left_not_ok.Image = CType(resources.GetObject("pb_left_not_ok.Image"), System.Drawing.Image)
        Me.pb_left_not_ok.Location = New System.Drawing.Point(435, 304)
        Me.pb_left_not_ok.Name = "pb_left_not_ok"
        Me.pb_left_not_ok.Size = New System.Drawing.Size(16, 16)
        Me.pb_left_not_ok.TabIndex = 45
        Me.pb_left_not_ok.TabStop = False
        Me.pb_left_not_ok.Visible = False
        '
        'pb_right_not_ok
        '
        Me.pb_right_not_ok.Image = CType(resources.GetObject("pb_right_not_ok.Image"), System.Drawing.Image)
        Me.pb_right_not_ok.Location = New System.Drawing.Point(435, 326)
        Me.pb_right_not_ok.Name = "pb_right_not_ok"
        Me.pb_right_not_ok.Size = New System.Drawing.Size(16, 16)
        Me.pb_right_not_ok.TabIndex = 46
        Me.pb_right_not_ok.TabStop = False
        Me.pb_right_not_ok.Visible = False
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel2.Location = New System.Drawing.Point(20, 152)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(47, 15)
        Me.MetroLabel2.TabIndex = 47
        Me.MetroLabel2.Text = "Position"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel3.Location = New System.Drawing.Point(20, 178)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(76, 15)
        Me.MetroLabel3.TabIndex = 48
        Me.MetroLabel3.Text = "Office/Division"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.Location = New System.Drawing.Point(20, 206)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(44, 15)
        Me.MetroLabel4.TabIndex = 50
        Me.MetroLabel4.Text = "Gender"
        '
        'lbl_gender
        '
        Me.lbl_gender.AutoSize = True
        Me.lbl_gender.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lbl_gender.Location = New System.Drawing.Point(121, 206)
        Me.lbl_gender.Name = "lbl_gender"
        Me.lbl_gender.Size = New System.Drawing.Size(75, 15)
        Me.lbl_gender.TabIndex = 49
        Me.lbl_gender.Text = "NVBSP - IMU"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel6.Location = New System.Drawing.Point(20, 234)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(57, 15)
        Me.MetroLabel6.TabIndex = 52
        Me.MetroLabel6.Text = "Birth Date"
        '
        'lbl_dob
        '
        Me.lbl_dob.AutoSize = True
        Me.lbl_dob.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lbl_dob.Location = New System.Drawing.Point(121, 234)
        Me.lbl_dob.Name = "lbl_dob"
        Me.lbl_dob.Size = New System.Drawing.Size(75, 15)
        Me.lbl_dob.TabIndex = 51
        Me.lbl_dob.Text = "NVBSP - IMU"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel8.Location = New System.Drawing.Point(20, 262)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(49, 15)
        Me.MetroLabel8.TabIndex = 54
        Me.MetroLabel8.Text = "Address"
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lbl_address.Location = New System.Drawing.Point(121, 262)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(75, 15)
        Me.lbl_address.TabIndex = 53
        Me.lbl_address.Text = "NVBSP - IMU"
        '
        'New_Employee_4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(667, 480)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.lbl_address)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.lbl_dob)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.lbl_gender)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.pb_right_not_ok)
        Me.Controls.Add(Me.pb_left_not_ok)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.pb_right_ok)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.pb_left_ok)
        Me.Controls.Add(Me.pb_profile)
        Me.Controls.Add(Me.lbl_department)
        Me.Controls.Add(Me.lbl_position)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_employee_no)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_cancel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "New_Employee_4"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Create Employee Step 4 of 4"
        CType(Me.pb_profile,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pb_left_ok,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pb_right_ok,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pb_left_not_ok,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pb_right_not_ok,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btn_back As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_save As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_cancel As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_employee_no As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_name As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_position As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_department As MetroFramework.Controls.MetroLabel
    Friend WithEvents pb_profile As System.Windows.Forms.PictureBox
    Friend WithEvents pb_left_ok As System.Windows.Forms.PictureBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents pb_right_ok As System.Windows.Forms.PictureBox
    Friend WithEvents pb_left_not_ok As System.Windows.Forms.PictureBox
    Friend WithEvents pb_right_not_ok As System.Windows.Forms.PictureBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_gender As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_dob As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_address As MetroFramework.Controls.MetroLabel
End Class
