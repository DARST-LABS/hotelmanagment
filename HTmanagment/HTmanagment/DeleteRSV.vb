Imports MySql.Data.MySqlClient

Public Class DeleteRSV

    Public Sub fill_datagrid()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from  darstlabs.reservations ", conDatabase)
            Dim dtgv As MySqlDataAdapter = New MySqlDataAdapter()
            dtgv.SelectCommand = cmdDatabase
            Dim dbDataset As DataTable = New DataTable()
            dtgv.Fill(dbDataset)
            Dim bSource As BindingSource = New BindingSource()
            bSource.DataSource = dbDataset
            dgv_rsv.DataSource = bSource
            dtgv.Update(dbDataset)
            conDatabase.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub btn_delrsv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delrsv.Click
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from darstlabs.reservations  where rsvNumber='" & txt_rsvnumber.Text & "' ", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            MessageBox.Show("Data has been deleted")
            txt_rsvnumber.Text = ""
            txt_fname.Text = ""
            txt_lname.Text = ""
            txt_tel.Text = ""
            txt_email.Text = ""
            txt_rmno.Text = ""
            txt_persons.Text = ""
            fill_datagrid()

            mycon.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub DeleteRSV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fill_datagrid()
    End Sub

    Private Sub btn_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_view.Click
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from  darstlabs.reservations where rsvNumber='" + txt_rsvnumber.Text + "' ;", conDatabase)
            Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
            sda.SelectCommand = cmdDatabase
            Dim dbDataset As DataTable = New DataTable()
            sda.Fill(dbDataset)
            Dim bSource As BindingSource = New BindingSource()
            bSource.DataSource = dbDataset
            dgv_rsv.DataSource = bSource
            sda.Update(dbDataset)
            conDatabase.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Dim i As Integer
        i = dgv_rsv.CurrentRow.Index
        Me.txt_rsvnumber.Text = dgv_rsv.Item(0, i).Value
        Me.txt_fname.Text = dgv_rsv.Item(1, i).Value
        Me.txt_lname.Text = dgv_rsv.Item(2, i).Value
        Me.txt_tel.Text = dgv_rsv.Item(3, i).Value
        Me.txt_email.Text = dgv_rsv.Item(4, i).Value
        Me.txt_rmno.Text = dgv_rsv.Item(5, i).Value
        Me.txt_persons.Text = dgv_rsv.Item(6, i).Value
        Me.dtp_rsvdate.Text = dgv_rsv.Item(7, i).Value
        Me.cmb_chkstatus.Text = dgv_rsv.Item(8, i).Value
    End Sub

    Private Sub smi_done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smi_done.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub smi_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smi_clear.Click
        txt_rsvnumber.Text = ""
        txt_fname.Text = ""
        txt_lname.Text = ""
        txt_tel.Text = ""
        txt_email.Text = ""
        txt_rmno.Text = ""
        txt_persons.Text = ""
        fill_datagrid()
        cmb_chkstatus.Text = ""
    End Sub
End Class