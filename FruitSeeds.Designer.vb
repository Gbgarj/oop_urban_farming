<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FruitSeeds
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FruitSeeds))
        Nav = New Panel()
        btnLogout = New Button()
        btnCart = New Button()
        btnFruit = New Button()
        btnVege = New Button()
        Panel13 = New Panel()
        PictureBox2 = New PictureBox()
        btnNavExit = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel3 = New Panel()
        Panel5 = New Panel()
        Panel4 = New Panel()
        Panel6 = New Panel()
        Panel7 = New Panel()
        Panel8 = New Panel()
        Panel9 = New Panel()
        Panel10 = New Panel()
        Panel11 = New Panel()
        btnNav = New Button()
        Panel2 = New Panel()
        Button3 = New Button()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        appleLabel = New Label()
        Nav.SuspendLayout()
        Panel13.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        Nav.TabIndex = 28
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
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle
        FlowLayoutPanel1.Controls.Add(Panel3)
        FlowLayoutPanel1.Controls.Add(Panel5)
        FlowLayoutPanel1.Controls.Add(Panel4)
        FlowLayoutPanel1.Controls.Add(Panel6)
        FlowLayoutPanel1.Controls.Add(Panel7)
        FlowLayoutPanel1.Controls.Add(Panel8)
        FlowLayoutPanel1.Controls.Add(Panel9)
        FlowLayoutPanel1.Controls.Add(Panel10)
        FlowLayoutPanel1.Controls.Add(Panel11)
        FlowLayoutPanel1.Location = New Point(52, 139)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(10)
        FlowLayoutPanel1.Size = New Size(838, 362)
        FlowLayoutPanel1.TabIndex = 27
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(appleLabel)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Location = New Point(20, 20)
        Panel3.Margin = New Padding(10)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(246, 323)
        Panel3.TabIndex = 0
        ' 
        ' Panel5
        ' 
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Location = New Point(286, 20)
        Panel5.Margin = New Padding(10)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(246, 323)
        Panel5.TabIndex = 1
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Location = New Point(552, 20)
        Panel4.Margin = New Padding(10)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(246, 323)
        Panel4.TabIndex = 1
        ' 
        ' Panel6
        ' 
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Location = New Point(20, 363)
        Panel6.Margin = New Padding(10)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(246, 323)
        Panel6.TabIndex = 2
        ' 
        ' Panel7
        ' 
        Panel7.BorderStyle = BorderStyle.FixedSingle
        Panel7.Location = New Point(286, 363)
        Panel7.Margin = New Padding(10)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(246, 323)
        Panel7.TabIndex = 3
        ' 
        ' Panel8
        ' 
        Panel8.BorderStyle = BorderStyle.FixedSingle
        Panel8.Location = New Point(552, 363)
        Panel8.Margin = New Padding(10)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(246, 323)
        Panel8.TabIndex = 4
        ' 
        ' Panel9
        ' 
        Panel9.BorderStyle = BorderStyle.FixedSingle
        Panel9.Location = New Point(20, 706)
        Panel9.Margin = New Padding(10)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(246, 323)
        Panel9.TabIndex = 5
        ' 
        ' Panel10
        ' 
        Panel10.BorderStyle = BorderStyle.FixedSingle
        Panel10.Location = New Point(286, 706)
        Panel10.Margin = New Padding(10)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(246, 323)
        Panel10.TabIndex = 6
        ' 
        ' Panel11
        ' 
        Panel11.BorderStyle = BorderStyle.FixedSingle
        Panel11.Location = New Point(552, 706)
        Panel11.Margin = New Padding(10)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(246, 323)
        Panel11.TabIndex = 7
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
        btnNav.TabIndex = 26
        btnNav.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Panel2.Controls.Add(Button3)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(932, 37)
        Panel2.TabIndex = 25
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
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.appleseeds
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 40)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(238, 190)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 29
        Label1.Text = "Label1"
        ' 
        ' appleLabel
        ' 
        appleLabel.AutoSize = True
        appleLabel.Location = New Point(81, 12)
        appleLabel.Name = "appleLabel"
        appleLabel.Size = New Size(71, 15)
        appleLabel.TabIndex = 1
        appleLabel.Text = "Apple Seeds"
        ' 
        ' FruitSeeds
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(932, 548)
        Controls.Add(Label1)
        Controls.Add(Nav)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(btnNav)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "FruitSeeds"
        Text = "Form3"
        Nav.ResumeLayout(False)
        Panel13.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Nav As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnCart As Button
    Friend WithEvents btnFruit As Button
    Friend WithEvents btnVege As Button
    Friend WithEvents Panel13 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnNavExit As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents btnNav As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents appleLabel As Label
End Class
