<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmWelcomePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWelcomePage))
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.btnLogIn = New Guna.UI.WinForms.GunaButton()
        Me.GunaPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel1.BackgroundImage = Global.Family_daily_management_system.My.Resources.Resources.vecteezy_couple_plan_family_budget_manage_finance_13717353
        Me.GunaPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 50)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(422, 344)
        Me.GunaPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("!Khmer OS Siemreap", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(496, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 58)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Family Daily"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("!Khmer OS Siemreap", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(455, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(277, 49)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Income And Expense"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Location = New System.Drawing.Point(460, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(266, 54)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Manage your income and expense " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "everyday to make your income strong."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.White
        Me.GunaPanel2.Controls.Add(Me.btnLogIn)
        Me.GunaPanel2.Controls.Add(Me.Label3)
        Me.GunaPanel2.Controls.Add(Me.Label2)
        Me.GunaPanel2.Controls.Add(Me.Label1)
        Me.GunaPanel2.Controls.Add(Me.GunaPanel1)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(770, 439)
        Me.GunaPanel2.TabIndex = 1
        '
        'btnLogIn
        '
        Me.btnLogIn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnLogIn.AnimationHoverSpeed = 0.07!
        Me.btnLogIn.AnimationSpeed = 0.03!
        Me.btnLogIn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogIn.BorderColor = System.Drawing.Color.Black
        Me.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogIn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLogIn.FocusedColor = System.Drawing.Color.Empty
        Me.btnLogIn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLogIn.ForeColor = System.Drawing.Color.White
        Me.btnLogIn.Image = Nothing
        Me.btnLogIn.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnLogIn.Location = New System.Drawing.Point(513, 294)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogIn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnLogIn.OnHoverForeColor = System.Drawing.Color.White
        Me.btnLogIn.OnHoverImage = Nothing
        Me.btnLogIn.OnPressedColor = System.Drawing.Color.Black
        Me.btnLogIn.Size = New System.Drawing.Size(160, 42)
        Me.btnLogIn.TabIndex = 3
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmWelcomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 439)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Font = New System.Drawing.Font("!Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "FrmWelcomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome Page"
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnLogIn As Guna.UI.WinForms.GunaButton
End Class
