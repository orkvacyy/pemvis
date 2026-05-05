Imports MySqlConnector
Imports System.Configuration

Module ConnectionModule
    Public ReadOnly ConnectionString As String = ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function
End Module