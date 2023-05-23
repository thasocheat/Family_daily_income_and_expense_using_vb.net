<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAddIncome
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComIncome = New System.Windows.Forms.ComboBox()
        Me.RichDescription = New System.Windows.Forms.RichTextBox()
        Me.dateTimeIncome = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabInID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIncomeValue = New System.Windows.Forms.TextBox()
        Me.btnClearIncomeField = New Guna.UI.WinForms.GunaButton()
        Me.btnDeleteIncome = New Guna.UI.WinForms.GunaButton()
        Me.btnEditIncome = New Guna.UI.WinForms.GunaButton()
        Me.btnAddNewIncom = New Guna.UI.WinForms.GunaButton()
        Me.LabUID = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.DataGridViewIncome.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridViewIncome.Location = New System.Drawing.Point(12, 229)
        Me.DataGridViewIncome.Name = "DataGridViewIncome"
        Me.DataGridViewIncome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewIncome.Size = New System.Drawing.Size(674, 230)
        Me.DataGridViewIncome.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComIncome)
        Me.GroupBox1.Controls.Add(Me.RichDescription)
        Me.GroupBox1.Controls.Add(Me.dateTimeIncome)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.LabUID)
        Me.GroupBox1.Controls.Add(Me.LabInID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtIncomeValue)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(674, 165)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add New Income"
        '
        'ComIncome
        '
        Me.ComIncome.FormattingEnabled = True
        Me.ComIncome.Location = New System.Drawing.Point(131, 48)
        Me.ComIncome.Name = "ComIncome"
        Me.ComIncome.Size = New System.Drawing.Size(158, 35)
        Me.ComIncome.TabIndex = 5
        '
        'RichDescription
        '
        Me.RichDescription.Location = New System.Drawing.Point(131, 97)
        Me.RichDescription.Name = "RichDescription"
        Me.RichDescription.Size = New System.Drawing.Size(241, 52)
        Me.RichDescription.TabIndex = 4
        Me.RichDescription.Text = ""
        '
        'dateTimeIncome
        '
        Me.dateTimeIncome.CustomFormat = "yyyy-MM-dd"
        Me.dateTimeIncome.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateTimeIncome.Location = New System.Drawing.Point(497, 114)
        Me.dateTimeIncome.Name = "dateTimeIncome"
        Me.dateTimeIncome.Size = New System.Drawing.Size(155, 35)
        Me.dateTimeIncome.TabIndex = 3
        Me.dateTimeIncome.Value = New Date(2023, 2, 12, 11, 47, 9, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(386, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "កាលបរិច្ឆេទ ៖"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(386, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ចំនួនទឹកប្រាក់ ៖"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 27)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ពិព័នានាចំណូល ៖"
        '
        'LabInID
        '
        Me.LabInID.AutoSize = True
        Me.LabInID.Location = New System.Drawing.Point(126, 18)
        Me.LabInID.Name = "LabInID"
        Me.LabInID.Size = New System.Drawing.Size(0, 27)
        Me.LabInID.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ប្រភេទចំណូល ៖"
        '
        'txtIncomeValue
        '
        Me.txtIncomeValue.Location = New System.Drawing.Point(497, 48)
        Me.txtIncomeValue.Name = "txtIncomeValue"
        Me.txtIncomeValue.Size = New System.Drawing.Size(155, 35)
        Me.txtIncomeValue.TabIndex = 2
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
        Me.btnClearIncomeField.Location = New System.Drawing.Point(285, 10)
        Me.btnClearIncomeField.Name = "btnClearIncomeField"
        Me.btnClearIncomeField.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClearIncomeField.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnClearIncomeField.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClearIncomeField.OnHoverImage = Nothing
        Me.btnClearIncomeField.OnPressedColor = System.Drawing.Color.Black
        Me.btnClearIncomeField.Size = New System.Drawing.Size(85, 42)
        Me.btnClearIncomeField.TabIndex = 5
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
        Me.btnDeleteIncome.Location = New System.Drawing.Point(194, 10)
        Me.btnDeleteIncome.Name = "btnDeleteIncome"
        Me.btnDeleteIncome.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDeleteIncome.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDeleteIncome.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDeleteIncome.OnHoverImage = Nothing
        Me.btnDeleteIncome.OnPressedColor = System.Drawing.Color.Black
        Me.btnDeleteIncome.Size = New System.Drawing.Size(85, 42)
        Me.btnDeleteIncome.TabIndex = 6
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
        Me.btnEditIncome.Location = New System.Drawing.Point(103, 10)
        Me.btnEditIncome.Name = "btnEditIncome"
        Me.btnEditIncome.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEditIncome.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnEditIncome.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEditIncome.OnHoverImage = Nothing
        Me.btnEditIncome.OnPressedColor = System.Drawing.Color.Black
        Me.btnEditIncome.Size = New System.Drawing.Size(85, 42)
        Me.btnEditIncome.TabIndex = 7
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
        Me.btnAddNewIncom.Location = New System.Drawing.Point(12, 10)
        Me.btnAddNewIncom.Name = "btnAddNewIncom"
        Me.btnAddNewIncom.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddNewIncom.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAddNewIncom.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAddNewIncom.OnHoverImage = Nothing
        Me.btnAddNewIncom.OnPressedColor = System.Drawing.Color.Black
        Me.btnAddNewIncom.Size = New System.Drawing.Size(85, 42)
        Me.btnAddNewIncom.TabIndex = 8
        Me.btnAddNewIncom.Text = "Add"
        Me.btnAddNewIncom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabUID
        '
        Me.LabUID.AutoSize = True
        Me.LabUID.Location = New System.Drawing.Point(176, 18)
        Me.LabUID.Name = "LabUID"
        Me.LabUID.Size = New System.Drawing.Size(0, 27)
        Me.LabUID.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "លេខចំណូល"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "លេខអ្នកប្រើប្រាស់"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "លេខតាមប្រភេទ"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "កំណត់ចំណាំ"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "តម្លៃ"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "ថ្ងៃនៃចំណូល"
        Me.Column6.Name = "Column6"
        '
        'FrmAddIncome
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
        Me.Name = "FrmAddIncome"
        Me.Text = "FrmAddIncome"
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIncomeValue As TextBox
    Friend WithEvents dateTimeIncome As DateTimePicker
    Friend WithEvents RichDescription As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComIncome As ComboBox
    Friend WithEvents LabInID As Label
    Friend WithEvents LabUID As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
