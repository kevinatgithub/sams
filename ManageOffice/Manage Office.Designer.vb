﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.SignatoryPosition = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.txt_signatory_position = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.cm_offices.SuspendLayout()
        Me.SuspendLayout()
        '
        'lv_offices
        '
        Me.lv_offices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.OfficeName, Me.Signatory, Me.SignatoryPosition})
        Me.lv_offices.FullRowSelect = True
        Me.lv_offices.GridLines = True
        Me.lv_offices.Location = New System.Drawing.Point(31, 117)
        Me.lv_offices.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lv_offices.Name = "lv_offices"
        Me.lv_offices.Size = New System.Drawing.Size(1089, 671)
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
        Me.Signatory.Width = 289
        '
        'SignatoryPosition
        '
        Me.SignatoryPosition.Text = "Signatory Position"
        Me.SignatoryPosition.Width = 203
        '
        'btn_newOffice
        '
        Me.btn_newOffice.Location = New System.Drawing.Point(1129, 388)
        Me.btn_newOffice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_newOffice.Name = "btn_newOffice"
        Me.btn_newOffice.Size = New System.Drawing.Size(140, 28)
        Me.btn_newOffice.TabIndex = 2
        Me.btn_newOffice.Text = "Save"
        Me.btn_newOffice.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(1129, 165)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(88, 20)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Office Name"
        '
        'txt_officeName
        '
        Me.txt_officeName.Location = New System.Drawing.Point(1129, 193)
        Me.txt_officeName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_officeName.Name = "txt_officeName"
        Me.txt_officeName.Size = New System.Drawing.Size(288, 28)
        Me.txt_officeName.TabIndex = 0
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(1129, 230)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(67, 20)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Signatory"
        '
        'txt_signatory
        '
        Me.txt_signatory.Location = New System.Drawing.Point(1129, 258)
        Me.txt_signatory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_signatory.Name = "txt_signatory"
        Me.txt_signatory.Size = New System.Drawing.Size(288, 28)
        Me.txt_signatory.TabIndex = 1
        '
        'lbl_formstate
        '
        Me.lbl_formstate.AutoSize = True
        Me.lbl_formstate.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbl_formstate.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lbl_formstate.Location = New System.Drawing.Point(1129, 117)
        Me.lbl_formstate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_formstate.Name = "lbl_formstate"
        Me.lbl_formstate.Size = New System.Drawing.Size(165, 25)
        Me.lbl_formstate.TabIndex = 6
        Me.lbl_formstate.Text = "Create New Office"
        Me.lbl_formstate.UseStyleColors = True
        '
        'cm_offices
        '
        Me.cm_offices.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cm_offices.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmi_update, Me.cmi_delete})
        Me.cm_offices.Name = "cm_offices"
        Me.cm_offices.Size = New System.Drawing.Size(128, 52)
        '
        'cmi_update
        '
        Me.cmi_update.Name = "cmi_update"
        Me.cmi_update.Size = New System.Drawing.Size(127, 24)
        Me.cmi_update.Text = "Update"
        '
        'cmi_delete
        '
        Me.cmi_delete.Name = "cmi_delete"
        Me.cmi_delete.Size = New System.Drawing.Size(127, 24)
        Me.cmi_delete.Text = "Delete"
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(1277, 388)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(140, 28)
        Me.btn_cancel.TabIndex = 3
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_cancel.Visible = False
        '
        'txt_signatory_position
        '
        Me.txt_signatory_position.Location = New System.Drawing.Point(1129, 331)
        Me.txt_signatory_position.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_signatory_position.Name = "txt_signatory_position"
        Me.txt_signatory_position.Size = New System.Drawing.Size(288, 28)
        Me.txt_signatory_position.TabIndex = 7
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(1129, 303)
        Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(118, 20)
        Me.MetroLabel3.TabIndex = 8
        Me.MetroLabel3.Text = "Signatory Position"
        '
        'ManageOffices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1432, 807)
        Me.Controls.Add(Me.txt_signatory_position)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.lbl_formstate)
        Me.Controls.Add(Me.txt_signatory)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.txt_officeName)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btn_newOffice)
        Me.Controls.Add(Me.lv_offices)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ManageOffices"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Text = "Manage Offices"
        Me.Theme = MetroFramework.MetroThemeStyle.Light
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
    Friend WithEvents SignatoryPosition As ColumnHeader
    Friend WithEvents txt_signatory_position As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
End Class
