Imports System.Windows.Forms

Public Class FormRegister

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtUsername.Text.Trim().Length < 3 Then
            MessageBox.Show("Username minimal 3 karakter!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtPassword.Text.Length < 4 Then
            MessageBox.Show("Password minimal 4 karakter!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If DataModule.RegisterUser(txtUsername.Text.Trim(), txtPassword.Text) Then
            MessageBox.Show("Registrasi berhasil! Silakan login.", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

End Class