<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label_PatientID = New System.Windows.Forms.Label()
        Me.Panel_RegistrationInfo = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox_BloodType = New System.Windows.Forms.ComboBox()
        Me.Label_BloodType = New System.Windows.Forms.Label()
        Me.GroupBox_ExtraInfo = New System.Windows.Forms.GroupBox()
        Me.TextBox_ExtraInfo = New System.Windows.Forms.TextBox()
        Me.Label_DOBFormat = New System.Windows.Forms.Label()
        Me.Label_DOB = New System.Windows.Forms.Label()
        Me.Date_DOB = New System.Windows.Forms.DateTimePicker()
        Me.RadioButton_Female = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Male = New System.Windows.Forms.RadioButton()
        Me.Label_Gender = New System.Windows.Forms.Label()
        Me.TextBox_PatientName = New System.Windows.Forms.TextBox()
        Me.Label_PatientName = New System.Windows.Forms.Label()
        Me.TextBox_PatientID = New System.Windows.Forms.TextBox()
        Me.Panel_RegisterFingerPrient = New System.Windows.Forms.Panel()
        Me.Button_Done = New System.Windows.Forms.Button()
        Me.Panel_Images = New System.Windows.Forms.Panel()
        Me.PictureBoxSample_2 = New System.Windows.Forms.PictureBox()
        Me.Label_Status = New System.Windows.Forms.Label()
        Me.PictureBoxSample_4 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxSample_1 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxSample_3 = New System.Windows.Forms.PictureBox()
        Me.Finger_10 = New System.Windows.Forms.Label()
        Me.Finger_9 = New System.Windows.Forms.Label()
        Me.Finger_8 = New System.Windows.Forms.Label()
        Me.Finger_7 = New System.Windows.Forms.Label()
        Me.Finger_6 = New System.Windows.Forms.Label()
        Me.Finger_5 = New System.Windows.Forms.Label()
        Me.Finger_4 = New System.Windows.Forms.Label()
        Me.Finger_3 = New System.Windows.Forms.Label()
        Me.Finger_2 = New System.Windows.Forms.Label()
        Me.Finger_1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel_RegistrationInfo.SuspendLayout()
        Me.GroupBox_ExtraInfo.SuspendLayout()
        Me.Panel_RegisterFingerPrient.SuspendLayout()
        Me.Panel_Images.SuspendLayout()
        CType(Me.PictureBoxSample_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSample_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSample_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSample_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_PatientID
        '
        Me.Label_PatientID.AutoSize = True
        Me.Label_PatientID.Location = New System.Drawing.Point(6, 15)
        Me.Label_PatientID.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label_PatientID.Name = "Label_PatientID"
        Me.Label_PatientID.Size = New System.Drawing.Size(236, 27)
        Me.Label_PatientID.TabIndex = 0
        Me.Label_PatientID.Text = "Patient ID - هوية المريض"
        '
        'Panel_RegistrationInfo
        '
        Me.Panel_RegistrationInfo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel_RegistrationInfo.Controls.Add(Me.Button1)
        Me.Panel_RegistrationInfo.Controls.Add(Me.ComboBox_BloodType)
        Me.Panel_RegistrationInfo.Controls.Add(Me.Label_BloodType)
        Me.Panel_RegistrationInfo.Controls.Add(Me.GroupBox_ExtraInfo)
        Me.Panel_RegistrationInfo.Controls.Add(Me.Label_DOBFormat)
        Me.Panel_RegistrationInfo.Controls.Add(Me.Label_DOB)
        Me.Panel_RegistrationInfo.Controls.Add(Me.Date_DOB)
        Me.Panel_RegistrationInfo.Controls.Add(Me.RadioButton_Female)
        Me.Panel_RegistrationInfo.Controls.Add(Me.RadioButton_Male)
        Me.Panel_RegistrationInfo.Controls.Add(Me.Label_Gender)
        Me.Panel_RegistrationInfo.Controls.Add(Me.TextBox_PatientName)
        Me.Panel_RegistrationInfo.Controls.Add(Me.Label_PatientName)
        Me.Panel_RegistrationInfo.Controls.Add(Me.TextBox_PatientID)
        Me.Panel_RegistrationInfo.Controls.Add(Me.Label_PatientID)
        Me.Panel_RegistrationInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_RegistrationInfo.Location = New System.Drawing.Point(0, 0)
        Me.Panel_RegistrationInfo.Name = "Panel_RegistrationInfo"
        Me.Panel_RegistrationInfo.Size = New System.Drawing.Size(791, 619)
        Me.Panel_RegistrationInfo.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(327, 553)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 50)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Next - التالي"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox_BloodType
        '
        Me.ComboBox_BloodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_BloodType.FormattingEnabled = True
        Me.ComboBox_BloodType.Items.AddRange(New Object() {"O−", "O+", "A−", "A+", "B−", "B+", "AB−", "AB+"})
        Me.ComboBox_BloodType.Location = New System.Drawing.Point(334, 235)
        Me.ComboBox_BloodType.Name = "ComboBox_BloodType"
        Me.ComboBox_BloodType.Size = New System.Drawing.Size(95, 34)
        Me.ComboBox_BloodType.TabIndex = 6
        '
        'Label_BloodType
        '
        Me.Label_BloodType.AutoSize = True
        Me.Label_BloodType.Location = New System.Drawing.Point(6, 238)
        Me.Label_BloodType.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label_BloodType.Name = "Label_BloodType"
        Me.Label_BloodType.Size = New System.Drawing.Size(295, 27)
        Me.Label_BloodType.TabIndex = 11
        Me.Label_BloodType.Text = "Patient Blood Type - فصيلة الدم"
        '
        'GroupBox_ExtraInfo
        '
        Me.GroupBox_ExtraInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_ExtraInfo.Controls.Add(Me.TextBox_ExtraInfo)
        Me.GroupBox_ExtraInfo.Location = New System.Drawing.Point(11, 299)
        Me.GroupBox_ExtraInfo.Name = "GroupBox_ExtraInfo"
        Me.GroupBox_ExtraInfo.Size = New System.Drawing.Size(768, 237)
        Me.GroupBox_ExtraInfo.TabIndex = 10
        Me.GroupBox_ExtraInfo.TabStop = False
        Me.GroupBox_ExtraInfo.Text = "More Information - معلومات أكثر"
        '
        'TextBox_ExtraInfo
        '
        Me.TextBox_ExtraInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_ExtraInfo.Location = New System.Drawing.Point(3, 30)
        Me.TextBox_ExtraInfo.Multiline = True
        Me.TextBox_ExtraInfo.Name = "TextBox_ExtraInfo"
        Me.TextBox_ExtraInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox_ExtraInfo.Size = New System.Drawing.Size(762, 204)
        Me.TextBox_ExtraInfo.TabIndex = 7
        '
        'Label_DOBFormat
        '
        Me.Label_DOBFormat.AutoSize = True
        Me.Label_DOBFormat.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_DOBFormat.Location = New System.Drawing.Point(612, 177)
        Me.Label_DOBFormat.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label_DOBFormat.Name = "Label_DOBFormat"
        Me.Label_DOBFormat.Size = New System.Drawing.Size(134, 27)
        Me.Label_DOBFormat.TabIndex = 9
        Me.Label_DOBFormat.Text = "dd/mm/yyyy"
        '
        'Label_DOB
        '
        Me.Label_DOB.AutoSize = True
        Me.Label_DOB.Location = New System.Drawing.Point(6, 177)
        Me.Label_DOB.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label_DOB.Name = "Label_DOB"
        Me.Label_DOB.Size = New System.Drawing.Size(258, 27)
        Me.Label_DOB.TabIndex = 8
        Me.Label_DOB.Text = "Patient DOB - تاريخ الميلاد "
        '
        'Date_DOB
        '
        Me.Date_DOB.CustomFormat = "dd/MM/yyyy"
        Me.Date_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Date_DOB.Location = New System.Drawing.Point(334, 175)
        Me.Date_DOB.Name = "Date_DOB"
        Me.Date_DOB.Size = New System.Drawing.Size(269, 34)
        Me.Date_DOB.TabIndex = 5
        '
        'RadioButton_Female
        '
        Me.RadioButton_Female.AutoSize = True
        Me.RadioButton_Female.Location = New System.Drawing.Point(592, 124)
        Me.RadioButton_Female.Name = "RadioButton_Female"
        Me.RadioButton_Female.Size = New System.Drawing.Size(154, 31)
        Me.RadioButton_Female.TabIndex = 4
        Me.RadioButton_Female.Text = "Female - أنثى"
        Me.RadioButton_Female.UseVisualStyleBackColor = True
        '
        'RadioButton_Male
        '
        Me.RadioButton_Male.AutoSize = True
        Me.RadioButton_Male.Location = New System.Drawing.Point(334, 124)
        Me.RadioButton_Male.Name = "RadioButton_Male"
        Me.RadioButton_Male.Size = New System.Drawing.Size(131, 31)
        Me.RadioButton_Male.TabIndex = 3
        Me.RadioButton_Male.Text = "Male - ذكر"
        Me.RadioButton_Male.UseVisualStyleBackColor = True
        '
        'Label_Gender
        '
        Me.Label_Gender.AutoSize = True
        Me.Label_Gender.Location = New System.Drawing.Point(6, 121)
        Me.Label_Gender.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label_Gender.Name = "Label_Gender"
        Me.Label_Gender.Size = New System.Drawing.Size(232, 27)
        Me.Label_Gender.TabIndex = 4
        Me.Label_Gender.Text = "Patient Gender - الجنس "
        '
        'TextBox_PatientName
        '
        Me.TextBox_PatientName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_PatientName.Location = New System.Drawing.Point(334, 69)
        Me.TextBox_PatientName.Name = "TextBox_PatientName"
        Me.TextBox_PatientName.Size = New System.Drawing.Size(412, 34)
        Me.TextBox_PatientName.TabIndex = 2
        '
        'Label_PatientName
        '
        Me.Label_PatientName.AutoSize = True
        Me.Label_PatientName.Location = New System.Drawing.Point(6, 69)
        Me.Label_PatientName.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label_PatientName.Name = "Label_PatientName"
        Me.Label_PatientName.Size = New System.Drawing.Size(258, 27)
        Me.Label_PatientName.TabIndex = 2
        Me.Label_PatientName.Text = "Patient Name - اسم المريض"
        '
        'TextBox_PatientID
        '
        Me.TextBox_PatientID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_PatientID.Location = New System.Drawing.Point(334, 15)
        Me.TextBox_PatientID.Name = "TextBox_PatientID"
        Me.TextBox_PatientID.Size = New System.Drawing.Size(412, 34)
        Me.TextBox_PatientID.TabIndex = 1
        '
        'Panel_RegisterFingerPrient
        '
        Me.Panel_RegisterFingerPrient.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel_RegisterFingerPrient.Controls.Add(Me.Button_Done)
        Me.Panel_RegisterFingerPrient.Controls.Add(Me.Panel_Images)
        Me.Panel_RegisterFingerPrient.Controls.Add(Me.Finger_10)
        Me.Panel_RegisterFingerPrient.Controls.Add(Me.Finger_9)
        Me.Panel_RegisterFingerPrient.Controls.Add(Me.Finger_8)
        Me.Panel_RegisterFingerPrient.Controls.Add(Me.Finger_7)
        Me.Panel_RegisterFingerPrient.Controls.Add(Me.Finger_6)
        Me.Panel_RegisterFingerPrient.Controls.Add(Me.Finger_5)
        Me.Panel_RegisterFingerPrient.Controls.Add(Me.Finger_4)
        Me.Panel_RegisterFingerPrient.Controls.Add(Me.Finger_3)
        Me.Panel_RegisterFingerPrient.Controls.Add(Me.Finger_2)
        Me.Panel_RegisterFingerPrient.Controls.Add(Me.Finger_1)
        Me.Panel_RegisterFingerPrient.Controls.Add(Me.PictureBox2)
        Me.Panel_RegisterFingerPrient.Controls.Add(Me.PictureBox1)
        Me.Panel_RegisterFingerPrient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_RegisterFingerPrient.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_RegisterFingerPrient.Location = New System.Drawing.Point(0, 0)
        Me.Panel_RegisterFingerPrient.Name = "Panel_RegisterFingerPrient"
        Me.Panel_RegisterFingerPrient.Size = New System.Drawing.Size(791, 619)
        Me.Panel_RegisterFingerPrient.TabIndex = 14
        Me.Panel_RegisterFingerPrient.Visible = False
        '
        'Button_Done
        '
        Me.Button_Done.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Done.Location = New System.Drawing.Point(327, 542)
        Me.Button_Done.Name = "Button_Done"
        Me.Button_Done.Size = New System.Drawing.Size(116, 50)
        Me.Button_Done.TabIndex = 19
        Me.Button_Done.TabStop = False
        Me.Button_Done.Text = "Done - تم"
        Me.Button_Done.UseVisualStyleBackColor = True
        Me.Button_Done.Visible = False
        '
        'Panel_Images
        '
        Me.Panel_Images.Controls.Add(Me.PictureBoxSample_2)
        Me.Panel_Images.Controls.Add(Me.Label_Status)
        Me.Panel_Images.Controls.Add(Me.PictureBoxSample_4)
        Me.Panel_Images.Controls.Add(Me.PictureBoxSample_1)
        Me.Panel_Images.Controls.Add(Me.PictureBoxSample_3)
        Me.Panel_Images.Location = New System.Drawing.Point(176, 335)
        Me.Panel_Images.Name = "Panel_Images"
        Me.Panel_Images.Size = New System.Drawing.Size(433, 184)
        Me.Panel_Images.TabIndex = 18
        Me.Panel_Images.Visible = False
        '
        'PictureBoxSample_2
        '
        Me.PictureBoxSample_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBoxSample_2.Location = New System.Drawing.Point(113, 40)
        Me.PictureBoxSample_2.Name = "PictureBoxSample_2"
        Me.PictureBoxSample_2.Size = New System.Drawing.Size(100, 100)
        Me.PictureBoxSample_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxSample_2.TabIndex = 15
        Me.PictureBoxSample_2.TabStop = False
        '
        'Label_Status
        '
        Me.Label_Status.AutoSize = True
        Me.Label_Status.Location = New System.Drawing.Point(3, 157)
        Me.Label_Status.Name = "Label_Status"
        Me.Label_Status.Size = New System.Drawing.Size(84, 22)
        Me.Label_Status.TabIndex = 13
        Me.Label_Status.Text = "Status - 0"
        '
        'PictureBoxSample_4
        '
        Me.PictureBoxSample_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBoxSample_4.Location = New System.Drawing.Point(325, 40)
        Me.PictureBoxSample_4.Name = "PictureBoxSample_4"
        Me.PictureBoxSample_4.Size = New System.Drawing.Size(100, 100)
        Me.PictureBoxSample_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxSample_4.TabIndex = 17
        Me.PictureBoxSample_4.TabStop = False
        '
        'PictureBoxSample_1
        '
        Me.PictureBoxSample_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBoxSample_1.Location = New System.Drawing.Point(6, 40)
        Me.PictureBoxSample_1.Name = "PictureBoxSample_1"
        Me.PictureBoxSample_1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBoxSample_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxSample_1.TabIndex = 14
        Me.PictureBoxSample_1.TabStop = False
        '
        'PictureBoxSample_3
        '
        Me.PictureBoxSample_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBoxSample_3.Location = New System.Drawing.Point(219, 40)
        Me.PictureBoxSample_3.Name = "PictureBoxSample_3"
        Me.PictureBoxSample_3.Size = New System.Drawing.Size(100, 100)
        Me.PictureBoxSample_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxSample_3.TabIndex = 16
        Me.PictureBoxSample_3.TabStop = False
        '
        'Finger_10
        '
        Me.Finger_10.AutoSize = True
        Me.Finger_10.BackColor = System.Drawing.Color.Red
        Me.Finger_10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Finger_10.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Finger_10.Location = New System.Drawing.Point(92, 90)
        Me.Finger_10.Name = "Finger_10"
        Me.Finger_10.Size = New System.Drawing.Size(28, 21)
        Me.Finger_10.TabIndex = 11
        Me.Finger_10.Text = "10"
        '
        'Finger_9
        '
        Me.Finger_9.AutoSize = True
        Me.Finger_9.BackColor = System.Drawing.Color.Red
        Me.Finger_9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Finger_9.Location = New System.Drawing.Point(162, 43)
        Me.Finger_9.Name = "Finger_9"
        Me.Finger_9.Size = New System.Drawing.Size(20, 22)
        Me.Finger_9.TabIndex = 10
        Me.Finger_9.Text = "9"
        '
        'Finger_8
        '
        Me.Finger_8.AutoSize = True
        Me.Finger_8.BackColor = System.Drawing.Color.Red
        Me.Finger_8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Finger_8.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Finger_8.Location = New System.Drawing.Point(217, 32)
        Me.Finger_8.Name = "Finger_8"
        Me.Finger_8.Size = New System.Drawing.Size(19, 21)
        Me.Finger_8.TabIndex = 9
        Me.Finger_8.Text = "8"
        '
        'Finger_7
        '
        Me.Finger_7.AutoSize = True
        Me.Finger_7.BackColor = System.Drawing.Color.Red
        Me.Finger_7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Finger_7.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Finger_7.Location = New System.Drawing.Point(275, 60)
        Me.Finger_7.Name = "Finger_7"
        Me.Finger_7.Size = New System.Drawing.Size(19, 21)
        Me.Finger_7.TabIndex = 8
        Me.Finger_7.Text = "7"
        '
        'Finger_6
        '
        Me.Finger_6.AutoSize = True
        Me.Finger_6.BackColor = System.Drawing.Color.Red
        Me.Finger_6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Finger_6.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Finger_6.Location = New System.Drawing.Point(344, 226)
        Me.Finger_6.Name = "Finger_6"
        Me.Finger_6.Size = New System.Drawing.Size(19, 21)
        Me.Finger_6.TabIndex = 7
        Me.Finger_6.Text = "6"
        '
        'Finger_5
        '
        Me.Finger_5.AutoSize = True
        Me.Finger_5.BackColor = System.Drawing.Color.Red
        Me.Finger_5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Finger_5.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Finger_5.Location = New System.Drawing.Point(684, 89)
        Me.Finger_5.Name = "Finger_5"
        Me.Finger_5.Size = New System.Drawing.Size(19, 21)
        Me.Finger_5.TabIndex = 6
        Me.Finger_5.Text = "5"
        '
        'Finger_4
        '
        Me.Finger_4.AutoSize = True
        Me.Finger_4.BackColor = System.Drawing.Color.Red
        Me.Finger_4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Finger_4.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Finger_4.Location = New System.Drawing.Point(618, 45)
        Me.Finger_4.Name = "Finger_4"
        Me.Finger_4.Size = New System.Drawing.Size(19, 21)
        Me.Finger_4.TabIndex = 5
        Me.Finger_4.Text = "4"
        '
        'Finger_3
        '
        Me.Finger_3.AutoSize = True
        Me.Finger_3.BackColor = System.Drawing.Color.Red
        Me.Finger_3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Finger_3.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Finger_3.Location = New System.Drawing.Point(562, 32)
        Me.Finger_3.Name = "Finger_3"
        Me.Finger_3.Size = New System.Drawing.Size(19, 21)
        Me.Finger_3.TabIndex = 4
        Me.Finger_3.Text = "3"
        '
        'Finger_2
        '
        Me.Finger_2.AutoSize = True
        Me.Finger_2.BackColor = System.Drawing.Color.Red
        Me.Finger_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Finger_2.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Finger_2.Location = New System.Drawing.Point(506, 61)
        Me.Finger_2.Name = "Finger_2"
        Me.Finger_2.Size = New System.Drawing.Size(19, 21)
        Me.Finger_2.TabIndex = 3
        Me.Finger_2.Text = "2"
        '
        'Finger_1
        '
        Me.Finger_1.AutoSize = True
        Me.Finger_1.BackColor = System.Drawing.Color.Red
        Me.Finger_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Finger_1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Finger_1.Location = New System.Drawing.Point(435, 226)
        Me.Finger_1.Name = "Finger_1"
        Me.Finger_1.Size = New System.Drawing.Size(19, 21)
        Me.Finger_1.TabIndex = 2
        Me.Finger_1.Text = "1"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.FingerPreintProject.My.Resources.Resources.LeftHand
        Me.PictureBox2.Location = New System.Drawing.Point(87, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(300, 300)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FingerPreintProject.My.Resources.Resources.RightHand
        Me.PictureBox1.Location = New System.Drawing.Point(417, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 300)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 619)
        Me.Controls.Add(Me.Panel_RegistrationInfo)
        Me.Controls.Add(Me.Panel_RegisterFingerPrient)
        Me.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Registration التسجيل"
        Me.Panel_RegistrationInfo.ResumeLayout(False)
        Me.Panel_RegistrationInfo.PerformLayout()
        Me.GroupBox_ExtraInfo.ResumeLayout(False)
        Me.GroupBox_ExtraInfo.PerformLayout()
        Me.Panel_RegisterFingerPrient.ResumeLayout(False)
        Me.Panel_RegisterFingerPrient.PerformLayout()
        Me.Panel_Images.ResumeLayout(False)
        Me.Panel_Images.PerformLayout()
        CType(Me.PictureBoxSample_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSample_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSample_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSample_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label_PatientID As Label
    Friend WithEvents Panel_RegistrationInfo As Panel
    Friend WithEvents TextBox_PatientName As TextBox
    Friend WithEvents Label_PatientName As Label
    Friend WithEvents TextBox_PatientID As TextBox
    Friend WithEvents Date_DOB As DateTimePicker
    Friend WithEvents RadioButton_Female As RadioButton
    Friend WithEvents RadioButton_Male As RadioButton
    Friend WithEvents Label_Gender As Label
    Friend WithEvents Label_DOB As Label
    Friend WithEvents Label_DOBFormat As Label
    Friend WithEvents GroupBox_ExtraInfo As GroupBox
    Friend WithEvents TextBox_ExtraInfo As TextBox
    Friend WithEvents ComboBox_BloodType As ComboBox
    Friend WithEvents Label_BloodType As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel_RegisterFingerPrient As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Finger_10 As Label
    Friend WithEvents Finger_9 As Label
    Friend WithEvents Finger_8 As Label
    Friend WithEvents Finger_7 As Label
    Friend WithEvents Finger_6 As Label
    Friend WithEvents Finger_5 As Label
    Friend WithEvents Finger_4 As Label
    Friend WithEvents Finger_3 As Label
    Friend WithEvents Finger_2 As Label
    Friend WithEvents Finger_1 As Label
    Friend WithEvents Label_Status As Label
    Friend WithEvents Panel_Images As Panel
    Friend WithEvents PictureBoxSample_2 As PictureBox
    Friend WithEvents PictureBoxSample_4 As PictureBox
    Friend WithEvents PictureBoxSample_1 As PictureBox
    Friend WithEvents PictureBoxSample_3 As PictureBox
    Friend WithEvents Button_Done As Button
End Class
