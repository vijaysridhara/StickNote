<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class StickNoteSettings
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
        Me.butEForecolor = New System.Windows.Forms.Button()
        Me.butEBackcolor = New System.Windows.Forms.Button()
        Me.butTForecolor = New System.Windows.Forms.Button()
        Me.colDG = New System.Windows.Forms.ColorDialog()
        Me.chkAutosave = New System.Windows.Forms.CheckBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.butExit = New System.Windows.Forms.Button()
        Me.butFonts = New System.Windows.Forms.Button()
        Me.fntDg = New System.Windows.Forms.FontDialog()
        Me.gpbColors = New System.Windows.Forms.GroupBox()
        Me.butTitleFont = New System.Windows.Forms.Button()
        Me.butContentFont = New System.Windows.Forms.Button()
        Me.butTitleBackcolor = New System.Windows.Forms.Button()
        Me.nudOpacity = New System.Windows.Forms.NumericUpDown()
        Me.lblOpacity = New System.Windows.Forms.Label()
        Me.gpbColors.SuspendLayout()
        CType(Me.nudOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'butEForecolor
        '
        Me.butEForecolor.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butEForecolor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butEForecolor.ForeColor = System.Drawing.Color.Lime
        Me.butEForecolor.Location = New System.Drawing.Point(7, 27)
        Me.butEForecolor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.butEForecolor.Name = "butEForecolor"
        Me.butEForecolor.Size = New System.Drawing.Size(175, 28)
        Me.butEForecolor.TabIndex = 0
        Me.butEForecolor.Text = "&Forecolor"
        '
        'butEBackcolor
        '
        Me.butEBackcolor.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butEBackcolor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butEBackcolor.Location = New System.Drawing.Point(7, 61)
        Me.butEBackcolor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.butEBackcolor.Name = "butEBackcolor"
        Me.butEBackcolor.Size = New System.Drawing.Size(175, 28)
        Me.butEBackcolor.TabIndex = 1
        Me.butEBackcolor.Text = "&Backcolor"
        '
        'butTForecolor
        '
        Me.butTForecolor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butTForecolor.Location = New System.Drawing.Point(215, 27)
        Me.butTForecolor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.butTForecolor.Name = "butTForecolor"
        Me.butTForecolor.Size = New System.Drawing.Size(175, 28)
        Me.butTForecolor.TabIndex = 2
        Me.butTForecolor.Text = "&Title forecolor"
        '
        'chkAutosave
        '
        Me.chkAutosave.AutoSize = True
        Me.chkAutosave.Location = New System.Drawing.Point(7, 192)
        Me.chkAutosave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkAutosave.Name = "chkAutosave"
        Me.chkAutosave.Size = New System.Drawing.Size(78, 19)
        Me.chkAutosave.TabIndex = 3
        Me.chkAutosave.Text = "&Auto save"
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Location = New System.Drawing.Point(7, 218)
        Me.chkActive.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(178, 19)
        Me.chkActive.TabIndex = 4
        Me.chkActive.Text = "&Show active notes on startup"
        '
        'butExit
        '
        Me.butExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butExit.Location = New System.Drawing.Point(238, 212)
        Me.butExit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.butExit.Name = "butExit"
        Me.butExit.Size = New System.Drawing.Size(152, 29)
        Me.butExit.TabIndex = 6
        Me.butExit.Text = "E&xit"
        '
        'butFonts
        '
        Me.butFonts.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butFonts.Location = New System.Drawing.Point(238, 162)
        Me.butFonts.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.butFonts.Name = "butFonts"
        Me.butFonts.Size = New System.Drawing.Size(152, 28)
        Me.butFonts.TabIndex = 5
        Me.butFonts.Text = "Fo&nts"
        '
        'gpbColors
        '
        Me.gpbColors.Controls.Add(Me.butTitleFont)
        Me.gpbColors.Controls.Add(Me.butContentFont)
        Me.gpbColors.Controls.Add(Me.butEBackcolor)
        Me.gpbColors.Controls.Add(Me.butEForecolor)
        Me.gpbColors.Controls.Add(Me.butTitleBackcolor)
        Me.gpbColors.Controls.Add(Me.butTForecolor)
        Me.gpbColors.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpbColors.Location = New System.Drawing.Point(0, 0)
        Me.gpbColors.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gpbColors.Name = "gpbColors"
        Me.gpbColors.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gpbColors.Size = New System.Drawing.Size(399, 145)
        Me.gpbColors.TabIndex = 0
        Me.gpbColors.TabStop = False
        '
        'butTitleFont
        '
        Me.butTitleFont.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butTitleFont.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butTitleFont.Location = New System.Drawing.Point(215, 96)
        Me.butTitleFont.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.butTitleFont.Name = "butTitleFont"
        Me.butTitleFont.Size = New System.Drawing.Size(175, 28)
        Me.butTitleFont.TabIndex = 1
        Me.butTitleFont.Text = "Title font"
        '
        'butContentFont
        '
        Me.butContentFont.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butContentFont.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butContentFont.Location = New System.Drawing.Point(7, 95)
        Me.butContentFont.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.butContentFont.Name = "butContentFont"
        Me.butContentFont.Size = New System.Drawing.Size(175, 28)
        Me.butContentFont.TabIndex = 1
        Me.butContentFont.Text = "Content font"
        '
        'butTitleBackcolor
        '
        Me.butTitleBackcolor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butTitleBackcolor.Location = New System.Drawing.Point(215, 62)
        Me.butTitleBackcolor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.butTitleBackcolor.Name = "butTitleBackcolor"
        Me.butTitleBackcolor.Size = New System.Drawing.Size(175, 28)
        Me.butTitleBackcolor.TabIndex = 2
        Me.butTitleBackcolor.Text = "&Title backcolor"
        '
        'nudOpacity
        '
        Me.nudOpacity.Location = New System.Drawing.Point(58, 162)
        Me.nudOpacity.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.nudOpacity.Name = "nudOpacity"
        Me.nudOpacity.Size = New System.Drawing.Size(43, 23)
        Me.nudOpacity.TabIndex = 2
        Me.nudOpacity.Value = New Decimal(New Integer() {95, 0, 0, 0})
        '
        'lblOpacity
        '
        Me.lblOpacity.AutoSize = True
        Me.lblOpacity.Location = New System.Drawing.Point(6, 165)
        Me.lblOpacity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOpacity.Name = "lblOpacity"
        Me.lblOpacity.Size = New System.Drawing.Size(48, 15)
        Me.lblOpacity.TabIndex = 1
        Me.lblOpacity.Text = "&Opacity"
        '
        'StickNoteSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.butExit
        Me.ClientSize = New System.Drawing.Size(399, 257)
        Me.Controls.Add(Me.lblOpacity)
        Me.Controls.Add(Me.nudOpacity)
        Me.Controls.Add(Me.butFonts)
        Me.Controls.Add(Me.butExit)
        Me.Controls.Add(Me.chkActive)
        Me.Controls.Add(Me.chkAutosave)
        Me.Controls.Add(Me.gpbColors)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StickNoteSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.gpbColors.ResumeLayout(False)
        CType(Me.nudOpacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents butEForecolor As System.Windows.Forms.Button
    Friend WithEvents butEBackcolor As System.Windows.Forms.Button
    Friend WithEvents butTForecolor As System.Windows.Forms.Button
    Friend WithEvents colDG As System.Windows.Forms.ColorDialog
    Friend WithEvents chkAutosave As System.Windows.Forms.CheckBox
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    Friend WithEvents butExit As System.Windows.Forms.Button
    Friend WithEvents butFonts As System.Windows.Forms.Button
    Friend WithEvents fntDg As System.Windows.Forms.FontDialog
    Friend WithEvents gpbColors As System.Windows.Forms.GroupBox
    Friend WithEvents nudOpacity As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblOpacity As System.Windows.Forms.Label
    Friend WithEvents butContentFont As Button
    Friend WithEvents butTitleBackcolor As Button
    Friend WithEvents butTitleFont As Button
End Class
