'Option Explicit On
'Option Strict On

Imports System.IO
Imports MySql.Data.MySqlClient

Module ModCenter

    Public con As New MySqlConnection

    Public da As MySqlDataAdapter

    Public dr As MySqlDataReader

    Public dt As DataTable

    Public cmd As MySqlCommand

    Public sql As String



    Public Const strLang As String = "VB.NET 2023"

    Public Const strAnd As String = Chr(38)

    Public Const strSpace As String = Chr(32)

    Public Const dbName As String = "MySQL Database"



    Public Const mainProjectName As String = "Family Daily Income Management System."

    Public Const subProjectName As String = "Login System with User Authentication."



    Public appTitle1 As String = String.Format("{0} {1}", strLang, mainProjectName)

    Public appTitle1withDb As String = String.Format("{0} {1} {2} {3}", strLang, strAnd, dbName, mainProjectName)



    Public appTitle2 As String = String.Format("{0} {1}", strLang, subProjectName)

    Public appTitle2withDb As String = String.Format("{0} {1} {2} {3}", strLang, strAnd, dbName, subProjectName)



    Public conState As Boolean = False



    Public currentUserID As String = ""

    Public currentUsername As String = ""

    Public currentPermission As String = ""



    Public Function GetConnectionString() As String



        Dim host As String = "server=localhost;"

        Dim port As String = "port=3306;"

        Dim db As String = "database=family_daily_income;"

        Dim user As String = "user=root;"

        'Visual studio 2019 use this
        'Dim pass As String = "password=;Character Set=utf8;"

        'Visual studio 2022 use this
        Dim pass As String = "password="



        Dim conString As String = String.Format("{0}{1}{2}{3}{4}", host, port, db, user, pass)



        Return conString

    End Function

    Public Sub ManageConnection()

        conState = False



        Try



            Dim conString As String = GetConnectionString()



            If con.State = ConnectionState.Open Then

                con.Close()

            End If



            con.ConnectionString = conString

            con.Open()

            conState = True



            ' MessageBox.Show("Connected to MySQL (MariaDB) Database.", appTitle1, MessageBoxButtons.OK, MessageBoxIcon.Information)



        Catch ex As Exception

            conState = False

            MessageBox.Show("Error Database Connection: " & ex.Message, appTitle1withDb, MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return

        End Try

    End Sub

    Public Function DisplayData(str As String, tbl As String, myDS As DataSet) As DataSet

        If con.State = ConnectionState.Closed Then

            ManageConnection()

        End If



        Dim ds As New DataSet



        Try



            ds.Clear()

            da = New MySqlDataAdapter(str, con)

            Dim cmdBuilder As New MySqlCommandBuilder(da)

            da.Fill(myDS, tbl)



            ds = myDS



        Catch ex As Exception

            ds = Nothing

            conState = False

            MessageBox.Show("Error Displaying Data: " & ex.Message, appTitle1withDb, MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            conState = False

            con.Close()

        End Try



        DisplayData = ds

    End Function


    Public Function ExecuteDb(mySQL As String) As Boolean

        Dim bCheck As Boolean = False



        If conState = False Then

            ManageConnection()

        End If



        Try



            cmd = New MySqlCommand(mySQL, con)
            cmd.CommandType = CommandType.Text
            'cmd.CommandText = 600
            cmd.CommandTimeout = 600


            cmd.ExecuteNonQuery()



            bCheck = True



        Catch ex As Exception

            bCheck = False

            MessageBox.Show("Error: " & ex.Message, appTitle1withDb, MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            conState = False

            con.Close()

        End Try



        ExecuteDb = bCheck

    End Function

End Module
