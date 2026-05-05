Imports System.Data
Imports Guna.UI2.WinForms

Public Class Form3

    Private _workoutId As Integer = 0
    Public Sub InitWorkout(workoutId As Integer)
        _workoutId = workoutId
    End Sub

    Private Sub Form3_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        LoadWorkoutInfo()
        LoadExercises()
    End Sub

    Private Sub LoadWorkoutInfo()
        Dim dt As DataTable = DataModule.getWorkoutById(_workoutId)
        If dt.Rows.Count = 0 Then Return
        txtWorkoutName.Text = dt.Rows(0)("name").ToString()
        lblDate.Text = CDate(dt.Rows(0)("date")).ToString("ddd, dd MMM yyyy · HH:mm")
    End Sub

    Private Sub LoadExercises()
        flpExercises.SuspendLayout()
        For Each ctrl As Control In flpExercises.Controls
            ctrl.Dispose()
        Next
        flpExercises.Controls.Clear()

        Dim dt As DataTable = DataModule.getWorkoutExercises(_workoutId)

        If dt.Rows.Count = 0 Then
            Dim lblEmpty As New Label() With {
                .Text = "Belum ada exercise. Klik '+ Add Exercise' di bawah.",
                .ForeColor = Drawing.Color.FromArgb(100, 100, 100),
                .Font = New Drawing.Font("Segoe UI", 10.5),
                .AutoSize = False,
                .Size = New Drawing.Size(flpExercises.ClientSize.Width - 20, 50),
                .TextAlign = Drawing.ContentAlignment.MiddleCenter,
                .Margin = New Padding(0, 20, 0, 0)
            }
            flpExercises.Controls.Add(lblEmpty)
        Else
            For Each row As DataRow In dt.Rows
                Dim weId As Integer = CInt(row("id"))

                Dim card As New ExerciseCardCMS()
                card.SetHeader(weId, row("exercise_name").ToString(), row("muscle_group").ToString())
                card.Margin = New Padding(0, 0, 0, 14)
                card.Width = Math.Max(flpExercises.ClientSize.Width - 25, 450)

                Dim sets As DataTable = DataModule.getWorkoutSets(weId)
                For Each setRow As DataRow In sets.Rows
                    Dim setItem As New SetRowCMS()
                    setItem.SetData(
                        CInt(setRow("id")),
                        CInt(setRow("set_number")),
                        CDec(setRow("weight")),
                        CInt(setRow("reps")),
                        CBool(setRow("completed"))
                    )
                    card.AddSetRow(setItem)
                Next

                AddHandler card.RemoveExerciseClicked, Sub(id, nama)
                                                           If MessageBox.Show($"Hapus '{nama}' dari workout ini?", "Konfirmasi",
                                                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                                               DataModule.delWorkoutExercise(id)
                                                               LoadExercises()
                                                           End If
                                                       End Sub

                AddHandler card.AddSetClicked, Sub(id)
                                                   DataModule.addSet(id, 0, 0)
                                                   LoadExercises()
                                               End Sub

                AddHandler card.SetDataChanged, Sub(sId, w, r, d)
                                                    DataModule.editSet(sId, w, r, d)
                                                End Sub

                AddHandler card.SetDeleteClicked, Sub(sId)
                                                      DataModule.delSet(sId)
                                                      LoadExercises()
                                                  End Sub
                flpExercises.Controls.Add(card)
            Next
        End If

        flpExercises.ResumeLayout()
    End Sub



    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        SaveWorkoutName()
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        If MessageBox.Show("Tutup tanpa menyimpan nama workout?", "Konfirmasi",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If
    End Sub

    Private Sub SaveWorkoutName()
        Dim name As String = txtWorkoutName.Text.Trim()
        If String.IsNullOrWhiteSpace(name) Then name = "New Workout"
        DataModule.editWorkout(_workoutId, name, "")
    End Sub

    Private Sub txtWorkoutName_Leave(sender As Object, e As EventArgs) Handles txtWorkoutName.Leave
        SaveWorkoutName()
    End Sub

    Private Sub btnAddExercise_Click(sender As Object, e As EventArgs) Handles btnAddExercise.Click
        Dim picker As New FormPickExercise()
        If picker.ShowDialog() = DialogResult.OK AndAlso picker.highlightExerciseId > 0 Then
            DataModule.addWorkoutExercise(_workoutId, picker.highlightExerciseId)
            LoadExercises()
        End If
    End Sub

End Class