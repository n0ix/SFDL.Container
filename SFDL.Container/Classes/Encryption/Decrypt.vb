Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Public Class Decrypt

    Function DecryptString(ByVal Value As String, ByVal _password As String) As String

        Try

            If Not String.IsNullOrWhiteSpace(Value) Then

                Dim AES As New RijndaelManaged

                Dim rijndaelIvLength As Integer = 16
                Dim md5 As New MD5CryptoServiceProvider
                Dim key() As Byte = md5.ComputeHash(Encoding.UTF8.GetBytes(_password))

                md5.Clear()

                Dim encdata() As Byte = Convert.FromBase64String(Value)
                Dim ms As New MemoryStream(encdata)
                Dim iv(15) As Byte

                ms.Read(iv, 0, rijndaelIvLength)
                AES.IV = iv
                AES.Key = key

                Dim cs As New CryptoStream(ms, AES.CreateDecryptor, CryptoStreamMode.Read)

                Dim data(Integer.Parse(ms.Length.ToString) - rijndaelIvLength) As Byte
                Dim i As Integer = cs.Read(data, 0, data.Length)
                cs.Close()
                Return (System.Text.Encoding.UTF8.GetString(data, 0, i))

                AES.Clear()

            Else
                Return String.Empty
            End If

        Catch ex As Exception
            Throw New FalsePasswordException("Falsches Kennwort!")
        End Try

    End Function

End Class
