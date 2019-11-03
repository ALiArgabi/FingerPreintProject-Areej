Imports System.Data.SQLite
Module ModuleDB
    'DB path
    Public DBpath As String = "Data Source=" & Application.StartupPath & "\FingerPreintProjectDB.db;"

    Public Sub theMessage(message As String)
        MainForm.ToolStripStatusLabel.Text = message
    End Sub

    Public Sub theMessage1(message As String)
        MainForm.FAC_message.Text = message
    End Sub

    'open
    ' If conDB.State = ConnectionState.Closed Then conDB.Open()

    'close
    'If conDB.State = ConnectionState.Open Then conDB.Close()

    Public Sub Ali_ReaderConnected_Green()
        MainForm.ReaderStatus_C_D.BackColor = Color.Green
    End Sub
    Public Sub Ali_ReaderDisconnect_Red()
        MainForm.ReaderStatus_C_D.BackColor = Color.Red
    End Sub

End Module
