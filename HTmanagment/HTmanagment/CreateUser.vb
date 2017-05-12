Imports MySql.Data.MySqlClient

Public Class CreateUser

    Private Sub btn_create_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_create.Click
        If (txt_cid.Text = "" Or txt_cusername.Text = "" Or txt_cname.Text = "" Or txt_ccpassword.Text = "") Then
            'validating empty fields
            MessageBox.Show("All fields are required")

        ElseIf txt_cid.TextLength < 4 Then
            MessageBox.Show("invalid id length")
            txt_cid.BackColor = Color.Red

        ElseIf (txt_cpassword.TextLength < 8) Then
            'validating minimum number of characters
            MessageBox.Show("password must be eight characters and above")
            txt_ccpassword.BackColor = Color.Red
            txt_cpassword.BackColor = Color.Red

        ElseIf (txt_ccpassword.Text = txt_cpassword.Text) And (txt_cpassword.TextLength >= 8) Then
            Try
                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into darstlabs.users(idnumber,name,username,password) values('" & txt_cid.Text & "','" & txt_cname.Text & "','" & txt_cusername.Text & "','" & txt_ccpassword.Text & "') ", mycon)
                Dim myReader As MySqlDataReader
                mycon.Open()
                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("Data has been saved")
                mycon.Close()

                txt_cid.Text = ""
                txt_cname.Text = ""
                txt_cusername.Text = ""
                txt_cpassword.Text = ""
                txt_ccpassword.Text = ""
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("passwords dont match")
        End If
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Hide()
        Form2.Show()

    End Sub
End Class