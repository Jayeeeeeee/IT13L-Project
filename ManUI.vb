﻿Imports System.Data.SqlClient
Imports System.Data.SQLite

Public Class ManUI
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Logout(Me)
    End Sub

    Private Sub btnRoomProfile_Click(sender As Object, e As EventArgs) Handles btnRoomProfile.Click
        ShowForm(RoomProfile, Me)
    End Sub

    Private Sub btnDash_Click(sender As Object, e As EventArgs) Handles btnDash.Click
        ShowForm(Transactions, Me)
    End Sub

    Private Sub ManUI_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        manActivated()
    End Sub

    Private Sub dgvRSales_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRSales.CellClick
        manTable()
    End Sub

    Private Sub dgvCSales_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCSales.CellClick
        manTable()
    End Sub
End Class