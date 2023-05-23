Public Class FrmAddExpense

    Private selectedID As String = ""
    Dim ParentDashboardBody As New FrmParentDashboardBody()

    Private Sub FrmAddExpense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowUserData()
    End Sub

    Private Sub ShowUserData()

        Dim ds1 As New DataSet()

        sql = "SELECT ExpenseID, ExpenseName, ExpenseValue, ExpenseDate, ExpenseTotal FROM tblexpense ORDER BY ExpenseID ASC;"

        Try

            ds1 = DisplayData(sql, "tblexpense", ds1)

            If ds1 Is Nothing Then
                'MsgBox("Error : Dataset was nothing!!!")
                Return
            End If

            'If have data then just show it
            If ds1.Tables("tblexpense").Rows.Count > 0 Then
                DataGridViewExpense.DataSource = ds1.Tables("tblexpense")
            Else
                DataGridViewExpense.DataSource = Nothing
            End If

            Dim dgv1 As DataGridView = DataGridViewExpense

            'If have data then just show it with custom Column HeaderText display
            If dgv1.Rows.Count > 0 Then
                dgv1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

                dgv1.Columns(0).HeaderText = "ល.រ"

                dgv1.Columns(1).HeaderText = "ឈ្មោះចំណាយ"
                dgv1.Columns(1).Width = 145

                dgv1.Columns(2).HeaderText = "ចំនួនទឹកប្រាក់"
                dgv1.Columns(2).Width = 145

                dgv1.Columns(3).HeaderText = "កាលបរិច្ឆេទ"
                dgv1.Columns(3).Width = 145

                dgv1.Columns(4).HeaderText = "សរុបចំណាយ"
                dgv1.Columns(4).Width = 145

                dgv1.Columns(0).Visible = False

                dgv1.Columns(4).Visible = False



            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message.ToString(), "Error Message.",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnAddNewExpense_Click(sender As Object, e As EventArgs) Handles btnAddNewExpense.Click
        SaveUserData("INSERT")

        ParentDashboardBody.TotalExpense()


    End Sub

    Private Sub btnEditExpense_Click(sender As Object, e As EventArgs) Handles btnEditExpense.Click
        SaveUserData("UPDATE")
    End Sub

    Private Sub btnDeleteExpense_Click(sender As Object, e As EventArgs) Handles btnDeleteExpense.Click
        SaveUserData("DELETE")
    End Sub

    Private Sub btnClearExpenseField_Click(sender As Object, e As EventArgs) Handles btnClearExpenseField.Click
        ClearControls()
    End Sub

    Private Sub ClearControls()

        selectedID = ""

        txtExpenseName.Text = ""
        txtExpenseValue.Text = ""
        txtTotalExpense.Text = ""
        dateTimeExpense.Text = ""

        'If dateTimeIncome.Value > 0 Then
        '    dateTimeIncome.Value = ""
        'End If

        'ToolStripStatusLabel1.Text = "Status:"

    End Sub

    Private Sub SaveUserData(dbCommand As String)

        Try

            If dbCommand.ToUpper() = "UPDATE" Or dbCommand.ToUpper() = "DELETE" Then
                If selectedID = "" Then
                    MessageBox.Show("ID not found. Please select at least one item.", appTitle1,
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If
            End If

            If dbCommand.ToUpper() = "INSERT" Or dbCommand.ToUpper() = "UPDATE" Then

                If txtExpenseName.Text.Trim() = "" Then
                    MessageBox.Show("Please input Expense Name.", appTitle1, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtExpenseName.Focus()
                    Exit Sub
                End If

                If txtExpenseValue.Text.Trim() = "" Then
                    MessageBox.Show("Please input Expense value.", appTitle1, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtExpenseValue.Focus()
                    Exit Sub
                End If

            End If

            If dbCommand.ToUpper() <> "DELETE" Then

                If dateTimeExpense.Text = "" Then
                    MessageBox.Show("Please select the date.", appTitle1, MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Return

                End If

            End If

            Dim intID As Integer

            Select Case dbCommand.ToUpper()

                Case "INSERT"

                    If MessageBox.Show("Do you want to add this new Expense?",
                                       "Add New Expense : Into Access Database.",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                       MessageBoxDefaultButton.Button2) = DialogResult.No Then

                        Exit Sub

                    End If

                    sql = "INSERT INTO tblexpense(ExpenseName, ExpenseValue, ExpenseDate) "
                    sql &= " VALUES('" & txtExpenseName.Text.Trim() & "', '" & txtExpenseValue.Text.Trim() & "', "
                    sql &= "'" & dateTimeExpense.Text & "')"

                Case "UPDATE"

                    If MessageBox.Show("Do you want to update the selected record?", appTitle1, MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                        Exit Sub
                    End If

                    intID = Convert.ToInt32(selectedID.ToString().Trim())

                    sql = "UPDATE tblexpense SET ExpenseName = '" & txtExpenseName.Text.Trim() & "', "
                    sql &= "ExpenseValue = '" & txtExpenseValue.Text.Trim() & "', "
                    sql &= "ExpenseDate = '" & dateTimeExpense.Text & "' "
                    sql &= "WHERE ExpenseID = " & intID & ""

                    'If currentUserID = selectedID Then
                    '    currentUsername = txtAddUser.Text.Trim()
                    '    currentPermission = comAddPermission.SelectedItem.ToString().Trim()
                    'End If

                Case "DELETE"

                    'If currentUserID = selectedID Then
                    '    MessageBox.Show("Error Deleting Record: " & "The user " & Chr(39) & currentUsername & Chr(39) &
                    '                    " Is currently logged in.", appTitle1, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    '    Exit Sub
                    'End If

                    If MessageBox.Show("Do you want to delete the selected record?", appTitle1, MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                        Exit Sub
                    End If

                    intID = Convert.ToInt32(selectedID.ToString().Trim())

                    sql = "DELETE FROM tblexpense WHERE ExpenseID = " & intID & ""

            End Select

            If ExecuteDb(sql) = True Then
                selectedID = ""
                MessageBox.Show("Your SQL " & dbCommand & " QUERY has been executed successfully.",
                                appTitle1withDb, MessageBoxButtons.OK, MessageBoxIcon.Information)
                ShowUserData()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message.ToString(), appTitle1, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

    End Sub


    Private Sub DataGridViewExpense_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewExpense.CellDoubleClick

        Try

            If e.RowIndex = -1 Then
                Exit Sub
            End If

            selectedID = DataGridViewExpense.Rows(e.RowIndex).Cells(0).Value.ToString().Trim()

            'ToolStripStatusLabel1.Text = "Selected ID: " & selectedID

            txtExpenseName.Text = DataGridViewExpense.Rows(e.RowIndex).Cells(1).Value.ToString().Trim()
            txtExpenseValue.Text = DataGridViewExpense.Rows(e.RowIndex).Cells(2).Value.ToString().Trim()
            FormatDateTime(dateTimeExpense.Text = DataGridViewExpense.Rows(e.RowIndex).Cells(3).Value, "yyyy-MM-dd")

            'If Convert.ToString(DataGridViewIncome.CurrentRow.Cells(3).Value).Trim() = "admin" Then
            '    comAddPermission.SelectedIndex = 1 ' Admin
            'ElseIf Convert.ToString(DataGridViewIncome.CurrentRow.Cells(3).Value).Trim() = "parent" Then
            '    comAddPermission.SelectedIndex = 2 ' Parent
            'Else
            '    comAddPermission.SelectedIndex = 3 ' User
            'End If

        Catch ex As Exception

        End Try

    End Sub
End Class