Module GuestMod
    Public Sub cleartxtG()
        Guest.txtGuestID.Text = ""
        Guest.txtName.Text = ""
        Guest.txtAddress.Text = ""
        Guest.txtNumber.Text = ""
    End Sub

    Public Sub guestActivated()
        displayInfo("Select * From guest_info", Guest.dgvGuest)
    End Sub

    Public Sub AddGuest(ByVal ID As Integer, Name As String, Address As String, Number As String)
        If String.IsNullOrWhiteSpace(Name) Or String.IsNullOrWhiteSpace(Address) Or String.IsNullOrWhiteSpace(Number) Then
            MessageBox.Show("Some fields are empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim AddGuest = "Insert Into guests Values(null or '" & ID & "', '" & Name & "', '" & Address & "', '" & Number & "', '" & 3 & "')"

            SQLProcess(AddGuest)

            MessageBox.Show("Guest Added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            cleartxtG()
        End If
    End Sub

    Public Sub UpdateGuest(ByVal ID As Integer, Name As String, Address As String, Number As String)
        If String.IsNullOrWhiteSpace(Name) Or String.IsNullOrWhiteSpace(Address) Or String.IsNullOrWhiteSpace(Number) Then
            MessageBox.Show("Some fields are empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim UGuest = "Update guests Set GName = '" & Name & "', GAddress = '" & Address & "', GNum = '" & Number & "' Where GuestID = '" & ID & "'"
            SQLProcess(UGuest)

            MessageBox.Show("Guest Profile Updated!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            cleartxtG()
        End If
    End Sub

    Public Sub DeleteGuest(ByVal ID As Integer, Name As String, Address As String, Number As String)
        If String.IsNullOrWhiteSpace(Name) Or String.IsNullOrWhiteSpace(Address) Or String.IsNullOrWhiteSpace(Number) Then
            MessageBox.Show("Some fields are empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim GuestDelete As New System.Windows.Forms.DialogResult
            GuestDelete = MessageBox.Show("Delete Guest?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If GuestDelete = Windows.Forms.DialogResult.Yes Then
                Dim GDelete = "Delete From guest_info where ID = '" & ID & "'"
                SQLProcess(GDelete)
                MessageBox.Show("Guest Deleted!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cleartxtG()
            Else
                Guest.Show()
            End If
        End If
    End Sub
End Module
