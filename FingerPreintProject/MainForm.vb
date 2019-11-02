
Public Class MainForm

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub GetInfo_Click(sender As Object, e As EventArgs) Handles RegistrationMenu.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New Form1
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me
        ChildForm.StartPosition = FormStartPosition.Manual ' top left 0 0 
        ChildForm.Show()

        RegistrationMenu.Enabled = False 'disable the button , to avoide dublicate and shoing mre than one form
    End Sub

    Private Sub InformationsMenu_Click(sender As Object, e As EventArgs) Handles InformationsMenu.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New InformationForm
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me
        ChildForm.StartPosition = FormStartPosition.Manual ' top left 0 0 
        ChildForm.Show()

        InformationsMenu.Enabled = False 'disable the button , to avoide dublicate and shoing mre than one form

    End Sub
End Class
