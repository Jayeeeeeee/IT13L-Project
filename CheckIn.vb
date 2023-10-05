Imports System.Globalization

Public Class CheckIn

    Private Sub tmrCheck_Tick(sender As Object, e As EventArgs) Handles tmrCheck.Tick
        lblDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
    End Sub
    Private Sub CheckIn_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        chckinActivated()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ShowForm(EmpUI, Me)
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Logout(Me)
    End Sub

    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        GCheckIn(txtRoomNumber.Text, txtGuestID.Text, txtName.Text, dtpCheckIn.Text, dtpCheckOut.Text, txtPayment.Text)
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        GCheckOut(txtRoomNumber.Text, txtGuestID.Text, txtName.Text, dtpCheckIn.Text, dtpCheckOut.Text)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cleartxtCI()
    End Sub

    Private Sub dgGuest_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGuest.CellClick
        dtpCheckOut.MinDate = DateAdd(DateInterval.Day, 1, Now)
        dtpCheckIn.MinDate = Now
        txtPayment.Text = ""
        txtPayment.Enabled = True
        cTable()
        Try
            Dim i = e.RowIndex
            With dgvGuest
                txtGuestID.Text = .Item("ID", i).Value
                txtName.Text = .Item("Guest Name", i).Value

            End With
            btnCheckIn.Enabled = True
            btnCheckOut.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub dgvReserve_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReserve.CellClick
        dtpCheckOut.MinDate = DateAdd(DateInterval.Day, -1, Now)
        dtpCheckIn.MinDate = DateAdd(DateInterval.Day, -1, Now)
        txtPayment.Enabled = False
        cTable()
        Try
            Dim i = e.RowIndex
            With dgvReserve
                Dim chckin As DateTime = DateTime.ParseExact(.Item("Check-In Date", i).Value, "MM/dd/yyyy - h:mm tt", CultureInfo.InvariantCulture)
                Dim chckout As DateTime = DateTime.ParseExact(.Item("Check-Out Date", i).Value, "MM/dd/yyyy - h:mm tt", CultureInfo.InvariantCulture)

                txtRoomNumber.Text = .Item("Room No.", i).Value
                txtGuestID.Text = .Item("ID", i).Value
                txtName.Text = .Item("Guest Name", i).Value
                dtpCheckIn.Value = chckin
                dtpCheckOut.Value = chckout
                txtPayment.Text = .Item("Reservation Payment", i).Value


            End With
            btnCheckIn.Enabled = True
            btnCheckOut.Enabled = True
        Catch ex As Exception
            'MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub dgvCheckedIn_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCheckedIn.CellClick
        dtpCheckOut.MinDate = DateAdd(DateInterval.Day, -1, Now)
        dtpCheckIn.MinDate = DateAdd(DateInterval.Day, -1, Now)
        txtPayment.Enabled = False
        cTable()
        Try
            Dim i = e.RowIndex
            With dgvCheckedIn
                Dim chckin As DateTime = Date.ParseExact(.Item("Check-In Date", i).Value, "MM/dd/yyyy - h:mm tt", CultureInfo.InvariantCulture)
                Dim chckout As DateTime = Date.ParseExact(.Item("Check-Out Date", i).Value, "MM/dd/yyyy - h:mm tt", CultureInfo.InvariantCulture)

                txtRoomNumber.Text = .Item("Room No.", i).Value
                txtGuestID.Text = .Item("ID", i).Value
                txtName.Text = .Item("Guest Name", i).Value
                dtpCheckIn.Text = chckin
                dtpCheckOut.Text = chckout

            End With
            btnCheckIn.Enabled = True
            btnCheckOut.Enabled = True
        Catch ex As Exception
            'MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub dgvAvailable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAvailable.CellClick
        dtpCheckOut.MinDate = DateAdd(DateInterval.Day, 1, Now)
        dtpCheckIn.MinDate = Now
        txtPayment.Text = ""
        txtPayment.Enabled = True
        cTable()
        Try
            Dim i = e.RowIndex
            With dgvAvailable
                txtRoomNumber.Text = .Item("Room No.", i).Value

            End With
            btnCheckIn.Enabled = True
            btnCheckOut.Enabled = True
        Catch ex As Exception
            'MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub
End Class