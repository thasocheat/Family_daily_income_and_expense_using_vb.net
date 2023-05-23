<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.panAuthe = New Guna.UI.WinForms.GunaPanel()
        Me.labAccessDb = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaCheckBox1 = New Guna.UI.WinForms.GunaCheckBox()
        Me.GunaLinkLabel1 = New Guna.UI.WinForms.GunaLinkLabel()
        Me.buttLogin = New Guna.UI.WinForms.GunaButton()
        Me.eyeOpenPwd = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton3 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton2 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton1 = New Guna.UI.WinForms.GunaImageButton()
        Me.txtUserName = New Guna.UI.WinForms.GunaTextBox()
        Me.txtPassword = New Guna.UI.WinForms.GunaTextBox()
        Me.panAuthe.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'panAuthe
        '
        Me.panAuthe.BackColor = System.Drawing.Color.White
        Me.panAuthe.Controls.Add(Me.labAccessDb)
        Me.panAuthe.Controls.Add(Me.GunaLabel1)
        Me.panAuthe.Controls.Add(Me.GunaCheckBox1)
        Me.panAuthe.Controls.Add(Me.GunaLinkLabel1)
        Me.panAuthe.Controls.Add(Me.buttLogin)
        Me.panAuthe.Controls.Add(Me.eyeOpenPwd)
        Me.panAuthe.Controls.Add(Me.GunaImageButton3)
        Me.panAuthe.Controls.Add(Me.GunaImageButton2)
        Me.panAuthe.Controls.Add(Me.GunaImageButton1)
        Me.panAuthe.Controls.Add(Me.txtUserName)
        Me.panAuthe.Controls.Add(Me.txtPassword)
        Me.panAuthe.Location = New System.Drawing.Point(-1, -1)
        Me.panAuthe.Name = "panAuthe"
        Me.panAuthe.Size = New System.Drawing.Size(433, 307)
        Me.panAuthe.TabIndex = 10
        '
        'labAccessDb
        '
        Me.labAccessDb.AutoSize = True
        Me.labAccessDb.Font = New System.Drawing.Font("!Khmer OS Siemreap", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labAccessDb.Location = New System.Drawing.Point(303, 268)
        Me.labAccessDb.Name = "labAccessDb"
        Me.labAccessDb.Size = New System.Drawing.Size(0, 22)
        Me.labAccessDb.TabIndex = 11
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("!Khmer OS Siemreap", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(237, 184)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(102, 22)
        Me.GunaLabel1.TabIndex = 11
        Me.GunaLabel1.Text = "I forgot password"
        '
        'GunaCheckBox1
        '
        Me.GunaCheckBox1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaCheckBox1.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaCheckBox1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaCheckBox1.FillColor = System.Drawing.Color.White
        Me.GunaCheckBox1.Font = New System.Drawing.Font("!Khmer OS Siemreap", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaCheckBox1.Location = New System.Drawing.Point(90, 184)
        Me.GunaCheckBox1.Name = "GunaCheckBox1"
        Me.GunaCheckBox1.Size = New System.Drawing.Size(109, 25)
        Me.GunaCheckBox1.TabIndex = 10
        Me.GunaCheckBox1.Text = "Remember Me"
        '
        'GunaLinkLabel1
        '
        Me.GunaLinkLabel1.AutoSize = True
        Me.GunaLinkLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLinkLabel1.Location = New System.Drawing.Point(182, 275)
        Me.GunaLinkLabel1.Name = "GunaLinkLabel1"
        Me.GunaLinkLabel1.Size = New System.Drawing.Size(49, 15)
        Me.GunaLinkLabel1.TabIndex = 9
        Me.GunaLinkLabel1.TabStop = True
        Me.GunaLinkLabel1.Text = "Register"
        '
        'buttLogin
        '
        Me.buttLogin.AnimationHoverSpeed = 0.07!
        Me.buttLogin.AnimationSpeed = 0.03!
        Me.buttLogin.BackColor = System.Drawing.Color.Transparent
        Me.buttLogin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.buttLogin.BorderColor = System.Drawing.Color.Black
        Me.buttLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttLogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.buttLogin.FocusedColor = System.Drawing.Color.Empty
        Me.buttLogin.Font = New System.Drawing.Font("!Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttLogin.ForeColor = System.Drawing.Color.White
        Me.buttLogin.Image = Nothing
        Me.buttLogin.ImageSize = New System.Drawing.Size(20, 20)
        Me.buttLogin.Location = New System.Drawing.Point(123, 221)
        Me.buttLogin.Name = "buttLogin"
        Me.buttLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.buttLogin.OnHoverBorderColor = System.Drawing.Color.Black
        Me.buttLogin.OnHoverForeColor = System.Drawing.Color.White
        Me.buttLogin.OnHoverImage = Nothing
        Me.buttLogin.OnPressedColor = System.Drawing.Color.Black
        Me.buttLogin.Radius = 20
        Me.buttLogin.Size = New System.Drawing.Size(160, 42)
        Me.buttLogin.TabIndex = 8
        Me.buttLogin.Text = "Log In"
        Me.buttLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'eyeOpenPwd
        '
        Me.eyeOpenPwd.BackColor = System.Drawing.Color.White
        Me.eyeOpenPwd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.eyeOpenPwd.DialogResult = System.Windows.Forms.DialogResult.None
        Me.eyeOpenPwd.Image = Global.Family_daily_management_system.My.Resources.Resources.close_eye
        Me.eyeOpenPwd.ImageSize = New System.Drawing.Size(16, 16)
        Me.eyeOpenPwd.Location = New System.Drawing.Point(307, 157)
        Me.eyeOpenPwd.Name = "eyeOpenPwd"
        Me.eyeOpenPwd.OnHoverImage = Nothing
        Me.eyeOpenPwd.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.eyeOpenPwd.Size = New System.Drawing.Size(23, 14)
        Me.eyeOpenPwd.TabIndex = 4
        '
        'GunaImageButton3
        '
        Me.GunaImageButton3.BackColor = System.Drawing.Color.White
        Me.GunaImageButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton3.Image = Global.Family_daily_management_system.My.Resources.Resources.lock
        Me.GunaImageButton3.ImageSize = New System.Drawing.Size(16, 16)
        Me.GunaImageButton3.Location = New System.Drawing.Point(84, 157)
        Me.GunaImageButton3.Name = "GunaImageButton3"
        Me.GunaImageButton3.OnHoverImage = Nothing
        Me.GunaImageButton3.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton3.Size = New System.Drawing.Size(23, 14)
        Me.GunaImageButton3.TabIndex = 4
        '
        'GunaImageButton2
        '
        Me.GunaImageButton2.BackColor = System.Drawing.Color.White
        Me.GunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton2.Image = Global.Family_daily_management_system.My.Resources.Resources.user_in_textbox
        Me.GunaImageButton2.ImageSize = New System.Drawing.Size(16, 16)
        Me.GunaImageButton2.Location = New System.Drawing.Point(83, 103)
        Me.GunaImageButton2.Name = "GunaImageButton2"
        Me.GunaImageButton2.OnHoverImage = Nothing
        Me.GunaImageButton2.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton2.Size = New System.Drawing.Size(23, 14)
        Me.GunaImageButton2.TabIndex = 4
        '
        'GunaImageButton1
        '
        Me.GunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton1.Image = Global.Family_daily_management_system.My.Resources.Resources.users
        Me.GunaImageButton1.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton1.Location = New System.Drawing.Point(176, 11)
        Me.GunaImageButton1.Name = "GunaImageButton1"
        Me.GunaImageButton1.OnHoverImage = Nothing
        Me.GunaImageButton1.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton1.Size = New System.Drawing.Size(64, 64)
        Me.GunaImageButton1.TabIndex = 4
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.Color.Transparent
        Me.txtUserName.BaseColor = System.Drawing.Color.White
        Me.txtUserName.BorderColor = System.Drawing.Color.Silver
        Me.txtUserName.BorderSize = 1
        Me.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserName.FocusedBaseColor = System.Drawing.Color.White
        Me.txtUserName.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUserName.FocusedForeColor = System.Drawing.Color.DarkGray
        Me.txtUserName.Font = New System.Drawing.Font("!Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.ForeColor = System.Drawing.Color.DarkGray
        Me.txtUserName.Location = New System.Drawing.Point(76, 91)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUserName.Radius = 15
        Me.txtUserName.SelectedText = ""
        Me.txtUserName.Size = New System.Drawing.Size(263, 38)
        Me.txtUserName.TabIndex = 1
        Me.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtPassword.BaseColor = System.Drawing.Color.White
        Me.txtPassword.BorderColor = System.Drawing.Color.Silver
        Me.txtPassword.BorderSize = 1
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.FocusedBaseColor = System.Drawing.Color.Transparent
        Me.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.FocusedForeColor = System.Drawing.Color.DarkGray
        Me.txtPassword.Font = New System.Drawing.Font("!Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.DarkGray
        Me.txtPassword.Location = New System.Drawing.Point(76, 144)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Radius = 15
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(263, 38)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 306)
        Me.Controls.Add(Me.panAuthe)
        Me.Font = New System.Drawing.Font("!Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "FrmLogin"
        Me.Text = "FrmLogin"
        Me.panAuthe.ResumeLayout(False)
        Me.panAuthe.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents panAuthe As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaCheckBox1 As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GunaLinkLabel1 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents buttLogin As Guna.UI.WinForms.GunaButton
    Friend WithEvents eyeOpenPwd As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton3 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton2 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton1 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents txtUserName As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtPassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents labAccessDb As Guna.UI.WinForms.GunaLabel
End Class
