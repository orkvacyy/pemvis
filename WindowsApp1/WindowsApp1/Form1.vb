Imports System.Data
Imports Guna.UI2.WinForms

Public Class Form1

    Private IsShowingUsers As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flpWorkouts.HorizontalScroll.Maximum = 0
        flpWorkouts.AutoScroll = False
        flpWorkouts.VerticalScroll.Visible = False
        flpWorkouts.AutoScroll = True

        flpLib.HorizontalScroll.Maximum = 0
        flpLib.AutoScroll = False
        flpLib.VerticalScroll.Visible = False
        flpLib.AutoScroll = True

        If SessionModule.CurrentRole = "admin" Then
            btnAdmin.Visible = True
            btnWorkout.Visible = True
            btnAdmin.Checked = True

            IsShowingUsers = True
            lblTitle.Text = "User Management"
            btnNewWorkout.Text = "+ Add User"
            TampilUsers()
        Else
            btnAdmin.Visible = False
            btnWorkout.Visible = True
            btnWorkout.Checked = True

            IsShowingUsers = False
            lblTitle.Text = "Workout"
            btnNewWorkout.Text = "+ New Workout"
            TampilWorkouts()
        End If

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
        btnNewWorkout.Enabled = False
        Try
            If IsShowingUsers Then
                Dim popup As New FormUserPopup()
                If popup.ShowDialog() = DialogResult.OK Then
                    TampilUsers()
                End If
            Else
                Dim newId As Integer = DataModule.addWorkout("New Workout", "")
                If newId > 0 Then
                    Dim f3 As New Form3()
                    f3.InitWorkout(newId)
                    f3.ShowDialog()
                    TampilWorkouts()
                End If
            End If
        Finally
            btnNewWorkout.Enabled = True
        End Try
    End Sub

    Private Sub flpWorkouts_SizeChanged(sender As Object, e As EventArgs) Handles flpWorkouts.SizeChanged
        flpWorkouts.SuspendLayout()
        For Each ctrl As Control In flpWorkouts.Controls
            ctrl.Width = flpWorkouts.ClientSize.Width - 50
        Next
        flpWorkouts.ResumeLayout()
    End Sub


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

    Private Sub btnWorkout_Click(sender As Object, e As EventArgs) Handles btnWorkout.Click
        IsShowingUsers = False
        lblTitle.Text = "Workout"
        btnNewWorkout.Text = "+ New Workout"
        TampilWorkouts()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        IsShowingUsers = True
        lblTitle.Text = "User Management"
        btnNewWorkout.Text = "+ Add User"
        TampilUsers()
    End Sub

    Public Sub TampilUsers()
        flpWorkouts.Controls.Clear()
        Dim dt As DataTable = DataModule.GetUsers()

        If dt.Rows.Count = 0 Then
            Dim lblEmpty As New Label() With {
                .Text = "Belum ada user terdaftar.",
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
            Dim uid As Integer = CInt(row("id"))
            Dim username As String = row("username").ToString()
            Dim password As String = row("password").ToString()
            Dim role As String = row("role").ToString()
            Dim createdAt As DateTime = CDate(row("created_at"))

            Dim card As New Guna2Panel() With {
                .Height = 60,
                .Width = flpWorkouts.ClientSize.Width - 15,
                .BorderRadius = 6,
                .FillColor = Drawing.Color.FromArgb(32, 32, 32),
                .Margin = New Padding(0, 0, 0, 10)
            }

            Dim lblName As New Label() With {
                .Text = $"{username} ({role.ToUpper()})",
                .ForeColor = Drawing.Color.White,
                .Font = New Drawing.Font("Segoe UI", 11.0!, Drawing.FontStyle.Bold),
                .Location = New Drawing.Point(15, 10),
                .AutoSize = True,
                .BackColor = Drawing.Color.Transparent
            }
            card.Controls.Add(lblName)

            Dim lblMeta As New Label() With {
                .Text = $"ID: {uid}  •  Registered: {createdAt:dd MMM yyyy HH:mm}  •  Password: {password}",
                .ForeColor = Drawing.Color.FromArgb(150, 150, 150),
                .Font = New Drawing.Font("Segoe UI", 9.0!),
                .Location = New Drawing.Point(15, 33),
                .AutoSize = True,
                .BackColor = Drawing.Color.Transparent
            }
            card.Controls.Add(lblMeta)

            Dim btnEditUser As New Guna2Button() With {
                .Width = 36,
                .Height = 36,
                .Location = New Drawing.Point(card.Width - 90, 12),
                .Anchor = AnchorStyles.Top Or AnchorStyles.Right,
                .BorderRadius = 4,
                .FillColor = Drawing.Color.FromArgb(42, 42, 42),
                .ForeColor = Drawing.Color.White,
                .Font = New Drawing.Font("Segoe UI", 12.0!),
                .Text = "🖋",
                .Cursor = Cursors.Hand
            }
            AddHandler btnEditUser.Click, Sub()
                                             Dim popup As New FormUserPopup()
                                             popup.SetUserData(uid, username, password, role)
                                             If popup.ShowDialog() = DialogResult.OK Then
                                                 TampilUsers()
                                             End If
                                         End Sub
            card.Controls.Add(btnEditUser)

            Dim btnDelUser As New Guna2Button() With {
                .Width = 36,
                .Height = 36,
                .Location = New Drawing.Point(card.Width - 48, 12),
                .Anchor = AnchorStyles.Top Or AnchorStyles.Right,
                .BorderRadius = 4,
                .FillColor = Drawing.Color.FromArgb(42, 42, 42),
                .ForeColor = Drawing.Color.FromArgb(200, 60, 60),
                .Font = New Drawing.Font("Segoe UI", 12.0!),
                .Text = "🗑",
                .Cursor = Cursors.Hand
            }

            If uid = SessionModule.CurrentUserId Then
                btnDelUser.Enabled = False
                btnEditUser.Enabled = False
            End If

            AddHandler btnDelUser.Click, Sub()
                                             If MessageBox.Show($"Hapus akun user '{username}'? Semua data workout dan latihan kustom miliknya juga akan ikut terhapus secara permanen.", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                                                 If DataModule.DelUser(uid) Then
                                                     TampilUsers()
                                                 End If
                                             End If
                                         End Sub
            card.Controls.Add(btnDelUser)

            flpWorkouts.Controls.Add(card)
        Next
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        SessionModule.Logout()
        Dim loginForm As New FormLogin()
        Me.Hide()
        loginForm.ShowDialog()
        Me.Close()
    End Sub


    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint
    End Sub

    Private Sub flpWorkouts_Paint(sender As Object, e As PaintEventArgs) Handles flpWorkouts.Paint

    End Sub
End Class