Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.IO
Public Class FrmAddNewUser

    'Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=family_daily_income")
    Dim i As Integer
    'Dim dr As MySqlDataReader
    'Dim newID As Integer = 

    Private Sub FrmAddNewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
        LabID.Visible = False
        LabParentID.Visible = False
    End Sub
    Public Sub DGV_load()
        DataGridView1.Rows.Clear()
        Try
            ManageConnection()



            'conn.Open()
            'Dim cmd As New MySqlCommand("SELECT * FROM tbluser", conn)
            Dim cmd As New MySqlCommand("SELECT * FROM tbluser", con)
            dr = cmd.ExecuteReader
            While dr.Read
                'dr.Item("UserID").ToString,
                DataGridView1.Rows.Add(dr.Item("UserID").ToString, dr.Item("ParentID").ToString, dr.Item("FirstName").ToString, dr.Item("LastName").ToString, dr.Item("UserName").ToString, dr.Item("Gender").ToString, dr.Item("Dob").ToString, dr.Item("Pob").ToString, dr.Item("CurrentAdd").ToString, dr.Item("PhoneNum").ToString, dr.Item("Password").ToString, dr.Item("Permission").ToString, dr.Item("Photo"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'conn.Close()
        End Try
    End Sub

    Public Sub clear()
        TxtFirstName.Text = ""
        TxtLastName.Text = ""
        TxtAddUser.Text = ""
        TxtAddPassword.Text = ""
        ComAddPermission.Text = ""
        ShowCirclePicture.Image = Nothing
    End Sub

    Private Sub Browse_to_select_img_Click(sender As Object, e As EventArgs) Handles Browse_to_select_img.Click
        Dim pop As OpenFileDialog = New OpenFileDialog
        pop.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        If pop.ShowDialog = Windows.Forms.DialogResult.OK Then
            ShowCirclePicture.Image = Image.FromFile(pop.FileName)
        End If
    End Sub

    Private Sub BtnAdminAddNewUser_Click(sender As Object, e As EventArgs) Handles BtnAdminAddNewUser.Click
        Try
            ManageConnection()
            'conn.Open()
            'Dim cmd As New MySqlCommand("INSERT INTO `tbluser`(`FirstName`, `LastName`, `Username`, `Password`, `Permission`, `Photo`) VALUES (@fir,@las,@use,@pass,@per,@img)", conn)
            Dim cmd As New MySqlCommand("INSERT INTO `tbluser`(`FirstName`, `LastName`, `Username`, `Password`, `Permission`, `Photo`) VALUES (@fir,@las,@use,@pass,@per,@img)", con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@fir", TxtFirstName.Text)
            cmd.Parameters.AddWithValue("@las", TxtLastName.Text)
            cmd.Parameters.AddWithValue("@use", TxtAddUser.Text)
            cmd.Parameters.AddWithValue("@pass", TxtAddPassword.Text)
            cmd.Parameters.AddWithValue("@per", ComAddPermission.Text)

            'image convert to binary format

            Dim FileSize As New UInt32
            Dim mstream As New System.IO.MemoryStream
            ShowCirclePicture.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim picture() As Byte = mstream.GetBuffer
            FileSize = mstream.Length
            mstream.Close()
            cmd.Parameters.AddWithValue("@img", picture)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Record Save Success !", "CURD", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record Save Failed !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'conn.Close()
        End Try
        clear()
        DGV_load()
    End Sub

    Private Sub BtnAdminEditUser_Click(sender As Object, e As EventArgs) Handles BtnAdminEditUser.Click

        Try
            ManageConnection()
            'conn.Open()
            'intID = Convert.ToInt32(selectedID.ToString.Trim())
            'Dim cmd As New MySqlCommand("UPDATE `tbluser` SET `FirstName`=@fir,`LastName`=@las,`Username`=@use,`Password`=@pass,`Permission`=@per,`Photo`=@img WHERE `UserID`=" & LabID.Text & "", conn)
            Dim cmd As New MySqlCommand("UPDATE `tbluser` SET `FirstName`=@fir,`LastName`=@las,`Username`=@use,`Password`=@pass,`Permission`=@per,`Photo`=@img WHERE `UserID`=" & LabID.Text & "", con)
            cmd.Parameters.Clear()
            'cmd.Parameters.AddWithValue("@autoid", DataGridView1.CurrentRow.Cells("Column1").Value.ToString)
            cmd.Parameters.AddWithValue("@fir", TxtFirstName.Text)
            cmd.Parameters.AddWithValue("@las", TxtLastName.Text)
            cmd.Parameters.AddWithValue("@use", TxtAddUser.Text)
            cmd.Parameters.AddWithValue("@pass", TxtAddPassword.Text)
            cmd.Parameters.AddWithValue("@per", ComAddPermission.Text)

            'image convert to binary format

            Dim FileSize As New UInt32
            Dim mstream As New System.IO.MemoryStream
            ShowCirclePicture.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim picture() As Byte = mstream.GetBuffer
            FileSize = mstream.Length
            mstream.Close()
            cmd.Parameters.AddWithValue("@img", picture)
            'cmd.Parameters.AddWithValue("@fir", TxtFirstName.Text)


            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Record Update Success !", "CURD", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record Update Failed !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'conn.Close()
        End Try
        clear()
        DGV_load()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Try
            'If e.RowIndex = -1 Then
            '    Exit Sub
            'End If

            'selectedID = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString().Trim()
            ''Me.Text = DataGridView1.CurrentRow.Cells(0).Value

            LabID.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
            LabParentID.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
            TxtFirstName.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
            TxtLastName.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
            TxtAddUser.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
            TxtGender.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
            TxtDob.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
            TxtPob.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
            TxtCurrAdd.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString()
            TxtPhone.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString()

            TxtAddPassword.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString()
            'If Convert.ToString(DataGridView1.CurrentRow.Cells(5).Value).Trim().ToUpper = "ADMIN" Then
            '    ComAddPermission.SelectedIndex = 1
            'Else
            '    ComAddPermission.SelectedIndex = 2
            'End If
            ComAddPermission.Text = DataGridView1.CurrentRow.Cells(11).Value

            Dim bytes As [Byte]() = DataGridView1.CurrentRow.Cells(12).Value
            Dim ms As New MemoryStream(bytes)
            ShowCirclePicture.Image = Image.FromStream(ms)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnAdminDeleteUser_Click(sender As Object, e As EventArgs) Handles BtnAdminDeleteUser.Click
        'intID = Convert.ToInt32(selectedID.ToString.Trim())
        If MsgBox("Are You Sure Delete This Record", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                ManageConnection()
                'conn.Open()
                'Dim cmd As New MySqlCommand("DELETE FROM `tbluser` WHERE `UserID`=" & LabID.Text & "", conn)
                Dim cmd As New MySqlCommand("DELETE FROM `tbluser` WHERE `UserID`=" & LabID.Text & "", con)
                cmd.Parameters.Clear()
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("Record Deleted Success !", "CURD", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Record Deleted Failed !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                'conn.Close()
            End Try
            clear()
            DGV_load()
        Else
            Return
        End If
    End Sub

    Private Sub BtnAdminClearField_Click(sender As Object, e As EventArgs) Handles BtnAdminClearField.Click
        clear()
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        DGV_load()
    End Sub
    ' ================= End new ===================================








    ' ===================== Below is old code =========================
    'Private selectedID As String = ""


    'Private Sub FrmAddNewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '    ShowUserData()

    'End Sub

    ''Insert profile
    'Private Sub browse_to_select_img_Click(sender As Object, e As EventArgs) Handles Browse_to_select_img.Click
    '    Dim opf As New OpenFileDialog

    '    opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

    '    If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

    '        ShowCirclePicture.Image = Image.FromFile(opf.FileName)

    '    End If


    'End Sub


    ''In ShowUserData you need to use DataGridView or ListView and add all of your table columns
    'Private Sub ShowUserData()
    '    ManageConnection()
    '    DataGridView1.Rows.Clear()
    '    Try
    '        Dim cmd As New MySqlCommand("Select * from tbluser", con)
    '        dr = cmd.ExecuteReader
    '        While dr.Read
    '            DataGridView1.Rows.Add(dr.Item("UserID").ToString, dr.Item("FirstName").ToString, dr.Item("LastName").ToString, dr.Item("UserName").ToString, dr.Item("Password").ToString, dr.Item("Permission").ToString, dr.Item("Photo"))
    '        End While
    '        dr.Dispose()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    'End Sub

    'Private Sub btnAdminAddNewUser_Click(sender As Object, e As EventArgs) Handles BtnAdminAddNewUser.Click
    '    SaveUserData("INSERT")
    'End Sub

    'Private Sub btnAdminEditUser_Click(sender As Object, e As EventArgs) Handles BtnAdminEditUser.Click
    '    SaveUserData("UPDATE")
    'End Sub

    'Private Sub btnAdminDeleteUser_Click(sender As Object, e As EventArgs) Handles BtnAdminDeleteUser.Click
    '    SaveUserData("DELETE")
    'End Sub

    'Private Sub btnAdminClearField_Click(sender As Object, e As EventArgs) Handles BtnAdminClearField.Click
    '    ClearControls()
    'End Sub
    'Private Sub ClearControls()

    '    selectedID = ""
    '    TxtFirstName.Clear()
    '    TxtLastName.Clear()
    '    TxtAddUser.Text = ""
    '    TxtAddPassword.Text = ""


    '    ComAddPermission.Text = ""
    '    ShowCirclePicture.Image = Nothing

    '    If ComAddPermission.Items.Count > 0 Then
    '        ComAddPermission.SelectedIndex = 0
    '    End If

    '    'btnAdminDeleteUser.Enabled = False
    '    'btnAdminEditUser.Enabled = False


    'End Sub


    ''Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
    ''    btnAdminAddNewUser.Enabled = False
    ''    btnAdminDeleteUser.Enabled = False

    ''    Me.Text = DataGridView1.CurrentRow.Cells(0).Value
    ''    txtFirstName.Text = DataGridView1.CurrentRow.Cells(1).Value
    ''    txtLastName.Text = DataGridView1.CurrentRow.Cells(2).Value
    ''    txtAddUser.Text = DataGridView1.CurrentRow.Cells(3).Value
    ''    txtAddPassword.Text = DataGridView1.CurrentRow.Cells(4).Value
    ''    comAddPermission.Text = DataGridView1.CurrentRow.Cells(5).Value

    ''    Dim bytes As [Byte]() = DataGridView1.CurrentRow.Cells(6).Value
    ''    Dim ms As New MemoryStream(bytes)
    ''    showCirclePicture.Image = Image.FromStream(ms)
    ''End Sub
    'Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick

    '    Try


    '        'btnAdminAddNewUser.Enabled = False

    '        If e.RowIndex = -1 Then
    '            Exit Sub
    '        End If

    '        selectedID = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString().Trim()

    '        LabID.Text = DataGridView1.CurrentRow.Cells(0).Value
    '        TxtFirstName.Text = DataGridView1.CurrentRow.Cells(1).Value
    '        TxtLastName.Text = DataGridView1.CurrentRow.Cells(2).Value
    '        TxtAddUser.Text = DataGridView1.CurrentRow.Cells(3).Value
    '        TxtAddPassword.Text = DataGridView1.CurrentRow.Cells(4).Value
    '        ComAddPermission.Text = DataGridView1.CurrentRow.Cells(5).Value

    '        Dim bytes As [Byte]() = DataGridView1.CurrentRow.Cells(6).Value
    '        Dim ms As New MemoryStream(bytes)
    '        ShowCirclePicture.Image = Image.FromStream(ms)



    '        'Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
    '        'If colname = "colDelete" Then


    '        'End If


    '    Catch ex As Exception

    '    End Try

    'End Sub

    'Private Sub SaveUserData(dbCommand As String)

    '    ManageConnection()

    '    Try

    '        If dbCommand.ToUpper() = "UPDATE" Or dbCommand.ToUpper() = "DELETE" Then
    '            If selectedID = "" Then
    '                MessageBox.Show("ID not found. Please select at least one item.", appTitle1,
    '                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                Return
    '            End If
    '        End If

    '        If dbCommand.ToUpper() = "INSERT" Or dbCommand.ToUpper() = "UPDATE" Then

    '            If TxtAddUser.Text.Trim() = "" Then
    '                MessageBox.Show("Please input Username.", appTitle1, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                TxtAddUser.Focus()
    '                Exit Sub
    '            End If

    '            If TxtAddPassword.Text.Trim() = "" Then
    '                MessageBox.Show("Please input Password.", appTitle1, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                TxtAddPassword.Focus()
    '                Exit Sub
    '            End If

    '        End If

    '        If dbCommand.ToUpper() <> "DELETE" Then

    '            If ComAddPermission.Text = "" Then
    '                MessageBox.Show("Please select the permission from the ComboBox.", appTitle1, MessageBoxButtons.OK, MessageBoxIcon.Information)

    '                Return

    '            End If

    '        End If


    '        'Select case to insert, update and delete the data
    '        Select Case dbCommand.ToUpper().Trim()

    '            Case "INSERT"

    '                inserData()


    '            Case "UPDATE"

    '                updateData()

    '            Case "DELETE"

    '                deleteData()



    '        End Select

    '        If ExecuteDb(sql) = True Then
    '            selectedID = ""
    '            MessageBox.Show("Your SQL " & dbCommand & " QUERY has been executed successfully.",
    '                            appTitle1withDb, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            ShowUserData()
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show("Error: " & ex.Message.ToString(), appTitle1, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Exit Sub
    '    End Try

    'End Sub

    'Sub inserData()

    '    Try

    '        If MessageBox.Show("Do you want to add this new user?",
    '                                   "Add New User : Into Access Database.",
    '                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question,
    '                                   MessageBoxDefaultButton.Button2) = DialogResult.No Then
    '            Dim ms As New MemoryStream
    '            ShowCirclePicture.Image.Save(ms, ShowCirclePicture.Image.RawFormat)

    '            'cmd = New MySqlCommand("insert into tbluser (FirstName,LastName,Username,Password,Permission,Photo) Values ('" & TxtFirstName.Text & "','" & TxtLastName.Text & "','" & TxtAddUser.Text & "','" & TxtAddPassword.Text & "','" & ComAddPermission.Text & "','" & foto.Replace("\", "\\").ToString & "')", con)
    '            'cmd.ExecuteNonQuery()

    '            'Dim command As New MySqlCommand("INSERT INTO `tbluser`(`FirstName`, `LastName`, `Username`, `Password`, `Permission`, `Photo`) VALUES (@fir,@las,@use,@pass,@per,@img)", con)

    '            'With command.Parameters
    '            '    .Add("@fir", MySqlDbType.VarChar).Value = TxtFirstName.Text
    '            '    .Add("@las", MySqlDbType.VarChar).Value = TxtLastName.Text
    '            '    .Add("@use", MySqlDbType.VarChar).Value = TxtAddUser.Text
    '            '    .Add("@pass", MySqlDbType.VarChar).Value = TxtAddPassword.Text
    '            '    .Add("@per", MySqlDbType.VarChar).Value = ComAddPermission.Text
    '            'End With
    '            cmd.CommandType = CommandType.Text
    '            Dim command = New MySqlCommand
    '            With command
    '                .CommandText = "INSERT INTO `tbluser` " & " (FirstName,LastName,Username,Password,Permission,Photo) VALUES (@fir,@las,@use,@pass,@per,@img)"
    '                .Connection = con
    '                .Parameters.AddWithValue("@fir", TxtFirstName.Text)
    '                .Parameters.AddWithValue("@las", TxtLastName.Text)
    '                .Parameters.AddWithValue("@use", TxtAddUser.Text)
    '                .Parameters.AddWithValue("@pass", TxtAddPassword.Text)
    '                .Parameters.AddWithValue("@per", ComAddPermission.Text)
    '                '.Parameters.AddWithValue("@img", arrImage)
    '                .ExecuteNonQuery()
    '            End With

    '            Dim FileSize As New UInt32
    '            Dim mstream As New System.IO.MemoryStream
    '            ShowCirclePicture.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
    '            Dim picture() As Byte = mstream.GetBuffer
    '            FileSize = mstream.Length
    '            mstream.Close()
    '            command.Parameters.AddWithValue("@img", picture)

    '            Dim i As Integer
    '            i = command.ExecuteNonQuery
    '            If i > 0 Then
    '                MsgBox("New User Register Success !", vbInformation)
    '            Else
    '                MsgBox("New User Register Failed !", vbCritical)
    '            End If

    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try

    '    ShowUserData()
    '    ClearControls()

    '    Return
    'End Sub


    'Dim intID As Integer

    'Sub updateData()

    '    If MessageBox.Show("Do you want to update the selected record?", appTitle1, MessageBoxButtons.YesNo,
    '                                   MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then

    '        intID = Convert.ToInt32(selectedID.ToString.Trim())

    '        Dim command As New MySqlCommand("UPDATE `tbluser` SET `FirstName`=@firstname,`LastName`=@lastname,`UserName`=@username,`Password`=@password,`Permission`=@permission,`Photo`=@img WHERE `UserID`= @autoid = " & intID & " ", con)


    '        With command.Parameters
    '            .Clear()
    '            .AddWithValue("@autoid", DataGridView1.CurrentRow.Cells("Column1").Value.ToString)
    '            .AddWithValue("@firstname", TxtFirstName.Text)
    '            .AddWithValue("@lastname", TxtLastName.Text)
    '            .AddWithValue("@username", TxtAddUser.Text)
    '            .AddWithValue("@password", TxtAddPassword.Text)
    '            .AddWithValue("@permission", ComAddPermission.Text)
    '        End With

    '        Dim FileSize As New UInt32
    '        Dim mstream As New System.IO.MemoryStream
    '        ShowCirclePicture.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
    '        Dim picture() As Byte = mstream.GetBuffer
    '        FileSize = mstream.Length
    '        mstream.Close()
    '        command.Parameters.AddWithValue("@img", picture)

    '        Dim i As Integer
    '        i = command.ExecuteNonQuery
    '        If i > 0 Then
    '            MsgBox("Edit Successfully !", vbInformation)
    '        Else
    '            MsgBox("Failed !", vbCritical)
    '        End If

    '    End If

    '    ShowUserData()
    '    ClearControls()

    '    'Return

    'End Sub

    'Sub deleteData()

    '    If currentUserID = selectedID Then
    '        MessageBox.Show("Error Deleting Record: " & "The user " & Chr(39) & currentUsername & Chr(39) &
    '                            " Is currently logged in.", appTitle1, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Exit Sub
    '    End If


    '    If MessageBox.Show("Do you want to delete the selected record?", appTitle1, MessageBoxButtons.YesNo,
    '                           MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
    '        Try
    '            Dim command As New MySqlCommand("delete from tbluser where AutoID=@autoid", con)
    '            command.Parameters.Clear()
    '            command.Parameters.AddWithValue("@autoid", DataGridView1.CurrentRow.Cells("Column1").Value.ToString)

    '            Dim i As Integer
    '            i = command.ExecuteNonQuery
    '            If i > 0 Then
    '                MsgBox("User Delete Success !", vbInformation)
    '            Else
    '                MsgBox("Failed !", vbCritical)
    '            End If

    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End If

    '    ShowUserData()
    '    ClearControls()

    'End Sub
End Class