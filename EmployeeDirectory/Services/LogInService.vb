Public Class LogInService
    Private _LoginView As New LoginView
    Private _LoginRepository As New LoginRepository

    Public Function SelectUser(ByVal OracleID As String, ByVal Password As String) As LoginView
        _LoginView.OracleID = CInt(OracleID)
        Return _LoginRepository.GetUserLogin(New LoginView() With {.OracleID = OracleID, .Password = Password})
    End Function
End Class
