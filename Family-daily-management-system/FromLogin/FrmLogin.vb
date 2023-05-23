Imports MySql.Data.MySqlClient
Public Class FrmLogin

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load




        Try
            'labAccessDb.Text = dbName
            'txtUserName.Text = "User Name"
            'txtUserName.Visible = True
            'txtPassword.Text = "Password"
            'txtPassword.Visible = True


        Catch ex As Exception

        End Try

    End Sub

    Private Sub buttLogin_Click(sender As Object, e As EventArgs) Handles buttLogin.Click
        loadpic()
        logIN()

    End Sub

    'Loading user profile when they logged in
    Sub loadpic()
        ManageConnection()
        Dim picture() As Byte
        Try
            Dim cmd As New MySqlCommand("Select * from tbluser where UserName=@username", con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", txtUserName.Text)
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            'convert image to binary formate
            With FrmAdminDashboard
                picture = dt.Rows(0).Item("Photo")
                .labUser.Text = dt.Rows(0).Item("FirstName") & " " & dt.Rows(0).Item("LastName")
                '.lbl_role.Text = dt.Rows(0).Item("Permission")
                Dim mstream As New System.IO.MemoryStream(picture)
                .cleUserInfo.Image = Image.FromStream(mstream)
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub logIN()

        If txtUserName.Text.Trim = "" Then
            MessageBox.Show("Please Input Username.", subProjectName, MessageBoxButtons.OK,
            MessageBoxIcon.Warning)
            txtUserName.Focus()
            Exit Sub
        End If

        If txtPassword.Text.Trim = "" Then
            MessageBox.Show("Please Input Password.", subProjectName, MessageBoxButtons.OK,
            MessageBoxIcon.Warning)
            txtPassword.Focus()
            Exit Sub
        End If

        Dim ds1 As New DataSet()

        Try

            sql = "SELECT * FROM tbluser WHERE Username ='" & txtUserName.Text.Trim() & "'"
            sql &= "AND Password ='" & txtPassword.Text.Trim() & "'"

            ds1 = DisplayData(sql, "user", ds1)

            If ds1 Is Nothing Then
                'MsgBox("ds1 was nothing.")
                Return
            End If

            'If ds1.Tables("user").Rows.Count > 0 Then


            'This will show current user log in
            'currentUserID = ds1.Tables("user").Rows(0)("AutoID").ToString().Trim()
            currentUsername = ds1.Tables("user").Rows(0)("Username").ToString().Trim()
            currentPermission = ds1.Tables("user").Rows(0)("Permission").ToString().Trim()

            '    FrmAdminDashboard.Show()
            '    'Me.Close()
            'Else

            'Check user log in depent on the user permission
            If ds1.Tables("user").Rows(0)("Permission").ToString().Trim() = "admin" Then
                FrmWelcomePage.Visible = False
                Frm_Login.Visible = False
                FrmAdminDashboard.Show()
            ElseIf ds1.Tables("user").Rows(0)("Permission").ToString().Trim() = "parent" Then
                FrmWelcomePage.Visible = False
                Frm_Login.Visible = False
                'FrmParentDashboard.Show()
                FrmAdminDashboard.Show()
            ElseIf ds1.Tables("user").Rows(0)("Permission").ToString().Trim() = "user" Then
                FrmWelcomePage.Visible = False
                Frm_Login.Visible = False
                'FrmSon_And_DautherDashboard.Show()
                FrmAdminDashboard.Show()
            Else

                MessageBox.Show("The Username Or Password is incorrect, Please Try again!!!", appTitle2, MessageBoxButtons.OK,
                MessageBoxIcon.Error)

                txtUserName.Clear()
                txtPassword.Clear()
                txtUserName.Focus()
                Exit Sub

            End If

        Catch ex As Exception

            MessageBox.Show("Error : " & ex.Message, appTitle2, MessageBoxButtons.OK,
            MessageBoxIcon.Error)

        End Try

    End Sub

    'Private Sub txtUserName_MouseClick(sender As Object, e As MouseEventArgs) Handles txtUserName.MouseClick
    '    If sender Is txtUserName Then
    '        txtUserName.Text = ""
    '    Else
    '        txtPassword.Text = ""
    '    End If
    'End Sub

    'Private Sub txtPassword_MouseClick(sender As Object, e As MouseEventArgs) Handles txtPassword.MouseClick
    '    If sender Is txtPassword Then
    '        txtUserName.Text = ""
    '    Else
    '        txtPassword.Text = ""
    '    End If
    'End Sub




    Private Sub eyeOpenPwd_MouseClick(sender As Object, e As MouseEventArgs) Handles eyeOpenPwd.MouseClick
        If sender Is eyeOpenPwd = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True

        End If
    End Sub



    Private Sub txtUserName_Enter(sender As Object, e As EventArgs) Handles txtUserName.Enter

        ' clear the textbox when the textbox get the focus
        Dim username As String = txtUserName.Text
        ' check if the username is empty
        ' check if the textbox contains the default value "User Name"
        If username.Trim() = "User Name" Or username.Trim() = "" Then

            ' clear the textbox
            txtUserName.Text = ""
            ' change the textbox for color
            txtUserName.ForeColor = Color.Black

        End If

    End Sub

    Private Sub txtUserName_Leave(sender As Object, e As EventArgs) Handles txtUserName.Leave

        ' when the textbox get lost the focus
        Dim username As String = txtUserName.Text
        ' check if the username is empty
        ' check if the textbox contains the default value "User Name"
        If username.Trim().ToLower() = "User Name" Or username.Trim() = "" Then

            ' set the textbox text
            txtUserName.Text = "User Name"
            ' change the textbox for color
            txtUserName.ForeColor = Color.DarkGray

        End If

    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter

        ' when textbox password has focus
        Dim pass As String = txtPassword.Text
        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then

            ' clear the textbox text
            txtPassword.Text = ""
            ' change the textbox font color
            txtPassword.ForeColor = Color.Black
            ' use system password
            'txtPassword.UseSystemPasswordChar = True

        End If

    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave

        ' when textbox password lost focus
        Dim pass As String = txtPassword.Text
        If pass.Trim().ToLower() = "Password" Or pass.Trim() = "" Then

            ' set the textbox text
            txtPassword.Text = "Password"
            ' change the textbox font color
            txtPassword.ForeColor = Color.DarkGray
            ' set system password to false
            'txtPassword.UseSystemPasswordChar = False

        End If

    End Sub


End Class