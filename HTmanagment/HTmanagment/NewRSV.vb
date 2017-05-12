Imports MySql.Data.MySqlClient

Public Class NewRSV

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

    Private Sub btn_rsvcreation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_rsvcreation.Click
        If (txt_rsvnumber.Text = "" Or txt_fname.Text = "" Or txt_lname.Text = "" Or txt_email.Text = "" Or txt_tel.Text = "" Or txt_rmno.Text = "" Or txt_persons.Text = "") Then
            'validating empty fields
            MessageBox.Show("All fields are required")

        Else
            Try
                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into darstlabs.reservations(rsvNumber,firstName,lastName,telephone,roomNumber,email,personels,date) values('" & txt_rsvnumber.Text & "','" & txt_fname.Text & "','" & txt_lname.Text & "','" & txt_tel.Text & "','" & txt_rmno.Text & "','" & txt_email.Text & "','" & txt_persons.Text & "','" & dtp_rsvdate.Text & "') ", mycon)
                Dim SelectCommand2 As MySqlCommand = New MySqlCommand("insert into darstlabs.guests(firstName,lastName,telephone,email) values('" & txt_fname.Text & "','" & txt_lname.Text & "','" & txt_tel.Text & "','" & txt_email.Text & "') ", mycon)
                Dim myReader As MySqlDataReader
                mycon.Open()
                myReader = SelectCommand.ExecuteReader()
                mycon.Close()
                mycon.Open()
                myReader = SelectCommand2.ExecuteReader()
                MessageBox.Show("Data has been saved")
                fill_datagrid()
                mycon.Close()

                txt_rsvnumber.Text = ""
                txt_fname.Text = ""
                txt_lname.Text = ""
                txt_tel.Text = ""
                txt_email.Text = ""
                txt_rmno.Text = ""
                txt_persons.Text = ""
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
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
        dtp_rsvdate.Text = ""
    End Sub

    Private Sub NewRSV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fill_datagrid()
        dtp_rsvdate.Text = ""
    End Sub
End Class