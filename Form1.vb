Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI

Public Class Form1
    Dim con As MySqlConnection
    Dim cmd As MySqlCommand


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Validate input fields
        If String.IsNullOrWhiteSpace(txtUN.Text) OrElse String.IsNullOrWhiteSpace(txtPW.Text) Then
            MessageBox.Show("Both Username and Password are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Proceed with login attempt
        con = New MySqlConnection("Server=localhost;Database=urbanfarming;username=root;password=")
        cmd = New MySqlCommand("SELECT * FROM `login` WHERE `username` = @username AND `password` = @password", con)
        cmd.Parameters.AddWithValue("@username", txtUN.Text)
        cmd.Parameters.AddWithValue("@password", txtPW.Text)

        Dim adapter As New MySqlDataAdapter(cmd)
        Dim table As New DataTable

        Try
            con.Open()
            adapter.Fill(table)
            con.Close()

            If table.Rows.Count = 0 Then
                MessageBox.Show("Invalid Username or Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
                VegetablePage.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try

        ' Clear the fields
        txtPW.Text = ""
        txtUN.Text = ""
    End Sub


    Private Sub txtUN_TextChanged(sender As Object, e As EventArgs) Handles txtUN.TextChanged

    End Sub

    Private Sub txtPW_TextChanged(sender As Object, e As EventArgs) Handles txtPW.TextChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Hide()
        txtUN.Text = ""
        txtPW.Text = ""
    End Sub
End Class
