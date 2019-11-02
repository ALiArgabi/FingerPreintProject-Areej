Imports System.Data.SQLite
Module ModuleDB
    'DB path
    Public DBpath As String = "Data Source=" & Application.StartupPath & "\FingerPreintProjectDB.db;"

    Public Sub theMessage(message As String)
        MainForm.ToolStripStatusLabel.Text = message
    End Sub

    'open
    ' If conDB.State = ConnectionState.Closed Then conDB.Open()

    'close
    'If conDB.State = ConnectionState.Open Then conDB.Close()


End Module
