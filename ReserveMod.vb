Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.Data.SqlTypes

Module ReserveMod
    Public Sub txtclearR()
        Reserve.txtRoomNumber.Text = ""
        Reserve.txtGuestID.Text = ""
        Reserve.txtName.Text = ""
        Reserve.dtpCheckOut.MinDate = DateAdd(DateInterval.Day, 1, Now)
        Reserve.dtpCheckIn.MinDate = Now
        Reserve.txtPayment.Text = ""
    End Sub

    Public Sub GReserve(ByVal RNum As Integer, GID As String, Name As String, ChckIn As String, ChckOut As String, Payment As Integer)
        If String.IsNullOrWhiteSpace(RNum) Or String.IsNullOrWhiteSpace(GID) Or String.IsNullOrWhiteSpace(Name) Or String.IsNullOrWhiteSpace(Payment) Then
            MessageBox.Show("Some fields are empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim RRoom As New System.Windows.Forms.DialogResult
            RRoom = MessageBox.Show("Reserve Room No. " & RNum & "?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If RRoom = Windows.Forms.DialogResult.Yes Then
                Dim gReserve = "Insert Into reservation Values(null, '" & GID & "', '" & RNum & "', '" & ChckIn & "', '" & ChckOut & "', '" & 1 & "')"
                SQLProcess(gReserve)

                Dim ReserveRoom = "Update rooms Set RoomStatusID = 2 Where RoomID = '" & RNum & "'"
                SQLProcess(ReserveRoom)

                Dim CStatus = "Update guests Set CStatusID = 2  Where GuestID = '" & GID & "'"
                SQLProcess(CStatus)

                Dim EmpQuery As New SQLiteCommand("Select EmpID From emp_login Where EmpStatusID = 2", sqlConn)
                Dim da As New SQLiteDataAdapter(EmpQuery)
                Dim dt As New DataTable()
                da.Fill(dt)

                Dim ReserveQuery As New SQLiteCommand("Select ReservationID From reservation Where GuestID ='" & GID & "' and RoomID = '" & RNum & "'", sqlConn)
                Dim rda As New SQLiteDataAdapter(ReserveQuery)
                Dim rdt As New DataTable()
                rda.Fill(rdt)

                Dim PriceQuery As New SQLiteCommand("Select RoomPrice From room_type Where RoomTypeID In (Select RoomTypeID From Rooms Where RoomID ='" & RNum & "')", sqlConn)
                Dim pda As New SQLiteDataAdapter(PriceQuery)
                Dim pdt As New DataTable()
                pda.Fill(pdt)


                Dim Change As Integer = Payment - pdt.Rows.Item(0).Item("RoomPrice")

                Dim ReservePayment = "Insert Into reservation_payment Values(null, '" _
                                                                            & rdt.Rows.Item(0).Item("ReservationID") & "', '" _
                                                                            & dt.Rows.Item(0).Item("EmpID") & "', '" _
                                                                            & GID & "', '" _
                                                                            & RNum & "', '" _
                                                                            & Payment & "', '" _
                                                                            & Change & "', '" _
                                                                            & Reserve.lblDateTime.Text & "')"
                SQLProcess(ReservePayment)

                MessageBox.Show("Reserved!" & vbCrLf &
                                "Room No.: " & RNum & vbCrLf &
                                "Guest Name: " & Name & vbCrLf &
                                "Check-In Date: " & ChckIn & vbCrLf &
                                "Check-Out Date: " & ChckOut & vbCrLf &
                                "Payment Amount: ₱" & Payment & vbCrLf &
                                "Payment Change: ₱" & Change,
                                "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cleartxt()
            Else
                Reserve.Show()
            End If
        End If
    End Sub
End Module
