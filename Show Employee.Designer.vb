<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Show_Employee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Show_Employee))
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_employee_no = New MetroFramework.Controls.MetroLabel()
        Me.lbl_office = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_position = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_dob = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_gender = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_address = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_name = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.pb_pic = New System.Windows.Forms.PictureBox()
        Me.btn_update = New MetroFramework.Controls.MetroButton()
        Me.btn_disable = New MetroFramework.Controls.MetroButton()
        Me.btn_close = New MetroFramework.Controls.MetroButton()
        CType(Me.pb_pic,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = true
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(280, 125)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(118, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Employee No."
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_employee_no
        '
        Me.lbl_employee_no.AutoSize = true
        Me.lbl_employee_no.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbl_employee_no.Location = New System.Drawing.Point(468, 125)
        Me.lbl_employee_no.Name = "lbl_employee_no"
        Me.lbl_employee_no.Size = New System.Drawing.Size(0, 0)
        Me.lbl_employee_no.TabIndex = 1
        Me.lbl_employee_no.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_office
        '
        Me.lbl_office.AutoSize = True
        Me.lbl_office.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbl_office.Location = New System.Drawing.Point(468, 150)
        Me.lbl_office.Name = "lbl_office"
        Me.lbl_office.Size = New System.Drawing.Size(0, 0)
        Me.lbl_office.TabIndex = 3
        Me.lbl_office.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.Location = New System.Drawing.Point(280, 150)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(133, 25)
        Me.MetroLabel4.TabIndex = 2
        Me.MetroLabel4.Text = "Office / Division"
        Me.MetroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_position
        '
        Me.lbl_position.AutoSize = True
        Me.lbl_position.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbl_position.Location = New System.Drawing.Point(468, 175)
        Me.lbl_position.Name = "lbl_position"
        Me.lbl_position.Size = New System.Drawing.Size(0, 0)
        Me.lbl_position.TabIndex = 5
        Me.lbl_position.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.Location = New System.Drawing.Point(280, 175)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(72, 25)
        Me.MetroLabel6.TabIndex = 4
        Me.MetroLabel6.Text = "Position"
        Me.MetroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_dob
        '
        Me.lbl_dob.AutoSize = True
        Me.lbl_dob.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbl_dob.Location = New System.Drawing.Point(468, 200)
        Me.lbl_dob.Name = "lbl_dob"
        Me.lbl_dob.Size = New System.Drawing.Size(0, 0)
        Me.lbl_dob.TabIndex = 7
        Me.lbl_dob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel8.Location = New System.Drawing.Point(280, 200)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(107, 25)
        Me.MetroLabel8.TabIndex = 6
        Me.MetroLabel8.Text = "Date of Birth"
        Me.MetroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_gender
        '
        Me.lbl_gender.AutoSize = True
        Me.lbl_gender.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbl_gender.Location = New System.Drawing.Point(468, 225)
        Me.lbl_gender.Name = "lbl_gender"
        Me.lbl_gender.Size = New System.Drawing.Size(0, 0)
        Me.lbl_gender.TabIndex = 9
        Me.lbl_gender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel10.Location = New System.Drawing.Point(280, 225)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(68, 25)
        Me.MetroLabel10.TabIndex = 8
        Me.MetroLabel10.Text = "Gender"
        Me.MetroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbl_address.Location = New System.Drawing.Point(468, 250)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(0, 0)
        Me.lbl_address.TabIndex = 11
        Me.lbl_address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel12.Location = New System.Drawing.Point(280, 250)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(72, 25)
        Me.MetroLabel12.TabIndex = 10
        Me.MetroLabel12.Text = "Address"
        Me.MetroLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbl_name.Location = New System.Drawing.Point(468, 100)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(0, 0)
        Me.lbl_name.TabIndex = 13
        Me.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel14.Location = New System.Drawing.Point(280, 100)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(58, 25)
        Me.MetroLabel14.TabIndex = 12
        Me.MetroLabel14.Text = "Name"
        Me.MetroLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pb_pic
        '
        Me.pb_pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_pic.Image = CType(resources.GetObject("pb_pic.Image"), System.Drawing.Image)
        Me.pb_pic.Location = New System.Drawing.Point(24, 100)
        Me.pb_pic.Name = "pb_pic"
        Me.pb_pic.Size = New System.Drawing.Size(250, 250)
        Me.pb_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_pic.TabIndex = 14
        Me.pb_pic.TabStop = false
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(471, 327)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(90, 23)
        Me.btn_update.TabIndex = 15
        Me.btn_update.Text = "Update Details"
        Me.btn_update.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'btn_disable
        '
        Me.btn_disable.Location = New System.Drawing.Point(567, 327)
        Me.btn_disable.Name = "btn_disable"
        Me.btn_disable.Size = New System.Drawing.Size(90, 23)
        Me.btn_disable.TabIndex = 16
        Me.btn_disable.Text = "Disable"
        Me.btn_disable.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(664, 327)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 23)
        Me.btn_close.TabIndex = 17
        Me.btn_close.Text = "Close"
        '
        'Show_Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(762, 368)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_disable)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.pb_pic)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.MetroLabel14)
        Me.Controls.Add(Me.lbl_address)
        Me.Controls.Add(Me.MetroLabel12)
        Me.Controls.Add(Me.lbl_gender)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.lbl_dob)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.lbl_position)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.lbl_office)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.lbl_employee_no)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "Show_Employee"
        Me.Resizable = false
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Text = "Employee Details"
        CType(Me.pb_pic,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_employee_no As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_office As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_position As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_dob As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_gender As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_address As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_name As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents pb_pic As System.Windows.Forms.PictureBox
    Friend WithEvents btn_update As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_disable As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_close As MetroFramework.Controls.MetroButton
End Class
