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
        'PrintPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 750)
        Me.Controls.Add(Me.wb_dtr)
        Me.Name = "PrintPreview"
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents wb_dtr As WebBrowser
End Class
