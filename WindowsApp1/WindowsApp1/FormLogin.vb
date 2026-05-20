Imports System.Windows.Forms

Public Class FormLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If DataModule.LoginUser(txtUsername.Text, txtPassword.Text) Then
            Dim mainForm As New Form1()
            Me.Hide()
            mainForm.ShowDialog()
            Me.Close()
        Else
            MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If DataModule.RegisterUser(txtUsername.Text, txtPassword.Text) Then
            MessageBox.Show("Registrasi berhasil! Silakan klik Login.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class