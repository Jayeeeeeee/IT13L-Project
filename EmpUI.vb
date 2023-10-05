Public Class EmpUI

    Private Sub tmrDash_Tick(sender As Object, e As EventArgs) Handles tmrDash.Tick
        lblDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
    End Sub
    Private Sub EmpUI_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        empActivated()
    End Sub

    Private Sub btnGuest_Click(sender As Object, e As EventArgs) Handles btnGuest.Click
        ShowForm(Guest, Me)
    End Sub

    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        ShowForm(Reserve, Me)
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        ShowForm(CheckIn, Me)
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Logout(Me)
    End Sub

    Private Sub dgvOccupied_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOccupied.CellClick
        empTable()
    End Sub

    Private Sub dgvAvailable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAvailable.CellClick
        empTable()
    End Sub

    Private Sub dgvReserved_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReserved.CellClick
        empTable()
    End Sub
End Class