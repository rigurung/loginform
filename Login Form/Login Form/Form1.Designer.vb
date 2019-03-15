<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MtxtUserName = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtPassword = New System.Windows.Forms.MaskedTextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.linkCreateAccount = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username: "
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(50, 154)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password: "
        '
        'MtxtUserName
        '
        Me.MtxtUserName.Location = New System.Drawing.Point(114, 49)
        Me.MtxtUserName.Name = "MtxtUserName"
        Me.MtxtUserName.Size = New System.Drawing.Size(174, 20)
        Me.MtxtUserName.TabIndex = 7
        '
        'MtxtPassword
        '
        Me.MtxtPassword.Location = New System.Drawing.Point(114, 96)
        Me.MtxtPassword.Name = "MtxtPassword"
        Me.MtxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.MtxtPassword.Size = New System.Drawing.Size(174, 20)
        Me.MtxtPassword.TabIndex = 8
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(213, 154)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'linkCreateAccount
        '
        Me.linkCreateAccount.AutoSize = True
        Me.linkCreateAccount.Location = New System.Drawing.Point(49, 200)
        Me.linkCreateAccount.Name = "linkCreateAccount"
        Me.linkCreateAccount.Size = New System.Drawing.Size(84, 13)
        Me.linkCreateAccount.TabIndex = 10
        Me.linkCreateAccount.TabStop = True
        Me.linkCreateAccount.Text = "Create Account "
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(393, 284)
        Me.Controls.Add(Me.linkCreateAccount)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.MtxtPassword)
        Me.Controls.Add(Me.MtxtUserName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Form "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents MtxtUserName As MaskedTextBox
    Friend WithEvents MtxtPassword As MaskedTextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents linkCreateAccount As LinkLabel

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If MtxtUserName.Text = My.Settings.Username And
                MtxtPassword.Text = My.Settings.password Then
            Form3.Show()
            Me.Hide()
            MsgBox("You have logged in.", MsgBoxStyle.Information)

        Else

            MsgBox("Incorrect username or password.", MsgBoxStyle.Information, "Error")

        End If



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub linkCreateAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkCreateAccount.LinkClicked
        frmCreateAccount.Show()
    End Sub
End Class
