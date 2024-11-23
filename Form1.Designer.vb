<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        txtUN = New TextBox()
        txtPW = New TextBox()
        Username = New Label()
        Label1 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        PictureBox3 = New PictureBox()
        Panel2 = New Panel()
        Button2 = New Button()
        PictureBox2 = New PictureBox()
        Button3 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(49, 77)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(107, 100)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' txtUN
        ' 
        txtUN.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        txtUN.BackColor = SystemColors.ControlLightLight
        txtUN.BorderStyle = BorderStyle.FixedSingle
        txtUN.Font = New Font("Arial", 9F)
        txtUN.Location = New Point(54, 241)
        txtUN.Multiline = True
        txtUN.Name = "txtUN"
        txtUN.Size = New Size(238, 35)
        txtUN.TabIndex = 2
        ' 
        ' txtPW
        ' 
        txtPW.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        txtPW.BackColor = SystemColors.ControlLightLight
        txtPW.BorderStyle = BorderStyle.FixedSingle
        txtPW.Font = New Font("Arial", 9F)
        txtPW.Location = New Point(54, 319)
        txtPW.Multiline = True
        txtPW.Name = "txtPW"
        txtPW.PasswordChar = "●"c
        txtPW.Size = New Size(238, 33)
        txtPW.TabIndex = 3
        ' 
        ' Username
        ' 
        Username.AutoSize = True
        Username.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Username.Image = CType(resources.GetObject("Username.Image"), Image)
        Username.ImageAlign = ContentAlignment.MiddleLeft
        Username.Location = New Point(54, 214)
        Username.Name = "Username"
        Username.Size = New Size(84, 15)
        Username.TabIndex = 4
        Username.Text = "        Username"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Image = CType(resources.GetObject("Label1.Image"), Image)
        Label1.ImageAlign = ContentAlignment.MiddleLeft
        Label1.Location = New Point(54, 292)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 15)
        Label1.TabIndex = 5
        Label1.Text = "        Password"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Green
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(106, 373)
        Button1.Name = "Button1"
        Button1.Size = New Size(133, 41)
        Button1.TabIndex = 6
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(77, 436)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 15)
        Label2.TabIndex = 7
        Label2.Text = "Don't have an account yet?"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(180, 77)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(112, 100)
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Panel2.Controls.Add(Button2)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(730, 37)
        Panel2.TabIndex = 10
        ' 
        ' Button2
        ' 
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(695, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(32, 31)
        Button2.TabIndex = 11
        Button2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Right
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(351, 37)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(379, 481)
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.DarkGreen
        Button3.Location = New Point(224, 432)
        Button3.Name = "Button3"
        Button3.Size = New Size(59, 23)
        Button3.TabIndex = 12
        Button3.Text = "Sign up"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(252), CByte(251), CByte(244))
        ClientSize = New Size(730, 518)
        Controls.Add(Button3)
        Controls.Add(PictureBox2)
        Controls.Add(Panel2)
        Controls.Add(PictureBox3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(Username)
        Controls.Add(txtPW)
        Controls.Add(txtUN)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtUN As TextBox
    Friend WithEvents txtPW As TextBox
    Friend WithEvents Username As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button3 As Button

End Class
