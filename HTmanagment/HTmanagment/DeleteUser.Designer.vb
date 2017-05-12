<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteUser
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
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.txt_cpassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cusername = New System.Windows.Forms.TextBox()
        Me.txt_cname = New System.Windows.Forms.TextBox()
        Me.txt_cid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_view = New System.Windows.Forms.Button()
        Me.dgv_users = New System.Windows.Forms.DataGridView()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_done = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_users, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox1.Controls.Add(Me.btn_clear)
        Me.GroupBox1.Controls.Add(Me.btn_view)
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Controls.Add(Me.txt_cpassword)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_cusername)
        Me.GroupBox1.Controls.Add(Me.txt_cname)
        Me.GroupBox1.Controls.Add(Me.txt_cid)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 300)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CREATE NEW ADMINISTRATOR"
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(153, 221)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(128, 33)
        Me.btn_delete.TabIndex = 8
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'txt_cpassword
        '
        Me.txt_cpassword.Location = New System.Drawing.Point(114, 164)
        Me.txt_cpassword.Name = "txt_cpassword"
        Me.txt_cpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_cpassword.Size = New System.Drawing.Size(167, 22)
        Me.txt_cpassword.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "PASSWORD"
        '
        'txt_cusername
        '
        Me.txt_cusername.Location = New System.Drawing.Point(114, 126)
        Me.txt_cusername.Name = "txt_cusername"
        Me.txt_cusername.Size = New System.Drawing.Size(167, 22)
        Me.txt_cusername.TabIndex = 5
        '
        'txt_cname
        '
        Me.txt_cname.Location = New System.Drawing.Point(114, 88)
        Me.txt_cname.Name = "txt_cname"
        Me.txt_cname.Size = New System.Drawing.Size(167, 22)
        Me.txt_cname.TabIndex = 4
        '
        'txt_cid
        '
        Me.txt_cid.Location = New System.Drawing.Point(114, 51)
        Me.txt_cid.Name = "txt_cid"
        Me.txt_cid.Size = New System.Drawing.Size(167, 22)
        Me.txt_cid.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "USERNAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID NUMBER"
        '
        'btn_view
        '
        Me.btn_view.Location = New System.Drawing.Point(21, 221)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.Size = New System.Drawing.Size(126, 33)
        Me.btn_view.TabIndex = 11
        Me.btn_view.Text = "VIEW"
        Me.btn_view.UseVisualStyleBackColor = True
        '
        'dgv_users
        '
        Me.dgv_users.AllowUserToAddRows = False
        Me.dgv_users.AllowUserToDeleteRows = False
        Me.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_users.Location = New System.Drawing.Point(315, 12)
        Me.dgv_users.Name = "dgv_users"
        Me.dgv_users.ReadOnly = True
        Me.dgv_users.Size = New System.Drawing.Size(408, 392)
        Me.dgv_users.TabIndex = 7
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(88, 261)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(139, 33)
        Me.btn_clear.TabIndex = 12
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_done
        '
        Me.btn_done.Location = New System.Drawing.Point(100, 371)
        Me.btn_done.Name = "btn_done"
        Me.btn_done.Size = New System.Drawing.Size(139, 33)
        Me.btn_done.TabIndex = 13
        Me.btn_done.Text = "DONE"
        Me.btn_done.UseVisualStyleBackColor = True
        '
        'DeleteUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 416)
        Me.Controls.Add(Me.btn_done)
        Me.Controls.Add(Me.dgv_users)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "DeleteUser"
        Me.Text = "DeleteUser"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_users, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_view As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents txt_cpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_cusername As System.Windows.Forms.TextBox
    Friend WithEvents txt_cname As System.Windows.Forms.TextBox
    Friend WithEvents txt_cid As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_users As System.Windows.Forms.DataGridView
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_done As System.Windows.Forms.Button
End Class
