Module RoomMod

    Public Sub rpActivated()
        displayInfo("Select * From room_info", RoomProfile.dgvRoom)
        loadToComboBox("Select * From room_type", RoomProfile.cmbRoomType)
        loadToComboBox("Select * From room_status", RoomProfile.cmbAvailability)
    End Sub

    Public Sub rpCmb()
        If RoomProfile.cmbRoomType.Text = "Single" Then
            RoomProfile.txtBeds.Text = 1
            RoomProfile.txtRoomPrice.Text = 750.0

        ElseIf RoomProfile.cmbRoomType.Text = "Double" Then
            RoomProfile.txtBeds.Text = 2
            RoomProfile.txtRoomPrice.Text = 850.0

        ElseIf RoomProfile.cmbRoomType.Text = "Matrimonial" Then
            RoomProfile.txtBeds.Text = 1
            RoomProfile.txtRoomPrice.Text = 850.0

        End If
    End Sub

    Public Sub cleartxtRP()
        RoomProfile.txtRoomID.Text = ""
        RoomProfile.cmbRoomType.Text = ""
        RoomProfile.txtBeds.Text = ""
        RoomProfile.txtRoomPrice.Text = ""
        RoomProfile.cmbAvailability.Text = ""
    End Sub

    Public Sub CreateRoom(ByVal ID As Integer, Beds As Integer, RoomType As String, Availability As String)
        If String.IsNullOrWhiteSpace(Beds) Or String.IsNullOrWhiteSpace(RoomType) Or String.IsNullOrWhiteSpace(Availability) Then
            MessageBox.Show("Some fields are empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim RoomQuery = "Insert Into rooms Values('" & ID & "', '" & Beds & "', '" & RoomType & "', '" & Availability & "')"
            SQLProcess(RoomQuery)

            MessageBox.Show("Room Added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            cleartxtRP()
        End If
    End Sub

    Public Sub UpdateRoom(ByVal ID As Integer, Beds As Integer, RoomType As String, Availability As String)
        If String.IsNullOrWhiteSpace(Beds) Or String.IsNullOrWhiteSpace(RoomType) Or String.IsNullOrWhiteSpace(Availability) Then
            MessageBox.Show("Some fields are empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim RoomUpdate = "Update rooms Set BedNum = '" & Beds & "' Where RoomID = '" & ID & "'"
            Dim RTypeUpdate = "Update rooms Set RoomTypeID = '" & RoomType & "' Where RoomID = '" & ID & "'"
            Dim RAvailUpdate = "Update rooms Set RoomStatusID = '" & Availability & "' Where RoomID = '" & ID & "'"

            SQLProcess(RoomUpdate)
            SQLProcess(RTypeUpdate)
            SQLProcess(RAvailUpdate)

            MessageBox.Show("Update Successful", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            cleartxtRP()
        End If
    End Sub

    Public Sub DeleteRoom(ByVal ID As Integer, Beds As Integer, RoomType As String, Availability As String)
        If String.IsNullOrWhiteSpace(Beds) Or String.IsNullOrWhiteSpace(RoomType) Or String.IsNullOrWhiteSpace(Availability) Then
            MessageBox.Show("Some fields are empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim RoomDelete As New System.Windows.Forms.DialogResult
            RoomDelete = MessageBox.Show("Delete Room?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If RoomDelete = Windows.Forms.DialogResult.Yes Then
                Dim RDelete = "Delete From rooms where RoomID = '" & ID & "'"

                SQLProcess(RDelete)

                MessageBox.Show("Room Deleted!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                cleartxtRP()
            Else
                RoomProfile.Show()
            End If
        End If
    End Sub

End Module
