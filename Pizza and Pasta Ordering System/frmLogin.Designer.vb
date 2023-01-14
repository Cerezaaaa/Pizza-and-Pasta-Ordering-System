<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.btnLogin = New MetroFramework.Controls.MetroButton()
        Me.chk_RememberMe = New MetroFramework.Controls.MetroCheckBox()
        Me.txtPassword = New MetroFramework.Controls.MetroTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtUsername = New MetroFramework.Controls.MetroTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(464, 209)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(137, 28)
        Me.btnLogin.TabIndex = 9
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseSelectable = True
        '
        'chk_RememberMe
        '
        Me.chk_RememberMe.AutoSize = True
        Me.chk_RememberMe.Location = New System.Drawing.Point(240, 164)
        Me.chk_RememberMe.Margin = New System.Windows.Forms.Padding(4)
        Me.chk_RememberMe.Name = "chk_RememberMe"
        Me.chk_RememberMe.Size = New System.Drawing.Size(101, 15)
        Me.chk_RememberMe.TabIndex = 8
        Me.chk_RememberMe.Text = "Remember me"
        Me.chk_RememberMe.UseSelectable = True
        '
        'txtPassword
        '
        '
        '
        '
        Me.txtPassword.CustomButton.Image = Nothing
        Me.txtPassword.CustomButton.Location = New System.Drawing.Point(335, 2)
        Me.txtPassword.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.CustomButton.Name = ""
        Me.txtPassword.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPassword.CustomButton.TabIndex = 1
        Me.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPassword.CustomButton.UseSelectable = True
        Me.txtPassword.CustomButton.Visible = False
        Me.txtPassword.DisplayIcon = True
        Me.txtPassword.Icon = CType(resources.GetObject("txtPassword.Icon"), System.Drawing.Image)
        Me.txtPassword.Lines = New String(-1) {}
        Me.txtPassword.Location = New System.Drawing.Point(240, 128)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.PromptText = "Enter your user name"
        Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.ShortcutsEnabled = True
        Me.txtPassword.Size = New System.Drawing.Size(361, 28)
        Me.txtPassword.TabIndex = 7
        Me.txtPassword.UseSelectable = True
        Me.txtPassword.WaterMark = "Enter your user name"
        Me.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPassword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(32, 68)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(187, 172)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'txtUsername
        '
        '
        '
        '
        Me.txtUsername.CustomButton.Image = Nothing
        Me.txtUsername.CustomButton.Location = New System.Drawing.Point(335, 2)
        Me.txtUsername.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.CustomButton.Name = ""
        Me.txtUsername.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUsername.CustomButton.TabIndex = 1
        Me.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUsername.CustomButton.UseSelectable = True
        Me.txtUsername.CustomButton.Visible = False
        Me.txtUsername.DisplayIcon = True
        Me.txtUsername.Icon = CType(resources.GetObject("txtUsername.Icon"), System.Drawing.Image)
        Me.txtUsername.Lines = New String(-1) {}
        Me.txtUsername.Location = New System.Drawing.Point(240, 92)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.MaxLength = 32767
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PromptText = "Enter your user name"
        Me.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.SelectionLength = 0
        Me.txtUsername.SelectionStart = 0
        Me.txtUsername.ShortcutsEnabled = True
        Me.txtUsername.Size = New System.Drawing.Size(361, 28)
        Me.txtUsername.TabIndex = 5
        Me.txtUsername.UseSelectable = True
        Me.txtUsername.WaterMark = "Enter your user name"
        Me.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUsername.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 276)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.chk_RememberMe)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtUsername)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.Resizable = False
        Me.Text = "Login to Super Sale Shop"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As MetroFramework.Controls.MetroButton
    Friend WithEvents chk_RememberMe As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents txtPassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtUsername As MetroFramework.Controls.MetroTextBox
End Class
