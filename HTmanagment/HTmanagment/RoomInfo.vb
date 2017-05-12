Imports MySql.Data.MySqlClient

Public Class RoomInfo

    Public Sub fill_datagrid()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from  darstlabs.rooms ", conDatabase)
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

    Private Sub smi_done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smi_done.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub smi_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smi_clear.Click
        txt_maid.Text = ""
        txt_rmno.Text = ""
        cmb_bookstatus.Text = ""
        cmb_status.Text = ""
        cmb_wing.Text = ""

    End Sub

    Private Sub btn_addroom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addroom.Click
        If (txt_maid.Text = "" Or cmb_status.Text = "" Or cmb_bookstatus.Text = "" Or cmb_wing.Text = "") Then
            'validating empty fields
            MessageBox.Show("All fields are required")

        Else
            Try
                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into darstlabs.rooms(roomNumber,wing,status,maid,bookStatus) values('" & txt_rmno.Text & "','" & cmb_wing.Text & "','" & cmb_status.Text & "','" & txt_maid.Text & "','" & cmb_bookstatus.Text & "') ", mycon)
                Dim myReader As MySqlDataReader
                mycon.Open()
                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("Data has been saved")
                fill_datagrid()
                mycon.Close()

                txt_maid.Text = ""
                txt_rmno.Text = ""
                cmb_bookstatus.Text = ""
                cmb_status.Text = ""
                cmb_wing.Text = ""
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub RoomInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fill_datagrid()
        gb_room.Visible = False
    End Sub

    Private Sub btn_addview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addview.Click
        gb_room.Visible = True
    End Sub
End Class