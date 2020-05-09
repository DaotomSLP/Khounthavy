<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox35 = New System.Windows.Forms.GroupBox()
        Me.txtUsersPass = New System.Windows.Forms.TextBox()
        Me.GroupBox38 = New System.Windows.Forms.GroupBox()
        Me.txtUsersName = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox35.SuspendLayout()
        Me.GroupBox38.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Khounthavy.My.Resources.Resources._585e4beacb11b227491c3399
        Me.PictureBox1.Location = New System.Drawing.Point(213, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox35
        '
        Me.GroupBox35.Controls.Add(Me.txtUsersPass)
        Me.GroupBox35.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox35.Font = New System.Drawing.Font("Phetsarath OT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox35.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox35.Location = New System.Drawing.Point(45, 188)
        Me.GroupBox35.Name = "GroupBox35"
        Me.GroupBox35.Size = New System.Drawing.Size(441, 60)
        Me.GroupBox35.TabIndex = 12
        Me.GroupBox35.TabStop = False
        Me.GroupBox35.Text = "ລະຫັດຜ່ານ :"
        '
        'txtUsersPass
        '
        Me.txtUsersPass.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtUsersPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsersPass.ForeColor = System.Drawing.Color.Green
        Me.txtUsersPass.Location = New System.Drawing.Point(3, 28)
        Me.txtUsersPass.Name = "txtUsersPass"
        Me.txtUsersPass.Size = New System.Drawing.Size(432, 28)
        Me.txtUsersPass.TabIndex = 0
        Me.txtUsersPass.UseSystemPasswordChar = True
        '
        'GroupBox38
        '
        Me.GroupBox38.Controls.Add(Me.txtUsersName)
        Me.GroupBox38.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox38.Font = New System.Drawing.Font("Phetsarath OT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox38.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox38.Location = New System.Drawing.Point(45, 112)
        Me.GroupBox38.Name = "GroupBox38"
        Me.GroupBox38.Size = New System.Drawing.Size(441, 60)
        Me.GroupBox38.TabIndex = 11
        Me.GroupBox38.TabStop = False
        Me.GroupBox38.Text = "ຊື່ຜູ້ໃຊ້  :"
        '
        'txtUsersName
        '
        Me.txtUsersName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtUsersName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsersName.ForeColor = System.Drawing.Color.Green
        Me.txtUsersName.Location = New System.Drawing.Point(3, 28)
        Me.txtUsersName.Name = "txtUsersName"
        Me.txtUsersName.Size = New System.Drawing.Size(432, 28)
        Me.txtUsersName.TabIndex = 0
        '
        'btnLogin
        '
        Me.btnLogin.FlatAppearance.BorderSize = 2
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Phetsarath OT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnLogin.Location = New System.Drawing.Point(283, 263)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(203, 49)
        Me.btnLogin.TabIndex = 13
        Me.btnLogin.Text = "ເຂົ້າສູ່ລະບົບ"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.FlatAppearance.BorderSize = 2
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Phetsarath OT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnExit.Location = New System.Drawing.Point(45, 263)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(202, 49)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "ອອກ"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Maroon
        Me.Button1.Location = New System.Drawing.Point(442, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Server"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(529, 331)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.GroupBox35)
        Me.Controls.Add(Me.GroupBox38)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox35.ResumeLayout(False)
        Me.GroupBox35.PerformLayout()
        Me.GroupBox38.ResumeLayout(False)
        Me.GroupBox38.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox35 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUsersPass As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox38 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUsersName As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
