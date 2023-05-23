<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddExpense
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
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.DataGridViewExpense = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dateTimeExpense = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalExpense = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtExpenseValue = New System.Windows.Forms.TextBox()
        Me.txtExpenseName = New System.Windows.Forms.TextBox()
        Me.btnClearExpenseField = New Guna.UI.WinForms.GunaButton()
        Me.btnDeleteExpense = New Guna.UI.WinForms.GunaButton()
        Me.btnEditExpense = New Guna.UI.WinForms.GunaButton()
        Me.btnAddNewExpense = New Guna.UI.WinForms.GunaButton()
        CType(Me.DataGridViewExpense, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 0
        Me.BunifuElipse1.TargetControl = Me
        '
        'DataGridViewExpense
        '
        Me.DataGridViewExpense.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewExpense.Location = New System.Drawing.Point(12, 230)
        Me.DataGridViewExpense.Name = "DataGridViewExpense"
        Me.DataGridViewExpense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewExpense.Size = New System.Drawing.Size(674, 230)
        Me.DataGridViewExpense.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dateTimeExpense)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtTotalExpense)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtExpenseValue)
        Me.GroupBox1.Controls.Add(Me.txtExpenseName)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(674, 165)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add New Expense"
        '
        'dateTimeExpense
        '
        Me.dateTimeExpense.CustomFormat = "yyyy-MM-dd"
        Me.dateTimeExpense.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateTimeExpense.Location = New System.Drawing.Point(117, 104)
        Me.dateTimeExpense.Name = "dateTimeExpense"
        Me.dateTimeExpense.Size = New System.Drawing.Size(155, 35)
        Me.dateTimeExpense.TabIndex = 3
        Me.dateTimeExpense.Value = New Date(2023, 2, 12, 11, 47, 9, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "កាលបរិច្ឆេទ ៖"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(295, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 27)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "សរុប ៖"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(295, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ចំនួនទឹកប្រាក់ ៖"
        '
        'txtTotalExpense
        '
        Me.txtTotalExpense.Enabled = False
        Me.txtTotalExpense.Location = New System.Drawing.Point(406, 109)
        Me.txtTotalExpense.Name = "txtTotalExpense"
        Me.txtTotalExpense.Size = New System.Drawing.Size(155, 35)
        Me.txtTotalExpense.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ឈ្មោះចំណាយ ៖"
        '
        'txtExpenseValue
        '
        Me.txtExpenseValue.Location = New System.Drawing.Point(406, 55)
        Me.txtExpenseValue.Name = "txtExpenseValue"
        Me.txtExpenseValue.Size = New System.Drawing.Size(155, 35)
        Me.txtExpenseValue.TabIndex = 2
        '
        'txtExpenseName
        '
        Me.txtExpenseName.Location = New System.Drawing.Point(117, 55)
        Me.txtExpenseName.Name = "txtExpenseName"
        Me.txtExpenseName.Size = New System.Drawing.Size(155, 35)
        Me.txtExpenseName.TabIndex = 1
        '
        'btnClearExpenseField
        '
        Me.btnClearExpenseField.AnimationHoverSpeed = 0.07!
        Me.btnClearExpenseField.AnimationSpeed = 0.03!
        Me.btnClearExpenseField.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClearExpenseField.BorderColor = System.Drawing.Color.Black
        Me.btnClearExpenseField.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearExpenseField.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClearExpenseField.FocusedColor = System.Drawing.Color.Empty
        Me.btnClearExpenseField.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClearExpenseField.ForeColor = System.Drawing.Color.White
        Me.btnClearExpenseField.Image = Global.Family_daily_management_system.My.Resources.Resources.clear
        Me.btnClearExpenseField.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnClearExpenseField.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnClearExpenseField.Location = New System.Drawing.Point(285, 11)
        Me.btnClearExpenseField.Name = "btnClearExpenseField"
        Me.btnClearExpenseField.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClearExpenseField.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnClearExpenseField.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClearExpenseField.OnHoverImage = Nothing
        Me.btnClearExpenseField.OnPressedColor = System.Drawing.Color.Black
        Me.btnClearExpenseField.Size = New System.Drawing.Size(85, 42)
        Me.btnClearExpenseField.TabIndex = 11
        Me.btnClearExpenseField.Text = "Clear"
        Me.btnClearExpenseField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDeleteExpense
        '
        Me.btnDeleteExpense.AnimationHoverSpeed = 0.07!
        Me.btnDeleteExpense.AnimationSpeed = 0.03!
        Me.btnDeleteExpense.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDeleteExpense.BorderColor = System.Drawing.Color.Black
        Me.btnDeleteExpense.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteExpense.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDeleteExpense.FocusedColor = System.Drawing.Color.Empty
        Me.btnDeleteExpense.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDeleteExpense.ForeColor = System.Drawing.Color.White
        Me.btnDeleteExpense.Image = Global.Family_daily_management_system.My.Resources.Resources.delete_user
        Me.btnDeleteExpense.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnDeleteExpense.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnDeleteExpense.Location = New System.Drawing.Point(194, 11)
        Me.btnDeleteExpense.Name = "btnDeleteExpense"
        Me.btnDeleteExpense.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDeleteExpense.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDeleteExpense.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDeleteExpense.OnHoverImage = Nothing
        Me.btnDeleteExpense.OnPressedColor = System.Drawing.Color.Black
        Me.btnDeleteExpense.Size = New System.Drawing.Size(85, 42)
        Me.btnDeleteExpense.TabIndex = 12
        Me.btnDeleteExpense.Text = "Delete"
        Me.btnDeleteExpense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEditExpense
        '
        Me.btnEditExpense.AnimationHoverSpeed = 0.07!
        Me.btnEditExpense.AnimationSpeed = 0.03!
        Me.btnEditExpense.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEditExpense.BorderColor = System.Drawing.Color.Black
        Me.btnEditExpense.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditExpense.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEditExpense.FocusedColor = System.Drawing.Color.Empty
        Me.btnEditExpense.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEditExpense.ForeColor = System.Drawing.Color.White
        Me.btnEditExpense.Image = Global.Family_daily_management_system.My.Resources.Resources.user_edit
        Me.btnEditExpense.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnEditExpense.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnEditExpense.Location = New System.Drawing.Point(103, 11)
        Me.btnEditExpense.Name = "btnEditExpense"
        Me.btnEditExpense.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEditExpense.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnEditExpense.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEditExpense.OnHoverImage = Nothing
        Me.btnEditExpense.OnPressedColor = System.Drawing.Color.Black
        Me.btnEditExpense.Size = New System.Drawing.Size(85, 42)
        Me.btnEditExpense.TabIndex = 13
        Me.btnEditExpense.Text = "Edit"
        Me.btnEditExpense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAddNewExpense
        '
        Me.btnAddNewExpense.AnimationHoverSpeed = 0.07!
        Me.btnAddNewExpense.AnimationSpeed = 0.03!
        Me.btnAddNewExpense.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddNewExpense.BorderColor = System.Drawing.Color.Black
        Me.btnAddNewExpense.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNewExpense.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAddNewExpense.FocusedColor = System.Drawing.Color.Empty
        Me.btnAddNewExpense.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAddNewExpense.ForeColor = System.Drawing.Color.White
        Me.btnAddNewExpense.Image = Global.Family_daily_management_system.My.Resources.Resources.user_add
        Me.btnAddNewExpense.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnAddNewExpense.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAddNewExpense.Location = New System.Drawing.Point(12, 11)
        Me.btnAddNewExpense.Name = "btnAddNewExpense"
        Me.btnAddNewExpense.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddNewExpense.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAddNewExpense.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAddNewExpense.OnHoverImage = Nothing
        Me.btnAddNewExpense.OnPressedColor = System.Drawing.Color.Black
        Me.btnAddNewExpense.Size = New System.Drawing.Size(85, 42)
        Me.btnAddNewExpense.TabIndex = 14
        Me.btnAddNewExpense.Text = "Add"
        Me.btnAddNewExpense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmAddExpense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(698, 471)
        Me.Controls.Add(Me.DataGridViewExpense)
        Me.Controls.Add(Me.btnClearExpenseField)
        Me.Controls.Add(Me.btnDeleteExpense)
        Me.Controls.Add(Me.btnEditExpense)
        Me.Controls.Add(Me.btnAddNewExpense)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("!Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "FrmAddExpense"
        Me.Text = "FrmAddExpense"
        CType(Me.DataGridViewExpense, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents DataGridViewExpense As DataGridView
    Friend WithEvents btnClearExpenseField As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnDeleteExpense As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnEditExpense As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAddNewExpense As Guna.UI.WinForms.GunaButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dateTimeExpense As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotalExpense As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtExpenseValue As TextBox
    Friend WithEvents txtExpenseName As TextBox
End Class
