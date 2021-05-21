Public Class User
    Public Sub New(nid As Integer, nfirstName As String, nlastName As String, nEmail As String, nPhoneNumber As Integer)
        id = nid
        firstName = nfirstName
        lastName = nlastName
        email = nEmail
        phoneNumber = nPhoneNumber
    End Sub

    Public Property id As Integer
    Public Property firstName As String
    Public Property lastName As String
    Public Property email As String
    Public Property photoUrl As String
    Public Property phoneNumber As Integer
End Class
