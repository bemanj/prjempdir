Imports System.Security.Cryptography
Imports System.Text
Public Class BaseCrypto

    Const _defaultKey As String = "P@$sW0r6"

    Private _keyString As String
    Private _key As Byte()
    Private _iv As Byte()
    Private _valueCipher As Byte()

    Private _cipher As Object

    Private _provider As BASDCryptoProvider
    Private _transform As BASDCryptoTransform

    Public Sub New(ByVal provider As BASDCryptoProvider)
        _provider = provider

    End Sub

    Private Sub initializeCipher()

        If _provider = BASDCryptoProvider.Trides Then
            _cipher = New TripleDESCryptoServiceProvider()
            CType(_cipher, TripleDESCryptoServiceProvider).GenerateKey()
            CType(_cipher, TripleDESCryptoServiceProvider).GenerateIV()

        ElseIf _provider = BASDCryptoProvider.Rijndael Then
            _cipher = New RijndaelManaged()
            CType(_cipher, RijndaelManaged).GenerateKey()
            CType(_cipher, RijndaelManaged).GenerateIV()
        End If
    End Sub
    ''' <summary>
    ''' Process the given keys and initialize the cipher salt
    ''' </summary>
    ''' <param name="inString"></param>
    ''' <remarks></remarks>
    Private Sub getCipherSalt(ByVal inString As String)

        If _transform = BASDCryptoTransform.Encrypt Then
            _valueCipher = UTF8Encoding.UTF8.GetBytes(inString)
            _key = New Rfc2898DeriveBytes(_keyString, CType(_cipher, TripleDESCryptoServiceProvider).IV).GetBytes(CType(_cipher, TripleDESCryptoServiceProvider).KeySize / 8)
            _iv = CType(_cipher, TripleDESCryptoServiceProvider).IV
        ElseIf _transform = BASDCryptoTransform.Decrypt Then

            If _provider = BASDCryptoProvider.Trides Then
                Dim _tempCipher = CType(_cipher, TripleDESCryptoServiceProvider)
                Dim _tempSalt = inString.Substring(0, Convert.ToBase64String(_tempCipher.Key).Length + Convert.ToBase64String(_tempCipher.IV).Length)
                Dim _tempSaltLength = Convert.ToBase64String(_tempCipher.Key).Length + Convert.ToBase64String(_tempCipher.IV).Length

                _key = Convert.FromBase64String(_tempSalt.Substring(0, Convert.ToBase64String(_tempCipher.Key).Length))
                _iv = Convert.FromBase64String(_tempSalt.Substring(Convert.ToBase64String(_tempCipher.Key).Length, Convert.ToBase64String(_tempCipher.IV).Length))
                'CType(_cipher, TripleDESCryptoServiceProvider).Key = 

                _valueCipher = Convert.FromBase64String(inString.Substring(_tempSaltLength, (inString.Length - _tempSaltLength)))

                'Convert.FromBase64String(inString.Substring(Convert.ToBase64String(CType(_cipher, TripleDESCryptoServiceProvider).Key).Length, inString.Length - Convert.ToBase64String(CType(_cipher, TripleDESCryptoServiceProvider).Key).Length))

                'Dim _tempCipherKeySize = (CType(_cipher, TripleDESCryptoServiceProvider).KeySize / 8)
                'Dim _tempCipherIvSize = CType(_cipher, TripleDESCryptoServiceProvider).IV.Length / 8

                'Buffer.BlockCopy(_tempInBytes, _tempCipherKeySize - 1, _valueCipher, 0, (_tempInBytes.Length - _tempCipherKeySize) - 1)

                '_valueCipher = Buffer.BlockCopy(Convert.FromBase64String(inString), CType(_cipher, TripleDESCryptoServiceProvider).KeySize / 8, _valueCipher, 0, Convert.FromBase64String(inString).Length - (Type(_cipher, TripleDESCryptoServiceProvider).KeySize / 8))

            End If
        End If
        'Select Case _provider
        '    Case BASDCryptoProvider.Trides
        '        '_iv = New Rfc2898DeriveBytes(_ivString, 8).GetBytes(8)

        '    Case BASDCryptoProvider.Rijndael
        '        CType(_cipher, TripleDESCryptoServiceProvider).GenerateIV()
        '        _key = 'New Rfc2898DeriveBytes(_keyString, CType(_cipher, RijndaelManaged).IV).GetBytes(CType(_cipher, TripleDESCryptoServiceProvider).KeySize / 8)
        '        '_iv = New Rfc2898DeriveBytes(_ivString, 16).GetBytes(16)

        'End Select

    End Sub

    'Private Sub getDecryptionSalt(ByVal inString As String)

    '    Select Case _provider
    '        Case BASDCryptoProvider.Trides
    '            _key = New Rfc2898DeriveBytes(_keyString, 24).GetBytes(24)
    '            _iv = New Rfc2898DeriveBytes(_ivString, 8).GetBytes(8)
    '            _valueDecrypt = Convert.FromBase64String(inString)

    '        Case BASDCryptoProvider.Rijndael
    '            _key = New Rfc2898DeriveBytes(_keyString, 32).GetBytes(32)
    '            _iv = New Rfc2898DeriveBytes(_ivString, 16).GetBytes(16)
    '            _valueDecrypt = Convert.FromBase64String(inString)

    '    End Select
    'End Sub
    ''' <summary>
    ''' Setup of cipher provider selected.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub getCipher()
        If _provider = BASDCryptoProvider.Trides Then
            _cipher = New TripleDESCryptoServiceProvider()
            CType(_cipher, TripleDESCryptoServiceProvider).Key = _key
            CType(_cipher, TripleDESCryptoServiceProvider).IV = _iv
            CType(_cipher, TripleDESCryptoServiceProvider).Mode = CipherMode.ECB
            CType(_cipher, TripleDESCryptoServiceProvider).Padding = PaddingMode.PKCS7
        ElseIf _provider = BASDCryptoProvider.Rijndael Then
            _cipher = New RijndaelManaged()
            CType(_cipher, RijndaelManaged).Key = _key
            CType(_cipher, RijndaelManaged).IV = _iv
            CType(_cipher, RijndaelManaged).Mode = CipherMode.ECB
            CType(_cipher, RijndaelManaged).Padding = PaddingMode.PKCS7
        End If
    End Sub

    ''' <summary>
    ''' Creates cryptography based on transformation selected.
    ''' </summary>
    ''' <returns>ICryptoTransform</returns>
    ''' <remarks></remarks>
    Private Function cipherTransformation() As ICryptoTransform

        Dim _tempTransformation As ICryptoTransform = Nothing

        Select Case _provider
            Case BASDCryptoProvider.Trides
                If _transform = BASDCryptoTransform.Encrypt Then
                    _tempTransformation = CType(_cipher, TripleDESCryptoServiceProvider).CreateEncryptor()
                ElseIf _transform = BASDCryptoTransform.Decrypt Then
                    _tempTransformation = CType(_cipher, TripleDESCryptoServiceProvider).CreateDecryptor()
                End If
                Return _tempTransformation
            Case BASDCryptoProvider.Rijndael

                If _transform = BASDCryptoTransform.Encrypt Then
                    _tempTransformation = CType(_cipher, Rijndael).CreateEncryptor()
                ElseIf _transform = BASDCryptoTransform.Decrypt Then
                    _tempTransformation = CType(_cipher, Rijndael).CreateDecryptor()
                End If
                Return _tempTransformation
            Case Else
                Return Nothing
        End Select
    End Function

    ''' <summary>
    ''' Start the processing of input string to be encrypted
    ''' </summary>
    ''' <param name="inString"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function startEncryptionString(ByVal inString As String) As String

        Dim _tempResult As String
        Dim _tempKey As String
        Dim _tempIv As String
        _transform = BASDCryptoTransform.Encrypt
        Me.initializeCipher()
        Me.getCipherSalt(inString)
        Me.getCipher()
        _tempResult = Convert.ToBase64String(Me.cipherTransformation().TransformFinalBlock(_valueCipher, 0, _valueCipher.Length))
        _tempKey = Convert.ToBase64String(_key)
        _tempIv = Convert.ToBase64String(_iv)
        Return _tempKey & _tempIv & _tempResult
    End Function
    ''' <summary>
    ''' Start the processing of input string to be decrypted
    ''' </summary>
    ''' <param name="inString"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function startDecryptionString(ByVal inString As String) As String

        Dim _tempResult As String
        _transform = BASDCryptoTransform.Decrypt
        Me.initializeCipher()
        Me.getCipherSalt(inString)
        Me.getCipher()
        _tempResult = UTF8Encoding.UTF8.GetString(Me.cipherTransformation().TransformFinalBlock(_valueCipher, 0, _valueCipher.Length))

        Return _tempResult
    End Function

