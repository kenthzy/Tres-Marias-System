Imports System.IO
Imports System.Data.SQLite
Imports System.Drawing.Printing

Public Class billing
    Private dbCommand As String = ""
    Private bindingSrc As BindingSource

    Private dbName As String = "Items.Db"
    Private dbPath As String = Path.Combine(Application.StartupPath, dbName)

    Private conString As String = "Data Source=" & dbPath & ";Version=3"

    Private connection As New SQLiteConnection(conString)
    Private command As New SQLiteCommand("", connection)

    Private Sub billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadItems()
    End Sub

    Private Sub LoadItems()
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
            connection.Close()
        End Try
    End Sub

    Private Sub DTGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGV.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DTGV.Rows(e.RowIndex)
            textItemName.Text = selectedRow.Cells("ITEM NAME").Value.ToString()
            txtCategory.Text = selectedRow.Cells("CATEGORY").Value.ToString()
            txtManufacturer.Text = selectedRow.Cells("MANUFACTURER").Value.ToString()
            ' Assuming the price column is the fourth column (index 3), replace it with the actual column index
            Dim price As Decimal = Convert.ToDecimal(selectedRow.Cells(3).Value)
            txtPrice.Text = price.ToString("0.00") ' Adjust the format as needed
        End If
    End Sub


    Private Sub btnAddToBill_Click(sender As Object, e As EventArgs) Handles btnAddToBill.Click
        ' Add selected item to the client bill DataGridView
        Dim itemName As String = textItemName.Text
        Dim category As String = txtCategory.Text
        Dim quantity As Integer

        If Not Integer.TryParse(txtQuantity.Text, quantity) OrElse quantity <= 0 Then
            MessageBox.Show("Please enter a valid quantity.")
            Return
        End If

        Dim price As Decimal = Convert.ToDecimal(txtPrice.Text)
        Dim manufacturer As String = txtManufacturer.Text
        Dim total As Decimal = quantity * price

        ' Add a condition to check if the quantity is higher than available stocks
        Dim availableStocks As Integer = GetAvailableStocksForItem(itemName)
        If quantity > availableStocks Then
            MessageBox.Show("Invalid quantity. Insufficient stocks.")
            Return
        End If

        ' Add the item to the client bill DataGridView
        Dim newRow As String() = {itemName, category, price.ToString("0.00"), quantity.ToString(), manufacturer, total.ToString("0.00")}
        DTGVclientBill.Rows.Add(newRow)

        ' Update the total bill label
        UpdateTotalBillLabel()
        textItemName.Clear()
        txtCategory.Clear()
        txtQuantity.Clear()
        txtManufacturer.Clear()
        txtPrice.Clear()
    End Sub

    Private Function GetAvailableStocksForItem(itemName As String) As Integer
        ' Retrieve the available stocks for the specified item from your database
        ' You may need to implement a method to fetch the stocks for the item from your database
        ' Replace the code below with the actual code to fetch stocks for the item

        ' Example code (replace with actual database query)
        Dim availableStocks As Integer = 0

        Try
            connection.Open()
            command.CommandText = "SELECT STOCKS FROM ItemsInventory WHERE [ITEM NAME] = @itemName"
            command.Parameters.AddWithValue("@itemName", itemName)

            Dim result As Object = command.ExecuteScalar()

            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                availableStocks = Convert.ToInt32(result)
            End If
        Catch ex As Exception
            MessageBox.Show("Error fetching available stocks: " & ex.Message)
        Finally
            connection.Close()
        End Try

        Return availableStocks
    End Function

    Private Sub UpdateTotalBillLabel()
        ' Calculate and update the total bill label
        Dim totalBill As Decimal = 0

        For Each row As DataGridViewRow In DTGVclientBill.Rows
            Dim total As Decimal
            If Decimal.TryParse(row.Cells(5).Value.ToString(), total) Then
                totalBill += total
            End If
        Next

        labelTotalBill.Text = $"Total Bill: {totalBill.ToString("0.00")}"
    End Sub


    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        Me.Hide()
        items.Show()
    End Sub

    Private Sub btnContacts_Click(sender As Object, e As EventArgs) Handles btnContacts.Click
        Me.Hide()
        contacts.Show()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Close()
        dashboard.Show()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchItems(txtSearch.Text)
    End Sub

    Private Sub SearchItems(searchTerm As String)
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Try
            ' Create a parameterized SQL query with a LIKE clause
            command.CommandText = "SELECT * FROM ItemsInventory WHERE [ITEM NAME] LIKE @searchTerm OR CATEGORY LIKE @searchTerm OR MANUFACTURER LIKE @searchTerm"
            command.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")

            Dim rdr As SQLiteDataReader = command.ExecuteReader
            Dim table As New DataTable
            table.Load(rdr)

            If table.Rows.Count > 0 Then
                DTGV.DataSource = table
            Else
                MessageBox.Show("No matching items found.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error searching items: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' Check if there are items in the client bill DataGridView
        If DTGVclientBill.Rows.Count = 0 Then
            MessageBox.Show("No items to print.")
            Return
        End If

        ' Create a PrintDocument object
        Dim printDoc As New PrintDocument()

        ' Add an event handler for the PrintPage event
        AddHandler printDoc.PrintPage, AddressOf PrintPageHandler

        ' Print the document
        printDoc.Print()
        RefreshDataGridView()
    End Sub

    Private Sub PrintPageHandler(sender As Object, e As PrintPageEventArgs)
        ' Define the font and brush for drawing text
        Dim titleFont As New Font("Arial", 16, FontStyle.Bold)
        Dim columnNamesFont As New Font("Arial", 12, FontStyle.Bold)
        Dim contentFont As New Font("Arial", 12)
        Dim brush As New SolidBrush(Color.Black)

        ' Define the title and content for the receipt
        Dim title As String = "TRES MARIAS MOTORCYCLE PARTS AND SERVICES"
        Dim columnNames As String() = {"Item Name", "Category", "Price", "Quantity", "Manufacturer", "Total"}
        Dim content As String = $"Date: {DateTime.Now.ToShortDateString()}{Environment.NewLine}" &
                            $"Time: {DateTime.Now.ToShortTimeString()}{Environment.NewLine}{Environment.NewLine}" &
                            "Client Bill:" & Environment.NewLine

        ' Define the position for drawing text
        Dim posX As Single = e.MarginBounds.Left
        Dim posY As Single = e.MarginBounds.Top

        ' Define the cell width and height
        Dim cellWidth As Single = 120
        Dim cellHeight As Single = 25

        ' Draw the title
        e.Graphics.DrawString(title, titleFont, brush, posX, posY)

        ' Calculate the height of the title
        Dim titleHeight As Single = e.Graphics.MeasureString(title, titleFont).Height

        ' Update the Y position
        posY += titleHeight + 40 ' Add some spacing

        ' Draw the column names with lines
        For Each columnName In columnNames
            e.Graphics.DrawRectangle(Pens.Black, posX, posY, cellWidth, cellHeight)
            e.Graphics.DrawString(columnName, columnNamesFont, brush, posX + 5, posY + 5)
            posX += cellWidth
        Next

        ' Update the Y position
        posY += cellHeight + 10 ' Add some spacing

        ' Draw the content with lines
        For Each row As DataGridViewRow In DTGVclientBill.Rows
            posX = e.MarginBounds.Left ' Reset X position for each row
            For Each cell As DataGridViewCell In row.Cells
                e.Graphics.DrawRectangle(Pens.Black, posX, posY, cellWidth, cellHeight)
                e.Graphics.DrawString(cell.Value.ToString(), contentFont, brush, posX + 5, posY + 5)
                posX += cellWidth
            Next

            ' Move to the next row
            posY += cellHeight + 10 ' Add some spacing
        Next

        ' Check if another page is needed
        e.HasMorePages = False

        For Each row As DataGridViewRow In DTGVclientBill.Rows
            ' ... (previous code remains unchanged)
        Next

        ' Draw the Total Bill row
        posX = e.MarginBounds.Left
        posY += cellHeight + 10 ' Add some spacing

        ' Draw the cell for "Total Bill"
        e.Graphics.DrawRectangle(Pens.Black, posX, posY, cellWidth, cellHeight)
        e.Graphics.DrawString("Total Bill", columnNamesFont, brush, posX + 5, posY + 5)

        ' Draw the total amount from UpdateTotalBillLabel method
        posX += cellWidth
        e.Graphics.DrawRectangle(Pens.Black, posX, posY, cellWidth, cellHeight)
        e.Graphics.DrawString(labelTotalBill.Text.Replace("Total Bill: ", ""), contentFont, brush, posX + 5, posY + 5)

        ' Move to the next row
        posY += cellHeight + 10 ' Add some spacing

        ' Draw the date
        posX = e.MarginBounds.Left
        e.Graphics.DrawString($"Date: {DateTime.Now.ToShortDateString()}", contentFont, brush, posX, posY)

        ' Check if another page is needed
        e.HasMorePages = False
    End Sub



    Private Sub SubtractQuantityFromStocks(itemName As String, quantity As Integer)
        Try
            connection.Open()
            command.CommandText = "UPDATE ItemsInventory SET Stocks = Stocks - @quantity WHERE [ITEM NAME] = @itemName"
            command.Parameters.AddWithValue("@quantity", quantity)
            command.Parameters.AddWithValue("@itemName", itemName)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error subtracting quantity from stocks: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Clear textboxes
        textItemName.Clear()
        txtCategory.Clear()
        txtQuantity.Clear()
        txtManufacturer.Clear()
        txtPrice.Clear()
        labelTotalBill.Text = ""
        ' Clear other textboxes as needed

        ' Clear DataGridView
        DTGVclientBill.Rows.Clear()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshDataGridView()
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

    Private Sub btnConfirmOrder_Click(sender As Object, e As EventArgs) Handles btnConfirmOrder.Click
        If DTGVclientBill.Rows.Count = 0 Then
            MessageBox.Show("No items.")
            Return
        End If

        ' Initialize variables for the sales transaction
        Dim transactionDate As DateTime = DateTime.Now
        Dim totalAmount As Decimal = Convert.ToDecimal(labelTotalBill.Text.Replace("Total Bill: ", ""))
        Dim cash As Decimal = Convert.ToDecimal(txtCash.Text)
        Dim change As Decimal = cash - totalAmount

        ' Iterate through the client bill and record a sales transaction for each item
        For Each row As DataGridViewRow In DTGVclientBill.Rows
            Dim itemName As String = row.Cells(0).Value.ToString()
            Dim quantity As Integer = Convert.ToInt32(row.Cells(3).Value)

            ' Check if the quantity is greater than zero before recording the transaction
            If quantity > 0 Then
                ' Subtract it from available stocks
                SubtractQuantityFromStocks(itemName, quantity)

                ' Record the sales transaction
                RecordSalesTransaction(itemName, quantity, totalAmount, transactionDate, cash, change)
            End If
        Next

        ' Update the total bill label after subtracting quantities
        UpdateTotalBillLabel()

        ' Refresh the DataGridView
        RefreshDataGridView()
        textItemName.Clear()
        txtCategory.Clear()
        txtQuantity.Clear()
        txtManufacturer.Clear()
        txtPrice.Clear()
        labelTotalBill.Text = ""
        DTGVclientBill.Rows.Clear()
        txtCash.Clear()
        labelChange.Text = ""
    End Sub

    Private Sub RecordSalesTransaction(itemName As String, quantity As Integer, totalAmount As Decimal, transactionDate As DateTime, cash As Decimal, change As Decimal)
        Try
            connection.Open()

            ' Insert into SalesTransactions table
            command.CommandText = "INSERT INTO SalesTransactions (ItemName, Quantity, TotalAmount, TransactionDate, Cash, Change) VALUES (@itemName, @quantity, @totalAmount, @transactionDate, @cash, @change)"
            command.Parameters.AddWithValue("@itemName", itemName)
            command.Parameters.AddWithValue("@quantity", quantity)
            command.Parameters.AddWithValue("@totalAmount", totalAmount)
            command.Parameters.AddWithValue("@transactionDate", transactionDate)
            command.Parameters.AddWithValue("@cash", cash)
            command.Parameters.AddWithValue("@change", change)
            command.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Error recording sales transaction: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        If Not String.IsNullOrEmpty(labelTotalBill.Text) AndAlso Decimal.TryParse(txtCash.Text, Nothing) Then
            ' Calculate the change
            Dim totalBill As Decimal = Convert.ToDecimal(labelTotalBill.Text.Replace("Total Bill: ", ""))
            Dim cash As Decimal = Convert.ToDecimal(txtCash.Text)
            Dim change As Decimal = cash - totalBill

            ' Display the change in the labelChange
            labelChange.Text = $"Change: {change.ToString("0.00")}"
        Else
            ' Clear the labelChange if either the total bill label is empty or txtCash is not a valid numeric value
            labelChange.Text = "Change: "
        End If
    End Sub

    Private Sub RecordCashAndChange(itemName As String, quantity As Integer, totalAmount As Decimal, transactionDate As DateTime)
        Try
            connection.Open()

            ' Insert into SalesTransactions table
            command.CommandText = "INSERT INTO SalesTransactions (ItemName, Quantity, TotalAmount, TransactionDate, Cash, Change) VALUES (@itemName, @quantity, @totalAmount, @transactionDate, @cash, @change)"
            command.Parameters.AddWithValue("@itemName", itemName)
            command.Parameters.AddWithValue("@quantity", quantity)
            command.Parameters.AddWithValue("@totalAmount", totalAmount)
            command.Parameters.AddWithValue("@transactionDate", transactionDate)
            command.Parameters.AddWithValue("@cash", Convert.ToDecimal(txtCash.Text))
            command.Parameters.AddWithValue("@change", Convert.ToDecimal(labelChange.Text.Replace("Change: ", "")))
            command.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Error recording cash and change: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
End Class