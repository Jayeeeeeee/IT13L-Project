Imports System.Data.SQLite

Module HSMod
    Private da As SQLiteDataAdapter
    Private ds As DataSet
    Private dt As DataTable
    Private sqlCommand As SQLiteCommand

    Public sqlConn As New SQLiteConnection("Data Source = " & Application.StartupPath & "\hoteldb.db")
    Public Sub OpendbConn()

        Try
            If sqlConn.State = ConnectionState.Closed Then
                sqlConn.Open()
                'MessageBox.Show("Connected")
            End If

        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
            'MessageBox.Show("Connection Error: " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ClosedbConn()

        Try

            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If

        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
            'MessageBox.Show("Connection Error: " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub SQLProcess(ByVal SQL As String)
        Try
            OpendbConn()
            sqlCommand = New SQLiteCommand

            With sqlCommand
                .CommandText = SQL
                .CommandType = CommandType.Text
                .Connection = sqlConn
                .ExecuteNonQuery()
            End With

        Catch ex As Exception
            MessageBox.Show("Error: SQLProcess" + ex.Message)
        Finally

            ClosedbConn()
        End Try
    End Sub

    Public Sub displayInfo(ByVal SQL As String, ByVal DG As DataGridView)
        Try
            OpendbConn()
            da = New SQLiteDataAdapter(SQL, sqlConn)
            dt = New DataTable
            da.Fill(dt)
            DG.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Error: displayInfo " + ex.Message)
        Finally
            ClosedbConn()
        End Try
    End Sub

    Public Sub loadToComboBox(ByVal SQL As String, ByVal cbo As ComboBox)

        Try
            sqlConn.Open()
            da = New SQLiteDataAdapter(SQL, sqlConn)
            dt = New DataTable
            da.Fill(dt)
            cbo.DataSource = dt
            cbo.ValueMember = dt.Columns(0).ToString
            cbo.DisplayMember = dt.Columns(1).ToString

        Catch ex As Exception
            MessageBox.Show("Error: loadtoComboBox " + ex.Message)
        Finally
            sqlConn.Close()
        End Try

    End Sub

End Module
