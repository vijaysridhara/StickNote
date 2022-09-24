<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Post
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Post))
        Me.ctxEdit = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SavenoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.PageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintnoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintpreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewnoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HidenotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TogglewordwrapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StayontopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowOrganizerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrAutosave = New System.Windows.Forms.Timer(Me.components)
        Me.txtContent = New RichTextBoxPrintCtrl.RichTextBoxPrintCtrl.RichTextBoxPrintCtrl()
        Me.PNLbOTTOM = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblRight = New System.Windows.Forms.Label()
        Me.Title1 = New Title()
        Me.ctxEdit.SuspendLayout()
        Me.PNLbOTTOM.SuspendLayout()
        Me.SuspendLayout()
        '
        'ctxEdit
        '
        Me.ctxEdit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.SelectallToolStripMenuItem, Me.ToolStripSeparator2, Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.ToolStripSeparator3, Me.SavenoteToolStripMenuItem, Me.ToolStripSeparator4, Me.PageToolStripMenuItem, Me.PrintnoteToolStripMenuItem, Me.PrintpreviewToolStripMenuItem, Me.ToolStripSeparator1, Me.NewnoteToolStripMenuItem, Me.HidenotesToolStripMenuItem, Me.TogglewordwrapToolStripMenuItem, Me.StayontopToolStripMenuItem, Me.ShowOrganizerToolStripMenuItem})
        Me.ctxEdit.Name = "ctxEdit"
        Me.ctxEdit.Size = New System.Drawing.Size(214, 358)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'SelectallToolStripMenuItem
        '
        Me.SelectallToolStripMenuItem.Name = "SelectallToolStripMenuItem"
        Me.SelectallToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectallToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.SelectallToolStripMenuItem.Text = "Select &all"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(210, 6)
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Image = CType(resources.GetObject("UndoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Image = CType(resources.GetObject("RedoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.RedoToolStripMenuItem.Text = "&Redo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(210, 6)
        '
        'SavenoteToolStripMenuItem
        '
        Me.SavenoteToolStripMenuItem.Image = CType(resources.GetObject("SavenoteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SavenoteToolStripMenuItem.Name = "SavenoteToolStripMenuItem"
        Me.SavenoteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SavenoteToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.SavenoteToolStripMenuItem.Text = "&Save note"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(210, 6)
        '
        'PageToolStripMenuItem
        '
        Me.PageToolStripMenuItem.Name = "PageToolStripMenuItem"
        Me.PageToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.PageToolStripMenuItem.Text = "Page set&up"
        '
        'PrintnoteToolStripMenuItem
        '
        Me.PrintnoteToolStripMenuItem.Name = "PrintnoteToolStripMenuItem"
        Me.PrintnoteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintnoteToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.PrintnoteToolStripMenuItem.Text = "&Print note"
        '
        'PrintpreviewToolStripMenuItem
        '
        Me.PrintpreviewToolStripMenuItem.Name = "PrintpreviewToolStripMenuItem"
        Me.PrintpreviewToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.PrintpreviewToolStripMenuItem.Text = "Print pre&view"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(210, 6)
        '
        'NewnoteToolStripMenuItem
        '
        Me.NewnoteToolStripMenuItem.Image = CType(resources.GetObject("NewnoteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewnoteToolStripMenuItem.Name = "NewnoteToolStripMenuItem"
        Me.NewnoteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewnoteToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.NewnoteToolStripMenuItem.Text = "&New note"
        '
        'HidenotesToolStripMenuItem
        '
        Me.HidenotesToolStripMenuItem.Name = "HidenotesToolStripMenuItem"
        Me.HidenotesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HidenotesToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.HidenotesToolStripMenuItem.Text = "&Hide notes"
        '
        'TogglewordwrapToolStripMenuItem
        '
        Me.TogglewordwrapToolStripMenuItem.Name = "TogglewordwrapToolStripMenuItem"
        Me.TogglewordwrapToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.TogglewordwrapToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.TogglewordwrapToolStripMenuItem.Text = "Toggle &word wrap"
        '
        'StayontopToolStripMenuItem
        '
        Me.StayontopToolStripMenuItem.Name = "StayontopToolStripMenuItem"
        Me.StayontopToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.StayontopToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.StayontopToolStripMenuItem.Text = "Stay on &top"
        '
        'ShowOrganizerToolStripMenuItem
        '
        Me.ShowOrganizerToolStripMenuItem.Name = "ShowOrganizerToolStripMenuItem"
        Me.ShowOrganizerToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.ShowOrganizerToolStripMenuItem.Text = "S&how organizer"
        '
        'tmrAutosave
        '
        Me.tmrAutosave.Interval = 1000
        '
        'txtContent
        '
        Me.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContent.ContextMenuStrip = Me.ctxEdit
        Me.txtContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContent.Location = New System.Drawing.Point(0, 22)
        Me.txtContent.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(341, 262)
        Me.txtContent.TabIndex = 0
        Me.txtContent.Text = ""
        '
        'PNLbOTTOM
        '
        Me.PNLbOTTOM.BackColor = System.Drawing.Color.Transparent
        Me.PNLbOTTOM.Controls.Add(Me.lblDate)
        Me.PNLbOTTOM.Controls.Add(Me.lblRight)
        Me.PNLbOTTOM.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PNLbOTTOM.Location = New System.Drawing.Point(0, 284)
        Me.PNLbOTTOM.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PNLbOTTOM.Name = "PNLbOTTOM"
        Me.PNLbOTTOM.Size = New System.Drawing.Size(341, 23)
        Me.PNLbOTTOM.TabIndex = 4
        '
        'lblDate
        '
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDate.Location = New System.Drawing.Point(0, 0)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(315, 23)
        Me.lblDate.TabIndex = 0
        '
        'lblRight
        '
        Me.lblRight.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.lblRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblRight.Image = CType(resources.GetObject("lblRight.Image"), System.Drawing.Image)
        Me.lblRight.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.lblRight.Location = New System.Drawing.Point(315, 0)
        Me.lblRight.Margin = New System.Windows.Forms.Padding(0)
        Me.lblRight.Name = "lblRight"
        Me.lblRight.Size = New System.Drawing.Size(26, 23)
        Me.lblRight.TabIndex = 1
        '
        'Title1
        '
        Me.Title1.BackColor = System.Drawing.Color.Transparent
        Me.Title1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Title1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Title1.Location = New System.Drawing.Point(0, 0)
        Me.Title1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Title1.Name = "Title1"
        Me.Title1.Size = New System.Drawing.Size(341, 22)
        Me.Title1.TabIndex = 1
        '
        'Post
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 307)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtContent)
        Me.Controls.Add(Me.PNLbOTTOM)
        Me.Controls.Add(Me.Title1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Post"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.ctxEdit.ResumeLayout(False)
        Me.PNLbOTTOM.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ctxEdit As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SavenoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintnoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewnoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HidenotesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectallToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintpreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    'Friend WithEvents txtContent As RichTextBoxPrintCtrl.RichTextBoxPrintCtrl.RichTextBoxPrintCtrl
    Friend WithEvents tmrAutosave As System.Windows.Forms.Timer
    Friend WithEvents TogglewordwrapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StayontopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtContent As RichTextBoxPrintCtrl.RichTextBoxPrintCtrl.RichTextBoxPrintCtrl
    Friend WithEvents Title1 As Title
    Friend WithEvents PNLbOTTOM As System.Windows.Forms.Panel
    Friend WithEvents lblRight As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents ShowOrganizerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    'Friend WithEvents txtContent As RichTextBoxPrintCtrl.RichTextBoxPrintCtrl.RichTextBoxPrintCtrl

End Class
