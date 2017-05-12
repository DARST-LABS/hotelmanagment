Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from  darstlabs.users where username='" & txt_luser.Text & "' and password='" & txt_lpassword.Text & "';", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            Dim count As Integer = 0
            If (myReader.HasRows()) Then
                count = count + 1
            End If
            If (count = 1) Then
                MessageBox.Show("username and password correct and access granted")
                txt_luser.Text = ""
                txt_lpassword.Text = ""
                Form2.Show()
                Me.Visible = False
            ElseIf (count < 1) Then
                MessageBox.Show("no such details")
            Else
                MessageBox.Show("wrong username or password")
            End If
            mycon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Application.Exit()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_luser.Text = "Admin"
    End Sub
End Class
