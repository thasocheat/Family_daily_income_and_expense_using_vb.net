<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAdminDashboardBody
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
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.labTotalUser = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.labTotalParent = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.BunifuCards3 = New Bunifu.Framework.UI.BunifuCards()
        Me.labTotalStudentUser = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.BunifuCards4 = New Bunifu.Framework.UI.BunifuCards()
        Me.labTotalAdmin = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GunaCirclePictureBox4 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaCirclePictureBox3 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaCirclePictureBox2 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.BunifuCards1.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        Me.GunaPanel2.SuspendLayout()
        Me.BunifuCards2.SuspendLayout()
        Me.GunaPanel3.SuspendLayout()
        Me.BunifuCards3.SuspendLayout()
        Me.GunaPanel4.SuspendLayout()
        Me.BunifuCards4.SuspendLayout()
        CType(Me.GunaCirclePictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.Tomato
        Me.BunifuCards1.Controls.Add(Me.Label7)
        Me.BunifuCards1.Controls.Add(Me.labTotalUser)
        Me.BunifuCards1.Controls.Add(Me.Label9)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(3, 33)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(194, 114)
        Me.BunifuCards1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 27)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "About Users"
        '
        'labTotalUser
        '
        Me.labTotalUser.AutoSize = True
        Me.labTotalUser.Font = New System.Drawing.Font("!Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTotalUser.Location = New System.Drawing.Point(122, 39)
        Me.labTotalUser.Name = "labTotalUser"
        Me.labTotalUser.Size = New System.Drawing.Size(0, 29)
        Me.labTotalUser.TabIndex = 4
        Me.labTotalUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(87, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 27)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Total User"
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.GunaCirclePictureBox1)
        Me.GunaPanel1.Controls.Add(Me.BunifuCards1)
        Me.GunaPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(200, 150)
        Me.GunaPanel1.TabIndex = 1
        '
        'GunaPanel2
        '
        Me.GunaPanel2.Controls.Add(Me.GunaCirclePictureBox2)
        Me.GunaPanel2.Controls.Add(Me.BunifuCards2)
        Me.GunaPanel2.Location = New System.Drawing.Point(232, 12)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(200, 150)
        Me.GunaPanel2.TabIndex = 3
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.White
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuCards2.Controls.Add(Me.labTotalParent)
        Me.BunifuCards2.Controls.Add(Me.Label4)
        Me.BunifuCards2.Controls.Add(Me.Label6)
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(3, 33)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(194, 114)
        Me.BunifuCards2.TabIndex = 2
        '
        'labTotalParent
        '
        Me.labTotalParent.AutoSize = True
        Me.labTotalParent.Font = New System.Drawing.Font("!Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTotalParent.Location = New System.Drawing.Point(125, 41)
        Me.labTotalParent.Name = "labTotalParent"
        Me.labTotalParent.Size = New System.Drawing.Size(0, 29)
        Me.labTotalParent.TabIndex = 5
        Me.labTotalParent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 27)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "About Parent"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(90, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 27)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Parent"
        '
        'GunaPanel3
        '
        Me.GunaPanel3.Controls.Add(Me.GunaCirclePictureBox3)
        Me.GunaPanel3.Controls.Add(Me.BunifuCards3)
        Me.GunaPanel3.Location = New System.Drawing.Point(452, 12)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(200, 150)
        Me.GunaPanel3.TabIndex = 7
        '
        'BunifuCards3
        '
        Me.BunifuCards3.BackColor = System.Drawing.Color.White
        Me.BunifuCards3.BorderRadius = 5
        Me.BunifuCards3.BottomSahddow = True
        Me.BunifuCards3.color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuCards3.Controls.Add(Me.labTotalStudentUser)
        Me.BunifuCards3.Controls.Add(Me.Label15)
        Me.BunifuCards3.Controls.Add(Me.Label14)
        Me.BunifuCards3.LeftSahddow = False
        Me.BunifuCards3.Location = New System.Drawing.Point(3, 33)
        Me.BunifuCards3.Name = "BunifuCards3"
        Me.BunifuCards3.RightSahddow = True
        Me.BunifuCards3.ShadowDepth = 20
        Me.BunifuCards3.Size = New System.Drawing.Size(194, 114)
        Me.BunifuCards3.TabIndex = 8
        '
        'labTotalStudentUser
        '
        Me.labTotalStudentUser.AutoSize = True
        Me.labTotalStudentUser.Font = New System.Drawing.Font("!Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTotalStudentUser.Location = New System.Drawing.Point(128, 43)
        Me.labTotalStudentUser.Name = "labTotalStudentUser"
        Me.labTotalStudentUser.Size = New System.Drawing.Size(0, 29)
        Me.labTotalStudentUser.TabIndex = 8
        Me.labTotalStudentUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(93, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 27)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Student"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 81)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 27)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "About Student"
        '
        'GunaPanel4
        '
        Me.GunaPanel4.Controls.Add(Me.GunaCirclePictureBox4)
        Me.GunaPanel4.Controls.Add(Me.BunifuCards4)
        Me.GunaPanel4.Location = New System.Drawing.Point(12, 180)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(200, 150)
        Me.GunaPanel4.TabIndex = 10
        '
        'BunifuCards4
        '
        Me.BunifuCards4.BackColor = System.Drawing.Color.White
        Me.BunifuCards4.BorderRadius = 5
        Me.BunifuCards4.BottomSahddow = True
        Me.BunifuCards4.color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuCards4.Controls.Add(Me.labTotalAdmin)
        Me.BunifuCards4.Controls.Add(Me.Label10)
        Me.BunifuCards4.Controls.Add(Me.Label12)
        Me.BunifuCards4.LeftSahddow = False
        Me.BunifuCards4.Location = New System.Drawing.Point(3, 33)
        Me.BunifuCards4.Name = "BunifuCards4"
        Me.BunifuCards4.RightSahddow = True
        Me.BunifuCards4.ShadowDepth = 20
        Me.BunifuCards4.Size = New System.Drawing.Size(194, 114)
        Me.BunifuCards4.TabIndex = 11
        '
        'labTotalAdmin
        '
        Me.labTotalAdmin.AutoSize = True
        Me.labTotalAdmin.Font = New System.Drawing.Font("!Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTotalAdmin.Location = New System.Drawing.Point(128, 43)
        Me.labTotalAdmin.Name = "labTotalAdmin"
        Me.labTotalAdmin.Size = New System.Drawing.Size(0, 29)
        Me.labTotalAdmin.TabIndex = 13
        Me.labTotalAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(93, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 27)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Total Admin"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 27)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "About Admin"
        '
        'GunaCirclePictureBox4
        '
        Me.GunaCirclePictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaCirclePictureBox4.BaseColor = System.Drawing.Color.Black
        Me.GunaCirclePictureBox4.Image = Global.Family_daily_management_system.My.Resources.Resources.admin_user
        Me.GunaCirclePictureBox4.Location = New System.Drawing.Point(14, 5)
        Me.GunaCirclePictureBox4.Name = "GunaCirclePictureBox4"
        Me.GunaCirclePictureBox4.Size = New System.Drawing.Size(64, 64)
        Me.GunaCirclePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox4.TabIndex = 1
        Me.GunaCirclePictureBox4.TabStop = False
        Me.GunaCirclePictureBox4.UseTransfarantBackground = False
        '
        'GunaCirclePictureBox3
        '
        Me.GunaCirclePictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaCirclePictureBox3.BaseColor = System.Drawing.Color.Black
        Me.GunaCirclePictureBox3.Image = Global.Family_daily_management_system.My.Resources.Resources.student
        Me.GunaCirclePictureBox3.Location = New System.Drawing.Point(14, 5)
        Me.GunaCirclePictureBox3.Name = "GunaCirclePictureBox3"
        Me.GunaCirclePictureBox3.Size = New System.Drawing.Size(64, 64)
        Me.GunaCirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox3.TabIndex = 1
        Me.GunaCirclePictureBox3.TabStop = False
        Me.GunaCirclePictureBox3.UseTransfarantBackground = False
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.Black
        Me.GunaCirclePictureBox1.Image = Global.Family_daily_management_system.My.Resources.Resources.userss
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(14, 5)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 1
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'GunaCirclePictureBox2
        '
        Me.GunaCirclePictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaCirclePictureBox2.BaseColor = System.Drawing.Color.Black
        Me.GunaCirclePictureBox2.Image = Global.Family_daily_management_system.My.Resources.Resources.parent
        Me.GunaCirclePictureBox2.Location = New System.Drawing.Point(14, 5)
        Me.GunaCirclePictureBox2.Name = "GunaCirclePictureBox2"
        Me.GunaCirclePictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.GunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox2.TabIndex = 1
        Me.GunaCirclePictureBox2.TabStop = False
        Me.GunaCirclePictureBox2.UseTransfarantBackground = False
        '
        'FrmAdminDashboardBody
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(698, 471)
        Me.Controls.Add(Me.GunaPanel4)
        Me.Controls.Add(Me.GunaPanel3)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Font = New System.Drawing.Font("!Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "FrmAdminDashboardBody"
        Me.Text = "FrmAdminDashboardBody"
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel2.ResumeLayout(False)
        Me.BunifuCards2.ResumeLayout(False)
        Me.BunifuCards2.PerformLayout()
        Me.GunaPanel3.ResumeLayout(False)
        Me.BunifuCards3.ResumeLayout(False)
        Me.BunifuCards3.PerformLayout()
        Me.GunaPanel4.ResumeLayout(False)
        Me.BunifuCards4.ResumeLayout(False)
        Me.BunifuCards4.PerformLayout()
        CType(Me.GunaCirclePictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents labTotalUser As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaCirclePictureBox2 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents labTotalParent As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaCirclePictureBox3 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents BunifuCards3 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents labTotalStudentUser As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaCirclePictureBox4 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents BunifuCards4 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents labTotalAdmin As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
End Class
