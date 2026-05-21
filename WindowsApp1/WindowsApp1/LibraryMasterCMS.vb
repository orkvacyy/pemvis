Public Class LibraryMasterCMS
    Private _execId As Integer
    Private _execName As String
    Private _muscleGroup As String
    Private _equipment As String
    Public Event EditClicked(id As Integer, name As String, muscle As String, equipment As String)
    Public Event DeleteClicked(id As Integer, name As String)

    Public Sub SetData(id As Integer, name As String, muscle As String, equipment As String, ownerId As Object)
        _execId = id
        _execName = name
        _muscleGroup = muscle
        _equipment = equipment

        If IsDBNull(ownerId) Then
            btnEx.Text = $"{name} ({muscle})"
            btnEx.BorderThickness = 0
        Else
            btnEx.Text = $"👤 {name} ({muscle})"
            btnEx.BorderThickness = 1
            btnEx.BorderColor = System.Drawing.Color.FromArgb(0, 150, 255)
        End If

        If SessionModule.CurrentRole = "admin" Then
            btnEdit.Visible = True
            btnDel.Visible = True
        Else
            If IsDBNull(ownerId) Then
                btnEdit.Visible = False
                btnDel.Visible = False
            Else
                btnEdit.Visible = True
                btnDel.Visible = True
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        RaiseEvent EditClicked(_execId, _execName, _muscleGroup, _equipment)
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        RaiseEvent DeleteClicked(_execId, _execName)
    End Sub

    Private Sub btnEx_Click(sender As Object, e As EventArgs) Handles btnEx.Click

    End Sub
End Class