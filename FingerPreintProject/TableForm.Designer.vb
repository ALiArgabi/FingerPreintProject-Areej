<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TableForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button_Search = New System.Windows.Forms.Button()
        Me.Button_Remove = New System.Windows.Forms.Button()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.Button_Refresh = New System.Windows.Forms.Button()
        Me.Label_PatientID = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Search
        '
        Me.Button_Search.Location = New System.Drawing.Point(12, 94)
        Me.Button_Search.Name = "Button_Search"
        Me.Button_Search.Size = New System.Drawing.Size(166, 51)
        Me.Button_Search.TabIndex = 1
        Me.Button_Search.Tag = "Button_Search"
        Me.Button_Search.Text = "Search - بحث"
        Me.Button_Search.UseVisualStyleBackColor = True
        '
        'Button_Remove
        '
        Me.Button_Remove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Remove.Location = New System.Drawing.Point(613, 94)
        Me.Button_Remove.Name = "Button_Remove"
        Me.Button_Remove.Size = New System.Drawing.Size(166, 51)
        Me.Button_Remove.TabIndex = 2
        Me.Button_Remove.TabStop = False
        Me.Button_Remove.Tag = "Button_Search"
        Me.Button_Remove.Text = "Remove - حذف"
        Me.Button_Remove.UseVisualStyleBackColor = True
        '
        'TextBox_ID
        '
        Me.TextBox_ID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_ID.Location = New System.Drawing.Point(260, 30)
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.Size = New System.Drawing.Size(519, 34)
        Me.TextBox_ID.TabIndex = 3
        '
        'Button_Refresh
        '
        Me.Button_Refresh.Location = New System.Drawing.Point(324, 94)
        Me.Button_Refresh.Name = "Button_Refresh"
        Me.Button_Refresh.Size = New System.Drawing.Size(172, 51)
        Me.Button_Refresh.TabIndex = 4
        Me.Button_Refresh.Tag = " "
        Me.Button_Refresh.Text = "Refresh - تحديث"
        Me.Button_Refresh.UseVisualStyleBackColor = True
        '
        'Label_PatientID
        '
        Me.Label_PatientID.AutoSize = True
        Me.Label_PatientID.Location = New System.Drawing.Point(15, 33)
        Me.Label_PatientID.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label_PatientID.Name = "Label_PatientID"
        Me.Label_PatientID.Size = New System.Drawing.Size(236, 27)
        Me.Label_PatientID.TabIndex = 5
        Me.Label_PatientID.Text = "Patient ID - هوية المريض"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 172)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(767, 435)
        Me.DataGridView1.TabIndex = 11
        '
        'TableForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(791, 619)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label_PatientID)
        Me.Controls.Add(Me.Button_Refresh)
        Me.Controls.Add(Me.TextBox_ID)
        Me.Controls.Add(Me.Button_Remove)
        Me.Controls.Add(Me.Button_Search)
        Me.Font = New System.Drawing.Font("Times New Roman", 13.8!)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "TableForm"
        Me.ShowIcon = False
        Me.Text = "All Data - كل البيانات"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Search As Button
    Friend WithEvents Button_Remove As Button
    Friend WithEvents TextBox_ID As TextBox
    Friend WithEvents Button_Refresh As Button
    Friend WithEvents Label_PatientID As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
