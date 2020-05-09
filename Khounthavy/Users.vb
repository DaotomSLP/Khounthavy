Imports System.Security.Cryptography
Imports System.Text
Imports System.Data
Module Users

    Public Des As New TripleDESCryptoServiceProvider
    Public MD5 As New MD5CryptoServiceProvider

    Function MD5Hash(ByVal value As String) As Byte()
        Return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))
    End Function
    Function Encrypt(ByVal strInput As String, ByVal key As String) As String
        Des.Key = MD5Hash(key)
        Des.Mode = CipherMode.ECB
        Dim buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(strInput)
        Return Convert.ToBase64String(Des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))
    End Function


    Sub UserSave()

    End Sub
    Sub UserSaveEdit()

    End Sub


End Module
