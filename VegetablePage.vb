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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label1.Click

    End Sub

    ' Handle View Guide button clicks
    Private Sub btnViewGuide_Click(sender As Object, e As EventArgs) _
    Handles btnViewGuideOkra.Click, btnViewGuideLettuce.Click, btnViewGuidePechay.Click,
            btnViewGuideTomato.Click, btnViewGuideSitaw.Click, btnViewGuideCucumber.Click,
            btnViewGuideEggplant.Click, btnViewGuideSquash.Click,
            btnViewGuideOnion.Click

        ' Cast sender to Button to identify which button was clicked
        Dim btn As Button = DirectCast(sender, Button)

        ' Show the guide panel
        GuidePanel.Visible = True

        ' Populate the guide content based on the button clicked
        Select Case btn.Name
            Case "btnViewGuideOkra"
                lblGuideTitle.Text = "Okra Guide"
                txtGuideContent.Text = "Plant okra in full sun. Water regularly and harvest pods when tender."
                imgGuideImage.Image = Image.FromFile("C:\Users\garab\Downloads\image-removebg-preview (22).png") ' Replace with your actual resource

            Case "btnViewGuideLettuce"
                lblGuideTitle.Text = "Lettuce Guide"
                txtGuideContent.Text = "Lettuce grows best in cool weather. Keep soil moist and harvest leaves as needed."
                imgGuideImage.Image = Image.FromFile("C:\Users\garab\Downloads\image-removebg-preview (23).png")

            Case "btnViewGuidePechay"
                lblGuideTitle.Text = "Pechay Guide"
                txtGuideContent.Text = "Pechay thrives in well-drained soil. Water regularly and harvest before bolting."
                imgGuideImage.Image = Image.FromFile("C:\Users\garab\Downloads\image-removebg-preview (15).png")

        ' Add more cases for other buttons (Tomato, Carrot, etc.)
            Case "btnViewGuideTomato"
                lblGuideTitle.Text = "Tomato Guide"
                txtGuideContent.Text = "Tomatoes need full sun and well-drained soil. Water consistently and use stakes for support."
                imgGuideImage.Image = Image.FromFile("C:\Users\garab\Downloads\image-removebg-preview (19).png")

            Case "btnViewGuideEggplant"
                lblGuideTitle.Text = "Eggplant Guide"
                txtGuideContent.Text = "Carrots grow well in loose, sandy soil. Thin seedlings for better root development."
                imgGuideImage.Image = Image.FromFile("C:\Users\garab\Downloads\image-removebg-preview (24).png")

            Case "btnViewGuideCucumber"
                lblGuideTitle.Text = "Cucumber Guide"
                txtGuideContent.Text = "Lettuce grows best in cool weather. Keep soil moist and harvest leaves as needed."
                imgGuideImage.Image = Image.FromFile("C:\Users\garab\Downloads\image-removebg-preview (23).png")

            Case "btnViewGuideSitaw"
                lblGuideTitle.Text = "Sitaw Guide"
                txtGuideContent.Text = "Pechay thrives in well-drained soil. Water regularly and harvest before bolting."
                imgGuideImage.Image = Image.FromFile("C:\Users\garab\Downloads\image-removebg-preview (15).png")

        ' Add more cases for other buttons (Tomato, Carrot, etc.)
            Case "btnViewGuideSquash"
                lblGuideTitle.Text = "Squash Guide"
                txtGuideContent.Text = "Tomatoes need full sun and well-drained soil. Water consistently and use stakes for support."
                imgGuideImage.Image = Image.FromFile("C:\Users\garab\Downloads\image-removebg-preview (19).png")

            Case "btnViewGuideOnion"
                lblGuideTitle.Text = "Onion Guide"
                txtGuideContent.Text = "Carrots grow well in loose, sandy soil. Thin seedlings for better root development."
                imgGuideImage.Image = Image.FromFile("C:\Users\garab\Downloads\image-removebg-preview (24).png")

                ' Continue for the remaining vegetables...
        End Select
    End Sub

    ' Close the guide panel
    Private Sub btnCloseGuide_Click(sender As Object, e As EventArgs) Handles btnCloseGuide.Click
        GuidePanel.Visible = False
    End Sub

    Private Sub btnViewGuideTomato_Click(sender As Object, e As EventArgs) Handles btnViewGuideTomato.Click

    End Sub
End Class
