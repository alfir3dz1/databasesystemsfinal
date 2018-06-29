Imports MySql.Data.MySqlClient

Public Class RestockForm
    Dim str, query As String
    Dim comm As MySqlCommand
    Dim reader As MySqlDataReader
    Dim prodinf(4) As String
    Dim info As ListViewItem

    Private Sub CloseForm(sender As Object, e As EventArgs) Handles Me.FormClosing
        MainMenuForm.Show()
    End Sub

    Private Sub StockTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles StockTextBox.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ReduceButton_Click(sender As Object, e As EventArgs) Handles ReduceButton.Click
        Try
            If ProductList.SelectedIndices.Count <= 0 Then
                MessageBox.Show("No product is selected!")
                Return
            ElseIf StockTextBox.Text = String.Empty Then
                MessageBox.Show("Value needs to be filled!")
                Return
            Else
                'Update Database
                MainMenuForm.conn.Open()
                Dim item As ListViewItem
                item = ProductList.SelectedItems(0)

                Dim query = "UPDATE product SET product_quantity = product_quantity-" + StockTextBox.Text + " WHERE product_id = " + Convert.ToString(item.SubItems(0).Text)
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader
                MainMenuForm.conn.Close()

                'Saves the stock quantity into the variable 'quantity'
                Dim quantity = 0
                MainMenuForm.conn.Open()
                query = "SELECT product_quantity FROM product WHERE product_id = " + Convert.ToString(item.SubItems(0).Text)
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        quantity = Convert.ToInt16(reader.Item("product_quantity"))
                    End While
                End If
                MainMenuForm.conn.Close()

                'If 'quantity' is negative, automatically convert it to 0 and update the database

                If quantity < 0 Then
                    MainMenuForm.conn.Open()
                    query = "UPDATE product set product_quantity = 0 WHERE product_id = " + Convert.ToString(item.SubItems(0).Text)
                    comm = New MySqlCommand(query, MainMenuForm.conn)
                    reader = comm.ExecuteReader
                    MainMenuForm.conn.Close()
                End If

                'Refresh Table
                MainMenuForm.conn.Open()
                ProductList.Items.Clear()
                query = "SELECT p.product_id AS id, p.product_name AS name, p.product_quantity AS qty, b.branch_name AS branch FROM product AS p, branch AS b WHERE b.branch_id = p.branch_id"
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        prodinf(0) = reader.Item("id")
                        prodinf(1) = reader.Item("name")
                        prodinf(2) = reader.Item("qty")
                        prodinf(3) = reader.Item("branch")
                        info = New ListViewItem(prodinf)
                        ProductList.Items.Add(info)
                    End While
                End If

                MainMenuForm.conn.Close()
            End If

        Catch ex As Exception
            MainMenuForm.conn.Close()
            MessageBox.Show("ERROR  :" + ex.Message)
        End Try
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Try
            If ProductList.SelectedIndices.Count <= 0 Then
                MessageBox.Show("No product is selected!")
                Return
            ElseIf StockTextBox.Text = String.Empty Then
                MessageBox.Show("Value needs to be filled!")
                Return
            Else
                'Update Database
                MainMenuForm.conn.Open()

                Dim item As ListViewItem
                item = ProductList.SelectedItems(0)

                Dim query = "UPDATE product SET product_quantity = product_quantity+" + StockTextBox.Text + " WHERE product_id = " + Convert.ToString(item.SubItems(0).Text)
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                MainMenuForm.conn.Close()

                'Refresh Table
                MainMenuForm.conn.Open()
                ProductList.Items.Clear()
                query = "SELECT p.product_id AS id, p.product_name AS name, p.product_quantity AS qty, b.branch_name AS branch FROM product AS p, branch AS b WHERE b.branch_id = p.branch_id"
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        prodinf(0) = reader.Item("id")
                        prodinf(1) = reader.Item("name")
                        prodinf(2) = reader.Item("qty")
                        prodinf(3) = reader.Item("branch")
                        info = New ListViewItem(prodinf)
                        ProductList.Items.Add(info)
                    End While
                End If

                MainMenuForm.conn.Close()
            End If

        Catch ex As Exception
            MainMenuForm.conn.Close()
            MessageBox.Show("ERROR  :" + ex.Message)
        End Try
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProductList.View = View.Details
        ProductList.FullRowSelect = True
        'ProductList.Columns.Add("Product ID", 100, HorizontalAlignment.Left)
        ProductList.Columns.Add("Product ID", 75, HorizontalAlignment.Left)
        ProductList.Columns.Add("Product Name", 150, HorizontalAlignment.Left)
        ProductList.Columns.Add("Quantity", 75, HorizontalAlignment.Left)
        ProductList.Columns.Add("Branch", 75, HorizontalAlignment.Left)
        'ProductList.Columns.Add("Is On Market", 50, HorizontalAlignment.Left)

        Try
            MainMenuForm.conn.Open()
            ProductList.Items.Clear()
            Dim query = "SELECT p.product_id AS id, p.product_name AS name, p.product_quantity AS qty, b.branch_name AS branch FROM product AS p, branch AS b WHERE b.branch_id = p.branch_id"
            comm = New MySqlCommand(query, MainMenuForm.conn)
            reader = comm.ExecuteReader

            If reader.HasRows Then
                While reader.Read()
                    prodinf(0) = reader.Item("id")
                    prodinf(1) = reader.Item("name")
                    prodinf(2) = reader.Item("qty")
                    prodinf(3) = reader.Item("branch")
                    info = New ListViewItem(prodinf)
                    ProductList.Items.Add(info)
                End While
            End If

            MainMenuForm.conn.Close()
        Catch ex As Exception
            MainMenuForm.conn.Close()
            MessageBox.Show("ERROR  :" + ex.Message)
        End Try
    End Sub
End Class