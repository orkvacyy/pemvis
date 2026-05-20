Public Class SetRowCMS
    Private _setId As Integer

    Public Event RowChanged(setId As Integer, w As Decimal, r As Integer, done As Boolean)
    Public Event DeleteClicked(setId As Integer)

    Public Sub setData(setId As Integer, setNum As Integer, weight As Decimal, reps As Integer, done As Boolean)
        _setId = setId
        lblNum.Text = setNum.ToString()
        txtWeight.Text = weight.ToString("0.##")
        txtReps.Text = reps.ToString()
        chkDone.Checked = done
    End Sub

    Private Sub triggerSave()
        Dim w As Decimal = 0D
        Dim r As Integer = 0
        Decimal.TryParse(txtWeight.Text.Replace(",", "."), Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, w)
        Integer.TryParse(txtReps.Text, r)
        RaiseEvent RowChanged(_setId, w, r, chkDone.Checked)
    End Sub

    Private Sub txtWeight_Leave(sender As Object, e As EventArgs) Handles txtWeight.Leave
        triggerSave()
    End Sub

    Private Sub txtReps_Leave(sender As Object, e As EventArgs) Handles txtReps.Leave
        triggerSave()
    End Sub

    Private Sub chkDone_CheckedChanged(sender As Object, e As EventArgs) Handles chkDone.CheckedChanged
        triggerSave()
    End Sub

    Private Sub btnDelSet_Click(sender As Object, e As EventArgs) Handles btnDelSet.Click
        RaiseEvent DeleteClicked(_setId)
    End Sub
End Class