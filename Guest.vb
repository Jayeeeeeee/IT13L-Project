Imports System.Runtime.CompilerServices

Public Class Guest

    Private Sub tmrGP_Tick(sender As Object, e As EventArgs) Handles tmrGP.Tick
        lblDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
    End Sub
    Private Sub Guest_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        guestActivated()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ShowForm(EmpUI, Me)
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Logout(Me)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Num As String = txtNumber.Text
        AddGuest(txtGuestID.Text, txtName.Text, txtAddress.Text, Num)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim Num As String = txtNumber.Text
        UpdateGuest(txtGuestID.Text, txtName.Text, txtAddress.Text, Num)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim Num As String = txtNumber.Text
        DeleteGuest(txtGuestID.Text, txtName.Text, txtAddress.Text, Num)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cleartxtG()
    End Sub

    Private Sub dgvGuest_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGuest.CellClick
        rTable()
        Try
            Dim i = e.RowIndex
            With dgvGuest
                txtGuestID.Text = .Item("ID", i).Value
                txtName.Text = .Item("Guest Name", i).Value
                txtAddress.Text = .Item("Address", i).Value
                txtNumber.Text = .Item("Contact No.", i).Value
            End With
            btnDelete.Enabled = True
            btnUpdate.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub
End Class