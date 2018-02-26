Imports System.Runtime.CompilerServices

Public Module GlobalModule

    Public Const MessageLoginError As String = "Please enter username/password"
    Public Const MessageUserNotFound As String = "UserName/Password not found!"
    Public Const MessageDuplicateOracleID As String = "Oracle ID already exists."
    Public Const MessageEmailError As String = "Email is not valid, Please check your email address."
    Public Const MessageSFCError As String = "Please enter SFC date."
    Public Const MessageRequiredFields As String = "Please fill up required field/s"
   
   

    'Public Function SetListName(ByVal combo As ComboBox, ByVal val As Integer) As String
    '    Dim j As Integer = combo.Items.Count
    '    Dim _selectname As String = "unk"

    '    If Not val > 0 Then
    '        Return _selectname
    '    End If

    '    Dim i As Integer = 0
    '    Do
    '        combo.SelectedIndex = i
    '        If CType(combo.SelectedItem, DropDownList).ListID = val Then
    '            _selectname = CType(combo.SelectedItem, DropDownList).ListName
    '            Exit Do
    '        End If
    '        i += 1
    '    Loop Until i > j
    '    Return _selectname

    'End Function

    'Public Function SetSiteDetails(ByVal sitecombo As ComboBox, ByVal siteidentity As Integer) As Site

    '    Dim j As Integer = sitecombo.Items.Count
    '    Dim _site As New Site()


    '    Dim i As Integer = 0

    '    Do
    '        If Not siteidentity > 0 Then
    '            Exit Do
    '        End If
    '        sitecombo.SelectedIndex = i
    '        If CType(sitecombo.SelectedItem, Site).SiteID = siteidentity Then
    '            _site = CType(sitecombo.SelectedItem, Site)
    '            Exit Do
    '        End If
    '        i += 1
    '    Loop Until i > j

    '    Return _site

    'End Function
End Module
