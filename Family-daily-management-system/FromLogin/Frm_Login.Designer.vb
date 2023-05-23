<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Login))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.panAuthe = New Guna.UI.WinForms.GunaPanel()
        Me.btnRegister = New Guna.UI.WinForms.GunaButton()
        Me.btnSignIn = New Guna.UI.WinForms.GunaButton()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GunaControlBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaControlBox1.IconColor = System.Drawing.Color.Black
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(385, 0)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.Red
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(45, 35)
        Me.GunaControlBox1.TabIndex = 1
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.White
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.GunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.ShadowDepth = 10
        Me.GunaShadowPanel1.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(431, 36)
        Me.GunaShadowPanel1.TabIndex = 3
        '
        'panAuthe
        '
        Me.panAuthe.BackColor = System.Drawing.Color.White
        Me.panAuthe.Location = New System.Drawing.Point(0, 98)
        Me.panAuthe.Name = "panAuthe"
        Me.panAuthe.Size = New System.Drawing.Size(431, 306)
        Me.panAuthe.TabIndex = 9
        '
        'btnRegister
        '
        Me.btnRegister.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegister.AnimationHoverSpeed = 0.07!
        Me.btnRegister.AnimationSpeed = 0.03!
        Me.btnRegister.BackColor = System.Drawing.Color.White
        Me.btnRegister.BaseColor = System.Drawing.Color.White
        Me.btnRegister.BorderColor = System.Drawing.Color.Black
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegister.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRegister.Enabled = False
        Me.btnRegister.FocusedColor = System.Drawing.Color.Empty
        Me.btnRegister.Font = New System.Drawing.Font("!Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.Black
        Me.btnRegister.Image = Global.Family_daily_management_system.My.Resources.Resources.register
        Me.btnRegister.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnRegister.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnRegister.Location = New System.Drawing.Point(215, 35)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRegister.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnRegister.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRegister.OnHoverImage = Nothing
        Me.btnRegister.OnPressedColor = System.Drawing.Color.Black
        Me.btnRegister.Size = New System.Drawing.Size(216, 44)
        Me.btnRegister.TabIndex = 0
        Me.btnRegister.Text = "Register"
        Me.btnRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSignIn
        '
        Me.btnSignIn.AnimationHoverSpeed = 0.07!
        Me.btnSignIn.AnimationSpeed = 0.03!
        Me.btnSignIn.BaseColor = System.Drawing.Color.White
        Me.btnSignIn.BorderColor = System.Drawing.Color.Black
        Me.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignIn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSignIn.FocusedColor = System.Drawing.Color.Empty
        Me.btnSignIn.Font = New System.Drawing.Font("!Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignIn.ForeColor = System.Drawing.Color.Black
        Me.btnSignIn.Image = Global.Family_daily_management_system.My.Resources.Resources.sign_in
        Me.btnSignIn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnSignIn.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSignIn.Location = New System.Drawing.Point(-1, 35)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSignIn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSignIn.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSignIn.OnHoverImage = Nothing
        Me.btnSignIn.OnPressedColor = System.Drawing.Color.Black
        Me.btnSignIn.Size = New System.Drawing.Size(216, 44)
        Me.btnSignIn.TabIndex = 0
        Me.btnSignIn.Text = "Sign In"
        Me.btnSignIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(431, 403)
        Me.Controls.Add(Me.GunaControlBox1)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnSignIn)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.Controls.Add(Me.panAuthe)
        Me.Font = New System.Drawing.Font("!Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSignIn As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnRegister As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents panAuthe As Guna.UI.WinForms.GunaPanel
End Class
