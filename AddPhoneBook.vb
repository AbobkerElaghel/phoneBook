Imports MySql.Data.MySqlClient

Public Class AddPhoneBook
    Private Async Sub addPhonebookButton_Click(sender As Object, e As EventArgs) Handles addPhonebookButton.Click
        Try
            Dim conn As New MySqlConnection()
            conn.ConnectionString = "server=sql3.freemysqlhosting.net;user=sql3413637;database=sql3413637;port=3306;password=eEztbhiy4C;"
            Await conn.OpenAsync()
            Dim query As String = "INSERT INTO phonebook (firstName, lastName, phoneNumber, userId) VALUES ('" & firstNameTextBox.Text & "', '" & lastNameTextBox.Text & "', '" & phonenumberTextBox.Text & "', '" & MainForm.getSignInUser().id & "');"
            Dim command = conn.CreateCommand()
            command.CommandText = query
            Dim affectedRows = command.ExecuteNonQuery()
            If affectedRows > 0 Then
                MsgBox("Phone Book added")
                MainForm.populateGridList()
                Await conn.CloseAsync()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class