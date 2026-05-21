Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class FormUserPopup
    Private _userId As Integer = 0
    Private _isEdit As Boolean = False

    Public Sub SetUserData(id As Integer, username As String, password As String, role As String)
        _userId = id
        _isEdit = True
        txtUsername.Text = username
        txtPassword.Text = password
        cmbRole.SelectedItem = role
        lblTitle.Text = "Edit User Account"
    End Sub

    Private Sub FormUserPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not _isEdit Then
            cmbRole.SelectedIndex = 1
            lblTitle.Text = "Add New User"
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim role As String = If(cmbRole.SelectedItem IsNot Nothing, cmbRole.SelectedItem.ToString(), "user")

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Username dan Password tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not Regex.IsMatch(txtUsername.Text, "[a-zA-Z0-9]") Then
            MessageBox.Show("Error: Username harus mengandung huruf atau angka, tidak boleh hanya simbol.", "Validasi Gagal")
            Exit Sub
        End If
        If username.Length < 3 Then
            MessageBox.Show("Username minimal 3 karakter!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If password.Length < 4 Then
            MessageBox.Show("Password minimal 4 karakter!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim success As Boolean = False
        If _isEdit Then
            success = DataModule.EditUser(_userId, username, password, role)
        Else
            success = DataModule.AddUser(username, password, role)
        End If

        If success Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
