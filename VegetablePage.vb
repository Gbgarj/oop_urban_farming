Public Class VegetablePage

    Dim PanelExpanded As Boolean = False ' Track if the panel is expanded or collapsed

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure the panel starts collapsed
        Nav.Width = 0
    End Sub

    Private Sub btnNav_Click(sender As Object, e As EventArgs) Handles btnNav.Click
        If PanelExpanded Then
            ' Collapse the panel
            For i As Integer = Nav.Width To 0 Step -10
                Nav.Width = i
                Application.DoEvents() ' Refresh the UI
                System.Threading.Thread.Sleep(5) ' Delay for smooth animation
                btnVege.Hide()
                btnFruit.Hide()
                btnCart.Hide()
                btnLogout.Hide()
            Next
            PanelExpanded = False
        Else
            ' Expand the panel
            For i As Integer = 0 To 200 Step 10 ' Set target width (e.g., 200)
                Nav.Width = i
                Application.DoEvents()
                System.Threading.Thread.Sleep(5)
                btnVege.Show()
                btnFruit.Show()
                btnCart.Show()
                btnLogout.Show()
            Next
            PanelExpanded = True
        End If
    End Sub

    Private Sub btnNavExit_Click(sender As Object, e As EventArgs) Handles btnNavExit.Click
        If PanelExpanded Then
            ' Collapse the panel
            For i = Nav.Width To 0 Step -10
                Nav.Width = i
                Application.DoEvents() ' Refresh the UI
                Threading.Thread.Sleep(5) ' Delay for smooth animation
                btnVege.Hide()
                btnFruit.Hide()
                btnCart.Hide()
                btnLogout.Hide()
            Next
            PanelExpanded = False
        Else
            ' Expand the panel
            For i = 0 To 200 Step 10 ' Set target width (e.g., 200)
                Nav.Width = i
                Application.DoEvents()
                Threading.Thread.Sleep(5)
                btnVege.Show()
                btnFruit.Show()
                btnCart.Show()
                btnLogout.Show()
            Next
            PanelExpanded = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub btnVege_Click(sender As Object, e As EventArgs) Handles btnVege.Click

    End Sub

    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles btnVege.MouseEnter, btnFruit.MouseEnter, btnCart.MouseEnter
        ' Change the background color of the hovered button
        Dim btn = CType(sender, Button)
        btn.BackColor = Color.Green
    End Sub

    Private Sub btn_MouseLeave(sender As Object, e As EventArgs) Handles btnVege.MouseLeave, btnFruit.MouseLeave, btnCart.MouseLeave
        ' Revert the background color of the button when the mouse leaves
        Dim btn = CType(sender, Button)
        btn.BackColor = Color.FromArgb(18, 16, 0)
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click

    End Sub
End Class
