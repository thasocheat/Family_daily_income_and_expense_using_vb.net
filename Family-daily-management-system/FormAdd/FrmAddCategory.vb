Imports MySql.Data.MySqlClient

Public Class FrmAddCategory


    Private Sub FrmAddCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Category_data_load()
    End Sub
    Public Sub Category_data_load()
        DataGridViewIncome.Rows.Clear()
        Try
            ManageConnection()
            'conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM categories", con)
            'Dim cmd As New MySqlCommand("SELECT categories.*,tbluser.FirstName,categories.CatCode,categories.CatName,categories.CatNote FROM tblincome INNER JOIN tbluser ON tblincome.UserID=tbluser.UserID INNER JOIN categories ON tblincome.CatID=categories.CatID", con)
            dr = cmd.ExecuteReader
            While dr.Read
                'dr.Item("UserID").ToString,
                DataGridViewIncome.Rows.Add(dr.Item("CatID").ToString, dr.Item("CatCode").ToString, dr.Item("CatName").ToString, dr.Item("CatNote").ToString)
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'conn.Close()
        End Try
    End Sub

End Class