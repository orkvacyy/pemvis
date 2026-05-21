<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRegister = New Guna.UI2.WinForms.Guna2Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.BorderRadius = 6
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtUsername.ForeColor = System.Drawing.Color.White
        Me.txtUsername.Location = New System.Drawing.Point(50, 110)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PlaceholderText = "Username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(280, 46)
        Me.txtUsername.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.BorderRadius = 6
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.White
        Me.txtPassword.Location = New System.Drawing.Point(50, 170)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(280, 46)
        Me.txtPassword.TabIndex = 2
        '
        'btnLogin
        '
        Me.btnLogin.BorderRadius = 6
        Me.btnLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(50, 240)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(280, 46)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        '
        'btnRegister
        '
        Me.btnRegister.BorderRadius = 6
        Me.btnRegister.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(50, 300)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(280, 46)
        Me.btnRegister.TabIndex = 4
        Me.btnRegister.Text = "Register"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Poppins", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(79, 40)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(235, 65)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Login Hevy"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(380, 412)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRegister As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
End Class