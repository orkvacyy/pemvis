Module SessionModule
    Public CurrentUserId As Integer = 0
    Public CurrentUsername As String = ""

    Public Sub Logout()
        CurrentUserId = 0
        CurrentUsername = ""
    End Sub
End Module