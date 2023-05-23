<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAddNewUser
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ShowCirclePicture = New System.Windows.Forms.PictureBox()
        Me.Browse_to_select_img = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtLastName = New System.Windows.Forms.TextBox()
        Me.TxtFirstName = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnAdminClearField = New Guna.UI.WinForms.GunaButton()
        Me.BtnAdminDeleteUser = New Guna.UI.WinForms.GunaButton()
        Me.BtnAdminEditUser = New Guna.UI.WinForms.GunaButton()
        Me.BtnAdminAddNewUser = New Guna.UI.WinForms.GunaButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ButtonRefresh = New Guna.UI.WinForms.GunaButton()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBoxByName = New System.Windows.Forms.CheckBox()
        Me.CheckBoxByID = New System.Windows.Forms.CheckBox()
        Me.TxtPob = New System.Windows.Forms.TextBox()
        Me.TxtGender = New System.Windows.Forms.TextBox()
        Me.TxtCurrAdd = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtDob = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComAddPermission = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtAddPassword = New System.Windows.Forms.TextBox()
        Me.TxtAddUser = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.LabParentID = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ShowCirclePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Browse_to_select_img, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 0
        Me.GunaElipse1.TargetControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtPhone)
        Me.GroupBox1.Controls.Add(Me.ComAddPermission)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtAddPassword)
        Me.GroupBox1.Controls.Add(Me.TxtAddUser)
        Me.GroupBox1.Controls.Add(Me.ShowCirclePicture)
        Me.GroupBox1.Controls.Add(Me.Browse_to_select_img)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LabParentID)
        Me.GroupBox1.Controls.Add(Me.LabID)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtCurrAdd)
        Me.GroupBox1.Controls.Add(Me.TxtLastName)
        Me.GroupBox1.Controls.Add(Me.TxtDob)
        Me.GroupBox1.Controls.Add(Me.TxtGender)
        Me.GroupBox1.Controls.Add(Me.TxtPob)
        Me.GroupBox1.Controls.Add(Me.TxtFirstName)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(674, 250)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add New User"
        '
        'ShowCirclePicture
        '
        Me.ShowCirclePicture.BackColor = System.Drawing.Color.Gainsboro
        Me.ShowCirclePicture.Location = New System.Drawing.Point(568, 20)
        Me.ShowCirclePicture.Name = "ShowCirclePicture"
        Me.ShowCirclePicture.Size = New System.Drawing.Size(100, 97)
        Me.ShowCirclePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ShowCirclePicture.TabIndex = 5
        Me.ShowCirclePicture.TabStop = False
        '
        'Browse_to_select_img
        '
        Me.Browse_to_select_img.BaseColor = System.Drawing.Color.White
        Me.Browse_to_select_img.Image = Global.Family_daily_management_system.My.Resources.Resources.plus
        Me.Browse_to_select_img.Location = New System.Drawing.Point(542, 20)
        Me.Browse_to_select_img.Name = "Browse_to_select_img"
        Me.Browse_to_select_img.Size = New System.Drawing.Size(20, 20)
        Me.Browse_to_select_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Browse_to_select_img.TabIndex = 4
        Me.Browse_to_select_img.TabStop = False
        Me.Browse_to_select_img.UseTransfarantBackground = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 27)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Last Name :"
        '
        'LabID
        '
        Me.LabID.AutoSize = True
        Me.LabID.Location = New System.Drawing.Point(650, 131)
        Me.LabID.Name = "LabID"
        Me.LabID.Size = New System.Drawing.Size(0, 27)
        Me.LabID.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 27)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "First Name :"
        '
        'TxtLastName
        '
        Me.TxtLastName.Location = New System.Drawing.Point(106, 69)
        Me.TxtLastName.Name = "TxtLastName"
        Me.TxtLastName.Size = New System.Drawing.Size(125, 35)
        Me.TxtLastName.TabIndex = 2
        '
        'TxtFirstName
        '
        Me.TxtFirstName.Location = New System.Drawing.Point(106, 28)
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.Size = New System.Drawing.Size(125, 35)
        Me.TxtFirstName.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column8, Me.Column1, Me.Column2, Me.Column3, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 347)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(674, 112)
        Me.DataGridView1.TabIndex = 3
        '
        'Column7
        '
        Me.Column7.HeaderText = "លេខ"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'Column8
        '
        Me.Column8.HeaderText = "អណាព្យាបាល"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "នាមខ្លួន"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "ត្រកូល"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "ឈ្មោះអ្នកប្រើប្រាស់"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column9
        '
        Me.Column9.HeaderText = "ភេទ"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "ថ្ងៃខែឆ្នាំកំណើត"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "ទីកន្លែងកំណើត"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "អាស័យដ្ឋានបច្ចុប្បន្ន"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column13
        '
        Me.Column13.HeaderText = "លេខទូរស័ព្ទ"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "លេខសំងាត់"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "សិទ្វិប្រើប្រាស់"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "រូបភាព"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'BtnAdminClearField
        '
        Me.BtnAdminClearField.AnimationHoverSpeed = 0.07!
        Me.BtnAdminClearField.AnimationSpeed = 0.03!
        Me.BtnAdminClearField.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAdminClearField.BorderColor = System.Drawing.Color.Black
        Me.BtnAdminClearField.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdminClearField.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnAdminClearField.FocusedColor = System.Drawing.Color.Empty
        Me.BtnAdminClearField.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnAdminClearField.ForeColor = System.Drawing.Color.White
        Me.BtnAdminClearField.Image = Global.Family_daily_management_system.My.Resources.Resources.clear
        Me.BtnAdminClearField.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BtnAdminClearField.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnAdminClearField.Location = New System.Drawing.Point(285, 8)
        Me.BtnAdminClearField.Name = "BtnAdminClearField"
        Me.BtnAdminClearField.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAdminClearField.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnAdminClearField.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnAdminClearField.OnHoverImage = Nothing
        Me.BtnAdminClearField.OnPressedColor = System.Drawing.Color.Black
        Me.BtnAdminClearField.Size = New System.Drawing.Size(85, 42)
        Me.BtnAdminClearField.TabIndex = 1
        Me.BtnAdminClearField.Text = "Clear"
        Me.BtnAdminClearField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnAdminDeleteUser
        '
        Me.BtnAdminDeleteUser.AnimationHoverSpeed = 0.07!
        Me.BtnAdminDeleteUser.AnimationSpeed = 0.03!
        Me.BtnAdminDeleteUser.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAdminDeleteUser.BorderColor = System.Drawing.Color.Black
        Me.BtnAdminDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdminDeleteUser.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnAdminDeleteUser.FocusedColor = System.Drawing.Color.Empty
        Me.BtnAdminDeleteUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnAdminDeleteUser.ForeColor = System.Drawing.Color.White
        Me.BtnAdminDeleteUser.Image = Global.Family_daily_management_system.My.Resources.Resources.delete_user
        Me.BtnAdminDeleteUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BtnAdminDeleteUser.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnAdminDeleteUser.Location = New System.Drawing.Point(194, 8)
        Me.BtnAdminDeleteUser.Name = "BtnAdminDeleteUser"
        Me.BtnAdminDeleteUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAdminDeleteUser.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnAdminDeleteUser.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnAdminDeleteUser.OnHoverImage = Nothing
        Me.BtnAdminDeleteUser.OnPressedColor = System.Drawing.Color.Black
        Me.BtnAdminDeleteUser.Size = New System.Drawing.Size(85, 42)
        Me.BtnAdminDeleteUser.TabIndex = 1
        Me.BtnAdminDeleteUser.Text = "Delete"
        Me.BtnAdminDeleteUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnAdminEditUser
        '
        Me.BtnAdminEditUser.AnimationHoverSpeed = 0.07!
        Me.BtnAdminEditUser.AnimationSpeed = 0.03!
        Me.BtnAdminEditUser.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAdminEditUser.BorderColor = System.Drawing.Color.Black
        Me.BtnAdminEditUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdminEditUser.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnAdminEditUser.FocusedColor = System.Drawing.Color.Empty
        Me.BtnAdminEditUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnAdminEditUser.ForeColor = System.Drawing.Color.White
        Me.BtnAdminEditUser.Image = Global.Family_daily_management_system.My.Resources.Resources.user_edit
        Me.BtnAdminEditUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BtnAdminEditUser.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnAdminEditUser.Location = New System.Drawing.Point(103, 8)
        Me.BtnAdminEditUser.Name = "BtnAdminEditUser"
        Me.BtnAdminEditUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAdminEditUser.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnAdminEditUser.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnAdminEditUser.OnHoverImage = Nothing
        Me.BtnAdminEditUser.OnPressedColor = System.Drawing.Color.Black
        Me.BtnAdminEditUser.Size = New System.Drawing.Size(85, 42)
        Me.BtnAdminEditUser.TabIndex = 1
        Me.BtnAdminEditUser.Text = "Edit"
        Me.BtnAdminEditUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnAdminAddNewUser
        '
        Me.BtnAdminAddNewUser.AnimationHoverSpeed = 0.07!
        Me.BtnAdminAddNewUser.AnimationSpeed = 0.03!
        Me.BtnAdminAddNewUser.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAdminAddNewUser.BorderColor = System.Drawing.Color.Black
        Me.BtnAdminAddNewUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdminAddNewUser.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnAdminAddNewUser.FocusedColor = System.Drawing.Color.Empty
        Me.BtnAdminAddNewUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnAdminAddNewUser.ForeColor = System.Drawing.Color.White
        Me.BtnAdminAddNewUser.Image = Global.Family_daily_management_system.My.Resources.Resources.user_add
        Me.BtnAdminAddNewUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BtnAdminAddNewUser.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnAdminAddNewUser.Location = New System.Drawing.Point(12, 8)
        Me.BtnAdminAddNewUser.Name = "BtnAdminAddNewUser"
        Me.BtnAdminAddNewUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAdminAddNewUser.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnAdminAddNewUser.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnAdminAddNewUser.OnHoverImage = Nothing
        Me.BtnAdminAddNewUser.OnPressedColor = System.Drawing.Color.Black
        Me.BtnAdminAddNewUser.Size = New System.Drawing.Size(85, 42)
        Me.BtnAdminAddNewUser.TabIndex = 1
        Me.BtnAdminAddNewUser.Text = "Add"
        Me.BtnAdminAddNewUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.AnimationHoverSpeed = 0.07!
        Me.ButtonRefresh.AnimationSpeed = 0.03!
        Me.ButtonRefresh.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonRefresh.BorderColor = System.Drawing.Color.Black
        Me.ButtonRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRefresh.DialogResult = System.Windows.Forms.DialogResult.None
        Me.ButtonRefresh.FocusedColor = System.Drawing.Color.Empty
        Me.ButtonRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonRefresh.ForeColor = System.Drawing.Color.White
        Me.ButtonRefresh.Image = Global.Family_daily_management_system.My.Resources.Resources.clear
        Me.ButtonRefresh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ButtonRefresh.ImageSize = New System.Drawing.Size(20, 20)
        Me.ButtonRefresh.Location = New System.Drawing.Point(376, 8)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonRefresh.OnHoverBorderColor = System.Drawing.Color.Black
        Me.ButtonRefresh.OnHoverForeColor = System.Drawing.Color.White
        Me.ButtonRefresh.OnHoverImage = Nothing
        Me.ButtonRefresh.OnPressedColor = System.Drawing.Color.Black
        Me.ButtonRefresh.Size = New System.Drawing.Size(85, 42)
        Me.ButtonRefresh.TabIndex = 1
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(85, 309)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(158, 35)
        Me.TextBoxSearch.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 27)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "ស្វែងរក ៖"
        '
        'CheckBoxByName
        '
        Me.CheckBoxByName.AutoSize = True
        Me.CheckBoxByName.Location = New System.Drawing.Point(256, 310)
        Me.CheckBoxByName.Name = "CheckBoxByName"
        Me.CheckBoxByName.Size = New System.Drawing.Size(91, 31)
        Me.CheckBoxByName.TabIndex = 4
        Me.CheckBoxByName.Text = "By Name"
        Me.CheckBoxByName.UseVisualStyleBackColor = True
        '
        'CheckBoxByID
        '
        Me.CheckBoxByID.AutoSize = True
        Me.CheckBoxByID.Location = New System.Drawing.Point(353, 310)
        Me.CheckBoxByID.Name = "CheckBoxByID"
        Me.CheckBoxByID.Size = New System.Drawing.Size(65, 31)
        Me.CheckBoxByID.TabIndex = 4
        Me.CheckBoxByID.Text = "By Id"
        Me.CheckBoxByID.UseVisualStyleBackColor = True
        '
        'TxtPob
        '
        Me.TxtPob.Location = New System.Drawing.Point(373, 28)
        Me.TxtPob.Name = "TxtPob"
        Me.TxtPob.Size = New System.Drawing.Size(155, 35)
        Me.TxtPob.TabIndex = 1
        '
        'TxtGender
        '
        Me.TxtGender.Location = New System.Drawing.Point(106, 151)
        Me.TxtGender.Name = "TxtGender"
        Me.TxtGender.Size = New System.Drawing.Size(155, 35)
        Me.TxtGender.TabIndex = 10
        '
        'TxtCurrAdd
        '
        Me.TxtCurrAdd.Location = New System.Drawing.Point(373, 69)
        Me.TxtCurrAdd.Name = "TxtCurrAdd"
        Me.TxtCurrAdd.Size = New System.Drawing.Size(155, 35)
        Me.TxtCurrAdd.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(275, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 27)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "POB :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 27)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Gender :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(239, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 27)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Current Address :"
        '
        'TxtDob
        '
        Me.TxtDob.Location = New System.Drawing.Point(106, 192)
        Me.TxtDob.Name = "TxtDob"
        Me.TxtDob.Size = New System.Drawing.Size(155, 35)
        Me.TxtDob.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 195)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 27)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "DOB :"
        '
        'ComAddPermission
        '
        Me.ComAddPermission.FormattingEnabled = True
        Me.ComAddPermission.Items.AddRange(New Object() {"--Select--", "admin", "parent", "user"})
        Me.ComAddPermission.Location = New System.Drawing.Point(373, 192)
        Me.ComAddPermission.Name = "ComAddPermission"
        Me.ComAddPermission.Size = New System.Drawing.Size(155, 35)
        Me.ComAddPermission.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(278, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 27)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Permission :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(273, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 27)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Password   :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 27)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "User Name :"
        '
        'TxtAddPassword
        '
        Me.TxtAddPassword.Location = New System.Drawing.Point(373, 151)
        Me.TxtAddPassword.Name = "TxtAddPassword"
        Me.TxtAddPassword.Size = New System.Drawing.Size(155, 35)
        Me.TxtAddPassword.TabIndex = 16
        '
        'TxtAddUser
        '
        Me.TxtAddUser.Location = New System.Drawing.Point(106, 110)
        Me.TxtAddUser.Name = "TxtAddUser"
        Me.TxtAddUser.Size = New System.Drawing.Size(155, 35)
        Me.TxtAddUser.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(273, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 27)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Phone :"
        '
        'TxtPhone
        '
        Me.TxtPhone.Location = New System.Drawing.Point(373, 110)
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(155, 35)
        Me.TxtPhone.TabIndex = 18
        '
        'LabParentID
        '
        Me.LabParentID.AutoSize = True
        Me.LabParentID.Location = New System.Drawing.Point(620, 131)
        Me.LabParentID.Name = "LabParentID"
        Me.LabParentID.Size = New System.Drawing.Size(0, 27)
        Me.LabParentID.TabIndex = 2
        '
        'FrmAddNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(698, 471)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.BtnAdminClearField)
        Me.Controls.Add(Me.BtnAdminDeleteUser)
        Me.Controls.Add(Me.BtnAdminEditUser)
        Me.Controls.Add(Me.BtnAdminAddNewUser)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CheckBoxByID)
        Me.Controls.Add(Me.CheckBoxByName)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Font = New System.Drawing.Font("!Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "FrmAddNewUser"
        Me.Text = "FrmAddNewUser"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ShowCirclePicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Browse_to_select_img, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents BtnAdminAddNewUser As Guna.UI.WinForms.GunaButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnAdminDeleteUser As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnAdminEditUser As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnAdminClearField As Guna.UI.WinForms.GunaButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Browse_to_select_img As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtLastName As TextBox
    Friend WithEvents TxtFirstName As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ButtonRefresh As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents CheckBoxByName As CheckBox
    Friend WithEvents CheckBoxByID As CheckBox
    Friend WithEvents ShowCirclePicture As PictureBox
    Friend WithEvents LabID As Label
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents ComAddPermission As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtAddPassword As TextBox
    Friend WithEvents TxtAddUser As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtCurrAdd As TextBox
    Friend WithEvents TxtDob As TextBox
    Friend WithEvents TxtGender As TextBox
    Friend WithEvents TxtPob As TextBox
    Friend WithEvents LabParentID As Label
End Class
