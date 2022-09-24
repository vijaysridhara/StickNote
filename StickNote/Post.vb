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
Public Class Post

    Private prevX As Integer
    Private prevY As Integer
    Private prevX1 As Integer
    Private prevY1 As Integer
    Private bpen As New Pen(Color.Black, 1)
    Private checkPrint As Integer
    Private def_fname As String
    Friend WithEvents prdDoc As New Printing.PrintDocument
    Private oldPost As Boolean
    Private postid As Integer = -1
    Private _isLoading As Boolean
    Private DefSize As Size
    Private prestackLoc As Point

    Public Property IsLoading As Boolean
        Get
            Return _isLoading
        End Get
        Set(value As Boolean)
            _isLoading = value
        End Set
    End Property
    Public Sub New(pid As Integer)
        InitializeComponent()
        postid = pid
        oldPost = True
        DefSize = Me.Size
        LoadFile(pid)
        prestackLoc = Me.Location
    End Sub
 
    Public ReadOnly Property GetPostID() As Integer
        Get
            Return postid
        End Get
    End Property
    Property EFont() As Font
        Get
            Return txtContent.Font
        End Get
        Set(ByVal value As Font)
            txtContent.Font = value
        End Set
    End Property
    Property TFont() As Font
        Get
            Return Title1.Font
        End Get
        Set(ByVal value As Font)
            Title1.Font = value
        End Set
    End Property
    Property EditForecolor() As Color
        Get
            Return txtContent.ForeColor
        End Get
        Set(ByVal value As Color)
            txtContent.ForeColor = value
        End Set
    End Property
    Property TitleForeColor() As Color
        Get
            Return Title1.TitleForeColor
        End Get
        Set(ByVal value As Color)
            Title1.TitleForeColor = value
        End Set
    End Property
    Property TitleBackColor() As Color
        Get
            Return Title1.BackColor
        End Get
        Set(ByVal value As Color)
            Title1.BackColor = value
        End Set
    End Property
    Sub AutosaveEnable()
        tmrAutosave.Enabled = My.Settings.AutoSave
        If My.Settings.AutoSave Then
            tmrAutosave.Start()
        Else
            tmrAutosave.Stop()
        End If
    End Sub

    Property EditBackcolor() As Color
        Get
            Return txtContent.BackColor
        End Get
        Set(ByVal value As Color)
            txtContent.BackColor = value
            lblRight.BackColor = value
            lblDate.BackColor = value

        End Set
    End Property
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DefSize = Me.Size
    End Sub
    Friend Property Title() As String
        Get
            Return Title1.Text
        End Get
        Set(ByVal value As String)
            Title1.Text = value
        End Set
    End Property


    Private Sub Label1_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        ' Me.Size = New Size(Label1.Left + Label1.Width + 1, Label1.Top + Label1.Height + 1)
    End Sub

    Private Sub Label1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        prevX = e.X
        prevY = e.Y
    End Sub

    Private Sub Label1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.Cursor = Cursors.SizeNWSE
        'If e.Button = Windows.Forms.MouseButtons.Left Then
        '    Label1.Location = New Point(Label1.Left - (prevX - e.X), Label1.Top - (prevY - e.Y))
        'End If
    End Sub
    Friend Sub Save(Optional explicit As Boolean = False)
        On Error GoTo eD
        If txtContent.Modified Or explicit Then
            If oldPost Then
                cmd.Connection = conn
                cmd.CommandText = "UPDATE ENTRIES SET HEIGHT=?,WIDTH=?,POSX=?,POSY=?,TITLE=?,CONTENT=? WHERE ID=?"
                cmd.Parameters.Clear()
                cmd.Parameters.Add("HEIGHT", Data.DbType.Int32)
                cmd.Parameters.Add("WIDTH", Data.DbType.Int32)
                cmd.Parameters.Add("POSX", Data.DbType.Int32)
                cmd.Parameters.Add("POSY", Data.DbType.Int32)
                cmd.Parameters.Add("TITLE", Data.DbType.StringFixedLength)
                cmd.Parameters.Add("CONTENT", Data.DbType.String)
                cmd.Parameters.Add("ID", Data.DbType.Int32)
                cmd.Parameters("HEIGHT").Value = DefSize .Height
                cmd.Parameters("WIDTH").Value = DefSize.Width
                cmd.Parameters("POSX").Value = prestackLoc.X
                cmd.Parameters("POSY").Value = prestackLoc.Y
                cmd.Parameters("TITLE").Value = Title
                cmd.Parameters("CONTENT").Value = txtContent.Rtf
                cmd.Parameters("ID").Value = postid
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
                txtContent.Modified = False
            Else
                cmd.Connection = conn
                cmd.CommandText = "INSERT INTO ENTRIES(HEIGHT,WIDTH,POSX,POSY,TITLE,CONTENT,ONDATE)VALUES(?,?,?,?,?,?,?)"
                cmd.Parameters.Clear()
                cmd.Parameters.Add("HEIGHT", Data.DbType.Int32)
                cmd.Parameters.Add("WIDTH", Data.DbType.Int32)
                cmd.Parameters.Add("POSX", Data.DbType.Int32)
                cmd.Parameters.Add("POSY", Data.DbType.Int32)
                cmd.Parameters.Add("TITLE", Data.DbType.StringFixedLength)
                cmd.Parameters.Add("CONTENT", Data.DbType.String)
                cmd.Parameters.Add("ONDATE", Data.DbType.DateTime)
                cmd.Parameters("HEIGHT").Value = DefSize.Height
                cmd.Parameters("WIDTH").Value = DefSize.Width
                cmd.Parameters("POSX").Value = prestackLoc.X
                cmd.Parameters("POSY").Value = prestackLoc.Y
                cmd.Parameters("TITLE").Value = Title
                cmd.Parameters("CONTENT").Value = txtContent.Rtf
                cmd.Parameters("ONDATE").Value = Format(Date.Now, "yyyy-MM-dd HH:mm:ss")
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
                cmd.CommandText = "Select MAX(id),ONDATE from ENTRIES "
                rDr = cmd.ExecuteReader()
                If rDr.Read Then
                    postid = rDr(0)
                    lblDate.Text = Format(CDate(rDr(1)), "yyyy-MM-dd HH:mm:ss")
                    oldPost = True
                End If
                rDr.Close()

            End If
        End If
        Exit Sub
