Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.Data.SqlTypes

Module CheckInMod

    Public Sub cleartxtCI()
        CheckIn.txtRoomNumber.Text = ""
        CheckIn.txtGuestID.Text = ""
        CheckIn.txtName.Text = ""
        CheckIn.dtpCheckOut.MinDate = DateAdd(DateInterval.Day, 1, Now)
        CheckIn.dtpCheckIn.MinDate = Now
        CheckIn.txtPayment.Text = ""
    End Sub

    Public Sub chckinActivated()
        displayInfo("Select * From guest_avail", CheckIn.dgvGuest)
        displayInfo("Select * From guest_checkedin", CheckIn.dgvCheckedIn)
        displayInfo("Select * From rooms_available", CheckIn.dgvAvailable)
        displayInfo("Select * From guest_reservation", CheckIn.dgvReserve)
        cTable()
    End Sub

    Public Sub cTable()
        CheckIn.dgvGuest.ClearSelection()
        CheckIn.dgvCheckedIn.ClearSelection()
        CheckIn.dgvAvailable.ClearSelection()
        CheckIn.dgvReserve.ClearSelection()
    End Sub


    Public Sub GCheckIn(ByVal RNum As Integer, GID As String, Name As String, ChckIn As String, ChckOut As String, Payment As Integer)
        If String.IsNullOrWhiteSpace(RNum) Or String.IsNullOrWhiteSpace(GID) Or String.IsNullOrWhiteSpace(Name) Then
            MessageBox.Show("Some fields are empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim CIn As New System.Windows.Forms.DialogResult
            CIn = MessageBox.Show("Check-In On Room No. " & RNum & "?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If CIn = Windows.Forms.DialogResult.Yes Then
                Dim gCheckIn = "Insert Into checkin Values(null, '" _
                                                         & GID & "', '" _
                                                         & RNum & "', '" _
                                                         & ChckIn & "', '" _
                                                         & ChckOut & "', '" _
                                                         & 1 & "')"
                SQLProcess(gCheckIn)

                'Dim ReserveStatus = "Update reservation_payment Set RStatusID = 2 Where RoomID = '" & txtRoomNumber.Text & "' And GuestID = '" & txtGuestID.Text & "'"
                'SQLProcess(ReserveStatus)

                Dim CheckInRoom = "Update rooms Set RoomStatusID = 3 Where RoomID = '" & RNum & "'"
                SQLProcess(CheckInRoom)

                Dim RStatus = "Update reservation Set RStatusID = 2  where RoomID = '" & RNum &
                                                                         "' And GuestID = '" & GID &
                                                                         "' And CIDate = '" & ChckIn &
                                                                         "' And CODate = '" & ChckOut & "'"
                SQLProcess(RStatus)

                Dim CStatus = "Update guests Set CStatusID = 1  Where GuestID = '" & GID & "'"
                SQLProcess(CStatus)

                Dim EmpQuery As New SQLiteCommand("Select EmpID From emp_login Where EmpStatusID = 2", sqlConn)
                Dim da As New SQLiteDataAdapter(EmpQuery)
                Dim dt As New DataTable()
                da.Fill(dt)

                Dim ChckinQuery As New SQLiteCommand("Select ChckID From checkin Where GuestID ='" & GID &
                                                    "' and RoomID = '" & RNum & "'", sqlConn)
                Dim cda As New SQLiteDataAdapter(ChckinQuery)
                Dim cdt As New DataTable()
                cda.Fill(cdt)

                Dim PriceQuery As New SQLiteCommand("Select RoomPrice From room_type Where RoomTypeID In (Select RoomTypeID From Rooms Where RoomID ='" & RNum & "')", sqlConn)
                Dim pda As New SQLiteDataAdapter(PriceQuery)
                Dim pdt As New DataTable()
                pda.Fill(pdt)

                Dim ChckStatus As New SQLiteCommand("Select RoomStatusID From rooms Where RoomID = '" & RNum & "'", sqlConn)
                Dim csda As New SQLiteDataAdapter(ChckStatus)
                Dim csdt As New DataTable()
                csda.Fill(csdt)

                'CheckIn
                Dim Change As Integer = Payment - pdt.Rows.Item(0).Item("RoomPrice")
                Dim CheckInPayment = "Insert Into checkin_payment Values(null, '" _
                                                                            & cdt.Rows.Item(0).Item("ChckID") &
                                                                            "', '" & dt.Rows.Item(0).Item("EmpID") &
                                                                            "', '" & GID &
                                                                            "', '" & RNum &
                                                                            "', '" & Payment &
                                                                            "', '" & Change &
                                                                            "', '" & CheckIn.lblDateTime.Text & "')"
                SQLProcess(CheckInPayment)

                MessageBox.Show("Guest Checked-In!" & vbCrLf &
                                    "Room No.: " & RNum & vbCrLf &
                                    "Guest Name: " & CheckIn.txtName.Text & vbCrLf &
                                    "Check-In Date: " & ChckIn & vbCrLf &
                                    "Check-Out Date: " & ChckOut & vbCrLf &
                                    "Payment Amount: ₱" & Payment & vbCrLf &
                                    "Payment Change: ₱" & Change,
                                    "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cleartxtCI()
            Else
                CheckIn.Show()
            End If
        End If
    End Sub

    Public Sub GCheckOut(ByVal RNum As Integer, GID As String, Name As String, ChckIn As String, ChckOut As String)
        If String.IsNullOrWhiteSpace(RNum) Or String.IsNullOrWhiteSpace(GID) Or String.IsNullOrWhiteSpace(Name) Then
            MessageBox.Show("Some fields are empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim COut As New System.Windows.Forms.DialogResult
            COut = MessageBox.Show("Check-Out On Room No. " & RNum & "?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If COut = Windows.Forms.DialogResult.Yes Then
                Dim CheckOutStatus = "Update checkin Set ChckStatusID = 2 where RoomID = '" & RNum &
                                                                         "' And GuestID = '" & GID &
                                                                         "' And CIDate = '" & ChckIn &
                                                                         "' And CODate = '" & ChckOut & "'"
                SQLProcess(CheckOutStatus)

                Dim CheckInRoom = "Update rooms Set RoomStatusID = 1 Where RoomID = '" & RNum & "'"
                SQLProcess(CheckInRoom)

                Dim CStatus = "Update guests Set CStatusID = 3  Where GuestID = '" & GID & "'"
                SQLProcess(CStatus)

                'Dim ReserveStatus = "Update reservation_payment Set RStatusID = 3 Where RoomID = '" & txtRoomNumber.Text & "' And GuestID = '" & txtGuestID.Text & "'"
                'SQLProcess(ReserveStatus)

                Dim RStatus = "Update reservation Set RStatusID = 3  where RoomID = '" & RNum &
                                                                         "' And GuestID = '" & GID &
                                                                         "' And CIDate = '" & ChckIn &
                                                                         "' And CODate = '" & ChckOut & "'"
                SQLProcess(RStatus)

                MessageBox.Show("Guest Checked-Out!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                cleartxtCI()
            Else
                CheckIn.Show()
            End If
        End If
    End Sub
End Module
