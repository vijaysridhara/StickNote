Imports System.Data.SQLite

Friend Class Book

    Dim dgmode As DragDropEffects = DragDropEffects.Move
    Private Sub NewcategoryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewcategoryToolStripMenuItem.Click
        Try
            cmd.Connection = conn
            Dim cat As String = InputBox("Category", "Category", "Project")
            Dim TN As TreeNode = TreeView1.SelectedNode
            cmd.Parameters.Clear()
            Dim catid As Integer = -1
            If Not TN Is Nothing Then catid = TN.Tag
            cmd.CommandText = "INSERT INTO CATEGORIES(CATNAME,PARENTCAT) VALUES('" & cat & "'," & catid & ")"
            cmd.ExecuteNonQuery()
            LoadCategories(TN)
            If TN.Name = "ROOT" Then
                TreeView1.Nodes("ROOT").Nodes.Add("Uncategorized", "Uncategorized", 0, 0).Tag = -2
                LoadNotes(TreeView1.Nodes("ROOT").Nodes("Uncategorized"))
            End If
            If Not TN Is Nothing Then TN.Expand()
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub
    Friend Sub LoadCategories(Optional TN As TreeNode = Nothing)
        Try
            TN.Nodes.Clear()
            Dim cmd As New SQLiteCommand
            Dim rdr As SQLiteDataReader
            cmd.Connection = conn
            Dim catid As Integer
            catid = TN.Tag
            cmd.CommandText = "SELECT CATNAME,CATID FROM CATEGORIES WHERE PARENTCAT=" & catid & " ORDER BY CATNAME ASC"
            rdr = cmd.ExecuteReader
            While rdr.Read
                Dim nn As TreeNode
                nn = TN.Nodes.Add(rdr(1), rdr(0), 0, 0)
                nn.Tag = rdr(1)
            End While
            rdr.Close()
            For Each XN As TreeNode In TN.Nodes
                LoadCategories(XN)
            Next
            LoadNotes(TN)
            cmd.Dispose()
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub
    Private Sub LoadNotes(tn As TreeNode)
        Try
            Dim cmd As New SQLiteCommand
            Dim rdr As SQLiteDataReader
            cmd.Connection = conn
            cmd.CommandText = "SELECT title,id FROM entries WHERE CATID=" & tn.Tag & " ORDER BY ondate ASC"
            rdr = cmd.ExecuteReader
            While rdr.Read
                Dim nn As TreeNode = tn.Nodes.Add(rdr(1), rdr(0), 1, 1)
                nn.Tag = rdr(1)
            End While
            rdr.Close()
            cmd.Dispose()
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub NewnoteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewnoteToolStripMenuItem.Click
        Try
            cmd.Connection = conn
            Dim cat As String = InputBox("Note name", "Note name", "Untitled")
            Dim TN As TreeNode = TreeView1.SelectedNode
            cmd.Parameters.Clear()
            Dim catid As Integer
            catid = TN.Tag
            cmd.CommandText = "INSERT INTO ENTRIES(TITLE,ONDATE,POSX,POSY,HEIGHT,WIDTH,CATID,CONTENT) VALUES('" & cat & "','" & Format(Date.Now, "yyyy-MM-dd HH:mm:ss") & "',100,200,300,200," & catid & ",'{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fnil\fcharset0 Arial;}}\viewkind4\uc1\pard\fs20\par}')"
            cmd.ExecuteNonQuery()
            LoadNotes(TN)
            TN.Expand()
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub ctxTree_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ctxTree.Opening
        If TreeView1.SelectedNode Is Nothing Then
            NewnoteToolStripMenuItem.Enabled = False
            NewcategoryToolStripMenuItem.Enabled = True
            DeleteCategoryToolStripMenuItem.Enabled = False
            DeleteNoteToolStripMenuItem.Enabled = False
            ReloadToolStripMenuItem.Enabled = False
        ElseIf TreeView1.SelectedNode.ImageIndex = 0 And TreeView1.SelectedNode.Text <> "Uncategorized" Then
            ReloadToolStripMenuItem.Enabled = True
            NewnoteToolStripMenuItem.Enabled = True
            NewcategoryToolStripMenuItem.Enabled = True
            DeleteCategoryToolStripMenuItem.Enabled = True
            DeleteNoteToolStripMenuItem.Enabled = False
        ElseIf TreeView1.SelectedNode.ImageIndex = 0 And TreeView1.SelectedNode.Text = "Uncategorized" Then
            ReloadToolStripMenuItem.Enabled = True
            NewnoteToolStripMenuItem.Enabled = True
            NewcategoryToolStripMenuItem.Enabled = False
            DeleteCategoryToolStripMenuItem.Enabled = False
            DeleteNoteToolStripMenuItem.Enabled = False
        ElseIf TreeView1.SelectedNode.ImageIndex = 1 Then
            ReloadToolStripMenuItem.Enabled = False
            NewnoteToolStripMenuItem.Enabled = False
            NewcategoryToolStripMenuItem.Enabled = False
            DeleteCategoryToolStripMenuItem.Enabled = False
            DeleteNoteToolStripMenuItem.Enabled = True
        Else
            ReloadToolStripMenuItem.Enabled = False
            NewnoteToolStripMenuItem.Enabled = False
            NewcategoryToolStripMenuItem.Enabled = True
            DeleteCategoryToolStripMenuItem.Enabled = False
            DeleteNoteToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub DeleteNoteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteNoteToolStripMenuItem.Click
        Try
            If MsgBox("Do you really want to delete this note", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.No Then Exit Sub
            cmd.Connection = conn
            cmd.CommandText = "DELETE FROM entries WHERE id=" & TreeView1.SelectedNode.Tag
            cmd.ExecuteNonQuery()
            TreeView1.SelectedNode.Remove()
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub DeleteCategoryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteCategoryToolStripMenuItem.Click
        Try

            If MsgBox("Do you really want to delete this category", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.No Then Exit Sub
            cmd.Connection = conn
            cmd.CommandText = "UPDATE ENTRIES SET CATID=-2 WHERE CATID=" & TreeView1.SelectedNode.Tag
            cmd.ExecuteNonQuery()
            cmd.CommandText = "DELETE FROM CATEGORIES WHERE CATID=" & TreeView1.SelectedNode.Tag
            cmd.ExecuteNonQuery()
            TreeView1.SelectedNode.Remove()
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub TreeView1_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect

        Try
            If TreeView1.SelectedNode.ImageIndex <> 1 Then
                txtContent.Enabled = False
                butSave.Enabled = False
            Else
                txtContent.Enabled = True
            End If
            cmd.Connection = conn
            isLoading = True
            cmd.CommandText = "SELECT title,content,ondate from entries where id=" & TreeView1.SelectedNode.Tag
            rDr = cmd.ExecuteReader
            If rDr.Read Then
                lblTitle.Text = rDr(0)
                txtContent.Rtf = IIf(rDr.IsDBNull(1), "", rDr(1))
                lblDate.Text = Format(CDate(rDr(2)), "yyyy-MM-dd HH:mm:ss")
                txtContent.Tag = TreeView1.SelectedNode.Tag
            End If
            rDr.Close()
            txtContent.Modified = False
            isLoading = False

        Catch ex As Exception
            isLoading = False
            DE(ex)
        End Try
    End Sub
    Dim isLoading As Boolean

    Private Sub txtContent_ModifiedChanged(sender As Object, e As System.EventArgs) Handles txtContent.ModifiedChanged
        If Not isLoading Then butSave.Enabled = True
    End Sub
    Private Sub txtContent_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtContent.TextChanged
        If Not isLoading Then butSave.Enabled = True
    End Sub

    Private Sub Book_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        txtContent.BackColor = My.Settings.NoteBackColor
        txtContent.Font = My.Settings.NoteFont

        TreeView1.Nodes.Add("ROOT", "Note Collection", 2, 2).Tag = "-1"
        LoadCategories(TreeView1.Nodes("ROOT"))
        TreeView1.Nodes("ROOT").Nodes.Add("Uncategorized", "Uncategorized", 0, 0).Tag = -2
        LoadNotes(TreeView1.Nodes("ROOT").Nodes("Uncategorized"))

        TreeView1.Nodes("ROOT").Expand()
        Try
            cmd.Connection = conn
            cmd.CommandText = "SELECT TITLE,ID FROM ENTRIES WHERE DATE(ONDATE)='" & Format(MonthCalendar1.SelectionStart, "yyyy-MM-dd") & "' ORDER BY ID"
            cmd.Parameters.Clear()
            rDr = cmd.ExecuteReader
            lstNotes.Items.Clear()
            While rDr.Read
                lstNotes.Items.Add(rDr(0) & "~" & rDr(1))
            End While
            rDr.Close()
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub Book_LocationChanged(sender As Object, e As System.EventArgs) Handles Me.LocationChanged

    End Sub

    Private Sub TreeView1_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles TreeView1.DragDrop
        If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", False) Then
            Dim NewNode As TreeNode
            Dim pt As Point
            Dim DestinationNode As TreeNode
            pt = CType(sender, TreeView).PointToClient(New Point(e.X, e.Y))
            DestinationNode = CType(sender, TreeView).GetNodeAt(pt)
            If DestinationNode Is DBNull.Value Then Exit Sub
            'If DestinationNode.ImageIndex <> 2 Then Exit Sub
            NewNode = CType(e.Data.GetData("System.Windows.Forms.TreeNode"),  _
                                            TreeNode)
            'If Not DestinationNode.TreeView Is NewNode.TreeView Then
            If NewNode.Name = "ROOT" Then Exit Sub
            If DestinationNode Is Nothing Then Exit Sub
            If DestinationNode.ImageIndex = 1 Then Exit Sub
            If DestinationNode Is NewNode.Parent Then Exit Sub
            Dim str As String = DestinationNode.FullPath
            If InStr(GetFullpath(DestinationNode), NewNode.Name) > 0 Then
                MsgBox("This would introduce cyclic redundancy", MsgBoxStyle.Information Or MsgBoxStyle.Exclamation)
                Exit Sub
            Else
                Try
                    Dim dropSourceindex As Integer = NewNode.ImageIndex
                    Dim dropTargetindex As Integer = DestinationNode.ImageIndex
                    cmd.Parameters.Clear()
                    If dropSourceindex = 1 And dropTargetindex = 0 Then
                        cmd.CommandText = "UPDATE ENTRIES SET CATID=" & DestinationNode.Tag & " WHERE ID=" & NewNode.Tag
                        cmd.ExecuteNonQuery()
                    ElseIf dropSourceindex = 0 And dropTargetindex = 0 Then
                        cmd.CommandText = "UPDATE CATEGORIES SET PARENTCAT=" & DestinationNode.Tag & " WHERE CATID=" & NewNode.Tag
                        cmd.ExecuteNonQuery()
                    ElseIf dropSourceindex = 0 And dropTargetindex = 2 Then
                        cmd.CommandText = "UPDATE CATEGORIES SET PARENTCAT=" & DestinationNode.Tag & " WHERE CATID=" & NewNode.Tag
                        cmd.ExecuteNonQuery()
                    ElseIf dropSourceindex = 1 Then
                        Exit Sub
                    ElseIf DestinationNode.Text = "Uncategorized" And dropSourceindex = 1 Then
                        Exit Sub
                    ElseIf dropTargetindex = 1 And NewNode.Text = "Uncategorized" Then
                        Exit Sub
                    End If
                Catch ex As Exception
                    DE(ex)
                End Try
            End If
            DestinationNode.Nodes.Add(NewNode.Clone)
            DestinationNode.Expand()
            'Remove original node
            NewNode.Remove()
            'End If
        End If
    End Sub
    Private Function GetFullpath(ByVal dn As TreeNode) As String
        Dim ret As String = "", nn As TreeNode
        nn = dn
        While nn.Name <> "ROOT"

            ret = ret & "\" & nn.Name
            nn = nn.Parent
        End While
        ret = "ROOT" & ret
        Return ret
    End Function
    Private Sub TreeView1_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles TreeView1.DragEnter
        If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", _
            True) Then
            'TreeNode found allow move effect
            e.Effect = dgmode
        Else
            'No TreeNode found, prevent move
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub TreeView1_ItemDrag(sender As Object, e As System.Windows.Forms.ItemDragEventArgs) Handles TreeView1.ItemDrag
        If CType(e.Item, TreeNode).Text = "Uncategorized" Or CType(e.Item, TreeNode).Text = "ROOT" Then Exit Sub
        DoDragDrop(e.Item, dgmode)
    End Sub

    Private Sub TreeView1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TreeView1.MouseDown
        If Not TreeView1.HitTest(e.Location).Node Is Nothing Then
            TreeView1.SelectedNode = TreeView1.HitTest(e.Location).Node
        End If
    End Sub

    Private Sub butSave_Click(sender As System.Object, e As System.EventArgs) Handles butSave.Click
        Try
            cmd.Connection = conn
            cmd.Parameters.Clear()
            cmd.CommandText = "UPDATE ENTRIES SET CONTENT=? WHERE ID=?"
            cmd.Parameters.Add("CONTENT", Data.DbType.String)
            cmd.Parameters.Add("ID", Data.DbType.Int32)
            cmd.Parameters("CONTENT").Value = txtContent.Rtf
            cmd.Parameters("ID").Value = txtContent.Tag
            cmd.ExecuteNonQuery()
            butSave.Enabled = False
            txtContent.Modified = False
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub


    Private Sub MonthCalendar1_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Try
            cmd.Connection = conn
            cmd.CommandText = "SELECT TITLE,ID FROM ENTRIES WHERE DATE(ONDATE)='" & Format(MonthCalendar1.SelectionStart, "yyyy-MM-dd") & "' ORDER BY ID"
            cmd.Parameters.Clear()
            rDr = cmd.ExecuteReader
            lstNotes.Items.Clear()
            txtContent.Enabled = False
            butSave.Enabled = False
            While rDr.Read
                lstNotes.Items.Add(rDr(0) & "~" & rDr(1))
            End While
            rDr.Close()
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub


    Private Sub lstNotes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstNotes.SelectedIndexChanged
        On Error Resume Next
        If lstNotes.SelectedItems.Count = 0 Then Exit Sub
        Dim rst As String = lstNotes.SelectedItem
        Dim ID As Integer = rst.Split("~")(1)
        cmd.Connection = conn
        cmd.Parameters.Clear()
        txtContent.Enabled = True
        butSave.Enabled = False
        isLoading = True
        cmd.CommandText = "SELECT CONTENT FROM ENTRIES WHERE ID=" & ID
        rDr = cmd.ExecuteReader
        If rDr.Read Then
            txtContent.Rtf = rDr(0)
        End If
        rDr.Close()
        txtContent.Tag = ID
        isLoading = False
    End Sub

    Private Sub ReloadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReloadToolStripMenuItem.Click
        LoadCategories(TreeView1.SelectedNode)
    End Sub

    Private Sub TreeView1_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
        If e.Node.ImageIndex = 1 Then
            Dim id As Integer = e.Node.Tag
            Dim pst As New Post(id)
            pst.Show()
        End If
    End Sub
End Class