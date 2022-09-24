'***************************************************************************************
'Version: 1.1.0.0
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
Module modFun
    Dim newpost As Post
    Friend GemnoteNumber As Long = 0
    Friend NotePath As String

    Friend STICKYNOTEPATH As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\StickyNoteData"
    Friend STICKYNOTEDB As String = STICKYNOTEPATH & "\sn.db"
    Friend ACTIVENOTEPATH As String = STICKYNOTEPATH & "\activenotes.ini"


    Friend WithEvents ppvdPreview As New PrintPreviewDialog
    Friend WithEvents psdSetup As New PageSetupDialog
    Friend WithEvents pdPring As New PrintDialog
    Friend CONSTR As String = "Data Source={0};Version=3;"
    Friend conn As SQLiteConnection
    Friend rDr As SQLiteDataReader
    Friend cmd As New SQLiteCommand
    Friend Function GetZNumber() As Long
        GemnoteNumber = GemnoteNumber + 1
        Return GemnoteNumber
    End Function
    Friend Sub DE(ed As Exception)
        MsgBox(ed.Message, MsgBoxStyle.Critical)
    End Sub
    Friend Function CheckifOpen(id As Integer) As Boolean
        Dim frm As Form
        For Each frm In Application.OpenForms
            If TypeOf frm Is Post Then
                If CType(frm, Post).GetPostID = id Then
                    frm.Visible = True
                    frm.BringToFront()
                    Return True
                End If

            End If
        Next
        Return False
    End Function
    Friend Sub Updatecolors()
        Dim frm As Form
        For Each frm In Application.OpenForms
            If TypeOf frm Is Post Then
                CType(frm, Post).TitleForeColor = My.Settings.TitleForeColor
                CType(frm, Post).TitleBackColor = My.Settings.TitleBackColor
                CType(frm, Post).EditBackcolor = My.Settings.NoteBackColor
                CType(frm, Post).EditForecolor = My.Settings.NoteForeColor
            End If
        Next
    End Sub
    Friend Sub UpdateFonts()
        Dim frm As Form
        For Each frm In Application.OpenForms
            If TypeOf frm Is Post Then
                CType(frm, Post).EFont = My.Settings.NoteFont
                CType(frm, Post).TFont = My.Settings.TitleFont
            End If
        Next
    End Sub
    Friend Sub UpdateOpacity()
        Dim frm As Form
        For Each frm In Application.OpenForms
            If TypeOf frm Is Post Then
                CType(frm, Post).Opacity = My.Settings.Opacity / 100
            End If
        Next
    End Sub
    Friend Sub EnableAutosave()
        Dim frm As Form
        For Each frm In Application.OpenForms
            If TypeOf frm Is Post Then
                CType(frm, Post).AutosaveEnable()
            End If
        Next
    End Sub

    Friend Function CreateNewPost(Optional id As Integer = -1) As Post
       
        If id <> -1 Then
            newpost = New Post(id)
            newpost.Show()
            newpost.LoadFile(id)
        Else
            newpost = New Post
            newpost.Show()
            newpost.Location = New Point(300, 100)
        End If

        Return newpost
    End Function
    Public Sub DE()
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub
End Module
