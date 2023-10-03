<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Login))
        lblUser = New Label()
        lblPass = New Label()
        txtUser = New TextBox()
        txtPass = New TextBox()
        btnLogin = New Button()
        btnCancel = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblUser
        ' 
        lblUser.Anchor = AnchorStyles.Bottom
        lblUser.AutoSize = True
        lblUser.BackColor = Color.FromArgb(CByte(34), CByte(34), CByte(34))
        lblUser.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblUser.ForeColor = Color.White
        lblUser.Location = New Point(12, 143)
        lblUser.Margin = New Padding(4, 0, 4, 0)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(70, 14)
        lblUser.TabIndex = 0
        lblUser.Text = "Username:"
        ' 
        ' lblPass
        ' 
        lblPass.Anchor = AnchorStyles.Bottom
        lblPass.AutoSize = True
        lblPass.BackColor = Color.FromArgb(CByte(34), CByte(34), CByte(34))
        lblPass.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblPass.ForeColor = Color.White
        lblPass.Location = New Point(12, 174)
        lblPass.Margin = New Padding(4, 0, 4, 0)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(70, 14)
        lblPass.TabIndex = 1
        lblPass.Text = "Password:"
        ' 
        ' txtUser
        ' 
        txtUser.Anchor = AnchorStyles.Bottom
        txtUser.BackColor = Color.White
        txtUser.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtUser.ForeColor = Color.Black
        txtUser.Location = New Point(80, 140)
        txtUser.Margin = New Padding(4, 3, 4, 3)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(117, 23)
        txtUser.TabIndex = 2
        ' 
        ' txtPass
        ' 
        txtPass.Anchor = AnchorStyles.Bottom
        txtPass.BackColor = Color.White
        txtPass.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPass.ForeColor = Color.Black
        txtPass.Location = New Point(80, 171)
        txtPass.Margin = New Padding(4, 3, 4, 3)
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "*"c
        txtPass.Size = New Size(117, 23)
        txtPass.TabIndex = 3
        ' 
        ' btnLogin
        ' 
        btnLogin.Anchor = AnchorStyles.Bottom
        btnLogin.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogin.Image = My.Resources.Resources.login2
        btnLogin.Location = New Point(12, 200)
        btnLogin.Margin = New Padding(4, 3, 4, 3)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(186, 27)
        btnLogin.TabIndex = 4
        btnLogin.TabStop = False
        btnLogin.Text = "Login"
        btnLogin.TextAlign = ContentAlignment.MiddleRight
        btnLogin.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Anchor = AnchorStyles.Bottom
        btnCancel.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), Image)
        btnCancel.Location = New Point(12, 233)
        btnCancel.Margin = New Padding(4, 3, 4, 3)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(186, 23)
        btnCancel.TabIndex = 5
        btnCancel.TabStop = False
        btnCancel.Text = "Cancel"
        btnCancel.TextAlign = ContentAlignment.MiddleRight
        btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(186, 120)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Login
        ' 
        AcceptButton = btnLogin
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(34), CByte(34))
        CancelButton = btnCancel
        ClientSize = New Size(210, 262)
        Controls.Add(PictureBox1)
        Controls.Add(btnCancel)
        Controls.Add(btnLogin)
        Controls.Add(txtPass)
        Controls.Add(txtUser)
        Controls.Add(lblPass)
        Controls.Add(lblUser)
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MaximumSize = New Size(226, 301)
        MinimizeBox = False
        MinimumSize = New Size(226, 301)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUser As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
