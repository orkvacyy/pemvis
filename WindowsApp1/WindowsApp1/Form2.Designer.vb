<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtExName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblMuscle = New System.Windows.Forms.Label()
        Me.cmbMuscle = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblEq = New System.Windows.Forms.Label()
        Me.cmbEq = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(313, 51)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Custom exercise"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.lblName.ForeColor = System.Drawing.Color.LightGray
        Me.lblName.Location = New System.Drawing.Point(22, 65)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(83, 36)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name"
        '
        'txtExName
        '
        Me.txtExName.BorderRadius = 5
        Me.txtExName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtExName.DefaultText = ""
        Me.txtExName.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.txtExName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtExName.ForeColor = System.Drawing.Color.White
        Me.txtExName.Location = New System.Drawing.Point(25, 102)
        Me.txtExName.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.txtExName.Name = "txtExName"
        Me.txtExName.PlaceholderText = "Exercise Name"
        Me.txtExName.SelectedText = ""
        Me.txtExName.Size = New System.Drawing.Size(350, 40)
        Me.txtExName.TabIndex = 2
        '
        'lblMuscle
        '
        Me.lblMuscle.AutoSize = True
        Me.lblMuscle.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.lblMuscle.ForeColor = System.Drawing.Color.LightGray
        Me.lblMuscle.Location = New System.Drawing.Point(22, 150)
        Me.lblMuscle.Name = "lblMuscle"
        Me.lblMuscle.Size = New System.Drawing.Size(175, 36)
        Me.lblMuscle.TabIndex = 3
        Me.lblMuscle.Text = "Muscle Group"
        '
        'cmbMuscle
        '
        Me.cmbMuscle.BackColor = System.Drawing.Color.Transparent
        Me.cmbMuscle.BorderRadius = 5
        Me.cmbMuscle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMuscle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMuscle.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.cmbMuscle.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbMuscle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbMuscle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbMuscle.ForeColor = System.Drawing.Color.White
        Me.cmbMuscle.ItemHeight = 30
        Me.cmbMuscle.Items.AddRange(New Object() {"Chest", "Back", "Legs", "Arms", "Shoulders", "Core", "Cardio", "Other"})
        Me.cmbMuscle.Location = New System.Drawing.Point(25, 189)
        Me.cmbMuscle.Name = "cmbMuscle"
        Me.cmbMuscle.Size = New System.Drawing.Size(350, 36)
        Me.cmbMuscle.StartIndex = 0
        Me.cmbMuscle.TabIndex = 4
        '
        'lblEq
        '
        Me.lblEq.AutoSize = True
        Me.lblEq.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.lblEq.ForeColor = System.Drawing.Color.LightGray
        Me.lblEq.Location = New System.Drawing.Point(22, 235)
        Me.lblEq.Name = "lblEq"
        Me.lblEq.Size = New System.Drawing.Size(139, 36)
        Me.lblEq.TabIndex = 5
        Me.lblEq.Text = "Equipment"
        '
        'cmbEq
        '
        Me.cmbEq.BackColor = System.Drawing.Color.Transparent
        Me.cmbEq.BorderRadius = 5
        Me.cmbEq.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbEq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEq.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.cmbEq.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbEq.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbEq.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbEq.ForeColor = System.Drawing.Color.White
        Me.cmbEq.ItemHeight = 30
        Me.cmbEq.Items.AddRange(New Object() {"None", "Barbell", "Dumbbell", "Machine", "Cables", "Kettlebell", "Band"})
        Me.cmbEq.Location = New System.Drawing.Point(25, 275)
        Me.cmbEq.Name = "cmbEq"
        Me.cmbEq.Size = New System.Drawing.Size(350, 36)
        Me.cmbEq.StartIndex = 0
        Me.cmbEq.TabIndex = 6
        '
        'btnSave
        '
        Me.btnSave.BorderRadius = 5
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(265, 321)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(110, 40)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Me.btnCancel.BorderRadius = 5
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(145, 321)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 40)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(493, 442)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbEq)
        Me.Controls.Add(Me.lblEq)
        Me.Controls.Add(Me.cmbMuscle)
        Me.Controls.Add(Me.lblMuscle)
        Me.Controls.Add(Me.txtExName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Custom Exercise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtExName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblMuscle As System.Windows.Forms.Label
    Friend WithEvents cmbMuscle As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblEq As System.Windows.Forms.Label
    Friend WithEvents cmbEq As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
End Class