<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductForm
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
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.ProductList = New System.Windows.Forms.ListView()
        Me.AddEntryButton = New System.Windows.Forms.Button()
        Me.DeleteEntryButton = New System.Windows.Forms.Button()
        Me.UpdateEntryButton = New System.Windows.Forms.Button()
        Me.SubcategoryBox = New System.Windows.Forms.ComboBox()
        Me.FormBox = New System.Windows.Forms.GroupBox()
        Me.RestrictionBox = New System.Windows.Forms.ComboBox()
        Me.RestrictionLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BranchBox = New System.Windows.Forms.ComboBox()
        Me.DescriptionBox = New System.Windows.Forms.TextBox()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.PriceBox = New System.Windows.Forms.TextBox()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.ProductBox = New System.Windows.Forms.TextBox()
        Me.ProductNameLabel = New System.Windows.Forms.Label()
        Me.SubcategoryLabel = New System.Windows.Forms.Label()
        Me.DisableEntrySale = New System.Windows.Forms.Button()
        Me.EnableEntrySaleButton = New System.Windows.Forms.Button()
        Me.FormBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderLabel
        '
        Me.HeaderLabel.AutoSize = True
        Me.HeaderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.HeaderLabel.Location = New System.Drawing.Point(12, 9)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(249, 36)
        Me.HeaderLabel.TabIndex = 0
        Me.HeaderLabel.Text = "Manage Products"
        '
        'ProductList
        '
        Me.ProductList.Location = New System.Drawing.Point(18, 48)
        Me.ProductList.Name = "ProductList"
        Me.ProductList.Size = New System.Drawing.Size(991, 390)
        Me.ProductList.TabIndex = 1
        Me.ProductList.UseCompatibleStateImageBehavior = False
        '
        'AddEntryButton
        '
        Me.AddEntryButton.Location = New System.Drawing.Point(1015, 48)
        Me.AddEntryButton.Name = "AddEntryButton"
        Me.AddEntryButton.Size = New System.Drawing.Size(322, 23)
        Me.AddEntryButton.TabIndex = 2
        Me.AddEntryButton.Text = "Add Entry"
        Me.AddEntryButton.UseVisualStyleBackColor = True
        '
        'DeleteEntryButton
        '
        Me.DeleteEntryButton.Location = New System.Drawing.Point(1015, 77)
        Me.DeleteEntryButton.Name = "DeleteEntryButton"
        Me.DeleteEntryButton.Size = New System.Drawing.Size(322, 23)
        Me.DeleteEntryButton.TabIndex = 3
        Me.DeleteEntryButton.Text = "Delete Entry"
        Me.DeleteEntryButton.UseVisualStyleBackColor = True
        '
        'UpdateEntryButton
        '
        Me.UpdateEntryButton.Location = New System.Drawing.Point(1015, 106)
        Me.UpdateEntryButton.Name = "UpdateEntryButton"
        Me.UpdateEntryButton.Size = New System.Drawing.Size(322, 23)
        Me.UpdateEntryButton.TabIndex = 4
        Me.UpdateEntryButton.Text = "Update Entry"
        Me.UpdateEntryButton.UseVisualStyleBackColor = True
        '
        'SubcategoryBox
        '
        Me.SubcategoryBox.FormattingEnabled = True
        Me.SubcategoryBox.Location = New System.Drawing.Point(9, 147)
        Me.SubcategoryBox.Name = "SubcategoryBox"
        Me.SubcategoryBox.Size = New System.Drawing.Size(147, 24)
        Me.SubcategoryBox.TabIndex = 5
        '
        'FormBox
        '
        Me.FormBox.Controls.Add(Me.RestrictionBox)
        Me.FormBox.Controls.Add(Me.RestrictionLabel)
        Me.FormBox.Controls.Add(Me.Label1)
        Me.FormBox.Controls.Add(Me.BranchBox)
        Me.FormBox.Controls.Add(Me.DescriptionBox)
        Me.FormBox.Controls.Add(Me.DescriptionLabel)
        Me.FormBox.Controls.Add(Me.PriceBox)
        Me.FormBox.Controls.Add(Me.PriceLabel)
        Me.FormBox.Controls.Add(Me.ProductBox)
        Me.FormBox.Controls.Add(Me.ProductNameLabel)
        Me.FormBox.Controls.Add(Me.SubcategoryLabel)
        Me.FormBox.Controls.Add(Me.SubcategoryBox)
        Me.FormBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.FormBox.Location = New System.Drawing.Point(1015, 193)
        Me.FormBox.Name = "FormBox"
        Me.FormBox.Size = New System.Drawing.Size(322, 245)
        Me.FormBox.TabIndex = 7
        Me.FormBox.TabStop = False
        Me.FormBox.Text = "Entry Form"
        '
        'RestrictionBox
        '
        Me.RestrictionBox.FormattingEnabled = True
        Me.RestrictionBox.Location = New System.Drawing.Point(9, 203)
        Me.RestrictionBox.Name = "RestrictionBox"
        Me.RestrictionBox.Size = New System.Drawing.Size(307, 24)
        Me.RestrictionBox.TabIndex = 16
        '
        'RestrictionLabel
        '
        Me.RestrictionLabel.AutoSize = True
        Me.RestrictionLabel.Location = New System.Drawing.Point(6, 183)
        Me.RestrictionLabel.Name = "RestrictionLabel"
        Me.RestrictionLabel.Size = New System.Drawing.Size(118, 17)
        Me.RestrictionLabel.TabIndex = 15
        Me.RestrictionLabel.Text = "Select Restriction"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(166, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Select Branch"
        '
        'BranchBox
        '
        Me.BranchBox.FormattingEnabled = True
        Me.BranchBox.Location = New System.Drawing.Point(169, 147)
        Me.BranchBox.Name = "BranchBox"
        Me.BranchBox.Size = New System.Drawing.Size(147, 24)
        Me.BranchBox.TabIndex = 13
        '
        'DescriptionBox
        '
        Me.DescriptionBox.Location = New System.Drawing.Point(9, 93)
        Me.DescriptionBox.Name = "DescriptionBox"
        Me.DescriptionBox.Size = New System.Drawing.Size(307, 22)
        Me.DescriptionBox.TabIndex = 12
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Location = New System.Drawing.Point(6, 73)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(79, 17)
        Me.DescriptionLabel.TabIndex = 11
        Me.DescriptionLabel.Text = "Description"
        '
        'PriceBox
        '
        Me.PriceBox.Location = New System.Drawing.Point(169, 38)
        Me.PriceBox.Name = "PriceBox"
        Me.PriceBox.Size = New System.Drawing.Size(147, 22)
        Me.PriceBox.TabIndex = 10
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Location = New System.Drawing.Point(166, 18)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(40, 17)
        Me.PriceLabel.TabIndex = 9
        Me.PriceLabel.Text = "Price"
        '
        'ProductBox
        '
        Me.ProductBox.Location = New System.Drawing.Point(9, 38)
        Me.ProductBox.Name = "ProductBox"
        Me.ProductBox.Size = New System.Drawing.Size(147, 22)
        Me.ProductBox.TabIndex = 8
        '
        'ProductNameLabel
        '
        Me.ProductNameLabel.AutoSize = True
        Me.ProductNameLabel.Location = New System.Drawing.Point(6, 18)
        Me.ProductNameLabel.Name = "ProductNameLabel"
        Me.ProductNameLabel.Size = New System.Drawing.Size(98, 17)
        Me.ProductNameLabel.TabIndex = 7
        Me.ProductNameLabel.Text = "Product Name"
        '
        'SubcategoryLabel
        '
        Me.SubcategoryLabel.AutoSize = True
        Me.SubcategoryLabel.Location = New System.Drawing.Point(6, 127)
        Me.SubcategoryLabel.Name = "SubcategoryLabel"
        Me.SubcategoryLabel.Size = New System.Drawing.Size(131, 17)
        Me.SubcategoryLabel.TabIndex = 6
        Me.SubcategoryLabel.Text = "Select Subcategory"
        '
        'DisableEntrySale
        '
        Me.DisableEntrySale.Location = New System.Drawing.Point(1015, 164)
        Me.DisableEntrySale.Name = "DisableEntrySale"
        Me.DisableEntrySale.Size = New System.Drawing.Size(322, 23)
        Me.DisableEntrySale.TabIndex = 8
        Me.DisableEntrySale.Text = "Disable Entry Sale"
        Me.DisableEntrySale.UseVisualStyleBackColor = True
        '
        'EnableEntrySaleButton
        '
        Me.EnableEntrySaleButton.Location = New System.Drawing.Point(1015, 135)
        Me.EnableEntrySaleButton.Name = "EnableEntrySaleButton"
        Me.EnableEntrySaleButton.Size = New System.Drawing.Size(322, 23)
        Me.EnableEntrySaleButton.TabIndex = 9
        Me.EnableEntrySaleButton.Text = "Enable Entry Sale"
        Me.EnableEntrySaleButton.UseVisualStyleBackColor = True
        '
        'ProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1355, 456)
        Me.Controls.Add(Me.EnableEntrySaleButton)
        Me.Controls.Add(Me.DisableEntrySale)
        Me.Controls.Add(Me.FormBox)
        Me.Controls.Add(Me.UpdateEntryButton)
        Me.Controls.Add(Me.DeleteEntryButton)
        Me.Controls.Add(Me.AddEntryButton)
        Me.Controls.Add(Me.ProductList)
        Me.Controls.Add(Me.HeaderLabel)
        Me.Name = "ProductForm"
        Me.Text = "Apotechary Application (Admin)"
        Me.FormBox.ResumeLayout(False)
        Me.FormBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HeaderLabel As Label
    Friend WithEvents ProductList As ListView
    Friend WithEvents AddEntryButton As Button
    Friend WithEvents DeleteEntryButton As Button
    Friend WithEvents UpdateEntryButton As Button
    Friend WithEvents SubcategoryBox As ComboBox
    Friend WithEvents FormBox As GroupBox
    Friend WithEvents SubcategoryLabel As Label
    Friend WithEvents ProductNameLabel As Label
    Friend WithEvents ProductBox As TextBox
    Friend WithEvents PriceBox As TextBox
    Friend WithEvents PriceLabel As Label
    Friend WithEvents DescriptionBox As TextBox
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents RestrictionBox As ComboBox
    Friend WithEvents RestrictionLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BranchBox As ComboBox
    Friend WithEvents DisableEntrySale As Button
    Friend WithEvents EnableEntrySaleButton As Button
End Class
