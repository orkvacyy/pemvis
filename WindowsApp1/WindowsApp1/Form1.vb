Imports System.Data
Imports Guna.UI2.WinForms

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tampilkan tombol sesuai role
        If SessionModule.CurrentRole = "admin" Then
            btnAdmin.Visible = True
            btnWorkout.Visible = False
        Else
            btnAdmin.Visible = False
            btnWorkout.Visible = True
        End If

        ' Setup scroll
        flpWorkouts.HorizontalScroll.Maximum = 0
        flpWorkouts.AutoScroll = False
        flpWorkouts.VerticalScroll.Visible = False
        flpWorkouts.AutoScroll = True

        flpLib.HorizontalScroll.Maximum = 0
        flpLib.AutoScroll = False
        flpLib.VerticalScroll.Visible = False
        flpLib.AutoScroll = True

        TampilWorkouts()
        TampilLibrary()
    End Sub

    ' ── WORKOUT (Panel Kiri) ─────────────────────────────────

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
            card.Width = flpWorkouts.ClientSize.Width - 15
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

    Private Sub flpWorkouts_SizeChanged(sender As Object, e As EventArgs) Handles flpWorkouts.SizeChanged
        flpWorkouts.SuspendLayout()
        For Each ctrl As Control In flpWorkouts.Controls
            ctrl.Width = flpWorkouts.ClientSize.Width - 15
        Next
        flpWorkouts.ResumeLayout()
    End Sub

    ' ── LIBRARY (Panel Kanan) ────────────────────────────────

    Public Sub TampilLibrary()
        flpLib.Controls.Clear()
        Dim dt As DataTable = DataModule.getExec()

        If dt.Rows.Count = 0 Then
            Dim lblEmpty As New Label() With {
                .Text = "Belum ada exercise.",
                .ForeColor = Drawing.Color.FromArgb(100, 100, 100),
                .Font = New Drawing.Font("Segoe UI", 11),
                .AutoSize = False,
                .Size = New Drawing.Size(flpLib.Width - 20, 40),
                .TextAlign = Drawing.ContentAlignment.MiddleCenter
            }
            flpLib.Controls.Add(lblEmpty)
            Return
        End If

        Dim globalRows As New List(Of DataRow)()
        Dim customRows As New List(Of DataRow)()

        For Each row As DataRow In dt.Rows
            If IsDBNull(row("user_id")) Then
                globalRows.Add(row)
            Else
                customRows.Add(row)
            End If
        Next

        ' 1. Render Global/System Exercises
        If globalRows.Count > 0 Then
            Dim lblDefaultHeader As New Label() With {
                .Text = "SYSTEM EXERCISES",
                .ForeColor = Drawing.Color.FromArgb(120, 120, 120),
                .Font = New Drawing.Font("Segoe UI", 8.0!, Drawing.FontStyle.Bold),
                .AutoSize = False,
                .Size = New Drawing.Size(flpLib.Width - 25, 24),
                .Margin = New Padding(5, 8, 0, 4),
                .TextAlign = Drawing.ContentAlignment.BottomLeft
            }
            flpLib.Controls.Add(lblDefaultHeader)

            For Each row In globalRows
                Dim item As New LibraryMasterCMS()
                item.Width = flpLib.ClientSize.Width - 15
                item.SetData(row("id"), row("name"), row("muscle_group"), row("equipment"), row("user_id"))
                AddLibraryHandlers(item)
                flpLib.Controls.Add(item)
            Next
        End If

        ' 2. Render Custom Exercises
        If customRows.Count > 0 Then
            Dim lblCustomHeader As New Label() With {
                .Text = "USER-CREATED EXERCISES",
                .ForeColor = Drawing.Color.FromArgb(0, 150, 255),
                .Font = New Drawing.Font("Segoe UI", 8.0!, Drawing.FontStyle.Bold),
                .AutoSize = False,
                .Size = New Drawing.Size(flpLib.Width - 25, 24),
                .Margin = New Padding(5, 12, 0, 4),
                .TextAlign = Drawing.ContentAlignment.BottomLeft
            }
            flpLib.Controls.Add(lblCustomHeader)

            For Each row In customRows
                Dim item As New LibraryMasterCMS()
                item.Width = flpLib.ClientSize.Width - 15
                item.SetData(row("id"), row("name"), row("muscle_group"), row("equipment"), row("user_id"))
                AddLibraryHandlers(item)
                flpLib.Controls.Add(item)
            Next
        End If
    End Sub

    Private Sub AddLibraryHandlers(item As LibraryMasterCMS)
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
    End Sub

    Private Sub btnCustomExercise_Click(sender As Object, e As EventArgs) Handles btnCustomExercise.Click
        Dim popup As New Form2()
        If popup.ShowDialog() = DialogResult.OK Then TampilLibrary()
    End Sub

    Private Sub flpLib_SizeChanged(sender As Object, e As EventArgs) Handles flpLib.SizeChanged
        flpLib.SuspendLayout()
        For Each ctrl As Control In flpLib.Controls
            ctrl.Width = flpLib.ClientSize.Width - 15
        Next
        flpLib.ResumeLayout()
    End Sub

    ' ── SIDEBAR ──────────────────────────────────────────────

    Private Sub btnWorkout_Click(sender As Object, e As EventArgs) Handles btnWorkout.Click
        TampilWorkouts()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        SessionModule.Logout()
        Dim loginForm As New FormLogin()
        Me.Hide()
        loginForm.ShowDialog()
        Me.Close()
    End Sub

    ' ── PAINT (kosong, biarkan saja) ─────────────────────────

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint
    End Sub

End Class