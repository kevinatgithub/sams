<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update_Employee_3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Update_Employee_3))
        Me.btn_back = New MetroFramework.Controls.MetroButton()
        Me.btn_next = New MetroFramework.Controls.MetroButton()
        Me.btn_cancel = New MetroFramework.Controls.MetroButton()
        Me.btn_scan_right = New MetroFramework.Controls.MetroButton()
        Me.btn_scan_left = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.pb_right = New System.Windows.Forms.PictureBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.pb_left = New System.Windows.Forms.PictureBox()
        CType(Me.pb_right, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_left, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(237, 422)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 38
        Me.btn_back.Text = "Back"
        Me.btn_back.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'btn_next
        '
        Me.btn_next.Location = New System.Drawing.Point(318, 422)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(75, 23)
        Me.btn_next.TabIndex = 37
        Me.btn_next.Text = "Next"
        Me.btn_next.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(399, 422)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 36
        Me.btn_cancel.Text = "Cancel"
        '
        'btn_scan_right
        '
        Me.btn_scan_right.Location = New System.Drawing.Point(399, 160)
        Me.btn_scan_right.Name = "btn_scan_right"
        Me.btn_scan_right.Size = New System.Drawing.Size(75, 23)
        Me.btn_scan_right.TabIndex = 35
        Me.btn_scan_right.Text = "Scan Finger"
        '
        'btn_scan_left
        '
        Me.btn_scan_left.Location = New System.Drawing.Point(211, 160)
        Me.btn_scan_left.Name = "btn_scan_left"
        Me.btn_scan_left.Size = New System.Drawing.Size(75, 23)
        Me.btn_scan_left.TabIndex = 34
        Me.btn_scan_left.Text = "Scan Finger"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 99)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(162, 19)
        Me.MetroLabel3.TabIndex = 33
        Me.MetroLabel3.Text = "Scan Left and Right Finger"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(349, 160)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel2.TabIndex = 32
        Me.MetroLabel2.Text = "Right"
        '
        'pb_right
        '
        Me.pb_right.Location = New System.Drawing.Point(349, 191)
        Me.pb_right.Name = "pb_right"
        Me.pb_right.Size = New System.Drawing.Size(125, 130)
        Me.pb_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_right.TabIndex = 31
        Me.pb_right.TabStop = False
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(161, 160)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(30, 19)
        Me.MetroLabel1.TabIndex = 30
        Me.MetroLabel1.Text = "Left"
        '
        'pb_left
        '
        Me.pb_left.Location = New System.Drawing.Point(161, 191)
        Me.pb_left.Name = "pb_left"
        Me.pb_left.Size = New System.Drawing.Size(125, 130)
        Me.pb_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_left.TabIndex = 29
        Me.pb_left.TabStop = False
        '
        'Update_Employee_3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(523, 480)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_scan_right)
        Me.Controls.Add(Me.btn_scan_left)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.pb_right)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.pb_left)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Update_Employee_3"
        Me.Resizable = false
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Update Employee (Step 3 of 4)"
        CType(Me.pb_right,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pb_left,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btn_back As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_next As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_cancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_scan_right As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_scan_left As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents pb_right As System.Windows.Forms.PictureBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents pb_left As System.Windows.Forms.PictureBox
End Class
