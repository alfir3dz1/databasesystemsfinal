<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShopkeeperForm
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
        Me.ShopkeeperList = New System.Windows.Forms.ListView()
        Me.AddShopkeeperButton = New System.Windows.Forms.Button()
        Me.DeleteShopkeeperButton = New System.Windows.Forms.Button()
        Me.UpdateShopkeeperButton = New System.Windows.Forms.Button()
        Me.EnableShopkeeperButton = New System.Windows.Forms.Button()
        Me.DisableShopkeeperButton = New System.Windows.Forms.Button()
        Me.FormBox = New System.Windows.Forms.GroupBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.PasswordBox = New System.Windows.Forms.TextBox()
        Me.PhoneLabel = New System.Windows.Forms.Label()
        Me.GenderLabel = New System.Windows.Forms.Label()
        Me.BranchLabel = New System.Windows.Forms.Label()
        Me.BranchBox = New System.Windows.Forms.ComboBox()
        Me.CommentBox = New System.Windows.Forms.TextBox()
        Me.CommentLabel = New System.Windows.Forms.Label()
        Me.PhoneBox = New System.Windows.Forms.TextBox()
        Me.AgeBox = New System.Windows.Forms.TextBox()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.GenderBox = New System.Windows.Forms.TextBox()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.ShopkeeperLabel = New System.Windows.Forms.Label()
        Me.FormBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Shopkeepers"
        '
        'ShopkeeperList
        '
        Me.ShopkeeperList.Location = New System.Drawing.Point(18, 48)
        Me.ShopkeeperList.Name = "ShopkeeperList"
        Me.ShopkeeperList.Size = New System.Drawing.Size(880, 390)
        Me.ShopkeeperList.TabIndex = 1
        Me.ShopkeeperList.UseCompatibleStateImageBehavior = False
        '
        'AddShopkeeperButton
        '
        Me.AddShopkeeperButton.Location = New System.Drawing.Point(904, 48)
        Me.AddShopkeeperButton.Name = "AddShopkeeperButton"
        Me.AddShopkeeperButton.Size = New System.Drawing.Size(326, 23)
        Me.AddShopkeeperButton.TabIndex = 2
        Me.AddShopkeeperButton.Text = "Add Shopkeeper"
        Me.AddShopkeeperButton.UseVisualStyleBackColor = True
        '
        'DeleteShopkeeperButton
        '
        Me.DeleteShopkeeperButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DeleteShopkeeperButton.Location = New System.Drawing.Point(904, 77)
        Me.DeleteShopkeeperButton.Name = "DeleteShopkeeperButton"
        Me.DeleteShopkeeperButton.Size = New System.Drawing.Size(326, 23)
        Me.DeleteShopkeeperButton.TabIndex = 3
        Me.DeleteShopkeeperButton.Text = "Delete Shopkeeper"
        Me.DeleteShopkeeperButton.UseVisualStyleBackColor = True
        '
        'UpdateShopkeeperButton
        '
        Me.UpdateShopkeeperButton.Location = New System.Drawing.Point(904, 106)
        Me.UpdateShopkeeperButton.Name = "UpdateShopkeeperButton"
        Me.UpdateShopkeeperButton.Size = New System.Drawing.Size(326, 23)
        Me.UpdateShopkeeperButton.TabIndex = 4
        Me.UpdateShopkeeperButton.Text = "Update Shopkeeper"
        Me.UpdateShopkeeperButton.UseVisualStyleBackColor = True
        '
        'EnableShopkeeperButton
        '
        Me.EnableShopkeeperButton.Location = New System.Drawing.Point(904, 135)
        Me.EnableShopkeeperButton.Name = "EnableShopkeeperButton"
        Me.EnableShopkeeperButton.Size = New System.Drawing.Size(326, 23)
        Me.EnableShopkeeperButton.TabIndex = 5
        Me.EnableShopkeeperButton.Text = "Enable Shopkeeper"
        Me.EnableShopkeeperButton.UseVisualStyleBackColor = True
        '
        'DisableShopkeeperButton
        '
        Me.DisableShopkeeperButton.Location = New System.Drawing.Point(904, 164)
        Me.DisableShopkeeperButton.Name = "DisableShopkeeperButton"
        Me.DisableShopkeeperButton.Size = New System.Drawing.Size(326, 23)
        Me.DisableShopkeeperButton.TabIndex = 6
        Me.DisableShopkeeperButton.Text = "Disable Shopkeeper"
        Me.DisableShopkeeperButton.UseVisualStyleBackColor = True
        '
        'FormBox
        '
        Me.FormBox.Controls.Add(Me.PasswordLabel)
        Me.FormBox.Controls.Add(Me.PasswordBox)
        Me.FormBox.Controls.Add(Me.PhoneLabel)
        Me.FormBox.Controls.Add(Me.GenderLabel)
        Me.FormBox.Controls.Add(Me.BranchLabel)
        Me.FormBox.Controls.Add(Me.BranchBox)
        Me.FormBox.Controls.Add(Me.CommentBox)
        Me.FormBox.Controls.Add(Me.CommentLabel)
        Me.FormBox.Controls.Add(Me.PhoneBox)
        Me.FormBox.Controls.Add(Me.AgeBox)
        Me.FormBox.Controls.Add(Me.AgeLabel)
        Me.FormBox.Controls.Add(Me.GenderBox)
        Me.FormBox.Controls.Add(Me.NameBox)
        Me.FormBox.Controls.Add(Me.ShopkeeperLabel)
        Me.FormBox.Location = New System.Drawing.Point(904, 193)
        Me.FormBox.Name = "FormBox"
        Me.FormBox.Size = New System.Drawing.Size(324, 245)
        Me.FormBox.TabIndex = 7
        Me.FormBox.TabStop = False
        Me.FormBox.Text = "Shopkeeper Form"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(168, 18)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(69, 17)
        Me.PasswordLabel.TabIndex = 15
        Me.PasswordLabel.Text = "Password"
        '
        'PasswordBox
        '
        Me.PasswordBox.Location = New System.Drawing.Point(171, 38)
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordBox.Size = New System.Drawing.Size(147, 22)
        Me.PasswordBox.TabIndex = 14
        '
        'PhoneLabel
        '
        Me.PhoneLabel.AutoSize = True
        Me.PhoneLabel.Location = New System.Drawing.Point(168, 128)
        Me.PhoneLabel.Name = "PhoneLabel"
        Me.PhoneLabel.Size = New System.Drawing.Size(49, 17)
        Me.PhoneLabel.TabIndex = 13
        Me.PhoneLabel.Text = "Phone"
        '
        'GenderLabel
        '
        Me.GenderLabel.AutoSize = True
        Me.GenderLabel.Location = New System.Drawing.Point(168, 73)
        Me.GenderLabel.Name = "GenderLabel"
        Me.GenderLabel.Size = New System.Drawing.Size(56, 17)
        Me.GenderLabel.TabIndex = 12
        Me.GenderLabel.Text = "Gender"
        '
        'BranchLabel
        '
        Me.BranchLabel.AutoSize = True
        Me.BranchLabel.Location = New System.Drawing.Point(6, 127)
        Me.BranchLabel.Name = "BranchLabel"
        Me.BranchLabel.Size = New System.Drawing.Size(53, 17)
        Me.BranchLabel.TabIndex = 11
        Me.BranchLabel.Text = "Branch"
        '
        'BranchBox
        '
        Me.BranchBox.FormattingEnabled = True
        Me.BranchBox.Location = New System.Drawing.Point(9, 147)
        Me.BranchBox.Name = "BranchBox"
        Me.BranchBox.Size = New System.Drawing.Size(147, 24)
        Me.BranchBox.TabIndex = 10
        '
        'CommentBox
        '
        Me.CommentBox.Location = New System.Drawing.Point(9, 203)
        Me.CommentBox.Name = "CommentBox"
        Me.CommentBox.Size = New System.Drawing.Size(309, 22)
        Me.CommentBox.TabIndex = 9
        '
        'CommentLabel
        '
        Me.CommentLabel.AutoSize = True
        Me.CommentLabel.Location = New System.Drawing.Point(6, 183)
        Me.CommentLabel.Name = "CommentLabel"
        Me.CommentLabel.Size = New System.Drawing.Size(67, 17)
        Me.CommentLabel.TabIndex = 8
        Me.CommentLabel.Text = "Comment"
        '
        'PhoneBox
        '
        Me.PhoneBox.Location = New System.Drawing.Point(171, 148)
        Me.PhoneBox.Name = "PhoneBox"
        Me.PhoneBox.Size = New System.Drawing.Size(147, 22)
        Me.PhoneBox.TabIndex = 6
        '
        'AgeBox
        '
        Me.AgeBox.Location = New System.Drawing.Point(9, 93)
        Me.AgeBox.Name = "AgeBox"
        Me.AgeBox.Size = New System.Drawing.Size(147, 22)
        Me.AgeBox.TabIndex = 5
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(6, 73)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(33, 17)
        Me.AgeLabel.TabIndex = 4
        Me.AgeLabel.Text = "Age"
        '
        'GenderBox
        '
        Me.GenderBox.Location = New System.Drawing.Point(171, 93)
        Me.GenderBox.Name = "GenderBox"
        Me.GenderBox.Size = New System.Drawing.Size(147, 22)
        Me.GenderBox.TabIndex = 2
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(9, 38)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(147, 22)
        Me.NameBox.TabIndex = 1
        '
        'ShopkeeperLabel
        '
        Me.ShopkeeperLabel.AutoSize = True
        Me.ShopkeeperLabel.Location = New System.Drawing.Point(6, 18)
        Me.ShopkeeperLabel.Name = "ShopkeeperLabel"
        Me.ShopkeeperLabel.Size = New System.Drawing.Size(45, 17)
        Me.ShopkeeperLabel.TabIndex = 0
        Me.ShopkeeperLabel.Text = "Name"
        '
        'ShopkeeperForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 450)
        Me.Controls.Add(Me.FormBox)
        Me.Controls.Add(Me.DisableShopkeeperButton)
        Me.Controls.Add(Me.EnableShopkeeperButton)
        Me.Controls.Add(Me.UpdateShopkeeperButton)
        Me.Controls.Add(Me.DeleteShopkeeperButton)
        Me.Controls.Add(Me.AddShopkeeperButton)
        Me.Controls.Add(Me.ShopkeeperList)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ShopkeeperForm"
        Me.Text = "Apotechary Application (Admin)"
        Me.FormBox.ResumeLayout(False)
        Me.FormBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ShopkeeperList As ListView
    Friend WithEvents AddShopkeeperButton As Button
    Friend WithEvents DeleteShopkeeperButton As Button
    Friend WithEvents UpdateShopkeeperButton As Button
    Friend WithEvents EnableShopkeeperButton As Button
    Friend WithEvents DisableShopkeeperButton As Button
    Friend WithEvents FormBox As GroupBox
    Friend WithEvents ShopkeeperLabel As Label
    Friend WithEvents BranchLabel As Label
    Friend WithEvents BranchBox As ComboBox
    Friend WithEvents CommentBox As TextBox
    Friend WithEvents CommentLabel As Label
    Friend WithEvents PhoneBox As TextBox
    Friend WithEvents AgeBox As TextBox
    Friend WithEvents AgeLabel As Label
    Friend WithEvents GenderBox As TextBox
    Friend WithEvents NameBox As TextBox
    Friend WithEvents GenderLabel As Label
    Friend WithEvents PhoneLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents PasswordBox As TextBox
End Class
