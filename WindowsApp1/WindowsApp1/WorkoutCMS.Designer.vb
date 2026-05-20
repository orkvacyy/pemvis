<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WorkoutCMS
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblMeta = New System.Windows.Forms.Label()
        Me.btnOpen = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDel = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(32, 23)
        Me.lblName.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(233, 41)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Workout Name"
        '
        'lblMeta
        '
        Me.lblMeta.AutoSize = True
        Me.lblMeta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblMeta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.lblMeta.Location = New System.Drawing.Point(32, 77)
        Me.lblMeta.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblMeta.Name = "lblMeta"
        Me.lblMeta.Size = New System.Drawing.Size(407, 32)
        Me.lblMeta.TabIndex = 1
        Me.lblMeta.Text = "Mon, 01 Jan 2026 • 0 exercise • 0 set"
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpen.BorderRadius = 5
        Me.btnOpen.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnOpen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnOpen.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnOpen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnOpen.FillColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnOpen.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnOpen.ForeColor = System.Drawing.Color.White
        Me.btnOpen.Location = New System.Drawing.Point(460, 38)
        Me.btnOpen.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(140, 62)
        Me.btnOpen.TabIndex = 2
        Me.btnOpen.Text = "Open"
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDel.BorderRadius = 5
        Me.btnDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDel.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnDel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnDel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDel.Location = New System.Drawing.Point(610, 38)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(76, 62)
        Me.btnDel.TabIndex = 3
        Me.btnDel.Text = "🗑"
        '
        'WorkoutCMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.lblMeta)
        Me.Controls.Add(Me.lblName)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "WorkoutCMS"
        Me.Size = New System.Drawing.Size(720, 142)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Windows.Forms.Label
    Friend WithEvents lblMeta As Windows.Forms.Label
    Friend WithEvents btnOpen As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDel As Guna.UI2.WinForms.Guna2Button

End Class