Imports System.Data.SQLite
Imports System.IO


Public Class contacts
    Private dbCommand As String = ""
    Private bindingSrc As BindingSource

    Private dbName As String = "contacts.Db"
    Private dbPath As String = Path.Combine(Application.StartupPath, dbName)

    Private conString As String = "Data Source=" & dbPath & ";Version=3"

    Private connection As New SQLiteConnection(conString)
    Private command As New SQLiteCommand("", connection)

    Private Sub contacts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection.Open()

            If connection.State = ConnectionState.Open Then
                command.Connection = connection
                command.CommandText = "SELECT * FROM contacts"

                Dim rdr As SQLiteDataReader = command.ExecuteReader
                Dim table As New DataTable
                table.Load(rdr)

                DTGV.DataSource = table
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading items: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub RefreshDataGridView()
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            command.CommandText = "SELECT * FROM contacts"
            Dim rdr As SQLiteDataReader = command.ExecuteReader
            Dim table As New DataTable
            table.Load(rdr)
            DTGV.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error refreshing data: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Hide()
        dashboard.Show()
    End Sub

    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        Me.Hide()
        items.Show()
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Me.Hide()
        billing.Show()
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim name As String = txtName.Text
        Dim number As String = txtPhoneNo.Text
        Dim type As String = comboBoxType.Text
        Dim sex As String = comboBoxSex.Text

        Try
            connection.Open()

            ' Use parameterized query to prevent SQL injection
            command.CommandText = "INSERT INTO contacts (Name, Number, Type, Sex) VALUES (@Name, @Number, @Type, @Sex)"
            command.Parameters.AddWithValue("@Name", name)
            command.Parameters.AddWithValue("@Number", txtPhoneNo.Text)
            command.Parameters.AddWithValue("@Type", type)
            command.Parameters.AddWithValue("@Sex", sex)

            command.ExecuteNonQuery()

            ' Refresh the DataGridView after adding a new contact
            RefreshDataGridView()

            ' Clear the input fields after adding
            txtName.Text = ""
            txtPhoneNo.Text = ""
            comboBoxType.Text = ""
            comboBoxSex.Text = ""
        Catch ex As Exception
            MessageBox.Show("Error adding contact: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub DTGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGV.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DTGV.Rows(e.RowIndex)

            ' Fill the textboxes with the selected row's data
            txtName.Text = selectedRow.Cells("Name").Value.ToString()
            txtPhoneNo.Text = selectedRow.Cells("Number").Value.ToString()
            comboBoxType.Text = selectedRow.Cells("Type").Value.ToString()
            comboBoxSex.Text = selectedRow.Cells("Sex").Value.ToString()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Try
            ' Check if the search textbox is not empty
            If Not String.IsNullOrEmpty(txtSearch.Text) Then
                ' Create a parameterized SQL query with a LIKE clause
                command.CommandText = "SELECT * FROM contacts WHERE [Name] LIKE @searchTerm OR Number LIKE @searchTerm OR Type LIKE @searchTerm"
                command.Parameters.AddWithValue("@searchTerm", "%" & txtSearch.Text & "%")

                Dim rdr As SQLiteDataReader = command.ExecuteReader
                Dim table As New DataTable
                table.Load(rdr)

                If table.Rows.Count > 0 Then
                    DTGV.DataSource = table
                Else
                    MessageBox.Show("No matching items found.")
                End If
            Else
                MessageBox.Show("Please enter a search term.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error searching items: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Private Sub DeleteItem(itemId As Integer)
        ' Delete the record with the specified ID from the database
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            command.CommandText = "DELETE FROM contacts WHERE [ID] = @itemId"
            command.Parameters.AddWithValue("@itemId", itemId)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error deleting item: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Check if a row is selected in the DataGridView
        If DTGV.SelectedRows.Count > 0 Then
            ' Get the selected row index
            Dim selectedIndex As Integer = DTGV.SelectedRows(0).Index

            ' Confirm deletion with the user
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                ' Delete the record from the database
                Dim itemId As Long = Convert.ToInt64(DTGV.Rows(selectedIndex).Cells(0).Value) ' Assuming the Item ID is in the first column
                DeleteItem(itemId)

                ' Refresh DataGridView after deletion
                RefreshDataGridView()

                MessageBox.Show("Item deleted successfully!")
            End If
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Check if a row is selected in the DataGridView
        If DTGV.SelectedRows.Count > 0 Then
            ' Get the selected row index
            Dim selectedIndex As Integer = DTGV.SelectedRows(0).Index

            ' Confirm update with the user
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this contact?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                ' Update the record in the database
                Dim contactId As Integer = Convert.ToInt32(DTGV.Rows(selectedIndex).Cells("ID").Value)
                UpdateContact(contactId)

                ' Refresh DataGridView after update
                RefreshDataGridView()

                MessageBox.Show("Contact updated successfully!")
            End If
        Else
            MessageBox.Show("Please select a row to update.")
        End If
    End Sub

    Private Sub UpdateContact(contactId As Integer)
        ' Update the record with the specified ID in the database
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Create a parameterized SQL query to avoid SQL injection
            command.CommandText = "UPDATE contacts SET Name = @Name, Number = @Number, Type = @Type, Sex = @Sex WHERE ID = @contactId"

            ' Set up the command
            command.Parameters.AddWithValue("@Name", txtName.Text)
            command.Parameters.AddWithValue("@Number", (txtPhoneNo.Text))
            command.Parameters.AddWithValue("@Type", comboBoxType.Text)
            command.Parameters.AddWithValue("@Sex", comboBoxSex.Text)
            command.Parameters.AddWithValue("@contactId", contactId)

            ' Execute the query
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error updating contact: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtName.Clear()
        txtPhoneNo.Clear()
        comboBoxType.SelectedIndex = -1
        comboBoxSex.SelectedIndex = -1
    End Sub
End Class