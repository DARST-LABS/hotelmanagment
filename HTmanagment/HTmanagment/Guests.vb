Imports MySql.Data.MySqlClient

Public Class Guests

    Public Sub fill_datagrid()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from  darstlabs.guests ", conDatabase)
            Dim dtgv As MySqlDataAdapter = New MySqlDataAdapter()
            dtgv.SelectCommand = cmdDatabase
            Dim dbDataset As DataTable = New DataTable()
            dtgv.Fill(dbDataset)
            Dim bSource As BindingSource = New BindingSource()
            bSource.DataSource = dbDataset
            dgv_guests.DataSource = bSource
            dtgv.Update(dbDataset)
            conDatabase.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btn_count_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_count.Click
        Dim total As String = 0
        For i As Integer = 0 To dgv_guests.RowCount - 1
            total += dgv_guests.Rows(i).Cells(2).Value
        Next
        txt_total.Text = total

    End Sub

    Private Sub DoneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoneToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Guests_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fill_datagrid()
    End Sub
End Class