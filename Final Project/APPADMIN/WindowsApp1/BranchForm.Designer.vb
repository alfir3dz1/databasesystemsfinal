<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BranchForm
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
        Me.BranchList = New System.Windows.Forms.ListView()
        Me.AddBranchButton = New System.Windows.Forms.Button()
        Me.DeleteBranchButton = New System.Windows.Forms.Button()
        Me.UpdateBranchButton = New System.Windows.Forms.Button()
        Me.EnableBranchButton = New System.Windows.Forms.Button()
        Me.DisableBranchButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ShopkeeperLabel = New System.Windows.Forms.Label()
        Me.BranchLabel = New System.Windows.Forms.Label()
        Me.BranchBox = New System.Windows.Forms.TextBox()
        Me.ShopkeeperBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Branches"
        '
        'BranchList
        '
        Me.BranchList.Location = New System.Drawing.Point(18, 48)
        Me.BranchList.Name = "BranchList"
        Me.BranchList.Size = New System.Drawing.Size(477, 390)
        Me.BranchList.TabIndex = 1
        Me.BranchList.UseCompatibleStateImageBehavior = False
        '
        'AddBranchButton
        '
        Me.AddBranchButton.Location = New System.Drawing.Point(501, 48)
        Me.AddBranchButton.Name = "AddBranchButton"
        Me.AddBranchButton.Size = New System.Drawing.Size(319, 23)
        Me.AddBranchButton.TabIndex = 2
        Me.AddBranchButton.Text = "Add Branch"
        Me.AddBranchButton.UseVisualStyleBackColor = True
        '
        'DeleteBranchButton
        '
        Me.DeleteBranchButton.Location = New System.Drawing.Point(501, 77)
        Me.DeleteBranchButton.Name = "DeleteBranchButton"
        Me.DeleteBranchButton.Size = New System.Drawing.Size(319, 23)
        Me.DeleteBranchButton.TabIndex = 3
        Me.DeleteBranchButton.Text = "Delete Branch"
        Me.DeleteBranchButton.UseVisualStyleBackColor = True
        '
        'UpdateBranchButton
        '
        Me.UpdateBranchButton.Location = New System.Drawing.Point(501, 106)
        Me.UpdateBranchButton.Name = "UpdateBranchButton"
        Me.UpdateBranchButton.Size = New System.Drawing.Size(319, 23)
        Me.UpdateBranchButton.TabIndex = 4
        Me.UpdateBranchButton.Text = "Update Branch"
        Me.UpdateBranchButton.UseVisualStyleBackColor = True
        '
        'EnableBranchButton
        '
        Me.EnableBranchButton.Location = New System.Drawing.Point(501, 135)
        Me.EnableBranchButton.Name = "EnableBranchButton"
        Me.EnableBranchButton.Size = New System.Drawing.Size(319, 23)
        Me.EnableBranchButton.TabIndex = 5
        Me.EnableBranchButton.Text = "Enable Branch"
        Me.EnableBranchButton.UseVisualStyleBackColor = True
        '
        'DisableBranchButton
        '
        Me.DisableBranchButton.Location = New System.Drawing.Point(501, 164)
        Me.DisableBranchButton.Name = "DisableBranchButton"
        Me.DisableBranchButton.Size = New System.Drawing.Size(319, 23)
        Me.DisableBranchButton.TabIndex = 6
        Me.DisableBranchButton.Text = "Disable Branch"
        Me.DisableBranchButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ShopkeeperBox)
        Me.GroupBox1.Controls.Add(Me.BranchBox)
        Me.GroupBox1.Controls.Add(Me.BranchLabel)
        Me.GroupBox1.Controls.Add(Me.ShopkeeperLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(501, 193)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 245)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Branch Form"
        '
        'ShopkeeperLabel
        '
        Me.ShopkeeperLabel.AutoSize = True
        Me.ShopkeeperLabel.Location = New System.Drawing.Point(6, 72)
        Me.ShopkeeperLabel.Name = "ShopkeeperLabel"
        Me.ShopkeeperLabel.Size = New System.Drawing.Size(85, 17)
        Me.ShopkeeperLabel.TabIndex = 0
        Me.ShopkeeperLabel.Text = "Shopkeeper"
        '
        'BranchLabel
        '
        Me.BranchLabel.AutoSize = True
        Me.BranchLabel.Location = New System.Drawing.Point(6, 18)
        Me.BranchLabel.Name = "BranchLabel"
        Me.BranchLabel.Size = New System.Drawing.Size(94, 17)
        Me.BranchLabel.TabIndex = 1
        Me.BranchLabel.Text = "Branch Name"
        '
        'BranchBox
        '
        Me.BranchBox.Location = New System.Drawing.Point(9, 38)
        Me.BranchBox.Name = "BranchBox"
        Me.BranchBox.Size = New System.Drawing.Size(304, 22)
        Me.BranchBox.TabIndex = 2
        '
        'ShopkeeperBox
        '
        Me.ShopkeeperBox.FormattingEnabled = True
        Me.ShopkeeperBox.Location = New System.Drawing.Point(9, 92)
        Me.ShopkeeperBox.Name = "ShopkeeperBox"
        Me.ShopkeeperBox.Size = New System.Drawing.Size(304, 24)
        Me.ShopkeeperBox.TabIndex = 3
        '
        'BranchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DisableBranchButton)
        Me.Controls.Add(Me.EnableBranchButton)
        Me.Controls.Add(Me.UpdateBranchButton)
        Me.Controls.Add(Me.DeleteBranchButton)
        Me.Controls.Add(Me.AddBranchButton)
        Me.Controls.Add(Me.BranchList)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BranchForm"
        Me.Text = "Apotechary Application (Admin)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BranchList As ListView
    Friend WithEvents AddBranchButton As Button
    Friend WithEvents DeleteBranchButton As Button
    Friend WithEvents UpdateBranchButton As Button
    Friend WithEvents EnableBranchButton As Button
    Friend WithEvents DisableBranchButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ShopkeeperBox As ComboBox
    Friend WithEvents BranchBox As TextBox
    Friend WithEvents BranchLabel As Label
    Friend WithEvents ShopkeeperLabel As Label
End Class
