Imports System.Data.SQLite
Imports System.IO
Public Class reportSales
    Private dbName As String = "Items.Db"
    Private dbPath As String = Path.Combine(Application.StartupPath, dbName)
    Private conString As String = "Data Source=" & dbPath & ";Version=3"
    Private loginDbName As String = "logIn.Db"
    Private loginDbPath As String = Path.Combine(Application.StartupPath, loginDbName)
    Private loginConString As String = "Data Source=" & loginDbPath & ";Version=3"
    Private connection As New SQLiteConnection(conString)
    Private loginConnection As New SQLiteConnection(loginConString)
    Private command As New SQLiteCommand("", connection)
    Private loginCommand As New SQLiteCommand("", loginConnection)

    Private Sub reportsSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSalesData()
        LoadTransactionLog()
        LoadLoginHistory()
    End Sub

    Private Sub LoadSalesData()
        Try
            connection.Open()

            command.CommandText = "SELECT * FROM SalesTransactions"
            Dim rdr As SQLiteDataReader = command.ExecuteReader()
            Dim table As New DataTable
            table.Load(rdr)

            DTGV.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Error loading sales data: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub LoadTransactionLog()
        Try
            ' Connect to the database
            Using connection As New SQLiteConnection(conString)
                connection.Open()

                ' Select all records from the TransactionLog table
                Dim command As New SQLiteCommand("SELECT * FROM TransactionLog ORDER BY LogDate DESC", connection)
                Dim adapter As New SQLiteDataAdapter(command)
                Dim dataTable As New DataTable
                adapter.Fill(dataTable)

                ' Bind the data to the DataGridView
                dataGridViewTransactionLog.DataSource = dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading transaction log: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadLoginHistory()
        Try
            ' Open the loginConnection explicitly
            loginConnection.Open()

            ' Fetch data from LoginHistory table in logIn.Db
            loginCommand.CommandText = "SELECT * FROM LoginHistory"
            Dim rdr As SQLiteDataReader = loginCommand.ExecuteReader()
            Dim table As New DataTable
            table.Load(rdr)

            ' Display data in DataGridView
            dataGridViewHistory.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error loading login history: " & ex.Message)
        Finally
            ' Always close the loginConnection, whether there's an exception or not
            loginConnection.Close()
        End Try
    End Sub



    Private Sub btnDeleteData_Click(sender As Object, e As EventArgs) Handles btnDeleteData.Click
        Dim tableName As String = txtbxTableName.Text.Trim()

        If String.IsNullOrEmpty(tableName) Then
            MessageBox.Show("Please enter a table name.")
            Return
        End If

        Try
            connection.Open()

            ' Construct and execute the DELETE statement
            command.CommandText = $"DELETE FROM {tableName}"
            command.ExecuteNonQuery()

            MessageBox.Show($"Data from table '{tableName}' deleted successfully.")
        Catch ex As Exception
            MessageBox.Show($"Error deleting data: {ex.Message}")
        Finally
            connection.Close()
            ' Refresh data after deletion
            LoadSalesData()
        End Try
        txtbxTableName.Clear()
    End Sub


    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Hide()
        dashboard.Show()
    End Sub

    Private Sub btnContacts_Click(sender As Object, e As EventArgs) Handles btnContacts.Click
        Me.Hide()
        contacts.Show()
    End Sub

    Private Sub btnBilling_Click(sender As Object, e As EventArgs) Handles btnBilling.Click
        Me.Hide()
        billing.Show()
    End Sub

    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        Me.Hide()
        items.Show()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ' Refresh all data
        LoadSalesData()
        LoadTransactionLog()
        LoadLoginHistory()
        txtbxTableName.Clear()
        MessageBox.Show("Data refreshed successfully.")
    End Sub


End Class