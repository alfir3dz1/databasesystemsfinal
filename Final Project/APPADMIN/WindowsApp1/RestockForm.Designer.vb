<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RestockForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.ProductList = New System.Windows.Forms.ListView()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.StockTextBox = New System.Windows.Forms.TextBox()
        Me.ReduceButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'HeaderLabel
        '
        Me.HeaderLabel.AutoSize = True
        Me.HeaderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.HeaderLabel.Location = New System.Drawing.Point(12, 9)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(250, 36)
        Me.HeaderLabel.TabIndex = 1
        Me.HeaderLabel.Text = "Restock Products"
        '
        'ProductList
        '
        Me.ProductList.Location = New System.Drawing.Point(18, 48)
        Me.ProductList.Name = "ProductList"
        Me.ProductList.ShowGroups = False
        Me.ProductList.Size = New System.Drawing.Size(526, 306)
        Me.ProductList.TabIndex = 3
        Me.ProductList.UseCompatibleStateImageBehavior = False
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(71, 360)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(118, 23)
        Me.AddButton.TabIndex = 4
        Me.AddButton.Text = "Add Stock"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'StockTextBox
        '
        Me.StockTextBox.Location = New System.Drawing.Point(18, 360)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.Size = New System.Drawing.Size(47, 22)
        Me.StockTextBox.TabIndex = 5
        '
        'ReduceButton
        '
        Me.ReduceButton.Location = New System.Drawing.Point(195, 360)
        Me.ReduceButton.Name = "ReduceButton"
        Me.ReduceButton.Size = New System.Drawing.Size(118, 23)
        Me.ReduceButton.TabIndex = 6
        Me.ReduceButton.Text = "Reduce Stock"
        Me.ReduceButton.UseVisualStyleBackColor = True
        '
        'RestockForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 401)
        Me.Controls.Add(Me.ReduceButton)
        Me.Controls.Add(Me.StockTextBox)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.ProductList)
        Me.Controls.Add(Me.HeaderLabel)
        Me.Name = "RestockForm"
        Me.Text = "Apotechary Application (Admin)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HeaderLabel As Label
    Friend WithEvents ProductList As ListView
    Friend WithEvents AddButton As Button
    Friend WithEvents StockTextBox As TextBox
    Friend WithEvents ReduceButton As Button
End Class
