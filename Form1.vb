Public Class Form1
    '
    ' Primary Color: #2A3035
    '
    Dim PrimaryColor As Integer = "#2A3035"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorTranslator.FromHtml(PrimaryColor)
    End Sub
End Class
