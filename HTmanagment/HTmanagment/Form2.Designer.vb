<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_checkin = New System.Windows.Forms.Button()
        Me.btn_cancel_rsv = New System.Windows.Forms.Button()
        Me.btn_checkout = New System.Windows.Forms.Button()
        Me.btn_new_rsv = New System.Windows.Forms.Button()
        Me.btn_search_rsv = New System.Windows.Forms.Button()
        Me.smi_search = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.smi_help = New System.Windows.Forms.ToolStripMenuItem()
        Me.smi_rsvp = New System.Windows.Forms.ToolStripMenuItem()
        Me.smi_logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.smi_new = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.smi_about = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_profile = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_maid = New System.Windows.Forms.Button()
        Me.btn_free_rooms = New System.Windows.Forms.Button()
        Me.btn_room_status = New System.Windows.Forms.Button()
        Me.btn_room_info = New System.Windows.Forms.Button()
        Me.btn_arrival = New System.Windows.Forms.Button()
        Me.btn_guestin = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_deleteuser = New System.Windows.Forms.Button()
        Me.btn_usercreate = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_checkin)
        Me.GroupBox1.Controls.Add(Me.btn_cancel_rsv)
        Me.GroupBox1.Controls.Add(Me.btn_checkout)
        Me.GroupBox1.Controls.Add(Me.btn_new_rsv)
        Me.GroupBox1.Controls.Add(Me.btn_search_rsv)
        Me.GroupBox1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(16, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 350)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reservations"
        '
        'btn_checkin
        '
        Me.btn_checkin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_checkin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_checkin.Location = New System.Drawing.Point(24, 161)
        Me.btn_checkin.Name = "btn_checkin"
        Me.btn_checkin.Size = New System.Drawing.Size(169, 45)
        Me.btn_checkin.TabIndex = 4
        Me.btn_checkin.Text = "Check In"
        Me.btn_checkin.UseVisualStyleBackColor = True
        '
        'btn_cancel_rsv
        '
        Me.btn_cancel_rsv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel_rsv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_cancel_rsv.Location = New System.Drawing.Point(24, 275)
        Me.btn_cancel_rsv.Name = "btn_cancel_rsv"
        Me.btn_cancel_rsv.Size = New System.Drawing.Size(169, 45)
        Me.btn_cancel_rsv.TabIndex = 3
        Me.btn_cancel_rsv.Text = "Cancel RSV"
        Me.btn_cancel_rsv.UseVisualStyleBackColor = True
        '
        'btn_checkout
        '
        Me.btn_checkout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_checkout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_checkout.Location = New System.Drawing.Point(24, 220)
        Me.btn_checkout.Name = "btn_checkout"
        Me.btn_checkout.Size = New System.Drawing.Size(169, 45)
        Me.btn_checkout.TabIndex = 2
        Me.btn_checkout.Text = "Check Out"
        Me.btn_checkout.UseVisualStyleBackColor = True
        '
        'btn_new_rsv
        '
        Me.btn_new_rsv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_rsv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_new_rsv.Location = New System.Drawing.Point(24, 105)
        Me.btn_new_rsv.Name = "btn_new_rsv"
        Me.btn_new_rsv.Size = New System.Drawing.Size(169, 45)
        Me.btn_new_rsv.TabIndex = 1
        Me.btn_new_rsv.Text = "New Reservation"
        Me.btn_new_rsv.UseVisualStyleBackColor = True
        '
        'btn_search_rsv
        '
        Me.btn_search_rsv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search_rsv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_search_rsv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_search_rsv.Location = New System.Drawing.Point(24, 45)
        Me.btn_search_rsv.Name = "btn_search_rsv"
        Me.btn_search_rsv.Size = New System.Drawing.Size(169, 45)
        Me.btn_search_rsv.TabIndex = 0
        Me.btn_search_rsv.Text = "RSV Search"
        Me.btn_search_rsv.UseVisualStyleBackColor = True
        '
        'smi_search
        '
        Me.smi_search.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReservationToolStripMenuItem, Me.RoomToolStripMenuItem, Me.GuestToolStripMenuItem})
        Me.smi_search.Name = "smi_search"
        Me.smi_search.Size = New System.Drawing.Size(54, 20)
        Me.smi_search.Text = "Search"
        '
        'ReservationToolStripMenuItem
        '
        Me.ReservationToolStripMenuItem.Name = "ReservationToolStripMenuItem"
        Me.ReservationToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ReservationToolStripMenuItem.Text = "Reservation"
        '
        'RoomToolStripMenuItem
        '
        Me.RoomToolStripMenuItem.Name = "RoomToolStripMenuItem"
        Me.RoomToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.RoomToolStripMenuItem.Text = "Room"
        '
        'GuestToolStripMenuItem
        '
        Me.GuestToolStripMenuItem.Name = "GuestToolStripMenuItem"
        Me.GuestToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.GuestToolStripMenuItem.Text = "Guest"
        '
        'smi_help
        '
        Me.smi_help.Name = "smi_help"
        Me.smi_help.Size = New System.Drawing.Size(44, 20)
        Me.smi_help.Text = "Help"
        '
        'smi_rsvp
        '
        Me.smi_rsvp.Name = "smi_rsvp"
        Me.smi_rsvp.Size = New System.Drawing.Size(147, 22)
        Me.smi_rsvp.Text = "Reservation"
        '
        'smi_logout
        '
        Me.smi_logout.Name = "smi_logout"
        Me.smi_logout.Size = New System.Drawing.Size(62, 20)
        Me.smi_logout.Text = "Log Out"
        '
        'smi_new
        '
        Me.smi_new.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smi_rsvp, Me.AdministratorToolStripMenuItem})
        Me.smi_new.Name = "smi_new"
        Me.smi_new.Size = New System.Drawing.Size(43, 20)
        Me.smi_new.Text = "New"
        '
        'AdministratorToolStripMenuItem
        '
        Me.AdministratorToolStripMenuItem.Name = "AdministratorToolStripMenuItem"
        Me.AdministratorToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.AdministratorToolStripMenuItem.Text = "Administrator"
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_exit.Location = New System.Drawing.Point(551, 336)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(169, 45)
        Me.btn_exit.TabIndex = 12
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smi_new, Me.smi_search, Me.smi_help, Me.smi_logout, Me.smi_about})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(756, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'smi_about
        '
        Me.smi_about.Name = "smi_about"
        Me.smi_about.Size = New System.Drawing.Size(52, 20)
        Me.smi_about.Text = "About"
        '
        'btn_profile
        '
        Me.btn_profile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_profile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_profile.Location = New System.Drawing.Point(24, 144)
        Me.btn_profile.Name = "btn_profile"
        Me.btn_profile.Size = New System.Drawing.Size(169, 45)
        Me.btn_profile.TabIndex = 4
        Me.btn_profile.Text = "Guest Profile"
        Me.btn_profile.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_maid)
        Me.GroupBox4.Controls.Add(Me.btn_free_rooms)
        Me.GroupBox4.Controls.Add(Me.btn_room_status)
        Me.GroupBox4.Controls.Add(Me.btn_room_info)
        Me.GroupBox4.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(527, 39)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(216, 278)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Reservations"
        '
        'btn_maid
        '
        Me.btn_maid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_maid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_maid.Location = New System.Drawing.Point(24, 161)
        Me.btn_maid.Name = "btn_maid"
        Me.btn_maid.Size = New System.Drawing.Size(169, 45)
        Me.btn_maid.TabIndex = 4
        Me.btn_maid.Text = "Assign Maid"
        Me.btn_maid.UseVisualStyleBackColor = True
        '
        'btn_free_rooms
        '
        Me.btn_free_rooms.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_free_rooms.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_free_rooms.Location = New System.Drawing.Point(24, 221)
        Me.btn_free_rooms.Name = "btn_free_rooms"
        Me.btn_free_rooms.Size = New System.Drawing.Size(169, 45)
        Me.btn_free_rooms.TabIndex = 3
        Me.btn_free_rooms.Text = "Free Rooms"
        Me.btn_free_rooms.UseVisualStyleBackColor = True
        '
        'btn_room_status
        '
        Me.btn_room_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_room_status.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_room_status.Location = New System.Drawing.Point(24, 105)
        Me.btn_room_status.Name = "btn_room_status"
        Me.btn_room_status.Size = New System.Drawing.Size(169, 45)
        Me.btn_room_status.TabIndex = 1
        Me.btn_room_status.Text = "Room Status"
        Me.btn_room_status.UseVisualStyleBackColor = True
        '
        'btn_room_info
        '
        Me.btn_room_info.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_room_info.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_room_info.Location = New System.Drawing.Point(24, 45)
        Me.btn_room_info.Name = "btn_room_info"
        Me.btn_room_info.Size = New System.Drawing.Size(169, 45)
        Me.btn_room_info.TabIndex = 0
        Me.btn_room_info.Text = "Room INFO"
        Me.btn_room_info.UseVisualStyleBackColor = True
        '
        'btn_arrival
        '
        Me.btn_arrival.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_arrival.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_arrival.Location = New System.Drawing.Point(24, 89)
        Me.btn_arrival.Name = "btn_arrival"
        Me.btn_arrival.Size = New System.Drawing.Size(169, 45)
        Me.btn_arrival.TabIndex = 1
        Me.btn_arrival.Text = "Arrivals"
        Me.btn_arrival.UseVisualStyleBackColor = True
        '
        'btn_guestin
        '
        Me.btn_guestin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guestin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_guestin.Location = New System.Drawing.Point(24, 30)
        Me.btn_guestin.Name = "btn_guestin"
        Me.btn_guestin.Size = New System.Drawing.Size(169, 45)
        Me.btn_guestin.TabIndex = 0
        Me.btn_guestin.Text = "Guests In House"
        Me.btn_guestin.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_deleteuser)
        Me.GroupBox3.Controls.Add(Me.btn_usercreate)
        Me.GroupBox3.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(275, 264)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(216, 125)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Main"
        '
        'btn_deleteuser
        '
        Me.btn_deleteuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deleteuser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_deleteuser.Location = New System.Drawing.Point(24, 78)
        Me.btn_deleteuser.Name = "btn_deleteuser"
        Me.btn_deleteuser.Size = New System.Drawing.Size(169, 33)
        Me.btn_deleteuser.TabIndex = 1
        Me.btn_deleteuser.Text = "Remove User"
        Me.btn_deleteuser.UseVisualStyleBackColor = True
        '
        'btn_usercreate
        '
        Me.btn_usercreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_usercreate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_usercreate.Location = New System.Drawing.Point(24, 30)
        Me.btn_usercreate.Name = "btn_usercreate"
        Me.btn_usercreate.Size = New System.Drawing.Size(169, 35)
        Me.btn_usercreate.TabIndex = 0
        Me.btn_usercreate.Text = "Create User"
        Me.btn_usercreate.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_profile)
        Me.GroupBox2.Controls.Add(Me.btn_arrival)
        Me.GroupBox2.Controls.Add(Me.btn_guestin)
        Me.GroupBox2.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(275, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 206)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Guests"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 408)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form2"
        Me.Text = "REQUESTS"
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_checkin As System.Windows.Forms.Button
    Friend WithEvents btn_cancel_rsv As System.Windows.Forms.Button
    Friend WithEvents btn_checkout As System.Windows.Forms.Button
    Friend WithEvents btn_new_rsv As System.Windows.Forms.Button
    Friend WithEvents btn_search_rsv As System.Windows.Forms.Button
    Friend WithEvents smi_search As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smi_help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smi_rsvp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smi_logout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smi_new As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents smi_about As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_profile As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_maid As System.Windows.Forms.Button
    Friend WithEvents btn_free_rooms As System.Windows.Forms.Button
    Friend WithEvents btn_room_info As System.Windows.Forms.Button
    Friend WithEvents btn_arrival As System.Windows.Forms.Button
    Friend WithEvents btn_guestin As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_deleteuser As System.Windows.Forms.Button
    Friend WithEvents btn_usercreate As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ReservationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministratorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_room_status As System.Windows.Forms.Button
End Class
