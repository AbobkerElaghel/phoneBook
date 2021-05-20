Imports MySql.Data.MySqlClient


Public Class SignInUpForm

    Dim PrimaryColor As String = "#2A3035"
    Dim isSignUp As Boolean = True

    Public Shared Sub dbConnection()
        Dim connStr As String = "server=localhost;user=root;database=phonebook;port=3306;password=root;"
        Dim conn As New MySqlConnection(connStr)
        Try
            Console.WriteLine("Connecting to MySQL...")
            conn.Open()

            Dim command As MySqlCommand = conn.CreateCommand()
            command.CommandText = "select * from users"
            Dim result As MySqlDataReader = command.ExecuteReader()

            ' While result.Read()'
            '  MsgBox(result.GetValue("name"))'
            '   End While'



            ' While result.HasRows()'
            '  MsgBox(result.GetValue("name")'
            'result.Read()
            ' End While '


        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        conn.Close()
    End Sub



    Private Sub signInEdits()
        Me.Text = "Sign in"
        logInLabel.Text = "Log in"
        alreadyAMemberLabel.Text = "Already a member?"
        CreateAnAccountWithUsLabel.Text = "Welcome"
        phoneNumberLabel.Text = "Email"
        emailLabel.Text = "Password"
        firstNameLabel.Hide()
        firstNameTextBox.Hide()

        lastNameLabel.Hide()
        lastNameTextBox.Hide()

        passwordLabel.Hide()

        passwordTextBox.Hide()
        confirmPasswordTextBox.Hide()

        confirmPasswordLabel.Hide()
        logInButton.Show()
        signUpButton.Hide()
        isSignUp = Not isSignUp
    End Sub

    Private Sub signUpEdits()
        Me.Text = "Sign up"

        logInLabel.Text = "Create One!"

        alreadyAMemberLabel.Text = "Don't have an account?"
        CreateAnAccountWithUsLabel.Text = "Create an Account with us"

        phoneNumberLabel.Text = "Phone Number"
        emailLabel.Text = "Email"

        firstNameLabel.Show()
        firstNameTextBox.Show()

        lastNameLabel.Show()
        lastNameTextBox.Show()

        passwordLabel.Show()
        passwordTextBox.Show()

        passwordTextBox.Show()
        confirmPasswordTextBox.Show()
        confirmPasswordLabel.Show()
        logInButton.Hide()
        signUpButton.Show()
        isSignUp = Not isSignUp

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorTranslator.FromHtml(PrimaryColor)
        'dbConnection()'
    End Sub

    Private Sub alreadyAMemberLabel_Click(sender As Object, e As EventArgs) Handles alreadyAMemberLabel.Click

    End Sub

    Private Sub logInLabel_Click(sender As Object, e As EventArgs) Handles logInLabel.Click
        If isSignUp Then
            signInEdits()
        Else
            signUpEdits()
        End If
    End Sub

    Private Sub CreateAnAccountWithUsLabel_Click(sender As Object, e As EventArgs) Handles CreateAnAccountWithUsLabel.Click

    End Sub

    Private Sub phoneNumberLabel_Click(sender As Object, e As EventArgs) Handles phoneNumberLabel.Click

    End Sub

    Private Sub emailLabel_Click(sender As Object, e As EventArgs) Handles emailLabel.Click

    End Sub

    Private Sub firstNameLabel_Click(sender As Object, e As EventArgs) Handles firstNameLabel.Click

    End Sub

    Private Sub firstNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles firstNameTextBox.TextChanged

    End Sub

    Private Sub lastNameLabel_Click(sender As Object, e As EventArgs) Handles lastNameLabel.Click

    End Sub

    Private Sub lastNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles lastNameTextBox.TextChanged

    End Sub

    Private Sub passwordLabel_Click(sender As Object, e As EventArgs) Handles passwordLabel.Click

    End Sub

    Private Sub passwordTextBox_TextChanged(sender As Object, e As EventArgs) Handles passwordTextBox.TextChanged

    End Sub

    Private Sub confirmPasswordLabel_Click(sender As Object, e As EventArgs) Handles confirmPasswordLabel.Click

    End Sub

    Private Sub confirmPasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles confirmPasswordTextBox.TextChanged

    End Sub

    Private Sub logInButton_Click(sender As Object, e As EventArgs) Handles logInButton.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles signUpButton.Click
        Me.Hide()
        MainForm.Activate()
        MainForm.Show()



    End Sub
End Class
