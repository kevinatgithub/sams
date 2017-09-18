<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enroll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Enroll))
        Me.pb_finger = New System.Windows.Forms.PictureBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_counter = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.btn_cancel = New MetroFramework.Controls.MetroButton()
        CType(Me.pb_finger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_finger
        '
        Me.pb_finger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_finger.Location = New System.Drawing.Point(23, 39)
        Me.pb_finger.Name = "pb_finger"
        Me.pb_finger.Size = New System.Drawing.Size(132, 150)
        Me.pb_finger.TabIndex = 0
        Me.pb_finger.TabStop = False
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(161, 39)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(65, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Scanning "
        '
        'lbl_counter
        '
        Me.lbl_counter.AutoSize = True
        Me.lbl_counter.Location = New System.Drawing.Point(220, 39)
        Me.lbl_counter.Name = "lbl_counter"
        Me.lbl_counter.Size = New System.Drawing.Size(16, 19)
        Me.lbl_counter.TabIndex = 2
        Me.lbl_counter.Text = "1"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(232, 39)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(55, 19)
        Me.MetroLabel3.TabIndex = 3
        Me.MetroLabel3.Text = "out of 4"
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(261, 166)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 4
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Enroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(359, 212)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.lbl_counter)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.pb_finger)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Enroll"
        Me.Resizable = false
        Me.Style = MetroFramework.MetroColorStyle.Green
        CType(Me.pb_finger,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents pb_finger As System.Windows.Forms.PictureBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_counter As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_cancel As MetroFramework.Controls.MetroButton
End Class
