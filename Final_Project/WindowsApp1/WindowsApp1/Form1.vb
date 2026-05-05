Imports System.Data
Imports Guna.UI2.WinForms

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilWorkouts()
        TampilLibrary()
    End Sub

    Public Sub TampilWorkouts()
        flpWorkouts.Controls.Clear()
        Dim dt As DataTable = DataModule.getWorkouts()

        If dt.Rows.Count = 0 Then
            Dim lblEmpty As New Label() With {
                .Text = "Belum ada workout. Klik '+ New Workout' untuk mulai.",
                .ForeColor = Drawing.Color.FromArgb(100, 100, 100),
                .Font = New Drawing.Font("Segoe UI", 11),
                .AutoSize = False,
                .Size = New Drawing.Size(flpWorkouts.Width - 20, 40),
                .TextAlign = Drawing.ContentAlignment.MiddleCenter
            }
            flpWorkouts.Controls.Add(lblEmpty)
            Return
        End If

        For Each row As DataRow In dt.Rows
            Dim wid As Integer = CInt(row("id"))
            Dim wName As String = row("name").ToString()
            Dim wDate As DateTime = CDate(row("date"))
            Dim exCount As Integer = CInt(row("exercise_count"))
            Dim setCount As Integer = CInt(row("set_count"))

            Dim card As New WorkoutCMS()

            card.Margin = New Padding(0, 0, 0, 10)
            card.Width = flpWorkouts.Width - 25

            card.SetData(wid, wName, wDate, exCount, setCount)

            AddHandler card.OpenClicked, Sub(clickedId)
                                             Dim f3 As New Form3()
                                             f3.InitWorkout(clickedId)
                                             f3.ShowDialog()
                                             TampilWorkouts()
                                         End Sub

            AddHandler card.DeleteClicked, Sub(delId, delName)
                                               If MessageBox.Show($"Hapus workout '{delName}'?", "Konfirmasi",
                                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                                                   If DataModule.delWorkout(delId) Then TampilWorkouts()
                                               End If
                                           End Sub
            flpWorkouts.Controls.Add(card)
        Next
    End Sub



    Private Sub btnNewWorkout_Click(sender As Object, e As EventArgs) Handles btnNewWorkout.Click
        Dim newId As Integer = DataModule.addWorkout("New Workout", "")
        If newId > 0 Then
            Dim f3 As New Form3()
            f3.InitWorkout(newId)
            f3.ShowDialog()
            TampilWorkouts()
        End If
    End Sub

    Public Sub TampilLibrary()
        flpLib.Controls.Clear()
        Dim dt As DataTable = DataModule.getExec()

        For Each row As DataRow In dt.Rows
            Dim item As New LibraryMasterCMS()
            item.SetData(row("id"), row("name"), row("muscle_group"), row("equipment"))
            AddHandler item.EditClicked, Sub(id, name, muscle, eq)
                                             Dim popup As New Form2()
                                             popup.SetEditData(id, name, muscle, eq)
                                             If popup.ShowDialog() = DialogResult.OK Then TampilLibrary()
                                         End Sub
            AddHandler item.DeleteClicked, Sub(id, name)
                                               If MessageBox.Show($"Hapus '{name}'?", "Konfirmasi",
                                                                  MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                                   If DataModule.delExec(id) Then TampilLibrary()
                                               End If
                                           End Sub
            flpLib.Controls.Add(item)
        Next
    End Sub



    Private Sub btnCustomExercise_Click(sender As Object, e As EventArgs) Handles btnCustomExercise.Click
        Dim popup As New Form2()
        If popup.ShowDialog() = DialogResult.OK Then TampilLibrary()
    End Sub

End Class