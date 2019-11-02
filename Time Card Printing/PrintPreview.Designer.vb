<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintPreview
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
        Me.wb_dtr = New System.Windows.Forms.WebBrowser()
        Me.btn_save = New MetroFramework.Controls.MetroButton()
        Me.btn_cancel = New MetroFramework.Controls.MetroButton()
        Me.btn_reload = New MetroFramework.Controls.MetroButton()
        Me.btn_copy_url = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'wb_dtr
        '
        Me.wb_dtr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wb_dtr.Location = New System.Drawing.Point(20, 60)
        Me.wb_dtr.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wb_dtr.Name = "wb_dtr"
        Me.wb_dtr.Size = New System.Drawing.Size(760, 670)
        Me.wb_dtr.TabIndex = 0
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(20, 31)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 37
        Me.btn_save.Text = "Print"
        Me.btn_save.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(182, 31)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 38
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'btn_reload
        '
        Me.btn_reload.Location = New System.Drawing.Point(101, 31)
        Me.btn_reload.Name = "btn_reload"
        Me.btn_reload.Size = New System.Drawing.Size(75, 23)
        Me.btn_reload.TabIndex = 39
        Me.btn_reload.Text = "Reload"
        Me.btn_reload.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'btn_copy_url
        '
        Me.btn_copy_url.Location = New System.Drawing.Point(705, 31)
        Me.btn_copy_url.Name = "btn_copy_url"
        Me.btn_copy_url.Size = New System.Drawing.Size(75, 23)
        Me.btn_copy_url.TabIndex = 40
        Me.btn_copy_url.Text = "Copy"
        Me.btn_copy_url.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'PrintPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 750)
        Me.Controls.Add(Me.btn_copy_url)
        Me.Controls.Add(Me.btn_reload)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.wb_dtr)
        Me.Name = "PrintPreview"
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents wb_dtr As WebBrowser
    Friend WithEvents btn_save As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_cancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_reload As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_copy_url As MetroFramework.Controls.MetroButton
End Class
