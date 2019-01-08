<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSettings))
        Me.fbdDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.versionLabel = New System.Windows.Forms.Label()
        Me.tbProxy = New System.Windows.Forms.TabPage()
        Me.lblProxyPort = New System.Windows.Forms.Label()
        Me.btnUpdateProxy = New System.Windows.Forms.Button()
        Me.lblProxyHost = New System.Windows.Forms.Label()
        Me.txtProxyPort = New System.Windows.Forms.TextBox()
        Me.txtProxyHost = New System.Windows.Forms.TextBox()
        Me.tbAbout = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.tbAuthentication = New System.Windows.Forms.TabPage()
        Me.lbLoggedInAs = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lbPassword = New System.Windows.Forms.Label()
        Me.lbUsername = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.tbDownloads = New System.Windows.Forms.TabPage()
        Me.chkOverwrite = New System.Windows.Forms.CheckBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.chkDontAskDir = New System.Windows.Forms.CheckBox()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.cbxUseProxy = New System.Windows.Forms.CheckBox()
        Me.tbProxy.SuspendLayout()
        Me.tbAbout.SuspendLayout()
        Me.tbAuthentication.SuspendLayout()
        Me.tbDownloads.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fbdDialog
        '
        Me.fbdDialog.SelectedPath = "C:\"
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(456, 271)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(137, 28)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'versionLabel
        '
        Me.versionLabel.AutoSize = True
        Me.versionLabel.Enabled = False
        Me.versionLabel.Location = New System.Drawing.Point(16, 277)
        Me.versionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.versionLabel.Name = "versionLabel"
        Me.versionLabel.Size = New System.Drawing.Size(108, 17)
        Me.versionLabel.TabIndex = 2
        Me.versionLabel.Text = "Version: 0.0.0.0"
        '
        'tbProxy
        '
        Me.tbProxy.Controls.Add(Me.cbxUseProxy)
        Me.tbProxy.Controls.Add(Me.lblProxyPort)
        Me.tbProxy.Controls.Add(Me.btnUpdateProxy)
        Me.tbProxy.Controls.Add(Me.lblProxyHost)
        Me.tbProxy.Controls.Add(Me.txtProxyPort)
        Me.tbProxy.Controls.Add(Me.txtProxyHost)
        Me.tbProxy.Location = New System.Drawing.Point(4, 25)
        Me.tbProxy.Name = "tbProxy"
        Me.tbProxy.Padding = New System.Windows.Forms.Padding(3)
        Me.tbProxy.Size = New System.Drawing.Size(575, 220)
        Me.tbProxy.TabIndex = 3
        Me.tbProxy.Text = "Proxy"
        Me.tbProxy.UseVisualStyleBackColor = True
        '
        'lblProxyPort
        '
        Me.lblProxyPort.AutoSize = True
        Me.lblProxyPort.Location = New System.Drawing.Point(230, 44)
        Me.lblProxyPort.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProxyPort.Name = "lblProxyPort"
        Me.lblProxyPort.Size = New System.Drawing.Size(38, 17)
        Me.lblProxyPort.TabIndex = 18
        Me.lblProxyPort.Text = "Port:"
        '
        'btnUpdateProxy
        '
        Me.btnUpdateProxy.Location = New System.Drawing.Point(18, 71)
        Me.btnUpdateProxy.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdateProxy.Name = "btnUpdateProxy"
        Me.btnUpdateProxy.Size = New System.Drawing.Size(143, 28)
        Me.btnUpdateProxy.TabIndex = 17
        Me.btnUpdateProxy.Text = "Update Proxy"
        Me.btnUpdateProxy.UseVisualStyleBackColor = True
        '
        'lblProxyHost
        '
        Me.lblProxyHost.AutoSize = True
        Me.lblProxyHost.Location = New System.Drawing.Point(14, 44)
        Me.lblProxyHost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProxyHost.Name = "lblProxyHost"
        Me.lblProxyHost.Size = New System.Drawing.Size(41, 17)
        Me.lblProxyHost.TabIndex = 16
        Me.lblProxyHost.Text = "Host:"
        '
        'txtProxyPort
        '
        Me.txtProxyPort.Location = New System.Drawing.Point(276, 41)
        Me.txtProxyPort.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProxyPort.Name = "txtProxyPort"
        Me.txtProxyPort.Size = New System.Drawing.Size(86, 22)
        Me.txtProxyPort.TabIndex = 15
        '
        'txtProxyHost
        '
        Me.txtProxyHost.Location = New System.Drawing.Point(63, 41)
        Me.txtProxyHost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProxyHost.Name = "txtProxyHost"
        Me.txtProxyHost.Size = New System.Drawing.Size(159, 22)
        Me.txtProxyHost.TabIndex = 14
        '
        'tbAbout
        '
        Me.tbAbout.Controls.Add(Me.TextBox1)
        Me.tbAbout.Location = New System.Drawing.Point(4, 25)
        Me.tbAbout.Margin = New System.Windows.Forms.Padding(4)
        Me.tbAbout.Name = "tbAbout"
        Me.tbAbout.Padding = New System.Windows.Forms.Padding(4)
        Me.tbAbout.Size = New System.Drawing.Size(575, 220)
        Me.tbAbout.TabIndex = 1
        Me.tbAbout.Text = "About"
        Me.tbAbout.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(8, 7)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(555, 201)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'tbAuthentication
        '
        Me.tbAuthentication.Controls.Add(Me.lbLoggedInAs)
        Me.tbAuthentication.Controls.Add(Me.btnLogin)
        Me.tbAuthentication.Controls.Add(Me.lbPassword)
        Me.tbAuthentication.Controls.Add(Me.lbUsername)
        Me.tbAuthentication.Controls.Add(Me.txtPassword)
        Me.tbAuthentication.Controls.Add(Me.txtUsername)
        Me.tbAuthentication.Location = New System.Drawing.Point(4, 25)
        Me.tbAuthentication.Margin = New System.Windows.Forms.Padding(4)
        Me.tbAuthentication.Name = "tbAuthentication"
        Me.tbAuthentication.Size = New System.Drawing.Size(575, 220)
        Me.tbAuthentication.TabIndex = 2
        Me.tbAuthentication.Text = "Authentication"
        Me.tbAuthentication.UseVisualStyleBackColor = True
        '
        'lbLoggedInAs
        '
        Me.lbLoggedInAs.AutoSize = True
        Me.lbLoggedInAs.Location = New System.Drawing.Point(9, 52)
        Me.lbLoggedInAs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbLoggedInAs.Name = "lbLoggedInAs"
        Me.lbLoggedInAs.Size = New System.Drawing.Size(121, 17)
        Me.lbLoggedInAs.TabIndex = 13
        Me.lbLoggedInAs.Text = "Logged in as: N/A"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(95, 81)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(100, 28)
        Me.btnLogin.TabIndex = 12
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lbPassword
        '
        Me.lbPassword.AutoSize = True
        Me.lbPassword.Location = New System.Drawing.Point(9, 52)
        Me.lbPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPassword.Name = "lbPassword"
        Me.lbPassword.Size = New System.Drawing.Size(73, 17)
        Me.lbPassword.TabIndex = 5
        Me.lbPassword.Text = "Password:"
        '
        'lbUsername
        '
        Me.lbUsername.AutoSize = True
        Me.lbUsername.Location = New System.Drawing.Point(9, 20)
        Me.lbUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbUsername.Name = "lbUsername"
        Me.lbUsername.Size = New System.Drawing.Size(77, 17)
        Me.lbUsername.TabIndex = 4
        Me.lbUsername.Text = "Username:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(95, 48)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(159, 22)
        Me.txtPassword.TabIndex = 3
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(95, 16)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(159, 22)
        Me.txtUsername.TabIndex = 2
        '
        'tbDownloads
        '
        Me.tbDownloads.Controls.Add(Me.chkOverwrite)
        Me.tbDownloads.Controls.Add(Me.btnBrowse)
        Me.tbDownloads.Controls.Add(Me.chkDontAskDir)
        Me.tbDownloads.Controls.Add(Me.txtDir)
        Me.tbDownloads.Controls.Add(Me.Label1)
        Me.tbDownloads.Location = New System.Drawing.Point(4, 25)
        Me.tbDownloads.Margin = New System.Windows.Forms.Padding(4)
        Me.tbDownloads.Name = "tbDownloads"
        Me.tbDownloads.Padding = New System.Windows.Forms.Padding(4)
        Me.tbDownloads.Size = New System.Drawing.Size(575, 220)
        Me.tbDownloads.TabIndex = 0
        Me.tbDownloads.Text = "Downloads"
        Me.tbDownloads.UseVisualStyleBackColor = True
        '
        'chkOverwrite
        '
        Me.chkOverwrite.AutoSize = True
        Me.chkOverwrite.Location = New System.Drawing.Point(13, 90)
        Me.chkOverwrite.Margin = New System.Windows.Forms.Padding(4)
        Me.chkOverwrite.Name = "chkOverwrite"
        Me.chkOverwrite.Size = New System.Drawing.Size(224, 21)
        Me.chkOverwrite.TabIndex = 7
        Me.chkOverwrite.Text = "Overwrite file if it already exists"
        Me.chkOverwrite.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(364, 27)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(100, 28)
        Me.btnBrowse.TabIndex = 6
        Me.btnBrowse.Text = "Browse.."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'chkDontAskDir
        '
        Me.chkDontAskDir.AutoSize = True
        Me.chkDontAskDir.Location = New System.Drawing.Point(13, 62)
        Me.chkDontAskDir.Margin = New System.Windows.Forms.Padding(4)
        Me.chkDontAskDir.Name = "chkDontAskDir"
        Me.chkDontAskDir.Size = New System.Drawing.Size(340, 21)
        Me.chkDontAskDir.TabIndex = 5
        Me.chkDontAskDir.Text = "Don't ask for directory every time, just save them!"
        Me.chkDontAskDir.UseVisualStyleBackColor = True
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(13, 30)
        Me.txtDir.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.ReadOnly = True
        Me.txtDir.Size = New System.Drawing.Size(341, 22)
        Me.txtDir.TabIndex = 4
        Me.txtDir.Text = "C:\"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "The default directory for downloads is:"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tbDownloads)
        Me.TabControl1.Controls.Add(Me.tbAuthentication)
        Me.TabControl1.Controls.Add(Me.tbProxy)
        Me.TabControl1.Controls.Add(Me.tbAbout)
        Me.TabControl1.Location = New System.Drawing.Point(16, 15)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(583, 249)
        Me.TabControl1.TabIndex = 0
        '
        'cbxUseProxy
        '
        Me.cbxUseProxy.AutoSize = True
        Me.cbxUseProxy.Location = New System.Drawing.Point(18, 13)
        Me.cbxUseProxy.Name = "cbxUseProxy"
        Me.cbxUseProxy.Size = New System.Drawing.Size(94, 21)
        Me.cbxUseProxy.TabIndex = 30
        Me.cbxUseProxy.Text = "Use Proxy"
        Me.cbxUseProxy.UseVisualStyleBackColor = True
        '
        'FrmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(615, 310)
        Me.Controls.Add(Me.versionLabel)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.tbProxy.ResumeLayout(False)
        Me.tbProxy.PerformLayout()
        Me.tbAbout.ResumeLayout(False)
        Me.tbAbout.PerformLayout()
        Me.tbAuthentication.ResumeLayout(False)
        Me.tbAuthentication.PerformLayout()
        Me.tbDownloads.ResumeLayout(False)
        Me.tbDownloads.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fbdDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents versionLabel As System.Windows.Forms.Label
    Friend WithEvents tbProxy As TabPage
    Friend WithEvents tbAbout As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents tbAuthentication As TabPage
    Friend WithEvents lbLoggedInAs As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents lbPassword As Label
    Friend WithEvents lbUsername As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents tbDownloads As TabPage
    Friend WithEvents chkOverwrite As CheckBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents chkDontAskDir As CheckBox
    Friend WithEvents txtDir As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents lblProxyPort As Label
    Friend WithEvents btnUpdateProxy As Button
    Friend WithEvents lblProxyHost As Label
    Friend WithEvents txtProxyPort As TextBox
    Friend WithEvents txtProxyHost As TextBox
    Friend WithEvents cbxUseProxy As CheckBox
End Class
