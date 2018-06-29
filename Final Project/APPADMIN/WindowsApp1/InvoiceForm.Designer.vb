<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoiceForm
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
        Me.InvoiceList = New System.Windows.Forms.ListView()
        Me.AddInvoiceButton = New System.Windows.Forms.Button()
        Me.DeleteInvoiceButton = New System.Windows.Forms.Button()
        Me.UpdateInvoiceButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PharmasistBox = New System.Windows.Forms.ComboBox()
        Me.PharmasistLabel = New System.Windows.Forms.Label()
        Me.ShopkeeperBox = New System.Windows.Forms.ComboBox()
        Me.ShopkeeperLabel = New System.Windows.Forms.Label()
        Me.BranchBox = New System.Windows.Forms.ComboBox()
        Me.BranchLabel = New System.Windows.Forms.Label()
        Me.ClientBox = New System.Windows.Forms.ComboBox()
        Me.ClientLabel = New System.Windows.Forms.Label()
        Me.showOrder = New System.Windows.Forms.ListView()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Invoices"
        '
        'InvoiceList
        '
        Me.InvoiceList.Location = New System.Drawing.Point(14, 39)
        Me.InvoiceList.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.InvoiceList.Name = "InvoiceList"
        Me.InvoiceList.Size = New System.Drawing.Size(486, 168)
        Me.InvoiceList.TabIndex = 1
        Me.InvoiceList.UseCompatibleStateImageBehavior = False
        '
        'AddInvoiceButton
        '
        Me.AddInvoiceButton.Location = New System.Drawing.Point(502, 39)
        Me.AddInvoiceButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AddInvoiceButton.Name = "AddInvoiceButton"
        Me.AddInvoiceButton.Size = New System.Drawing.Size(240, 19)
        Me.AddInvoiceButton.TabIndex = 2
        Me.AddInvoiceButton.Text = "Add Invoice"
        Me.AddInvoiceButton.UseVisualStyleBackColor = True
        '
        'DeleteInvoiceButton
        '
        Me.DeleteInvoiceButton.Location = New System.Drawing.Point(502, 63)
        Me.DeleteInvoiceButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DeleteInvoiceButton.Name = "DeleteInvoiceButton"
        Me.DeleteInvoiceButton.Size = New System.Drawing.Size(240, 19)
        Me.DeleteInvoiceButton.TabIndex = 3
        Me.DeleteInvoiceButton.Text = "Delete Invoice"
        Me.DeleteInvoiceButton.UseVisualStyleBackColor = True
        '
        'UpdateInvoiceButton
        '
        Me.UpdateInvoiceButton.Location = New System.Drawing.Point(502, 86)
        Me.UpdateInvoiceButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UpdateInvoiceButton.Name = "UpdateInvoiceButton"
        Me.UpdateInvoiceButton.Size = New System.Drawing.Size(240, 19)
        Me.UpdateInvoiceButton.TabIndex = 4
        Me.UpdateInvoiceButton.Text = "Update Invoice"
        Me.UpdateInvoiceButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PharmasistBox)
        Me.GroupBox1.Controls.Add(Me.PharmasistLabel)
        Me.GroupBox1.Controls.Add(Me.ShopkeeperBox)
        Me.GroupBox1.Controls.Add(Me.ShopkeeperLabel)
        Me.GroupBox1.Controls.Add(Me.BranchBox)
        Me.GroupBox1.Controls.Add(Me.BranchLabel)
        Me.GroupBox1.Controls.Add(Me.ClientBox)
        Me.GroupBox1.Controls.Add(Me.ClientLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(502, 110)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(240, 246)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Invoice Form"
        '
        'PharmasistBox
        '
        Me.PharmasistBox.FormattingEnabled = True
        Me.PharmasistBox.Location = New System.Drawing.Point(7, 167)
        Me.PharmasistBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PharmasistBox.Name = "PharmasistBox"
        Me.PharmasistBox.Size = New System.Drawing.Size(230, 21)
        Me.PharmasistBox.TabIndex = 7
        '
        'PharmasistLabel
        '
        Me.PharmasistLabel.AutoSize = True
        Me.PharmasistLabel.Location = New System.Drawing.Point(4, 151)
        Me.PharmasistLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PharmasistLabel.Name = "PharmasistLabel"
        Me.PharmasistLabel.Size = New System.Drawing.Size(58, 13)
        Me.PharmasistLabel.TabIndex = 6
        Me.PharmasistLabel.Text = "Pharmasist"
        '
        'ShopkeeperBox
        '
        Me.ShopkeeperBox.FormattingEnabled = True
        Me.ShopkeeperBox.Location = New System.Drawing.Point(7, 122)
        Me.ShopkeeperBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ShopkeeperBox.Name = "ShopkeeperBox"
        Me.ShopkeeperBox.Size = New System.Drawing.Size(230, 21)
        Me.ShopkeeperBox.TabIndex = 5
        '
        'ShopkeeperLabel
        '
        Me.ShopkeeperLabel.AutoSize = True
        Me.ShopkeeperLabel.Location = New System.Drawing.Point(4, 106)
        Me.ShopkeeperLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ShopkeeperLabel.Name = "ShopkeeperLabel"
        Me.ShopkeeperLabel.Size = New System.Drawing.Size(65, 13)
        Me.ShopkeeperLabel.TabIndex = 4
        Me.ShopkeeperLabel.Text = "Shopkeeper"
        '
        'BranchBox
        '
        Me.BranchBox.FormattingEnabled = True
        Me.BranchBox.Location = New System.Drawing.Point(7, 76)
        Me.BranchBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BranchBox.Name = "BranchBox"
        Me.BranchBox.Size = New System.Drawing.Size(230, 21)
        Me.BranchBox.TabIndex = 3
        '
        'BranchLabel
        '
        Me.BranchLabel.AutoSize = True
        Me.BranchLabel.Location = New System.Drawing.Point(4, 60)
        Me.BranchLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BranchLabel.Name = "BranchLabel"
        Me.BranchLabel.Size = New System.Drawing.Size(41, 13)
        Me.BranchLabel.TabIndex = 2
        Me.BranchLabel.Text = "Branch"
        '
        'ClientBox
        '
        Me.ClientBox.FormattingEnabled = True
        Me.ClientBox.Location = New System.Drawing.Point(7, 31)
        Me.ClientBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ClientBox.Name = "ClientBox"
        Me.ClientBox.Size = New System.Drawing.Size(230, 21)
        Me.ClientBox.TabIndex = 1
        '
        'ClientLabel
        '
        Me.ClientLabel.AutoSize = True
        Me.ClientLabel.Location = New System.Drawing.Point(4, 15)
        Me.ClientLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ClientLabel.Name = "ClientLabel"
        Me.ClientLabel.Size = New System.Drawing.Size(60, 13)
        Me.ClientLabel.TabIndex = 0
        Me.ClientLabel.Text = "Client Type"
        '
        'showOrder
        '
        Me.showOrder.Location = New System.Drawing.Point(14, 216)
        Me.showOrder.Name = "showOrder"
        Me.showOrder.Size = New System.Drawing.Size(483, 140)
        Me.showOrder.TabIndex = 6
        Me.showOrder.UseCompatibleStateImageBehavior = False
        '
        'InvoiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 366)
        Me.Controls.Add(Me.showOrder)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.UpdateInvoiceButton)
        Me.Controls.Add(Me.DeleteInvoiceButton)
        Me.Controls.Add(Me.AddInvoiceButton)
        Me.Controls.Add(Me.InvoiceList)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "InvoiceForm"
        Me.Text = "Apotechary Application (Admin)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents InvoiceList As ListView
    Friend WithEvents AddInvoiceButton As Button
    Friend WithEvents DeleteInvoiceButton As Button
    Friend WithEvents UpdateInvoiceButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PharmasistBox As ComboBox
    Friend WithEvents PharmasistLabel As Label
    Friend WithEvents ShopkeeperBox As ComboBox
    Friend WithEvents ShopkeeperLabel As Label
    Friend WithEvents BranchBox As ComboBox
    Friend WithEvents BranchLabel As Label
    Friend WithEvents ClientBox As ComboBox
    Friend WithEvents ClientLabel As Label
    Friend WithEvents showOrder As ListView
End Class
