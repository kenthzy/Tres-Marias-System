Imports System.Data.SQLite
Imports System.IO
Imports System.Web.UI.WebControls

Public Class login
    Private dbCommand As String = ""
    Private bindingSrc As BindingSource

    Private dbName As String = "logIn.Db"
    Private dbPath As String = Path.Combine(Application.StartupPath, dbName)

    Private conString As String = "Data Source=" & dbPath & ";Version=3"

    Private connection As New SQLiteConnection(conString)
    Private command As New SQLiteCommand("", connection)
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection.Open()

            If connection.State = ConnectionState.Open Then
                ' Removed unnecessary command and reader here
                MsgBox("Connection successful!") ' Optional feedback
            End If
        Catch ex As Exception
            MsgBox("Error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        register.Show()
        Me.Hide()
    End Sub


    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        If Not String.IsNullOrEmpty(txtbxusername.Text) And Not String.IsNullOrEmpty(txtPass.Text) Then
            Try
                connection.Open()
                Dim transaction As SQLiteTransaction = connection.BeginTransaction()

                ' Set command text before executing the command
                command.CommandText = "SELECT * FROM loginInfo WHERE userName = @username AND userPass = @password"
                command.Parameters.AddWithValue("@username", txtbxusername.Text)
                command.Parameters.AddWithValue("@password", txtPass.Text)

                Using reader As SQLiteDataReader = command.ExecuteReader()
                    reader.Read()

                    If reader.HasRows Then
                        ' Login successful - verify password for security
                        If reader("userPass").ToString() = txtPass.Text Then ' Replace "userPass" with your actual password column name
                            MsgBox("Login successful!")

                            ' Record login history within the same transaction
                            RecordLoginHistory(transaction, reader("userName").ToString())

                            Me.Hide()
                            dashboard.ShowDialog()
                        Else
                            MsgBox("Invalid username or password.")
                        End If
                    Else
                        MsgBox("Invalid username or password.")
                    End If
                End Using

                transaction.Commit()
            Catch ex As Exception
                MsgBox("Error occurred: " & ex.Message)
            Finally
                connection.Close()
            End Try
        Else
            MsgBox("Please enter both username and password.")
        End If
    End Sub

    Private Sub RecordLoginHistory(transaction As SQLiteTransaction, userName As String)
        Try
            ' Prepare the command for inserting into LoginHistory table
            Using insertCommand As New SQLiteCommand("INSERT INTO LoginHistory (userName, loginTime) VALUES (@userName, @loginTime)", connection, transaction)
                insertCommand.Parameters.AddWithValue("@userName", userName)
                insertCommand.Parameters.AddWithValue("@loginTime", DateTime.Now.ToString())

                ' Execute the command
                insertCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Error recording login history: " & ex.Message)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            'if checked
            txtPass.UseSystemPasswordChar = True
        Else
            txtPass.UseSystemPasswordChar = False
        End If
    End Sub
End Class