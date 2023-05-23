Public Class FrmWelcomePage
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

        ManageConnection()

        Frm_Login.ShowDialog()

    End Sub
End Class