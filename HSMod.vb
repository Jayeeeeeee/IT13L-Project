Imports System.Data.SQLite

Module HSMod
    Private da As SQLiteDataAdapter
    Private ds As DataSet
    Private dt As DataTable
    Private sqlCommand As SQLiteCommand

    Public sqlConn As New SQLiteConnection("Data Source = " & Application.StartupPath & "\hoteldb.db")
    Public Sub dbOpen()
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

    Public Sub dbClose()
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
            dbOpen()
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

            dbClose()
        End Try
    End Sub

    Public Sub displayInfo(ByVal SQL As String, ByVal DG As DataGridView)
        Try
            dbOpen()
            da = New SQLiteDataAdapter(SQL, sqlConn)
            dt = New DataTable
            da.Fill(dt)
            DG.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Error: displayInfo " + ex.Message)
        Finally
            dbClose()
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

    Public Sub Logout(ByVal Form As Windows.Forms.Form)
        Dim StatusQuery = "Update emp_login Set EmpStatusID = 1 Where EmpStatusID = 2"
        Dim Out As New System.Windows.Forms.DialogResult
        Out = MessageBox.Show("Logout?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Out = Windows.Forms.DialogResult.Yes Then
            SQLProcess(StatusQuery)
            Form.Close()
            Login.Show()
        Else
            Form.Show()
        End If
    End Sub

    Public Sub ShowForm(ByVal SForm As Windows.Forms.Form, CForm As Windows.Forms.Form)
        SForm.Show()
        CForm.Close()
    End Sub

    Public Sub empActivated()
        displayInfo("Select * From rooms_available", EmpUI.dgvAvailable)
        displayInfo("Select * From rooms_occupied", EmpUI.dgvOccupied)
        displayInfo("Select * From rooms_reserved", EmpUI.dgvReserved)
        empTable()
    End Sub

    Public Sub empTable()
        EmpUI.dgvAvailable.ClearSelection()
        EmpUI.dgvOccupied.ClearSelection()
        EmpUI.dgvReserved.ClearSelection()
    End Sub

    Public Sub manActivated()
        Dim RQuery As New SQLiteCommand("Select * From rp", sqlConn)
        Dim ra As New SQLiteDataAdapter(RQuery)
        Dim rdt As New DataTable()
        ra.Fill(rdt)
        ManUI.lblRS.Text = "₱" & rdt.Rows.Item(0).Item("SUM(PAmount)")

        Dim CQuery As New SQLiteCommand("Select SUM(PAmount) From checkin_payment", sqlConn)
        Dim ca As New SQLiteDataAdapter(CQuery)
        Dim cdt As New DataTable()
        ca.Fill(cdt)
        ManUI.lblCS.Text = "₱" & cdt.Rows.Item(0).Item("SUM(PAmount)")

        displayInfo("select * from total_rp", ManUI.dgvRSales)
        displayInfo("select * from total_cip", ManUI.dgvCSales)
        manTable()
    End Sub

    Public Sub manTable()
        ManUI.dgvRSales.ClearSelection()
        ManUI.dgvCSales.ClearSelection()
    End Sub

    Public Sub recsActivated()
        displayInfo("Select * From reservation_records", Transactions.dgvRTransaction)
        displayInfo("Select * From checkin_records", Transactions.dgvCITransaction)
        recsTable()
    End Sub

    Public Sub recsTable()
        Transactions.dgvRTransaction.ClearSelection()
        Transactions.dgvCITransaction.ClearSelection()
    End Sub

End Module
