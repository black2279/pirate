<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbVkontakte = New System.Windows.Forms.LinkLabel()
        Me.lbPassword = New System.Windows.Forms.Label()
        Me.lbUsername = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnUpdateProxy = New System.Windows.Forms.Button()
        Me.lblProxyPort = New System.Windows.Forms.Label()
        Me.lblProxyHost = New System.Windows.Forms.Label()
        Me.txtProxyPort = New System.Windows.Forms.TextBox()
        Me.txtProxyHost = New System.Windows.Forms.TextBox()
        Me.cbxUseProxy = New System.Windows.Forms.CheckBox()
        Me.pnlInfo = New System.Windows.Forms.Panel()
        Me.pnlInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(168, 79)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(100, 28)
        Me.btnLogin.TabIndex = 23
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 11)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(404, 17)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "A vkontakte account is necessary for the functionality of Pirate."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(266, 27)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "to create one."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(194, 27)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Click "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 27)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Don't have an account yet?"
        '
        'lbVkontakte
        '
        Me.lbVkontakte.AutoSize = True
        Me.lbVkontakte.Location = New System.Drawing.Point(231, 27)
        Me.lbVkontakte.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbVkontakte.Name = "lbVkontakte"
        Me.lbVkontakte.Size = New System.Drawing.Size(37, 17)
        Me.lbVkontakte.TabIndex = 18
        Me.lbVkontakte.TabStop = True
        Me.lbVkontakte.Text = "here"
        '
        'lbPassword
        '
        Me.lbPassword.AutoSize = True
        Me.lbPassword.Location = New System.Drawing.Point(83, 50)
        Me.lbPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPassword.Name = "lbPassword"
        Me.lbPassword.Size = New System.Drawing.Size(73, 17)
        Me.lbPassword.TabIndex = 17
        Me.lbPassword.Text = "Password:"
        '
        'lbUsername
        '
        Me.lbUsername.AutoSize = True
        Me.lbUsername.Location = New System.Drawing.Point(83, 18)
        Me.lbUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbUsername.Name = "lbUsername"
        Me.lbUsername.Size = New System.Drawing.Size(77, 17)
        Me.lbUsername.TabIndex = 16
        Me.lbUsername.Text = "Username:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(168, 47)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(159, 22)
        Me.txtPassword.TabIndex = 15
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(168, 15)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(159, 22)
        Me.txtUsername.TabIndex = 14
        '
        'btnUpdateProxy
        '
        Me.btnUpdateProxy.Location = New System.Drawing.Point(168, 214)
        Me.btnUpdateProxy.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdateProxy.Name = "btnUpdateProxy"
        Me.btnUpdateProxy.Size = New System.Drawing.Size(159, 28)
        Me.btnUpdateProxy.TabIndex = 28
        Me.btnUpdateProxy.Text = "Update Proxy"
        Me.btnUpdateProxy.UseVisualStyleBackColor = True
        '
        'lblProxyPort
        '
        Me.lblProxyPort.AutoSize = True
        Me.lblProxyPort.Location = New System.Drawing.Point(83, 185)
        Me.lblProxyPort.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProxyPort.Name = "lblProxyPort"
        Me.lblProxyPort.Size = New System.Drawing.Size(38, 17)
        Me.lblProxyPort.TabIndex = 27
        Me.lblProxyPort.Text = "Port:"
        '
        'lblProxyHost
        '
        Me.lblProxyHost.AutoSize = True
        Me.lblProxyHost.Location = New System.Drawing.Point(83, 153)
        Me.lblProxyHost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProxyHost.Name = "lblProxyHost"
        Me.lblProxyHost.Size = New System.Drawing.Size(41, 17)
        Me.lblProxyHost.TabIndex = 26
        Me.lblProxyHost.Text = "Host:"
        '
        'txtProxyPort
        '
        Me.txtProxyPort.Location = New System.Drawing.Point(168, 182)
        Me.txtProxyPort.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProxyPort.Name = "txtProxyPort"
        Me.txtProxyPort.Size = New System.Drawing.Size(68, 22)
        Me.txtProxyPort.TabIndex = 25
        '
        'txtProxyHost
        '
        Me.txtProxyHost.Location = New System.Drawing.Point(168, 150)
        Me.txtProxyHost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProxyHost.Name = "txtProxyHost"
        Me.txtProxyHost.Size = New System.Drawing.Size(159, 22)
        Me.txtProxyHost.TabIndex = 24
        '
        'cbxUseProxy
        '
        Me.cbxUseProxy.AutoSize = True
        Me.cbxUseProxy.Location = New System.Drawing.Point(86, 121)
        Me.cbxUseProxy.Name = "cbxUseProxy"
        Me.cbxUseProxy.Size = New System.Drawing.Size(94, 21)
        Me.cbxUseProxy.TabIndex = 29
        Me.cbxUseProxy.Text = "Use Proxy"
        Me.cbxUseProxy.UseVisualStyleBackColor = True
        '
        'pnlInfo
        '
        Me.pnlInfo.Controls.Add(Me.Label7)
        Me.pnlInfo.Controls.Add(Me.lbVkontakte)
        Me.pnlInfo.Controls.Add(Me.Label6)
        Me.pnlInfo.Controls.Add(Me.Label2)
        Me.pnlInfo.Controls.Add(Me.Label5)
        Me.pnlInfo.Location = New System.Drawing.Point(9, 246)
        Me.pnlInfo.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(426, 52)
        Me.pnlInfo.TabIndex = 31
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 307)
        Me.Controls.Add(Me.pnlInfo)
        Me.Controls.Add(Me.cbxUseProxy)
        Me.Controls.Add(Me.btnUpdateProxy)
        Me.Controls.Add(Me.lblProxyPort)
        Me.Controls.Add(Me.lblProxyHost)
        Me.Controls.Add(Me.txtProxyPort)
        Me.Controls.Add(Me.txtProxyHost)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lbPassword)
        Me.Controls.Add(Me.lbUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Authentication"
        Me.pnlInfo.ResumeLayout(False)
        Me.pnlInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbVkontakte As System.Windows.Forms.LinkLabel
    Friend WithEvents lbPassword As System.Windows.Forms.Label
    Friend WithEvents lbUsername As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdateProxy As Button
    Friend WithEvents lblProxyPort As Label
    Friend WithEvents lblProxyHost As Label
    Friend WithEvents txtProxyPort As TextBox
    Friend WithEvents txtProxyHost As TextBox
    Friend WithEvents cbxUseProxy As CheckBox
    Friend WithEvents pnlInfo As Panel
End Class
