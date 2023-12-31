﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transactions
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Transactions))
        btnBack = New Button()
        lblDateTime = New Label()
        btnLogOut = New Button()
        GroupBox4 = New GroupBox()
        dgvCITransaction = New DataGridView()
        GroupBox3 = New GroupBox()
        dgvRTransaction = New DataGridView()
        tmrRecords = New Timer(components)
        Panel1 = New Panel()
        GroupBox4.SuspendLayout()
        CType(dgvCITransaction, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        CType(dgvRTransaction, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnBack.Image = My.Resources.Resources.back
        btnBack.ImageAlign = ContentAlignment.MiddleRight
        btnBack.Location = New Point(3, 6)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(133, 23)
        btnBack.TabIndex = 11
        btnBack.Text = "Back"
        btnBack.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' lblDateTime
        ' 
        lblDateTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblDateTime.AutoSize = True
        lblDateTime.BackColor = Color.Transparent
        lblDateTime.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblDateTime.ForeColor = Color.White
        lblDateTime.Location = New Point(1257, 10)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(161, 14)
        lblDateTime.TabIndex = 34
        lblDateTime.Text = "00/00/0000 00:00:00 am"
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnLogOut.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogOut.Image = My.Resources.Resources.login
        btnLogOut.ImageAlign = ContentAlignment.MiddleRight
        btnLogOut.Location = New Point(1424, 6)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(133, 23)
        btnLogOut.TabIndex = 33
        btnLogOut.Text = "Logout"
        btnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.Goldenrod
        GroupBox4.Controls.Add(dgvCITransaction)
        GroupBox4.Font = New Font("Consolas", 8F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox4.Location = New Point(12, 319)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(1560, 250)
        GroupBox4.TabIndex = 37
        GroupBox4.TabStop = False
        GroupBox4.Text = "Check-In Transaction"
        ' 
        ' dgvCITransaction
        ' 
        dgvCITransaction.AllowUserToAddRows = False
        dgvCITransaction.AllowUserToDeleteRows = False
        dgvCITransaction.AllowUserToResizeColumns = False
        dgvCITransaction.AllowUserToResizeRows = False
        dgvCITransaction.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvCITransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCITransaction.BackgroundColor = Color.White
        dgvCITransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCITransaction.Cursor = Cursors.Hand
        dgvCITransaction.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvCITransaction.GridColor = SystemColors.Menu
        dgvCITransaction.ImeMode = ImeMode.NoControl
        dgvCITransaction.Location = New Point(6, 23)
        dgvCITransaction.Name = "dgvCITransaction"
        dgvCITransaction.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        dgvCITransaction.RowTemplate.Height = 25
        dgvCITransaction.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCITransaction.Size = New Size(1548, 221)
        dgvCITransaction.TabIndex = 5
        dgvCITransaction.TabStop = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.Goldenrod
        GroupBox3.Controls.Add(dgvRTransaction)
        GroupBox3.Font = New Font("Consolas", 8F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox3.ForeColor = Color.Black
        GroupBox3.Location = New Point(12, 63)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(1560, 250)
        GroupBox3.TabIndex = 36
        GroupBox3.TabStop = False
        GroupBox3.Text = "Reservation Transaction"
        ' 
        ' dgvRTransaction
        ' 
        dgvRTransaction.AllowUserToAddRows = False
        dgvRTransaction.AllowUserToDeleteRows = False
        dgvRTransaction.AllowUserToResizeColumns = False
        dgvRTransaction.AllowUserToResizeRows = False
        dgvRTransaction.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvRTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRTransaction.BackgroundColor = Color.White
        dgvRTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRTransaction.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvRTransaction.Location = New Point(6, 23)
        dgvRTransaction.Name = "dgvRTransaction"
        dgvRTransaction.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        dgvRTransaction.RowTemplate.Height = 25
        dgvRTransaction.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRTransaction.Size = New Size(1548, 221)
        dgvRTransaction.TabIndex = 0
        dgvRTransaction.TabStop = False
        ' 
        ' tmrRecords
        ' 
        tmrRecords.Enabled = True
        tmrRecords.Interval = 1000
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(34), CByte(34), CByte(34))
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(btnLogOut)
        Panel1.Controls.Add(lblDateTime)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1560, 39)
        Panel1.TabIndex = 38
        ' 
        ' Transactions
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(34), CByte(34))
        ClientSize = New Size(1584, 581)
        Controls.Add(Panel1)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MaximumSize = New Size(1600, 620)
        MinimizeBox = False
        MinimumSize = New Size(1600, 620)
        Name = "Transactions"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Records"
        GroupBox4.ResumeLayout(False)
        CType(dgvCITransaction, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        CType(dgvRTransaction, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblDateTime As Label
    Friend WithEvents btnLogOut As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgvCITransaction As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvRTransaction As DataGridView
    Friend WithEvents tmrRecords As Timer
    Friend WithEvents Panel1 As Panel
End Class
