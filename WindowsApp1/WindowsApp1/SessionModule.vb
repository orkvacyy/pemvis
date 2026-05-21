Module SessionModule
    Public CurrentUserId As Integer = 0
    Public CurrentUsername As String = ""
    Public CurrentRole As String = ""        ' ← Tambah ini

    Public Sub Logout()
        CurrentUserId = 0
        CurrentUsername = ""
        CurrentRole = ""
    End Sub
End Module