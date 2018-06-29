Imports MySql.Data.MySqlClient

Public Class PharmasistForm

    Dim str, query As String
    Dim comm As MySqlCommand
    Dim reader As MySqlDataReader
    Dim pharinf(5) As String
    Dim info As ListViewItem

    Private Sub PharmasistForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PharmasistList.View = View.Details
        PharmasistList.FullRowSelect = True
        PharmasistList.Columns.Add("Pharmasist ID", 80, HorizontalAlignment.Left)
        PharmasistList.Columns.Add("Branch Name", 100, HorizontalAlignment.Left)
        PharmasistList.Columns.Add("Name", 75, HorizontalAlignment.Left)
        PharmasistList.Columns.Add("Gender", 75, HorizontalAlignment.Left)
        PharmasistList.Columns.Add("Active", 75, HorizontalAlignment.Left)

        Try
            MainMenuForm.conn.Open()
            PharmasistList.Items.Clear()
            Dim query = "SELECT p.pharmasist_id, b.branch_name, p.pharmasist_name, p.gender, p.isactive FROM pharmasist AS p, branch AS b WHERE b.branch_id = p.branch_id"
            'SELECT p.pharmasist_id, b.branch_name, p.pharmasist_name, p.gender, p.isactive FROM pharmasist AS p, branch AS b WHERE b.branch_id = p.branch_id

            comm = New MySqlCommand(query, MainMenuForm.conn)
            reader = comm.ExecuteReader

            If reader.HasRows Then
                While reader.Read()
                    pharinf(0) = reader.Item("pharmasist_id")
                    pharinf(1) = reader.Item("branch_name")
                    pharinf(2) = reader.Item("pharmasist_name")
                    pharinf(3) = reader.Item("gender")
                    pharinf(4) = reader.Item("isactive")
                    info = New ListViewItem(pharinf)
                    PharmasistList.Items.Add(info)
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

    Private Sub DisablePharmasistButton_Click(sender As Object, e As EventArgs) Handles DisablePharmasistButton.Click
        Try
            If PharmasistList.SelectedIndices.Count <= 0 Then
                MessageBox.Show("No pharmasist is selected!")
                Return
            Else
                'Disable Entry
                MainMenuForm.conn.Open()

                Dim item As ListViewItem
                item = PharmasistList.SelectedItems(0)

                Dim query = "UPDATE pharmasist SET isactive = 0 WHERE pharmasist_id=" + item.SubItems(0).Text
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                MainMenuForm.conn.Close()

                'Refresh Database

                MainMenuForm.conn.Open()
                PharmasistList.Items.Clear()
                query = "SELECT p.pharmasist_id, b.branch_name, p.pharmasist_name, p.gender, p.isactive FROM pharmasist AS p, branch AS b WHERE b.branch_id = p.branch_id"
                'SELECT p.pharmasist_id, b.branch_name, p.pharmasist_name, p.gender, p.isactive FROM pharmasist AS p, branch AS b WHERE b.branch_id = p.branch_id

                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        pharinf(0) = reader.Item("pharmasist_id")
                        pharinf(1) = reader.Item("branch_name")
                        pharinf(2) = reader.Item("pharmasist_name")
                        pharinf(3) = reader.Item("gender")
                        pharinf(4) = reader.Item("isactive")
                        info = New ListViewItem(pharinf)
                        PharmasistList.Items.Add(info)
                    End While
                End If

                MainMenuForm.conn.Close()
            End If

        Catch ex As Exception
            MainMenuForm.conn.Close()
            MessageBox.Show("ERROR  :" + ex.Message)
        End Try
    End Sub

    Private Sub EnablePharmasistButton_Click(sender As Object, e As EventArgs) Handles EnablePharmasistButton.Click
        Try
            If PharmasistList.SelectedIndices.Count <= 0 Then
                MessageBox.Show("No pharmasist is selected!")
                Return
            Else
                'Enable Entry
                MainMenuForm.conn.Open()

                Dim item As ListViewItem
                item = PharmasistList.SelectedItems(0)

                Dim query = "UPDATE pharmasist SET isactive = 1 WHERE pharmasist_id=" + item.SubItems(0).Text
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                MainMenuForm.conn.Close()

                'Refresh Database

                MainMenuForm.conn.Open()
                PharmasistList.Items.Clear()
                query = "SELECT p.pharmasist_id, b.branch_name, p.pharmasist_name, p.gender, p.isactive FROM pharmasist AS p, branch AS b WHERE b.branch_id = p.branch_id"
                'SELECT p.pharmasist_id, b.branch_name, p.pharmasist_name, p.gender, p.isactive FROM pharmasist AS p, branch AS b WHERE b.branch_id = p.branch_id

                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        pharinf(0) = reader.Item("pharmasist_id")
                        pharinf(1) = reader.Item("branch_name")
                        pharinf(2) = reader.Item("pharmasist_name")
                        pharinf(3) = reader.Item("gender")
                        pharinf(4) = reader.Item("isactive")
                        info = New ListViewItem(pharinf)
                        PharmasistList.Items.Add(info)
                    End While
                End If

                MainMenuForm.conn.Close()
            End If

        Catch ex As Exception
            MainMenuForm.conn.Close()
            MessageBox.Show("ERROR  :" + ex.Message)
        End Try
    End Sub

    Private Sub UpdatePharmasistButton_Click(sender As Object, e As EventArgs) Handles UpdatePharmasistButton.Click
        Try
            If PharmasistList.SelectedIndices.Count <= 0 Then
                MessageBox.Show("No pharmasist is selected!")
                Return
            ElseIf BranchBox.Text = "" Or PharmasistBox.Text = "" Or GenderBox.Text = "" Then
                MessageBox.Show("All value needs to be filled!")
                Return
            Else
                'Update Database
                MainMenuForm.conn.Open()

                Dim item As ListViewItem
                item = PharmasistList.SelectedItems(0)

                Dim query = "UPDATE pharmasist " +
                            "SET branch_id=(SELECT bra.branch_id FROM branch AS bra WHERE bra.branch_name = '" + BranchBox.Text + "'), pharmasist_name='" + PharmasistBox.Text + "', gender='" + GenderBox.Text + "' " +
                            "WHERE pharmasist_id=" + item.SubItems(0).Text

                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                MainMenuForm.conn.Close()
                MessageBox.Show("Pharmasist has been successfully updated!")

                'Refresh Database

                MainMenuForm.conn.Open()
                PharmasistList.Items.Clear()
                query = "SELECT p.pharmasist_id, b.branch_name, p.pharmasist_name, p.gender, p.isactive FROM pharmasist AS p, branch AS b WHERE b.branch_id = p.branch_id"
                'SELECT p.pharmasist_id, b.branch_name, p.pharmasist_name, p.gender, p.isactive FROM pharmasist AS p, branch AS b WHERE b.branch_id = p.branch_id

                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        pharinf(0) = reader.Item("pharmasist_id")
                        pharinf(1) = reader.Item("branch_name")
                        pharinf(2) = reader.Item("pharmasist_name")
                        pharinf(3) = reader.Item("gender")
                        pharinf(4) = reader.Item("isactive")
                        info = New ListViewItem(pharinf)
                        PharmasistList.Items.Add(info)
                    End While
                End If

                MainMenuForm.conn.Close()
            End If

        Catch ex As Exception
            MainMenuForm.conn.Close()
            MessageBox.Show("ERROR  :" + ex.Message)
        End Try
    End Sub

    Private Sub DeletePharmasistButton_Click(sender As Object, e As EventArgs) Handles DeletePharmasistButton.Click
        Try
            If PharmasistList.SelectedIndices.Count <= 0 Then
                MessageBox.Show("No pharmasist is selected!")
                Return
            Else
                'Delete Entry
                MainMenuForm.conn.Open()
                Dim item As ListViewItem
                item = PharmasistList.SelectedItems(0)

                Dim query = "DELETE FROM pharmasist WHERE pharmasist_id=" + item.SubItems(0).Text
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader
                MainMenuForm.conn.Close()

                MessageBox.Show("Pharmasist has been successfully deleted!")

                'Refresh Table
                MainMenuForm.conn.Open()
                PharmasistList.Items.Clear()
                query = "SELECT p.pharmasist_id, b.branch_name, p.pharmasist_name, p.gender, p.isactive FROM pharmasist AS p, branch AS b WHERE b.branch_id = p.branch_id"
                'SELECT p.pharmasist_id, b.branch_name, p.pharmasist_name, p.gender, p.isactive FROM pharmasist AS p, branch AS b WHERE b.branch_id = p.branch_id

                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        pharinf(0) = reader.Item("pharmasist_id")
                        pharinf(1) = reader.Item("branch_name")
                        pharinf(2) = reader.Item("pharmasist_name")
                        pharinf(3) = reader.Item("gender")
                        pharinf(4) = reader.Item("isactive")
                        info = New ListViewItem(pharinf)
                        PharmasistList.Items.Add(info)
                    End While
                End If

                MainMenuForm.conn.Close()
            End If

        Catch ex As Exception
            MainMenuForm.conn.Close()
            MessageBox.Show("ERROR  :" + ex.Message)
        End Try
    End Sub

    Private Sub AddPharmasistButton_Click(sender As Object, e As EventArgs) Handles AddPharmasistButton.Click
        Try
            If BranchBox.Text = "" Or PharmasistBox.Text = "" Or GenderBox.Text = "" Then
                MessageBox.Show("All fields requires to be filled!")
                Return
            Else
                MainMenuForm.conn.Open()
                Dim query = "INSERT INTO pharmasist (branch_id, pharmasist_name, gender) " +
                            "SELECT b.branch_id, '" + PharmasistBox.Text + "', '" + GenderBox.Text + "' FROM branch AS b " +
                            "WHERE b.branch_name = '" + BranchBox.Text + "'"
                System.Console.WriteLine(query)
                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                MainMenuForm.conn.Close()

                MessageBox.Show("Pharmasist has been successfully added!")

                'Refresh Database
                MainMenuForm.conn.Open()
                PharmasistList.Items.Clear()
                query = "SELECT p.pharmasist_id, b.branch_name, p.pharmasist_name, p.gender, p.isactive FROM pharmasist AS p, branch AS b WHERE b.branch_id = p.branch_id"
                'SELECT p.pharmasist_id, b.branch_name, p.pharmasist_name, p.gender, p.isactive FROM pharmasist AS p, branch AS b WHERE b.branch_id = p.branch_id

                comm = New MySqlCommand(query, MainMenuForm.conn)
                reader = comm.ExecuteReader

                If reader.HasRows Then
                    While reader.Read()
                        pharinf(0) = reader.Item("pharmasist_id")
                        pharinf(1) = reader.Item("branch_name")
                        pharinf(2) = reader.Item("pharmasist_name")
                        pharinf(3) = reader.Item("gender")
                        pharinf(4) = reader.Item("isactive")
                        info = New ListViewItem(pharinf)
                        PharmasistList.Items.Add(info)
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