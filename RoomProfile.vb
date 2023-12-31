﻿Public Class RoomProfile

    Private Sub tmrRP_Tick(sender As Object, e As EventArgs) Handles tmrRP.Tick
        lblDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ShowForm(ManUI, Me)
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Logout(Me)
    End Sub

    Private Sub RoomProfile_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        rpActivated()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cleartxtRP()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        CreateRoom(txtRoomID.Text, txtBeds.Text, cmbRoomType.SelectedValue, cmbAvailability.SelectedValue)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateRoom(txtRoomID.Text, txtBeds.Text, cmbRoomType.SelectedValue, cmbAvailability.SelectedValue)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteRoom(txtRoomID.Text, txtBeds.Text, cmbRoomType.SelectedValue, cmbAvailability.SelectedValue)
    End Sub

    Private Sub cmbRoomType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRoomType.SelectedIndexChanged
        rpCmb()
    End Sub

    Private Sub dgvRoom_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRoom.CellClick
        rpTable()
        Try
            Dim i = e.RowIndex
            With dgvRoom
                txtRoomID.Text = .Item("Room No.", i).Value
                cmbRoomType.Text = .Item("Room Type", i).Value
                txtBeds.Text = .Item("No. Of Beds", i).Value
                txtRoomPrice.Text = .Item("Room Price", i).Value
                cmbAvailability.Text = .Item("Room Status", i).Value
            End With
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub
End Class