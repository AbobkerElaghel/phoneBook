Imports MySql.Data.MySqlClient

Public Class MainForm

    Private Shared signInUser As User

    Public Sub setSignInUser(user As User)
        signInUser = user
    End Sub

    Public Function getSignInUser() As User
        Return signInUser
    End Function
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles welcomeLabel.Click

    End Sub

    'Private Async Sub addButtonClick(sender As Object, e As EventArgs) Handles addButton.Click
    '    Dim conn As New MySqlConnection()
    '    conn.ConnectionString = "server=sql3.freemysqlhosting.net;user=sql3413637;database=sql3413637;port=3306;password=eEztbhiy4C;"
    '    Await conn.OpenAsync()
    'End Sub
    Private Async Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        welcomeLabel.Text = welcomeLabel.Text & " " & signInUser.firstName
        populateGridList()
        populateUserInfo()
    End Sub

    Public Async Sub populateGridList()
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Try
            Dim conn As New MySqlConnection()
            conn.ConnectionString = "server=sql3.freemysqlhosting.net;user=sql3413637;database=sql3413637;port=3306;password=eEztbhiy4C;"
            Await conn.OpenAsync()
            Dim query As String
            query = "select * from phonebook"
            Dim command = New MySqlCommand(query, conn)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            phoneBooksGrid.DataSource = bSource
            SDA.Update(dbDataSet)
            Await conn.CloseAsync()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Async Sub populateUserInfo()
        firstNameTextBox.Text = signInUser.firstName
        lastNameTextBox.Text = signInUser.lastName
        phoneNumberTextBox.Text = signInUser.phoneNumber
        emailTextBox.Text = signInUser.email
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        AddPhoneBook.Show()
    End Sub
End Class