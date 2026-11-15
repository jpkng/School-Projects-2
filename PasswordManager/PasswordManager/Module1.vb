Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

Module AESModule
    ' Default AES key
    Public AesKey As String = "MyDefaultKey123"

    Private Function GetKeyBytes() As Byte()
        Dim key = AesKey
        If key Is Nothing Then key = ""
        If key.Length < 32 Then
            key = key.PadRight(32, " "c)
        ElseIf key.Length > 32 Then
            key = key.Substring(0, 32)
        End If
        Return Encoding.UTF8.GetBytes(key)
    End Function

    Public Function Encrypt(plainText As String) As String
        Dim keyBytes = GetKeyBytes()
        Using aesAlg As Aes = Aes.Create()
            aesAlg.Key = keyBytes
            aesAlg.Mode = CipherMode.CBC
            aesAlg.Padding = PaddingMode.PKCS7
            aesAlg.GenerateIV()
            Dim iv = aesAlg.IV
            Dim encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV)

            Using ms As New MemoryStream()
                ' prepend IV
                ms.Write(iv, 0, iv.Length)
                Using cs As New CryptoStream(ms, encryptor, CryptoStreamMode.Write)
                    Using sw As New StreamWriter(cs, Encoding.UTF8)
                        sw.Write(plainText)
                    End Using
                End Using
                Return Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
    End Function

    Public Function Decrypt(cipherText As String) As String
        If String.IsNullOrEmpty(cipherText) Then Return ""
        Dim fullCipher As Byte() = Convert.FromBase64String(cipherText)
        Dim keyBytes = GetKeyBytes()

        ' IV is first 16 bytes
        If fullCipher.Length < 16 Then Throw New CryptographicException("Cipher too short")

        Dim iv(15) As Byte
        Array.Copy(fullCipher, 0, iv, 0, iv.Length)

        Dim cipherBytes(fullCipher.Length - iv.Length - 1) As Byte
        Array.Copy(fullCipher, iv.Length, cipherBytes, 0, cipherBytes.Length)

        Using aesAlg As Aes = Aes.Create()
            aesAlg.Key = keyBytes
            aesAlg.IV = iv
            aesAlg.Mode = CipherMode.CBC
            aesAlg.Padding = PaddingMode.PKCS7

            Dim decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV)
            Using ms As New MemoryStream(cipherBytes)
                Using cs As New CryptoStream(ms, decryptor, CryptoStreamMode.Read)
                    Using sr As New StreamReader(cs, Encoding.UTF8)
                        Return sr.ReadToEnd()
                    End Using
                End Using
            End Using
        End Using
    End Function
End Module
