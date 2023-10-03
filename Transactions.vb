﻿Public Class Transactions

    Private Sub lblDateTime_Click(sender As Object, e As EventArgs) Handles lblDateTime.Click
        lblDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
    End Sub

    Private Sub Transactions_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        displayInfo("Select * From reservation_records", dgvRTransaction)
        displayInfo("Select * From checkin_records", dgvCITransaction)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ShowForm(ManUI, Me)
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Logout(Me)
    End Sub
End Class