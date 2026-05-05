Imports MySqlConnector
Imports System.Data
Imports System.Windows.Forms

Module DataModule
    Public Function getExec() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter("SELECT * FROM exercises ORDER BY name ASC", conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal ambil data exercise: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function addExec(name As String, muscle As String, equipment As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "INSERT INTO exercises (name, muscle_group, equipment) VALUES (@name, @muscle, @eq)", conn)
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@muscle", muscle)
                    cmd.Parameters.AddWithValue("@eq", equipment)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal simpan exercise: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function editExec(id As Integer, name As String, muscle As String, equipment As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "UPDATE exercises SET name=@name, muscle_group=@muscle, equipment=@eq WHERE id=@id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@muscle", muscle)
                    cmd.Parameters.AddWithValue("@eq", equipment)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal edit exercise: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function delExec(id As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("DELETE FROM exercises WHERE id = @id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal hapus exercise: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function getWorkouts() As DataTable
        Dim dt As New DataTable()
        Try
            Dim sql As String =
                "SELECT w.id, w.name, w.date, w.notes, " &
                "       COUNT(DISTINCT we.id)  AS exercise_count, " &
                "       COUNT(ws.id)           AS set_count " &
                "FROM workouts w " &
                "LEFT JOIN workout_exercises we ON w.id = we.workout_id " &
                "LEFT JOIN workout_sets      ws ON we.id = ws.workout_exercise_id " &
                "GROUP BY w.id, w.name, w.date, w.notes " &
                "ORDER BY w.date DESC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(sql, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal ambil workouts: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function getWorkoutById(id As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter("SELECT * FROM workouts WHERE id = @id", conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", id)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal ambil workout: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ''' <summary>Buat workout baru, kembalikan ID-nya (0 jika gagal).</summary>
    Public Function addWorkout(name As String, notes As String) As Integer
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "INSERT INTO workouts (name, notes) VALUES (@name, @notes)", conn)
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@notes", If(notes, ""))
                    cmd.ExecuteNonQuery()
                End Using
                Using cmd As New MySqlCommand("SELECT LAST_INSERT_ID()", conn)
                    Return CInt(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal tambah workout: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function

    Public Function editWorkout(id As Integer, name As String, notes As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "UPDATE workouts SET name=@name, notes=@notes WHERE id=@id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@notes", If(notes, ""))
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal edit workout: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function delWorkout(id As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("DELETE FROM workouts WHERE id = @id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal hapus workout: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function getWorkoutExercises(workoutId As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Dim sql As String =
                "SELECT we.id, we.workout_id, we.exercise_id, we.order_index, " &
                "       e.name AS exercise_name, e.muscle_group, e.equipment " &
                "FROM workout_exercises we " &
                "INNER JOIN exercises e ON we.exercise_id = e.id " &
                "WHERE we.workout_id = @wid " &
                "ORDER BY we.order_index, we.id"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(sql, conn)
                    da.SelectCommand.Parameters.AddWithValue("@wid", workoutId)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal ambil exercises: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function


    Public Function addWorkoutExercise(workoutId As Integer, exerciseId As Integer) As Integer
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim maxOrder As Integer = 0
                Using cmd As New MySqlCommand(
                    "SELECT COALESCE(MAX(order_index), 0) FROM workout_exercises WHERE workout_id = @wid", conn)
                    cmd.Parameters.AddWithValue("@wid", workoutId)
                    maxOrder = CInt(cmd.ExecuteScalar())
                End Using
                Using cmd As New MySqlCommand(
                    "INSERT INTO workout_exercises (workout_id, exercise_id, order_index) VALUES (@wid, @eid, @ord)", conn)
                    cmd.Parameters.AddWithValue("@wid", workoutId)
                    cmd.Parameters.AddWithValue("@eid", exerciseId)
                    cmd.Parameters.AddWithValue("@ord", maxOrder + 1)
                    cmd.ExecuteNonQuery()
                End Using
                Using cmd As New MySqlCommand("SELECT LAST_INSERT_ID()", conn)
                    Return CInt(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal tambah exercise ke workout: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function

    Public Function delWorkoutExercise(id As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("DELETE FROM workout_exercises WHERE id = @id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal hapus exercise dari workout: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function getWorkoutSets(workoutExerciseId As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(
                    "SELECT * FROM workout_sets WHERE workout_exercise_id = @weid ORDER BY set_number", conn)
                    da.SelectCommand.Parameters.AddWithValue("@weid", workoutExerciseId)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal ambil sets: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function addSet(workoutExerciseId As Integer, weight As Decimal, reps As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim maxSetNum As Integer = 0
                Using cmd As New MySqlCommand(
                    "SELECT COALESCE(MAX(set_number), 0) FROM workout_sets WHERE workout_exercise_id = @weid", conn)
                    cmd.Parameters.AddWithValue("@weid", workoutExerciseId)
                    maxSetNum = CInt(cmd.ExecuteScalar())
                End Using
                Using cmd As New MySqlCommand(
                    "INSERT INTO workout_sets (workout_exercise_id, set_number, weight, reps) VALUES (@weid, @sn, @w, @r)", conn)
                    cmd.Parameters.AddWithValue("@weid", workoutExerciseId)
                    cmd.Parameters.AddWithValue("@sn", maxSetNum + 1)
                    cmd.Parameters.AddWithValue("@w", weight)
                    cmd.Parameters.AddWithValue("@r", reps)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal tambah set: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function editSet(id As Integer, weight As Decimal, reps As Integer, completed As Boolean) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "UPDATE workout_sets SET weight=@w, reps=@r, completed=@c WHERE id=@id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@w", weight)
                    cmd.Parameters.AddWithValue("@r", reps)
                    cmd.Parameters.AddWithValue("@c", If(completed, 1, 0))
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function delSet(id As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("DELETE FROM workout_sets WHERE id = @id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal hapus set: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function searchExec(searchKeyword As String, muscleFilter As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                Dim sql As String = "SELECT * FROM exercises WHERE name LIKE @search"

                If muscleFilter <> "All" Then
                    sql &= " AND muscle_group = @muscle"
                End If

                sql &= " ORDER BY name ASC"

                Using da As New MySqlDataAdapter(sql, conn)
                    da.SelectCommand.Parameters.AddWithValue("@search", "%" & searchKeyword & "%")

                    If muscleFilter <> "All" Then
                        da.SelectCommand.Parameters.AddWithValue("@muscle", muscleFilter)
                    End If

                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data exercise: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

End Module