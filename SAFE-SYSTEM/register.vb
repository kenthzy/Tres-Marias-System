Imports System.Data.SQLite
Imports System.IO

Public Class register
    Private dbCommand As String = ""
    Private bindingSrc As BindingSource

    Private dbName As String = "logIn.Db"
    Private dbPath As String = Path.Combine(Application.StartupPath, dbName)

    Private conString As String = "Data Source=" & dbPath & ";Version=3"

    Private connection As New SQLiteConnection(conString)
    Private command As New SQLiteCommand("", connection)

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtPassAd.Text = "va898900" Then ' Check the security code
            If Not String.IsNullOrEmpty(txtbxusername.Text) And Not String.IsNullOrEmpty(txtbxNewPass.Text) And Not String.IsNullOrEmpty(txtbxConfirmPass.Text) Then
                If txtbxNewPass.Text = txtbxConfirmPass.Text Then ' Check if passwords match
                    Try
                        connection.Open()

                        ' Check if the username already exists
                        command.CommandText = "SELECT COUNT(*) FROM loginInfo WHERE userName = @username"
                        command.Parameters.AddWithValue("@username", txtbxusername.Text)

                        Dim userCount As Integer = Convert.ToInt32(command.ExecuteScalar())

                        If userCount = 0 Then ' Username does not exist, proceed with registration
                            command.Parameters.Clear()
                            command.CommandText = "INSERT INTO loginInfo (userName, userPass) VALUES (@username, @password)"
                            command.Parameters.AddWithValue("@username", txtbxusername.Text)
                            command.Parameters.AddWithValue("@password", txtbxNewPass.Text)

                            Dim rowsAffected As Integer = command.ExecuteNonQuery()

                            If rowsAffected > 0 Then
                                MsgBox("Registration successful!")
                                Me.Hide()
                                login.ShowDialog()
                            Else
                                MsgBox("Error occurred during registration.")
                            End If
                        Else
                            MsgBox("Username already exists. Please choose a different username.")
                        End If
                    Catch ex As Exception
                        MsgBox("Error occurred: " & ex.Message)
                    Finally
                        connection.Close()
                    End Try
                Else
                    MsgBox("Passwords do not match. Please confirm your password.")
                End If
            Else
                MsgBox("Please fill in all fields.")
            End If
        Else
            MsgBox("Invalid security code. Please enter the correct code.")
        End If
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            'if checked
            txtPassAd.UseSystemPasswordChar = True
        Else
            txtPassAd.UseSystemPasswordChar = False
        End If
    End Sub
End Class
