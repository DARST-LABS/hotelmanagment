Public Class Form2

    Private Sub btn_search_rsv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search_rsv.Click
        Me.Hide()
        SearchRSV.Show()
    End Sub

    Private Sub btn_new_rsv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_new_rsv.Click
        Me.Hide()
        NewRSV.Show()
    End Sub

    Private Sub btn_checkout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_checkout.Click
        Me.Hide()
        DeleteRSV.Show()
    End Sub

    Private Sub btn_cancel_rsv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel_rsv.Click
        Me.Hide()
        DeleteRSV.Show()
    End Sub

    Private Sub btn_checkin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_checkin.Click
        Me.Hide()
        CheckIn.Show()
    End Sub

    Private Sub smi_rsvp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smi_rsvp.Click
        Me.Hide()
        NewRSV.Show()
    End Sub

    Private Sub AdministratorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministratorToolStripMenuItem.Click
        Me.Hide()
        CreateUser.Show()

    End Sub

    Private Sub ReservationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservationToolStripMenuItem.Click
        Me.Hide()
        SearchRSV.Show()
    End Sub

    Private Sub smi_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smi_logout.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btn_guestin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guestin.Click
        Me.Hide()
        Guests.Show()
    End Sub

    Private Sub btn_arrival_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_arrival.Click
        Me.Hide()
        Guests.Show()
    End Sub

    Private Sub btn_profile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_profile.Click
        Me.Hide()
        Guests.Show()
    End Sub

    Private Sub btn_usercreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_usercreate.Click
        Me.Hide()
        CreateUser.Show()
    End Sub

    Private Sub btn_deleteuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_deleteuser.Click
        Me.Hide()
        DeleteUser.Show()
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Application.Exit()

    End Sub


    Private Sub btn_room_info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_room_info.Click
        Me.Hide()
        RoomInfo.Show()
    End Sub

    Private Sub btn_room_status_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_room_status.Click
        Me.Hide()
        RoomStatus.Show()
    End Sub

    Private Sub btn_maid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_maid.Click
        Me.Hide()
        RoomMaid.Show()
    End Sub

    Private Sub btn_free_rooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_free_rooms.Click
        Me.Hide()
        RoomStatus.Show()
    End Sub

    Private Sub RoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomToolStripMenuItem.Click
        Me.Hide()
        RoomStatus.Show()
    End Sub

    Private Sub GuestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuestToolStripMenuItem.Click
        Me.Hide()
        Guests.Show()
    End Sub

    Private Sub smi_about_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smi_about.Click
        Me.Hide()
        About.Show()

    End Sub

    Private Sub smi_help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smi_help.Click
        MessageBox.Show("under development")
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class