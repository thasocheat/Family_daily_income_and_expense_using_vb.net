<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAddCategory
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
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.DataGridViewIncome = New System.Windows.Forms.DataGridView()
        Me.btnClearIncomeField = New Guna.UI.WinForms.GunaButton()
        Me.btnDeleteIncome = New Guna.UI.WinForms.GunaButton()
        Me.btnEditIncome = New Guna.UI.WinForms.GunaButton()
        Me.btnAddNewIncom = New Guna.UI.WinForms.GunaButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RichCatNote = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.TxtCategoryType = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridViewIncome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 0
        Me.BunifuElipse1.TargetControl = Me
        '
        'DataGridViewIncome
        '
        Me.DataGridViewIncome.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewIncome.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridViewIncome.Location = New System.Drawing.Point(12, 230)
        Me.DataGridViewIncome.Name = "DataGridViewIncome"
        Me.DataGridViewIncome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewIncome.Size = New System.Drawing.Size(674, 230)
        Me.DataGridViewIncome.TabIndex = 15
        '
        'btnClearIncomeField
        '
        Me.btnClearIncomeField.AnimationHoverSpeed = 0.07!
        Me.btnClearIncomeField.AnimationSpeed = 0.03!
        Me.btnClearIncomeField.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClearIncomeField.BorderColor = System.Drawing.Color.Black
        Me.btnClearIncomeField.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearIncomeField.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClearIncomeField.FocusedColor = System.Drawing.Color.Empty
        Me.btnClearIncomeField.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClearIncomeField.ForeColor = System.Drawing.Color.White
        Me.btnClearIncomeField.Image = Global.Family_daily_management_system.My.Resources.Resources.clear
        Me.btnClearIncomeField.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnClearIncomeField.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnClearIncomeField.Location = New System.Drawing.Point(285, 11)
        Me.btnClearIncomeField.Name = "btnClearIncomeField"
        Me.btnClearIncomeField.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClearIncomeField.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnClearIncomeField.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClearIncomeField.OnHoverImage = Nothing
        Me.btnClearIncomeField.OnPressedColor = System.Drawing.Color.Black
        Me.btnClearIncomeField.Size = New System.Drawing.Size(85, 42)
        Me.btnClearIncomeField.TabIndex = 11
        Me.btnClearIncomeField.Text = "Clear"
        Me.btnClearIncomeField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDeleteIncome
        '
        Me.btnDeleteIncome.AnimationHoverSpeed = 0.07!
        Me.btnDeleteIncome.AnimationSpeed = 0.03!
        Me.btnDeleteIncome.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDeleteIncome.BorderColor = System.Drawing.Color.Black
        Me.btnDeleteIncome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteIncome.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDeleteIncome.FocusedColor = System.Drawing.Color.Empty
        Me.btnDeleteIncome.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDeleteIncome.ForeColor = System.Drawing.Color.White
        Me.btnDeleteIncome.Image = Global.Family_daily_management_system.My.Resources.Resources.delete_user
        Me.btnDeleteIncome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnDeleteIncome.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnDeleteIncome.Location = New System.Drawing.Point(194, 11)
        Me.btnDeleteIncome.Name = "btnDeleteIncome"
        Me.btnDeleteIncome.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDeleteIncome.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDeleteIncome.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDeleteIncome.OnHoverImage = Nothing
        Me.btnDeleteIncome.OnPressedColor = System.Drawing.Color.Black
        Me.btnDeleteIncome.Size = New System.Drawing.Size(85, 42)
        Me.btnDeleteIncome.TabIndex = 12
        Me.btnDeleteIncome.Text = "Delete"
        Me.btnDeleteIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEditIncome
        '
        Me.btnEditIncome.AnimationHoverSpeed = 0.07!
        Me.btnEditIncome.AnimationSpeed = 0.03!
        Me.btnEditIncome.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEditIncome.BorderColor = System.Drawing.Color.Black
        Me.btnEditIncome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditIncome.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEditIncome.FocusedColor = System.Drawing.Color.Empty
        Me.btnEditIncome.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEditIncome.ForeColor = System.Drawing.Color.White
        Me.btnEditIncome.Image = Global.Family_daily_management_system.My.Resources.Resources.user_edit
        Me.btnEditIncome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnEditIncome.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnEditIncome.Location = New System.Drawing.Point(103, 11)
        Me.btnEditIncome.Name = "btnEditIncome"
        Me.btnEditIncome.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEditIncome.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnEditIncome.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEditIncome.OnHoverImage = Nothing
        Me.btnEditIncome.OnPressedColor = System.Drawing.Color.Black
        Me.btnEditIncome.Size = New System.Drawing.Size(85, 42)
        Me.btnEditIncome.TabIndex = 13
        Me.btnEditIncome.Text = "Edit"
        Me.btnEditIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAddNewIncom
        '
        Me.btnAddNewIncom.AnimationHoverSpeed = 0.07!
        Me.btnAddNewIncom.AnimationSpeed = 0.03!
        Me.btnAddNewIncom.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddNewIncom.BorderColor = System.Drawing.Color.Black
        Me.btnAddNewIncom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNewIncom.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAddNewIncom.FocusedColor = System.Drawing.Color.Empty
        Me.btnAddNewIncom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAddNewIncom.ForeColor = System.Drawing.Color.White
        Me.btnAddNewIncom.Image = Global.Family_daily_management_system.My.Resources.Resources.user_add
        Me.btnAddNewIncom.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnAddNewIncom.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAddNewIncom.Location = New System.Drawing.Point(12, 11)
        Me.btnAddNewIncom.Name = "btnAddNewIncom"
        Me.btnAddNewIncom.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddNewIncom.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAddNewIncom.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAddNewIncom.OnHoverImage = Nothing
        Me.btnAddNewIncom.OnPressedColor = System.Drawing.Color.Black
        Me.btnAddNewIncom.Size = New System.Drawing.Size(85, 42)
        Me.btnAddNewIncom.TabIndex = 14
        Me.btnAddNewIncom.Text = "Add"
        Me.btnAddNewIncom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RichCatNote)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtCategoryType)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(674, 165)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add New Category"
        '
        'RichCatNote
        '
        Me.RichCatNote.Location = New System.Drawing.Point(131, 97)
        Me.RichCatNote.Name = "RichCatNote"
        Me.RichCatNote.Size = New System.Drawing.Size(241, 52)
        Me.RichCatNote.TabIndex = 4
        Me.RichCatNote.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "លេខកូដ ៖"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 27)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ពិព័នានា ៖"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(131, 56)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(155, 35)
        Me.txtCode.TabIndex = 2
        '
        'TxtCategoryType
        '
        Me.TxtCategoryType.Location = New System.Drawing.Point(418, 56)
        Me.TxtCategoryType.Name = "TxtCategoryType"
        Me.TxtCategoryType.Size = New System.Drawing.Size(155, 35)
        Me.TxtCategoryType.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(307, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ប្រភេទគណនី ៖"
        '
        'Column1
        '
        Me.Column1.HeaderText = "លេខរៀង"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "លេខកូដ"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "ឈ្មោះគណនី"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "កំណត់ចំណាំ"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 200
        '
        'FrmAddCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(698, 471)
        Me.Controls.Add(Me.DataGridViewIncome)
        Me.Controls.Add(Me.btnClearIncomeField)
        Me.Controls.Add(Me.btnDeleteIncome)
        Me.Controls.Add(Me.btnEditIncome)
        Me.Controls.Add(Me.btnAddNewIncom)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("!Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "FrmAddCategory"
        Me.Text = "FrmAddCategory"
        CType(Me.DataGridViewIncome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents DataGridViewIncome As DataGridView
    Friend WithEvents btnClearIncomeField As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnDeleteIncome As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnEditIncome As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAddNewIncom As Guna.UI.WinForms.GunaButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RichCatNote As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCategoryType As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
