<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPickExercise
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
        Me.pnlSearch = New Guna.UI2.WinForms.Guna2Panel()
        Me.cmbFilter = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lstExercises = New System.Windows.Forms.ListBox()
        Me.pnlBottom = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnSelect = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlSearch.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSearch
        '
        Me.pnlSearch.Controls.Add(Me.cmbFilter)
        Me.pnlSearch.Controls.Add(Me.txtSearch)
        Me.pnlSearch.Controls.Add(Me.lblTitle)
        Me.pnlSearch.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlSearch.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.pnlSearch.Location = New System.Drawing.Point(0, 0)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(500, 120)
        Me.pnlSearch.TabIndex = 0
        '
        'cmbFilter
        '
        Me.cmbFilter.BackColor = System.Drawing.Color.Transparent
        Me.cmbFilter.BorderRadius = 6
        Me.cmbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilter.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.cmbFilter.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.cmbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.cmbFilter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbFilter.ForeColor = System.Drawing.Color.White
        Me.cmbFilter.ItemHeight = 28
        Me.cmbFilter.Items.AddRange(New Object() {"Chest", "Back", "Legs", "Arms", "Shoulders", "Core", "Cardio", "Other"})
        Me.cmbFilter.Location = New System.Drawing.Point(326, 46)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(158, 34)
        Me.cmbFilter.TabIndex = 2
        '
        'txtSearch
        '
        Me.txtSearch.BorderRadius = 6
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.White
        Me.txtSearch.Location = New System.Drawing.Point(15, 46)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PlaceholderText = "Find exercise..."
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(302, 36)
        Me.txtSearch.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(15, 14)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(236, 45)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Select Exercise"
        '
        'lstExercises
        '
        Me.lstExercises.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lstExercises.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstExercises.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstExercises.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.lstExercises.ForeColor = System.Drawing.Color.White
        Me.lstExercises.FormattingEnabled = True
        Me.lstExercises.ItemHeight = 38
        Me.lstExercises.Location = New System.Drawing.Point(0, 120)
        Me.lstExercises.Name = "lstExercises"
        Me.lstExercises.Size = New System.Drawing.Size(500, 370)
        Me.lstExercises.TabIndex = 1
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.btnSelect)
        Me.pnlBottom.Controls.Add(Me.btnCancel)
        Me.pnlBottom.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlBottom.CustomBorderThickness = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.FillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.pnlBottom.Location = New System.Drawing.Point(0, 490)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(500, 60)
        Me.pnlBottom.TabIndex = 2
        '
        'btnSelect
        '
        Me.btnSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelect.BorderRadius = 7
        Me.btnSelect.FillColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnSelect.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnSelect.ForeColor = System.Drawing.Color.White
        Me.btnSelect.Location = New System.Drawing.Point(390, 10)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(100, 40)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.Text = "Select  ➜"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BorderRadius = 7
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(276, 10)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(105, 40)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        '
        'FormPickExercise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(500, 550)
        Me.Controls.Add(Me.lstExercises)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlSearch)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPickExercise"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select Exercise"
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.pnlBottom.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSearch As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbFilter As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lstExercises As System.Windows.Forms.ListBox
    Friend WithEvents pnlBottom As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSelect As Guna.UI2.WinForms.Guna2Button
End Class