Public Class Cart

    Dim PanelExpanded As Boolean = False
    Private Sub Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnVege_Click(sender As Object, e As EventArgs) Handles btnVege.Click
        VegetablePage.Show()
        Me.Hide()
    End Sub

    Private Sub btnFruit_Click(sender As Object, e As EventArgs) Handles btnFruit.Click
        FruitSeeds.Show()
        Me.Hide()
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

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class