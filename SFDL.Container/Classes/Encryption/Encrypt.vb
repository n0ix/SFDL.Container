Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

Public Class Encrypt

    Function EncryptString(ByVal Value As String, ByVal _password As String) As String

        Dim AES As New RijndaelManaged

        Dim md5 As New MD5CryptoServiceProvider
        Dim key() As Byte = md5.ComputeHash(Encoding.UTF8.GetBytes(_password))

        md5.Clear()
        AES.Key = key
        AES.GenerateIV()

        Dim iv() As Byte = AES.IV
        Dim ms As New MemoryStream

        ms.Write(iv, 0, iv.Length)

        Dim cs As New CryptoStream(ms, AES.CreateEncryptor, CryptoStreamMode.Write)
        Dim data() As Byte = System.Text.Encoding.UTF8.GetBytes(Value)

        cs.Write(data, 0, data.Length)
        cs.FlushFinalBlock()

        Dim encdata() As Byte = ms.ToArray()
        Return (Convert.ToBase64String(encdata))
        cs.Close()
        AES.Clear()

    End Function

End Class
