
Public Class MainForm

    Private m_ChildFormNumber As Integer

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

    Private Sub InformationMenuItem_Click(sender As Object, e As EventArgs) Handles InformationMenuItem.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New InformationForm
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me
        ChildForm.StartPosition = FormStartPosition.Manual ' top left 0 0 

        ChildForm.Location = New Point(Me.Width / 2 - ChildForm.Width / 2, 0) ' center and top 0

        ChildForm.Show()

        HospitalMenu.Enabled = False 'disable the button , to avoide dublicate and shoing mre than one form
    End Sub

    Private Sub RegistrationMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrationMenuItem.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New Form1
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me
        ChildForm.StartPosition = FormStartPosition.Manual ' top left 0 0 
        ChildForm.Location = New Point(Me.Width / 2 - ChildForm.Width / 2, 0) ' center and top 0
        ChildForm.Show()

        MinistryOfHealthMenu.Enabled = False 'disable the button , to avoide dublicate and shoing mre than one form
    End Sub

    Private Sub UpdatingMenuItem_Click(sender As Object, e As EventArgs) Handles UpdatingMenuItem.Click
        MessageBox.Show("باقي ما برمجتها سيكون فيه تعديل على البيانات وحذف السجل في حالة الوفاة",
    "ملاحظة مهمة",
    MessageBoxButtons.OK,
    MessageBoxIcon.Exclamation,
    MessageBoxDefaultButton.Button1)

    End Sub
    Private Sub MainForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Refresh() 'for resizend background image in MainForm
    End Sub
    Private Sub MainForm_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Me.Refresh() 'for resizend background image in MainForm
    End Sub

End Class
