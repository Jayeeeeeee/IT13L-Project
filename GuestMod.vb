Module GuestMod
    Public Sub cleartxtG()
        Guest.txtGuestID.Clear()
        Guest.txtName.Clear()
        Guest.txtAddress.Clear()
        Guest.txtNumber.Clear()
        gEnable()
    End Sub

    Public Sub gDisable()
        Guest.txtGuestID.Enabled = False
    End Sub

    Public Sub gEnable()
        Guest.txtGuestID.Enabled = True
    End Sub

    Public Sub guestActivated()
        displayInfo("Select * From guest_info", Guest.dgvGuest)
        gTable()
    End Sub

    Public Sub gTable()
        Guest.dgvGuest.ClearSelection()
    End Sub

    Public Sub AddGuest(ByVal ID As Integer, Name As String, Address As String, Number As String)
        If String.IsNullOrWhiteSpace(Name) Or String.IsNullOrWhiteSpace(Address) Or String.IsNullOrWhiteSpace(Number) Then
            MessageBox.Show("Some fields are empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim AddGuest = "Insert Into guests Values('" & ID & "', '" & Name & "', '" & Address & "', '" & Number & "', '" & 3 & "')"

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
