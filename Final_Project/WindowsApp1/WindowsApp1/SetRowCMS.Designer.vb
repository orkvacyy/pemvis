<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SetRowCMS
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
        Me.lblNum = New System.Windows.Forms.Label()
        Me.txtWeight = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtReps = New Guna.UI2.WinForms.Guna2TextBox()
        Me.chkDone = New System.Windows.Forms.CheckBox()
        Me.btnDelSet = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'lblNum
        '
        Me.lblNum.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lblNum.Location = New System.Drawing.Point(14, 10)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(36, 22)
        Me.lblNum.TabIndex = 0
        Me.lblNum.Text = "1"
        Me.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtWeight
        '
        Me.txtWeight.BorderRadius = 4
        Me.txtWeight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWeight.DefaultText = ""
        Me.txtWeight.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtWeight.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtWeight.ForeColor = System.Drawing.Color.White
        Me.txtWeight.Location = New System.Drawing.Point(60, 6)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.PlaceholderText = "0"
        Me.txtWeight.Size = New System.Drawing.Size(100, 30)
        Me.txtWeight.TabIndex = 1
        '
        'txtReps
        '
        Me.txtReps.BorderRadius = 4
        Me.txtReps.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReps.DefaultText = ""
        Me.txtReps.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtReps.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtReps.ForeColor = System.Drawing.Color.White
        Me.txtReps.Location = New System.Drawing.Point(180, 6)
        Me.txtReps.Name = "txtReps"
        Me.txtReps.PlaceholderText = "0"
        Me.txtReps.Size = New System.Drawing.Size(64, 30)
        Me.txtReps.TabIndex = 2
        '
        'chkDone
        '
        Me.chkDone.AutoSize = True
        Me.chkDone.Location = New System.Drawing.Point(270, 13)
        Me.chkDone.Name = "chkDone"
        Me.chkDone.Size = New System.Drawing.Size(15, 14)
        Me.chkDone.TabIndex = 3
        Me.chkDone.UseVisualStyleBackColor = True
        '
        'btnDelSet
        '
        Me.btnDelSet.BorderRadius = 4
        Me.btnDelSet.FillColor = System.Drawing.Color.Transparent
        Me.btnDelSet.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelSet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDelSet.Location = New System.Drawing.Point(305, 7)
        Me.btnDelSet.Name = "btnDelSet"
        Me.btnDelSet.Size = New System.Drawing.Size(26, 26)
        Me.btnDelSet.TabIndex = 4
        Me.btnDelSet.Text = "×"
        '
        'SetRowCMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Controls.Add(Me.btnDelSet)
        Me.Controls.Add(Me.chkDone)
        Me.Controls.Add(Me.txtReps)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.lblNum)
        Me.Margin = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.Name = "SetRowCMS"
        Me.Size = New System.Drawing.Size(340, 40)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNum As Windows.Forms.Label
    Friend WithEvents txtWeight As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtReps As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents chkDone As Windows.Forms.CheckBox
    Friend WithEvents btnDelSet As Guna.UI2.WinForms.Guna2Button

End Class