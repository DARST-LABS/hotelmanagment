<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomInfo
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
        Me.btn_addroom = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_maid = New System.Windows.Forms.TextBox()
        Me.txt_rmno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.smi_done = New System.Windows.Forms.ToolStripMenuItem()
        Me.smi_clear = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgv_rsv = New System.Windows.Forms.DataGridView()
        Me.gb_room = New System.Windows.Forms.GroupBox()
        Me.cmb_bookstatus = New System.Windows.Forms.ComboBox()
        Me.cmb_status = New System.Windows.Forms.ComboBox()
        Me.cmb_wing = New System.Windows.Forms.ComboBox()
        Me.btn_addview = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgv_rsv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_room.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_addroom
        '
        Me.btn_addroom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addroom.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_addroom.Location = New System.Drawing.Point(55, 236)
        Me.btn_addroom.Name = "btn_addroom"
        Me.btn_addroom.Size = New System.Drawing.Size(165, 31)
        Me.btn_addroom.TabIndex = 17
        Me.btn_addroom.Text = "PROCEED"
        Me.btn_addroom.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(4, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "BOOK STATUS"
        '
        'txt_maid
        '
        Me.txt_maid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_maid.Location = New System.Drawing.Point(95, 159)
        Me.txt_maid.Name = "txt_maid"
        Me.txt_maid.Size = New System.Drawing.Size(167, 20)
        Me.txt_maid.TabIndex = 9
        '
        'txt_rmno
        '
        Me.txt_rmno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rmno.Location = New System.Drawing.Point(95, 30)
        Me.txt_rmno.Name = "txt_rmno"
        Me.txt_rmno.Size = New System.Drawing.Size(167, 20)
        Me.txt_rmno.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(55, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "WING"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smi_done, Me.smi_clear})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(811, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'smi_done
        '
        Me.smi_done.Name = "smi_done"
        Me.smi_done.Size = New System.Drawing.Size(47, 20)
        Me.smi_done.Text = "Done"
        '
        'smi_clear
        '
        Me.smi_clear.Name = "smi_clear"
        Me.smi_clear.Size = New System.Drawing.Size(46, 20)
        Me.smi_clear.Text = "Clear"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(6, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ROOM NUMBER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(39, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "STATUS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(52, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "MAID"
        '
        'dgv_rsv
        '
        Me.dgv_rsv.AllowUserToAddRows = False
        Me.dgv_rsv.AllowUserToDeleteRows = False
        Me.dgv_rsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_rsv.Location = New System.Drawing.Point(295, 27)
        Me.dgv_rsv.Name = "dgv_rsv"
        Me.dgv_rsv.ReadOnly = True
        Me.dgv_rsv.Size = New System.Drawing.Size(501, 430)
        Me.dgv_rsv.TabIndex = 13
        '
        'gb_room
        '
        Me.gb_room.Controls.Add(Me.cmb_bookstatus)
        Me.gb_room.Controls.Add(Me.cmb_status)
        Me.gb_room.Controls.Add(Me.cmb_wing)
        Me.gb_room.Controls.Add(Me.btn_addroom)
        Me.gb_room.Controls.Add(Me.Label8)
        Me.gb_room.Controls.Add(Me.txt_maid)
        Me.gb_room.Controls.Add(Me.txt_rmno)
        Me.gb_room.Controls.Add(Me.Label2)
        Me.gb_room.Controls.Add(Me.Label5)
        Me.gb_room.Controls.Add(Me.Label3)
        Me.gb_room.Controls.Add(Me.Label4)
        Me.gb_room.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_room.ForeColor = System.Drawing.Color.Blue
        Me.gb_room.Location = New System.Drawing.Point(13, 25)
        Me.gb_room.Name = "gb_room"
        Me.gb_room.Size = New System.Drawing.Size(276, 278)
        Me.gb_room.TabIndex = 12
        Me.gb_room.TabStop = False
        Me.gb_room.Text = "Room Details"
        '
        'cmb_bookstatus
        '
        Me.cmb_bookstatus.FormattingEnabled = True
        Me.cmb_bookstatus.Items.AddRange(New Object() {"FREE", "BOOKED"})
        Me.cmb_bookstatus.Location = New System.Drawing.Point(95, 194)
        Me.cmb_bookstatus.Name = "cmb_bookstatus"
        Me.cmb_bookstatus.Size = New System.Drawing.Size(167, 25)
        Me.cmb_bookstatus.TabIndex = 20
        '
        'cmb_status
        '
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.Items.AddRange(New Object() {"AVAILABLE", "UNDER MAINTAINANCE"})
        Me.cmb_status.Location = New System.Drawing.Point(95, 116)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(167, 25)
        Me.cmb_status.TabIndex = 19
        '
        'cmb_wing
        '
        Me.cmb_wing.FormattingEnabled = True
        Me.cmb_wing.Items.AddRange(New Object() {"NORTH", "SOUTH", "WEST", "EAST"})
        Me.cmb_wing.Location = New System.Drawing.Point(95, 72)
        Me.cmb_wing.Name = "cmb_wing"
        Me.cmb_wing.Size = New System.Drawing.Size(167, 25)
        Me.cmb_wing.TabIndex = 18
        '
        'btn_addview
        '
        Me.btn_addview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addview.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_addview.Location = New System.Drawing.Point(68, 337)
        Me.btn_addview.Name = "btn_addview"
        Me.btn_addview.Size = New System.Drawing.Size(165, 31)
        Me.btn_addview.TabIndex = 18
        Me.btn_addview.Text = "ADD ROOM"
        Me.btn_addview.UseVisualStyleBackColor = True
        '
        'RoomInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 462)
        Me.Controls.Add(Me.btn_addview)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgv_rsv)
        Me.Controls.Add(Me.gb_room)
        Me.Name = "RoomInfo"
        Me.Text = "RoomInfo"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgv_rsv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_room.ResumeLayout(False)
        Me.gb_room.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_addroom As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_maid As System.Windows.Forms.TextBox
    Friend WithEvents txt_rmno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents smi_done As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smi_clear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgv_rsv As System.Windows.Forms.DataGridView
    Friend WithEvents gb_room As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_bookstatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_status As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_wing As System.Windows.Forms.ComboBox
    Friend WithEvents btn_addview As System.Windows.Forms.Button
End Class
