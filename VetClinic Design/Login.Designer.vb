<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Panel2 = New Panel()
        btnClose = New Button()
        Label3 = New Label()
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        Username = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        PictureBox1 = New PictureBox()
        btnLogIn = New Button()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = My.Resources.Resources.internet_technology_blue_background_design_0070028_660340_66
        Panel2.Controls.Add(btnClose)
        Panel2.Controls.Add(Label3)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(905, 27)
        Panel2.TabIndex = 9
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.IndianRed
        btnClose.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(878, 2)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(24, 23)
        btnClose.TabIndex = 9
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Sitka Heading", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(12, 5)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 18)
        Label3.TabIndex = 8
        Label3.Text = "Veterinary Official System"
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.d24a9d5a_7ca7_4bd3_9e63_d95265b300ea
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Location = New Point(0, 6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(502, 464)
        Panel1.TabIndex = 17
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Sitka Heading", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(620, 428)
        Label2.Name = "Label2"
        Label2.Size = New Size(180, 21)
        Label2.TabIndex = 16
        Label2.Text = "Secured by NomVet Clinic"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Sitka Heading", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(592, 228)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 21)
        Label1.TabIndex = 14
        Label1.Text = "Password"
        ' 
        ' Username
        ' 
        Username.AutoSize = True
        Username.BackColor = Color.Transparent
        Username.Font = New Font("Sitka Heading", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Username.ForeColor = SystemColors.ControlLightLight
        Username.Location = New Point(592, 175)
        Username.Name = "Username"
        Username.Size = New Size(78, 21)
        Username.TabIndex = 13
        Username.Text = "Username"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(592, 252)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(220, 23)
        TextBox2.TabIndex = 12
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(592, 199)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(220, 23)
        TextBox1.TabIndex = 11
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources._300b7530_1555_41b3_b69e_a8cbbbef9dd0
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(570, 71)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(272, 90)
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' btnLogIn
        ' 
        btnLogIn.BackgroundImage = My.Resources.Resources._1e4477_solid_color_background_icolorpalette
        btnLogIn.Font = New Font("Sitka Display", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogIn.ForeColor = SystemColors.ControlLightLight
        btnLogIn.Location = New Point(649, 300)
        btnLogIn.Name = "btnLogIn"
        btnLogIn.Size = New Size(96, 35)
        btnLogIn.TabIndex = 18
        btnLogIn.Text = "Log-In"
        btnLogIn.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._1e4477_solid_color_background_icolorpalette
        ClientSize = New Size(905, 470)
        Controls.Add(btnLogIn)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Username)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Username As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogIn As Button

End Class
