Imports MySql.Data.MySqlClient

Public Class Form1
    Dim strconnect As String
    Dim conn As MySqlConnection
    Dim reader As MySqlDataReader
    Dim query As String
    Dim prodinf(6) As String
    Dim invcoll(4) As String
    Dim incart(4) As String
    Dim secphase As ListViewItem
    Dim comm As MySqlCommand
    Dim mode As Int16
    Dim islogin As Boolean
    Dim nextIndex As Integer
    Dim cartcount As Integer
    Dim addnew As Boolean
    Dim user As String
    Dim level As Integer
    Dim branchiden As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addnew = True
        If IsNumeric(TextBox1.Text) And ListView1.SelectedItems.Count > 0 Then
            For objectnavigate As Integer = 0 To cartcount - 1
                If ListView2.Items(objectnavigate).Text = ListView1.SelectedItems(0).Text Then
                    addnew = False
                    If Convert.ToUInt32(ListView1.SelectedItems(0).SubItems(5).Text) >= (Convert.ToInt32(ListView2.Items(objectnavigate).SubItems(1).Text) + Convert.ToInt32(TextBox1.Text)) Then
                        ListView2.Items(objectnavigate).SubItems(1).Text = Convert.ToInt32(ListView2.Items(objectnavigate).SubItems(1).Text) + Convert.ToInt32(TextBox1.Text)
                        ListView2.Items(objectnavigate).SubItems(3).Text = Convert.ToInt32(ListView2.Items(objectnavigate).SubItems(1).Text) * Convert.ToInt32(ListView1.SelectedItems(0).SubItems(4).Text)
                        TotalPrice.Text = Convert.ToInt32(TotalPrice.Text) + (Convert.ToInt32(TextBox1.Text) * Convert.ToInt32(ListView1.SelectedItems(0).SubItems(4).Text))
                    End If
                    Exit For
                End If
            Next
            If addnew And Convert.ToUInt32(ListView1.SelectedItems(0).SubItems(5).Text) >= Convert.ToUInt32(TextBox1.Text) Then
                incart(0) = ListView1.SelectedItems(0).Text
                incart(1) = TextBox1.Text
                incart(2) = ListView1.SelectedItems(0).SubItems(3).Text
                incart(3) = Convert.ToInt32(ListView1.SelectedItems(0).SubItems(4).Text) * Convert.ToInt32(TextBox1.Text)
                TotalPrice.Text = Convert.ToInt32(TotalPrice.Text) + Convert.ToInt32(incart(3))
                secphase = New ListViewItem(incart)
                ListView2.Items.Add(secphase)
                cartcount += 1
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListView2.SelectedItems.Count > 0 Then
            TotalPrice.Text = Convert.ToInt32(TotalPrice.Text) - Convert.ToInt32(ListView2.SelectedItems(0).SubItems(3).Text)
            ListView2.Items.Remove(ListView2.SelectedItems(0))
            cartcount -= 1
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        out.Hide()
        phar.Hide()
        cltype.Hide()
        log.Show()
        pass.Show()
        islogin = False
        ListView1.Hide()
        ListView2.Hide()
        TextBox1.Hide()
        TextBox4.Hide()
        Label1.Hide()
        Currency.Hide()
        TotalPrice.Hide()
        Button1.Hide()
        Button2.Hide()
        Button3.Hide()
        Button4.Hide()
        Button5.Hide()
        Button6.Hide()
        InvoiceCheck.Hide()
        ComboBox1.Hide()
        ComboBox2.Hide()
        ComboBox4.Hide()
        ComboBox4.Items.Add("Product Name")
        ComboBox4.Items.Add("Category Name")
        ComboBox4.Items.Add("Subcategory Name")
        ComboBox4.SelectedIndex = 0
        ComboBox5.Hide()
        ComboBox5.Items.Add("Invoice ID")
        ComboBox5.Items.Add("Shop Keeper")
        ComboBox5.Items.Add("Pharmacist")
        ComboBox5.SelectedIndex = 0
        strconnect = "Server = localhost; user id = root; password = ; database = pharmashop; SslMode = none"
        conn = New MySqlConnection(strconnect)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.hideInvoice()
        Me.showForCart()
        Me.showProduct()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.hideCart()
        Me.showForInvoice()
        Me.showInvoices()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If mode = 1 And ComboBox4.SelectedIndex = 0 Then
            query = "SELECT product_name, category_name, subcategory_name, restriction_level, product_price, product_quantity FROM (((product inner join subcategory on product.subcategory_id = subcategory.subcategory_id) inner join category on subcategory.category_id = category.category_id) inner join restriction on product.restriction_id=restriction.restriction_id) WHERE isonmarket=1 and branch_id=" + branchiden.ToString() + " and product_name like '%" + TextBox4.Text + "%';"
        ElseIf mode = 1 And ComboBox4.SelectedIndex = 1 Then
            query = "SELECT product_name, category_name, subcategory_name, restriction_level, product_price, product_quantity FROM (((product inner join subcategory on product.subcategory_id = subcategory.subcategory_id) inner join category on subcategory.category_id = category.category_id) inner join restriction on product.restriction_id=restriction.restriction_id) WHERE isonmarket=1 and branch_id=" + branchiden.ToString() + " and category_name like '%" + TextBox4.Text + "%';"
        ElseIf mode = 1 And ComboBox4.SelectedIndex = 2 Then
            query = "SELECT product_name, category_name, subcategory_name, restriction_level, product_price, product_quantity FROM (((product inner join subcategory on product.subcategory_id = subcategory.subcategory_id) inner join category on subcategory.category_id = category.category_id) inner join restriction on product.restriction_id=restriction.restriction_id) WHERE isonmarket=1 and branch_id=" + branchiden.ToString() + " and subcategory_name like '%" + TextBox4.Text + "%';"
        ElseIf mode = 2 And ComboBox5.SelectedIndex = 0 Then
            query = "SELECT invoice_id,branch_name as branchidf, shopkeeper_name, pharmasist_name from (((invoice inner join shopkeeper on invoice.shopkeeper_id = shopkeeper.shopkeeper_id) inner join pharmasist on invoice.pharmasist_id = pharmasist.pharmasist_id)inner join branch on invoice.branch_id=branch.branch_id) where invoice_id like '%" + TextBox4.Text + "%'"
        ElseIf mode = 2 And ComboBox5.SelectedIndex = 1 Then
            query = "SELECT invoice_id,branch_name as branchidf, shopkeeper_name, pharmasist_name from (((invoice inner join shopkeeper on invoice.shopkeeper_id = shopkeeper.shopkeeper_id) inner join pharmasist on invoice.pharmasist_id = pharmasist.pharmasist_id)inner join branch on invoice.branch_id=branch.branch_id) where shopkeeper_name like '%" + TextBox4.Text + "%'"
        ElseIf mode = 2 And ComboBox5.SelectedIndex = 2 Then
            query = "SELECT invoice_id,branch_name as branchidf, shopkeeper_name, pharmasist_name from (((invoice inner join shopkeeper on invoice.shopkeeper_id = shopkeeper.shopkeeper_id) inner join pharmasist on invoice.pharmasist_id = pharmasist.pharmasist_id)inner join branch on invoice.branch_id=branch.branch_id) where pharmasist_name like '%" + TextBox4.Text + "%'"
        End If
        Try
            conn.Open()
            ListView1.Items.Clear()
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader
            If reader.HasRows Then
                While reader.Read()
                    If (mode = 1) Then
                        prodinf(0) = reader.Item("product_name")
                        prodinf(1) = reader.Item("category_name")
                        prodinf(2) = reader.Item("subcategory_name")
                        prodinf(3) = reader.Item("restriction_level")
                        prodinf(4) = reader.Item("product_price")
                        prodinf(5) = reader.Item("product_quantity")
                        secphase = New ListViewItem(prodinf)
                        ListView1.Items.Add(secphase)
                    ElseIf (mode = 2) Then
                        invcoll(0) = reader.Item("invoice_id")
                        invcoll(1) = reader.Item("branchidf")
                        invcoll(2) = reader.Item("shopkeeper_name")
                        invcoll(3) = reader.Item("pharmasist_name")
                        secphase = New ListViewItem(invcoll)
                        ListView1.Items.Add(secphase)
                    End If
                End While

            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("ERROR  :" + ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
    Private Sub showForCart()

        mode = 1
        ListView1.Clear()
        ListView1.View = View.Details
        ListView1.Columns.Add("Product Name", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Category", 60, HorizontalAlignment.Left)
        ListView1.Columns.Add("Sub Category", 60, HorizontalAlignment.Left)
        ListView1.Columns.Add("Restriction Level", 25, HorizontalAlignment.Left)
        ListView1.Columns.Add("Price", 50, HorizontalAlignment.Left)
        ListView1.Columns.Add("Stock", 30, HorizontalAlignment.Left)
        ListView2.Clear()
        ListView2.View = View.Details
        ListView2.Columns.Add("Product Name", 100, HorizontalAlignment.Left)
        ListView2.Columns.Add("Quantity", 50, HorizontalAlignment.Left)
        ListView2.Columns.Add("Restriction", 25, HorizontalAlignment.Left)
        ListView2.Columns.Add("Total Price", 50, HorizontalAlignment.Left)
        TextBox1.Show()
        Label1.Show()
        Currency.Show()
        TotalPrice.Show()
        cltype.Show()
        phar.Show()
        Button1.Show()
        Button2.Show()
        Button3.Show()
        ComboBox1.Show()
        ComboBox1.SelectedIndex = 0
        ComboBox2.Show()
        ComboBox2.SelectedIndex = 0
        ComboBox4.Show()
        ComboBox4.SelectedIndex = 0
        cartcount = 0
        TotalPrice.Text = "0"
    End Sub
    Private Sub hideCart()
        mode = 0
        ListView1.Clear()
        ListView2.Clear()
        TextBox1.Hide()
        Label1.Hide()
        Currency.Hide()
        TotalPrice.Hide()
        cltype.Hide()
        phar.Hide()
        Button1.Hide()
        Button2.Hide()
        Button3.Hide()
        ComboBox1.Hide()
        ComboBox1.SelectedIndex = 0
        ComboBox2.Hide()
        ComboBox2.SelectedIndex = 0
        ComboBox4.Hide()
        ComboBox4.SelectedIndex = 0
        cartcount = 0
        TotalPrice.Text = "0"
    End Sub
    Private Sub showBasic()
        ListView1.Show()
        ListView2.Show()
        TextBox4.Show()
        Button4.Show()
        Button5.Show()
        Button6.Show()
        out.Show()
    End Sub
    Private Sub hideBasic()
        ListView1.Hide()
        ListView2.Hide()
        TextBox4.Hide()
        Button4.Hide()
        Button5.Hide()
        Button6.Hide()
        out.Hide()
    End Sub
    Private Sub showForInvoice()
        mode = 2
        ListView1.Clear()
        ListView1.View = View.Details
        ListView1.Columns.Add("Invoice ID", 50, HorizontalAlignment.Left)
        ListView1.Columns.Add("Branch ID", 50, HorizontalAlignment.Left)
        ListView1.Columns.Add("Shop Keeper", 60, HorizontalAlignment.Left)
        ListView1.Columns.Add("Pharmacist", 60, HorizontalAlignment.Left)
        ListView2.Clear()
        ListView2.View = View.Details
        ListView2.Columns.Add("Product Name", 100, HorizontalAlignment.Left)
        ListView2.Columns.Add("Quantity", 50, HorizontalAlignment.Left)
        ListView2.Columns.Add("Restriction", 25, HorizontalAlignment.Left)
        ListView2.Columns.Add("Total Price", 50, HorizontalAlignment.Left)
        InvoiceCheck.Show()
        ComboBox5.Show()
        ComboBox5.SelectedIndex = 0
        Currency.Show()
        Label1.Show()
        TotalPrice.Show()
        TotalPrice.Text = "0"
    End Sub
    Private Sub hideInvoice()
        mode = 0
        ListView1.Clear()
        ListView2.Clear()
        InvoiceCheck.Hide()
        ComboBox5.Hide()
        ComboBox5.SelectedIndex = 0
        Currency.Hide()
        Label1.Hide()
        TotalPrice.Hide()
        TotalPrice.Text = "0"
    End Sub
    Private Sub showProduct()
        Try
            conn.Open()
            ListView1.Items.Clear()
            query = "SELECT product_name, category_name, subcategory_name, restriction_level, product_price, product_quantity FROM (((product inner join subcategory on product.subcategory_id = subcategory.subcategory_id) inner join category on subcategory.category_id = category.category_id) inner join restriction on product.restriction_id=restriction.restriction_id) WHERE isonmarket=1 AND branch_id=" + branchiden.ToString() + ";"
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader
            If reader.HasRows Then
                While reader.Read()
                    prodinf(0) = reader.Item("product_name")
                    prodinf(1) = reader.Item("category_name")
                    prodinf(2) = reader.Item("subcategory_name")
                    prodinf(3) = reader.Item("restriction_level")
                    prodinf(4) = reader.Item("product_price")
                    prodinf(5) = reader.Item("product_quantity")
                    secphase = New ListViewItem(prodinf)
                    ListView1.Items.Add(secphase)
                End While
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("ERROR  :" + ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub showInvoices()
        Try
            conn.Open()
            ListView1.Items.Clear()
            query = "SELECT invoice_id, branch_name as branchidf, shopkeeper_name, pharmasist_name from (((invoice inner join shopkeeper on invoice.shopkeeper_id = shopkeeper.shopkeeper_id) inner join pharmasist on invoice.pharmasist_id = pharmasist.pharmasist_id)inner join branch on invoice.branch_id=branch.branch_id)"
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader
            If reader.HasRows Then
                While reader.Read()
                    invcoll(0) = reader.Item("invoice_id")
                    invcoll(1) = reader.Item("branchidf")
                    invcoll(2) = reader.Item("shopkeeper_name")
                    invcoll(3) = reader.Item("pharmasist_name")
                    secphase = New ListViewItem(invcoll)
                    ListView1.Items.Add(secphase)
                End While
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("ERROR  :" + ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub showName()
        name1.Show()
        name2.Show()
        name3.Show()
    End Sub
    Private Sub hideName()
        name1.Hide()
        name2.Hide()
        name3.Hide()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            conn.Open()
            query = "SELECT * FROM shopkeeper WHERE shopkeeper_name='" + TextBox2.Text + "' AND hashed_password = PASSWORD('" + TextBox3.Text + "') AND isactive = 1;"
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader
            If reader.HasRows Then
                If reader.Read() Then
                    user = reader.Item("shopkeeper_name")
                    branchiden = Convert.ToInt32(reader.Item("branch_id"))
                    user = user.ToLower()
                End If
                islogin = True
                TextBox2.Hide()
                TextBox3.Hide()
                Button7.Hide()
            End If
            conn.Close()

            If islogin Then
                log.Hide()
                pass.Hide()
                conn.Open()
                query = "SELECT * FROM invoice;"
                comm = New MySqlCommand(query, conn)
                reader = comm.ExecuteReader
                If reader.HasRows Then
                    While reader.Read()
                        nextIndex = Convert.ToInt32(reader.Item("invoice_id"))
                    End While
                End If
                nextIndex += 1
                conn.Close()
                conn.Open()
                query = "SELECT client_type FROM client;"
                comm = New MySqlCommand(query, conn)
                reader = comm.ExecuteReader
                If reader.HasRows Then
                    While reader.Read()
                        ComboBox1.Items.Add(reader.Item("client_type"))
                    End While
                End If
                conn.Close()
                conn.Open()
                query = "SELECT pharmasist_name FROM pharmasist WHERE branch_id=" + branchiden.ToString() + ";"
                comm = New MySqlCommand(query, conn)
                reader = comm.ExecuteReader
                If reader.HasRows Then
                    While reader.Read()
                        ComboBox2.Items.Add(reader.Item("pharmasist_name"))
                    End While
                End If
                conn.Close()
                Me.hideName()
                Me.showBasic()
                mode = 1
                Me.showForCart()
                Me.showProduct()
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR  :" + ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged

    End Sub

    Private Sub TotalPrice_Click(sender As Object, e As EventArgs) Handles TotalPrice.Click

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            addnew = True
            conn.Open()
            query = "SELECT client_id FROM client WHERE client_type = '" + ComboBox1.SelectedItem.ToString + "';"
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader
            If reader.HasRows Then
                If reader.Read() Then
                    level = Convert.ToInt16(reader.Item("client_id"))
                End If
            End If
            conn.Close()
            For objectnavigate As Integer = 0 To cartcount - 1
                If level < Convert.ToInt16(ListView2.Items(objectnavigate).SubItems(2).Text) Then
                    addnew = False
                    Exit For
                End If
            Next
            If addnew And cartcount > 0 Then
                conn.Open()
                query = "INSERT INTO invoice VALUES(" + nextIndex.ToString() + ",(select client_id from client where client_type='" + ComboBox1.SelectedItem.ToString() + "'), " + branchiden.ToString() + ",(select shopkeeper_id from shopkeeper where shopkeeper_name='" + user + "'),(select pharmasist_id from pharmasist where pharmasist_name='" + ComboBox2.SelectedItem.ToString() + "'));"
                comm = New MySqlCommand(query, conn)
                reader = comm.ExecuteReader
                conn.Close()
                For objectnavigate As Integer = 0 To cartcount - 1
                    conn.Open()
                    query = "INSERT INTO cart VALUES((select invoice_id from invoice where invoice_id=" + nextIndex.ToString() + "),(select product_id from product where product_name='" + ListView2.Items(objectnavigate).Text + "' AND branch_id = " + branchiden.ToString() + ")," + ListView2.Items(objectnavigate).SubItems(1).Text + ");"
                    comm = New MySqlCommand(query, conn)
                    reader = comm.ExecuteReader
                    conn.Close()
                    conn.Open()
                    query = "UPDATE product SET product_quantity=product_quantity-" + ListView2.Items(objectnavigate).SubItems(1).Text + " where product_name = '" + ListView2.Items(objectnavigate).Text + "' AND branch_id=" + branchiden.ToString() + ";"
                    comm = New MySqlCommand(query, conn)
                    reader = comm.ExecuteReader
                    conn.Close()
                Next
                nextIndex += 1
                ListView2.Items.Clear()
                Me.showProduct()
                MessageBox.Show("Success")
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR  :" + ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub InvoiceCheck_Click(sender As Object, e As EventArgs) Handles InvoiceCheck.Click
        If ListView1.SelectedItems.Count > 0 Then
            Try
                conn.Open()
                ListView2.Items.Clear()
                query = "SELECT product_name, ordered_quantity, restriction_level, (ordered_quantity*product_price)as total_price FROM ((cart inner join product on cart.product_id = product.product_id) inner join restriction on product.restriction_id=restriction.restriction_id) WHERE invoice_id=" + ListView1.SelectedItems(0).Text + ";"
                comm = New MySqlCommand(query, conn)
                reader = comm.ExecuteReader
                If reader.HasRows Then
                    While reader.Read
                        incart(0) = reader.Item("product_name")
                        incart(1) = reader.Item("ordered_quantity")
                        incart(2) = reader.Item("restriction_level")
                        incart(3) = reader.Item("total_price")
                        TotalPrice.Text = Convert.ToInt32(TotalPrice.Text) + Convert.ToInt32(incart(3))
                        secphase = New ListViewItem(incart)
                        ListView2.Items.Add(secphase)
                    End While
                End If
                conn.Close()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub log_Click(sender As Object, e As EventArgs) Handles log.Click

    End Sub

    Private Sub phar_Click(sender As Object, e As EventArgs) Handles phar.Click

    End Sub

    Private Sub cltype_Click(sender As Object, e As EventArgs) Handles cltype.Click

    End Sub

    Private Sub out_Click(sender As Object, e As EventArgs) Handles out.Click
        mode = 0
        Me.hideCart()
        Me.hideInvoice()
        Me.hideBasic()
        Me.ComboBox1.Items.Clear()
        Me.ComboBox2.Items.Clear()
        islogin = False
        log.Show()
        pass.Show()
        TextBox2.Show()
        TextBox2.Text = ""
        TextBox3.Show()
        TextBox3.Text = ""
        Button7.Show()
        Me.showName()

    End Sub

    Private Sub name2_Click(sender As Object, e As EventArgs) Handles name2.Click

    End Sub

    Private Sub name1_Click(sender As Object, e As EventArgs) Handles name1.Click

    End Sub

    Private Sub name3_Click(sender As Object, e As EventArgs) Handles name3.Click

    End Sub

End Class
