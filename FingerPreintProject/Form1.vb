Imports System.ComponentModel
Imports System.Data.SQLite
Imports DPFP
Imports DPFP.Capture

Public Class Form1
    Implements DPFP.Capture.EventHandler

    Private ali_Enrollment As DPFP.Processing.Enrollment
    Private ali_Capturer As DPFP.Capture.Capture

    Private theMaskFingeris As Integer = 0

    Private Sub EnrollFinger(lableName As Label, MaskFinger As String)
        lableName.BackColor = Color.Yellow
        startingConfigNew()
        theMaskFingeris = MaskFinger
        UpdateStatus_Ali()

        Panel_Images.Invoke(Sub()
                                Panel_Images.Visible = True
                            End Sub)

        StartCapture()
    End Sub

    Private Sub justMakeFingerGreen(fingerNumber As Integer)
        Select Case fingerNumber
            Case 1
                Finger_1.BackColor = Color.Green
            Case 2
                Finger_2.BackColor = Color.Green
            Case 3
                Finger_3.BackColor = Color.Green
            Case 4
                Finger_4.BackColor = Color.Green
            Case 5
                Finger_5.BackColor = Color.Green
            Case 6
                Finger_6.BackColor = Color.Green
            Case 7
                Finger_7.BackColor = Color.Green
            Case 8
                Finger_8.BackColor = Color.Green
            Case 9
                Finger_9.BackColor = Color.Green
            Case 10
                Finger_10.BackColor = Color.Green
            Case Else
                'nothing
        End Select
    End Sub

    Private Sub justMakeFingerRed(fingerNumber As Integer)
        Select Case fingerNumber
            Case 1
                Finger_1.BackColor = Color.Red
            Case 2
                Finger_2.BackColor = Color.Red
            Case 3
                Finger_3.BackColor = Color.Red
            Case 4
                Finger_4.BackColor = Color.Red
            Case 5
                Finger_5.BackColor = Color.Red
            Case 6
                Finger_6.BackColor = Color.Red
            Case 7
                Finger_7.BackColor = Color.Red
            Case 8
                Finger_8.BackColor = Color.Red
            Case 9
                Finger_9.BackColor = Color.Red
            Case 10
                Finger_10.BackColor = Color.Red
            Case Else
                'nothing
        End Select
    End Sub

    Private Sub HideRestCombonnents()

        Panel_Images.Invoke(Sub()
                                Panel_Images.Visible = False
                            End Sub)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not isValidatedInfo() Then
            Exit Sub
        End If

        'If Not RegistrationgInfo_ToDB() Then ' true = added to DB | false = error happned ,s o not added to DB
        '    Exit Sub
        'End If
        RegistrationgInfo_ToDB()

        Panel_RegisterFingerPrient.Visible = True
        Panel_RegistrationInfo.Visible = False

    End Sub

    Private Function isValidatedInfo()
        '' add here to checi Id not recorded before in DB

        If TextBox_PatientID.Text = Nothing Then
            MsgBox("Please Enter the Patient's ID")
            Return False

        ElseIf TextBox_PatientName.Text = Nothing Then
            MsgBox("Please Enter The Patient's Name")
            Return False

        ElseIf RadioButton_Male.Checked = False And RadioButton_Female.Checked = False Then
            MsgBox("Please Select The Patient's Gender")
            Return False

        ElseIf ComboBox_BloodType.Text = Nothing Then
            MsgBox("Please Select The Patient's Blood Type")
            Return False

        End If




        Return True 'everything validated good 
    End Function
#Region "theFingers"
    Private Sub Finger_1_Click(sender As Object, e As EventArgs) Handles Finger_1.Click
        EnrollFinger(Finger_1, 1)
    End Sub
    Private Sub Finger_2_Click(sender As Object, e As EventArgs) Handles Finger_2.Click
        EnrollFinger(Finger_2, 2)
    End Sub

    Private Sub Finger_3_Click(sender As Object, e As EventArgs) Handles Finger_3.Click
        EnrollFinger(Finger_3, 3)
    End Sub

    Private Sub Finger_4_Click(sender As Object, e As EventArgs) Handles Finger_4.Click
        EnrollFinger(Finger_4, 4)
    End Sub

    Private Sub Finger_5_Click(sender As Object, e As EventArgs) Handles Finger_5.Click
        EnrollFinger(Finger_5, 5)
    End Sub

    Private Sub Finger_6_Click(sender As Object, e As EventArgs) Handles Finger_6.Click
        EnrollFinger(Finger_6, 6)
    End Sub

    Private Sub Finger_7_Click(sender As Object, e As EventArgs) Handles Finger_7.Click
        EnrollFinger(Finger_7, 7)
    End Sub

    Private Sub Finger_8_Click(sender As Object, e As EventArgs) Handles Finger_8.Click
        EnrollFinger(Finger_8, 8)
    End Sub

    Private Sub Finger_9_Click(sender As Object, e As EventArgs) Handles Finger_9.Click
        EnrollFinger(Finger_9, 9)
    End Sub

    Private Sub Finger_10_Click(sender As Object, e As EventArgs) Handles Finger_10.Click
        EnrollFinger(Finger_10, 10)
    End Sub

