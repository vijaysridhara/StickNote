<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.mnuMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewpostToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HideallpostsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowactivenotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowallpostsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShowOrganizerToolSTripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StackItemstoRightMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrClose = New System.Windows.Forms.Timer(Me.components)
        Me.UnstackItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewpostToolStripMenuItem, Me.ToolStripSeparator1, Me.StackItemstoRightMenuItem, Me.UnstackItemsToolStripMenuItem, Me.HideallpostsToolStripMenuItem, Me.ShowactivenotesToolStripMenuItem, Me.ShowallpostsToolStripMenuItem, Me.ToolStripSeparator2, Me.ShowOrganizerToolSTripMenuItem, Me.SettingsToolStripMenuItem, Me.ToolStripSeparator3, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.ShowImageMargin = False
        Me.mnuMain.Size = New System.Drawing.Size(152, 242)
        '
        'NewpostToolStripMenuItem
        '
        Me.NewpostToolStripMenuItem.Name = "NewpostToolStripMenuItem"
        Me.NewpostToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.NewpostToolStripMenuItem.Text = "&New note"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(148, 6)
        '
        'HideallpostsToolStripMenuItem
        '
        Me.HideallpostsToolStripMenuItem.Name = "HideallpostsToolStripMenuItem"
        Me.HideallpostsToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.HideallpostsToolStripMenuItem.Text = "&Hide all notes"
        '
        'ShowactivenotesToolStripMenuItem
        '
        Me.ShowactivenotesToolStripMenuItem.Name = "ShowactivenotesToolStripMenuItem"
        Me.ShowactivenotesToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ShowactivenotesToolStripMenuItem.Text = "Show &active notes"
        '
        'ShowallpostsToolStripMenuItem
        '
        Me.ShowallpostsToolStripMenuItem.Name = "ShowallpostsToolStripMenuItem"
        Me.ShowallpostsToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ShowallpostsToolStripMenuItem.Text = "&Show all notes"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(148, 6)
        '
        'ShowOrganizerToolSTripMenuItem
        '
        Me.ShowOrganizerToolSTripMenuItem.Name = "ShowOrganizerToolSTripMenuItem"
        Me.ShowOrganizerToolSTripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ShowOrganizerToolSTripMenuItem.Text = "Show Organizer"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.SettingsToolStripMenuItem.Text = "Se&ttings"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(148, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'StackItemstoRightMenuItem
        '
        Me.StackItemstoRightMenuItem.Name = "StackItemstoRightMenuItem"
        Me.StackItemstoRightMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.StackItemstoRightMenuItem.Text = "Stack notes to right"
        '
        'tmrClose
        '
        '
        'UnstackItemsToolStripMenuItem
        '
        Me.UnstackItemsToolStripMenuItem.Name = "UnstackItemsToolStripMenuItem"
        Me.UnstackItemsToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.UnstackItemsToolStripMenuItem.Text = "Unstack notes"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(0, 0)
        Me.ContextMenuStrip = Me.mnuMain
        Me.ControlBox = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.mnuMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mnuMain As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewpostToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HideallpostsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowallpostsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tmrClose As System.Windows.Forms.Timer
    Friend WithEvents ShowactivenotesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowOrganizerToolSTripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StackItemstoRightMenuItem As ToolStripMenuItem
    Friend WithEvents UnstackItemsToolStripMenuItem As ToolStripMenuItem
End Class
