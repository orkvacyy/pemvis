<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlTop = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtWorkoutName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnFinish = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDiscard = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlBottom = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnAddExercise = New Guna.UI2.WinForms.Guna2Button()
        Me.flpExercises = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlTop.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.SuspendLayout()

        ' ── pnlTop ────────────────────────────────────────────────────
        Me.pnlTop.Controls.Add(Me.txtWorkoutName)
        Me.pnlTop.Controls.Add(Me.lblDate)
        Me.pnlTop.Controls.Add(Me.btnFinish)
        Me.pnlTop.Controls.Add(Me.btnDiscard)
        Me.pnlTop.CustomBorderColor = System.Drawing.Color.FromArgb(45, 45, 45)
        Me.pnlTop.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.FillColor = System.Drawing.Color.FromArgb(26, 26, 26)
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(940, 82)
        Me.pnlTop.TabIndex = 0

        ' ── txtWorkoutName ────────────────────────────────────────────
        Me.txtWorkoutName.BorderRadius = 6
        Me.txtWorkoutName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWorkoutName.DefaultText = ""
        Me.txtWorkoutName.FillColor = System.Drawing.Color.FromArgb(36, 36, 36)
        Me.txtWorkoutName.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.txtWorkoutName.ForeColor = System.Drawing.Color.White
        Me.txtWorkoutName.Location = New System.Drawing.Point(18, 18)
        Me.txtWorkoutName.Margin = New System.Windows.Forms.Padding(6)
        Me.txtWorkoutName.Name = "txtWorkoutName"
        Me.txtWorkoutName.PlaceholderText = "Workout Name"
        Me.txtWorkoutName.SelectedText = ""
        Me.txtWorkoutName.Size = New System.Drawing.Size(320, 46)
        Me.txtWorkoutName.TabIndex = 0

        ' ── lblDate ───────────────────────────────────────────────────
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(130, 130, 130)
        Me.lblDate.Location = New System.Drawing.Point(352, 30)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "—"

        ' ── btnDiscard ────────────────────────────────────────────────
        Me.btnDiscard.Anchor = CType(System.Windows.Forms.AnchorStyles.Top Or
                                      System.Windows.Forms.AnchorStyles.Right,
                                     System.Windows.Forms.AnchorStyles)
        Me.btnDiscard.BorderRadius = 7
        Me.btnDiscard.FillColor = System.Drawing.Color.FromArgb(50, 50, 50)
        Me.btnDiscard.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnDiscard.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200)
        Me.btnDiscard.Location = New System.Drawing.Point(820, 20)
        Me.btnDiscard.Name = "btnDiscard"
        Me.btnDiscard.Size = New System.Drawing.Size(100, 42)
        Me.btnDiscard.TabIndex = 3
        Me.btnDiscard.Text = "Close"

        ' ── btnFinish ─────────────────────────────────────────────────
        Me.btnFinish.Anchor = CType(System.Windows.Forms.AnchorStyles.Top Or
                                     System.Windows.Forms.AnchorStyles.Right,
                                    System.Windows.Forms.AnchorStyles)
        Me.btnFinish.BorderRadius = 7
        Me.btnFinish.FillColor = System.Drawing.Color.FromArgb(59, 130, 246)
        Me.btnFinish.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnFinish.ForeColor = System.Drawing.Color.White
        Me.btnFinish.Location = New System.Drawing.Point(700, 20)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(110, 42)
        Me.btnFinish.TabIndex = 2
        Me.btnFinish.Text = "✔  Finish"

        ' ── pnlBottom ─────────────────────────────────────────────────
        Me.pnlBottom.Controls.Add(Me.btnAddExercise)
        Me.pnlBottom.CustomBorderColor = System.Drawing.Color.FromArgb(45, 45, 45)
        Me.pnlBottom.CustomBorderThickness = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.FillColor = System.Drawing.Color.FromArgb(24, 24, 24)
        Me.pnlBottom.Location = New System.Drawing.Point(0, 672)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(940, 64)
        Me.pnlBottom.TabIndex = 2

        ' ── btnAddExercise ────────────────────────────────────────────
        Me.btnAddExercise.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddExercise.BorderRadius = 8
        Me.btnAddExercise.FillColor = System.Drawing.Color.FromArgb(42, 42, 42)
        Me.btnAddExercise.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddExercise.ForeColor = System.Drawing.Color.FromArgb(59, 130, 246)
        Me.btnAddExercise.Location = New System.Drawing.Point(370, 12)
        Me.btnAddExercise.Name = "btnAddExercise"
        Me.btnAddExercise.Size = New System.Drawing.Size(200, 42)
        Me.btnAddExercise.TabIndex = 0
        Me.btnAddExercise.Text = "+ Add Exercise"

        ' ── flpExercises ──────────────────────────────────────────────
        Me.flpExercises.AutoScroll = True
        Me.flpExercises.BackColor = System.Drawing.Color.FromArgb(18, 18, 18)
        Me.flpExercises.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpExercises.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpExercises.Location = New System.Drawing.Point(0, 82)
        Me.flpExercises.Name = "flpExercises"
        Me.flpExercises.Padding = New System.Windows.Forms.Padding(12, 12, 12, 12)
        Me.flpExercises.Size = New System.Drawing.Size(940, 590)
        Me.flpExercises.TabIndex = 1
        Me.flpExercises.WrapContents = False

        ' ── Form3 ─────────────────────────────────────────────────────
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(18, 18, 18)
        Me.ClientSize = New System.Drawing.Size(940, 736)
        Me.Controls.Add(Me.flpExercises)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.MinimumSize = New System.Drawing.Size(700, 550)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Workout"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlBottom.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTop As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtWorkoutName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents btnFinish As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDiscard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlBottom As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnAddExercise As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents flpExercises As System.Windows.Forms.FlowLayoutPanel
End Class