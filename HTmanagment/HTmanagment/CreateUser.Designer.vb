<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateUser
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
        Me.txt_ccpassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_create = New System.Windows.Forms.Button()
        Me.txt_cpassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cusername = New System.Windows.Forms.TextBox()
        Me.txt_cname = New System.Windows.Forms.TextBox()
        Me.txt_cid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox1.Controls.Add(Me.btn_cancel)
        Me.GroupBox1.Controls.Add(Me.txt_ccpassword)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btn_create)
        Me.GroupBox1.Controls.Add(Me.txt_cpassword)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_cusername)
        Me.GroupBox1.Controls.Add(Me.txt_cname)
        Me.GroupBox1.Controls.Add(Me.txt_cid)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(477, 300)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CREATE NEW ADMINISTRATOR"
        '
        'txt_ccpassword
        '
        Me.txt_ccpassword.Location = New System.Drawing.Point(225, 182)
        Me.txt_ccpassword.Name = "txt_ccpassword"
        Me.txt_ccpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_ccpassword.Size = New System.Drawing.Size(167, 22)
        Me.txt_ccpassword.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(100, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 12)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "CONFIRM PASSWORD"
        '
        'btn_create
        '
        Me.btn_create.Location = New System.Drawing.Point(253, 224)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(139, 33)
        Me.btn_create.TabIndex = 8
        Me.btn_create.Text = "CREATE"
        Me.btn_create.UseVisualStyleBackColor = True
        '
        'txt_cpassword
        '
        Me.txt_cpassword.Location = New System.Drawing.Point(225, 143)
        Me.txt_cpassword.Name = "txt_cpassword"
        Me.txt_cpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_cpassword.Size = New System.Drawing.Size(167, 22)
        Me.txt_cpassword.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(112, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "PASSWORD"
        '
        'txt_cusername
        '
        Me.txt_cusername.Location = New System.Drawing.Point(225, 105)
        Me.txt_cusername.Name = "txt_cusername"
        Me.txt_cusername.Size = New System.Drawing.Size(167, 22)
        Me.txt_cusername.TabIndex = 5
        '
        'txt_cname
        '
        Me.txt_cname.Location = New System.Drawing.Point(225, 67)
        Me.txt_cname.Name = "txt_cname"
        Me.txt_cname.Size = New System.Drawing.Size(167, 22)
        Me.txt_cname.TabIndex = 4
        '
        'txt_cid
        '
        Me.txt_cid.Location = New System.Drawing.Point(225, 30)
        Me.txt_cid.Name = "txt_cid"
        Me.txt_cid.Size = New System.Drawing.Size(167, 22)
        Me.txt_cid.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(112, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "USERNAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(113, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID NUMBER"
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(55, 224)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(139, 33)
        Me.btn_cancel.TabIndex = 11
        Me.btn_cancel.Text = "CANCEL"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'CreateUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 346)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CreateUser"
        Me.Text = "CreateUser"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_ccpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_create As System.Windows.Forms.Button
    Friend WithEvents txt_cpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_cusername As System.Windows.Forms.TextBox
    Friend WithEvents txt_cname As System.Windows.Forms.TextBox
    Friend WithEvents txt_cid As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
End Class
