﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guest
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Guest))
        btnAdd = New Button()
        btnBack = New Button()
        btnLogOut = New Button()
        btnClear = New Button()
        btnDelete = New Button()
        GroupBox2 = New GroupBox()
        dgvGuest = New DataGridView()
        GroupBox1 = New GroupBox()
        txtName = New TextBox()
        txtAddress = New TextBox()
        txtNumber = New TextBox()
        txtGuestID = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnUpdate = New Button()
        lblDateTime = New Label()
        tmrGP = New Timer(components)
        Panel1 = New Panel()
        GroupBox2.SuspendLayout()
        CType(dgvGuest, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnAdd.Image = My.Resources.Resources.gadd
        btnAdd.ImageAlign = ContentAlignment.MiddleRight
        btnAdd.Location = New Point(12, 315)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(90, 68)
        btnAdd.TabIndex = 5
        btnAdd.Text = "Add New Guest"
        btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnBack.Image = My.Resources.Resources.back
        btnBack.ImageAlign = ContentAlignment.MiddleRight
        btnBack.Location = New Point(3, 3)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(133, 22)
        btnBack.TabIndex = 9
        btnBack.Text = "Back"
        btnBack.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnLogOut.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogOut.Image = My.Resources.Resources.login1
        btnLogOut.ImageAlign = ContentAlignment.MiddleRight
        btnLogOut.Location = New Point(1391, 3)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(133, 22)
        btnLogOut.TabIndex = 10
        btnLogOut.Text = "Logout"
        btnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnClear.Image = CType(resources.GetObject("btnClear.Image"), Image)
        btnClear.ImageAlign = ContentAlignment.MiddleRight
        btnClear.Location = New Point(300, 315)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(90, 68)
        btnClear.TabIndex = 8
        btnClear.Text = "Clear"
        btnClear.TextImageRelation = TextImageRelation.ImageBeforeText
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Enabled = False
        btnDelete.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnDelete.Image = My.Resources.Resources.gdelete
        btnDelete.ImageAlign = ContentAlignment.MiddleRight
        btnDelete.Location = New Point(204, 315)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(90, 68)
        btnDelete.TabIndex = 7
        btnDelete.Text = "Delete Guest"
        btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox2.BackColor = Color.Goldenrod
        GroupBox2.Controls.Add(dgvGuest)
        GroupBox2.Font = New Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.ForeColor = Color.Black
        GroupBox2.Location = New Point(396, 42)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1143, 341)
        GroupBox2.TabIndex = 22
        GroupBox2.TabStop = False
        GroupBox2.Text = "Guest List"
        ' 
        ' dgvGuest
        ' 
        dgvGuest.AllowUserToAddRows = False
        dgvGuest.AllowUserToDeleteRows = False
        dgvGuest.AllowUserToResizeColumns = False
        dgvGuest.AllowUserToResizeRows = False
        dgvGuest.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvGuest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvGuest.BackgroundColor = Color.White
        dgvGuest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGuest.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvGuest.Location = New Point(6, 25)
        dgvGuest.Name = "dgvGuest"
        dgvGuest.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        dgvGuest.RowTemplate.Height = 25
        dgvGuest.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvGuest.Size = New Size(1131, 310)
        dgvGuest.TabIndex = 0
        dgvGuest.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Goldenrod
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(txtAddress)
        GroupBox1.Controls.Add(txtNumber)
        GroupBox1.Controls.Add(txtGuestID)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(12, 42)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(378, 267)
        GroupBox1.TabIndex = 21
        GroupBox1.TabStop = False
        ' 
        ' txtName
        ' 
        txtName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtName.Location = New Point(176, 89)
        txtName.Name = "txtName"
        txtName.Size = New Size(186, 26)
        txtName.TabIndex = 2
        ' 
        ' txtAddress
        ' 
        txtAddress.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtAddress.Location = New Point(176, 131)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(186, 26)
        txtAddress.TabIndex = 3
        ' 
        ' txtNumber
        ' 
        txtNumber.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtNumber.Location = New Point(176, 172)
        txtNumber.Name = "txtNumber"
        txtNumber.Size = New Size(186, 26)
        txtNumber.TabIndex = 4
        ' 
        ' txtGuestID
        ' 
        txtGuestID.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtGuestID.Location = New Point(176, 43)
        txtGuestID.Name = "txtGuestID"
        txtGuestID.Size = New Size(186, 26)
        txtGuestID.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(20, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(144, 19)
        Label4.TabIndex = 7
        Label4.Text = "Contact Number:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(20, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 19)
        Label3.TabIndex = 6
        Label3.Text = "Address:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(20, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 19)
        Label2.TabIndex = 5
        Label2.Text = "Guest Name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(20, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 19)
        Label1.TabIndex = 4
        Label1.Text = "Guest ID:"
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Enabled = False
        btnUpdate.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnUpdate.Image = My.Resources.Resources.gupdate
        btnUpdate.ImageAlign = ContentAlignment.MiddleRight
        btnUpdate.Location = New Point(108, 316)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(90, 67)
        btnUpdate.TabIndex = 6
        btnUpdate.Text = "Update Guest Profile"
        btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' lblDateTime
        ' 
        lblDateTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblDateTime.AutoSize = True
        lblDateTime.BackColor = Color.Transparent
        lblDateTime.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblDateTime.ForeColor = Color.White
        lblDateTime.Location = New Point(1224, 7)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(161, 14)
        lblDateTime.TabIndex = 34
        lblDateTime.Text = "00/00/0000 00:00:00 am"
        ' 
        ' tmrGP
        ' 
        tmrGP.Enabled = True
        tmrGP.Interval = 1000
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(34), CByte(34), CByte(34))
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(lblDateTime)
        Panel1.Controls.Add(btnLogOut)
        Panel1.Location = New Point(12, 11)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1527, 25)
        Panel1.TabIndex = 35
        ' 
        ' Guest
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(34), CByte(34))
        ClientSize = New Size(1551, 396)
        Controls.Add(Panel1)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MaximumSize = New Size(1567, 435)
        MinimizeBox = False
        MinimumSize = New Size(1567, 435)
        Name = "Guest"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Guest Profile"
        GroupBox2.ResumeLayout(False)
        CType(dgvGuest, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvGuest As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents txtGuestID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblDateTime As Label
    Friend WithEvents tmrGP As Timer
    Friend WithEvents Panel1 As Panel
End Class
