<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAdminDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdminDashboard))
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.labUser = New System.Windows.Forms.Label()
        Me.labAdminLogOut = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panAdminDashboardBody = New Guna.UI.WinForms.GunaShadowPanel()
        Me.cleUserInfo = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.BtnAddExpense = New Guna.UI.WinForms.GunaButton()
        Me.BtnAddCategory = New Guna.UI.WinForms.GunaButton()
        Me.BtnAddIncome = New Guna.UI.WinForms.GunaButton()
        Me.BtnViewProfile = New Guna.UI.WinForms.GunaButton()
        Me.btnAdminAddUser = New Guna.UI.WinForms.GunaButton()
        Me.btnAdminDashboard = New Guna.UI.WinForms.GunaButton()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPanel1.SuspendLayout()
        Me.GunaPanel2.SuspendLayout()
        CType(Me.cleUserInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.AutoScroll = True
        Me.GunaPanel1.Controls.Add(Me.BtnAddExpense)
        Me.GunaPanel1.Controls.Add(Me.BtnAddCategory)
        Me.GunaPanel1.Controls.Add(Me.BtnAddIncome)
        Me.GunaPanel1.Controls.Add(Me.BtnViewProfile)
        Me.GunaPanel1.Controls.Add(Me.btnAdminAddUser)
        Me.GunaPanel1.Controls.Add(Me.btnAdminDashboard)
        Me.GunaPanel1.Controls.Add(Me.GunaPictureBox1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(184, 518)
        Me.GunaPanel1.TabIndex = 0
        '
        'GunaPanel2
        '
        Me.GunaPanel2.Controls.Add(Me.labUser)
        Me.GunaPanel2.Controls.Add(Me.labAdminLogOut)
        Me.GunaPanel2.Controls.Add(Me.cleUserInfo)
        Me.GunaPanel2.Controls.Add(Me.Label1)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel2.Location = New System.Drawing.Point(184, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(698, 47)
        Me.GunaPanel2.TabIndex = 1
        '
        'labUser
        '
        Me.labUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labUser.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.labUser.Location = New System.Drawing.Point(479, 9)
        Me.labUser.Name = "labUser"
        Me.labUser.Size = New System.Drawing.Size(105, 29)
        Me.labUser.TabIndex = 1
        Me.labUser.Text = "Name"
        Me.labUser.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'labAdminLogOut
        '
        Me.labAdminLogOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labAdminLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labAdminLogOut.Location = New System.Drawing.Point(627, 9)
        Me.labAdminLogOut.Name = "labAdminLogOut"
        Me.labAdminLogOut.Size = New System.Drawing.Size(68, 29)
        Me.labAdminLogOut.TabIndex = 1
        Me.labAdminLogOut.Text = "Log out"
        Me.labAdminLogOut.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Admin Dashboard"
        '
        'panAdminDashboardBody
        '
        Me.panAdminDashboardBody.AutoScroll = True
        Me.panAdminDashboardBody.BackColor = System.Drawing.Color.Transparent
        Me.panAdminDashboardBody.BaseColor = System.Drawing.Color.White
        Me.panAdminDashboardBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panAdminDashboardBody.Location = New System.Drawing.Point(184, 47)
        Me.panAdminDashboardBody.Name = "panAdminDashboardBody"
        Me.panAdminDashboardBody.ShadowColor = System.Drawing.Color.Black
        Me.panAdminDashboardBody.Size = New System.Drawing.Size(698, 471)
        Me.panAdminDashboardBody.TabIndex = 2
        '
        'cleUserInfo
        '
        Me.cleUserInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cleUserInfo.BaseColor = System.Drawing.Color.White
        Me.cleUserInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cleUserInfo.Image = Global.Family_daily_management_system.My.Resources.Resources.users
        Me.cleUserInfo.Location = New System.Drawing.Point(590, 9)
        Me.cleUserInfo.Name = "cleUserInfo"
        Me.cleUserInfo.Size = New System.Drawing.Size(32, 32)
        Me.cleUserInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cleUserInfo.TabIndex = 1
        Me.cleUserInfo.TabStop = False
        Me.cleUserInfo.UseTransfarantBackground = False
        '
        'BtnAddExpense
        '
        Me.BtnAddExpense.AnimationHoverSpeed = 0.07!
        Me.BtnAddExpense.AnimationSpeed = 0.03!
        Me.BtnAddExpense.BaseColor = System.Drawing.Color.Transparent
        Me.BtnAddExpense.BorderColor = System.Drawing.Color.Transparent
        Me.BtnAddExpense.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddExpense.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnAddExpense.FocusedColor = System.Drawing.Color.Transparent
        Me.BtnAddExpense.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnAddExpense.ForeColor = System.Drawing.Color.Black
        Me.BtnAddExpense.Image = Global.Family_daily_management_system.My.Resources.Resources.expenses
        Me.BtnAddExpense.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnAddExpense.Location = New System.Drawing.Point(10, 318)
        Me.BtnAddExpense.Name = "BtnAddExpense"
        Me.BtnAddExpense.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAddExpense.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.BtnAddExpense.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnAddExpense.OnHoverImage = Nothing
        Me.BtnAddExpense.OnPressedColor = System.Drawing.Color.Transparent
        Me.BtnAddExpense.OnPressedDepth = 0
        Me.BtnAddExpense.Size = New System.Drawing.Size(160, 42)
        Me.BtnAddExpense.TabIndex = 2
        Me.BtnAddExpense.Text = "Add Expense"
        '
        'BtnAddCategory
        '
        Me.BtnAddCategory.AnimationHoverSpeed = 0.07!
        Me.BtnAddCategory.AnimationSpeed = 0.03!
        Me.BtnAddCategory.BaseColor = System.Drawing.Color.Transparent
        Me.BtnAddCategory.BorderColor = System.Drawing.Color.Transparent
        Me.BtnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddCategory.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnAddCategory.FocusedColor = System.Drawing.Color.Transparent
        Me.BtnAddCategory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnAddCategory.ForeColor = System.Drawing.Color.Black
        Me.BtnAddCategory.Image = Global.Family_daily_management_system.My.Resources.Resources.category
        Me.BtnAddCategory.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnAddCategory.Location = New System.Drawing.Point(10, 234)
        Me.BtnAddCategory.Name = "BtnAddCategory"
        Me.BtnAddCategory.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAddCategory.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.BtnAddCategory.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnAddCategory.OnHoverImage = Nothing
        Me.BtnAddCategory.OnPressedColor = System.Drawing.Color.Transparent
        Me.BtnAddCategory.OnPressedDepth = 0
        Me.BtnAddCategory.Size = New System.Drawing.Size(160, 42)
        Me.BtnAddCategory.TabIndex = 2
        Me.BtnAddCategory.Text = "Admin Category"
        '
        'BtnAddIncome
        '
        Me.BtnAddIncome.AnimationHoverSpeed = 0.07!
        Me.BtnAddIncome.AnimationSpeed = 0.03!
        Me.BtnAddIncome.BackColor = System.Drawing.Color.Transparent
        Me.BtnAddIncome.BaseColor = System.Drawing.Color.Transparent
        Me.BtnAddIncome.BorderColor = System.Drawing.Color.Transparent
        Me.BtnAddIncome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddIncome.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnAddIncome.FocusedColor = System.Drawing.Color.Empty
        Me.BtnAddIncome.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnAddIncome.ForeColor = System.Drawing.Color.Black
        Me.BtnAddIncome.Image = Global.Family_daily_management_system.My.Resources.Resources.profit
        Me.BtnAddIncome.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnAddIncome.Location = New System.Drawing.Point(10, 276)
        Me.BtnAddIncome.Name = "BtnAddIncome"
        Me.BtnAddIncome.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAddIncome.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnAddIncome.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnAddIncome.OnHoverImage = Nothing
        Me.BtnAddIncome.OnPressedColor = System.Drawing.Color.Black
        Me.BtnAddIncome.Size = New System.Drawing.Size(160, 42)
        Me.BtnAddIncome.TabIndex = 2
        Me.BtnAddIncome.Text = "Add Income"
        '
        'BtnViewProfile
        '
        Me.BtnViewProfile.AnimationHoverSpeed = 0.07!
        Me.BtnViewProfile.AnimationSpeed = 0.03!
        Me.BtnViewProfile.BaseColor = System.Drawing.Color.Transparent
        Me.BtnViewProfile.BorderColor = System.Drawing.Color.Transparent
        Me.BtnViewProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnViewProfile.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnViewProfile.FocusedColor = System.Drawing.Color.Transparent
        Me.BtnViewProfile.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnViewProfile.ForeColor = System.Drawing.Color.Black
        Me.BtnViewProfile.Image = Global.Family_daily_management_system.My.Resources.Resources.suers
        Me.BtnViewProfile.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnViewProfile.Location = New System.Drawing.Point(10, 151)
        Me.BtnViewProfile.Name = "BtnViewProfile"
        Me.BtnViewProfile.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnViewProfile.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.BtnViewProfile.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnViewProfile.OnHoverImage = Nothing
        Me.BtnViewProfile.OnPressedColor = System.Drawing.Color.Transparent
        Me.BtnViewProfile.OnPressedDepth = 0
        Me.BtnViewProfile.Size = New System.Drawing.Size(160, 42)
        Me.BtnViewProfile.TabIndex = 2
        Me.BtnViewProfile.Text = "View Profile"
        '
        'btnAdminAddUser
        '
        Me.btnAdminAddUser.AnimationHoverSpeed = 0.07!
        Me.btnAdminAddUser.AnimationSpeed = 0.03!
        Me.btnAdminAddUser.BackColor = System.Drawing.Color.Transparent
        Me.btnAdminAddUser.BaseColor = System.Drawing.Color.Transparent
        Me.btnAdminAddUser.BorderColor = System.Drawing.Color.Transparent
        Me.btnAdminAddUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdminAddUser.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAdminAddUser.FocusedColor = System.Drawing.Color.Empty
        Me.btnAdminAddUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAdminAddUser.ForeColor = System.Drawing.Color.Black
        Me.btnAdminAddUser.Image = Global.Family_daily_management_system.My.Resources.Resources.add_user
        Me.btnAdminAddUser.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAdminAddUser.Location = New System.Drawing.Point(10, 192)
        Me.btnAdminAddUser.Name = "btnAdminAddUser"
        Me.btnAdminAddUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdminAddUser.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAdminAddUser.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAdminAddUser.OnHoverImage = Nothing
        Me.btnAdminAddUser.OnPressedColor = System.Drawing.Color.Black
        Me.btnAdminAddUser.Size = New System.Drawing.Size(160, 42)
        Me.btnAdminAddUser.TabIndex = 2
        Me.btnAdminAddUser.Text = "Add User"
        '
        'btnAdminDashboard
        '
        Me.btnAdminDashboard.AnimationHoverSpeed = 0.07!
        Me.btnAdminDashboard.AnimationSpeed = 0.03!
        Me.btnAdminDashboard.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdminDashboard.BorderColor = System.Drawing.Color.Transparent
        Me.btnAdminDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdminDashboard.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAdminDashboard.FocusedColor = System.Drawing.Color.Empty
        Me.btnAdminDashboard.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAdminDashboard.ForeColor = System.Drawing.Color.White
        Me.btnAdminDashboard.Image = Global.Family_daily_management_system.My.Resources.Resources.dashboard
        Me.btnAdminDashboard.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAdminDashboard.Location = New System.Drawing.Point(10, 109)
        Me.btnAdminDashboard.Name = "btnAdminDashboard"
        Me.btnAdminDashboard.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdminDashboard.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAdminDashboard.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAdminDashboard.OnHoverImage = Nothing
        Me.btnAdminDashboard.OnPressedColor = System.Drawing.Color.Black
        Me.btnAdminDashboard.Size = New System.Drawing.Size(160, 42)
        Me.btnAdminDashboard.TabIndex = 2
        Me.btnAdminDashboard.Text = "Dashboard"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.Family_daily_management_system.My.Resources.Resources._7948448681639235816_128
        Me.GunaPictureBox1.Location = New System.Drawing.Point(58, 12)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 1
        Me.GunaPictureBox1.TabStop = False
        '
        'FrmAdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 518)
        Me.Controls.Add(Me.panAdminDashboardBody)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Font = New System.Drawing.Font("!Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "FrmAdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminDashboard"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        CType(Me.cleUserInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents btnAdminDashboard As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnViewProfile As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents panAdminDashboardBody As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents BtnAddExpense As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnAddCategory As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnAddIncome As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAdminAddUser As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cleUserInfo As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents labAdminLogOut As Label
    Friend WithEvents labUser As Label
End Class
