Imports System.ComponentModel
Imports System.Data.SQLite

Public Class TableForm
    Private Sub TableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getAllData()
    End Sub


    Private Sub getAllData()
        Dim conDB As New SQLiteConnection(ModuleDB.DBpath)
        Try
            conDB.Open()
        Catch ex As Exception
            conDB.Dispose()
            conDB = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Dim dt As New DataTable
        Try
            dafill("select * from informations_tb order by id", dt, conDB)
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dt.Dispose()
        dt = Nothing
        conDB.Close()
        conDB.Dispose()
        conDB = Nothing
    End Sub

    Private Sub dafill(ByVal qeury As String, ByVal table As DataTable, ByVal con As SQLiteConnection)
        Dim da As New SQLiteDataAdapter(qeury, con)
        da.Fill(table)
        da.Dispose()
        da = Nothing
    End Sub

    Private Sub Button_Refresh_Click(sender As Object, e As EventArgs) Handles Button_Refresh.Click
        getAllData()
        TextBox_ID.Clear()
    End Sub

    Private Sub TableForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MainForm.MinistryOfHealthMenu.Enabled = True
    End Sub

    Private Sub Button_Search_Click(sender As Object, e As EventArgs) Handles Button_Search.Click

        ' we can do short here , short code ..
        Dim q As String
        If TextBox_ID.Text = Nothing Then
            q = "select * from informations_tb order by id"
        Else
            q = "select * from informations_tb where id=" & TextBox_ID.Text ' ID integer
        End If

        Dim conDb As New SQLiteConnection(ModuleDB.DBpath)
        Try
            conDb.Open()
        Catch ex As Exception
            conDb.Dispose()
            conDb = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Dim dt As New DataTable
        Try
            dafill(q, dt, conDb)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If dt.Rows.Count > 0 Then
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = dt

        End If
        dt.Dispose()
        dt = Nothing
        conDb.Close()
        conDb.Dispose()
        conDb = Nothing
    End Sub

    Private Sub Button_Remove_Click(sender As Object, e As EventArgs) Handles Button_Remove.Click
        If MsgBox("Delete record? هل تريد حذف هذا السجل", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmation تاكيد") = MsgBoxResult.Cancel Then Return

        Dim conDB As New SQLiteConnection(ModuleDB.DBpath)
        Try
            conDB.Open()
        Catch ex As Exception
            conDB.Dispose()
            conDB = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Try
            'all information  table
            ExecuteNonQuery("delete from informations_tb where id=" & TextBox_ID.Text, conDB)
            'fingerpritnt  table
            ExecuteNonQuery("delete from fingerprints_tb where id=" & TextBox_ID.Text, conDB)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conDB.Close()
        conDB.Dispose()
        conDB = Nothing

        TextBox_ID.Clear()
        getAllData()
    End Sub
    Private Sub ExecuteNonQuery(ByVal query As String, ByVal cn As SQLiteConnection)
        Dim cm As New SQLiteCommand(query, cn)
        cm.ExecuteNonQuery()
        cm.Dispose()
        cm = Nothing
    End Sub

    Private Sub TextBox_ID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_ID.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then 'only number
            e.Handled = True
        End If
    End Sub
End Class