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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pnlSidebar = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnWorkout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlLogo = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pnlMain = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnNewWorkout = New Guna.UI2.WinForms.Guna2Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.sidebarTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblLibTitle = New System.Windows.Forms.Label()
        Me.btnCustomExercise = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlLibrary = New Guna.UI2.WinForms.Guna2Panel()
        Me.flpWorkouts = New System.Windows.Forms.FlowLayoutPanel()
        Me.flpLib = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlLogo.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.pnlLibrary.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.Controls.Add(Me.btnWorkout)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Controls.Add(Me.pnlLogo)
        Me.pnlSidebar.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.pnlSidebar.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.FillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(220, 766)
        Me.pnlSidebar.TabIndex = 0
        '
        'btnWorkout
        '
        Me.btnWorkout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnWorkout.Checked = True
        Me.btnWorkout.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnWorkout.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnWorkout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnWorkout.FillColor = System.Drawing.Color.Transparent
        Me.btnWorkout.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWorkout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.btnWorkout.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnWorkout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnWorkout.Location = New System.Drawing.Point(0, 80)
        Me.btnWorkout.Name = "btnWorkout"
        Me.btnWorkout.Size = New System.Drawing.Size(220, 50)
        Me.btnWorkout.TabIndex = 3
        Me.btnWorkout.Text = "  Workout"
        Me.btnWorkout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnWorkout.TextOffset = New System.Drawing.Point(20, 0)
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FillColor = System.Drawing.Color.Transparent
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnLogout.Location = New System.Drawing.Point(0, 716)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(220, 50)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "  Logout"
        Me.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.TextOffset = New System.Drawing.Point(20, 0)
        '
        'pnlLogo
        '
        Me.pnlLogo.BackColor = System.Drawing.Color.Black
        Me.pnlLogo.Controls.Add(Me.Guna2PictureBox1)
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(220, 80)
        Me.pnlLogo.TabIndex = 0
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(72, 4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(58, 70)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 2
        Me.Guna2PictureBox1.TabStop = False
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.flpWorkouts)
        Me.pnlMain.Controls.Add(Me.btnNewWorkout)
        Me.pnlMain.Controls.Add(Me.lblTitle)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.pnlMain.Location = New System.Drawing.Point(220, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1065, 766)
        Me.pnlMain.TabIndex = 1
        '
        'btnNewWorkout
        '
        Me.btnNewWorkout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNewWorkout.BackColor = System.Drawing.Color.Black
        Me.btnNewWorkout.BorderRadius = 8
        Me.btnNewWorkout.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNewWorkout.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewWorkout.ForeColor = System.Drawing.Color.White
        Me.btnNewWorkout.Location = New System.Drawing.Point(870, 30)
        Me.btnNewWorkout.Name = "btnNewWorkout"
        Me.btnNewWorkout.Size = New System.Drawing.Size(160, 44)
        Me.btnNewWorkout.TabIndex = 3
        Me.btnNewWorkout.Text = "+ New Workout"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(40, 28)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(95, 28)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Workout"
        '
        'sidebarTimer
        '
        Me.sidebarTimer.Interval = 10
        '
        'lblLibTitle
        '
        Me.lblLibTitle.AutoSize = True
        Me.lblLibTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblLibTitle.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLibTitle.ForeColor = System.Drawing.Color.White
        Me.lblLibTitle.Location = New System.Drawing.Point(10, 22)
        Me.lblLibTitle.Name = "lblLibTitle"
        Me.lblLibTitle.Size = New System.Drawing.Size(161, 28)
        Me.lblLibTitle.TabIndex = 0
        Me.lblLibTitle.Text = "Exercise Library"
        '
        'btnCustomExercise
        '
        Me.btnCustomExercise.BackColor = System.Drawing.Color.Transparent
        Me.btnCustomExercise.BorderRadius = 6
        Me.btnCustomExercise.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomExercise.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnCustomExercise.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomExercise.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCustomExercise.Location = New System.Drawing.Point(10, 68)
        Me.btnCustomExercise.Name = "btnCustomExercise"
        Me.btnCustomExercise.Size = New System.Drawing.Size(250, 36)
        Me.btnCustomExercise.TabIndex = 2
        Me.btnCustomExercise.Text = "+ Custom Exercise"
        '
        'pnlLibrary
        '
        Me.pnlLibrary.Controls.Add(Me.flpLib)
        Me.pnlLibrary.Controls.Add(Me.btnCustomExercise)
        Me.pnlLibrary.Controls.Add(Me.lblLibTitle)
        Me.pnlLibrary.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.pnlLibrary.CustomBorderThickness = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.pnlLibrary.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlLibrary.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.pnlLibrary.Location = New System.Drawing.Point(1285, 0)
        Me.pnlLibrary.Name = "pnlLibrary"
        Me.pnlLibrary.Size = New System.Drawing.Size(270, 766)
        Me.pnlLibrary.TabIndex = 2
        '
        'flpWorkouts
        '
        Me.flpWorkouts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpWorkouts.AutoScroll = True
        Me.flpWorkouts.BackColor = System.Drawing.Color.Transparent
        Me.flpWorkouts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpWorkouts.Location = New System.Drawing.Point(45, 112)
        Me.flpWorkouts.Name = "flpWorkouts"
        Me.flpWorkouts.Size = New System.Drawing.Size(985, 616)
        Me.flpWorkouts.TabIndex = 4
        Me.flpWorkouts.WrapContents = False
        '
        'flpLib
        '
        Me.flpLib.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpLib.AutoScroll = True
        Me.flpLib.BackColor = System.Drawing.Color.Transparent
        Me.flpLib.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpLib.Location = New System.Drawing.Point(10, 125)
        Me.flpLib.Name = "flpLib"
        Me.flpLib.Size = New System.Drawing.Size(250, 641)
        Me.flpLib.TabIndex = 3
        Me.flpLib.WrapContents = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1555, 766)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlLibrary)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hevy"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlLogo.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.pnlLibrary.ResumeLayout(False)
        Me.pnlLibrary.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlLogo As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnWorkout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlMain As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents sidebarTimer As System.Windows.Forms.Timer
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNewWorkout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblLibTitle As Label
    Friend WithEvents btnCustomExercise As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlLibrary As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents flpWorkouts As FlowLayoutPanel
    Friend WithEvents flpLib As FlowLayoutPanel
End Class