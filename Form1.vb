Public Class SignInUpForm
    '
    ' Primary Color: #2A3035
    '
    Dim PrimaryColor As String = "#2A3035"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorTranslator.FromHtml(PrimaryColor)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles firstNameTextBox.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        firstNameTextBox.Hide()
        MsgBox(firstNameTextBox.Visible)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles startHereLabel.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles alreadyAMemberLabel.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles CreateAnAccountWithUsLabel.Click

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles firstNameLabel.Click

    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs)

    End Sub
End Class
