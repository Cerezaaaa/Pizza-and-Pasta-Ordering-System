Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "Admin" And txtPassword.Text = "Admin" Then
            Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub chk_RememberMe_CheckedChanged(sender As Object, e As EventArgs) Handles chk_RememberMe.CheckedChanged
        If chk_RememberMe.Checked Then
            My.MySettings.Default.user = txtUsername.Text
            My.MySettings.Default.password = txtUsername.Text
            My.MySettings.Default.rememberme = chk_RememberMe.Checked
            My.MySettings.Default.Save()
        Else
            My.MySettings.Default.user = ""
            My.MySettings.Default.password = ""
            My.MySettings.Default.rememberme = False
            My.MySettings.Default.Save()
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
        txtUsername.Text = My.MySettings.Default.user
        txtPassword.Text = My.MySettings.Default.password
        chk_RememberMe.Checked = My.MySettings.Default.rememberme
    End Sub
End Class