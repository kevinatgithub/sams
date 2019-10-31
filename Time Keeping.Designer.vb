<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Time_Keeping
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Time_Keeping))
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_mode = New System.Windows.Forms.Label()
        Me.lbl_office = New System.Windows.Forms.Label()
        Me.lbl_position = New System.Windows.Forms.Label()
        Me.lbl_time_log = New System.Windows.Forms.Label()
        Me.pb_photo_default = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pb_photo = New System.Windows.Forms.PictureBox()
        Me.lbl_fullname = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_pm_out = New System.Windows.Forms.Button()
        Me.btn_pm_in = New System.Windows.Forms.Button()
        Me.btn_am_out = New System.Windows.Forms.Button()
        Me.btn_am_in = New System.Windows.Forms.Button()
        CType(Me.pb_photo_default, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pb_photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.lbl_time.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.ForeColor = System.Drawing.Color.White
        Me.lbl_time.Location = New System.Drawing.Point(501, 37)
        Me.lbl_time.MinimumSize = New System.Drawing.Size(250, 0)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(250, 37)
        Me.lbl_time.TabIndex = 0
        Me.lbl_time.Text = "4:11:01 pm"
        Me.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer
        '
        '
        'lbl_mode
        '
        Me.lbl_mode.AutoSize = True
        Me.lbl_mode.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mode.ForeColor = System.Drawing.Color.DarkRed
        Me.lbl_mode.Location = New System.Drawing.Point(172, 83)
        Me.lbl_mode.Name = "lbl_mode"
        Me.lbl_mode.Size = New System.Drawing.Size(0, 37)
        Me.lbl_mode.TabIndex = 7
        '
        'lbl_office
        '
        Me.lbl_office.AutoSize = True
        Me.lbl_office.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_office.Location = New System.Drawing.Point(175, 62)
        Me.lbl_office.Name = "lbl_office"
        Me.lbl_office.Size = New System.Drawing.Size(0, 21)
        Me.lbl_office.TabIndex = 3
        '
        'lbl_position
        '
        Me.lbl_position.AutoSize = True
        Me.lbl_position.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_position.Location = New System.Drawing.Point(175, 41)
        Me.lbl_position.Name = "lbl_position"
        Me.lbl_position.Size = New System.Drawing.Size(0, 21)
        Me.lbl_position.TabIndex = 2
        '
        'lbl_time_log
        '
        Me.lbl_time_log.AutoSize = True
        Me.lbl_time_log.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time_log.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_time_log.Location = New System.Drawing.Point(174, 120)
        Me.lbl_time_log.Name = "lbl_time_log"
        Me.lbl_time_log.Size = New System.Drawing.Size(0, 25)
        Me.lbl_time_log.TabIndex = 9
        '
        'pb_photo_default
        '
        Me.pb_photo_default.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_photo_default.Image = CType(resources.GetObject("pb_photo_default.Image"), System.Drawing.Image)
        Me.pb_photo_default.Location = New System.Drawing.Point(10, 20)
        Me.pb_photo_default.Name = "pb_photo_default"
        Me.pb_photo_default.Size = New System.Drawing.Size(150, 150)
        Me.pb_photo_default.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_photo_default.TabIndex = 0
        Me.pb_photo_default.TabStop = False
        Me.pb_photo_default.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.pb_photo)
        Me.Panel1.Controls.Add(Me.lbl_fullname)
        Me.Panel1.Controls.Add(Me.lbl_office)
        Me.Panel1.Controls.Add(Me.lbl_position)
        Me.Panel1.Controls.Add(Me.lbl_time_log)
        Me.Panel1.Controls.Add(Me.pb_photo_default)
        Me.Panel1.Controls.Add(Me.lbl_mode)
        Me.Panel1.Location = New System.Drawing.Point(39, 146)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(536, 188)
        Me.Panel1.TabIndex = 8
        '
        'pb_photo
        '
        Me.pb_photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_photo.Image = CType(resources.GetObject("pb_photo.Image"), System.Drawing.Image)
        Me.pb_photo.Location = New System.Drawing.Point(10, 20)
        Me.pb_photo.Name = "pb_photo"
        Me.pb_photo.Size = New System.Drawing.Size(150, 150)
        Me.pb_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_photo.TabIndex = 10
        Me.pb_photo.TabStop = False
        Me.pb_photo.Visible = False
        '
        'lbl_fullname
        '
        Me.lbl_fullname.AutoSize = True
        Me.lbl_fullname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fullname.Location = New System.Drawing.Point(175, 20)
        Me.lbl_fullname.Name = "lbl_fullname"
        Me.lbl_fullname.Size = New System.Drawing.Size(0, 21)
        Me.lbl_fullname.TabIndex = 1
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.lbl_date.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.White
        Me.lbl_date.Location = New System.Drawing.Point(500, 74)
        Me.lbl_date.MinimumSize = New System.Drawing.Size(250, 0)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Padding = New System.Windows.Forms.Padding(5)
        Me.lbl_date.Size = New System.Drawing.Size(250, 31)
        Me.lbl_date.TabIndex = 10
        Me.lbl_date.Text = "Wednesday, September 14, 2017"
        Me.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btn_pm_out)
        Me.Panel2.Controls.Add(Me.btn_pm_in)
        Me.Panel2.Controls.Add(Me.btn_am_out)
        Me.Panel2.Controls.Add(Me.btn_am_in)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.lbl_time)
        Me.Panel2.Controls.Add(Me.lbl_date)
        Me.Panel2.Location = New System.Drawing.Point(0, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 400)
        Me.Panel2.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 376)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 11)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "v 1.1.0"
        '
        'btn_pm_out
        '
        Me.btn_pm_out.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btn_pm_out.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pm_out.Location = New System.Drawing.Point(630, 304)
        Me.btn_pm_out.Name = "btn_pm_out"
        Me.btn_pm_out.Size = New System.Drawing.Size(120, 30)
        Me.btn_pm_out.TabIndex = 13
        Me.btn_pm_out.Text = "PM Time Out"
        Me.btn_pm_out.UseVisualStyleBackColor = False
        '
        'btn_pm_in
        '
        Me.btn_pm_in.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btn_pm_in.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pm_in.Location = New System.Drawing.Point(630, 251)
        Me.btn_pm_in.Name = "btn_pm_in"
        Me.btn_pm_in.Size = New System.Drawing.Size(120, 30)
        Me.btn_pm_in.TabIndex = 12
        Me.btn_pm_in.Text = "PM Time In"
        Me.btn_pm_in.UseVisualStyleBackColor = False
        '
        'btn_am_out
        '
        Me.btn_am_out.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btn_am_out.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_am_out.Location = New System.Drawing.Point(630, 199)
        Me.btn_am_out.Name = "btn_am_out"
        Me.btn_am_out.Size = New System.Drawing.Size(120, 30)
        Me.btn_am_out.TabIndex = 11
        Me.btn_am_out.Text = "AM Time Out"
        Me.btn_am_out.UseVisualStyleBackColor = False
        '
        'btn_am_in
        '
        Me.btn_am_in.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btn_am_in.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_am_in.Location = New System.Drawing.Point(630, 146)
        Me.btn_am_in.Name = "btn_am_in"
        Me.btn_am_in.Size = New System.Drawing.Size(120, 30)
        Me.btn_am_in.TabIndex = 0
        Me.btn_am_in.Text = "AM Time In"
        Me.btn_am_in.UseVisualStyleBackColor = False
        '
        'Time_Keeping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Time_Keeping"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.TransparencyKey = System.Drawing.Color.Silver
        CType(Me.pb_photo_default, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pb_photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_time As System.Windows.Forms.Label
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents lbl_mode As System.Windows.Forms.Label
    Friend WithEvents lbl_time_log As System.Windows.Forms.Label
    Friend WithEvents pb_photo_default As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_office As System.Windows.Forms.Label
    Friend WithEvents lbl_position As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents lbl_fullname As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_am_in As System.Windows.Forms.Button
    Friend WithEvents btn_pm_out As System.Windows.Forms.Button
    Friend WithEvents btn_pm_in As System.Windows.Forms.Button
    Friend WithEvents btn_am_out As System.Windows.Forms.Button
    Friend WithEvents pb_photo As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
