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
End Class
