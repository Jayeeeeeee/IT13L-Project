﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        btnLogOut = New Button()
        btnRoomProfile = New Button()
        btnDash = New Button()
        GroupBox1 = New GroupBox()
        dgvSales = New DataGridView()
        GroupBox1.SuspendLayout()
        CType(dgvSales, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Font = New Font("Consolas", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogOut.Location = New Point(464, 12)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(60, 23)
        btnLogOut.TabIndex = 3
        btnLogOut.Text = "Logout"
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' btnRoomProfile
        ' 
        btnRoomProfile.Font = New Font("Consolas", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnRoomProfile.Location = New Point(12, 12)
        btnRoomProfile.Name = "btnRoomProfile"
        btnRoomProfile.Size = New Size(130, 23)
        btnRoomProfile.TabIndex = 1
        btnRoomProfile.Text = "Room Profile"
        btnRoomProfile.UseVisualStyleBackColor = True
        ' 
        ' btnDash
        ' 
        btnDash.Font = New Font("Consolas", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnDash.Location = New Point(148, 12)
        btnDash.Name = "btnDash"
        btnDash.Size = New Size(130, 23)
        btnDash.TabIndex = 2
        btnDash.Text = "Transactions"
        btnDash.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Goldenrod
        GroupBox1.Controls.Add(dgvSales)
        GroupBox1.Font = New Font("Consolas", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(12, 41)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(512, 218)
        GroupBox1.TabIndex = 41
        GroupBox1.TabStop = False
        GroupBox1.Text = "Sales"
        ' 
        ' dgvSales
        ' 
        dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSales.Location = New Point(6, 57)
        dgvSales.Name = "dgvSales"
        dgvSales.RowTemplate.Height = 25
        dgvSales.Size = New Size(500, 154)
        dgvSales.TabIndex = 0
        ' 
        ' ManUI
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(536, 271)
        Controls.Add(GroupBox1)
        Controls.Add(btnLogOut)
        Controls.Add(btnDash)
        Controls.Add(btnRoomProfile)
        MaximumSize = New Size(552, 310)
        MinimumSize = New Size(552, 310)
        Name = "ManUI"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        GroupBox1.ResumeLayout(False)
        CType(dgvSales, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnDash As Button
    Friend WithEvents btnRoomProfile As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvSales As DataGridView
End Class
