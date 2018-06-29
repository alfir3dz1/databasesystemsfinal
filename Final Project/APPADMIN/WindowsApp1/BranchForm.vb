Imports MySql.Data.MySqlClient

Public Class BranchForm
    Dim str, query As String
    Dim comm As MySqlCommand
    Dim reader As MySqlDataReader
    Dim prodinf(4) As String
    Dim info As ListViewItem

    Private Sub CloseForm(sender As Object, e As EventArgs) Handles Me.FormClosing
        MainMenuForm.Show()
    End Sub

    Private Sub EnableBranchButton_Click(sender As Object, e As EventArgs) Handles EnableBranchButton.Click
        Try
            If BranchList.SelectedIndices.Count <= 0 Then
                MessageBox.Show("No branch is selected!")
                Return
            Else
                'Enable Entry
                MainMenuForm.conn.Open()

                Dim item As ListViewItem
                item = BranchList.SelectedItems(0)

                Dim query = "UPDATE branch SET isinoperation = 1 WHERE branch_id=" + item.SubItems(0).Text
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                MainMenuForm.conn.Close()

                'Enable Product related to Entry
                MainMenuForm.conn.Open()

                item = BranchList.SelectedItems(0)

                query = "UPDATE product SET isonmarket = 1 WHERE branch_id=" + item.SubItems(0).Text
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                MainMenuForm.conn.Close()

                'Enable Shopkeeper related to Entry
                MainMenuForm.conn.Open()

                item = BranchList.SelectedItems(0)

                query = "UPDATE shopkeeper SET isactive = 1 WHERE branch_id=" + item.SubItems(0).Text
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                MainMenuForm.conn.Close()

                'Enable Pharmasist related to Entry
                MainMenuForm.conn.Open()

                item = BranchList.SelectedItems(0)

                query = "UPDATE pharmasist SET isactive = 1 WHERE branch_id=" + item.SubItems(0).Text
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                MainMenuForm.conn.Close()

                'Refresh Database

                MainMenuForm.conn.Open()
                BranchList.Items.Clear()
                query = "SELECT b.branch_id, b.branch_name, s.shopkeeper_name, b.isinoperation FROM branch AS b, shopkeeper as s WHERE b.shopkeeper_id = s.shopkeeper_id"
                'SELECT b.branch_id, b.branch_name, s.shopkeeper_name, b.isinoperation FROM branch AS b, shopkeeper as s WHERE b.shopkeeper_id = s.shopkeeper_id

                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        prodinf(0) = reader.Item("branch_id")
                        prodinf(1) = reader.Item("branch_name")
                        prodinf(2) = reader.Item("shopkeeper_name")
                        prodinf(3) = reader.Item("isinoperation")
                        info = New ListViewItem(prodinf)
                        BranchList.Items.Add(info)
                    End While
                End If

                MainMenuForm.conn.Close()
            End If

        Catch ex As Exception
            MainMenuForm.conn.Close()
            MessageBox.Show("ERROR  :" + ex.Message)
        End Try
    End Sub

    Private Sub DisableBranchButton_Click(sender As Object, e As EventArgs) Handles DisableBranchButton.Click
        Try
            If BranchList.SelectedIndices.Count <= 0 Then
                MessageBox.Show("No branch is selected!")
                Return
            Else
                'Disable Entry
                MainMenuForm.conn.Open()

                Dim item As ListViewItem
                item = BranchList.SelectedItems(0)

                Dim query = "UPDATE branch SET isinoperation = 0 WHERE branch_id=" + item.SubItems(0).Text
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                MainMenuForm.conn.Close()

                'Disable Product related to Entry
                MainMenuForm.conn.Open()

                item = BranchList.SelectedItems(0)

                query = "UPDATE product SET isonmarket = 0 WHERE branch_id=" + item.SubItems(0).Text
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                MainMenuForm.conn.Close()

                'Disable Shopkeeper related to Entry
                MainMenuForm.conn.Open()

                item = BranchList.SelectedItems(0)

                query = "UPDATE shopkeeper SET isactive = 0 WHERE branch_id=" + item.SubItems(0).Text
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                MainMenuForm.conn.Close()

                'Disable Pharmasist related to Entry
                MainMenuForm.conn.Open()

                item = BranchList.SelectedItems(0)

                query = "UPDATE pharmasist SET isactive = 0 WHERE branch_id=" + item.SubItems(0).Text
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                MainMenuForm.conn.Close()

                'Refresh Database

                MainMenuForm.conn.Open()
                BranchList.Items.Clear()
                query = "SELECT b.branch_id, b.branch_name, s.shopkeeper_name, b.isinoperation FROM branch AS b, shopkeeper as s WHERE b.shopkeeper_id = s.shopkeeper_id"
                'SELECT b.branch_id, b.branch_name, s.shopkeeper_name, b.isinoperation FROM branch AS b, shopkeeper as s WHERE b.shopkeeper_id = s.shopkeeper_id

                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        prodinf(0) = reader.Item("branch_id")
                        prodinf(1) = reader.Item("branch_name")
                        prodinf(2) = reader.Item("shopkeeper_name")
                        prodinf(3) = reader.Item("isinoperation")
                        info = New ListViewItem(prodinf)
                        BranchList.Items.Add(info)
                    End While
                End If

                MainMenuForm.conn.Close()
            End If

        Catch ex As Exception
            MainMenuForm.conn.Close()
            MessageBox.Show("ERROR  :" + ex.Message)
        End Try
    End Sub

    Private Sub DeleteBranchButton_Click(sender As Object, e As EventArgs) Handles DeleteBranchButton.Click
        Try
            If BranchList.SelectedIndices.Count <= 0 Then
                MessageBox.Show("No branch is selected!")
                Return
            Else
                'Delete Entry
                MainMenuForm.conn.Open()
                Dim item As ListViewItem
                item = BranchList.SelectedItems(0)

                Dim query = "DELETE FROM branch WHERE branch_id=" + item.SubItems(0).Text
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader
                MainMenuForm.conn.Close()

                MessageBox.Show("Branch has been successfully deleted!")

                'Refresh Table
                MainMenuForm.conn.Open()
                BranchList.Items.Clear()
                query = "SELECT b.branch_id, b.branch_name, s.shopkeeper_name, b.isinoperation FROM branch AS b, shopkeeper as s WHERE b.shopkeeper_id = s.shopkeeper_id"
                'SELECT b.branch_id, b.branch_name, s.shopkeeper_name, b.isinoperation FROM branch AS b, shopkeeper as s WHERE b.shopkeeper_id = s.shopkeeper_id

                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        prodinf(0) = reader.Item("branch_id")
                        prodinf(1) = reader.Item("branch_name")
                        prodinf(2) = reader.Item("shopkeeper_name")
                        prodinf(3) = reader.Item("isinoperation")
                        info = New ListViewItem(prodinf)
                        BranchList.Items.Add(info)
                    End While
                End If

                MainMenuForm.conn.Close()
            End If

        Catch ex As Exception
            MainMenuForm.conn.Close()
            MessageBox.Show("ERROR  :" + ex.Message)
        End Try
    End Sub

    Private Sub AddBranchButton_Click(sender As Object, e As EventArgs) Handles AddBranchButton.Click
        Try
            If BranchBox.Text = "" Or ShopkeeperBox.Text = "" Then
                MessageBox.Show("All fields requires to be filled!")
                Return
            Else
                MainMenuForm.conn.Open()
                Dim query = "INSERT INTO branch (shopkeeper_id, branch_name) " +
                            "SELECT s.shopkeeper_id, '" + BranchBox.Text + "' FROM shopkeeper AS s " +
                            "WHERE s.shopkeeper_name = '" + ShopkeeperBox.Text + "'"
                System.Console.WriteLine(query)
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                MainMenuForm.conn.Close()

                MessageBox.Show("Shopkeeper has been successfully added!")

                'Refresh Database

                MainMenuForm.conn.Open()
                BranchList.Items.Clear()
                query = "SELECT b.branch_id, b.branch_name, s.shopkeeper_name, b.isinoperation FROM branch AS b, shopkeeper as s WHERE b.shopkeeper_id = s.shopkeeper_id"
                'SELECT b.branch_id, b.branch_name, s.shopkeeper_name, b.isinoperation FROM branch AS b, shopkeeper as s WHERE b.shopkeeper_id = s.shopkeeper_id

                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        prodinf(0) = reader.Item("branch_id")
                        prodinf(1) = reader.Item("branch_name")
                        prodinf(2) = reader.Item("shopkeeper_name")
                        prodinf(3) = reader.Item("isinoperation")
                        info = New ListViewItem(prodinf)
                        BranchList.Items.Add(info)
                    End While
                End If

                MainMenuForm.conn.Close()
            End If
        Catch ex As Exception
            MainMenuForm.conn.Close()
            MessageBox.Show("ERROR  :" + ex.Message)
        End Try
    End Sub

    Private Sub UpdateBranchButton_Click(sender As Object, e As EventArgs) Handles UpdateBranchButton.Click
        Try
            If BranchList.SelectedIndices.Count <= 0 Then
                MessageBox.Show("No branch is selected!")
                Return
            ElseIf BranchBox.Text = "" Or ShopkeeperBox.Text = "" Then
                MessageBox.Show("All fields requires to be filled!")
                Return
            Else
                'Update Database
                MainMenuForm.conn.Open()

                Dim item As ListViewItem
                item = BranchList.SelectedItems(0)

                Dim query = "UPDATE branch " +
                            "SET shopkeeper_id=(SELECT sho.shopkeeper_id FROM shopkeeper AS sho WHERE sho.shopkeeper_name = '" + ShopkeeperBox.Text + "'), branch_name = '" + BranchBox.Text + "' " +
                            "WHERE branch_id=" + item.SubItems(0).Text

                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                MainMenuForm.conn.Close()
                MessageBox.Show("Shopkeeper info has been successfully updated!")

                'Refresh Database

                MainMenuForm.conn.Open()
                BranchList.Items.Clear()
                query = "SELECT b.branch_id, b.branch_name, s.shopkeeper_name, b.isinoperation FROM branch AS b, shopkeeper as s WHERE b.shopkeeper_id = s.shopkeeper_id"
                'SELECT b.branch_id, b.branch_name, s.shopkeeper_name, b.isinoperation FROM branch AS b, shopkeeper as s WHERE b.shopkeeper_id = s.shopkeeper_id

                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        prodinf(0) = reader.Item("branch_id")
                        prodinf(1) = reader.Item("branch_name")
                        prodinf(2) = reader.Item("shopkeeper_name")
                        prodinf(3) = reader.Item("isinoperation")
                        info = New ListViewItem(prodinf)
                        BranchList.Items.Add(info)
                    End While
                End If

                MainMenuForm.conn.Close()
            End If

        Catch ex As Exception
            MainMenuForm.conn.Close()
            MessageBox.Show("ERROR  :" + ex.Message)
        End Try
    End Sub

    Private Sub BranchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BranchList.View = View.Details
        BranchList.FullRowSelect = True
        'ProductList.Columns.Add("Product ID", 100, HorizontalAlignment.Left)
        BranchList.Columns.Add("Branch ID", 75, HorizontalAlignment.Left)
        BranchList.Columns.Add("Branch Name", 100, HorizontalAlignment.Left)
        BranchList.Columns.Add("Shopkeeper", 100, HorizontalAlignment.Left)
        BranchList.Columns.Add("In Operation", 75, HorizontalAlignment.Left)

        Try
            MainMenuForm.conn.Open()
            BranchList.Items.Clear()
            Dim query = "SELECT b.branch_id, b.branch_name, s.shopkeeper_name, b.isinoperation FROM branch AS b, shopkeeper as s WHERE b.shopkeeper_id = s.shopkeeper_id"
            'SELECT b.branch_id, b.branch_name, s.shopkeeper_name, b.isinoperation FROM branch AS b, shopkeeper as s WHERE b.shopkeeper_id = s.shopkeeper_id

            comm = New MySqlCommand(query, MainMenuForm.conn)
            reader = comm.ExecuteReader

            If reader.HasRows Then
                While reader.Read()
                    prodinf(0) = reader.Item("branch_id")
                    prodinf(1) = reader.Item("branch_name")
                    prodinf(2) = reader.Item("shopkeeper_name")
                    prodinf(3) = reader.Item("isinoperation")
                    info = New ListViewItem(prodinf)
                    BranchList.Items.Add(info)
                End While
            End If

            MainMenuForm.conn.Close()
        Catch ex As Exception
            MainMenuForm.conn.Close()
            MessageBox.Show("ERROR  :" + ex.Message)
        End Try

        'Load Shopkeeper

        Try
            MainMenuForm.conn.Open()
            query = "SELECT s.shopkeeper_name FROM shopkeeper AS s LEFT JOIN branch AS b ON s.shopkeeper_id = b.shopkeeper_id WHERE b.shopkeeper_id IS NULL"

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
        Catch ex As Exception
            MainMenuForm.conn.Close()
            MessageBox.Show("ERROR  :" + ex.Message)
        End Try
    End Sub
End Class