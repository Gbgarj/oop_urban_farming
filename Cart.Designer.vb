<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cart
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cart))
        PictureBox2 = New PictureBox()
        btnNavExit = New Button()
        btnLogout = New Button()
        btnCart = New Button()
        btnFruit = New Button()
        btnVege = New Button()
        Panel13 = New Panel()
        Nav = New Panel()
        btnNav = New Button()
        Button3 = New Button()
        Panel2 = New Panel()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel13.SuspendLayout()
        Nav.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(70, 24)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(68, 72)
        PictureBox2.TabIndex = 24
        PictureBox2.TabStop = False
        ' 
        ' btnNavExit
        ' 
        btnNavExit.Cursor = Cursors.Hand
        btnNavExit.FlatAppearance.BorderSize = 0
        btnNavExit.FlatStyle = FlatStyle.Flat
        btnNavExit.Image = CType(resources.GetObject("btnNavExit.Image"), Image)
        btnNavExit.Location = New Point(166, 6)
        btnNavExit.Name = "btnNavExit"
        btnNavExit.Size = New Size(31, 28)
        btnNavExit.TabIndex = 23
        btnNavExit.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Cursor = Cursors.Hand
        btnLogout.Dock = DockStyle.Bottom
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.White
        btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), Image)
        btnLogout.ImageAlign = ContentAlignment.MiddleLeft
        btnLogout.Location = New Point(0, 442)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(15, 0, 0, 0)
        btnLogout.Size = New Size(0, 69)
        btnLogout.TabIndex = 28
        btnLogout.Text = "     Logout"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnCart
        ' 
        btnCart.Cursor = Cursors.Hand
        btnCart.Dock = DockStyle.Top
        btnCart.FlatAppearance.BorderSize = 0
        btnCart.FlatStyle = FlatStyle.Flat
        btnCart.Font = New Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCart.ForeColor = SystemColors.ButtonHighlight
        btnCart.Image = CType(resources.GetObject("btnCart.Image"), Image)
        btnCart.ImageAlign = ContentAlignment.MiddleLeft
        btnCart.Location = New Point(0, 316)
        btnCart.Name = "btnCart"
        btnCart.Padding = New Padding(15, 0, 0, 0)
        btnCart.Size = New Size(0, 69)
        btnCart.TabIndex = 27
        btnCart.Text = "     Cart"
        btnCart.TextAlign = ContentAlignment.MiddleLeft
        btnCart.TextImageRelation = TextImageRelation.ImageBeforeText
        btnCart.UseVisualStyleBackColor = True
        ' 
        ' btnFruit
        ' 
        btnFruit.Cursor = Cursors.Hand
        btnFruit.Dock = DockStyle.Top
        btnFruit.FlatAppearance.BorderSize = 0
        btnFruit.FlatStyle = FlatStyle.Flat
        btnFruit.Font = New Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFruit.ForeColor = SystemColors.ButtonHighlight
        btnFruit.Image = CType(resources.GetObject("btnFruit.Image"), Image)
        btnFruit.ImageAlign = ContentAlignment.MiddleLeft
        btnFruit.Location = New Point(0, 247)
        btnFruit.Name = "btnFruit"
        btnFruit.Padding = New Padding(15, 0, 0, 0)
        btnFruit.Size = New Size(0, 69)
        btnFruit.TabIndex = 26
        btnFruit.Text = "     Fruit Seeds"
        btnFruit.TextAlign = ContentAlignment.MiddleLeft
        btnFruit.TextImageRelation = TextImageRelation.ImageBeforeText
        btnFruit.UseVisualStyleBackColor = True
        ' 
        ' btnVege
        ' 
        btnVege.Cursor = Cursors.Hand
        btnVege.Dock = DockStyle.Top
        btnVege.FlatAppearance.BorderSize = 0
        btnVege.FlatStyle = FlatStyle.Flat
        btnVege.Font = New Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVege.ForeColor = SystemColors.ButtonHighlight
        btnVege.Image = CType(resources.GetObject("btnVege.Image"), Image)
        btnVege.ImageAlign = ContentAlignment.MiddleLeft
        btnVege.Location = New Point(0, 178)
        btnVege.Name = "btnVege"
        btnVege.Padding = New Padding(15, 0, 0, 0)
        btnVege.Size = New Size(0, 69)
        btnVege.TabIndex = 25
        btnVege.Text = "     Vegetable Seeds"
        btnVege.TextAlign = ContentAlignment.MiddleLeft
        btnVege.TextImageRelation = TextImageRelation.ImageBeforeText
        btnVege.UseVisualStyleBackColor = True
        ' 
        ' Panel13
        ' 
        Panel13.Controls.Add(PictureBox2)
        Panel13.Controls.Add(btnNavExit)
        Panel13.Dock = DockStyle.Top
        Panel13.Location = New Point(0, 0)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(0, 178)
        Panel13.TabIndex = 24
        ' 
        ' Nav
        ' 
        Nav.BackColor = Color.FromArgb(CByte(18), CByte(16), CByte(0))
        Nav.Controls.Add(btnLogout)
        Nav.Controls.Add(btnCart)
        Nav.Controls.Add(btnFruit)
        Nav.Controls.Add(btnVege)
        Nav.Controls.Add(Panel13)
        Nav.Dock = DockStyle.Left
        Nav.Location = New Point(0, 37)
        Nav.Name = "Nav"
        Nav.Size = New Size(0, 511)
        Nav.TabIndex = 47
        ' 
        ' btnNav
        ' 
        btnNav.BackColor = Color.Transparent
        btnNav.Cursor = Cursors.Hand
        btnNav.FlatAppearance.BorderSize = 0
        btnNav.FlatStyle = FlatStyle.Flat
        btnNav.Image = CType(resources.GetObject("btnNav.Image"), Image)
        btnNav.Location = New Point(12, 52)
        btnNav.Name = "btnNav"
        btnNav.Size = New Size(43, 43)
        btnNav.TabIndex = 45
        btnNav.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.Location = New Point(897, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(32, 31)
        Button3.TabIndex = 11
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Panel2.Controls.Add(Button3)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(932, 37)
        Panel2.TabIndex = 44
        ' 
        ' Cart
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(932, 548)
        Controls.Add(Nav)
        Controls.Add(btnNav)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Cart"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cart"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel13.ResumeLayout(False)
        Nav.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnNavExit As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnCart As Button
    Friend WithEvents btnFruit As Button
    Friend WithEvents btnVege As Button
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Nav As Panel
    Friend WithEvents btnNav As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel2 As Panel
End Class
