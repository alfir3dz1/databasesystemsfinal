<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PharmasistForm
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
        Me.PharmasistList = New System.Windows.Forms.ListView()
        Me.AddPharmasistButton = New System.Windows.Forms.Button()
        Me.DeletePharmasistButton = New System.Windows.Forms.Button()
        Me.UpdatePharmasistButton = New System.Windows.Forms.Button()
        Me.EnablePharmasistButton = New System.Windows.Forms.Button()
        Me.DisablePharmasistButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PharmasistLabel = New System.Windows.Forms.Label()
        Me.GenderLabel = New System.Windows.Forms.Label()
        Me.PharmasistBox = New System.Windows.Forms.TextBox()
        Me.GenderBox = New System.Windows.Forms.TextBox()
        Me.BranchLabel = New System.Windows.Forms.Label()
        Me.BranchBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Pharmasists"
        '
        'PharmasistList
        '
        Me.PharmasistList.Location = New System.Drawing.Point(18, 48)
        Me.PharmasistList.Name = "PharmasistList"
        Me.PharmasistList.Size = New System.Drawing.Size(575, 390)
        Me.PharmasistList.TabIndex = 1
        Me.PharmasistList.UseCompatibleStateImageBehavior = False
        '
        'AddPharmasistButton
        '
        Me.AddPharmasistButton.Location = New System.Drawing.Point(599, 48)
        Me.AddPharmasistButton.Name = "AddPharmasistButton"
        Me.AddPharmasistButton.Size = New System.Drawing.Size(308, 23)
        Me.AddPharmasistButton.TabIndex = 2
        Me.AddPharmasistButton.Text = "Add Pharmasist"
        Me.AddPharmasistButton.UseVisualStyleBackColor = True
        '
        'DeletePharmasistButton
        '
        Me.DeletePharmasistButton.Location = New System.Drawing.Point(599, 77)
        Me.DeletePharmasistButton.Name = "DeletePharmasistButton"
        Me.DeletePharmasistButton.Size = New System.Drawing.Size(308, 23)
        Me.DeletePharmasistButton.TabIndex = 3
        Me.DeletePharmasistButton.Text = "Delete Pharmasist"
        Me.DeletePharmasistButton.UseVisualStyleBackColor = True
        '
        'UpdatePharmasistButton
        '
        Me.UpdatePharmasistButton.Location = New System.Drawing.Point(599, 106)
        Me.UpdatePharmasistButton.Name = "UpdatePharmasistButton"
        Me.UpdatePharmasistButton.Size = New System.Drawing.Size(308, 23)
        Me.UpdatePharmasistButton.TabIndex = 4
        Me.UpdatePharmasistButton.Text = "Update Pharmasist"
        Me.UpdatePharmasistButton.UseVisualStyleBackColor = True
        '
        'EnablePharmasistButton
        '
        Me.EnablePharmasistButton.Location = New System.Drawing.Point(599, 135)
        Me.EnablePharmasistButton.Name = "EnablePharmasistButton"
        Me.EnablePharmasistButton.Size = New System.Drawing.Size(308, 23)
        Me.EnablePharmasistButton.TabIndex = 5
        Me.EnablePharmasistButton.Text = "Enable Pharmasist"
        Me.EnablePharmasistButton.UseVisualStyleBackColor = True
        '
        'DisablePharmasistButton
        '
        Me.DisablePharmasistButton.Location = New System.Drawing.Point(599, 164)
        Me.DisablePharmasistButton.Name = "DisablePharmasistButton"
        Me.DisablePharmasistButton.Size = New System.Drawing.Size(308, 23)
        Me.DisablePharmasistButton.TabIndex = 6
        Me.DisablePharmasistButton.Text = "Disable Pharmasist"
        Me.DisablePharmasistButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BranchBox)
        Me.GroupBox1.Controls.Add(Me.BranchLabel)
        Me.GroupBox1.Controls.Add(Me.GenderBox)
        Me.GroupBox1.Controls.Add(Me.PharmasistBox)
        Me.GroupBox1.Controls.Add(Me.GenderLabel)
        Me.GroupBox1.Controls.Add(Me.PharmasistLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(599, 193)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 245)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pharmasist Form"
        '
        'PharmasistLabel
        '
        Me.PharmasistLabel.AutoSize = True
        Me.PharmasistLabel.Location = New System.Drawing.Point(6, 18)
        Me.PharmasistLabel.Name = "PharmasistLabel"
        Me.PharmasistLabel.Size = New System.Drawing.Size(119, 17)
        Me.PharmasistLabel.TabIndex = 8
        Me.PharmasistLabel.Text = "Pharmasist Name"
        '
        'GenderLabel
        '
        Me.GenderLabel.AutoSize = True
        Me.GenderLabel.Location = New System.Drawing.Point(156, 18)
        Me.GenderLabel.Name = "GenderLabel"
        Me.GenderLabel.Size = New System.Drawing.Size(56, 17)
        Me.GenderLabel.TabIndex = 9
        Me.GenderLabel.Text = "Gender"
        '
        'PharmasistBox
        '
        Me.PharmasistBox.Location = New System.Drawing.Point(9, 38)
        Me.PharmasistBox.Name = "PharmasistBox"
        Me.PharmasistBox.Size = New System.Drawing.Size(140, 22)
        Me.PharmasistBox.TabIndex = 10
        '
        'GenderBox
        '
        Me.GenderBox.Location = New System.Drawing.Point(159, 38)
        Me.GenderBox.Name = "GenderBox"
        Me.GenderBox.Size = New System.Drawing.Size(140, 22)
        Me.GenderBox.TabIndex = 11
        '
        'BranchLabel
        '
        Me.BranchLabel.AutoSize = True
        Me.BranchLabel.Location = New System.Drawing.Point(6, 72)
        Me.BranchLabel.Name = "BranchLabel"
        Me.BranchLabel.Size = New System.Drawing.Size(53, 17)
        Me.BranchLabel.TabIndex = 12
        Me.BranchLabel.Text = "Branch"
        '
        'BranchBox
        '
        Me.BranchBox.FormattingEnabled = True
        Me.BranchBox.Location = New System.Drawing.Point(9, 92)
        Me.BranchBox.Name = "BranchBox"
        Me.BranchBox.Size = New System.Drawing.Size(293, 24)
        Me.BranchBox.TabIndex = 13
        '
        'PharmasistForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DisablePharmasistButton)
        Me.Controls.Add(Me.EnablePharmasistButton)
        Me.Controls.Add(Me.UpdatePharmasistButton)
        Me.Controls.Add(Me.DeletePharmasistButton)
        Me.Controls.Add(Me.AddPharmasistButton)
        Me.Controls.Add(Me.PharmasistList)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PharmasistForm"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PharmasistList As ListView
    Friend WithEvents AddPharmasistButton As Button
    Friend WithEvents DeletePharmasistButton As Button
    Friend WithEvents UpdatePharmasistButton As Button
    Friend WithEvents EnablePharmasistButton As Button
    Friend WithEvents DisablePharmasistButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BranchBox As ComboBox
    Friend WithEvents BranchLabel As Label
    Friend WithEvents GenderBox As TextBox
    Friend WithEvents PharmasistBox As TextBox
    Friend WithEvents GenderLabel As Label
    Friend WithEvents PharmasistLabel As Label
End Class
