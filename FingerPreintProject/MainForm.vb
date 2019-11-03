
Imports DPFP
Imports DPFP.Capture

Public Class MainForm
    Implements DPFP.Capture.EventHandler

    Private m_ChildFormNumber As Integer



#Region " for the Reader Connection and Disconnection"
    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete
        'no need this in mainForm
    End Sub
    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerGone
        'no need this in mainForm
    End Sub
    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerTouch
        'no need this in mainForm
    End Sub
    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As CaptureFeedback) Implements EventHandler.OnSampleQuality
        'no need this in mainForm
    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderConnect
        Invoke(Sub()
                   Ali_ReaderConnected_Green()
               End Sub)
    End Sub
    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderDisconnect
        Invoke(Sub()
                   Ali_ReaderDisconnect_Red()
               End Sub)
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'start cuptcher cuz i want detect the reader connected or not for green , red   

        'error happing whene try start using FP reader in other Forms

        Exit Sub ' can not inintinaize  StartCaptuer  'just removed this will work  but  cuzzes error
        Try
            Dim Capturer_ReaderStatus_C_D As DPFP.Capture.Capture = New DPFP.Capture.Capture() ' Create a capture operation.

            If (Not Capturer_ReaderStatus_C_D Is Nothing) Then
                Capturer_ReaderStatus_C_D.EventHandler = Me
                Capturer_ReaderStatus_C_D.StartCapture() ' Subscribe for capturing events.
            Else
                MsgBox("Can't initiate capture operation! - MainForm")
            End If
        Catch ex As Exception
            MessageBox.Show("Can't initiate capture operation! - MainForm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region


#Region "WindosMenu"

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
#End Region

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

        ' Create a new instance of the child form.
        Dim ChildForm As New TableForm
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me
        ChildForm.StartPosition = FormStartPosition.Manual ' top left 0 0 
        ChildForm.Location = New Point(Me.Width / 2 - ChildForm.Width / 2, 0) ' center and top 0
        ChildForm.Show()

        MinistryOfHealthMenu.Enabled = False 'disable the button , to avoide dublicate and shoing mre than one form

        Exit Sub
        MessageBox.Show("باقي ما برمجتها سيكون فيه تعديل على البيانات وحذف السجل في حالة الوفاة",
    "ملاحظة مهمة",
    MessageBoxButtons.OK,
    MessageBoxIcon.Exclamation,
    MessageBoxDefaultButton.Button1)

    End Sub

#Region "For Refreshing the background image"
    Private Sub MainForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Refresh() 'for resizend background image in MainForm
    End Sub
    Private Sub MainForm_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Me.Refresh() 'for resizend background image in MainForm
    End Sub
#End Region






End Class
