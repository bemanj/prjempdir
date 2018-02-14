Imports System.Text.RegularExpressions

Public Class EmpEditService

    Private _EmployeeRepository As New EmployeeRepository
    Private _Employee As New Employee


    Public Property Employee() As Employee
        Get
            Return _Employee
        End Get
        Set(ByVal value As Employee)
            _Employee = value
        End Set
    End Property

    Public Function SelectEmpFromList(ByVal OracleID As Long) As Employee
        Return _EmployeeRepository.GetData(New Employee() With {.OracleID = OracleID})
    End Function

    Public Function ValidateEmail(ByVal EmailAddress) As Boolean
        Try
            Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
            If email.IsMatch(EmailAddress) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function SetListName(ByVal combo As ComboBox, ByVal comboID As Integer) As String
        Dim j As Integer = combo.Items.Count
        Dim _selectname As String = "unk"

        If Not comboID > 0 Then
            Return _selectname
        End If

        Dim i As Integer = 0
        Do
            combo.SelectedIndex = i
            If CType(combo.SelectedItem, DropDownList).ListID = comboID Then
                _selectname = CType(combo.SelectedItem, DropDownList).ListName
                Exit Do
            End If
            i += 1
        Loop Until i > j
        Return _selectname

    End Function

    Public Function SetSiteDetails(ByVal sitecombo As ComboBox, ByVal siteidentity As Integer) As Site

        Dim j As Integer = sitecombo.Items.Count
        Dim _site As New Site()


        Dim i As Integer = 0

        Do
            If Not siteidentity > 0 Then
                Exit Do
            End If
            sitecombo.SelectedIndex = i
            If CType(sitecombo.SelectedItem, Site).SiteID = siteidentity Then
                _site = CType(sitecombo.SelectedItem, Site)
                Exit Do
            End If
            i += 1
        Loop Until i > j

        Return _site

    End Function
End Class
