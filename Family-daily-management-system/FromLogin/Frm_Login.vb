Public Class Frm_Login

    Dim loginForm As New FrmLogin()
    Dim registerForm As New FrmRegister()



    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        btnRegister.BaseColor = Color.WhiteSmoke
        btnRegister.OnHoverBaseColor = Color.Gainsboro
        btnRegister.OnHoverForeColor = Color.Black

        btnSignIn.OnHoverBaseColor = Color.Empty
        btnSignIn.OnHoverForeColor = Color.Black

        loginForm.TopLevel = False
        'registerForm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        'f.Size = New System.Drawing.Size(200, 150)
        'f.Location = New System.Drawing.Point(20, 20)
        loginForm.WindowState = FormWindowState.Normal
        loginForm.Visible = False
        panAuthe.Controls.Add(loginForm)

        If loginForm.Visible = False Then loginForm.Visible = True Else loginForm.Visible = False



    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        btnRegister.BaseColor = Color.White
        btnRegister.OnHoverBaseColor = Color.Empty
        btnRegister.OnHoverForeColor = Color.Black

        btnSignIn.BaseColor = Color.WhiteSmoke
        btnSignIn.OnHoverBaseColor = Color.Gainsboro
        btnSignIn.OnHoverForeColor = Color.Black

        loginForm.Visible = False


        registerForm.TopLevel = False
        'registerForm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        'f.Size = New System.Drawing.Size(200, 150)
        'f.Location = New System.Drawing.Point(20, 20)
        registerForm.WindowState = FormWindowState.Normal
        registerForm.Visible = False
        panAuthe.Controls.Add(registerForm)

        If registerForm.Visible = False Then registerForm.Visible = True Else registerForm.Visible = False


    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click

        btnSignIn.BaseColor = Color.White
        btnSignIn.OnHoverBaseColor = Color.Empty
        btnSignIn.OnHoverForeColor = Color.Black

        btnRegister.BaseColor = Color.WhiteSmoke
        btnRegister.OnHoverBaseColor = Color.Gainsboro
        btnRegister.OnHoverForeColor = Color.Black

        registerForm.Visible = False

        loginForm.TopLevel = False
        'registerForm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        'f.Size = New System.Drawing.Size(200, 150)
        'f.Location = New System.Drawing.Point(20, 20)
        loginForm.WindowState = FormWindowState.Normal
        loginForm.Visible = False
        panAuthe.Controls.Add(loginForm)

        If loginForm.Visible = False Then loginForm.Visible = True Else loginForm.Visible = False


    End Sub
End Class