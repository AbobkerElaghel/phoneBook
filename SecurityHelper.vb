Imports System.Security.Cryptography

Public Class SecurityHelper
    Public Shared Function GenerateSalt(ByVal nSalt As Integer) As String
        Dim saltBytes = New Byte(nSalt) {}

        Using provider = New RNGCryptoServiceProvider()
            provider.GetNonZeroBytes(saltBytes)
        End Using

        Return Convert.ToBase64String(saltBytes)
    End Function

    Public Shared Function HashPassword(ByVal password As String, ByVal salt As String) As String
        Dim saltBytes = Convert.FromBase64String(salt)

        Using rfc2898DeriveBytes = New Rfc2898DeriveBytes(password, saltBytes, 10101)
            Return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(70))
        End Using
    End Function

    Public Shared Function verifyPassword(ByVal attempted As String, ByVal hashedPassword As String, ByVal salt As String) As Boolean
        Dim hashedAttempted As String = HashPassword(attempted, salt)
        Return hashedPassword = hashedAttempted
    End Function
End Class