eD:
        DE()
    End Sub
    Public Sub LoadFile(ByVal id As Integer)
        On Error GoTo ED
        Me.IsLoading = True
        cmd.Connection = conn
        cmd.CommandText = "SELECT TITLE,POSX,POSY,WIDTH,HEIGHT,CONTENT,ONDATE FROM ENTRIES WHERE ID=?"
        cmd.Parameters.Clear()
        cmd.Parameters.Add("ID", Data.DbType.Int32)
        cmd.Parameters("ID").Value = id
        rDr = cmd.ExecuteReader
        If rDr.Read Then
            txtContent.Rtf = rDr(5)
            lblDate.Text = Format(CDate(rDr(6).ToString), "yyyy-mm-dd HH:mm:ss")
            Me.Location = New Point(rDr(1), rDr(2))
            Me.Size = New Size(rDr(3), rDr(4))
            Me.Title = rDr(0)
        End If
        rDr.Close()
        Me.IsLoading = False
        Exit Sub
ED:
        DE()
    End Sub


    Private Sub Post_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
     
        tmrAutosave.Enabled = False
        tmrAutosave.Stop()
    End Sub

    Private Sub Post_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Location = New Point(Screen.PrimaryScreen.Bounds.Right - Me.Width - 50, Screen.PrimaryScreen.Bounds.Top + 50)

        Title1.Text = "StickNote-" & GetZNumber()
        AutosaveEnable()
        EditForecolor = My.Settings.NoteForeColor
        EditBackcolor = My.Settings.NoteBackColor
        Title1.BackColor = My.Settings.TitleBackColor
        Title1.TitleForeColor = My.Settings.TitleForeColor

        'Title1.TitleBackColor = m_TBackcolor
        'Title1.TitleForeColor = m_TForecolor
        EFont = My.Settings.NoteFont
        TFont = My.Settings.TitleFont
        '  Label1.BringToFront()
        Me.Opacity = My.Settings.Opacity / 100
        'Me.Size = New Size(550, 650)
    End Sub



    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        e.Graphics.DrawRectangle(bpen, 0, 0, Me.Width - 1, Me.Height - 1)
    End Sub

    Private Sub Title1_CloseClicked() Handles Title1.CloseClicked
        Me.Save()
        Me.Close()
        Me.Dispose()
    End Sub


    Dim _ismaxminclicked As Boolean
    Private Sub Title1_MaxMinClicked(ismax As Boolean) Handles Title1.MaxMinClicked
        _ismaxminclicked = True

        If ismax Then
            Me.Height = Title1.Height
            PNLbOTTOM.Hide()
        Else
            Me.Height = DefSize.Height
            PNLbOTTOM.Show()
        End If
        _ismaxminclicked = False
    End Sub

    Public Sub Minimize(width As Integer)
        _ismaxminclicked = True
        Me.Height = Title1.Height
        Me.Width = width
        PNLbOTTOM.Hide()
        Title1.butMax.ImageIndex = 1
        _ismaxminclicked = False
    End Sub
    Public Sub Maximize()
        _ismaxminclicked = True

        Me.Size = DefSize
        PNLbOTTOM.Show()
        Title1.butMax.ImageIndex = 0
        _ismaxminclicked = False
    End Sub
    Public Sub StackReady(loc As Point, width As Integer)

        Minimize(width)
        Me.Location = loc
    End Sub
    Public Sub Unstack()
        Maximize()

        Me.Location = prestackLoc
    End Sub
    Private Sub Title1_MouseMoveEvent(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Title1.MouseMoveEvent
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location = New Point(Me.Left - (prevX1 - e.X), Me.Top - (prevY1 - e.Y))
            prestackLoc = Me.Location
        End If
    End Sub

    Private Sub Title1_PaddingChanged(sender As Object, e As System.EventArgs)

    End Sub


    Private Sub Title1_TMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Title1.TMouseDown
        prevX1 = e.X
        prevY1 = e.Y
    End Sub


    Private Sub Post_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Invalidate()
        If _ismaxminclicked = False Then
            DefSize = Me.Size

        End If
    End Sub

    Private Sub ctxEdit_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ctxEdit.Opening
        If txtContent.CanUndo Then
            UndoToolStripMenuItem.Enabled = True
        Else
            UndoToolStripMenuItem.Enabled = False
        End If
        If txtContent.CanRedo Then
            RedoToolStripMenuItem.Enabled = True
        Else
            RedoToolStripMenuItem.Enabled = False
        End If
        If txtContent.SelectionLength > 0 Then
            CutToolStripMenuItem.Enabled = True
            CopyToolStripMenuItem.Enabled = True
        Else
            CutToolStripMenuItem.Enabled = False
            CopyToolStripMenuItem.Enabled = False
        End If
        If Clipboard.ContainsData(DataFormats.Rtf) Or Clipboard.ContainsData(DataFormats.Bitmap) Or Clipboard.ContainsData(DataFormats.Text) Or Clipboard.ContainsData(DataFormats.Html) Then
            PasteToolStripMenuItem.Enabled = True
        Else
            PasteToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        'Clipboard.SetData(DataFormats.Rtf, txtContent.SelectedRtf)
        txtContent.Copy()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        txtContent.Cut()
        'Clipboard.SetData(DataFormats.Rtf, txtContent.SelectedRtf)
        'txtContent.SelectedText = ""
    End Sub

    Private Sub HidenotesToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HidenotesToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub NewnoteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewnoteToolStripMenuItem.Click
        CreateNewPost()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        txtContent.Paste()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        txtContent.Redo()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        txtContent.Undo()
    End Sub

    Private Sub SavenoteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SavenoteToolStripMenuItem.Click
        Save()
    End Sub

    Private Sub SelectallToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SelectallToolStripMenuItem.Click
        txtContent.SelectAll()
    End Sub

    Private Sub PrintnoteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintnoteToolStripMenuItem.Click
        Try
            prdDoc.Print()

        Catch ex As Exception
            DE()
        End Try
    End Sub

    Private Sub prdDoc_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles prdDoc.BeginPrint
        psdSetup.Document = prdDoc
        ppvdPreview.Document = prdDoc
        psdSetup.Document = prdDoc
        checkPrint = 0

    End Sub

    Private Sub prdDoc_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles prdDoc.PrintPage
        ' Print the content of the RichTextBox. Store the last character printed.
        psdSetup.Document = prdDoc
        ppvdPreview.Document = prdDoc
        psdSetup.Document = prdDoc

        checkPrint = txtContent.Print(checkPrint, txtContent.TextLength, e)

        ' Look for more pages
        If checkPrint < txtContent.TextLength Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If

    End Sub
    Private Sub PageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageToolStripMenuItem.Click
        Try
            psdSetup.Document = prdDoc
            ppvdPreview.Document = prdDoc
            psdSetup.Document = prdDoc

            psdSetup.ShowDialog()

        Catch ex As Exception
            DE()
        End Try
    End Sub
    Private Sub PrintpreviewToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrintpreviewToolStripMenuItem.Click
        Try
            psdSetup.Document = prdDoc
            ppvdPreview.Document = prdDoc
            psdSetup.Document = prdDoc

            ppvdPreview.ShowDialog()

        Catch ex As Exception
            DE()
        End Try
    End Sub

    Private Sub tmrAutosave_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAutosave.Tick
        If (txtContent.Modified Or Title1.txtTitle.Modified) And IsLoading = False Then Save()
    End Sub

    Private Sub TogglewordwrapToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TogglewordwrapToolStripMenuItem.Click
        If txtContent.WordWrap Then
            txtContent.WordWrap = False
        Else
            txtContent.WordWrap = True
        End If
    End Sub

    Private Sub StayontopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StayontopToolStripMenuItem.Click
        If Me.TopMost Then
            Me.TopMost = False
            StayontopToolStripMenuItem.Checked = False
        Else
            Me.TopMost = True
            StayontopToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub StatusStrip1_SizeChanged(sender As Object, e As System.EventArgs)

    End Sub

    Private Sub lblRight_Click(sender As System.Object, e As System.EventArgs) Handles lblRight.Click

    End Sub

    Private Sub lblRight_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblRight.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            prevX = e.X
            prevY = e.Y
        End If
    End Sub

    Private Sub lblRight_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblRight.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.Size.Width + (e.X - prevX), Me.Size.Height + (e.Y - prevY))
        End If
    End Sub

    Private Sub txtContent_ModifiedChanged(sender As Object, e As System.EventArgs) Handles txtContent.ModifiedChanged
        If IsLoading And txtContent.Modified Then
            txtContent.Modified = False
        End If
    End Sub

    Private Sub ShowOrganizerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ShowOrganizerToolStripMenuItem.Click
        Dim bk As New Book
        bk.Show(Me)
    End Sub

    Private Sub Title1_PinClicked(topi As Boolean) Handles Title1.PinClicked
        StayontopToolStripMenuItem_Click(Nothing, Nothing)
    End Sub
End Class
