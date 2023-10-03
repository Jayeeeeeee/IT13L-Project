Public Class EmpUI

    Private Sub EmpUI_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        displayInfo("Select * From rooms_available", dgvAvailable)
        displayInfo("Select * From rooms_occupied", dgvOccupied)
        displayInfo("Select * From rooms_reserved", dgvReserved)
    End Sub

    Private Sub btnGuest_Click(sender As Object, e As EventArgs) Handles btnGuest.Click
        'ShowForm(Guests, Me)
    End Sub

    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        'ShowForm(Reserve, Me)
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        'ShowForm(CheckIn, Me)
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Logout(Me)
    End Sub
End Class