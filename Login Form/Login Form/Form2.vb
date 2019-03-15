Public Class frmCreateAccount
    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        My.Settings.Username = MtxtUserName.Text
        My.Settings.password = MtxtPassword.Text
        My.Settings.Save()

        MsgBox("Account has been created", MsgBoxStyle.Information)
        Me.Hide()
        frmLogin.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class