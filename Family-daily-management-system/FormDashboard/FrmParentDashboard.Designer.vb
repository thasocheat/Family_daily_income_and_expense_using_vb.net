<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmParentDashboard
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
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.labParentLogOut = New System.Windows.Forms.Label()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.panParentBodyForm = New Guna.UI.WinForms.GunaShadowPanel()
        Me.cleUserInfo = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaButton6 = New Guna.UI.WinForms.GunaButton()
        Me.btnAddExpense = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton5 = New Guna.UI.WinForms.GunaButton()
        Me.btnParentProfile = New Guna.UI.WinForms.GunaButton()
        Me.btnParentAddIncome = New Guna.UI.WinForms.GunaButton()
        Me.btnParentDashboard = New Guna.UI.WinForms.GunaButton()
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
        Me.GunaPanel1.Controls.Add(Me.GunaButton6)
        Me.GunaPanel1.Controls.Add(Me.btnAddExpense)
        Me.GunaPanel1.Controls.Add(Me.GunaButton5)
        Me.GunaPanel1.Controls.Add(Me.btnParentProfile)
        Me.GunaPanel1.Controls.Add(Me.btnParentAddIncome)
        Me.GunaPanel1.Controls.Add(Me.btnParentDashboard)
        Me.GunaPanel1.Controls.Add(Me.GunaPictureBox1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(184, 518)
        Me.GunaPanel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Parent Dashboard"
        '
        'GunaPanel2
        '
        Me.GunaPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel2.Controls.Add(Me.labParentLogOut)
        Me.GunaPanel2.Controls.Add(Me.cleUserInfo)
        Me.GunaPanel2.Controls.Add(Me.Label1)
        Me.GunaPanel2.Location = New System.Drawing.Point(184, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(698, 47)
        Me.GunaPanel2.TabIndex = 4
        '
        'labParentLogOut
        '
        Me.labParentLogOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labParentLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labParentLogOut.Location = New System.Drawing.Point(564, 12)
        Me.labParentLogOut.Name = "labParentLogOut"
        Me.labParentLogOut.Size = New System.Drawing.Size(84, 29)
        Me.labParentLogOut.TabIndex = 2
        Me.labParentLogOut.Text = "Log out"
        Me.labParentLogOut.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.AutoScroll = True
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(882, 518)
        Me.GunaShadowPanel1.TabIndex = 5
        '
        'panParentBodyForm
        '
        Me.panParentBodyForm.AutoScroll = True
        Me.panParentBodyForm.BackColor = System.Drawing.Color.Transparent
        Me.panParentBodyForm.BaseColor = System.Drawing.Color.White
        Me.panParentBodyForm.Location = New System.Drawing.Point(184, 47)
        Me.panParentBodyForm.Name = "panParentBodyForm"
        Me.panParentBodyForm.ShadowColor = System.Drawing.Color.Black
        Me.panParentBodyForm.Size = New System.Drawing.Size(698, 471)
        Me.panParentBodyForm.TabIndex = 3
        '
        'cleUserInfo
        '
        Me.cleUserInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cleUserInfo.BaseColor = System.Drawing.Color.White
        Me.cleUserInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cleUserInfo.Image = Global.Family_daily_management_system.My.Resources.Resources.users
        Me.cleUserInfo.Location = New System.Drawing.Point(654, 9)
        Me.cleUserInfo.Name = "cleUserInfo"
        Me.cleUserInfo.Size = New System.Drawing.Size(32, 32)
        Me.cleUserInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cleUserInfo.TabIndex = 1
        Me.cleUserInfo.TabStop = False
        Me.cleUserInfo.UseTransfarantBackground = False
        '
        'GunaButton6
        '
        Me.GunaButton6.AnimationHoverSpeed = 0.07!
        Me.GunaButton6.AnimationSpeed = 0.03!
        Me.GunaButton6.BaseColor = System.Drawing.Color.Transparent
        Me.GunaButton6.BorderColor = System.Drawing.Color.Transparent
        Me.GunaButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton6.Enabled = False
        Me.GunaButton6.FocusedColor = System.Drawing.Color.Transparent
        Me.GunaButton6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton6.ForeColor = System.Drawing.Color.Black
        Me.GunaButton6.Image = Global.Family_daily_management_system.My.Resources.Resources.admin_profile
        Me.GunaButton6.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton6.Location = New System.Drawing.Point(10, 318)
        Me.GunaButton6.Name = "GunaButton6"
        Me.GunaButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton6.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaButton6.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton6.OnHoverImage = Nothing
        Me.GunaButton6.OnPressedColor = System.Drawing.Color.Transparent
        Me.GunaButton6.OnPressedDepth = 0
        Me.GunaButton6.Size = New System.Drawing.Size(160, 42)
        Me.GunaButton6.TabIndex = 2
        Me.GunaButton6.Text = "Delete User"
        '
        'btnAddExpense
        '
        Me.btnAddExpense.AnimationHoverSpeed = 0.07!
        Me.btnAddExpense.AnimationSpeed = 0.03!
        Me.btnAddExpense.BaseColor = System.Drawing.Color.Transparent
        Me.btnAddExpense.BorderColor = System.Drawing.Color.Transparent
        Me.btnAddExpense.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddExpense.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAddExpense.FocusedColor = System.Drawing.Color.Transparent
        Me.btnAddExpense.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAddExpense.ForeColor = System.Drawing.Color.Black
        Me.btnAddExpense.Image = Global.Family_daily_management_system.My.Resources.Resources.expense_add
        Me.btnAddExpense.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAddExpense.Location = New System.Drawing.Point(10, 234)
        Me.btnAddExpense.Name = "btnAddExpense"
        Me.btnAddExpense.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddExpense.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnAddExpense.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAddExpense.OnHoverImage = Nothing
        Me.btnAddExpense.OnPressedColor = System.Drawing.Color.Transparent
        Me.btnAddExpense.OnPressedDepth = 0
        Me.btnAddExpense.Size = New System.Drawing.Size(160, 42)
        Me.btnAddExpense.TabIndex = 2
        Me.btnAddExpense.Text = "Add Expense"
        '
        'GunaButton5
        '
        Me.GunaButton5.AnimationHoverSpeed = 0.07!
        Me.GunaButton5.AnimationSpeed = 0.03!
        Me.GunaButton5.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton5.BaseColor = System.Drawing.Color.Transparent
        Me.GunaButton5.BorderColor = System.Drawing.Color.Transparent
        Me.GunaButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton5.Enabled = False
        Me.GunaButton5.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton5.ForeColor = System.Drawing.Color.Black
        Me.GunaButton5.Image = Global.Family_daily_management_system.My.Resources.Resources.dashboard
        Me.GunaButton5.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton5.Location = New System.Drawing.Point(10, 276)
        Me.GunaButton5.Name = "GunaButton5"
        Me.GunaButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton5.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton5.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton5.OnHoverImage = Nothing
        Me.GunaButton5.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton5.Size = New System.Drawing.Size(160, 42)
        Me.GunaButton5.TabIndex = 2
        Me.GunaButton5.Text = "View User"
        '
        'btnParentProfile
        '
        Me.btnParentProfile.AnimationHoverSpeed = 0.07!
        Me.btnParentProfile.AnimationSpeed = 0.03!
        Me.btnParentProfile.BaseColor = System.Drawing.Color.Transparent
        Me.btnParentProfile.BorderColor = System.Drawing.Color.Transparent
        Me.btnParentProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnParentProfile.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnParentProfile.FocusedColor = System.Drawing.Color.Transparent
        Me.btnParentProfile.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnParentProfile.ForeColor = System.Drawing.Color.Black
        Me.btnParentProfile.Image = Global.Family_daily_management_system.My.Resources.Resources.admin_profile
        Me.btnParentProfile.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnParentProfile.Location = New System.Drawing.Point(10, 151)
        Me.btnParentProfile.Name = "btnParentProfile"
        Me.btnParentProfile.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnParentProfile.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnParentProfile.OnHoverForeColor = System.Drawing.Color.White
        Me.btnParentProfile.OnHoverImage = Nothing
        Me.btnParentProfile.OnPressedColor = System.Drawing.Color.Transparent
        Me.btnParentProfile.OnPressedDepth = 0
        Me.btnParentProfile.Size = New System.Drawing.Size(160, 42)
        Me.btnParentProfile.TabIndex = 2
        Me.btnParentProfile.Text = "Parent Profile"
        '
        'btnParentAddIncome
        '
        Me.btnParentAddIncome.AnimationHoverSpeed = 0.07!
        Me.btnParentAddIncome.AnimationSpeed = 0.03!
        Me.btnParentAddIncome.BackColor = System.Drawing.Color.Transparent
        Me.btnParentAddIncome.BaseColor = System.Drawing.Color.Transparent
        Me.btnParentAddIncome.BorderColor = System.Drawing.Color.Transparent
        Me.btnParentAddIncome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnParentAddIncome.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnParentAddIncome.FocusedColor = System.Drawing.Color.Empty
        Me.btnParentAddIncome.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnParentAddIncome.ForeColor = System.Drawing.Color.Black
        Me.btnParentAddIncome.Image = Global.Family_daily_management_system.My.Resources.Resources.income
        Me.btnParentAddIncome.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnParentAddIncome.Location = New System.Drawing.Point(10, 192)
        Me.btnParentAddIncome.Name = "btnParentAddIncome"
        Me.btnParentAddIncome.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnParentAddIncome.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnParentAddIncome.OnHoverForeColor = System.Drawing.Color.White
        Me.btnParentAddIncome.OnHoverImage = Nothing
        Me.btnParentAddIncome.OnPressedColor = System.Drawing.Color.Black
        Me.btnParentAddIncome.Size = New System.Drawing.Size(160, 42)
        Me.btnParentAddIncome.TabIndex = 2
        Me.btnParentAddIncome.Text = "Add Income"
        '
        'btnParentDashboard
        '
        Me.btnParentDashboard.AnimationHoverSpeed = 0.07!
        Me.btnParentDashboard.AnimationSpeed = 0.03!
        Me.btnParentDashboard.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnParentDashboard.BorderColor = System.Drawing.Color.Transparent
        Me.btnParentDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnParentDashboard.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnParentDashboard.FocusedColor = System.Drawing.Color.Empty
        Me.btnParentDashboard.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnParentDashboard.ForeColor = System.Drawing.Color.White
        Me.btnParentDashboard.Image = Global.Family_daily_management_system.My.Resources.Resources.dashboard
        Me.btnParentDashboard.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnParentDashboard.Location = New System.Drawing.Point(10, 109)
        Me.btnParentDashboard.Name = "btnParentDashboard"
        Me.btnParentDashboard.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnParentDashboard.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnParentDashboard.OnHoverForeColor = System.Drawing.Color.White
        Me.btnParentDashboard.OnHoverImage = Nothing
        Me.btnParentDashboard.OnPressedColor = System.Drawing.Color.Black
        Me.btnParentDashboard.Size = New System.Drawing.Size(160, 42)
        Me.btnParentDashboard.TabIndex = 2
        Me.btnParentDashboard.Text = "Dashboard"
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
        'FrmParentDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 518)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Controls.Add(Me.panParentBodyForm)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.Font = New System.Drawing.Font("!Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "FrmParentDashboard"
        Me.Text = "FrmParentDashboard"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        CType(Me.cleUserInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaButton6 As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAddExpense As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton5 As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnParentProfile As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnParentAddIncome As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnParentDashboard As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents cleUserInfo As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents panParentBodyForm As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents labParentLogOut As Label
End Class
