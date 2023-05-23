Public Class FrmAdminDashboard

    Dim formAdminAdd As New FrmAddNewUser()
    Dim formAdminDashboardBody As New FrmAdminDashboardBody()



    Public btnColor As Object = System.Drawing.Color.FromArgb(100, 88, 255)
    Private Sub FrmAdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ManageConnection()

        formAdminDashboardBody.TopLevel = False
        'formAdminDashboardBody.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        'formAdminDashboardBody.Size = New System.Drawing.Size(200, 150)
        'formAdminDashboardBody.Location = New System.Drawing.Point(20, 20)
        'formAdminDashboardBody.WindowState = FormWindowState.Normal
        formAdminDashboardBody.Visible = False
        panAdminDashboardBody.Controls.Add(formAdminDashboardBody)

        If formAdminDashboardBody.Visible = False Then formAdminDashboardBody.Visible = True Else formAdminDashboardBody.Visible = False

        Try

            'Dim login As Form = New FrmLogin()
            'login.ShowDialog()

            ShowPermission()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ShowPermission()

        Dim PermissionDetail As String

        If currentPermission.ToUpper() = "PARENT" Then
            PermissionDetail = "50% Control."
        ElseIf currentPermission.ToUpper() = "USER" Then
            PermissionDetail = "30% Control."
        Else
            PermissionDetail = "Full Control."
        End If

        'labRole.Visible = True
        'labRole.Text = "Current UserName : " & currentUsername & " : Log In as : " &
        'currentPermission.ToUpper() & PermissionDetail


    End Sub

    Private Sub labAdminLogOut_Click(sender As Object, e As EventArgs) Handles labAdminLogOut.Click

        Dim strText As String = "Are you sure you want to log out?"
        Dim strCaption As String = "Log Out From Dashboard."

        If MessageBox.Show(strText, strCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Return 'Exit Sub
        End If

        currentUserID = ""
        currentUsername = ""
        currentPermission = ""

        'labRole.Text = "Logged Out."
        'labAdminLogOut.Text = "Logged Out"

        Me.Visible = False

        FrmWelcomePage.Show()

        FrmAdminDashboard_Load(sender, e)

    End Sub


    Private Sub btnAdminAddUser_Click(sender As Object, e As EventArgs) Handles btnAdminAddUser.Click
        btnAdminDashboard.BaseColor = Color.Transparent
        btnAdminDashboard.ForeColor = Color.Black

        btnAdminAddUser.BaseColor = btnColor
        btnAdminAddUser.ForeColor = Color.White

        BtnAddCategory.BaseColor = Color.Transparent
        BtnAddCategory.ForeColor = Color.Black

        BtnAddIncome.BaseColor = Color.Transparent
        BtnAddIncome.ForeColor = Color.Black

        BtnAddExpense.BaseColor = Color.Transparent
        BtnAddExpense.ForeColor = Color.Black

        formAdminAdd.TopLevel = False
        'formAdminAdd.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        'formAdminAdd.Size = New System.Drawing.Size(200, 150)
        'formAdminAdd.Location = New System.Drawing.Point(20, 20)
        'formAdminAdd.WindowState = FormWindowState.Normal
        formAdminAdd.Visible = False
        panAdminDashboardBody.Controls.Add(formAdminAdd)

        If formAdminAdd.Visible = False Then formAdminAdd.Visible = True Else formAdminAdd.Visible = False


        formAdminDashboardBody.Visible = False
        FrmAddCategory.Visible = False
        FrmAddIncome.Visible = False
        FrmAddExpense.Visible = False


    End Sub

    Private Sub btnAdminDashboard_Click(sender As Object, e As EventArgs) Handles btnAdminDashboard.Click

        btnAdminDashboard.BaseColor = btnColor
        btnAdminDashboard.ForeColor = Color.White

        btnAdminAddUser.BaseColor = Color.Transparent
        btnAdminAddUser.ForeColor = Color.Black

        BtnAddCategory.BaseColor = Color.Transparent
        BtnAddCategory.ForeColor = Color.Black

        BtnAddIncome.BaseColor = Color.Transparent
        BtnAddIncome.ForeColor = Color.Black

        BtnAddExpense.BaseColor = Color.Transparent
        BtnAddExpense.ForeColor = Color.Black

        formAdminDashboardBody.TopLevel = False
        'formAdminDashboardBody.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        'formAdminDashboardBody.Size = New System.Drawing.Size(200, 150)
        'formAdminDashboardBody.Location = New System.Drawing.Point(20, 20)
        'formAdminDashboardBody.WindowState = FormWindowState.Normal
        formAdminDashboardBody.Visible = False
        panAdminDashboardBody.Controls.Add(formAdminDashboardBody)

        If formAdminDashboardBody.Visible = False Then formAdminDashboardBody.Visible = True Else formAdminDashboardBody.Visible = False

        formAdminAdd.Visible = False
        FrmAddCategory.Visible = False
        FrmAddIncome.Visible = False
        FrmAddExpense.Visible = False


    End Sub

    Private Sub cleUserInfo_Click(sender As Object, e As EventArgs) Handles cleUserInfo.Click

        MessageBox.Show("User ID: " & currentUserID & vbNewLine & vbNewLine &
                "Username: " & currentUsername & vbNewLine & vbNewLine &
                "Permission: " & currentPermission,
                "VB.NET : Current logged in user.",
                MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub BtnAddCategory_Click(sender As Object, e As EventArgs) Handles BtnAddCategory.Click
        btnAdminDashboard.BaseColor = Color.Transparent
        btnAdminDashboard.ForeColor = Color.Black

        btnAdminAddUser.BaseColor = Color.Transparent
        btnAdminAddUser.ForeColor = Color.Black

        BtnAddCategory.BaseColor = btnColor
        BtnAddCategory.ForeColor = Color.White

        BtnAddIncome.BaseColor = Color.Transparent
        BtnAddIncome.ForeColor = Color.Black

        BtnAddExpense.BaseColor = Color.Transparent
        BtnAddExpense.ForeColor = Color.Black

        FrmAddCategory.TopLevel = False
        FrmAddCategory.Visible = False
        panAdminDashboardBody.Controls.Add(FrmAddCategory)

        If FrmAddCategory.Visible = False Then FrmAddCategory.Visible = True Else FrmAddCategory.Visible = False

        formAdminAdd.Visible = False
        formAdminDashboardBody.Visible = False
        FrmAddIncome.Visible = False
        FrmAddExpense.Visible = False


    End Sub

    Private Sub BtnAddIncome_Click(sender As Object, e As EventArgs) Handles BtnAddIncome.Click
        btnAdminDashboard.BaseColor = Color.Transparent
        btnAdminDashboard.ForeColor = Color.Black

        btnAdminAddUser.BaseColor = Color.Transparent
        btnAdminAddUser.ForeColor = Color.Black

        BtnAddCategory.BaseColor = Color.Transparent
        BtnAddCategory.ForeColor = Color.Black

        BtnAddIncome.BaseColor = btnColor
        BtnAddIncome.ForeColor = Color.White

        BtnAddExpense.BaseColor = Color.Transparent
        BtnAddExpense.ForeColor = Color.Black

        FrmAddIncome.TopLevel = False
        FrmAddIncome.Visible = False
        panAdminDashboardBody.Controls.Add(FrmAddIncome)

        If FrmAddIncome.Visible = False Then FrmAddIncome.Visible = True Else FrmAddIncome.Visible = False

        formAdminAdd.Visible = False
        formAdminDashboardBody.Visible = False
        FrmAddCategory.Visible = False
        FrmAddExpense.Visible = False

    End Sub

    Private Sub BtnAddExpense_Click(sender As Object, e As EventArgs) Handles BtnAddExpense.Click
        btnAdminDashboard.BaseColor = Color.Transparent
        btnAdminDashboard.ForeColor = Color.Black

        btnAdminAddUser.BaseColor = Color.Transparent
        btnAdminAddUser.ForeColor = Color.Black

        BtnAddCategory.BaseColor = Color.Transparent
        BtnAddCategory.ForeColor = Color.Black

        BtnAddIncome.BaseColor = Color.Transparent
        BtnAddIncome.ForeColor = Color.Black

        BtnAddExpense.BaseColor = btnColor
        BtnAddExpense.ForeColor = Color.White



        FrmAddExpense.TopLevel = False
        FrmAddExpense.Visible = False
        panAdminDashboardBody.Controls.Add(FrmAddExpense)

        If FrmAddExpense.Visible = False Then FrmAddExpense.Visible = True Else FrmAddExpense.Visible = False

        formAdminAdd.Visible = False
        formAdminDashboardBody.Visible = False
        FrmAddCategory.Visible = False
        FrmAddIncome.Visible = False

    End Sub
End Class