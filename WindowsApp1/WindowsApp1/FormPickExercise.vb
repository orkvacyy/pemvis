Imports System.Data
Imports Guna.UI2.WinForms

Public Class FormPickExercise

    Public Property highlightExerciseId As Integer = 0
    Public Property execNameSelect As String = ""


    Private Sub FormPickExercise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cmbFilter.Items.Count > 0 Then
            cmbFilter.SelectedIndex = 0
        End If
        refreshList("", cmbFilter.SelectedItem.ToString())
    End Sub



    Private Sub refreshList(search As String, muscleFilter As String)
        lstExercises.Items.Clear()

        Dim dtResult As DataTable = DataModule.searchExec(search, muscleFilter)

        For Each row As DataRow In dtResult.Rows
            Dim id As Integer = CInt(row("id"))
            Dim name As String = row("name").ToString()
            Dim muscle As String = row("muscle_group").ToString()
            Dim isCustom As Boolean = Not IsDBNull(row("user_id"))

            Dim displayName As String = If(isCustom, $"👤 {name}", name)
            lstExercises.Items.Add(New ExerciseItem(id, displayName, muscle))
        Next
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        refreshList(txtSearch.Text, If(cmbFilter.SelectedItem?.ToString(), "All"))
    End Sub

    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged
        refreshList(txtSearch.Text, If(cmbFilter.SelectedItem?.ToString(), "All"))
    End Sub

    Private Sub lstExercises_DoubleClick(sender As Object, e As EventArgs) Handles lstExercises.DoubleClick
        invalidHandling()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        invalidHandling()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub invalidHandling()
        If lstExercises.SelectedIndex < 0 Then
            MessageBox.Show("exercise wajib di isi", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim item = CType(lstExercises.SelectedItem, ExerciseItem)
        highlightExerciseId = item.Id
        execNameSelect = item.Name
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub pnlSearch_Paint(sender As Object, e As PaintEventArgs) Handles pnlSearch.Paint

    End Sub
End Class

Friend Class ExerciseItem
    Public Property Id As Integer
    Public Property Name As String
    Public Property Muscle As String

    Public Sub New(id As Integer, name As String, muscle As String)
        Me.Id = id
        Me.Name = name
        Me.Muscle = muscle
    End Sub

    Public Overrides Function ToString() As String
        Return $"{Name}  [{Muscle}]"
    End Function
End Class