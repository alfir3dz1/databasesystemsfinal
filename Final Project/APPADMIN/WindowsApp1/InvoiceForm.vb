Imports MySql.Data.MySqlClient

Public Class InvoiceForm
    Dim str, query As String
    Dim comm As MySqlCommand
    Dim reader As MySqlDataReader
    Dim inf(5) As String
    Dim showPurc(4) As String
    Dim info As ListViewItem

    Private Sub CloseForm(sender As Object, e As EventArgs) Handles Me.FormClosing
        showOrder.Items.Clear()
        MainMenuForm.Show()
    End Sub

    Private Sub DeleteInvoiceButton_Click(sender As Object, e As EventArgs) Handles DeleteInvoiceButton.Click
        showOrder.Items.Clear()
        Try
            If InvoiceList.SelectedIndices.Count <= 0 Then
                MessageBox.Show("No invoice is selected!")
                Return
            Else
                'Delete Data
                Dim item As ListViewItem
                item = InvoiceList.SelectedItems(0)
                MainMenuForm.conn.Open()
                Dim query = "DELETE FROM cart WHERE invoice_id = " + Convert.ToString(item.SubItems(0).Text) + ";"
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader
                MainMenuForm.conn.Close()
                MainMenuForm.conn.Open()
                query = "DELETE FROM invoice WHERE invoice_id = " + Convert.ToString(item.SubItems(0).Text) + ";"
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader
                MainMenuForm.conn.Close()

                MessageBox.Show("Invoice has been successfully deleted!")

                'Refresh Table
                MainMenuForm.conn.Open()
                InvoiceList.Items.Clear()
                query = "SELECT i.invoice_id, c.client_type, b.branch_name AS branch, s.shopkeeper_name AS shopkeeper, p.pharmasist_name AS pharmasist FROM invoice AS i, client AS c, branch AS b, shopkeeper AS s, pharmasist AS p WHERE i.client_id = c.client_id AND i.branch_id = b.branch_id AND i.shopkeeper_id = s.shopkeeper_id AND i.pharmasist_id = p.pharmasist_id ORDER BY invoice_id ASC"
                'SELECT i.invoice_id, c.client_type, b.branch_name AS branch, s.shopkeeper_name AS shopkeeper, p.pharmasist_name AS pharmasist FROM invoice AS i, client AS c, branch AS b, shopkeeper AS s, pharmasist AS p WHERE i.client_id = c.client_id AND i.branch_id = b.branch_id AND i.shopkeeper_id = s.shopkeeper_id AND i.pharmasist_id = p.pharmasist_id
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        inf(0) = reader.Item("invoice_id")
                        inf(1) = reader.Item("client_type")
                        inf(2) = reader.Item("branch")
                        inf(3) = reader.Item("shopkeeper")
                        inf(4) = reader.Item("pharmasist")
                        info = New ListViewItem(inf)
                        InvoiceList.Items.Add(info)
                    End While
                End If

                MainMenuForm.conn.Close()
            End If

        Catch ex As Exception
            MainMenuForm.conn.Close()
            MessageBox.Show("ERROR  :" + ex.Message)
        End Try
    End Sub

    Private Sub AddInvoiceButton_Click(sender As Object, e As EventArgs) Handles AddInvoiceButton.Click
        showOrder.Items.Clear()
        Try
            If ClientBox.Text = "" Or BranchBox.Text = "" Or ShopkeeperBox.Text = "" Or PharmasistBox.Text = "" Then
                MessageBox.Show("All values requires to be filled!")
                Return
            Else
                MainMenuForm.conn.Open()
                query = "INSERT INTO invoice(client_id, branch_id, shopkeeper_id, pharmasist_id) " +
                        "SELECT c.client_id, b.branch_id, s.shopkeeper_id, p.pharmasist_id FROM client c, branch b, shopkeeper s, pharmasist p " +
                        "WHERE c.client_type = '" + ClientBox.Text + "' AND b.branch_name = '" + BranchBox.Text + "' AND s.shopkeeper_name = '" + ShopkeeperBox.Text + "' AND p.pharmasist_name = '" + PharmasistBox.Text + "'"

                System.Console.WriteLine(query)
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                MainMenuForm.conn.Close()

                MessageBox.Show("Invoice has been successfully added!")

                'Refresh Database
                MainMenuForm.conn.Open()
                InvoiceList.Items.Clear()
                query = "SELECT i.invoice_id, c.client_type, b.branch_name AS branch, s.shopkeeper_name AS shopkeeper, p.pharmasist_name AS pharmasist FROM invoice AS i, client AS c, branch AS b, shopkeeper AS s, pharmasist AS p WHERE i.client_id = c.client_id AND i.branch_id = b.branch_id AND i.shopkeeper_id = s.shopkeeper_id AND i.pharmasist_id = p.pharmasist_id ORDER BY invoice_id ASC"
                'SELECT i.invoice_id, c.client_type, b.branch_name AS branch, s.shopkeeper_name AS shopkeeper, p.pharmasist_name AS pharmasist FROM invoice AS i, client AS c, branch AS b, shopkeeper AS s, pharmasist AS p WHERE i.client_id = c.client_id AND i.branch_id = b.branch_id AND i.shopkeeper_id = s.shopkeeper_id AND i.pharmasist_id = p.pharmasist_id
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        inf(0) = reader.Item("invoice_id")
                        inf(1) = reader.Item("client_type")
                        inf(2) = reader.Item("branch")
                        inf(3) = reader.Item("shopkeeper")
                        inf(4) = reader.Item("pharmasist")
                        info = New ListViewItem(inf)
                        InvoiceList.Items.Add(info)
                    End While
                End If

                MainMenuForm.conn.Close()
            End If
        Catch ex As Exception
            MainMenuForm.conn.Close()
            MessageBox.Show("ERROR  :" + ex.Message)
        End Try
    End Sub

    Private Sub UpdateInvoiceButton_Click(sender As Object, e As EventArgs) Handles UpdateInvoiceButton.Click
        showOrder.Items.Clear()
        Try
            If InvoiceList.SelectedIndices.Count <= 0 Then
                MessageBox.Show("No invoice is selected!")
                Return
            ElseIf ClientBox.Text = "" Or BranchBox.Text = "" Or ShopkeeperBox.Text = "" Or PharmasistBox.Text = "" Then
                MessageBox.Show("All values requires to be filled!")
                Return
            Else
                'Update Database
                MainMenuForm.conn.Open()

                Dim item As ListViewItem
                item = InvoiceList.SelectedItems(0)

                Dim query = "UPDATE invoice " +
                            "SET client_id = (SELECT c.client_id FROM client c WHERE c.client_type='" + ClientBox.Text + "'), " +
                            "branch_id = (SELECT b.branch_id FROM branch b WHERE b.branch_name='" + BranchBox.Text + "'), " +
                            "shopkeeper_id = (SELECT s.shopkeeper_id FROM shopkeeper s WHERE s.shopkeeper_name='" + ShopkeeperBox.Text + "'), " +
                            "pharmasist_id = (SELECT p.pharmasist_id FROM pharmasist p WHERE p.pharmasist_name='" + PharmasistBox.Text + "') " +
                            "WHERE invoice_id = " + item.SubItems(0).Text

                System.Console.WriteLine(query)
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                MainMenuForm.conn.Close()
                MessageBox.Show("Invoice has been successfully updated!")

                'Refresh Database
                MainMenuForm.conn.Open()
                InvoiceList.Items.Clear()
                query = "SELECT i.invoice_id, c.client_type, b.branch_name AS branch, s.shopkeeper_name AS shopkeeper, p.pharmasist_name AS pharmasist FROM invoice AS i, client AS c, branch AS b, shopkeeper AS s, pharmasist AS p WHERE i.client_id = c.client_id AND i.branch_id = b.branch_id AND i.shopkeeper_id = s.shopkeeper_id AND i.pharmasist_id = p.pharmasist_id ORDER BY invoice_id ASC"
                'SELECT i.invoice_id, c.client_type, b.branch_name AS branch, s.shopkeeper_name AS shopkeeper, p.pharmasist_name AS pharmasist FROM invoice AS i, client AS c, branch AS b, shopkeeper AS s, pharmasist AS p WHERE i.client_id = c.client_id AND i.branch_id = b.branch_id AND i.shopkeeper_id = s.shopkeeper_id AND i.pharmasist_id = p.pharmasist_id
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        inf(0) = reader.Item("invoice_id")
                        inf(1) = reader.Item("client_type")
                        inf(2) = reader.Item("branch")
                        inf(3) = reader.Item("shopkeeper")
                        inf(4) = reader.Item("pharmasist")
                        info = New ListViewItem(inf)
                        InvoiceList.Items.Add(info)
                    End While
                End If

                MainMenuForm.conn.Close()
            End If

        Catch ex As Exception
            MainMenuForm.conn.Close()
            MessageBox.Show("ERROR  :" + ex.Message)
        End Try
    End Sub

    Private Sub showOrder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles showOrder.SelectedIndexChanged

    End Sub

    Private Sub InvoiceList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InvoiceList.SelectedIndexChanged
        If InvoiceList.SelectedItems.Count > 0 Then
            showOrder.Items.Clear()
            Dim query = "SELECT product_name, restriction_level, ordered_quantity, (ordered_quantity*product_price)as total_price FROM ((cart inner join product on cart.product_id = product.product_id) inner join restriction on product.restriction_id=restriction.restriction_id) WHERE invoice_id=" + InvoiceList.SelectedItems(0).Text + ";"
            Try
                MainMenuForm.conn.Open()
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader
                If reader.HasRows Then
                    While reader.Read
                        showPurc(0) = reader.Item("product_name")
                        showPurc(1) = reader.Item("restriction_level")
                        showPurc(2) = reader.Item("ordered_quantity")
                        showPurc(3) = reader.Item("total_price")
                        info = New ListViewItem(showPurc)
                        showOrder.Items.Add(info)

                    End While
                End If
                MainMenuForm.conn.Close()
            Catch ex As Exception
                MainMenuForm.conn.Close()
            End Try
        End If
    End Sub

    Private Sub InvoiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InvoiceList.View = View.Details
        InvoiceList.FullRowSelect = True
        InvoiceList.Columns.Add("Invoice ID", 70, HorizontalAlignment.Left)
        InvoiceList.Columns.Add("Client Type", 200, HorizontalAlignment.Left)
        InvoiceList.Columns.Add("Branch", 50, HorizontalAlignment.Left)
        InvoiceList.Columns.Add("Shopkeeper", 75, HorizontalAlignment.Left)
        InvoiceList.Columns.Add("Pharmasist", 75, HorizontalAlignment.Left)
        showOrder.View = View.Details
        showOrder.FullRowSelect = True
        showOrder.Columns.Add("Product Name", 100, HorizontalAlignment.Left)
        showOrder.Columns.Add("Restriction", 100, HorizontalAlignment.Left)
        showOrder.Columns.Add("Quantity", 50, HorizontalAlignment.Left)
        showOrder.Columns.Add("Total Price", 100, HorizontalAlignment.Left)
        Try
            MainMenuForm.conn.Open()
            InvoiceList.Items.Clear()
            Dim query = "SELECT i.invoice_id, c.client_type, b.branch_name AS branch, s.shopkeeper_name AS shopkeeper, p.pharmasist_name AS pharmasist FROM invoice AS i, client AS c, branch AS b, shopkeeper AS s, pharmasist AS p WHERE i.client_id = c.client_id AND i.branch_id = b.branch_id AND i.shopkeeper_id = s.shopkeeper_id AND i.pharmasist_id = p.pharmasist_id ORDER BY invoice_id ASC"
            'SELECT i.invoice_id, c.client_type, b.branch_name AS branch, s.shopkeeper_name AS shopkeeper, p.pharmasist_name AS pharmasist FROM invoice AS i, client AS c, branch AS b, shopkeeper AS s, pharmasist AS p WHERE i.client_id = c.client_id AND i.branch_id = b.branch_id AND i.shopkeeper_id = s.shopkeeper_id AND i.pharmasist_id = p.pharmasist_id
            comm = New MySqlCommand(query, MainMenuForm.conn)
            reader = comm.ExecuteReader

            If reader.HasRows Then
                While reader.Read()
                    inf(0) = reader.Item("invoice_id")
                    inf(1) = reader.Item("client_type")
                    inf(2) = reader.Item("branch")
                    inf(3) = reader.Item("shopkeeper")
                    inf(4) = reader.Item("pharmasist")
                    info = New ListViewItem(inf)
                    InvoiceList.Items.Add(info)
                End While
            End If

            MainMenuForm.conn.Close()

            'Load Client Type, Branch and Shopkeeper, Pharmasist

            Try
                'Load Client Type
                MainMenuForm.conn.Open()
                query = "SELECT client_type FROM client"

                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        Dim temp As String
                        temp = reader.Item("client_type")

                        ClientBox.Items.Add(temp)
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

                'Load Shopkeeper
                MainMenuForm.conn.Open()
                query = "SELECT shopkeeper_name FROM shopkeeper"

                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        Dim temp As String
                        temp = reader.Item("shopkeeper_name")

                        ShopkeeperBox.Items.Add(temp)
                    End While
                End If
                MainMenuForm.conn.Close()

                'Load Pharmasist
                MainMenuForm.conn.Open()
                query = "SELECT pharmasist_name FROM pharmasist"

                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        Dim temp As String
                        temp = reader.Item("pharmasist_name")

                        PharmasistBox.Items.Add(temp)
                    End While
                End If
                MainMenuForm.conn.Close()
            Catch ex As Exception
                MainMenuForm.conn.Close()
                MessageBox.Show("ERROR  :" + ex.Message)
            End Try
        Catch ex As Exception
            MainMenuForm.conn.Close()
            MessageBox.Show("ERROR  :" + ex.Message)
        End Try
    End Sub
End Class