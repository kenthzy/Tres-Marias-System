Imports System.Data.SQLite
Imports System.IO
Imports ClosedXML.Excel
Public Class items
    Private dbCommand As String = ""
    Private bindingSrc As BindingSource

    Private dbName As String = "Items.Db"
    Private dbPath As String = Path.Combine(Application.StartupPath, dbName)

    Private conString As String = "Data Source=" & dbPath & ";Version=3"

    Private connection As New SQLiteConnection(conString)
    Private command As New SQLiteCommand("", connection)




    Private Sub items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection.Open()

            If connection.State = ConnectionState.Open Then
                command.Connection = connection
                command.CommandText = "SELECT * FROM ItemsInventory"

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


    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        ' Check if the required textboxes are not empty
        If txtItemName.Text <> "" AndAlso txtCategory.Text <> "" AndAlso txtPrice.Text <> "" AndAlso txtStocks.Text <> "" AndAlso txtManufacturer.Text <> "" Then
            ' Create a parameterized SQL query to avoid SQL injection
            dbCommand = "INSERT INTO ItemsInventory ([ITEM NAME], CATEGORY, PRICE, STOCKS, MANUFACTURER) VALUES (@itemName, @category, @price, @stocks, @manufacturer)"

            ' Set up the command
            command.CommandText = dbCommand
            command.Parameters.AddWithValue("@itemName", txtItemName.Text)
            command.Parameters.AddWithValue("@category", txtCategory.Text)
            command.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text))
            command.Parameters.AddWithValue("@stocks", Convert.ToInt32(txtStocks.Text))
            command.Parameters.AddWithValue("@manufacturer", txtManufacturer.Text)

            ' Execute the query
            Try
                command.ExecuteNonQuery()
                MessageBox.Show("Item added successfully!")
            Catch ex As Exception
                MessageBox.Show("Error adding item: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please fill in all required fields.")
        End If

        txtItemName.Clear()
        txtCategory.Clear()
        txtProductNo.Clear()
        txtStocks.Clear()
        txtManufacturer.Clear()
        txtPrice.Clear()
        connection.Close()
        RefreshDataGridView()
        LogTransaction($"Added item: {txtItemName.Text}")
    End Sub

    Private Sub RefreshDataGridView()
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            command.CommandText = "SELECT * FROM ItemsInventory"
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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Check if a row is selected in the DataGridView
        If DTGV.SelectedRows.Count > 0 Then
            ' Get the selected row index
            Dim selectedIndex As Integer = DTGV.SelectedRows(0).Index

            ' Confirm update with the user
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this item?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                ' Update the record in the database
                Dim itemId As Integer = Convert.ToInt32(DTGV.Rows(selectedIndex).Cells("PRODUCT #").Value)
                UpdateItem(itemId)

                ' Refresh DataGridView after update
                RefreshDataGridView()

                MessageBox.Show("Item updated successfully!")
            End If
        Else
            MessageBox.Show("Please select a row to update.")
        End If
        txtItemName.Clear()
        txtCategory.Clear()
        txtProductNo.Clear()
        txtStocks.Clear()
        txtManufacturer.Clear()
        txtPrice.Clear()
        LogTransaction($"Updated item: {txtItemName.Text}")
    End Sub

    Private Sub UpdateItem(itemId As Integer)
        ' Update the record with the specified ID in the database
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Create a parameterized SQL query to avoid SQL injection
            dbCommand = "UPDATE ItemsInventory SET [ITEM NAME] = @itemName, CATEGORY = @category, PRICE = @price, STOCKS = @stocks, MANUFACTURER = @manufacturer WHERE [PRODUCT #] = @itemId"

            ' Set up the command
            command.CommandText = dbCommand
            command.Parameters.AddWithValue("@itemName", txtItemName.Text)
            command.Parameters.AddWithValue("@category", txtCategory.Text)
            command.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text))
            command.Parameters.AddWithValue("@stocks", Convert.ToInt32(txtStocks.Text))
            command.Parameters.AddWithValue("@manufacturer", txtManufacturer.Text)
            command.Parameters.AddWithValue("@itemId", itemId)

            ' Execute the query
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error updating item: " & ex.Message)
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
                Dim itemId As Integer = Convert.ToInt32(DTGV.Rows(selectedIndex).Cells(0).Value) ' Assuming the Item ID is in the first column
                DeleteItem(itemId)

                ' Refresh DataGridView after deletion
                RefreshDataGridView()

                MessageBox.Show("Item deleted successfully!")
            End If
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
        txtItemName.Clear()
        txtCategory.Clear()
        txtStocks.Clear()
        txtManufacturer.Clear()
        txtPrice.Clear()
    End Sub

    Private Sub DeleteItem(itemId As Integer)
        ' Delete the record with the specified ID from the database
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            command.CommandText = "DELETE FROM ItemsInventory WHERE [PRODUCT #] = @itemId"
            command.Parameters.AddWithValue("@itemId", itemId)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error deleting item: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        LogTransaction($"Deleted item with ID: {itemId}")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Try
            ' Check if the search textbox is not empty
            If Not String.IsNullOrEmpty(txtSearch.Text) Then
                ' Create a parameterized SQL query with a LIKE clause
                command.CommandText = "SELECT * FROM ItemsInventory WHERE [ITEM NAME] LIKE @searchTerm OR CATEGORY LIKE @searchTerm OR MANUFACTURER LIKE @searchTerm"
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

    Private Sub btnBilling_Click(sender As Object, e As EventArgs) Handles btnBilling.Click
        Me.Hide()
        billing.Show()
    End Sub

    Private Sub btnContacts_Click(sender As Object, e As EventArgs) Handles btnContacts.Click
        Me.Hide()
        contacts.Show()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Hide()
        dashboard.Show()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtItemName.Clear()
        txtCategory.Clear()
        txtProductNo.Clear()
        txtStocks.Clear()
        txtManufacturer.Clear()
        txtPrice.Clear()
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Create a new SaveFileDialog
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx"
            saveFileDialog.Title = "Save Inventory Report"
            saveFileDialog.FileName = "InventoryExport.xlsx"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                ' User selected a location to save the file
                Dim excelFilePath As String = saveFileDialog.FileName

                ' Create a new workbook
                Using workbook As New XLWorkbook()
                    ' Create a worksheet
                    Dim worksheet As IXLWorksheet = workbook.Worksheets.Add("Inventory")

                    ' Add a title to the worksheet
                    worksheet.Cell("A1").Value = "TRES MARIAS INVENTORY REPORT"
                    worksheet.Range("A1:F1").Merge() ' Merge cells for the title
                    worksheet.Cell("A1").Style.Font.Bold = True
                    worksheet.Cell("A1").Style.Font.FontSize = 16
                    worksheet.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center ' Center the title

                    ' Add the inventory report date
                    worksheet.Cell("A2").Value = "As of: " & DateTimePicker1.Value.ToString("MMMM dd, yyyy")
                    worksheet.Range("A2:F2").Merge() ' Merge cells for the date
                    worksheet.Cell("A2").Style.Font.Italic = True
                    worksheet.Cell("A2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center ' Center the date

                    ' Add headers to the worksheet
                    For colIndex As Integer = 1 To DTGV.Columns.Count
                        worksheet.Cell(3, colIndex).Value = " " & DTGV.Columns(colIndex - 1).HeaderText & " " ' Add spaces inside the cell

                        ' Apply styles to the header row
                        worksheet.Cell(3, colIndex).Style.Font.Bold = True
                        worksheet.Cell(3, colIndex).Style.Fill.BackgroundColor = XLColor.LightBlue
                        worksheet.Cell(3, colIndex).Style.Alignment.WrapText = True ' Enable word wrap

                        ' Adjust column width for all columns
                        If colIndex >= 2 AndAlso colIndex <= 6 Then
                            worksheet.Column(colIndex).Width = 30 ' Adjust width for columns 2 to 6
                        Else
                            worksheet.Column(colIndex).Width = 15 ' Default width for other columns
                        End If
                    Next

                    ' Add data to the worksheet
                    For rowIndex As Integer = 0 To DTGV.Rows.Count - 1
                        For colIndex As Integer = 0 To DTGV.Columns.Count - 1
                            Dim cellValue As String = DTGV.Rows(rowIndex).Cells(colIndex).Value.ToString()

                            ' Add spaces inside the cell
                            worksheet.Cell(rowIndex + 4, colIndex + 1).Value = " " & cellValue & " "
                            worksheet.Cell(rowIndex + 4, colIndex + 1).Style.Alignment.WrapText = True ' Enable word wrap

                            ' Apply colors to "STOCKS" and "PRICE" columns
                            If DTGV.Columns(colIndex).Name.ToUpper() = "STOCKS" Then
                                worksheet.Cell(rowIndex + 4, colIndex + 1).Style.Fill.BackgroundColor = XLColor.Yellow
                            ElseIf DTGV.Columns(colIndex).Name.ToUpper() = "PRICE" Then
                                worksheet.Cell(rowIndex + 4, colIndex + 1).Style.Fill.BackgroundColor = XLColor.GreenYellow
                            End If
                        Next
                    Next



                    ' Auto adjust column widths to fit contents
                    worksheet.Columns().AdjustToContents()
                    workbook.SaveAs(excelFilePath)

                    MessageBox.Show("Inventory exported to Excel successfully: " & excelFilePath)
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error exporting inventory to Excel: " & ex.Message)
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
            txtProductNo.Text = selectedRow.Cells("PRODUCT #").Value.ToString()
            txtItemName.Text = selectedRow.Cells("ITEM NAME").Value.ToString()
            txtCategory.Text = selectedRow.Cells("CATEGORY").Value.ToString()
            txtPrice.Text = selectedRow.Cells("PRICE").Value.ToString()
            txtStocks.Text = selectedRow.Cells("STOCKS").Value.ToString()
            txtManufacturer.Text = selectedRow.Cells("MANUFACTURER").Value.ToString()
        End If
    End Sub

    Private Sub LogTransaction(logMessage As String)
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Create a parameterized SQL query to insert a log entry
            dbCommand = "INSERT INTO TransactionLog (LogMessage, LogDate) VALUES (@logMessage, @logDate)"

            ' Set up the command
            command.CommandText = dbCommand
            command.Parameters.AddWithValue("@logMessage", logMessage)
            command.Parameters.AddWithValue("@logDate", DateTime.Now)

            ' Execute the query
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error logging transaction: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
End Class

