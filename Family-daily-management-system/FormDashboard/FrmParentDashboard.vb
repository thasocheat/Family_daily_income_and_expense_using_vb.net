Public Class FrmParentDashboard

    Dim formParentAddIncome As New FrmAddIncome()
    Dim formParentAddExpense As New FrmAddExpense()
    Dim formParentDashboardBody As New FrmParentDashboardBody()

    Public btnColor As Object = System.Drawing.Color.FromArgb(100, 88, 255)


    Private Sub FrmParentDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load

        ManageConnection()

        formParentDashboardBody.TopLevel = False
        'formAdminDashboardBody.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        'formAdminDashboardBody.Size = New System.Drawing.Size(200, 150)
        'formAdminDashboardBody.Location = New System.Drawing.Point(20, 20)
        'formAdminDashboardBody.WindowState = FormWindowState.Normal
        formParentDashboardBody.Visible = False
        panParentBodyForm.Controls.Add(formParentDashboardBody)

        If formParentDashboardBody.Visible = False Then formParentDashboardBody.Visible = True Else formParentDashboardBody.Visible = False

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

    Private Sub labParentLogOut_Click(sender As Object, e As EventArgs) Handles labParentLogOut.Click

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
        labParentLogOut.Text = "Logged Out"

        Me.Visible = False

        FrmWelcomePage.Show()

        FrmParentDashboard_Load(sender, e)

    End Sub

    Private Sub btnParentDashboard_Click(sender As Object, e As EventArgs) Handles btnParentDashboard.Click

        'Button Dashboard
        btnParentDashboard.BaseColor = btnColor
        btnParentDashboard.ForeColor = Color.White

        'Button Add Income
        btnParentAddIncome.BaseColor = Color.Transparent
        btnParentAddIncome.ForeColor = Color.Black

        'Button Add Expense
        btnAddExpense.BaseColor = Color.Transparent
        btnAddExpense.ForeColor = Color.Black

        formParentDashboardBody.TopLevel = False
        'formAdminDashboardBody.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        'formAdminDashboardBody.Size = New System.Drawing.Size(200, 150)
        'formAdminDashboardBody.Location = New System.Drawing.Point(20, 20)
        'formAdminDashboardBody.WindowState = FormWindowState.Normal
        formParentDashboardBody.Visible = False
        panParentBodyForm.Controls.Add(formParentDashboardBody)

        If formParentDashboardBody.Visible = False Then formParentDashboardBody.Visible = True Else formParentDashboardBody.Visible = False

        formParentAddIncome.Visible = False

        formParentAddExpense.Visible = False

    End Sub

    Private Sub btnParentProfile_Click(sender As Object, e As EventArgs) Handles btnParentProfile.Click

    End Sub

    Private Sub btnParentAddIncome_Click(sender As Object, e As EventArgs) Handles btnParentAddIncome.Click

        'Button Dashboard
        btnParentDashboard.BaseColor = Color.Transparent
        btnParentDashboard.ForeColor = Color.Black

        'Button Add Income
        btnParentAddIncome.BaseColor = btnColor
        btnParentAddIncome.ForeColor = Color.White

        'Button Add Expense
        btnAddExpense.BaseColor = Color.Transparent
        btnAddExpense.ForeColor = Color.Black

        formParentAddIncome.TopLevel = False
        'formAdminAdd.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        'formAdminAdd.Size = New System.Drawing.Size(200, 150)
        'formAdminAdd.Location = New System.Drawing.Point(20, 20)
        'formAdminAdd.WindowState = FormWindowState.Normal
        formParentAddIncome.Visible = False
        panParentBodyForm.Controls.Add(formParentAddIncome)

        If formParentAddIncome.Visible = False Then formParentAddIncome.Visible = True Else formParentAddIncome.Visible = False


        formParentDashboardBody.Visible = False

        formParentAddExpense.Visible = False

    End Sub

    Private Sub cleUserInfo_Click(sender As Object, e As EventArgs) Handles cleUserInfo.Click

        MessageBox.Show("User ID: " & currentUserID & vbNewLine & vbNewLine &
                "Username: " & currentUsername & vbNewLine & vbNewLine &
                "Permission: " & currentPermission,
                "VB.NET : Current logged in user.",
                MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnAddExpense_Click(sender As Object, e As EventArgs) Handles btnAddExpense.Click

        'Button Add Income
        btnParentAddIncome.BaseColor = Color.Transparent
        btnParentAddIncome.ForeColor = Color.Black

        'Button Dashboard
        btnParentDashboard.BaseColor = Color.Transparent
        btnParentDashboard.ForeColor = Color.Black


        btnAddExpense.BaseColor = btnColor
        btnAddExpense.ForeColor = Color.White

        formParentAddExpense.TopLevel = False
        'formAdminAdd.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        'formAdminAdd.Size = New System.Drawing.Size(200, 150)
        'formAdminAdd.Location = New System.Drawing.Point(20, 20)
        'formAdminAdd.WindowState = FormWindowState.Normal
        formParentAddExpense.Visible = False
        panParentBodyForm.Controls.Add(formParentAddExpense)

        If formParentAddExpense.Visible = False Then formParentAddExpense.Visible = True Else formParentAddExpense.Visible = False


        formParentDashboardBody.Visible = False

        formParentAddIncome.Visible = False
    End Sub
End Class