Imports MySql.Data.MySqlClient

Public Class MainMenuForm
    Dim strconnect As String
    Public conn As MySqlConnection
    Dim reader As MySqlDataReader
    Dim comm As MySqlCommand
    Dim query As String
    Dim islogin As Boolean
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
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextbox.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles AdminLabel.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs) Handles PasswordLabel.Click

    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Try
            conn.Open()
            query = "SELECT * FROM shopkeeper WHERE shopkeeper_name='" + UsernameTextbox.Text + "' AND hashed_password = PASSWORD('" + PasswordTextbox.Text + "') AND isactive = 1 AND admin_permission=1;"
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader
            If reader.HasRows Then
                If reader.Read() Then
                    WelcomeLabel.Text = "Welcome, " + reader.Item("shopkeeper_name") + "!"
                End If
                islogin = True

                AdminLabel.Hide()
                UsernameLabel.Hide()
                UsernameTextbox.Hide()
                PasswordTextbox.Hide()
                PasswordLabel.Hide()
                LoginButton.Hide()
                hideName()
                WelcomeLabel.Show()
                RestockProductsButton.Show()
                ManageBranchesButton.Show()
                ManageInvoicesButton.Show()
                ManageProductsButton.Show()
                ManagePharmasistsButton.Show()
                ManageShopkeepersButton.Show()
                LogOffButton.Show()
            Else
                MessageBox.Show("Invalid Username or Password!")
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("ERROR  :" + ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strconnect = "Server = localhost; user id = root; password = ; database = pharmashop; SslMode = none"
        conn = New MySqlConnection(strconnect)
    End Sub

    Private Sub LogOffButton_Click(sender As Object, e As EventArgs) Handles LogOffButton.Click
        islogin = False

        AdminLabel.Show()
        UsernameLabel.Show()
        UsernameTextbox.Show()
        PasswordTextbox.Show()
        PasswordLabel.Show()
        LoginButton.Show()
        UsernameTextbox.Text = ""
        PasswordTextbox.Text = ""
        showName()
        WelcomeLabel.Hide()
        RestockProductsButton.Hide()
        ManageBranchesButton.Hide()
        ManageInvoicesButton.Hide()
        ManageProductsButton.Hide()
        ManagePharmasistsButton.Hide()
        ManageShopkeepersButton.Hide()
        LogOffButton.Hide()

    End Sub

    Private Sub OpenRestockForm(sender As Object, e As EventArgs) Handles RestockProductsButton.Click
        RestockForm.Show()
        Me.Hide()
    End Sub

    Private Sub OpenProductForm(sender As Object, e As EventArgs) Handles ManageProductsButton.Click
        ProductForm.Show()
        Me.Hide()
    End Sub

    Private Sub OpenInvoiceForm(sender As Object, e As EventArgs) Handles ManageInvoicesButton.Click
        InvoiceForm.Show()
        Me.Hide()
    End Sub

    Private Sub OpenBranchForm(sender As Object, e As EventArgs) Handles ManageBranchesButton.Click
        BranchForm.Show()
        Me.Hide()
    End Sub

    Private Sub OpenShopkeeperForm(sender As Object, e As EventArgs) Handles ManageShopkeepersButton.Click
        ShopkeeperForm.Show()
        Me.Hide()
    End Sub

    Private Sub ManagePharmasistsButton_Click(sender As Object, e As EventArgs) Handles ManagePharmasistsButton.Click
        PharmasistForm.Show()
        Me.Hide()
    End Sub

    Private Sub PasswordTextbox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextbox.TextChanged

    End Sub
End Class
