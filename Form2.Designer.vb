<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Label1 = New Label()
        Button1 = New Button()
        LastName = New TextBox()
        Firstname = New TextBox()
        CreatePass = New TextBox()
        ValidUsername = New TextBox()
        Button2 = New Button()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        Label7 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Button3 = New Button()
        Panel2 = New Panel()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(48, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 22)
        Label1.TabIndex = 2
        Label1.Text = "SIGN UP"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(16, 52)
        Button1.Name = "Button1"
        Button1.Size = New Size(26, 27)
        Button1.TabIndex = 0
        Button1.UseVisualStyleBackColor = False
        ' 
        ' LastName
        ' 
        LastName.BorderStyle = BorderStyle.FixedSingle
        LastName.Location = New Point(35, 242)
        LastName.Multiline = True
        LastName.Name = "LastName"
        LastName.Size = New Size(136, 29)
        LastName.TabIndex = 4
        ' 
        ' Firstname
        ' 
        Firstname.BorderStyle = BorderStyle.FixedSingle
        Firstname.Location = New Point(188, 242)
        Firstname.Multiline = True
        Firstname.Name = "Firstname"
        Firstname.Size = New Size(145, 29)
        Firstname.TabIndex = 6
        ' 
        ' CreatePass
        ' 
        CreatePass.BorderStyle = BorderStyle.FixedSingle
        CreatePass.Location = New Point(35, 365)
        CreatePass.Multiline = True
        CreatePass.Name = "CreatePass"
        CreatePass.PasswordChar = "*"c
        CreatePass.Size = New Size(298, 29)
        CreatePass.TabIndex = 10
        CreatePass.UseSystemPasswordChar = True
        ' 
        ' ValidUsername
        ' 
        ValidUsername.BorderStyle = BorderStyle.FixedSingle
        ValidUsername.Location = New Point(35, 305)
        ValidUsername.Multiline = True
        ValidUsername.Name = "ValidUsername"
        ValidUsername.Size = New Size(298, 29)
        ValidUsername.TabIndex = 14
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Green
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(118, 432)
        Button2.Name = "Button2"
        Button2.Size = New Size(119, 39)
        Button2.TabIndex = 15
        Button2.Text = "SIGN UP"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(145, 96)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(83, 84)
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(35, 347)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 15)
        Label5.TabIndex = 9
        Label5.Text = "Create Password"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(35, 287)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 15)
        Label7.TabIndex = 13
        Label7.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(188, 224)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 5
        Label3.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(35, 224)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 3
        Label2.Text = "Last Name"
        ' 
        ' Button3
        ' 
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.Location = New Point(838, 3)
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
        Panel2.Size = New Size(873, 37)
        Panel2.TabIndex = 18
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(372, 37)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(501, 504)
        Panel1.TabIndex = 19
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(252), CByte(251), CByte(244))
        ClientSize = New Size(873, 541)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(PictureBox1)
        Controls.Add(Button2)
        Controls.Add(ValidUsername)
        Controls.Add(Label7)
        Controls.Add(CreatePass)
        Controls.Add(Label5)
        Controls.Add(Firstname)
        Controls.Add(Label3)
        Controls.Add(LastName)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LastName As TextBox
    Friend WithEvents Firstname As TextBox
    Friend WithEvents CreatePass As TextBox
    Friend WithEvents ValidUsername As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
End Class
