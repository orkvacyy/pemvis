Imports System.Data
Imports Guna.UI2.WinForms
Imports System.Drawing.Printing

Public Class Form3

    Private _workoutId As Integer = 0
    Private WithEvents PrintDoc As New PrintDocument()
    Private PrintPreview As New PrintPreviewDialog()
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
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDoc.DefaultPageSettings.Margins = New Margins(50, 50, 50, 50)
        PrintPreview.Document = PrintDoc
        PrintPreview.ShowDialog()
    End Sub

    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDoc.PrintPage
        Dim g As Graphics = e.Graphics
        Dim startX As Integer = 60
        Dim startY As Integer = 60
        Dim offset As Integer = 0
        Dim pageWidth As Integer = e.PageBounds.Width - 120

        ' Font & Warna (Tetap sama)
        Dim fontTitle As New Font("Segoe UI", 16, FontStyle.Bold)
        Dim fontHeader As New Font("Segoe UI", 11, FontStyle.Bold)
        Dim fontSub As New Font("Segoe UI", 9, FontStyle.Regular)
        Dim fontBody As New Font("Segoe UI", 9.5, FontStyle.Regular)
        Dim fontBodyBold As New Font("Segoe UI", 9.5, FontStyle.Bold)

        Dim colorPrimary As Color = Color.FromArgb(59, 130, 246)
        Dim colorText As Color = Color.FromArgb(31, 41, 55)
        Dim colorMuted As Color = Color.FromArgb(107, 114, 128)
        Dim colorBorder As Color = Color.FromArgb(229, 231, 235)
        Dim colorCardBg As Color = Color.FromArgb(249, 250, 251)

        Dim brushPrimary As New SolidBrush(colorPrimary)
        Dim brushText As New SolidBrush(colorText)
        Dim brushMuted As New SolidBrush(colorMuted)
        Dim brushCardBg As New SolidBrush(colorCardBg)
        Dim penBorder As New Pen(colorBorder, 1)

        Dim logText As String = "WORKOUT LOG"

        g.DrawString(logText, fontTitle, brushText, startX, startY + offset)
        Dim logoImg As Image = My.Resources.hevy

        Dim targetHeight As Integer = 48

        Dim targetWidth As Integer = CInt(logoImg.Width * (targetHeight / logoImg.Height))

        Dim logoX As Single = startX + pageWidth - targetWidth

        Dim logoY As Single = startY + offset - 2

        g.DrawImage(logoImg, logoX, logoY, targetWidth, targetHeight)

        offset += 55
        g.DrawLine(New Pen(colorPrimary, 2), startX, startY + offset, startX + pageWidth, startY + offset)
        offset += 20
        g.DrawString(txtWorkoutName.Text, fontTitle, brushText, startX, startY + offset)
        offset += 30

        g.DrawString("Date       :  " & lblDate.Text, fontBody, brushText, startX, startY + offset)
        offset += 20
        g.DrawString("User       :  " & SessionModule.CurrentUsername.ToUpper(), fontBodyBold, brushPrimary, startX, startY + offset)
        offset += 35

        Dim dtEx As DataTable = DataModule.getWorkoutExercises(_workoutId)
        For Each row As DataRow In dtEx.Rows
            Dim weId As Integer = CInt(row("id"))
            Dim exName As String = row("exercise_name").ToString().ToUpper()
            Dim muscle As String = row("muscle_group").ToString()

            If startY + offset > e.PageBounds.Height - 120 Then
                e.HasMorePages = True
                Return
            End If

            g.FillRectangle(brushCardBg, startX, startY + offset, pageWidth, 28)
            g.DrawRectangle(penBorder, startX, startY + offset, pageWidth, 28)
            g.DrawString(exName & " (" & muscle & ")", fontHeader, brushPrimary, startX + 10, startY + offset + 5)
            offset += 38

            g.DrawString("SET", fontSub, brushMuted, startX + 20, startY + offset)
            g.DrawString("WEIGHT (KG)", fontSub, brushMuted, startX + 120, startY + offset)
            g.DrawString("REPS", fontSub, brushMuted, startX + 260, startY + offset)
            g.DrawString("STATUS", fontSub, brushMuted, startX + 380, startY + offset)
            offset += 18

            g.DrawLine(penBorder, startX + 10, startY + offset, startX + pageWidth - 10, startY + offset)
            offset += 8

            Dim dtSets As DataTable = DataModule.getWorkoutSets(weId)
            For Each setRow As DataRow In dtSets.Rows
                Dim setNum As String = setRow("set_number").ToString()
                Dim weight As String = CDec(setRow("weight")).ToString("0.##")
                Dim reps As String = setRow("reps").ToString()
                Dim isDone As Boolean = CBool(setRow("completed"))

                If startY + offset > e.PageBounds.Height - 80 Then
                    e.HasMorePages = True
                    Return
                End If

                g.DrawString(setNum, fontBody, brushMuted, startX + 25, startY + offset)
                g.DrawString(weight, fontBody, brushText, startX + 125, startY + offset)
                g.DrawString(reps, fontBody, brushText, startX + 265, startY + offset)

                If isDone Then
                    g.DrawString("Completed", fontBody, Brushes.Green, startX + 380, startY + offset)
                Else
                    g.DrawString("Incomplete", fontBody, brushMuted, startX + 380, startY + offset)
                End If

                offset += 22
            Next
            offset += 15
        Next

        e.HasMorePages = False
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub pnlTop_Paint(sender As Object, e As PaintEventArgs) Handles pnlTop.Paint

    End Sub

    Private Sub flpExercises_Paint(sender As Object, e As PaintEventArgs) Handles flpExercises.Paint

    End Sub
End Class