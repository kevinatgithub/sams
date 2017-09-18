<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageOffices
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
        Me.lv_offices = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OfficeName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Signatory = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_newOffice = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txt_officeName = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txt_signatory = New MetroFramework.Controls.MetroTextBox()
        Me.lbl_formstate = New MetroFramework.Controls.MetroLabel()
        Me.cm_offices = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmi_update = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmi_delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_cancel = New MetroFramework.Controls.MetroButton()
        Me.cm_offices.SuspendLayout()
        Me.SuspendLayout()
        '
        'lv_offices
        '
        Me.lv_offices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.OfficeName, Me.Signatory})
        Me.lv_offices.FullRowSelect = True
        Me.lv_offices.GridLines = True
        Me.lv_offices.Location = New System.Drawing.Point(23, 95)
        Me.lv_offices.Name = "lv_offices"
        Me.lv_offices.Size = New System.Drawing.Size(535, 307)
        Me.lv_offices.TabIndex = 4
        Me.lv_offices.UseCompatibleStateImageBehavior = False
        Me.lv_offices.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 30
        '
        'OfficeName
        '
        Me.OfficeName.Text = "Office Name"
        Me.OfficeName.Width = 280
        '
        'Signatory
        '
        Me.Signatory.Text = "Signatory"
        Me.Signatory.Width = 200
        '
        'btn_newOffice
        '
        Me.btn_newOffice.Location = New System.Drawing.Point(564, 252)
        Me.btn_newOffice.Name = "btn_newOffice"
        Me.btn_newOffice.Size = New System.Drawing.Size(105, 23)
        Me.btn_newOffice.TabIndex = 2
        Me.btn_newOffice.Text = "Save"
        Me.btn_newOffice.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(564, 134)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(84, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Office Name"
        '
        'txt_officeName
        '
        Me.txt_officeName.Location = New System.Drawing.Point(564, 157)
        Me.txt_officeName.Name = "txt_officeName"
        Me.txt_officeName.Size = New System.Drawing.Size(216, 23)
        Me.txt_officeName.TabIndex = 0
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(564, 187)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Signatory"
        '
        'txt_signatory
        '
        Me.txt_signatory.Location = New System.Drawing.Point(564, 210)
        Me.txt_signatory.Name = "txt_signatory"
        Me.txt_signatory.Size = New System.Drawing.Size(216, 23)
        Me.txt_signatory.TabIndex = 1
        '
        'lbl_formstate
        '
        Me.lbl_formstate.AutoSize = True
        Me.lbl_formstate.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbl_formstate.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lbl_formstate.Location = New System.Drawing.Point(564, 95)
        Me.lbl_formstate.Name = "lbl_formstate"
        Me.lbl_formstate.Size = New System.Drawing.Size(154, 25)
        Me.lbl_formstate.TabIndex = 6
        Me.lbl_formstate.Text = "Create New Office"
        Me.lbl_formstate.UseStyleColors = True
        '
        'cm_offices
        '
        Me.cm_offices.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmi_update, Me.cmi_delete})
        Me.cm_offices.Name = "cm_offices"
        Me.cm_offices.Size = New System.Drawing.Size(113, 48)
        '
        'cmi_update
        '
        Me.cmi_update.Name = "cmi_update"
        Me.cmi_update.Size = New System.Drawing.Size(112, 22)
        Me.cmi_update.Text = "Update"
        '
        'cmi_delete
        '
        Me.cmi_delete.Name = "cmi_delete"
        Me.cmi_delete.Size = New System.Drawing.Size(112, 22)
        Me.cmi_delete.Text = "Delete"
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(675, 252)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(105, 23)
        Me.btn_cancel.TabIndex = 3
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_cancel.Visible = False
        '
        'ManageOffices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(790, 425)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.lbl_formstate)
        Me.Controls.Add(Me.txt_signatory)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.txt_officeName)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btn_newOffice)
        Me.Controls.Add(Me.lv_offices)
        Me.Name = "ManageOffices"
        Me.Text = "Manage Offices"
        Me.cm_offices.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lv_offices As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents OfficeName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Signatory As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_newOffice As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_officeName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_signatory As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lbl_formstate As MetroFramework.Controls.MetroLabel
    Friend WithEvents cm_offices As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmi_update As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmi_delete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_cancel As MetroFramework.Controls.MetroButton
End Class
