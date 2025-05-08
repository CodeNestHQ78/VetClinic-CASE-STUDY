<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Appointment
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
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        CheckBox1 = New CheckBox()
        DateTimePicker1 = New DateTimePicker()
        CheckBox2 = New CheckBox()
        TextBox2 = New TextBox()
        Label7 = New Label()
        Button12 = New Button()
        ComboBox2 = New ComboBox()
        Label4 = New Label()
        Label3 = New Label()
        TextBox4 = New TextBox()
        Username = New Label()
        Label6 = New Label()
        Button1 = New Button()
        Button5 = New Button()
        Label10 = New Label()
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        DataGridView1 = New DataGridView()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.images10
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(CheckBox2)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Button12)
        Panel1.Controls.Add(ComboBox2)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(Username)
        Panel1.Controls.Add(Label6)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(381, 574)
        Panel1.TabIndex = 85
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.icons8_calendar_24__1_1
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(20, 96)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(59, 49)
        PictureBox1.TabIndex = 102
        PictureBox1.TabStop = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.Font = New Font("Sitka Display", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox1.ForeColor = SystemColors.ControlLightLight
        CheckBox1.Location = New Point(160, 263)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(89, 25)
        CheckBox1.TabIndex = 101
        CheckBox1.Text = "Check-Up"
        CheckBox1.UseVisualStyleBackColor = False
        CheckBox1.UseWaitCursor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(153, 312)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(189, 23)
        DateTimePicker1.TabIndex = 100
        DateTimePicker1.UseWaitCursor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.BackColor = Color.Transparent
        CheckBox2.Font = New Font("Sitka Display", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox2.ForeColor = SystemColors.ControlLightLight
        CheckBox2.Location = New Point(255, 263)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(75, 25)
        CheckBox2.TabIndex = 99
        CheckBox2.Text = "Vaccine"
        CheckBox2.UseVisualStyleBackColor = False
        CheckBox2.UseWaitCursor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(157, 222)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(97, 23)
        TextBox2.TabIndex = 97
        TextBox2.UseWaitCursor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Sitka Heading", 18F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.ControlLightLight
        Label7.Location = New Point(22, 300)
        Label7.Name = "Label7"
        Label7.Size = New Size(72, 35)
        Label7.TabIndex = 96
        Label7.Text = "Date:"
        Label7.UseWaitCursor = True
        ' 
        ' Button12
        ' 
        Button12.Font = New Font("Sitka Display", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button12.ForeColor = SystemColors.ControlLightLight
        Button12.Image = My.Resources.Resources._1e4477_solid_color_background_icolorpalette
        Button12.Location = New Point(22, 373)
        Button12.Name = "Button12"
        Button12.Size = New Size(320, 39)
        Button12.TabIndex = 95
        Button12.Text = "Schedule"
        Button12.UseVisualStyleBackColor = True
        Button12.UseWaitCursor = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(260, 222)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(82, 23)
        ComboBox2.TabIndex = 94
        ComboBox2.Text = "Fetile"
        ComboBox2.UseWaitCursor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Sitka Heading", 18F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(21, 253)
        Label4.Name = "Label4"
        Label4.Size = New Size(133, 35)
        Label4.TabIndex = 93
        Label4.Text = "Procedure:"
        Label4.UseWaitCursor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Sitka Heading", 18F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(21, 209)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 35)
        Label3.TabIndex = 92
        Label3.Text = "Pet:"
        Label3.UseWaitCursor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(157, 174)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(185, 23)
        TextBox4.TabIndex = 91
        TextBox4.UseWaitCursor = True
        ' 
        ' Username
        ' 
        Username.AutoSize = True
        Username.BackColor = Color.Transparent
        Username.Font = New Font("Sitka Heading", 18F, FontStyle.Bold)
        Username.ForeColor = SystemColors.ControlLightLight
        Username.Location = New Point(21, 161)
        Username.Name = "Username"
        Username.Size = New Size(94, 35)
        Username.TabIndex = 90
        Username.Text = "Owner:"
        Username.UseWaitCursor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Sitka Heading", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(76, 106)
        Label6.Name = "Label6"
        Label6.Size = New Size(288, 39)
        Label6.TabIndex = 89
        Label6.Text = "Schedule Appointment"
        Label6.TextAlign = ContentAlignment.TopCenter
        Label6.UseWaitCursor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Sitka Display", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Image = My.Resources.Resources._1e4477_solid_color_background_icolorpalette
        Button1.Location = New Point(992, 524)
        Button1.Name = "Button1"
        Button1.Size = New Size(99, 30)
        Button1.TabIndex = 91
        Button1.Text = "View"
        Button1.UseVisualStyleBackColor = True
        Button1.UseWaitCursor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Sitka Display", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = SystemColors.ControlLightLight
        Button5.Image = My.Resources.Resources._1e4477_solid_color_background_icolorpalette
        Button5.Location = New Point(887, 524)
        Button5.Name = "Button5"
        Button5.Size = New Size(99, 30)
        Button5.TabIndex = 90
        Button5.Text = "Edit"
        Button5.UseVisualStyleBackColor = True
        Button5.UseWaitCursor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ActiveCaption
        Label10.Location = New Point(417, 59)
        Label10.Name = "Label10"
        Label10.Size = New Size(201, 37)
        Label10.TabIndex = 89
        Label10.Text = "Appointments"
        Label10.TextAlign = ContentAlignment.TopCenter
        Label10.UseWaitCursor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(903, 73)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(116, 23)
        ComboBox1.TabIndex = 88
        ComboBox1.Text = "Monday"
        ComboBox1.UseWaitCursor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(624, 73)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(273, 23)
        TextBox1.TabIndex = 87
        TextBox1.Text = "Search..."
        TextBox1.UseWaitCursor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(417, 106)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(674, 412)
        DataGridView1.TabIndex = 86
        DataGridView1.UseWaitCursor = True
        ' 
        ' Appointment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.colorful_gradient_abstract_background_colorful_pastel_design_vector3
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1163, 574)
        Controls.Add(Button1)
        Controls.Add(Button5)
        Controls.Add(Label10)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox1)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Appointment"
        Text = "Appointment"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button12 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Username As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
End Class
