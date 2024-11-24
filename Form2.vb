Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI

Public Class Form2
    Dim con As MySqlConnection
    Dim cmd As MySqlCommand

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Check if any of the fields are empty
        If String.IsNullOrWhiteSpace(Firstname.Text) OrElse
       String.IsNullOrWhiteSpace(LastName.Text) OrElse
       String.IsNullOrWhiteSpace(ValidUsername.Text) OrElse
       String.IsNullOrWhiteSpace(CreatePass.Text) Then

            MessageBox.Show("All fields are required. Please fill out the form completely.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Proceed with database operations
        con = New MySqlConnection("Server=localhost;Database=urbanfarming;username=root;password=")
        cmd = New MySqlCommand("INSERT INTO `login`(`firstname`, `lastname`, `username`, `password`) VALUES (@firstname, @lastname, @username, @password)", con)

        cmd.Parameters.AddWithValue("@firstname", Firstname.Text)
        cmd.Parameters.AddWithValue("@lastname", LastName.Text)
        cmd.Parameters.AddWithValue("@username", ValidUsername.Text)
        cmd.Parameters.AddWithValue("@password", CreatePass.Text)

        Dim adapter As New MySqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        con.Open()
        con.Close()

        If table.Rows.Count = 0 Then
            MessageBox.Show("Account Created!")
            Form1.Show()
            Hide()
        Else
            MessageBox.Show("Failed to create account.")
        End If

        ' Clear the fields
        Firstname.Text = ""
        LastName.Text = ""
        ValidUsername.Text = ""
        CreatePass.Text = ""
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
