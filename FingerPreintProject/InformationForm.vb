Imports System.ComponentModel
Imports System.Data.SQLite
Imports DPFP
Imports DPFP.Capture

Public Class InformationForm
    Implements DPFP.Capture.EventHandler

    Private theFingerNumberSelectedIs As Integer = 0 '  1-10

    Private Template_ali As DPFP.Template
    Private Verificator_ali As DPFP.Verification.Verification
    Private ali_Capturer As DPFP.Capture.Capture

    Private Sub TextBox_PatientID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_PatientID.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub InformationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        theMessage("--- started ---")

        Verificator_ali = New DPFP.Verification.Verification()

        Try
            ali_Capturer = New DPFP.Capture.Capture()                   ' Create a capture operation.

            If (Not ali_Capturer Is Nothing) Then
                ali_Capturer.EventHandler = Me                              ' Subscribe for capturing events.
            Else
                theMessage("Can't initiate capture operation!")
            End If
        Catch ex As Exception
            MessageBox.Show("Can't initiate capture operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'loadTemplate(ModuleDB.theTemplate)

    End Sub

    Private Sub InformationForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MainForm.InformationsMenu.Enabled = True
        StopCapture()
    End Sub


    '_________________________________________________________________________
    Private Sub justMakeFingerDefualtColor()
        Finger_1.BackColor = Color.DarkCyan
        Finger_2.BackColor = Color.DarkCyan
        Finger_3.BackColor = Color.DarkCyan
        Finger_4.BackColor = Color.DarkCyan
        Finger_5.BackColor = Color.DarkCyan
        Finger_6.BackColor = Color.DarkCyan
        Finger_7.BackColor = Color.DarkCyan
        Finger_8.BackColor = Color.DarkCyan
        Finger_9.BackColor = Color.DarkCyan
        Finger_10.BackColor = Color.DarkCyan
    End Sub
    Private Sub justMakeFingerYellow(fingerNumber As Integer)
        theFingerNumberSelectedIs = fingerNumber 'selecte finger

        justMakeFingerDefualtColor()

        Select Case fingerNumber
            Case 1
                Finger_1.BackColor = Color.Yellow
            Case 2
                Finger_2.BackColor = Color.Yellow
            Case 3
                Finger_3.BackColor = Color.Yellow
            Case 4
                Finger_4.BackColor = Color.Yellow
            Case 5
                Finger_5.BackColor = Color.Yellow
            Case 6
                Finger_6.BackColor = Color.Yellow
            Case 7
                Finger_7.BackColor = Color.Yellow
            Case 8
                Finger_8.BackColor = Color.Yellow
            Case 9
                Finger_9.BackColor = Color.Yellow
            Case 10
                Finger_10.BackColor = Color.Yellow
            Case Else
                'nothing
        End Select

        StartCapture()
    End Sub

    Private Sub Finger_1_Click(sender As Object, e As EventArgs) Handles Finger_1.Click
        justMakeFingerYellow(1)
    End Sub

    Private Sub Finger_2_Click(sender As Object, e As EventArgs) Handles Finger_2.Click
        justMakeFingerYellow(2)
    End Sub

    Private Sub Finger_3_Click(sender As Object, e As EventArgs) Handles Finger_3.Click
        justMakeFingerYellow(3)
    End Sub

    Private Sub Finger_4_Click(sender As Object, e As EventArgs) Handles Finger_4.Click
        justMakeFingerYellow(4)
    End Sub

    Private Sub Finger_5_Click(sender As Object, e As EventArgs) Handles Finger_5.Click
        justMakeFingerYellow(5)
    End Sub

    Private Sub Finger_6_Click(sender As Object, e As EventArgs) Handles Finger_6.Click
        justMakeFingerYellow(6)
    End Sub

    Private Sub Finger_7_Click(sender As Object, e As EventArgs) Handles Finger_7.Click
        justMakeFingerYellow(7)
    End Sub

    Private Sub Finger_8_Click(sender As Object, e As EventArgs) Handles Finger_8.Click
        justMakeFingerYellow(8)
    End Sub

    Private Sub Finger_9_Click(sender As Object, e As EventArgs) Handles Finger_9.Click
        justMakeFingerYellow(9)
    End Sub

    Private Sub Finger_10_Click(sender As Object, e As EventArgs) Handles Finger_10.Click
        justMakeFingerYellow(10)
    End Sub

    Private Sub Finger_1to10_Click(sender As Object, e As EventArgs)
        justMakeFingerYellow(11)
    End Sub

    Private Sub Button_Search_Click(sender As Object, e As EventArgs) Handles Button_Search.Click
        If SearchByID(Val(TextBox_PatientID.Text)) = False Then
            Exit Sub ' do not show the next panale , cuz no information found
        End If

        Panel_ShowInformations.Visible = True
        Panel_Searching.Visible = False
        'stop capturee 
    End Sub


    Private Function SearchByID(theID As Integer)
        Dim conDB As New SQLiteConnection(ModuleDB.DBpath)
        Dim query As String = "SELECT * FROM informations_tb WHERE id = " & Val(TextBox_PatientID.Text)  ' ID

        Try
            conDB.Open()

            Dim cmd As New SQLiteCommand(query, conDB)
            Dim Reader As SQLiteDataReader
            Reader = cmd.ExecuteReader()

            If Reader.Read Then
                ' ID
                TextBox_ID.Text = TextBox_PatientID.Text
                'Name & Age BoD
                TextBox_NameAge.Text = Reader.Item("name")
                'Bllod & Gender
                TextBox_Gender_BloodType.Text = Reader.Item("bloodtype") + "   |   " + Reader.Item("gender") + "  |  " + getAgeFromBoD(Reader.Item("BOD"))
                'Extra Information
                TextBox_ExtraInfo.Text = Reader.Item("extraInfo")
            Else
                'no information found
                TextBox_ID.Text = Nothing
                TextBox_NameAge.Text = Nothing
                TextBox_Gender_BloodType.Text = Nothing
                TextBox_ExtraInfo.Text = Nothing
                MsgBox("no results found")
                conDB.Close()
                Return False
            End If

            conDB.Close()

        Catch ex As Exception
            conDB.Dispose()
            conDB = Nothing
            MsgBox(ex.Message)
            Return False
        End Try

        Return True
    End Function

    Private Function getAgeFromBoD(BoD As String)
        'colculationg Age years and months
        Dim theDate As Date
        ' the format from DataTimePicker
        If Date.TryParseExact(BoD, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, theDate) Then
            Dim Age As New Date(Now.Subtract(theDate).Ticks)
            Return (String.Format("{0} Years and {1} Months", Age.Year - 1, Age.Month - 1))
        End If
        Return BoD 'can not colculate age so retarn the BoD
    End Function

    Private Sub TextBox_PatientID_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_PatientID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button_Search.PerformClick()
        End If
    End Sub



    '______________________________________________________________________
    Private Sub StartCapture()
        If (Not ali_Capturer Is Nothing) Then
            Try
                ali_Capturer.StartCapture()
                theMessage("Using the fingerprint reader, scan your fingerprint.")
            Catch ex As Exception
                theMessage("Can't initiate capture!")
            End Try
        End If
    End Sub

    Private Sub StopCapture()
        If (Not ali_Capturer Is Nothing) Then
            Try
                ali_Capturer.StopCapture()
            Catch ex As Exception
                theMessage("Can't terminate capture!")
            End Try
        End If
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

    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete
        theMessage("Searching ....")
        Ali_Process(Sample, theFingerNumberSelectedIs)
    End Sub

    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerGone
        theMessage("The finger was removed from the fingerprint reader.")
    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerTouch
        theMessage("The fingerprint reader was touched.")
    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderConnect
        theMessage("The fingerprint reader was connected.")
    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderDisconnect
        theMessage("The fingerprint reader was disconnected.")
    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As CaptureFeedback) Implements EventHandler.OnSampleQuality
        If CaptureFeedback = DPFP.Capture.CaptureFeedback.Good Then
            theMessage("The quality of the fingerprint sample is good.")
        Else
            theMessage("The quality of the fingerprint sample is poor.")
        End If
    End Sub

    Private Sub DrawPicture(ByVal bmp)
        PictuerBox_Fingerprient.Image = New Bitmap(bmp, PictuerBox_Fingerprient.Size)
    End Sub
    Private Function ConvertSampleToBitmap(ByVal Sample As DPFP.Sample) As Bitmap
        Dim convertor As New DPFP.Capture.SampleConversion()  ' Create a sample convertor.
        Dim bitmap As Bitmap = Nothing              ' TODO: the size doesn't matter
        convertor.ConvertToPicture(Sample, bitmap)        ' TODO: return bitmap as a result
        Return bitmap
    End Function
    Private Sub Ali_Process(ByVal Sample As DPFP.Sample, FingerNumber As Integer)
        Dim isFPFounded As Boolean = False ' checi if the faound any mached FP in DB or not  for showing message

        DrawPicture(ConvertSampleToBitmap(Sample))

        ' Process the sample and create a feature set for the enrollment purpose.
        Dim features As DPFP.FeatureSet = Extract_Features_Ali(Sample, DPFP.Processing.DataPurpose.Verification)

        ' Check quality of the sample and start verification if it's good
        If Not features Is Nothing Then


            ' Compare the feature set with our template
            Dim result As DPFP.Verification.Verification.Result = New DPFP.Verification.Verification.Result()
            '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Dim conDB As New SQLiteConnection(DBpath)
            Try
                conDB.Open()
                Dim query As String
                query = "SELECT * FROM fingerprints_tb"

                Dim cmd As New SQLiteCommand(query, conDB)
                Dim Reader As SQLiteDataReader
                Reader = cmd.ExecuteReader()
                Dim byteTemplate As Byte() = Nothing
                Dim tempTemplate = New DPFP.Template()

                While Reader.Read
                    'null values
                    If Reader.Item("finger_" & FingerNumber.ToString) Is DBNull.Value Then
                        Continue While ' skipe
                    End If


                    byteTemplate = Reader.Item("finger_" & FingerNumber.ToString) 'get Template selected finger number 'FingerNumber



                    tempTemplate.DeSerialize(byteTemplate) 'decodingtemplate from byets[]

                    Verificator_ali.Verify(features, tempTemplate, result)

                    ''whene got find the right template in DB

                    If result.Verified Then
                        isFPFounded = True 'found data , so do not show message unfoaunded 
                        'show information
                        TextBox_PatientID.Invoke(Sub()
                                                     TextBox_PatientID.Text = Reader.Item("id") 'get ID whitch matched the Fingerprient
                                                 End Sub)
                        Button_Search.Invoke(Sub()
                                                 Button_Search.PerformClick() ' auto search
                                             End Sub)

                        StopCapture() 'we found the result so not need for searching by fingerpreitn any more
                        Exit While
                    Else
                        isFPFounded = False
                    End If


                End While

                '  MakeReport(Module1.ali)


                ' MsgBox("loaded all")

                conDB.Close()

                '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                theMessage(String.Format("False Accept Rate (FAR) = {0}", result.FARAchieved)) ' Show "False accept rate" value

            Catch ex As Exception
                conDB.Dispose()
                conDB = Nothing
                MsgBox(ex.Message)

                theMessage("## no Template found. ##")
            End Try
        End If

        'show this message only if no result found 
        If Not isFPFounded Then
            MsgBox("the Fingerpreint not found in our DB")
            PictuerBox_Fingerprient.Image = Nothing 'reset
            justMakeFingerDefualtColor() 'reset
        End If
    End Sub
End Class