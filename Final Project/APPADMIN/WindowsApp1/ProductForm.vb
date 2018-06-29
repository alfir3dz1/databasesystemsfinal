Imports MySql.Data.MySqlClient

Public Class ProductForm
    Dim str, query As String
    Dim comm As MySqlCommand
    Dim reader As MySqlDataReader
    Dim prodinf(8) As String
    Dim info As ListViewItem

    Private Sub ProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ProductList.View = View.Details
        ProductList.FullRowSelect = True
        'ProductList.Columns.Add("Product ID", 100, HorizontalAlignment.Left)
        ProductList.Columns.Add("Product ID", 75, HorizontalAlignment.Left)
        ProductList.Columns.Add("Subcategory", 100, HorizontalAlignment.Left)
        ProductList.Columns.Add("Restriction", 150, HorizontalAlignment.Left)
        ProductList.Columns.Add("Branch", 75, HorizontalAlignment.Left)
        ProductList.Columns.Add("Product Name", 100, HorizontalAlignment.Left)
        ProductList.Columns.Add("Description", 75, HorizontalAlignment.Left)
        ProductList.Columns.Add("Price", 50, HorizontalAlignment.Left)
        ProductList.Columns.Add("For Sale", 75, HorizontalAlignment.Left)

        Try
            'Load Product List
            MainMenuForm.conn.Open()
            ProductList.Items.Clear()
            Dim query = "SELECT p.product_id, s.subcategory_name, r.description AS restriction_level, b.branch_name, p.product_name, p.product_description, p.product_price, p.isonmarket FROM product AS p, subcategory AS s, restriction AS r, branch AS b WHERE p.subcategory_id = s.subcategory_id AND p.restriction_id = r.restriction_id AND p.branch_id = b.branch_id ORDER BY p.product_id ASC"
            'SELECT p.product_id, s.subcategory_name, r.description AS restriction_level, b.branch_name, p.product_name, p.product_description, p.product_price, p.isonmarket
            'FROM product AS p, subcategory AS s, restriction AS r, branch AS b
            'WHERE p.subcategory_id = s.subcategory_id AND p.restriction_id = r.restriction_id AND p.branch_id = b.branch_id
            'ORDER By p.product_id ASC

            comm = New MySqlCommand(query, MainMenuForm.conn)
            reader = comm.ExecuteReader

            If reader.HasRows Then
                While reader.Read()
                    prodinf(0) = reader.Item("product_id")
                    prodinf(1) = reader.Item("subcategory_name")
                    prodinf(2) = reader.Item("restriction_level")
                    prodinf(3) = reader.Item("branch_name")
                    prodinf(4) = reader.Item("product_name")
                    prodinf(5) = reader.Item("product_description")
                    prodinf(6) = reader.Item("product_price")
                    prodinf(7) = reader.Item("isonmarket")
                    info = New ListViewItem(prodinf)
                    ProductList.Items.Add(info)
                End While
            End If
            MainMenuForm.conn.Close()
        Catch ex As Exception
            MainMenuForm.conn.Close()
            MessageBox.Show("ERROR  :" + ex.Message)
        End Try

        'Load Subcategories, Branch and Restriction

        Try
            'Load Subcategories
            MainMenuForm.conn.Open()
            query = "SELECT subcategory_name FROM subcategory"

            comm = New MySqlCommand(query, MainMenuForm.conn)
            reader = comm.ExecuteReader

            If reader.HasRows Then
                While reader.Read()
                    Dim temp As String
                    temp = reader.Item("subcategory_name")

                    SubcategoryBox.Items.Add(temp)
                End While
            End If
            MainMenuForm.conn.Close()

            'Load Branch
            MainMenuForm.conn.Open()
            query = "SELECT branch_name FROM branch"

            comm = New MySqlCommand(query, MainMenuForm.conn)
            reader = comm.ExecuteReader

            If reader.HasRows Then
                While reader.Read()
                    Dim temp As String
                    temp = reader.Item("branch_name")

                    BranchBox.Items.Add(temp)
                End While
            End If
            MainMenuForm.conn.Close()

            'Load Restriction
            MainMenuForm.conn.Open()
            query = "SELECT description FROM restriction"

            comm = New MySqlCommand(query, MainMenuForm.conn)
            reader = comm.ExecuteReader

            If reader.HasRows Then
                While reader.Read()
                    Dim temp As String
                    temp = reader.Item("description")

                    RestrictionBox.Items.Add(temp)
                End While
            End If
            MainMenuForm.conn.Close()
        Catch ex As Exception
            MainMenuForm.conn.Close()
            MessageBox.Show("ERROR  :" + ex.Message)
        End Try

    End Sub

    Private Sub DeleteEntryButton_Click(sender As Object, e As EventArgs) Handles DeleteEntryButton.Click
        Try
            If ProductList.SelectedIndices.Count <= 0 Then
                MessageBox.Show("No product is selected!")
                Return
            Else
                'Update Database
                MainMenuForm.conn.Open()
                Dim item As ListViewItem
                item = ProductList.SelectedItems(0)

                Dim query = "DELETE FROM product WHERE product_id = " + Convert.ToString(item.SubItems(0).Text)
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader
                MainMenuForm.conn.Close()

                MessageBox.Show("Product has been successfully deleted!")

                'Refresh Table
                MainMenuForm.conn.Open()
                ProductList.Items.Clear()
                query = "SELECT p.product_id, s.subcategory_name, r.description AS restriction_level, b.branch_name, p.product_name, p.product_description, p.product_price, p.isonmarket FROM product AS p, subcategory AS s, restriction AS r, branch AS b WHERE p.subcategory_id = s.subcategory_id AND p.restriction_id = r.restriction_id AND p.branch_id = b.branch_id ORDER BY p.product_id ASC"
                'SELECT p.product_id, s.subcategory_name, r.description AS restriction_level, b.branch_name, p.product_name, p.product_description, p.product_price, p.isonmarket
                'FROM product AS p, subcategory AS s, restriction AS r, branch AS b
                'WHERE p.subcategory_id = s.subcategory_id AND p.restriction_id = r.restriction_id AND p.branch_id = b.branch_id
                'ORDER By p.product_id ASC

                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        prodinf(0) = reader.Item("product_id")
                        prodinf(1) = reader.Item("subcategory_name")
                        prodinf(2) = reader.Item("restriction_level")
                        prodinf(3) = reader.Item("branch_name")
                        prodinf(4) = reader.Item("product_name")
                        prodinf(5) = reader.Item("product_description")
                        prodinf(6) = reader.Item("product_price")
                        prodinf(7) = reader.Item("isonmarket")
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

    Private Sub PriceBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PriceBox.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub AddEntryButton_Click(sender As Object, e As EventArgs) Handles AddEntryButton.Click
        Try
            If ProductBox.Text = "" Or PriceBox.Text = "" Or SubcategoryBox.Text = "" Or RestrictionBox.Text = "" Or BranchBox.Text = "" Then
                MessageBox.Show("All values (except description) requires to be filled!")
                Return
            Else
                MainMenuForm.conn.Open()
                query = "INSERT INTO product(subcategory_id, restriction_id, branch_id, product_name, product_description, product_price, product_quantity) " +
                        "SELECT s.subcategory_id, r.restriction_id, b.branch_id, '" + ProductBox.Text + "', '" + DescriptionBox.Text + "', " + PriceBox.Text + ", 0 FROM subcategory AS s, branch AS b, restriction AS r " +
                        "WHERE s.subcategory_name = '" + SubcategoryBox.Text + "' AND r.description = '" + RestrictionBox.Text + "' AND b.branch_name = '" + BranchBox.Text + "'"
                System.Console.WriteLine(query)
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader


                MainMenuForm.conn.Close()

                MessageBox.Show("Product has been successfully added!")

                'Refresh Database

                MainMenuForm.conn.Open()
                ProductList.Items.Clear()
                query = "SELECT p.product_id, s.subcategory_name, r.description AS restriction_level, b.branch_name, p.product_name, p.product_description, p.product_price, p.isonmarket FROM product AS p, subcategory AS s, restriction AS r, branch AS b WHERE p.subcategory_id = s.subcategory_id AND p.restriction_id = r.restriction_id AND p.branch_id = b.branch_id ORDER BY p.product_id ASC"
                'SELECT p.product_id, s.subcategory_name, r.description AS restriction_level, b.branch_name, p.product_name, p.product_description, p.product_price, p.isonmarket
                'FROM product AS p, subcategory AS s, restriction AS r, branch AS b
                'WHERE p.subcategory_id = s.subcategory_id AND p.restriction_id = r.restriction_id AND p.branch_id = b.branch_id
                'ORDER By p.product_id ASC

                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        prodinf(0) = reader.Item("product_id")
                        prodinf(1) = reader.Item("subcategory_name")
                        prodinf(2) = reader.Item("restriction_level")
                        prodinf(3) = reader.Item("branch_name")
                        prodinf(4) = reader.Item("product_name")
                        prodinf(5) = reader.Item("product_description")
                        prodinf(6) = reader.Item("product_price")
                        prodinf(7) = reader.Item("isonmarket")
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

    Private Sub UpdateEntryButton_Click(sender As Object, e As EventArgs) Handles UpdateEntryButton.Click
        Try
            If ProductList.SelectedIndices.Count <= 0 Then
                MessageBox.Show("No product is selected!")
                Return
            ElseIf SubcategoryBox.Text = "" Or BranchBox.Text = "" Or ProductBox.Text = "" Or RestrictionBox.Text = "" Or PriceBox.Text = "" Then
                MessageBox.Show("All value (except description) needs to be filled!")
                Return
            Else
                'Update Database
                MainMenuForm.conn.Open()

                Dim item As ListViewItem
                item = ProductList.SelectedItems(0)

                Dim query = "UPDATE product " +
                "SET subcategory_id=(SELECT sub.subcategory_id FROM subcategory AS sub WHERE sub.subcategory_name='" + SubcategoryBox.Text + "'), " +
                "restriction_id=(SELECT res.restriction_id FROM restriction AS res WHERE res.description='" + RestrictionBox.Text + "'), " +
                "branch_id=(SELECT bra.branch_id FROM branch AS bra WHERE bra.branch_name='" + BranchBox.Text + "'), " +
                "product_name='" + ProductBox.Text + "', product_description='" + DescriptionBox.Text + "', product_price=" + PriceBox.Text + " " +
                "WHERE product_id=" + item.SubItems(0).Text

                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                MainMenuForm.conn.Close()
                MessageBox.Show("Product has been successfully updated!")

                'Refresh Database

                MainMenuForm.conn.Open()
                ProductList.Items.Clear()
                query = "SELECT p.product_id, s.subcategory_name, r.description AS restriction_level, b.branch_name, p.product_name, p.product_description, p.product_price, p.isonmarket FROM product AS p, subcategory AS s, restriction AS r, branch AS b WHERE p.subcategory_id = s.subcategory_id AND p.restriction_id = r.restriction_id AND p.branch_id = b.branch_id ORDER BY p.product_id ASC"
                'SELECT p.product_id, s.subcategory_name, r.description AS restriction_level, b.branch_name, p.product_name, p.product_description, p.product_price, p.isonmarket
                'FROM product AS p, subcategory AS s, restriction AS r, branch AS b
                'WHERE p.subcategory_id = s.subcategory_id AND p.restriction_id = r.restriction_id AND p.branch_id = b.branch_id
                'ORDER By p.product_id ASC

                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        prodinf(0) = reader.Item("product_id")
                        prodinf(1) = reader.Item("subcategory_name")
                        prodinf(2) = reader.Item("restriction_level")
                        prodinf(3) = reader.Item("branch_name")
                        prodinf(4) = reader.Item("product_name")
                        prodinf(5) = reader.Item("product_description")
                        prodinf(6) = reader.Item("product_price")
                        prodinf(7) = reader.Item("isonmarket")
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

    Private Sub DisableEntrySale_Click(sender As Object, e As EventArgs) Handles DisableEntrySale.Click
        Try
            If ProductList.SelectedIndices.Count <= 0 Then
                MessageBox.Show("No product is selected!")
                Return
            Else
                'Disable Entry
                MainMenuForm.conn.Open()

                Dim item As ListViewItem
                item = ProductList.SelectedItems(0)

                Dim query = "UPDATE product SET isonmarket = 0 WHERE product_id=" + item.SubItems(0).Text
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                MainMenuForm.conn.Close()

                'Refresh Database

                MainMenuForm.conn.Open()
                ProductList.Items.Clear()
                query = "SELECT p.product_id, s.subcategory_name, r.description AS restriction_level, b.branch_name, p.product_name, p.product_description, p.product_price, p.isonmarket FROM product AS p, subcategory AS s, restriction AS r, branch AS b WHERE p.subcategory_id = s.subcategory_id AND p.restriction_id = r.restriction_id AND p.branch_id = b.branch_id ORDER BY p.product_id ASC"
                'SELECT p.product_id, s.subcategory_name, r.description AS restriction_level, b.branch_name, p.product_name, p.product_description, p.product_price, p.isonmarket
                'FROM product AS p, subcategory AS s, restriction AS r, branch AS b
                'WHERE p.subcategory_id = s.subcategory_id AND p.restriction_id = r.restriction_id AND p.branch_id = b.branch_id
                'ORDER By p.product_id ASC

                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        prodinf(0) = reader.Item("product_id")
                        prodinf(1) = reader.Item("subcategory_name")
                        prodinf(2) = reader.Item("restriction_level")
                        prodinf(3) = reader.Item("branch_name")
                        prodinf(4) = reader.Item("product_name")
                        prodinf(5) = reader.Item("product_description")
                        prodinf(6) = reader.Item("product_price")
                        prodinf(7) = reader.Item("isonmarket")
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

    Private Sub EnableEntrySaleButton_Click(sender As Object, e As EventArgs) Handles EnableEntrySaleButton.Click
        Try
            If ProductList.SelectedIndices.Count <= 0 Then
                MessageBox.Show("No product is selected!")
                Return
            Else
                'Disable Entry
                MainMenuForm.conn.Open()

                Dim item As ListViewItem
                item = ProductList.SelectedItems(0)

                Dim query = "UPDATE product SET isonmarket = 1 WHERE product_id=" + item.SubItems(0).Text
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                MainMenuForm.conn.Close()

                'Refresh Database

                MainMenuForm.conn.Open()
                ProductList.Items.Clear()
                query = "SELECT p.product_id, s.subcategory_name, r.description AS restriction_level, b.branch_name, p.product_name, p.product_description, p.product_price, p.isonmarket FROM product AS p, subcategory AS s, restriction AS r, branch AS b WHERE p.subcategory_id = s.subcategory_id AND p.restriction_id = r.restriction_id AND p.branch_id = b.branch_id ORDER BY p.product_id ASC"
                'SELECT p.product_id, s.subcategory_name, r.description AS restriction_level, b.branch_name, p.product_name, p.product_description, p.product_price, p.isonmarket
                'FROM product AS p, subcategory AS s, restriction AS r, branch AS b
                'WHERE p.subcategory_id = s.subcategory_id AND p.restriction_id = r.restriction_id AND p.branch_id = b.branch_id
                'ORDER By p.product_id ASC

                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        prodinf(0) = reader.Item("product_id")
                        prodinf(1) = reader.Item("subcategory_name")
                        prodinf(2) = reader.Item("restriction_level")
                        prodinf(3) = reader.Item("branch_name")
                        prodinf(4) = reader.Item("product_name")
                        prodinf(5) = reader.Item("product_description")
                        prodinf(6) = reader.Item("product_price")
                        prodinf(7) = reader.Item("isonmarket")
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

    Private Sub CloseForm(sender As Object, e As EventArgs) Handles Me.FormClosing
        MainMenuForm.Show()
    End Sub
End Class