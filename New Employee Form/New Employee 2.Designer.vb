<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Employee_2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(New_Employee_2))
        Me.btn_next = New MetroFramework.Controls.MetroLabel()
        Me.pb_pic = New System.Windows.Forms.PictureBox()
        Me.btn_start_camera = New MetroFramework.Controls.MetroButton()
        Me.btn_upload = New MetroFramework.Controls.MetroButton()
        Me.proceed = New MetroFramework.Controls.MetroButton()
        Me.btn_cancel = New MetroFramework.Controls.MetroButton()
        Me.btn_capture = New MetroFramework.Controls.MetroButton()
        Me.btn_back = New MetroFramework.Controls.MetroButton()
        CType(Me.pb_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_next
        '
        Me.btn_next.AutoSize = True
        Me.btn_next.Location = New System.Drawing.Point(23, 83)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(203, 19)
        Me.btn_next.TabIndex = 0
        Me.btn_next.Text = "Add Profile Picture for Employee"
        '
        'pb_pic
        '
        Me.pb_pic.Image = CType(resources.GetObject("pb_pic.Image"), System.Drawing.Image)
        Me.pb_pic.Location = New System.Drawing.Point(23, 105)
        Me.pb_pic.Name = "pb_pic"
        Me.pb_pic.Size = New System.Drawing.Size(250, 250)
        Me.pb_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_pic.TabIndex = 1
        Me.pb_pic.TabStop = False
        '
        'btn_start_camera
        '
        Me.btn_start_camera.Location = New System.Drawing.Point(26, 361)
        Me.btn_start_camera.Name = "btn_start_camera"
        Me.btn_start_camera.Size = New System.Drawing.Size(75, 23)
        Me.btn_start_camera.TabIndex = 2
        Me.btn_start_camera.Text = "Start Camera"
        Me.btn_start_camera.Visible = False
        '
        'btn_upload
        '
        Me.btn_upload.Location = New System.Drawing.Point(188, 361)
        Me.btn_upload.Name = "btn_upload"
        Me.btn_upload.Size = New System.Drawing.Size(75, 23)
        Me.btn_upload.TabIndex = 3
        Me.btn_upload.Text = "Select File"
        '
        'proceed
        '
        Me.proceed.Location = New System.Drawing.Point(318, 421)
        Me.proceed.Name = "proceed"
        Me.proceed.Size = New System.Drawing.Size(75, 23)
        Me.proceed.TabIndex = 22
        Me.proceed.Text = "Next"
        Me.proceed.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(399, 421)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 21
        Me.btn_cancel.Text = "Cancel"
        '
        'btn_capture
        '
        Me.btn_capture.Enabled = False
        Me.btn_capture.Location = New System.Drawing.Point(107, 361)
        Me.btn_capture.Name = "btn_capture"
        Me.btn_capture.Size = New System.Drawing.Size(75, 23)
        Me.btn_capture.TabIndex = 23
        Me.btn_capture.Text = "Capture"
        Me.btn_capture.Visible = False
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(237, 421)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 24
        Me.btn_back.Text = "Back"
        Me.btn_back.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'New_Employee_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(523, 480)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_capture)
        Me.Controls.Add(Me.proceed)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_upload)
        Me.Controls.Add(Me.btn_start_camera)
        Me.Controls.Add(Me.pb_pic)
        Me.Controls.Add(Me.btn_next)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "New_Employee_2"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Create Employee Step 2 of 4"
        CType(Me.pb_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_next As MetroFramework.Controls.MetroLabel
    Friend WithEvents pb_pic As System.Windows.Forms.PictureBox
    Friend WithEvents btn_start_camera As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_upload As MetroFramework.Controls.MetroButton
    Friend WithEvents proceed As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_cancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_capture As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_back As MetroFramework.Controls.MetroButton
End Class
