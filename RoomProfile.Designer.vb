﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomProfile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(RoomProfile))
        btnClear = New Button()
        btnDelete = New Button()
        GroupBox2 = New GroupBox()
        dgvRoom = New DataGridView()
        btnUpdate = New Button()
        GroupBox1 = New GroupBox()
        txtRoomPrice = New TextBox()
        Label4 = New Label()
        cmbAvailability = New ComboBox()
        Label5 = New Label()
        cmbRoomType = New ComboBox()
        txtBeds = New TextBox()
        txtRoomID = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnCreate = New Button()
        btnBack = New Button()
        btnLogOut = New Button()
        lblDateTime = New Label()
        tmrRP = New Timer(components)
        GroupBox2.SuspendLayout()
        CType(dgvRoom, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnClear
        ' 
        btnClear.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnClear.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnClear.Image = My.Resources.Resources.clear1
        btnClear.ImageAlign = ContentAlignment.MiddleRight
        btnClear.Location = New Point(300, 320)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(90, 58)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear"
        btnClear.TextImageRelation = TextImageRelation.ImageBeforeText
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnDelete.Enabled = False
        btnDelete.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnDelete.Image = My.Resources.Resources.delete
        btnDelete.ImageAlign = ContentAlignment.MiddleRight
        btnDelete.Location = New Point(204, 320)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(90, 58)
        btnDelete.TabIndex = 6
        btnDelete.Text = "Delete Room"
        btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.BackColor = Color.Goldenrod
        GroupBox2.Controls.Add(dgvRoom)
        GroupBox2.Font = New Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.ForeColor = Color.Black
        GroupBox2.Location = New Point(396, 40)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(776, 344)
        GroupBox2.TabIndex = 14
        GroupBox2.TabStop = False
        GroupBox2.Text = "Room Information"
        ' 
        ' dgvRoom
        ' 
        dgvRoom.AllowUserToAddRows = False
        dgvRoom.AllowUserToDeleteRows = False
        dgvRoom.AllowUserToResizeColumns = False
        dgvRoom.AllowUserToResizeRows = False
        dgvRoom.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRoom.BackgroundColor = Color.White
        dgvRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRoom.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvRoom.Location = New Point(6, 22)
        dgvRoom.Name = "dgvRoom"
        dgvRoom.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        dgvRoom.RowTemplate.Height = 25
        dgvRoom.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRoom.Size = New Size(764, 316)
        dgvRoom.TabIndex = 0
        dgvRoom.TabStop = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnUpdate.Enabled = False
        btnUpdate.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnUpdate.Image = My.Resources.Resources.edit
        btnUpdate.ImageAlign = ContentAlignment.MiddleRight
        btnUpdate.Location = New Point(108, 320)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(90, 58)
        btnUpdate.TabIndex = 5
        btnUpdate.Text = "Update Room"
        btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.BackColor = Color.Goldenrod
        GroupBox1.Controls.Add(txtRoomPrice)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(cmbAvailability)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(cmbRoomType)
        GroupBox1.Controls.Add(txtBeds)
        GroupBox1.Controls.Add(txtRoomID)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(12, 40)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(378, 274)
        GroupBox1.TabIndex = 13
        GroupBox1.TabStop = False
        ' 
        ' txtRoomPrice
        ' 
        txtRoomPrice.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtRoomPrice.Location = New Point(178, 151)
        txtRoomPrice.Name = "txtRoomPrice"
        txtRoomPrice.ReadOnly = True
        txtRoomPrice.Size = New Size(186, 26)
        txtRoomPrice.TabIndex = 0
        txtRoomPrice.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(22, 154)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 19)
        Label4.TabIndex = 9
        Label4.Text = "Room Price:"
        ' 
        ' cmbAvailability
        ' 
        cmbAvailability.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cmbAvailability.DropDownStyle = ComboBoxStyle.DropDownList
        cmbAvailability.FormattingEnabled = True
        cmbAvailability.Items.AddRange(New Object() {""})
        cmbAvailability.Location = New Point(178, 191)
        cmbAvailability.Name = "cmbAvailability"
        cmbAvailability.Size = New Size(186, 27)
        cmbAvailability.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(8, 194)
        Label5.Name = "Label5"
        Label5.Size = New Size(171, 19)
        Label5.TabIndex = 7
        Label5.Text = "Room Availability:"
        ' 
        ' cmbRoomType
        ' 
        cmbRoomType.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cmbRoomType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRoomType.FormattingEnabled = True
        cmbRoomType.Items.AddRange(New Object() {""})
        cmbRoomType.Location = New Point(178, 71)
        cmbRoomType.Name = "cmbRoomType"
        cmbRoomType.Size = New Size(186, 27)
        cmbRoomType.TabIndex = 2
        ' 
        ' txtBeds
        ' 
        txtBeds.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtBeds.Location = New Point(178, 111)
        txtBeds.Name = "txtBeds"
        txtBeds.ReadOnly = True
        txtBeds.Size = New Size(186, 26)
        txtBeds.TabIndex = 0
        txtBeds.TabStop = False
        ' 
        ' txtRoomID
        ' 
        txtRoomID.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtRoomID.Location = New Point(178, 31)
        txtRoomID.Name = "txtRoomID"
        txtRoomID.Size = New Size(186, 26)
        txtRoomID.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 19)
        Label3.TabIndex = 2
        Label3.Text = "No. Of Beds:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 19)
        Label2.TabIndex = 1
        Label2.Text = "Room Type:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 19)
        Label1.TabIndex = 0
        Label1.Text = "Room No.:"
        ' 
        ' btnCreate
        ' 
        btnCreate.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnCreate.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnCreate.Image = My.Resources.Resources.add1
        btnCreate.ImageAlign = ContentAlignment.MiddleRight
        btnCreate.Location = New Point(12, 320)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(90, 58)
        btnCreate.TabIndex = 4
        btnCreate.Text = "Create Room"
        btnCreate.TextImageRelation = TextImageRelation.ImageBeforeText
        btnCreate.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnBack.Image = My.Resources.Resources.back
        btnBack.ImageAlign = ContentAlignment.MiddleRight
        btnBack.Location = New Point(12, 11)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(133, 23)
        btnBack.TabIndex = 8
        btnBack.Text = "Back"
        btnBack.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnLogOut.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogOut.Image = My.Resources.Resources.logout
        btnLogOut.ImageAlign = ContentAlignment.MiddleRight
        btnLogOut.Location = New Point(1039, 11)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(133, 23)
        btnLogOut.TabIndex = 9
        btnLogOut.Text = "Logout"
        btnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' lblDateTime
        ' 
        lblDateTime.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblDateTime.AutoSize = True
        lblDateTime.BackColor = Color.Transparent
        lblDateTime.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblDateTime.ForeColor = Color.White
        lblDateTime.Location = New Point(872, 16)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(161, 14)
        lblDateTime.TabIndex = 35
        lblDateTime.Text = "00/00/0000 00:00:00 am"
        ' 
        ' tmrRP
        ' 
        tmrRP.Enabled = True
        tmrRP.Interval = 1000
        ' 
        ' RoomProfile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(34), CByte(34))
        ClientSize = New Size(1184, 396)
        Controls.Add(lblDateTime)
        Controls.Add(btnBack)
        Controls.Add(btnLogOut)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(GroupBox2)
        Controls.Add(btnUpdate)
        Controls.Add(GroupBox1)
        Controls.Add(btnCreate)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MaximumSize = New Size(1200, 435)
        MinimizeBox = False
        MinimumSize = New Size(1200, 435)
        Name = "RoomProfile"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Room Profile"
        GroupBox2.ResumeLayout(False)
        CType(dgvRoom, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvRoom As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbRoomType As ComboBox
    Friend WithEvents txtBeds As TextBox
    Friend WithEvents txtRoomID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents cmbAvailability As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRoomPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents tmrRP As Timer
End Class
