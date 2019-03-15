<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateAccount
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.MtxtPassword = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtUserName = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(231, 128)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MtxtPassword
        '
        Me.MtxtPassword.Location = New System.Drawing.Point(132, 70)
        Me.MtxtPassword.Name = "MtxtPassword"
        Me.MtxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.MtxtPassword.Size = New System.Drawing.Size(174, 20)
        Me.MtxtPassword.TabIndex = 15
        '
        'MtxtUserName
        '
        Me.MtxtUserName.Location = New System.Drawing.Point(132, 23)
        Me.MtxtUserName.Name = "MtxtUserName"
        Me.MtxtUserName.Size = New System.Drawing.Size(174, 20)
        Me.MtxtUserName.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Password: "
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Location = New System.Drawing.Point(68, 128)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(128, 23)
        Me.btnCreateAccount.TabIndex = 12
        Me.btnCreateAccount.Text = "Create Account "
        Me.btnCreateAccount.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Username: "
        '
        'frmCreateAccount
        '
        Me.AcceptButton = Me.btnCreateAccount
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 243)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.MtxtPassword)
        Me.Controls.Add(Me.MtxtUserName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCreateAccount"
        Me.Text = "Create Account "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents MtxtPassword As MaskedTextBox
    Friend WithEvents MtxtUserName As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents Label1 As Label
End Class
