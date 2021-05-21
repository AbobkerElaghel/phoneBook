Imports MySql.Data.MySqlClient

Public Class SignInUpForm

    Dim isSignUp As Boolean = True
    Dim conn As New MySqlConnection()
    'Database is Hosted online so it is uncoupled from the localhost and mysql does not have to installed'
    Dim connectionString As String = "server=sql3.freemysqlhosting.net;user=sql3413637;database=sql3413637;port=3306;password=eEztbhiy4C;"
    Private currectUser As User
    Private Async Function createUser(firstName As String, lastName As String, phoneNumber As Integer, email As String, userPassword As String, salt As String) As Task(Of Boolean)
        Try
            'Check if database connection is valid'
            If Await dbConnection() Then
                Await conn.OpenAsync()
                Dim command As MySqlCommand = conn.CreateCommand()

                'inserting the user to the database'
                command.CommandText = "INSERT INTO users (firstName, lastName, phoneNumber, email, userPassword,salt) VALUES ( '" & firstName & "','" & lastName & "'," & phoneNumber & ",'" & email & "','" & userPassword & "','" & salt & "');"
                'if the rows in the database has been affected then the user is saved, return true to the calling envourment'
                Dim numberOfRowsAffected As Integer = command.ExecuteNonQuery()
                If numberOfRowsAffected > 0 Then
                    Await conn.CloseAsync()
                    Return True
                End If
                Await conn.CloseAsync()
            End If
            MsgBox("connection to database failed in createUser")
            Await conn.CloseAsync()
            Return False
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

    End Function


    Private Async Function signIn(email As String, password As String) As Task(Of Boolean)
        Try
            If Await dbConnection() Then
                Await conn.OpenAsync()
                Dim command As MySqlCommand = conn.CreateCommand()
                command.CommandText = "select * from users where email = '" & email & "';"
                Dim result As MySqlDataReader = command.ExecuteReader()
                result.Read()

                If result.HasRows() Then
                    result.Read()
                    Dim hashedPassword = result.GetString("userPassword")
                    Dim salt = result.GetString("salt")

                    'If password is correct then the user will be loged in'
                    If SecurityHelper.verifyPassword(password, hashedPassword, salt) Then
                        currectUser = New User(result.GetInt32("id"), result.GetString("firstName"), result.GetString("lastName"), result.GetString("email"), result.GetInt32("phoneNumber"))
                        Await conn.CloseAsync()
                        Return True
                    Else
                        'if not then they will have to enter the password again' 
                        Await conn.CloseAsync()

                        Return False
                    End If
                Else
                    Await conn.CloseAsync()
                    MsgBox("user does not exists in the database")
                    Return False

                End If
            End If
            Await conn.CloseAsync()
            Return False
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
            Return False
        End Try
    End Function


    Private Function confirmPassword(str1 As String, str2 As String) As Boolean
        Return str1 = str2
    End Function

    Public Async Function dbConnection() As Task(Of Boolean)
        Try
            conn.ConnectionString = connectionString
            Console.WriteLine("Connecting to MySQL...")
            Await conn.OpenAsync()
            Await conn.CloseAsync()
            Return True

            ' Dim command As MySqlCommand = conn.CreateCommand()'
            'command.CommandText = "select * from users"'
            'Dim result As MySqlDataReader = command.ExecuteReader()'

            ' While result.Read()'
            '  MsgBox(result.GetValue("name"))'
            '   End While'
            ' While result.HasRows()'
            '  MsgBox(result.GetValue("name")'
            'result.Read()
            ' End While 
        Catch ex As Exception
            MsgBox(ex.ToString())
            conn.Close()
            Return False
        End Try

    End Function

    Private Sub signInEdits()

        Me.Text = "Sign in"
        logInLabel.Text = "Create One!"

        alreadyAMemberLabel.Text = "Don't have an account?"


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

        firstNameTextBox.Clear()
        lastNameTextBox.Clear()
        passwordTextBox.Clear()
        confirmPasswordTextBox.Clear()
        emailTextBox.Clear()
        phoneNumberTextBox.Clear()
        isSignUp = Not isSignUp
    End Sub

    Private Sub signUpEdits()
        Me.Text = "Sign up"

        logInLabel.Text = "Log in"
        alreadyAMemberLabel.Text = "Already a member?"
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


        firstNameTextBox.Clear()
        lastNameTextBox.Clear()
        passwordTextBox.Clear()
        confirmPasswordTextBox.Clear()
        emailTextBox.Clear()
        phoneNumberTextBox.Clear()
        isSignUp = Not isSignUp

    End Sub

    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await dbConnection()
        


    End Sub
    Private Sub logInLabel_Click(sender As Object, e As EventArgs) Handles logInLabel.Click
        If isSignUp Then
            signInEdits()
        Else
            signUpEdits()
        End If
    End Sub
    Private Async Sub signUpButton_Click(sender As Object, e As EventArgs) Handles signUpButton.Click
        'firstNameTextBox.Text, lastNameTextBox.Text, phoneNumberTextBox.Text, emailTextBox.Text, passwordTextBox.Text, confirmPasswordTextBox.Text'

        Try
            'Check of the password and the confirm password fields match'
            If Not confirmPassword(passwordTextBox.Text, confirmPasswordTextBox.Text) Then
                MsgBox("Passwords must match!")
                Return
            End If

            'hash the password before saving it to the database before saving it ot he database'
            Dim salt As String = SecurityHelper.GenerateSalt(70)
            Dim pwdHashed As String = SecurityHelper.HashPassword(passwordTextBox.Text, salt)
            If Await createUser(firstNameTextBox.Text, lastNameTextBox.Text, phoneNumberTextBox.Text, emailTextBox.Text, pwdHashed, salt) Then
                MsgBox("user created successfuly!")
            End If

        Catch ex As InvalidCastException
            MsgBox("Please enter a number in the phone number field!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        'Try
        '    dbConnection()
        '    conn.Open()
        '    Dim command As MySqlCommand = conn.CreateCommand()
        '    command.CommandText = "INSERT INTO users (firstName, lastName, phoneNumber, email, userPassword,salt) VALUES ('abobker','elaghl',123,'qwe','qwe','qwe');"
        '    Dim numberOfRowsAffected As Integer = command.ExecuteNonQuery()
        '    conn.Close()

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

    End Sub

    Private Async Sub logInButton_Click(sender As Object, e As EventArgs) Handles logInButton.Click
        Dim email = phoneNumberTextBox.Text
        Dim password = emailTextBox.Text

        If Await signIn(email, password) Then
            MainForm.setSignInUser(currectUser)
            MainForm.Show()
            Me.Hide()
        Else
            MsgBox("password is incorrect")
        End If

        'signInEdits()
    End Sub
End Class
