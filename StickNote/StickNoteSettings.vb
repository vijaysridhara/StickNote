Public Class StickNoteSettings
    Public m_isloading As Boolean
    Public Property IsLoading() As Boolean
        Get
            Return m_isloading
        End Get
        Set(ByVal value As Boolean)
            m_isloading = value
        End Set
    End Property
    Private Sub GSettings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        On Error Resume Next
        butEBackcolor.BackColor = My.Settings.NoteBackColor
        butEForecolor.BackColor = My.Settings.NoteForeColor
        butTForecolor.BackColor = My.Settings.TitleForeColor
        butTitleBackcolor.BackColor = My.Settings.TitleBackColor
        chkAutosave.Checked = My.Settings.AutoSave
        chkActive.Checked = My.Settings.ActiveNotesAtStartup
        butContentFont.Font = My.Settings.NoteFont
        butTitleFont.Font = My.Settings.TitleFont
        nudOpacity.Value = My.Settings.Opacity
        IsLoading = True
    End Sub

    Private Sub butEForecolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butEForecolor.Click
        With colDG
            .Color = My.Settings.NoteForeColor
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                If My.Settings.NoteForeColor = .Color Then Exit Sub
                butEForecolor.BackColor = .Color
                My.Settings.NoteForeColor = .Color
                My.Settings.Save()
                Updatecolors()
            End If
        End With
    End Sub

    Private Sub butEBackcolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butEBackcolor.Click
        With colDG
            .Color = My.Settings.NoteBackColor
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                If My.Settings.NoteBackColor = .Color Then Exit Sub
                butEBackcolor.BackColor = .Color
                My.Settings.NoteBackColor = .Color
                My.Settings.Save()
                Updatecolors()

            End If
        End With
    End Sub

    Private Sub butTForecolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butTForecolor.Click
        With colDG
            .Color = My.Settings.TitleForeColor
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                If My.Settings.TitleForeColor = .Color Then Exit Sub
                butTForecolor.BackColor = .Color
                My.Settings.TitleForeColor = .Color
                My.Settings.Save()
                Updatecolors()

            End If
        End With
    End Sub

    Private Sub butTBackcolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butTitleBackcolor.Click
        With colDG
            .Color = My.Settings.TitleBackColor
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                If My.Settings.TitleBackColor = .Color Then Exit Sub
                My.Settings.TitleBackColor = .Color
                My.Settings.Save()
                Updatecolors()

            End If
        End With
    End Sub



    Private Sub chkAutosave_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutosave.CheckedChanged
        My.Settings.AutoSave = chkAutosave.Checked
        EnableAutosave()
    End Sub

    Private Sub chkActive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActive.CheckedChanged
        My.Settings.ActiveNotesAtStartup = chkActive.Checked
    End Sub

    Private Sub butExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butExit.Click
        Me.Close()
    End Sub

    Private Sub butFonts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butFonts.Click

    End Sub

    Private Sub nudOpacity_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudOpacity.ValueChanged
        'since this is not getting set so I will use it this way
        If Not IsLoading Then Exit Sub
        My.Settings.Opacity = nudOpacity.Value
        My.Settings.Save()
        UpdateOpacity()
    End Sub

    Private Sub butContentFont_Click(sender As Object, e As EventArgs) Handles butContentFont.Click
        Dim fnt As New FontDialog
        With fnt
            .Font = My.Settings.NoteFont
            If .ShowDialog = DialogResult.OK Then
                If .Font.Equals(My.Settings.NoteFont) Then Exit Sub
                butContentFont.Font = .Font
                My.Settings.NoteFont = .Font
                My.Settings.Save()
                UpdateFonts()
            End If
        End With
    End Sub

    Private Sub butTitleFont_Click(sender As Object, e As EventArgs) Handles butTitleFont.Click
        Dim fnt As New FontDialog
        With fnt
            .Font = My.Settings.TitleFont
            If .ShowDialog = DialogResult.OK Then
                If .Font.Equals(My.Settings.TitleFont) Then Exit Sub
                butTitleFont.Font = .Font
                My.Settings.TitleFont = .Font
                My.Settings.Save()
                UpdateFonts()
            End If
        End With
    End Sub
End Class