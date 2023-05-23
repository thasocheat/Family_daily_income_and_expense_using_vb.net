Imports MySql.Data.MySqlClient
Public Class FrmAdminDashboardBody

    Dim conString As String = GetConnectionString()

    Private Sub FrmAdminDashboardBody_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TotalUsers()

        TotalAdmin()

        TotalParent()

        TotalStudent()


    End Sub

    Sub TotalUsers()
        'ManageConnection()
        Try
            'Dim conString As String = GetConnectionString()

            Dim con As New MySqlConnection(conString)
            con.Open()
            Dim cmd As New MySqlCommand("Select Count(*) from tbluser where UserID", con)
            Dim i As Integer = cmd.ExecuteScalar()
            cmd = Nothing
            con.Close()
            labTotalUser.Text = i & " នាក់"

        Catch ex As Exception
            labTotalUser.Text = "No User"
        End Try

    End Sub

    Sub TotalAdmin()
        'ManageConnection()
        Try
            'Dim conString As String = GetConnectionString()

            Dim con As New MySqlConnection(conString)
            con.Open()
            Dim cmd As New MySqlCommand("Select Count(*) from tbluser where Permission = 'admin'", con)
            Dim i As Integer = cmd.ExecuteScalar()
            cmd = Nothing
            con.Close()
            labTotalAdmin.Text = i & " នាក់"

        Catch ex As Exception
            labTotalAdmin.Text = "No Admin"
        End Try

    End Sub

    Sub TotalParent()
        'ManageConnection()
        Try
            'Dim conString As String = GetConnectionString()

            Dim con As New MySqlConnection(conString)
            con.Open()
            Dim cmd As New MySqlCommand("Select Count(*) from tbluser where Permission = 'parent'", con)
            Dim i As Integer = cmd.ExecuteScalar()
            cmd = Nothing
            con.Close()
            labTotalParent.Text = i & " នាក់"

        Catch ex As Exception
            labTotalParent.Text = "No Parent"
        End Try

    End Sub

    Sub TotalStudent()
        'ManageConnection()
        Try
            'Dim conString As String = GetConnectionString()

            Dim con As New MySqlConnection(conString)
            con.Open()
            Dim cmd As New MySqlCommand("Select Count(*) from tbluser where Permission = 'user'", con)
            Dim i As Integer = cmd.ExecuteScalar()
            cmd = Nothing
            con.Close()
            labTotalStudentUser.Text = i & " នាក់"

        Catch ex As Exception
            labTotalStudentUser.Text = "No Student or Normal User"
        End Try

    End Sub

End Class