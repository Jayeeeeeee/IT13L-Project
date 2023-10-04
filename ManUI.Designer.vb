<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManUI
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ManUI))
        btnLogOut = New Button()
        btnRoomProfile = New Button()
        btnDash = New Button()
        GroupBox1 = New GroupBox()
        lblRS = New Label()
        Label1 = New Label()
        dgvRSales = New DataGridView()
        GroupBox2 = New GroupBox()
        lblCS = New Label()
        Label4 = New Label()
        dgvCSales = New DataGridView()
        GroupBox1.SuspendLayout()
        CType(dgvRSales, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(dgvCSales, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogOut.Image = My.Resources.Resources.logout
        btnLogOut.ImageAlign = ContentAlignment.MiddleRight
        btnLogOut.Location = New Point(687, 12)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(130, 23)
        btnLogOut.TabIndex = 3
        btnLogOut.Text = "Logout"
        btnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' btnRoomProfile
        ' 
        btnRoomProfile.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnRoomProfile.Image = My.Resources.Resources.room_profile
        btnRoomProfile.ImageAlign = ContentAlignment.MiddleRight
        btnRoomProfile.Location = New Point(12, 12)
        btnRoomProfile.Name = "btnRoomProfile"
        btnRoomProfile.Size = New Size(130, 23)
        btnRoomProfile.TabIndex = 1
        btnRoomProfile.Text = "Room Profile"
        btnRoomProfile.TextImageRelation = TextImageRelation.ImageBeforeText
        btnRoomProfile.UseVisualStyleBackColor = True
        ' 
        ' btnDash
        ' 
        btnDash.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnDash.Image = My.Resources.Resources.transactions
        btnDash.ImageAlign = ContentAlignment.MiddleRight
        btnDash.Location = New Point(148, 12)
        btnDash.Name = "btnDash"
        btnDash.Size = New Size(130, 23)
        btnDash.TabIndex = 2
        btnDash.Text = "Transactions"
        btnDash.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDash.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Goldenrod
        GroupBox1.Controls.Add(lblRS)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(dgvRSales)
        GroupBox1.Font = New Font("Consolas", 8F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.Location = New Point(12, 41)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(400, 288)
        GroupBox1.TabIndex = 42
        GroupBox1.TabStop = False
        GroupBox1.Text = "Reservation Sales"
        ' 
        ' lblRS
        ' 
        lblRS.AutoSize = True
        lblRS.Location = New Point(82, 22)
        lblRS.Name = "lblRS"
        lblRS.Size = New Size(13, 13)
        lblRS.TabIndex = 2
        lblRS.Text = " "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 13)
        Label1.TabIndex = 1
        Label1.Text = "Total Sales:"
        ' 
        ' dgvRSales
        ' 
        dgvRSales.AllowUserToAddRows = False
        dgvRSales.AllowUserToDeleteRows = False
        dgvRSales.AllowUserToResizeColumns = False
        dgvRSales.AllowUserToResizeRows = False
        dgvRSales.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvRSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRSales.BackgroundColor = Color.White
        dgvRSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRSales.Location = New Point(6, 38)
        dgvRSales.Name = "dgvRSales"
        dgvRSales.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        dgvRSales.RowTemplate.Height = 25
        dgvRSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRSales.Size = New Size(388, 244)
        dgvRSales.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Goldenrod
        GroupBox2.Controls.Add(lblCS)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(dgvCSales)
        GroupBox2.Font = New Font("Consolas", 8F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.Location = New Point(418, 41)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(400, 288)
        GroupBox2.TabIndex = 43
        GroupBox2.TabStop = False
        GroupBox2.Text = "Check-In Sales"
        ' 
        ' lblCS
        ' 
        lblCS.AutoSize = True
        lblCS.Location = New Point(82, 22)
        lblCS.Name = "lblCS"
        lblCS.Size = New Size(13, 13)
        lblCS.TabIndex = 2
        lblCS.Text = " "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 22)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 13)
        Label4.TabIndex = 1
        Label4.Text = "Total Sales:"
        ' 
        ' dgvCSales
        ' 
        dgvCSales.AllowUserToAddRows = False
        dgvCSales.AllowUserToDeleteRows = False
        dgvCSales.AllowUserToResizeColumns = False
        dgvCSales.AllowUserToResizeRows = False
        dgvCSales.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvCSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCSales.BackgroundColor = Color.White
        dgvCSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCSales.Location = New Point(6, 38)
        dgvCSales.Name = "dgvCSales"
        dgvCSales.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        dgvCSales.RowTemplate.Height = 25
        dgvCSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCSales.Size = New Size(388, 244)
        dgvCSales.TabIndex = 0
        ' 
        ' ManUI
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(34), CByte(34))
        ClientSize = New Size(829, 341)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(btnLogOut)
        Controls.Add(btnDash)
        Controls.Add(btnRoomProfile)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MaximumSize = New Size(845, 380)
        MinimizeBox = False
        MinimumSize = New Size(845, 380)
        Name = "ManUI"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvRSales, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(dgvCSales, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnDash As Button
    Friend WithEvents btnRoomProfile As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblRS As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvRSales As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblCS As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvCSales As DataGridView
End Class
