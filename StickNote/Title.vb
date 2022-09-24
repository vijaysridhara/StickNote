'***************************************************************************************
'Version: 1.0.0.0
'Author : Vijay S
'Email : vsridhara@gmail.com
'Date : 07-Dec-2005
'Copyright: (c) 2005 Vijaya Sridhara
'License: GPL- Please read GPL.txt or help file to understand the license terms to use 
' the source code or binaries
'Change notice: Please read the GPL before making any changes to understand the license 
'terms
'***************************************************************************************
Public Class Title
    Event CloseClicked()
    Event TitleChanged()
    Event MouseMoveEvent(ByVal sender As Object, ByVal e As MouseEventArgs)
    Event TMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
    Event MaxMinClicked(ismax As Boolean)
    Event PinClicked(topi As Boolean)
    Friend Property TitleForeColor() As Color
        Get
            Return lblTitle.ForeColor
        End Get
        Set(ByVal value As Color)
            lblTitle.ForeColor = value
            butClose.ForeColor = value
        End Set
    End Property
    'Friend Property TitleBackColor() As Color
    '    Get
    '        Return lblTitle.BackColor
    '    End Get
    '    Set(ByVal value As Color)
    '        lblTitle.BackColor = value
    '        butClose.BackColor = value
    '        Me.BackColor = value
    '    End Set
    'End Property
    Friend Overloads Property Text() As String
        Get
            Return txtTitle.Text
        End Get
        Set(ByVal value As String)
            txtTitle.Text = value
            lblTitle.Text = value
        End Set
    End Property
 
    Private Property CreateTime() As String

        Get
            Return txtTitle.Tag
        End Get
        Set(ByVal value As String)
            txtTitle.Tag = value
        End Set
    End Property
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtTitle.Location = New Point(1, 2)
        'txtTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Left

        'txtTitle.Size = New Size(ClientRectangle.Width - butClose.Width, butClose.Height)
        'txtTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Bottom Or AnchorStyles.Right
        txtTitle.Dock = DockStyle.Fill
        lblTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        lblTitle.Location = New Point(21, 2)
        lblTitle.Size = txtTitle.Size
        lblTitle.Anchor = txtTitle.Anchor
        'txtTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        Text = "StickNote"
        txtTitle.Visible = False
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub butClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClose.Click
        RaiseEvent CloseClicked()
    End Sub

    Private Sub txtTitle_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTitle.LostFocus
        lblTitle.Visible = True
        txtTitle.Visible = False
    End Sub

    Private Sub txtTitle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTitle.TextChanged
        lblTitle.Text = txtTitle.Text
        RaiseEvent TitleChanged()
    End Sub

    Private Sub lblTitle_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblTitle.DoubleClick

    End Sub

    Private Sub lblTitle_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblTitle.GotFocus
        txtTitle.Visible = False

    End Sub

    Private Sub lblTitle_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDoubleClick
        txtTitle.Visible = True
        lblTitle.Visible = False
        txtTitle.Focus()
        'txtTitle.BackColor = Color.White
        txtTitle.ForeColor = Color.Black
        txtTitle.BringToFront()
    End Sub

    Private Sub lblTitle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDown
        RaiseEvent TMouseDown(sender, e)
    End Sub

    Private Sub lblTitle_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseMove
        RaiseEvent MouseMoveEvent(sender, e)
    End Sub

    Private Sub butMax_Click(sender As System.Object, e As System.EventArgs) Handles butMax.Click
        If butMax.ImageIndex = 0 Then
            butMax.ImageIndex = 1
            RaiseEvent MaxMinClicked(True)
        Else
            butMax.ImageIndex = 0
            RaiseEvent MaxMinClicked(False)
        End If
    End Sub

    Private Sub butPin_Click(sender As System.Object, e As System.EventArgs) Handles butPin.Click
        If butPin.ImageIndex = 3 Then
            butPin.ImageIndex = 2
            RaiseEvent PinClicked(True)
        Else
            butPin.ImageIndex = 3
            RaiseEvent PinClicked(False)
        End If
    End Sub
    Public Overrides Property Font As Font
        Get
            Return lblTitle.Font
        End Get
        Set(value As Font)
            lblTitle.Font = value
        End Set
    End Property
End Class
