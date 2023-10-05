Imports System.Globalization

Public Class Reserve

    Private Sub tmrReserve_Tick(sender As Object, e As EventArgs) Handles tmrReserve.Tick
        lblDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
    End Sub

    Private Sub Reserve_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        rActivated()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ShowForm(EmpUI, Me)
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Logout(Me)
    End Sub

    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        GReserve(txtRoomNumber.Text, txtGuestID.Text, txtName.Text, dtpCheckIn.Text, dtpCheckOut.Text, txtPayment.Text)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        CancelReserve(txtRoomNumber.Text, txtGuestID.Text, txtName.Text, dtpCheckIn.Text, dtpCheckOut.Text, txtPayment.Text)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtclearR()
    End Sub

    Private Sub dgvAvailable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAvailable.CellClick
        dtpCheckOut.MinDate = DateAdd(DateInterval.Day, 1, Now)
        dtpCheckIn.MinDate = Now
        txtPayment.Text = ""
        txtPayment.Enabled = True
        rTable()
        Try
            Dim i = e.RowIndex
            With dgvAvailable
                txtRoomNumber.Text = .Item("Room No.", i).Value

            End With
            btnReserve.Enabled = True
            btnCancel.Enabled = True
        Catch ex As Exception
            'MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub dgGuest_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGuest.CellClick
        dtpCheckOut.MinDate = DateAdd(DateInterval.Day, 1, Now)
        dtpCheckIn.MinDate = Now
        txtPayment.Text = ""
        txtPayment.Enabled = True
        rTable()
        Try
            Dim i = e.RowIndex
            With dgvGuest
                txtGuestID.Text = .Item("ID", i).Value
                txtName.Text = .Item("Guest Name", i).Value

            End With
            btnReserve.Enabled = True
            btnCancel.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub dgvReserve_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReserve.CellClick
        dtpCheckOut.MinDate = DateAdd(DateInterval.Day, -1, Now)
        dtpCheckIn.MinDate = DateAdd(DateInterval.Day, -1, Now)
        txtPayment.Enabled = False
        rTable()
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
            btnReserve.Enabled = True
            btnCancel.Enabled = True
        Catch ex As Exception
            'MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub
End Class