Imports MySql.Data.MySqlClient

Public Class ShopkeeperForm
    Dim str, query As String
    Dim comm As MySqlCommand
    Dim reader As MySqlDataReader
    Dim inf(9) As String
    Dim info As ListViewItem

    Private Sub CloseForm(sender As Object, e As EventArgs) Handles Me.FormClosing
        MainMenuForm.Show()
    End Sub

    Private Sub AgeBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AgeBox.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub PhoneBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PhoneBox.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub DisableShopkeeperButton_Click(sender As Object, e As EventArgs) Handles DisableShopkeeperButton.Click
        Try
            If ShopkeeperList.SelectedIndices.Count <= 0 Then
                MessageBox.Show("No shopkeeper is selected!")
                Return
            Else
                'Disable Entry
                MainMenuForm.conn.Open()

                Dim item As ListViewItem
                item = ShopkeeperList.SelectedItems(0)

                Dim query = "UPDATE shopkeeper SET isactive = 0 WHERE shopkeeper_id=" + item.SubItems(0).Text
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                MainMenuForm.conn.Close()

                'Refresh Database

                MainMenuForm.conn.Open()
                ShopkeeperList.Items.Clear()
                query = "SELECT s.shopkeeper_id, b.branch_name AS branch, s.shopkeeper_name AS name, s.gender, s.age, s.phone, s.comment, s.isactive, s.admin_permission FROM shopkeeper AS s, branch AS b WHERE s.branch_id = b.branch_id ORDER BY shopkeeper_id ASC"
                'SELECT s.shopkeeper_id, b.branch_name AS branch, s.shopkeeper_name AS name, s.gender, s.age, s.phone, s.comment, s.isactive, s.admin_permission FROM shopkeeper AS s, branch AS b WHERE s.branch_id = b.branch_id
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        inf(0) = reader.Item("shopkeeper_id")
                        inf(1) = reader.Item("branch")
                        inf(2) = reader.Item("name")
                        inf(3) = reader.Item("gender")
                        inf(4) = reader.Item("age")
                        inf(5) = reader.Item("phone")
                        inf(6) = reader.Item("comment")
                        inf(7) = reader.Item("isactive")
                        inf(8) = reader.Item("admin_permission")
                        info = New ListViewItem(inf)
                        ShopkeeperList.Items.Add(info)
                    End While
                End If

                MainMenuForm.conn.Close()
            End If

        Catch ex As Exception
            MainMenuForm.conn.Close()
            MessageBox.Show("ERROR  :" + ex.Message)
        End Try
    End Sub

    Private Sub EnableShopkeeperButton_Click(sender As Object, e As EventArgs) Handles EnableShopkeeperButton.Click
        Try
            If ShopkeeperList.SelectedIndices.Count <= 0 Then
                MessageBox.Show("No shopkeeper is selected!")
                Return
            Else
                'Disable Entry
                MainMenuForm.conn.Open()

                Dim item As ListViewItem
                item = ShopkeeperList.SelectedItems(0)

                Dim query = "UPDATE shopkeeper SET isactive = 1 WHERE shopkeeper_id=" + item.SubItems(0).Text
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                MainMenuForm.conn.Close()

                'Refresh Database

                MainMenuForm.conn.Open()
                ShopkeeperList.Items.Clear()
                query = "SELECT s.shopkeeper_id, b.branch_name AS branch, s.shopkeeper_name AS name, s.gender, s.age, s.phone, s.comment, s.isactive, s.admin_permission FROM shopkeeper AS s, branch AS b WHERE s.branch_id = b.branch_id ORDER BY shopkeeper_id ASC"
                'SELECT s.shopkeeper_id, b.branch_name AS branch, s.shopkeeper_name AS name, s.gender, s.age, s.phone, s.comment, s.isactive, s.admin_permission FROM shopkeeper AS s, branch AS b WHERE s.branch_id = b.branch_id
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        inf(0) = reader.Item("shopkeeper_id")
                        inf(1) = reader.Item("branch")
                        inf(2) = reader.Item("name")
                        inf(3) = reader.Item("gender")
                        inf(4) = reader.Item("age")
                        inf(5) = reader.Item("phone")
                        inf(6) = reader.Item("comment")
                        inf(7) = reader.Item("isactive")
                        inf(8) = reader.Item("admin_permission")
                        info = New ListViewItem(inf)
                        ShopkeeperList.Items.Add(info)
                    End While
                End If

                MainMenuForm.conn.Close()
            End If

        Catch ex As Exception
            MainMenuForm.conn.Close()
            MessageBox.Show("ERROR  :" + ex.Message)
        End Try
    End Sub

    Private Sub DeleteShopkeeperButton_Click(sender As Object, e As EventArgs) Handles DeleteShopkeeperButton.Click
        Try
            If ShopkeeperList.SelectedIndices.Count <= 0 Then
                MessageBox.Show("No shopkeeper is selected!")
                Return
            Else
                'Update Database
                MainMenuForm.conn.Open()
                Dim item As ListViewItem
                item = ShopkeeperList.SelectedItems(0)

                Dim query = "DELETE FROM shopkeeper WHERE shopkeeper_id=" + item.SubItems(0).Text + " AND admin_permission=0"
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader
                MainMenuForm.conn.Close()

                MessageBox.Show("Shopkeeper has been successfully deleted!")

                'Refresh Table
                MainMenuForm.conn.Open()
                ShopkeeperList.Items.Clear()
                query = "SELECT s.shopkeeper_id, b.branch_name AS branch, s.shopkeeper_name AS name, s.gender, s.age, s.phone, s.comment, s.isactive, s.admin_permission FROM shopkeeper AS s, branch AS b WHERE s.branch_id = b.branch_id ORDER BY shopkeeper_id ASC"
                'SELECT s.shopkeeper_id, b.branch_name AS branch, s.shopkeeper_name AS name, s.gender, s.age, s.phone, s.comment, s.isactive, s.admin_permission FROM shopkeeper AS s, branch AS b WHERE s.branch_id = b.branch_id
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        inf(0) = reader.Item("shopkeeper_id")
                        inf(1) = reader.Item("branch")
                        inf(2) = reader.Item("name")
                        inf(3) = reader.Item("gender")
                        inf(4) = reader.Item("age")
                        inf(5) = reader.Item("phone")
                        inf(6) = reader.Item("comment")
                        inf(7) = reader.Item("isactive")
                        inf(8) = reader.Item("admin_permission")
                        info = New ListViewItem(inf)
                        ShopkeeperList.Items.Add(info)
                    End While
                End If

                MainMenuForm.conn.Close()
            End If

        Catch ex As Exception
            MainMenuForm.conn.Close()
            MessageBox.Show("ERROR  :" + ex.Message)
        End Try
    End Sub

    Private Sub AddShopkeeperButton_Click(sender As Object, e As EventArgs) Handles AddShopkeeperButton.Click
        Try
            If NameBox.Text = "" Or PasswordBox.Text = "" Or AgeBox.Text = "" Or GenderBox.Text = "" Or BranchBox.Text = "" Then
                MessageBox.Show("Name, Password, Age, Gender and Branch requires to be filled!")
                Return
            Else
                MainMenuForm.conn.Open()
                Dim query = "INSERT INTO shopkeeper (branch_id, shopkeeper_name, hashed_password, gender, age, phone, comment) " +
                            "SELECT b.branch_id, '" + NameBox.Text + "', PASSWORD('" + PasswordBox.Text + "'), '" + GenderBox.Text + "', " + AgeBox.Text + ", '" + PhoneBox.Text + "', '" + CommentBox.Text + "' " +
                            "FROM branch AS b WHERE b.branch_name = '" + BranchBox.Text + "'"
                System.Console.WriteLine(query)
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                MainMenuForm.conn.Close()

                MessageBox.Show("Shopkeeper has been successfully added!")

                'Refresh Database

                MainMenuForm.conn.Open()
                ShopkeeperList.Items.Clear()
                query = "SELECT s.shopkeeper_id, b.branch_name AS branch, s.shopkeeper_name AS name, s.gender, s.age, s.phone, s.comment, s.isactive, s.admin_permission FROM shopkeeper AS s, branch AS b WHERE s.branch_id = b.branch_id ORDER BY shopkeeper_id ASC"
                'SELECT s.shopkeeper_id, b.branch_name AS branch, s.shopkeeper_name AS name, s.gender, s.age, s.phone, s.comment, s.isactive, s.admin_permission FROM shopkeeper AS s, branch AS b WHERE s.branch_id = b.branch_id
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        inf(0) = reader.Item("shopkeeper_id")
                        inf(1) = reader.Item("branch")
                        inf(2) = reader.Item("name")
                        inf(3) = reader.Item("gender")
                        inf(4) = reader.Item("age")
                        inf(5) = reader.Item("phone")
                        inf(6) = reader.Item("comment")
                        inf(7) = reader.Item("isactive")
                        inf(8) = reader.Item("admin_permission")
                        info = New ListViewItem(inf)
                        ShopkeeperList.Items.Add(info)
                    End While
                End If

                MainMenuForm.conn.Close()
            End If
        Catch ex As Exception
            MainMenuForm.conn.Close()
            MessageBox.Show("ERROR  :" + ex.Message)
        End Try
    End Sub

    Private Sub UpdateShopkeeperButton_Click(sender As Object, e As EventArgs) Handles UpdateShopkeeperButton.Click
        Try
            If ShopkeeperList.SelectedIndices.Count <= 0 Then
                MessageBox.Show("No shopkeeper is selected!")
                Return
            ElseIf NameBox.Text = "" Or PasswordBox.Text = "" Or AgeBox.Text = "" Or GenderBox.Text = "" Or BranchBox.Text = "" Then
                MessageBox.Show("Name, Password, Age, Gender and Branch requires to be filled!")
                Return
            Else
                'Update Database
                MainMenuForm.conn.Open()

                Dim item As ListViewItem
                item = ShopkeeperList.SelectedItems(0)

                Dim query = "UPDATE shopkeeper " +
                "SET branch_id=(SELECT bra.branch_id FROM branch AS bra WHERE bra.branch_name = '" + BranchBox.Text + "'), " +
                "shopkeeper_name='" + NameBox.Text + "', hashed_password=PASSWORD('" + PasswordBox.Text + "'), Gender='" + GenderBox.Text + "', age=" + AgeBox.Text + ", phone='" + PhoneBox.Text + "', comment='" + CommentBox.Text + "' " +
                "WHERE shopkeeper_id=" + item.SubItems(0).Text

                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                MainMenuForm.conn.Close()
                MessageBox.Show("Shopkeeper info has been successfully updated!")

                'Refresh Database

                MainMenuForm.conn.Open()
                ShopkeeperList.Items.Clear()
                query = "SELECT s.shopkeeper_id, b.branch_name AS branch, s.shopkeeper_name AS name, s.gender, s.age, s.phone, s.comment, s.isactive, s.admin_permission FROM shopkeeper AS s, branch AS b WHERE s.branch_id = b.branch_id ORDER BY shopkeeper_id ASC"
                'SELECT s.shopkeeper_id, b.branch_name AS branch, s.shopkeeper_name AS name, s.gender, s.age, s.phone, s.comment, s.isactive, s.admin_permission FROM shopkeeper AS s, branch AS b WHERE s.branch_id = b.branch_id
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        inf(0) = reader.Item("shopkeeper_id")
                        inf(1) = reader.Item("branch")
                        inf(2) = reader.Item("name")
                        inf(3) = reader.Item("gender")
                        inf(4) = reader.Item("age")
                        inf(5) = reader.Item("phone")
                        inf(6) = reader.Item("comment")
                        inf(7) = reader.Item("isactive")
                        inf(8) = reader.Item("admin_permission")
                        info = New ListViewItem(inf)
                        ShopkeeperList.Items.Add(info)
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
        ShopkeeperList.View = View.Details
        ShopkeeperList.FullRowSelect = True
        'ProductList.Columns.Add("Product ID", 100, HorizontalAlignment.Left)
        ShopkeeperList.Columns.Add("Shopkeeper ID", 100, HorizontalAlignment.Left)
        ShopkeeperList.Columns.Add("Branch", 50, HorizontalAlignment.Left)
        ShopkeeperList.Columns.Add("Name", 75, HorizontalAlignment.Left)
        ShopkeeperList.Columns.Add("Gender", 50, HorizontalAlignment.Left)
        ShopkeeperList.Columns.Add("Age", 50, HorizontalAlignment.Left)
        ShopkeeperList.Columns.Add("Phone", 75, HorizontalAlignment.Left)
        ShopkeeperList.Columns.Add("Comment", 75, HorizontalAlignment.Left)
        ShopkeeperList.Columns.Add("Active", 75, HorizontalAlignment.Left)
        ShopkeeperList.Columns.Add("Admin Permission", 100, HorizontalAlignment.Left)
        'ProductList.Columns.Add("Is On Market", 50, HorizontalAlignment.Left)

        Try
            MainMenuForm.conn.Open()
            ShopkeeperList.Items.Clear()
            Dim query = "SELECT s.shopkeeper_id, b.branch_name AS branch, s.shopkeeper_name AS name, s.gender, s.age, s.phone, s.comment, s.isactive, s.admin_permission FROM shopkeeper AS s, branch AS b WHERE s.branch_id = b.branch_id ORDER BY shopkeeper_id ASC"
            'SELECT s.shopkeeper_id, b.branch_name AS branch, s.shopkeeper_name AS name, s.gender, s.age, s.phone, s.comment, s.isactive, s.admin_permission FROM shopkeeper AS s, branch AS b WHERE s.branch_id = b.branch_id
            comm = New MySqlCommand(query, MainMenuForm.conn)
            reader = comm.ExecuteReader

            If reader.HasRows Then
                While reader.Read()
                    inf(0) = reader.Item("shopkeeper_id")
                    inf(1) = reader.Item("branch")
                    inf(2) = reader.Item("name")
                    inf(3) = reader.Item("gender")
                    inf(4) = reader.Item("age")
                    inf(5) = reader.Item("phone")
                    inf(6) = reader.Item("comment")
                    inf(7) = reader.Item("isactive")
                    inf(8) = reader.Item("admin_permission")
                    info = New ListViewItem(inf)
                    ShopkeeperList.Items.Add(info)
                End While
            End If

            MainMenuForm.conn.Close()
        Catch ex As Exception
            MainMenuForm.conn.Close()
            MessageBox.Show("ERROR  :" + ex.Message)
        End Try

        'Load Branch

        Try
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
        Catch ex As Exception
            MainMenuForm.conn.Close()
            MessageBox.Show("ERROR  :" + ex.Message)
        End Try
    End Sub
End Class