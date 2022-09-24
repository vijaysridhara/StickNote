<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Title
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Title))
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.butClose = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.butMax = New System.Windows.Forms.Label()
        Me.butPin = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.SystemColors.Window
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtTitle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTitle.Location = New System.Drawing.Point(25, 0)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(280, 17)
        Me.txtTitle.TabIndex = 3
        Me.txtTitle.Visible = False
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTitle.Location = New System.Drawing.Point(25, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(280, 22)
        Me.lblTitle.TabIndex = 5
        '
        'butClose
        '
        Me.butClose.BackColor = System.Drawing.Color.Transparent
        Me.butClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.butClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.butClose.ImageIndex = 4
        Me.butClose.ImageList = Me.ImageList1
        Me.butClose.Location = New System.Drawing.Point(330, 0)
        Me.butClose.Name = "butClose"
        Me.butClose.Size = New System.Drawing.Size(25, 22)
        Me.butClose.TabIndex = 4
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "minimize.png")
        Me.ImageList1.Images.SetKeyName(1, "maximize.png")
        Me.ImageList1.Images.SetKeyName(2, "pin.png")
        Me.ImageList1.Images.SetKeyName(3, "unpin.png")
        Me.ImageList1.Images.SetKeyName(4, "close.png")
        '
        'butMax
        '
        Me.butMax.BackColor = System.Drawing.Color.Transparent
        Me.butMax.Dock = System.Windows.Forms.DockStyle.Right
        Me.butMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.butMax.ImageIndex = 0
        Me.butMax.ImageList = Me.ImageList1
        Me.butMax.Location = New System.Drawing.Point(305, 0)
        Me.butMax.Name = "butMax"
        Me.butMax.Size = New System.Drawing.Size(25, 22)
        Me.butMax.TabIndex = 6
        '
        'butPin
        '
        Me.butPin.BackColor = System.Drawing.Color.Transparent
        Me.butPin.Dock = System.Windows.Forms.DockStyle.Left
        Me.butPin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.butPin.ImageIndex = 3
        Me.butPin.ImageList = Me.ImageList1
        Me.butPin.Location = New System.Drawing.Point(0, 0)
        Me.butPin.Name = "butPin"
        Me.butPin.Size = New System.Drawing.Size(25, 22)
        Me.butPin.TabIndex = 7
        '
        'Title
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.butMax)
        Me.Controls.Add(Me.butClose)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.butPin)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Title"
        Me.Size = New System.Drawing.Size(355, 22)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents butClose As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents butMax As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents butPin As System.Windows.Forms.Label

End Class
