Imports System.IO
Imports System.Reflection.Emit
Imports MySql.Data.MySqlClient

Public Class FrmAddIncome

    Dim formAdminAdd As New FrmAddNewUser()
    Dim uids As New FrmLogin()

    'Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=family_daily_income")
    Dim i As Integer
    'Dim dr As MySqlDataReader
    'Dim uid As String = LabID.Text
    'Dim cate As String = ComIncome.Text
    'Dim amo As String
    'Dim des As String
    'Dim datime As String



    Private Sub FrmAddIncome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataCat_in_income_combo_load()
        DGV_load()
        'LabID.Visible = False
    End Sub

    Public Sub DataCat_in_income_combo_load()
        ManageConnection()
        Dim cmd As New MySqlCommand("SELECT CatID,CatCode,CatName FROM categories", con)
        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        ComIncome.DataSource = dt
        ComIncome.DisplayMember = "CatName"
        'ComIncome.DisplayMember = "CatCode"
        ComIncome.ValueMember = "CatID"
        ComIncome.Text = "--- Select ---"
    End Sub

    Public Sub DGV_load()
        DataGridViewIncome.Rows.Clear()
        Try
            ManageConnection()
            'conn.Open()
            'Dim cmd As New MySqlCommand("SELECT * FROM tbluser", conn)
            Dim cmd As New MySqlCommand("SELECT IncomeID,UserID,CatID,Description,Amount,IncomeDate FROM tblincome", con)
            dr = cmd.ExecuteReader
            While dr.Read
                'dr.Item("UserID").ToString,
                DataGridViewIncome.Rows.Add(dr.Item("IncomeID").ToString, dr.Item("UserID").ToString, dr.Item("CatID").ToString, dr.Item("Description").ToString, dr.Item("Amount").ToString, dr.Item("IncomeDate").ToString)
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'conn.Close()
        End Try
    End Sub

    'Public Sub DGV_load()
    '    DataGridViewIncome.Rows.Clear()
    '    Try
    '        ManageConnection()
    '        'conn.Open()
    '        'Dim cmd As New MySqlCommand("SELECT * FROM tbluser", conn)
    '        Dim cmd As New MySqlCommand("SELECT tblincome.*,tbluser.FirstName,categories.CatCode,categories.CatName,categories.CatNote FROM tblincome INNER JOIN tbluser ON tblincome.UserID=tbluser.UserID INNER JOIN categories ON tblincome.CatID=categories.CatID", con)
    '        dr = cmd.ExecuteReader
    '        While dr.Read
    '            'dr.Item("UserID").ToString,
    '            DataGridViewIncome.Rows.Add(dr.Item("IncomeID").ToString, dr.Item("UserID").ToString, dr.Item("CatID").ToString, dr.Item("Description").ToString, dr.Item("Amount").ToString, dr.Item("IncomeDate").ToString, dr.Item("FirstName").ToString, dr.Item("CatCode").ToString, dr.Item("CatName").ToString, dr.Item("CatNote").ToString)
    '        End While
    '        dr.Dispose()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        'conn.Close()
    '    End Try
    'End Sub

    Public Sub clear()
        ComIncome.Text = ""
        txtIncomeValue.Text = ""
        RichDescription.Text = ""
        dateTimeIncome.Text = ""
    End Sub




    Private Sub btnAddNewIncom_Click(sender As Object, e As EventArgs) Handles btnAddNewIncom.Click
        Try
            ManageConnection()
            'conn.Open()
            'Dim cmd As New MySqlCommand("INSERT INTO `tbluser`(`FirstName`, `LastName`, `Username`, `Password`, `Permission`, `Photo`) VALUES (@fir,@las,@use,@pass,@per,@img)", conn)
            Dim cmd As New MySqlCommand("INSERT INTO `tblincome`(`CatID`, `Description`, `Amount`, `IncomeDate`) VALUES (@catid,@des,@amo,@indate)", con)
            cmd.Parameters.Clear()
            'cmd.Parameters.AddWithValue("@uid", uid)
            cmd.Parameters.AddWithValue("@catid", ComIncome.Text)
            cmd.Parameters.AddWithValue("@amo", txtIncomeValue.Text)
            cmd.Parameters.AddWithValue("@des", RichDescription.Text)
            cmd.Parameters.AddWithValue("@indate", dateTimeIncome.Text)


            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Record Save Success !", "Add Income", MessageBoxButtons.OK, MessageBoxIcon.Information)
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



    Private Sub btnEditIncome_Click(sender As Object, e As EventArgs) Handles btnEditIncome.Click
        Try
            ManageConnection()
            'conn.Open()
            'intID = Convert.ToInt32(selectedID.ToString.Trim())
            'Dim cmd As New MySqlCommand("UPDATE `tbluser` SET `FirstName`=@fir,`LastName`=@las,`Username`=@use,`Password`=@pass,`Permission`=@per,`Photo`=@img WHERE `UserID`=" & LabID.Text & "", conn)
            Dim cmd As New MySqlCommand("UPDATE `tblincome` SET `CatID`=@catid,`Description`=@des,`Amount`=@amo,`IncomeDate`=@indate WHERE `IncomeID`=" & LabInID.Text & "", con)
            cmd.Parameters.Clear()
            'cmd.Parameters.AddWithValue("@uid", uid)
            cmd.Parameters.AddWithValue("@catid", ComIncome.Text)
            cmd.Parameters.AddWithValue("@amo", txtIncomeValue.Text)
            cmd.Parameters.AddWithValue("@des", RichDescription.Text)
            cmd.Parameters.AddWithValue("@indate", dateTimeIncome.Text)

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


    Private Sub DataGridViewIncome_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewIncome.CellClick

        Try
            'If e.RowIndex = -1 Then
            '    Exit Sub
            'End If

            'selectedID = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString().Trim()
            ''Me.Text = DataGridView1.CurrentRow.Cells(0).Value

            LabInID.Text = DataGridViewIncome.CurrentRow.Cells(0).Value.ToString()
            LabUID.Text = DataGridViewIncome.CurrentRow.Cells(1).Value.ToString()
            ComIncome.Text = DataGridViewIncome.CurrentRow.Cells(2).Value.ToString()
            txtIncomeValue.Text = DataGridViewIncome.CurrentRow.Cells(4).Value.ToString()
            RichDescription.Text = DataGridViewIncome.CurrentRow.Cells(3).Value
            dateTimeIncome.Text = DataGridViewIncome.CurrentRow.Cells(5).Value




        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnDeleteIncome_Click(sender As Object, e As EventArgs) Handles btnDeleteIncome.Click
        'intID = Convert.ToInt32(selectedID.ToString.Trim())
        If MsgBox("Are You Sure Delete This Record", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                ManageConnection()
                'conn.Open()
                'Dim cmd As New MySqlCommand("DELETE FROM `tbluser` WHERE `UserID`=" & LabID.Text & "", conn)
                Dim cmd As New MySqlCommand("DELETE FROM `tblincome` WHERE `IncomeID`=" & LabInID.Text & "", con)
                cmd.Parameters.Clear()
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("Record Deleted Success !", "Delete Income", MessageBoxButtons.OK, MessageBoxIcon.Information)
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


    'Private Sub BtnAdminClearField_Click(sender As Object, e As EventArgs) Handles BtnAdminClearField.Click
    '    clear()
    'End Sub

    'Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
    '    DGV_load()
    'End Sub

















    'Private selectedID As String = ""
    'Dim ParentDashboardBody As New FrmParentDashboardBody()


    'Private Sub FrmAddIncome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    ShowUserData()
    'End Sub

    'Private Sub ShowUserData()

    '    Dim ds1 As New DataSet()

    '    sql = "SELECT IncomeID, IncomeName, IncomeValue, IncomeDate, IncomeTotal FROM tblincome ORDER BY IncomeID ASC;"

    '    Try

    '        ds1 = DisplayData(sql, "tblincome", ds1)

    '        If ds1 Is Nothing Then
    '            'MsgBox("Error : Dataset was nothing!!!")
    '            Return
    '        End If

    '        'If have data then just show it
    '        If ds1.Tables("tblincome").Rows.Count > 0 Then
    '            DataGridViewIncome.DataSource = ds1.Tables("tblincome")
    '        Else
    '            DataGridViewIncome.DataSource = Nothing
    '        End If

    '        Dim dgv1 As DataGridView = DataGridViewIncome

    '        'If have data then just show it with custom Column HeaderText display
    '        If dgv1.Rows.Count > 0 Then
    '            dgv1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    '            dgv1.Columns(0).HeaderText = "ល.រ"

    '            dgv1.Columns(1).HeaderText = "ឈ្មោះចំណូល"
    '            dgv1.Columns(1).Width = 145

    '            dgv1.Columns(2).HeaderText = "ចំនួនទឹកប្រាក់"
    '            dgv1.Columns(2).Width = 145

    '            dgv1.Columns(3).HeaderText = "កាលបរិច្ឆេទ"
    '            dgv1.Columns(3).Width = 145

    '            dgv1.Columns(4).HeaderText = "សរុបចំណូល"
    '            dgv1.Columns(4).Width = 145

    '            dgv1.Columns(0).Visible = False

    '            dgv1.Columns(4).Visible = False



    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show("Error: " & ex.Message.ToString(), "Error Message.",
    '        MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    'Private Sub btnAddNewIncom_Click(sender As Object, e As EventArgs) Handles btnAddNewIncom.Click
    '    SaveUserData("INSERT")

    '    ParentDashboardBody.TotalIncome()


    'End Sub

    'Private Sub btnEditIncome_Click(sender As Object, e As EventArgs) Handles btnEditIncome.Click
    '    SaveUserData("UPDATE")
    'End Sub

    'Private Sub btnDeleteIncome_Click(sender As Object, e As EventArgs) Handles btnDeleteIncome.Click
    '    SaveUserData("DELETE")
    'End Sub

    'Private Sub btnClearIncomeField_Click(sender As Object, e As EventArgs) Handles btnClearIncomeField.Click
    '    ClearControls()
    'End Sub

    'Private Sub ClearControls()

    '    selectedID = ""

    '    txtIncomeName.Text = ""
    '    txtIncomeValue.Text = ""
    '    'txtTotalIncome.Text = ""
    '    dateTimeIncome.Text = ""

    '    'If dateTimeIncome.Value > 0 Then
    '    '    dateTimeIncome.Value = ""
    '    'End If

    '    'ToolStripStatusLabel1.Text = "Status:"

    'End Sub

    'Private Sub SaveUserData(dbCommand As String)

    '    Try

    '        If dbCommand.ToUpper() = "UPDATE" Or dbCommand.ToUpper() = "DELETE" Then
    '            If selectedID = "" Then
    '                MessageBox.Show("ID not found. Please select at least one item.", appTitle1,
    '                                MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                Return
    '            End If
    '        End If

    '        If dbCommand.ToUpper() = "INSERT" Or dbCommand.ToUpper() = "UPDATE" Then

    '            If txtIncomeName.Text.Trim() = "" Then
    '                MessageBox.Show("Please input Income Name.", appTitle1, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                txtIncomeName.Focus()
    '                Exit Sub
    '            End If

    '            If txtIncomeValue.Text.Trim() = "" Then
    '                MessageBox.Show("Please input income value.", appTitle1, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                txtIncomeValue.Focus()
    '                Exit Sub
    '            End If

    '        End If

    '        If dbCommand.ToUpper() <> "DELETE" Then

    '            If dateTimeIncome.Text = "" Then
    '                MessageBox.Show("Please select the date.", appTitle1, MessageBoxButtons.OK, MessageBoxIcon.Information)

    '                Return

    '            End If

    '        End If

    '        Dim intID As Integer

    '        Select Case dbCommand.ToUpper()

    '            Case "INSERT"

    '                If MessageBox.Show("Do you want to add this new income?",
    '                                   "Add New Income : Into Access Database.",
    '                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question,
    '                                   MessageBoxDefaultButton.Button2) = DialogResult.No Then

    '                    Exit Sub

    '                End If

    '                sql = "INSERT INTO tblincome(IncomeName, IncomeValue, IncomeDate) "
    '                sql &= " VALUES('" & txtIncomeName.Text.Trim() & "', '" & txtIncomeValue.Text.Trim() & "', "
    '                sql &= "'" & dateTimeIncome.Text & "')"

    '            Case "UPDATE"

    '                If MessageBox.Show("Do you want to update the selected record?", appTitle1, MessageBoxButtons.YesNo,
    '                                   MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
    '                    Exit Sub
    '                End If

    '                intID = Convert.ToInt32(selectedID.ToString().Trim())

    '                sql = "UPDATE tblincome SET IncomeName = '" & txtIncomeName.Text.Trim() & "', "
    '                sql &= "IncomeValue = '" & txtIncomeValue.Text.Trim() & "', "
    '                sql &= "IncomeDate = '" & dateTimeIncome.Text & "' "
    '                sql &= "WHERE IncomeID = " & intID & ""

    '                'If currentUserID = selectedID Then
    '                '    currentUsername = txtAddUser.Text.Trim()
    '                '    currentPermission = comAddPermission.SelectedItem.ToString().Trim()
    '                'End If

    '            Case "DELETE"

    '                'If currentUserID = selectedID Then
    '                '    MessageBox.Show("Error Deleting Record: " & "The user " & Chr(39) & currentUsername & Chr(39) &
    '                '                    " Is currently logged in.", appTitle1, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                '    Exit Sub
    '                'End If

    '                If MessageBox.Show("Do you want to delete the selected record?", appTitle1, MessageBoxButtons.YesNo,
    '                                   MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
    '                    Exit Sub
    '                End If

    '                intID = Convert.ToInt32(selectedID.ToString().Trim())

    '                sql = "DELETE FROM tblincome WHERE IncomeID = " & intID & ""

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

    'Private Sub DataGridViewIncome_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewIncome.CellDoubleClick

    '    Try

    '        If e.RowIndex = -1 Then
    '            Exit Sub
    '        End If

    '        selectedID = DataGridViewIncome.Rows(e.RowIndex).Cells(0).Value.ToString().Trim()

    '        'ToolStripStatusLabel1.Text = "Selected ID: " & selectedID

    '        txtIncomeName.Text = DataGridViewIncome.Rows(e.RowIndex).Cells(1).Value.ToString().Trim()
    '        txtIncomeValue.Text = DataGridViewIncome.Rows(e.RowIndex).Cells(2).Value.ToString().Trim()
    '        FormatDateTime(dateTimeIncome.Text = DataGridViewIncome.Rows(e.RowIndex).Cells(3).Value, "yyyy-MM-dd")

    '        'If Convert.ToString(DataGridViewIncome.CurrentRow.Cells(3).Value).Trim() = "admin" Then
    '        '    comAddPermission.SelectedIndex = 1 ' Admin
    '        'ElseIf Convert.ToString(DataGridViewIncome.CurrentRow.Cells(3).Value).Trim() = "parent" Then
    '        '    comAddPermission.SelectedIndex = 2 ' Parent
    '        'Else
    '        '    comAddPermission.SelectedIndex = 3 ' User
    '        'End If

    '    Catch ex As Exception

    '    End Try

    'End Sub

    ''Private Sub GetDataToListView()
    ''    LVIncome.Items.Clear()
    ''    Try
    ''        conn = New MySqlConnection
    ''        conn.ConnectionString = My.Settings.Conn
    ''        conn.Open()
    ''        Dim SqlStr As String
    ''        'SqlStr = "SELECT tbl_incomes.*,users.first_name FROM tbl_incomes INNER JOIN users ON tbl_incomes.user_id=users.id"
    ''        SqlStr = "SELECT tbl_incomes.*,users.first_name,categories.cat_code,categories.cat_name,categories.cat_note FROM tbl_incomes INNER JOIN users ON tbl_incomes.user_id=users.id INNER JOIN categories ON tbl_incomes.cat_id=categories.cat_id"
    ''        cmd = New MySqlCommand(SqlStr, conn)
    ''        dr = cmd.ExecuteReader
    ''        Dim list As ListViewItem
    ''        Do While dr.Read = True
    ''            list = New ListViewItem(dr(0).ToString)
    ''            list.SubItems.Add(dr(5))
    ''            list.SubItems.Add(dr(7) & "-" & dr(8))
    ''            list.SubItems.Add(dr(3))
    ''            list.SubItems.Add(dr(4))
    ''            'list.SubItems.Add(dr(4))
    ''            LVIncome.Items.Add(list)
    ''        Loop

    ''    Catch ex As Exception
    ''        conn.Close()
    ''        MsgBox(ex.Message)
    ''        Exit Try
    ''    End Try
    ''End Sub

End Class