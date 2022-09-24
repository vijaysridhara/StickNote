<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Book
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Book))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ctxTree = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewcategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewnoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteNoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lstNotes = New System.Windows.Forms.ListBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.txtContent = New RichTextBoxPrintCtrl.RichTextBoxPrintCtrl.RichTextBoxPrintCtrl()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.butSave = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.ctxTree.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtContent)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblDate)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(816, 496)
        Me.SplitContainer1.SplitterDistance = 239
        Me.SplitContainer1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(239, 496)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TreeView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(231, 470)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Collections"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.AllowDrop = True
        Me.TreeView1.ContextMenuStrip = Me.ctxTree
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.Location = New System.Drawing.Point(3, 3)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.Size = New System.Drawing.Size(225, 464)
        Me.TreeView1.TabIndex = 0
        '
        'ctxTree
        '
        Me.ctxTree.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewcategoryToolStripMenuItem, Me.NewnoteToolStripMenuItem, Me.ToolStripMenuItem1, Me.ReloadToolStripMenuItem, Me.ToolStripMenuItem2, Me.DeleteCategoryToolStripMenuItem, Me.DeleteNoteToolStripMenuItem})
        Me.ctxTree.Name = "ctxTree"
        Me.ctxTree.Size = New System.Drawing.Size(157, 126)
        '
        'NewcategoryToolStripMenuItem
        '
        Me.NewcategoryToolStripMenuItem.Name = "NewcategoryToolStripMenuItem"
        Me.NewcategoryToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.NewcategoryToolStripMenuItem.Text = "New &category"
        '
        'NewnoteToolStripMenuItem
        '
        Me.NewnoteToolStripMenuItem.Name = "NewnoteToolStripMenuItem"
        Me.NewnoteToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.NewnoteToolStripMenuItem.Text = "New &note"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(153, 6)
        '
        'ReloadToolStripMenuItem
        '
        Me.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem"
        Me.ReloadToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ReloadToolStripMenuItem.Text = "&Reload"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(153, 6)
        '
        'DeleteCategoryToolStripMenuItem
        '
        Me.DeleteCategoryToolStripMenuItem.Name = "DeleteCategoryToolStripMenuItem"
        Me.DeleteCategoryToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.DeleteCategoryToolStripMenuItem.Text = "&Delete category"
        '
        'DeleteNoteToolStripMenuItem
        '
        Me.DeleteNoteToolStripMenuItem.Name = "DeleteNoteToolStripMenuItem"
        Me.DeleteNoteToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.DeleteNoteToolStripMenuItem.Text = "Dele&te note"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "folder_open_16.ico")
        Me.ImageList1.Images.SetKeyName(1, "slimnote.ico")
        Me.ImageList1.Images.SetKeyName(2, "note16.ico")
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lstNotes)
        Me.TabPage2.Controls.Add(Me.MonthCalendar1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(231, 470)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Date wise"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lstNotes
        '
        Me.lstNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstNotes.FormattingEnabled = True
        Me.lstNotes.Location = New System.Drawing.Point(3, 165)
        Me.lstNotes.Name = "lstNotes"
        Me.lstNotes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstNotes.Size = New System.Drawing.Size(225, 302)
        Me.lstNotes.TabIndex = 2
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MonthCalendar1.Location = New System.Drawing.Point(3, 3)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 3
        '
        'txtContent
        '
        Me.txtContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContent.Location = New System.Drawing.Point(0, 22)
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(573, 454)
        Me.txtContent.TabIndex = 1
        Me.txtContent.Text = ""
        '
        'lblDate
        '
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDate.Location = New System.Drawing.Point(0, 476)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(573, 20)
        Me.lblDate.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = My.Resources.Resources.title
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Controls.Add(Me.butSave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(573, 22)
        Me.Panel1.TabIndex = 2
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTitle.Location = New System.Drawing.Point(31, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(358, 22)
        Me.lblTitle.TabIndex = 6
        '
        'butSave
        '
        Me.butSave.BackColor = System.Drawing.Color.Transparent
        Me.butSave.Enabled = False
        Me.butSave.FlatAppearance.BorderSize = 0
        Me.butSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSave.Image = CType(resources.GetObject("butSave.Image"), System.Drawing.Image)
        Me.butSave.Location = New System.Drawing.Point(0, 0)
        Me.butSave.Name = "butSave"
        Me.butSave.Size = New System.Drawing.Size(25, 22)
        Me.butSave.TabIndex = 5
        Me.butSave.UseVisualStyleBackColor = False
        '
        'Book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 496)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Book"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Organize notes"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ctxTree.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ctxTree As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewcategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewnoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteNoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents txtContent As RichTextBoxPrintCtrl.RichTextBoxPrintCtrl.RichTextBoxPrintCtrl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents butSave As System.Windows.Forms.Button
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lstNotes As System.Windows.Forms.ListBox
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents ReloadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
End Class
