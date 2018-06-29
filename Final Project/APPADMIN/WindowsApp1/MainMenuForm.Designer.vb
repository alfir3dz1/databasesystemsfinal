<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenuForm
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
        Me.UsernameTextbox = New System.Windows.Forms.TextBox()
        Me.PasswordTextbox = New System.Windows.Forms.TextBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.AdminLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.WelcomeLabel = New System.Windows.Forms.Label()
        Me.RestockProductsButton = New System.Windows.Forms.Button()
        Me.ManageProductsButton = New System.Windows.Forms.Button()
        Me.ManageShopkeepersButton = New System.Windows.Forms.Button()
        Me.ManageBranchesButton = New System.Windows.Forms.Button()
        Me.ManageInvoicesButton = New System.Windows.Forms.Button()
        Me.LogOffButton = New System.Windows.Forms.Button()
        Me.ManagePharmasistsButton = New System.Windows.Forms.Button()
        Me.name3 = New System.Windows.Forms.Label()
        Me.name2 = New System.Windows.Forms.Label()
        Me.name1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UsernameTextbox
        '
        Me.UsernameTextbox.Location = New System.Drawing.Point(179, 135)
        Me.UsernameTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.UsernameTextbox.Name = "UsernameTextbox"
        Me.UsernameTextbox.Size = New System.Drawing.Size(254, 20)
        Me.UsernameTextbox.TabIndex = 0
        '
        'PasswordTextbox
        '
        Me.PasswordTextbox.Location = New System.Drawing.Point(179, 188)
        Me.PasswordTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.PasswordTextbox.Name = "PasswordTextbox"
        Me.PasswordTextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextbox.Size = New System.Drawing.Size(254, 20)
        Me.PasswordTextbox.TabIndex = 1
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(376, 223)
        Me.LoginButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(56, 19)
        Me.LoginButton.TabIndex = 2
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'AdminLabel
        '
        Me.AdminLabel.AutoSize = True
        Me.AdminLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.AdminLabel.Location = New System.Drawing.Point(175, 76)
        Me.AdminLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AdminLabel.Name = "AdminLabel"
        Me.AdminLabel.Size = New System.Drawing.Size(147, 29)
        Me.AdminLabel.TabIndex = 3
        Me.AdminLabel.Text = "Admin Login"
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Location = New System.Drawing.Point(177, 119)
        Me.UsernameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(55, 13)
        Me.UsernameLabel.TabIndex = 4
        Me.UsernameLabel.Text = "Username"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(177, 171)
        Me.PasswordLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(53, 13)
        Me.PasswordLabel.TabIndex = 5
        Me.PasswordLabel.Text = "Password"
        '
        'WelcomeLabel
        '
        Me.WelcomeLabel.AutoSize = True
        Me.WelcomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.WelcomeLabel.Location = New System.Drawing.Point(9, 7)
        Me.WelcomeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.WelcomeLabel.Name = "WelcomeLabel"
        Me.WelcomeLabel.Size = New System.Drawing.Size(175, 29)
        Me.WelcomeLabel.TabIndex = 6
        Me.WelcomeLabel.Text = "WelcomeLabel"
        Me.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.WelcomeLabel.Visible = False
        '
        'RestockProductsButton
        '
        Me.RestockProductsButton.Location = New System.Drawing.Point(14, 50)
        Me.RestockProductsButton.Margin = New System.Windows.Forms.Padding(2)
        Me.RestockProductsButton.Name = "RestockProductsButton"
        Me.RestockProductsButton.Size = New System.Drawing.Size(136, 19)
        Me.RestockProductsButton.TabIndex = 7
        Me.RestockProductsButton.Text = "Restock Products"
        Me.RestockProductsButton.UseVisualStyleBackColor = True
        Me.RestockProductsButton.Visible = False
        '
        'ManageProductsButton
        '
        Me.ManageProductsButton.Location = New System.Drawing.Point(14, 73)
        Me.ManageProductsButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ManageProductsButton.Name = "ManageProductsButton"
        Me.ManageProductsButton.Size = New System.Drawing.Size(136, 19)
        Me.ManageProductsButton.TabIndex = 8
        Me.ManageProductsButton.Text = "Manage Products"
        Me.ManageProductsButton.UseVisualStyleBackColor = True
        Me.ManageProductsButton.Visible = False
        '
        'ManageShopkeepersButton
        '
        Me.ManageShopkeepersButton.Location = New System.Drawing.Point(14, 97)
        Me.ManageShopkeepersButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ManageShopkeepersButton.Name = "ManageShopkeepersButton"
        Me.ManageShopkeepersButton.Size = New System.Drawing.Size(136, 19)
        Me.ManageShopkeepersButton.TabIndex = 9
        Me.ManageShopkeepersButton.Text = "Manage Shopkeepers"
        Me.ManageShopkeepersButton.UseVisualStyleBackColor = True
        Me.ManageShopkeepersButton.Visible = False
        '
        'ManageBranchesButton
        '
        Me.ManageBranchesButton.Location = New System.Drawing.Point(14, 120)
        Me.ManageBranchesButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ManageBranchesButton.Name = "ManageBranchesButton"
        Me.ManageBranchesButton.Size = New System.Drawing.Size(136, 19)
        Me.ManageBranchesButton.TabIndex = 10
        Me.ManageBranchesButton.Text = "Manage Branches"
        Me.ManageBranchesButton.UseVisualStyleBackColor = True
        Me.ManageBranchesButton.Visible = False
        '
        'ManageInvoicesButton
        '
        Me.ManageInvoicesButton.Location = New System.Drawing.Point(14, 167)
        Me.ManageInvoicesButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ManageInvoicesButton.Name = "ManageInvoicesButton"
        Me.ManageInvoicesButton.Size = New System.Drawing.Size(136, 19)
        Me.ManageInvoicesButton.TabIndex = 11
        Me.ManageInvoicesButton.Text = "Manage Invoices"
        Me.ManageInvoicesButton.UseVisualStyleBackColor = True
        Me.ManageInvoicesButton.Visible = False
        '
        'LogOffButton
        '
        Me.LogOffButton.Location = New System.Drawing.Point(14, 190)
        Me.LogOffButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LogOffButton.Name = "LogOffButton"
        Me.LogOffButton.Size = New System.Drawing.Size(136, 19)
        Me.LogOffButton.TabIndex = 12
        Me.LogOffButton.Text = "Log Off"
        Me.LogOffButton.UseVisualStyleBackColor = True
        Me.LogOffButton.Visible = False
        '
        'ManagePharmasistsButton
        '
        Me.ManagePharmasistsButton.Location = New System.Drawing.Point(14, 143)
        Me.ManagePharmasistsButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ManagePharmasistsButton.Name = "ManagePharmasistsButton"
        Me.ManagePharmasistsButton.Size = New System.Drawing.Size(136, 19)
        Me.ManagePharmasistsButton.TabIndex = 13
        Me.ManagePharmasistsButton.Text = "Manage Pharmasists"
        Me.ManagePharmasistsButton.UseVisualStyleBackColor = True
        Me.ManagePharmasistsButton.Visible = False
        '
        'name3
        '
        Me.name3.AutoSize = True
        Me.name3.Location = New System.Drawing.Point(176, 296)
        Me.name3.Name = "name3"
        Me.name3.Size = New System.Drawing.Size(110, 13)
        Me.name3.TabIndex = 32
        Me.name3.Text = "1901520233   Karuna"
        '
        'name2
        '
        Me.name2.AutoSize = True
        Me.name2.Location = New System.Drawing.Point(176, 274)
        Me.name2.Name = "name2"
        Me.name2.Size = New System.Drawing.Size(140, 13)
        Me.name2.TabIndex = 31
        Me.name2.Text = "2101693851   Felix Anggara"
        '
        'name1
        '
        Me.name1.AutoSize = True
        Me.name1.Location = New System.Drawing.Point(176, 251)
        Me.name1.Name = "name1"
        Me.name1.Size = New System.Drawing.Size(138, 13)
        Me.name1.TabIndex = 30
        Me.name1.Text = "2101693574   Alfi Redzwan"
        '
        'MainMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.name3)
        Me.Controls.Add(Me.name2)
        Me.Controls.Add(Me.name1)
        Me.Controls.Add(Me.ManagePharmasistsButton)
        Me.Controls.Add(Me.LogOffButton)
        Me.Controls.Add(Me.ManageInvoicesButton)
        Me.Controls.Add(Me.ManageBranchesButton)
        Me.Controls.Add(Me.ManageShopkeepersButton)
        Me.Controls.Add(Me.ManageProductsButton)
        Me.Controls.Add(Me.RestockProductsButton)
        Me.Controls.Add(Me.WelcomeLabel)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.AdminLabel)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.PasswordTextbox)
        Me.Controls.Add(Me.UsernameTextbox)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainMenuForm"
        Me.Text = "Apotechary Application (Admin)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UsernameTextbox As TextBox
    Friend WithEvents PasswordTextbox As TextBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents AdminLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents WelcomeLabel As Label
    Friend WithEvents RestockProductsButton As Button
    Friend WithEvents ManageProductsButton As Button
    Friend WithEvents ManageShopkeepersButton As Button
    Friend WithEvents ManageBranchesButton As Button
    Friend WithEvents ManageInvoicesButton As Button
    Friend WithEvents LogOffButton As Button
    Friend WithEvents ManagePharmasistsButton As Button
    Friend WithEvents name3 As Label
    Friend WithEvents name2 As Label
    Friend WithEvents name1 As Label
End Class
