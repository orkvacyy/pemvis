<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegister
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnKembali = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRegister = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Poppins", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(47, 48)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(290, 65)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Register Hevy"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsername
        '
        Me.txtUsername.BorderRadius = 6
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtUsername.ForeColor = System.Drawing.Color.White
        Me.txtUsername.Location = New System.Drawing.Point(48, 151)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PlaceholderText = "Username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(280, 46)
        Me.txtUsername.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.BorderRadius = 6
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.White
        Me.txtPassword.Location = New System.Drawing.Point(49, 217)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(280, 46)
        Me.txtPassword.TabIndex = 3
        '
        'btnKembali
        '
        Me.btnKembali.BorderRadius = 6
        Me.btnKembali.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnKembali.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnKembali.ForeColor = System.Drawing.Color.White
        Me.btnKembali.Location = New System.Drawing.Point(49, 292)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(138, 46)
        Me.btnKembali.TabIndex = 4
        Me.btnKembali.Text = "Kembali"
        '
        'btnRegister
        '
        Me.btnRegister.BorderRadius = 6
        Me.btnRegister.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(193, 292)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(136, 46)
        Me.btnRegister.TabIndex = 5
        Me.btnRegister.Text = "Register"
        '
        'FormRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(379, 410)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRegister"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnKembali As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRegister As Guna.UI2.WinForms.Guna2Button
End Class
