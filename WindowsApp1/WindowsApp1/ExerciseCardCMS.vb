Public Class ExerciseCardCMS
    Private _weId As Integer
    Private _exName As String

    Public Event RemoveExerciseClicked(weId As Integer, exName As String)
    Public Event AddSetClicked(weId As Integer)
    Public Event SetDataChanged(setId As Integer, w As Decimal, r As Integer, done As Boolean)
    Public Event SetDeleteClicked(setId As Integer)

    Public Sub SetHeader(weId As Integer, exName As String, muscle As String)
        _weId = weId
        _exName = exName
        lblName.Text = exName
        lblMuscle.Text = muscle
    End Sub
    Public Sub AddSetRow(row As SetRowCMS)
        AddHandler row.RowChanged, Sub(sId, w, r, d) RaiseEvent SetDataChanged(sId, w, r, d)
        AddHandler row.DeleteClicked, Sub(sId) RaiseEvent SetDeleteClicked(sId)

        flpSets.Controls.Add(row)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        RaiseEvent RemoveExerciseClicked(_weId, _exName)
    End Sub

    Private Sub btnAddSet_Click(sender As Object, e As EventArgs) Handles btnAddSet.Click
        RaiseEvent AddSetClicked(_weId)
    End Sub
End Class