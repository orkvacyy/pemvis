Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class FormLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Validasi input kosong
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not Regex.IsMatch(txtUsername.Text, "[a-zA-Z0-9]") Then
            ' Jika tidak ada huruf atau angka sama sekali (hanya simbol/kosong)
            MessageBox.Show("Error: Username harus mengandung huruf atau angka, tidak boleh hanya simbol.", "Validasi Gagal")
            Exit Sub
        End If

        If DataModule.LoginUser(txtUsername.Text.Trim(), txtPassword.Text) Then
            Dim mainForm As New Form1()
            Me.Hide()
            mainForm.ShowDialog()
            Me.Close()
        Else
            MessageBox.Show("Username atau Password salah!", "Login Gagal",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
            txtPassword.Focus()
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Buka FormRegister, bukan langsung register
        Dim regForm As New FormRegister()
        Me.Hide()
        regForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class