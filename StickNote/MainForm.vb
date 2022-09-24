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
Imports System.Data.SQLite
Imports System.IO

Public Class MainForm
    Private WithEvents nicMain As NotifyIcon


    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        'Call UnregisterHotKey(Me.Handle.ToInt32, &HA000&)
        'Call UnregisterHotKey(Me.Handle.ToInt32, &HA001&)
        'Call UnregisterHotKey(Me.Handle.ToInt32, &HA002&)
        'Call UnregisterHotKey(Me.Handle.ToInt32, &HA003&)

        Dim sw As IO.StreamWriter
        sw = New IO.StreamWriter(ACTIVENOTEPATH, False)
        Dim frm As Form
        For Each frm In Application.OpenForms
            If TypeOf frm Is Post Then
                If CType(frm, Post).txtContent.TextLength > 0 Then
                    CType(frm, Post).Save()
                    sw.WriteLine(CType(frm, Post).GetPostID)
                End If
            End If
        Next
        sw.Close()

    End Sub


    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Visible = False
        nicMain = New NotifyIcon
        If IO.Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments) Then
            If Not IO.Directory.Exists(STICKYNOTEPATH) Then
                Try
                    My.Computer.FileSystem.CreateDirectory(STICKYNOTEPATH)
                Catch ex As Exception
                    DE(ex)
                End Try

            End If
        End If

        If IO.File.Exists(STICKYNOTEDB) = False Then

            Dim br As BinaryWriter = New BinaryWriter(New IO.FileStream(STICKYNOTEDB, IO.FileMode.CreateNew))
            br.Write(My.Resources.sn)
        End If
        With nicMain
            .ContextMenuStrip = mnuMain
            .Text = "Double-Click for new"
            .Icon = Me.Icon
            .Visible = True
            .ShowBalloonTip("2000", "StickNote " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor, " Started", ToolTipIcon.Info)
        End With
        tmrClose.Enabled = True
        tmrClose.Start()

        Dim cstrg As String = String.Format(CONSTR, """" & STICKYNOTEDB & """").Trim
        conn = New SQLiteConnection(cstrg)
        conn.Open()
        If My.Settings.ActiveNotesAtStartup Then
            ShowActiveNotes()
        End If
        'bCancel = False
        'Dim m As HotkeyModifierFlags
        ''register the Ctrl-F hotkey
        'If RegisterHotKey(Me.Handle.ToInt32, &HA000&, m.MOD_CONTROL And m.MOD_SHIFT, Keys.N) = 0 Then
        '    MsgBox("Couldn't register hotkey for <New note>", MsgBoxStyle.Information Or MsgBoxStyle.Exclamation)
        'End If
        'If RegisterHotKey(Me.Handle.ToInt32, &HA001&, m.MOD_CONTROL And m.MOD_SHIFT, Keys.C) = 0 Then
        '    MsgBox("Couldn't register hotkey for <Close all notes>", MsgBoxStyle.Information Or MsgBoxStyle.Exclamation)
        'End If

        'If RegisterHotKey(Me.Handle.ToInt32, &HA002&, m.MOD_CONTROL And m.MOD_SHIFT, Keys.H) = 0 Then
        '    MsgBox("Couldn't register hotkey for <Hide all notes>", MsgBoxStyle.Information Or MsgBoxStyle.Exclamation)
        'End If
        'If RegisterHotKey(Me.Handle.ToInt32, &HA003&, m.MOD_CONTROL And m.MOD_SHIFT, Keys.S) = 0 Then
        '    MsgBox("Couldn't register hotkey for <Show all notes>", MsgBoxStyle.Information Or MsgBoxStyle.Exclamation)
        'End If

        'ProcessMessages()
    End Sub
    Private Sub ShowActiveNotes()
        If IO.File.Exists(ACTIVENOTEPATH) = False Then
            Exit Sub
        End If
        Dim sr As IO.StreamReader
        Dim st As IO.FileStream
        st = New IO.FileStream(ACTIVENOTEPATH, IO.FileMode.Open)
        sr = New IO.StreamReader(st)
        Try
            Dim rl As String

            While (sr.EndOfStream = False)
                rl = sr.ReadLine.Trim
                If rl = -1 Then Continue While
                If CheckifOpen(rl) = False Then CreateNewPost(rl)
            End While
            sr.Close()
        Catch ex As Exception
            DE()
        End Try

    End Sub
    Private Sub NewpostToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewpostToolStripMenuItem.Click
        CreateNewPost()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        nicMain.Dispose()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub tmrClose_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrClose.Tick
        Me.Hide()
        Me.Visible = False
        tmrClose.Stop()
        tmrClose.Enabled = False
    End Sub

    Private Sub OpenpostToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        StickNoteSettings.IsLoading = False
        StickNoteSettings.Show()
    End Sub

    Private Sub HideallpostsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideallpostsToolStripMenuItem.Click
        Dim frm As Form
        For Each frm In Application.OpenForms
            If TypeOf frm Is Post Then
                frm.Hide()
            End If
        Next

    End Sub

    Private Sub ShowallpostsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowallpostsToolStripMenuItem.Click
        Dim frm As Form
        For Each frm In Application.OpenForms
            If TypeOf frm Is Post Then
                frm.Show()
            End If
        Next
    End Sub

    'Private Sub CloseallnotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseallnotesToolStripMenuItem.Click
    '    On Error Resume Next
    '    Dim frm As Form
    '    For Each frm In Application.OpenForms
    '        If TypeOf frm Is Post Then
    '            frm.Close()
    '        End If
    '    Next
    'End Sub

    Private Sub ShowactivenotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowactivenotesToolStripMenuItem.Click
        ShowActiveNotes()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub nicMain_DoubleClick(sender As Object, e As System.EventArgs) Handles nicMain.DoubleClick
        CreateNewPost()
    End Sub

    Private Sub ShowOrganizerToolSTripMenuItem_Click(sender As Object, e As System.EventArgs) Handles ShowOrganizerToolSTripMenuItem.Click
        Dim bk As New Book
        bk.Show(Me)
    End Sub

    Private Sub StackItemstoRightMenuItem_Click(sender As Object, e As EventArgs) Handles StackItemstoRightMenuItem.Click
        Dim maxWidth As Integer = My.Computer.Screen.Bounds.Width
        Dim maxHeight As Integer = My.Computer.Screen.Bounds.Height
        Dim stackWidth As Integer = 200
        Dim stackHeight As Integer = 22
        Dim vertGap As Integer = 2
        Dim cnt As Integer = 0
        Dim BeginAt As Integer = 100
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is Post Then

                Dim loc As New Point(maxWidth - stackWidth - 10, cnt * (stackHeight + vertGap) + BeginAt)
                CType(frm, Post).StackReady(loc, stackWidth)
                cnt += 1
            End If
        Next
    End Sub

    Private Sub UnstackItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnstackItemsToolStripMenuItem.Click
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is Post Then
                CType(frm, Post).Unstack()
            End If
        Next
    End Sub
End Class