Public Class LibraryMasterCMS
    Private _execId As Integer
    Private _execName As String
    Private _muscleGroup As String
    Private _equipment As String
    Public Event EditClicked(id As Integer, name As String, muscle As String, equipment As String)
    Public Event DeleteClicked(id As Integer, name As String)

    Public Sub SetData(id As Integer, name As String, muscle As String, equipment As String)
        _execId = id
        _execName = name
        _muscleGroup = muscle
        _equipment = equipment

        btnEx.Text = $"{name} ({muscle})"
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        RaiseEvent EditClicked(_execId, _execName, _muscleGroup, _equipment)
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        RaiseEvent DeleteClicked(_execId, _execName)
    End Sub
End Class