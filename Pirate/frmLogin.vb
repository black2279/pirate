Public Class FrmLogin

    Private Sub lbVkontakte_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbVkontakte.LinkClicked
        System.Diagnostics.Process.Start("https://vk.com")
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Manager.Music.Login(txtUsername.Text, txtPassword.Text)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub frmLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        My.Settings.Save()
        If (Not Manager.Music.IsLoggedIn) Then
            Environment.Exit(0)
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetLoginButtonStatus()
        cbxUseProxy.Checked = My.Settings.UseProxy
        txtProxyHost.Text = My.Settings.ProxyHost
        txtProxyPort.Text = My.Settings.ProxyPort

        Dim newPosition As Point = pnlInfo.Location

        If (cbxUseProxy.Checked = False) Then
            lblProxyHost.Visible = False
            txtProxyHost.Visible = False
            lblProxyPort.Visible = False
            txtProxyPort.Visible = False
            btnUpdateProxy.Visible = False
            newPosition.Y = cbxUseProxy.Location.Y + 20
            Height = newPosition.Y + 80
        Else
            lblProxyHost.Visible = True
            txtProxyHost.Visible = True
            lblProxyPort.Visible = True
            txtProxyPort.Visible = True
            btnUpdateProxy.Visible = True
            newPosition.Y = btnUpdateProxy.Location.Y + 30
            Height = newPosition.Y + 80
        End If

        pnlInfo.Location = newPosition
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        SetLoginButtonStatus()
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        SetLoginButtonStatus()
    End Sub

    Private Sub SetLoginButtonStatus()
        btnLogin.Enabled = Not String.IsNullOrWhiteSpace(txtUsername.Text) AndAlso Not String.IsNullOrWhiteSpace(txtPassword.Text)
    End Sub

    Private Sub cbxUseProxy_CheckedChanged(sender As Object, e As EventArgs) Handles cbxUseProxy.CheckedChanged
        My.Settings.UseProxy = cbxUseProxy.Checked

        Dim newPosition As Point = pnlInfo.Location

        If (cbxUseProxy.Checked = False) Then
            lblProxyHost.Visible = False
            txtProxyHost.Visible = False
            lblProxyPort.Visible = False
            txtProxyPort.Visible = False
            btnUpdateProxy.Visible = False
            newPosition.Y = cbxUseProxy.Location.Y + 20
            Height = newPosition.Y + 80
        Else
            lblProxyHost.Visible = True
            txtProxyHost.Visible = True
            lblProxyPort.Visible = True
            txtProxyPort.Visible = True
            btnUpdateProxy.Visible = True
            newPosition.Y = btnUpdateProxy.Location.Y + 30
            Height = newPosition.Y + 80
        End If

        pnlInfo.Location = newPosition
    End Sub

    Private Sub btnUpdateProxy_Click(sender As Object, e As EventArgs) Handles btnUpdateProxy.Click
        Dim ProxyPort As UInt32 = 0
        If (Int32.TryParse(txtProxyPort.Text, ProxyPort)) Then
            My.Settings.ProxyPort = Trim(txtProxyPort.Text)
            My.Settings.ProxyHost = Trim(txtProxyHost.Text)
        Else
            MessageBox.Show("Invalid Proxy Port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class