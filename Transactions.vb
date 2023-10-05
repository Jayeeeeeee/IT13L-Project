Public Class Transactions

    Private Sub tmrRecords_Tick(sender As Object, e As EventArgs) Handles tmrRecords.Tick
        lblDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
    End Sub

    Private Sub Transactions_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        recsActivated()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ShowForm(ManUI, Me)
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Logout(Me)
    End Sub

    Private Sub dgvRTransaction_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRTransaction.CellClick
        recsTable()
    End Sub

    Private Sub dgvCITransaction_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCITransaction.CellClick
        recsTable()
    End Sub
End Class