Public Class WorkoutCMS
    Private _workoutId As Integer
    Private _workoutName As String

    Public Event OpenClicked(workoutId As Integer)
    Public Event DeleteClicked(workoutId As Integer, workoutName As String)

    Public Sub SetData(id As Integer, name As String, wDate As DateTime, exCount As Integer, setCount As Integer)
        _workoutId = id
        _workoutName = name

        lblName.Text = name
        lblMeta.Text = $"{wDate:ddd, dd MMM yyyy}  •  {exCount} exercise  •  {setCount} set"
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        RaiseEvent OpenClicked(_workoutId)
    End Sub

    Private Sub WorkoutCMS_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        RaiseEvent OpenClicked(_workoutId)
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        RaiseEvent DeleteClicked(_workoutId, _workoutName)
    End Sub
End Class