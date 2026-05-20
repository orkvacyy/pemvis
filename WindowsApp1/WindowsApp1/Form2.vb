Imports System.Windows.Forms

Public Class Form2
    Public Property editTemp As Boolean = False
    Public Property idExecSekarang As Integer = 0
    Public Sub SetEditData(id As Integer, name As String, muscle As String, equip As String)
        editTemp = True
        idExecSekarang = id
        txtExName.Text = name
        cmbMuscle.Text = muscle
        cmbEq.Text = equip


        Me.Text = "Edit Custom Exercise"
        lblTitle.Text = "Edit Custom Exercise"
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtExName.Text) Then
            MessageBox.Show("Please enter an exercise name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim success As Boolean = False
        If editTemp Then
            success = DataModule.editExec(idExecSekarang, txtExName.Text, cmbMuscle.Text, cmbEq.Text)
        Else
            success = DataModule.addExec(txtExName.Text, cmbMuscle.Text, cmbEq.Text)
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