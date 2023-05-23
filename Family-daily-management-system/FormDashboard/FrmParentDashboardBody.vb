Imports MySql.Data.MySqlClient
Public Class FrmParentDashboardBody

    Dim conString As String = GetConnectionString()
    Private Sub FrmParentDashboardBody_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TotalIncome()

        TotalExpense()

    End Sub

    Public Sub TotalIncome()
        'ManageConnection()
        Try
            'Dim conString As String = GetConnectionString()

            Dim con As New MySqlConnection(conString)
            con.Open()
            Dim cmd As New MySqlCommand("Select sum(IncomeValue) from tblincome", con)
            Dim i As Double = cmd.ExecuteScalar()
            'i += i
            cmd = Nothing
            con.Close()
            labTotalIncome.Text = i & "$"

        Catch ex As Exception
            labTotalIncome.Text = "No Income Total"
        End Try

    End Sub

    Public Sub TotalExpense()
        'ManageConnection()
        Try
            'Dim conString As String = GetConnectionString()

            Dim con As New MySqlConnection(conString)
            con.Open()
            Dim cmd As New MySqlCommand("Select sum(ExpenseValue) from tblexpense", con)
            Dim i As Double = cmd.ExecuteScalar()
            'i += i
            cmd = Nothing
            con.Close()
            labTotalExpense.Text = i & " រៀល"

        Catch ex As Exception
            labTotalExpense.Text = "No Expense Total"
        End Try

    End Sub

End Class