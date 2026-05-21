Public Class SetRowCMS
    Private _setId As Integer
    Public Property IsCardio As Boolean = False

    Public Event RowChanged(setId As Integer, w As Decimal, r As Integer, done As Boolean)
    Public Event DeleteClicked(setId As Integer)

    Public Sub setData(setId As Integer, setNum As Integer, weight As Decimal, reps As Integer, done As Boolean, Optional isCardio As Boolean = False)
        _setId = setId
        Me.IsCardio = isCardio
        lblNum.Text = setNum.ToString()
        chkDone.Checked = done

        If isCardio Then
            txtWeight.Text = weight.ToString("0.##")
            txtReps.Text = DataModule.FormatDuration(reps)
            txtWeight.PlaceholderText = "0.0"
            txtReps.PlaceholderText = "0:00"
        Else
            txtWeight.Text = weight.ToString("0.##")
            txtReps.Text = reps.ToString()
            txtWeight.PlaceholderText = "0"
            txtReps.PlaceholderText = "0"
        End If
    End Sub

    Private Sub triggerSave()
        Dim w As Decimal = 0D
        Dim r As Integer = 0
        Dim txtW As String = txtWeight.Text.Trim()
        Dim txtR As String = txtReps.Text.Trim()

        ' 1. Validasi Weight / Distance
        If txtW <> "" Then
            Dim isValidWeight As Boolean = Decimal.TryParse(txtW.Replace(",", "."), Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, w)
            If Not isValidWeight Then
                Dim jenisInput As String = If(IsCardio, "Jarak (km)", "Beban (kg)")
                MessageBox.Show($"Input '{txtW}' tidak valid. Silakan masukkan angka desimal untuk {jenisInput}.", "Input Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                w = 0D
                txtWeight.Text = If(IsCardio, "0.0", "0")
                txtWeight.Focus()
                Return
            End If
        End If

        ' 2. Validasi Reps / Duration
        If txtR <> "" Then
            If IsCardio Then
                If Not DataModule.IsValidDuration(txtR) Then
                    MessageBox.Show($"Input '{txtR}' tidak valid. Silakan masukkan format waktu yang benar (misal: 10:30, 25, atau 1.5).", "Input Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    r = 0
                    txtReps.Text = "0:00"
                    txtReps.Focus()
                    Return
                End If
                r = DataModule.ParseDuration(txtR)
            Else
                Dim isValidReps As Boolean = Integer.TryParse(txtR, r)
                If Not isValidReps OrElse r < 0 Then
                    MessageBox.Show($"Input '{txtR}' tidak valid. Silakan masukkan angka bulat untuk Repetisi.", "Input Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    r = 0
                    txtReps.Text = "0"
                    txtReps.Focus()
                    Return
                End If
            End If
        End If

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