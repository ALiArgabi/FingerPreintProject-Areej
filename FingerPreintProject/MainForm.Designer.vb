﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.HospitalMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformationMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinistryOfHealthMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrationMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdatingMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ReaderStatus_C_D = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FAC_message = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HospitalMenu, Me.MinistryOfHealthMenu, Me.WindowsMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(737, 28)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'HospitalMenu
        '
        Me.HospitalMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformationMenuItem})
        Me.HospitalMenu.Name = "HospitalMenu"
        Me.HospitalMenu.Size = New System.Drawing.Size(153, 24)
        Me.HospitalMenu.Text = "&Hospital المستشفى"
        '
        'InformationMenuItem
        '
        Me.InformationMenuItem.Name = "InformationMenuItem"
        Me.InformationMenuItem.Size = New System.Drawing.Size(168, 26)
        Me.InformationMenuItem.Text = "Search بحث"
        '
        'MinistryOfHealthMenu
        '
        Me.MinistryOfHealthMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrationMenuItem, Me.UpdatingMenuItem})
        Me.MinistryOfHealthMenu.Name = "MinistryOfHealthMenu"
        Me.MinistryOfHealthMenu.Size = New System.Drawing.Size(220, 24)
        Me.MinistryOfHealthMenu.Text = "&Ministry of Health وزارة الصحة"
        '
        'RegistrationMenuItem
        '
        Me.RegistrationMenuItem.Name = "RegistrationMenuItem"
        Me.RegistrationMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.RegistrationMenuItem.Text = "Registration التسجيل"
        '
        'UpdatingMenuItem
        '
        Me.UpdatingMenuItem.Name = "UpdatingMenuItem"
        Me.UpdatingMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.UpdatingMenuItem.Text = "Updating التحديث"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(130, 24)
        Me.WindowsMenu.Text = "&Windows النوافذ"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.CascadeToolStripMenuItem.Text = "&Cascade تتالي"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.TileVerticalToolStripMenuItem.Text = "&Vertical عمودي"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.TileHorizontalToolStripMenuItem.Text = "&Horizontal أفقي"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.CloseAllToolStripMenuItem.Text = "C&lose All غلق الكل"
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReaderStatus_C_D, Me.ToolStripStatusLabel, Me.FAC_message})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 532)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(737, 26)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(76, 20)
        Me.ToolStripStatusLabel.Text = "Ali Argabi"
        '
        'ReaderStatus_C_D
        '
        Me.ReaderStatus_C_D.BackColor = System.Drawing.Color.Transparent
        Me.ReaderStatus_C_D.Name = "ReaderStatus_C_D"
        Me.ReaderStatus_C_D.Size = New System.Drawing.Size(15, 20)
        Me.ReaderStatus_C_D.Text = "•"
        '
        'FAC_message
        '
        Me.FAC_message.Name = "FAC_message"
        Me.FAC_message.Size = New System.Drawing.Size(0, 20)
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FingerPreintProject.My.Resources.Resources.SaveME
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(737, 558)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.Text = "  Save Me أنقذني"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MinistryOfHealthMenu As ToolStripMenuItem
    Friend WithEvents HospitalMenu As ToolStripMenuItem
    Friend WithEvents InformationMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrationMenuItem As ToolStripMenuItem
    Friend WithEvents UpdatingMenuItem As ToolStripMenuItem
    Friend WithEvents ReaderStatus_C_D As ToolStripStatusLabel
    Friend WithEvents FAC_message As ToolStripStatusLabel
End Class
