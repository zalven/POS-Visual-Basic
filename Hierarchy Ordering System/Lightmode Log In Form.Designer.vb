<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lightlogin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lightlogin))
        Me.Login = New System.Windows.Forms.Button()
        Me.acctypelblerr = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.actiadmin = New System.Windows.Forms.RadioButton()
        Me.acticashier = New System.Windows.Forms.RadioButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.logininfoerror = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Login
        '
        Me.Login.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Login.FlatAppearance.BorderSize = 0
        Me.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Login.ForeColor = System.Drawing.Color.White
        Me.Login.Image = CType(resources.GetObject("Login.Image"), System.Drawing.Image)
        Me.Login.Location = New System.Drawing.Point(179, 379)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(103, 24)
        Me.Login.TabIndex = 5
        Me.Login.UseVisualStyleBackColor = False
        '
        'acctypelblerr
        '
        Me.acctypelblerr.AutoSize = True
        Me.acctypelblerr.BackColor = System.Drawing.Color.Transparent
        Me.acctypelblerr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.acctypelblerr.Location = New System.Drawing.Point(143, 447)
        Me.acctypelblerr.Name = "acctypelblerr"
        Me.acctypelblerr.Size = New System.Drawing.Size(167, 13)
        Me.acctypelblerr.TabIndex = 8
        Me.acctypelblerr.Text = "Please Select Your Account Type"
        Me.acctypelblerr.Visible = False
        '
        'password
        '
        Me.password.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.password.Font = New System.Drawing.Font("Lucida Sans", 10.0!)
        Me.password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.password.Location = New System.Drawing.Point(66, 314)
        Me.password.MaxLength = 10
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.password.Size = New System.Drawing.Size(310, 16)
        Me.password.TabIndex = 2
        '
        'username
        '
        Me.username.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.username.Font = New System.Drawing.Font("Lucida Sans", 10.0!)
        Me.username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.username.Location = New System.Drawing.Point(66, 234)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(310, 16)
        Me.username.TabIndex = 1
        '
        'actiadmin
        '
        Me.actiadmin.AutoSize = True
        Me.actiadmin.BackColor = System.Drawing.Color.Transparent
        Me.actiadmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.actiadmin.FlatAppearance.BorderSize = 0
        Me.actiadmin.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.actiadmin.Location = New System.Drawing.Point(123, 342)
        Me.actiadmin.Name = "actiadmin"
        Me.actiadmin.Size = New System.Drawing.Size(76, 18)
        Me.actiadmin.TabIndex = 3
        Me.actiadmin.TabStop = True
        Me.actiadmin.Text = "               "
        Me.actiadmin.UseVisualStyleBackColor = False
        '
        'acticashier
        '
        Me.acticashier.AutoSize = True
        Me.acticashier.BackColor = System.Drawing.Color.Transparent
        Me.acticashier.FlatAppearance.BorderSize = 0
        Me.acticashier.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.acticashier.Location = New System.Drawing.Point(268, 343)
        Me.acticashier.Name = "acticashier"
        Me.acticashier.Size = New System.Drawing.Size(76, 18)
        Me.acticashier.TabIndex = 4
        Me.acticashier.TabStop = True
        Me.acticashier.Text = "               "
        Me.acticashier.UseVisualStyleBackColor = False
        '
        'logininfoerror
        '
        Me.logininfoerror.AutoSize = True
        Me.logininfoerror.BackColor = System.Drawing.Color.Transparent
        Me.logininfoerror.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.logininfoerror.Location = New System.Drawing.Point(103, 406)
        Me.logininfoerror.Name = "logininfoerror"
        Me.logininfoerror.Size = New System.Drawing.Size(253, 13)
        Me.logininfoerror.TabIndex = 8
        Me.logininfoerror.Text = "The username or password you entered doesnt exist"
        Me.logininfoerror.Visible = False
        '
        'Lightlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(441, 570)
        Me.Controls.Add(Me.acticashier)
        Me.Controls.Add(Me.actiadmin)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.logininfoerror)
        Me.Controls.Add(Me.acctypelblerr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Lightlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lightlogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Login As Button
    Friend WithEvents acctypelblerr As Label
    Friend WithEvents password As TextBox
    Friend WithEvents username As TextBox
    Friend WithEvents actiadmin As RadioButton
    Friend WithEvents acticashier As RadioButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents logininfoerror As Label
End Class