#Region "DECRYPTION"
    ''' <summary>
    ''' Decrypt given inpunt string
    ''' </summary>
    ''' <param name="inString">input string to be decrypted</param>
    ''' <returns>Encrypted string</returns>
    ''' <remarks></remarks>
    Public Function DecryptString(ByVal inString As String) As String
        _keyString = _defaultKey
        Return startDecryptionString(inString)
    End Function
    ''' <summary>
    ''' Decrypt given inpunt string
    ''' </summary>
    ''' <param name="inString">input string to be decrypted</param>
    ''' <param name="keyString">key you want to use as salt</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overridable Function DecryptString(ByVal inString As String, ByVal keyString As String) As String
        _keyString = keyString
        Return startDecryptionString(inString)
    End Function
#End Region

#Region "ENCRYPTION"
    ''' <summary>
    ''' Encrypt given inpunt string
    ''' </summary>
    ''' <param name="inString">input string to be encrypted</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function EncryptString(ByVal inString As String) As String
        _keyString = _defaultKey
        Return startEncryptionString(inString)
    End Function
    ''' <summary>
    ''' Encrypt given inpunt string
    ''' </summary>
    ''' <param name="inString">input string to be encrypted</param>
    ''' <param name="keyString">key you want to use as salt</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overridable Function EncryptString(ByVal inString As String, ByVal keyString As String) As String
        _keyString = keyString
        Return startEncryptionString(inString)
    End Function
#End Region
    ''' <summary>
    ''' Set a new provider you want to use
    ''' </summary>
    ''' <param name="provider"></param>
    ''' <remarks></remarks>
    Public Sub ChangeProvider(ByVal provider As BASDCryptoProvider)
        Me._provider = provider
    End Sub
    
End Class

Public Enum BASDCryptoProvider
    Trides = 0
    Rijndael = 2
End Enum

Public Enum BASDCryptoTransform
    Encrypt = 0
    Decrypt = 1
End Enum