#End Region


    Private Function RegistrationgInfo_ToDB()
        'perepariong Data
        Dim theGender As String = "Other"
        If RadioButton_Male.Checked = True Then
            theGender = "Male"
        ElseIf RadioButton_Female.Checked = True Then
            theGender = "Female"
        End If

        'preparing the connection 
        Dim conDB As New SQLiteConnection(ModuleDB.DBpath)
        Dim query1 As String
        Dim query2 As String

        Try
            conDB.Open()

            query1 = "insert into informations_tb (id,name,gender,BOD,bloodtype,extraInfo) values (@id,@name,@gender,@BOD,@bloodtype,@extraInfo)"
            query2 = "insert into fingerprints_tb (id) values (@id)"

            Dim cmd1 As New SQLiteCommand(query1, conDB)
            Dim cmd2 As New SQLiteCommand(query2, conDB)

            With cmd1.Parameters
                .AddWithValue("id", Val(TextBox_PatientID.Text))
                .AddWithValue("name", TextBox_PatientName.Text)
                .AddWithValue("gender", theGender)
                .AddWithValue("BOD", Date_DOB.Value.ToString("dd/MM/yyyy"))
                .AddWithValue("bloodtype", ComboBox_BloodType.Text)
                .AddWithValue("extraInfo", TextBox_ExtraInfo.Text)
            End With
            cmd1.ExecuteNonQuery()

            With cmd2.Parameters
                .AddWithValue("id", Val(TextBox_PatientID.Text))
            End With
            cmd2.ExecuteNonQuery()

            '  MsgBox("done registered info")

            conDB.Close()
        Catch ex As Exception
            conDB.Dispose()
            conDB = Nothing
            MsgBox(ex.Message)
            Return False
        End Try
        Return True
    End Function

    Private Sub Register_update_Fingerprient_ToDB(theMaskFinger As Integer, Template As DPFP.Template)
        'preparing the connection 
        Dim conDB As New SQLiteConnection(ModuleDB.DBpath)
        Dim query As String

        Try
            conDB.Open()                            ' columint name =  theMaskFinger 1 2 3 4 5 ..
            query = "update fingerprints_tb  set finger_" & theMaskFinger.ToString & " = @maskeFingerTemplate WHERE id = @id"

            Dim cmd As New SQLiteCommand(query, conDB)

            Dim bytesTemplate As Byte() = Nothing
            Template.Serialize(bytesTemplate)

            With cmd.Parameters
                .AddWithValue("id", Val(TextBox_PatientID.Text))
                .AddWithValue("maskeFingerTemplate", bytesTemplate)
            End With
            cmd.ExecuteNonQuery()
            conDB.Close()

            justMakeFingerGreen(theMaskFinger) ' make the label green   finger_12345678910
            ButtonOK.Invoke(Sub()
                                ButtonOK.Visible = True
                            End Sub)
        Catch ex As Exception
            conDB.Dispose()
            conDB = Nothing
            MsgBox(ex.Message)
            justMakeFingerRed(theMaskFinger) ' make the label Red   finger_12345678910
        End Try
    End Sub
    '____________________________________________________________________________________________________________________
    Private Sub Process(ByVal Sample As DPFP.Sample, selectedMaskFinger As Integer)
        DrawPicture(ConvertSampleToBitmap(Sample))

        ' Process the sample and create a feature set for the enrollment purpose.
        Dim features As DPFP.FeatureSet = Extract_Features_Ali(Sample, DPFP.Processing.DataPurpose.Enrollment)

        ' Check quality of the sample and add to enroller if it's good
        If (Not features Is Nothing) Then
            Try
                Try
                    ali_Enrollment.AddFeatures(features)        ' Add feature set to template.
                Finally
                    UpdateStatus_Ali()




                    ' Check if template has been created.
                    Select Case ali_Enrollment.TemplateStatus
                        Case DPFP.Processing.Enrollment.Status.Ready    ' Report success and stop capturing

                            Register_update_Fingerprient_ToDB(selectedMaskFinger, ali_Enrollment.Template) ' save template in DB


                            HideRestCombonnents()

                            ' MsgBox("got all Template")
                            StopCapture()
                        Case DPFP.Processing.Enrollment.Status.Failed   ' Report failure and restart capturing
                            StopCapture()
                            MsgBox("erororororooror")
                            ali_Enrollment.Clear()
                            StartCapture()
                    End Select

                End Try
            Catch ex As Exception
                MsgBox("try again not same fingers")
            End Try
        End If
        ' StopCapture()  return true ali lated to avoied error  , bydefual start as false then if stated ment check .. etc
    End Sub
    Private Function Extract_Features_Ali(ByVal Sample As DPFP.Sample, ByVal Purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet
        Dim extractor As New DPFP.Processing.FeatureExtraction()    ' Create a feature extractor
        Dim feedback As DPFP.Capture.CaptureFeedback = DPFP.Capture.CaptureFeedback.None
        Dim features As New DPFP.FeatureSet()
        extractor.CreateFeatureSet(Sample, Purpose, feedback, features) ' TODO: return features as a result?
        If (feedback = DPFP.Capture.CaptureFeedback.Good) Then
            Return features
        Else
            Return Nothing
        End If
    End Function
    Private Sub UpdateStatus_Ali()

        ' Show number of samples needed.
        Dim theGvalue As String
        If ali_Enrollment Is Nothing Then
            theGvalue = "w8ing"
        Else
            theGvalue = ali_Enrollment.FeaturesNeeded
        End If
        Label_Status.Invoke(Sub()
                                Label_Status.Text = (String.Format("Fingerprint samples needed: {0}", theGvalue))
                            End Sub)
    End Sub
    Private Sub StartCapture()
        If (Not ali_Capturer Is Nothing) Then
            Try
                ali_Capturer.StartCapture()
                ' SetPrompt("Using the fingerprint reader, scan your fingerprint.")
            Catch ex As Exception
                MsgBox("Can't initiate capture!")
            End Try
        End If
    End Sub
    Private Sub StopCapture()
        If (Not ali_Capturer Is Nothing) Then
            Try
                ali_Capturer.StopCapture()
            Catch ex As Exception
                MsgBox("Can't terminate capture!")
            End Try
        End If
    End Sub

    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete
        Process(Sample, theMaskFingeris)
    End Sub

    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerGone
        theMessage("The finger was removed from the fingerprint reader.")
    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerTouch
        theMessage("The fingerprint reader was touched")
    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderConnect
        theMessage("The fingerprint reader was connected.")
        CheckBox_ReaderConnected.Invoke(Sub()
                                            CheckBox_ReaderConnected.Checked = True
                                            CheckBox_ReaderConnected.Text = "Connected"
                                            CheckBox_ReaderConnected.ForeColor = Color.Blue
                                        End Sub)
    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderDisconnect
        theMessage("The fingerprint reader was disconnected.")
        CheckBox_ReaderConnected.Invoke(Sub()
                                            CheckBox_ReaderConnected.Checked = False
                                            CheckBox_ReaderConnected.Text = "Disconnected"
                                            CheckBox_ReaderConnected.ForeColor = Color.Red
                                        End Sub)
    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As CaptureFeedback) Implements EventHandler.OnSampleQuality
        If CaptureFeedback = DPFP.Capture.CaptureFeedback.Good Then
            theMessage("The quality of the fingerprint sample is good.")
        Else
            theMessage("The quality of the fingerprint sample is poor.")
        End If
    End Sub

    Private Sub startingConfigNew()
        'clearnig images / reset images
        PictureBoxSample_1.Image = Nothing
        PictureBoxSample_2.Image = Nothing
        PictureBoxSample_3.Image = Nothing
        PictureBoxSample_4.Image = Nothing


        ali_Enrollment = New DPFP.Processing.Enrollment()     ' Create an enrollment.
        Try
            ali_Capturer = New DPFP.Capture.Capture()                   ' Create a capture operation.

            If (Not ali_Capturer Is Nothing) Then
                ali_Capturer.EventHandler = Me                              ' Subscribe for capturing events.
            Else
                MsgBox("Can't initiate capture operation!")
            End If
        Catch ex As Exception
            MessageBox.Show("Can't initiate capture operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function ConvertSampleToBitmap(ByVal Sample As DPFP.Sample) As Bitmap
        Dim convertor As New DPFP.Capture.SampleConversion()  ' Create a sample convertor.
        Dim bitmap As Bitmap = Nothing              ' TODO: the size doesn't matter
        convertor.ConvertToPicture(Sample, bitmap)        ' TODO: return bitmap as a result
        Return bitmap
    End Function

    Private Sub DrawPicture(ByVal bmp)
        Select Case ali_Enrollment.FeaturesNeeded
            Case 1
                PictureBoxSample_4.Image = New Bitmap(bmp, PictureBoxSample_4.Size)
            Case 2
                PictureBoxSample_3.Image = New Bitmap(bmp, PictureBoxSample_3.Size)
            Case 3
                PictureBoxSample_2.Image = New Bitmap(bmp, PictureBoxSample_2.Size)
            Case 4
                PictureBoxSample_1.Image = New Bitmap(bmp, PictureBoxSample_1.Size)
            Case Else
                'nothing
        End Select

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' StartCapture() 'rm

    End Sub

    Private Sub TextBox_PatientID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_PatientID.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Close()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MainForm.RegistrationMenu.Enabled = True
    End Sub
End Class
