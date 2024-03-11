Imports System.Data.SQLite

Public Class dashboard
    Private totalItems As Integer
    Private totalCategories As Integer

    Private Sub LoadTotalItemsAndCategories()
        Try
            ' Connect to the database
            Using connection As New SQLiteConnection("Data Source=Items.Db;Version=3")
                connection.Open()

                ' Count total items
                Dim commandItems As New SQLiteCommand("SELECT COUNT(*) FROM ItemsInventory", connection)
                totalItems = Convert.ToInt32(commandItems.ExecuteScalar())
                labelTotalItems.Text = totalItems.ToString()

                ' Count total categories
                Dim commandCategories As New SQLiteCommand("SELECT COUNT(DISTINCT CATEGORY) FROM ItemsInventory", connection)
                totalCategories = Convert.ToInt32(commandCategories.ExecuteScalar())
                labelTotalCategory.Text = totalCategories.ToString()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading total items and categories: " & ex.Message)
        End Try
    End Sub


    Private Sub btnBilling_Click(sender As Object, e As EventArgs) Handles btnBilling.Click
        Me.Hide()
        billing.ShowDialog()
    End Sub

    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        Me.Hide()
        items.ShowDialog()
    End Sub

    Private Sub btnContacts_Click(sender As Object, e As EventArgs) Handles btnContacts.Click
        Me.Hide()
        contacts.ShowDialog()
    End Sub





    Private Sub btnNote_Click(sender As Object, e As EventArgs) Handles btnNote.Click
        MsgBox("
    Developer's Note:

    Thank you for choosing Safe System! 

    I wish your business success as you utilize my inventory system 
    software to efficiently handle stock management,
    providing real-time insights into product quantities. 

    The current version include point-of-sale feature 
    and reports such as sales, inventory and all logins.
    also have the fundamentals of a straightforward
    inventory system suitable for your shop. 

   The system incorporates measures to guard against SQL injection
   ensuring the security of data and preventing 
   potential unauthorized access attempts by malicious entities 
   seeking to view sensitive information within the system. 

    Your continued support is appreciated. 
    Thank you for using my software!

    Dev, KG")
    End Sub

    Private Sub btnShutdown_Click_1(sender As Object, e As EventArgs) Handles btnShutdown.Click
        Application.Exit()
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        ' Prompt the user for a password
        Dim password As String = InputBox("Enter password:", "Password Required")

        ' Check if the entered password is correct
        If IsValidPassword(password) Then
            ' Password is correct, show the reportsSales form
            Me.Hide()
            reportSales.Show()
        Else
            ' Password is incorrect, show a message
            MessageBox.Show("Incorrect password. Access denied.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function IsValidPassword(enteredPassword As String) As Boolean
        ' Replace "YourActualPassword" with the actual password you want to check against
        Dim actualPassword As String = "va898900"
        Return enteredPassword = actualPassword
    End Function

    Private totalSalesThisMonth As Decimal = 0

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add the following code to load the total items, categories, and sales when the dashboard form loads
        LoadTotalItemsAndCategories()
        LoadTotalSalesThisMonth()

        ' Start a timer to check and reset total sales at the beginning of each month
        Dim timer As New Timer()
        AddHandler timer.Tick, AddressOf CheckAndResetTotalSales
        timer.Interval = 60000 ' Set the interval to 1 minute (adjust as needed)
        timer.Start()
    End Sub

    Private Sub LoadTotalSalesThisMonth()
        Try
            ' Connect to the database
            Using connection As New SQLiteConnection("Data Source=Items.Db;Version=3")
                connection.Open()

                ' Get the current month and year
                Dim currentMonth As Integer = DateTime.Now.Month
                Dim currentYear As Integer = DateTime.Now.Year

                ' Calculate the total sales for the current month
                Dim commandSales As New SQLiteCommand("SELECT SUM(TotalAmount) FROM SalesTransactions WHERE strftime('%Y-%m', TransactionDate) = @currentMonth", connection)
                commandSales.Parameters.AddWithValue("@currentMonth", $"{currentYear}-{currentMonth:D2}")
                Dim result As Object = commandSales.ExecuteScalar()

                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    totalSalesThisMonth = Convert.ToDecimal(result)
                    labelTotalSales.Text = $"₱ {totalSalesThisMonth.ToString("0.00")}"
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading total sales for the month: " & ex.Message)
        End Try
    End Sub

    Private Sub CheckAndResetTotalSales(sender As Object, e As EventArgs)
        ' Check if the current month has changed
        If DateTime.Now.Month <> DateTime.Today.Month Then
            ' Reset total sales for the new month
            totalSalesThisMonth = 0
            labelTotalSales.Text = "Total Sales: 0.00"
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadTotalItemsAndCategories()
        LoadTotalSalesThisMonth()
    End Sub

End Class