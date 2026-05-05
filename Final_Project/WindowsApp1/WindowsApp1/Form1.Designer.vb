<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.pnlSidebar = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnWorkout = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlLogo = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblLogoText = New System.Windows.Forms.Label()
        Me.pnlMain = New Guna.UI2.WinForms.Guna2Panel()
        Me.flpWorkouts = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnNewWorkout = New Guna.UI2.WinForms.Guna2Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlLibrary = New Guna.UI2.WinForms.Guna2Panel()
        Me.flpLib = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnCustomExercise = New Guna.UI2.WinForms.Guna2Button()
        Me.lblLibTitle = New System.Windows.Forms.Label()
        Me.sidebarTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pnlSidebar.SuspendLayout()
        Me.pnlLogo.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlLibrary.SuspendLayout()
        Me.SuspendLayout()

        ' ── pnlSidebar ────────────────────────────────────────────────
        Me.pnlSidebar.Controls.Add(Me.btnWorkout)
        Me.pnlSidebar.Controls.Add(Me.pnlLogo)
        Me.pnlSidebar.CustomBorderColor = System.Drawing.Color.FromArgb(42, 42, 42)
        Me.pnlSidebar.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.FillColor = System.Drawing.Color.FromArgb(26, 26, 26)
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(220, 766)
        Me.pnlSidebar.TabIndex = 0

        ' ── btnWorkout ────────────────────────────────────────────────
        Me.btnWorkout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnWorkout.Checked = True
        Me.btnWorkout.CheckedState.FillColor = System.Drawing.Color.FromArgb(25, 59, 130, 246)
        Me.btnWorkout.CheckedState.ForeColor = System.Drawing.Color.FromArgb(59, 130, 246)
        Me.btnWorkout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnWorkout.FillColor = System.Drawing.Color.Transparent
        Me.btnWorkout.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.btnWorkout.ForeColor = System.Drawing.Color.FromArgb(156, 163, 175)
        Me.btnWorkout.HoverState.FillColor = System.Drawing.Color.FromArgb(42, 42, 42)
        Me.btnWorkout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnWorkout.Location = New System.Drawing.Point(0, 80)
        Me.btnWorkout.Name = "btnWorkout"
        Me.btnWorkout.Size = New System.Drawing.Size(220, 50)
        Me.btnWorkout.TabIndex = 3
        Me.btnWorkout.Text = "  Workout"
        Me.btnWorkout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnWorkout.TextOffset = New System.Drawing.Point(20, 0)

        ' ── pnlLogo ───────────────────────────────────────────────────
        Me.pnlLogo.BackColor = System.Drawing.Color.Transparent
        Me.pnlLogo.Controls.Add(Me.lblLogoText)
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(220, 80)
        Me.pnlLogo.TabIndex = 0

        ' ── lblLogoText ───────────────────────────────────────────────
        Me.lblLogoText.AutoSize = True
        Me.lblLogoText.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogoText.ForeColor = System.Drawing.Color.White
        Me.lblLogoText.Location = New System.Drawing.Point(20, 18)
        Me.lblLogoText.Name = "lblLogoText"
        Me.lblLogoText.TabIndex = 1
        Me.lblLogoText.Text = "hevy"

        ' ── pnlMain ───────────────────────────────────────────────────
        Me.pnlMain.Controls.Add(Me.flpWorkouts)
        Me.pnlMain.Controls.Add(Me.btnNewWorkout)
        Me.pnlMain.Controls.Add(Me.lblTitle)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.FillColor = System.Drawing.Color.FromArgb(18, 18, 18)
        Me.pnlMain.Location = New System.Drawing.Point(220, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1065, 766)
        Me.pnlMain.TabIndex = 1

        ' ── flpWorkouts ───────────────────────────────────────────────
        Me.flpWorkouts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or
                                         System.Windows.Forms.AnchorStyles.Bottom) Or
                                        System.Windows.Forms.AnchorStyles.Left) Or
                                       System.Windows.Forms.AnchorStyles.Right,
                                      System.Windows.Forms.AnchorStyles)
        Me.flpWorkouts.AutoScroll = True
        Me.flpWorkouts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpWorkouts.Location = New System.Drawing.Point(40, 130)
        Me.flpWorkouts.Name = "flpWorkouts"
        Me.flpWorkouts.Size = New System.Drawing.Size(985, 616)
        Me.flpWorkouts.TabIndex = 2
        Me.flpWorkouts.WrapContents = False
        Me.flpWorkouts.BackColor = System.Drawing.Color.Transparent

        ' ── btnNewWorkout ─────────────────────────────────────────────
        Me.btnNewWorkout.Anchor = CType(System.Windows.Forms.AnchorStyles.Top Or
                                         System.Windows.Forms.AnchorStyles.Right,
                                        System.Windows.Forms.AnchorStyles)
        Me.btnNewWorkout.BorderRadius = 8
        Me.btnNewWorkout.FillColor = System.Drawing.Color.FromArgb(59, 130, 246)
        Me.btnNewWorkout.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnNewWorkout.ForeColor = System.Drawing.Color.White
        Me.btnNewWorkout.Location = New System.Drawing.Point(870, 30)
        Me.btnNewWorkout.Name = "btnNewWorkout"
        Me.btnNewWorkout.Size = New System.Drawing.Size(160, 44)
        Me.btnNewWorkout.TabIndex = 3
        Me.btnNewWorkout.Text = "+ New Workout"

        ' ── lblTitle ──────────────────────────────────────────────────
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(40, 28)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Workout"

        ' ── pnlLibrary ────────────────────────────────────────────────
        Me.pnlLibrary.Controls.Add(Me.flpLib)
        Me.pnlLibrary.Controls.Add(Me.btnCustomExercise)
        Me.pnlLibrary.Controls.Add(Me.lblLibTitle)
        Me.pnlLibrary.CustomBorderColor = System.Drawing.Color.FromArgb(42, 42, 42)
        Me.pnlLibrary.CustomBorderThickness = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.pnlLibrary.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlLibrary.FillColor = System.Drawing.Color.FromArgb(24, 24, 24)
        Me.pnlLibrary.Location = New System.Drawing.Point(1285, 0)
        Me.pnlLibrary.Name = "pnlLibrary"
        Me.pnlLibrary.Size = New System.Drawing.Size(270, 766)
        Me.pnlLibrary.TabIndex = 2

        ' ── flpLib ────────────────────────────────────────────────────
        Me.flpLib.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or
                                    System.Windows.Forms.AnchorStyles.Bottom) Or
                                   System.Windows.Forms.AnchorStyles.Left) Or
                                  System.Windows.Forms.AnchorStyles.Right,
                                 System.Windows.Forms.AnchorStyles)
        Me.flpLib.AutoScroll = True
        Me.flpLib.BackColor = System.Drawing.Color.Transparent
        Me.flpLib.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpLib.Location = New System.Drawing.Point(10, 115)
        Me.flpLib.Name = "flpLib"
        Me.flpLib.Size = New System.Drawing.Size(250, 641)
        Me.flpLib.TabIndex = 1
        Me.flpLib.WrapContents = False

        ' ── btnCustomExercise ─────────────────────────────────────────
        Me.btnCustomExercise.BackColor = System.Drawing.Color.Transparent
        Me.btnCustomExercise.BorderRadius = 6
        Me.btnCustomExercise.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomExercise.FillColor = System.Drawing.Color.FromArgb(42, 42, 42)
        Me.btnCustomExercise.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCustomExercise.ForeColor = System.Drawing.Color.FromArgb(59, 130, 246)
        Me.btnCustomExercise.Location = New System.Drawing.Point(10, 68)
        Me.btnCustomExercise.Name = "btnCustomExercise"
        Me.btnCustomExercise.Size = New System.Drawing.Size(250, 36)
        Me.btnCustomExercise.TabIndex = 2
        Me.btnCustomExercise.Text = "+ Custom Exercise"

        ' ── lblLibTitle ───────────────────────────────────────────────
        Me.lblLibTitle.AutoSize = True
        Me.lblLibTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblLibTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLibTitle.ForeColor = System.Drawing.Color.White
        Me.lblLibTitle.Location = New System.Drawing.Point(10, 22)
        Me.lblLibTitle.Name = "lblLibTitle"
        Me.lblLibTitle.TabIndex = 0
        Me.lblLibTitle.Text = "Exercise Library"

        ' ── sidebarTimer ──────────────────────────────────────────────
        Me.sidebarTimer.Interval = 10

        ' ── Form1 ─────────────────────────────────────────────────────
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(18, 18, 18)
        Me.ClientSize = New System.Drawing.Size(1555, 766)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlLibrary)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "Form1"
        Me.Text = "Hevy"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlLogo.ResumeLayout(False)
        Me.pnlLogo.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.pnlLibrary.ResumeLayout(False)
        Me.pnlLibrary.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlLogo As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblLogoText As System.Windows.Forms.Label
    Friend WithEvents btnWorkout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlMain As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnNewWorkout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents flpWorkouts As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pnlLibrary As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblLibTitle As System.Windows.Forms.Label
    Friend WithEvents flpLib As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnCustomExercise As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents sidebarTimer As System.Windows.Forms.Timer
End Class