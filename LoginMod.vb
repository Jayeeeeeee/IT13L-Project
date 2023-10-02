Imports System.Data.SQLite
Module LoginMod
    Public Sub LoginP(ByVal User As String, Pass As String)
        Dim LoginQuery As New SQLiteCommand("Select EmpUser,EmpPass,EmpTypeID From emp_login Where EmpUser ='" & User & "' and EmpPass = '" & Pass & "'", sqlConn)
        Dim StatusQuery = "Update emp_login Set EmpStatusID = 2 Where EmpUser ='" & User & "' and EmpPass = '" & Pass & "'"
        Dim da As New SQLiteDataAdapter(LoginQuery)
        Dim dt As New DataTable()
        da.Fill(dt)
        If dt.Rows.Count = 0 Then
            MessageBox.Show("Wrong Username or Password!", "Please check your credentials.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cleartxt()

        ElseIf dt.Rows.Item(0).Item("EmpTypeID") = "1" Then
            'Manager Login
            SQLProcess(StatusQuery)
            MessageBox.Show("Successful Manager Login!", "Welcome.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ManUI.Show()
            Login.Hide()

        ElseIf dt.Rows.Item(0).Item("EmpTypeID") = "2" Then
            'Attendant Login
            SQLProcess(StatusQuery)
            MessageBox.Show("Successful Attendant Login!", "Welcome.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            EmpUI.Show()
            Login.Hide()
        End If

    End Sub

    Public Sub cleartxt()
        Login.txtUser.Text = ""
        Login.txtPass.Text = ""
    End Sub
End Module
