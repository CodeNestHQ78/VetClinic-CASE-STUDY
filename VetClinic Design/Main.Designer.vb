<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        pnlSub = New Panel()
        lblTItle = New Label()
        Panel8 = New Panel()
        pnlBilling = New Panel()
        Panel7 = New Panel()
        PnlAppointment = New Panel()
        Panel1 = New Panel()
        btnLogOut = New Button()
        Panel11 = New Panel()
        Panel10 = New Panel()
        Panel9 = New Panel()
        Panel6 = New Panel()
        Panel5 = New Panel()
        btnBilling = New Button()
        btnAppointment = New Button()
        btnPets = New Button()
        btnPetOwners = New Button()
        PnlPets = New Panel()
        pnlPetOwners = New Panel()
        btnDashboard = New Button()
        Panel3 = New Panel()
        Panel2 = New Panel()
        Label3 = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        pnlMain = New Panel()
        Panel4 = New Panel()
        GroupBox4 = New GroupBox()
        Label12 = New Label()
        Label14 = New Label()
        PictureBox9 = New PictureBox()
        GroupBox3 = New GroupBox()
        Label9 = New Label()
        Label10 = New Label()
        PictureBox8 = New PictureBox()
        Button12 = New Button()
        GroupBox2 = New GroupBox()
        Label11 = New Label()
        Label13 = New Label()
        PictureBox3 = New PictureBox()
        Button13 = New Button()
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        PictureBox7 = New PictureBox()
        Label8 = New Label()
        PictureBox6 = New PictureBox()
        Button11 = New Button()
        PictureBox5 = New PictureBox()
        Button10 = New Button()
        PictureBox2 = New PictureBox()
        Button9 = New Button()
        PictureBox4 = New PictureBox()
        Button8 = New Button()
        pnlSub.SuspendLayout()
        pnlBilling.SuspendLayout()
        PnlAppointment.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        pnlMain.SuspendLayout()
        Panel4.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlSub
        ' 
        pnlSub.BackgroundImage = My.Resources.Resources._1e4477_solid_color_background_icolorpalette
        pnlSub.Controls.Add(lblTItle)
        pnlSub.Dock = DockStyle.Top
        pnlSub.Location = New Point(200, 27)
        pnlSub.Name = "pnlSub"
        pnlSub.Size = New Size(1148, 41)
        pnlSub.TabIndex = 15
        ' 
        ' lblTItle
        ' 
        lblTItle.AutoSize = True
        lblTItle.BackColor = Color.Transparent
        lblTItle.Font = New Font("Sitka Heading", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTItle.ForeColor = SystemColors.ControlLightLight
        lblTItle.Location = New Point(504, 3)
        lblTItle.Name = "lblTItle"
        lblTItle.Size = New Size(123, 28)
        lblTItle.TabIndex = 15
        lblTItle.Text = "DASHBOARD"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = SystemColors.ControlLightLight
        Panel8.Location = New Point(0, 28)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(10, 39)
        Panel8.TabIndex = 40
        ' 
        ' pnlBilling
        ' 
        pnlBilling.BackColor = SystemColors.ControlLightLight
        pnlBilling.Controls.Add(Panel7)
        pnlBilling.Location = New Point(0, 313)
        pnlBilling.Name = "pnlBilling"
        pnlBilling.Size = New Size(10, 39)
        pnlBilling.TabIndex = 41
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.ControlLightLight
        Panel7.Location = New Point(0, 7)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(10, 42)
        Panel7.TabIndex = 48
        ' 
        ' PnlAppointment
        ' 
        PnlAppointment.BackColor = SystemColors.ControlLightLight
        PnlAppointment.Controls.Add(Panel8)
        PnlAppointment.Location = New Point(0, 258)
        PnlAppointment.Name = "PnlAppointment"
        PnlAppointment.Size = New Size(10, 39)
        PnlAppointment.TabIndex = 40
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BackgroundImage = My.Resources.Resources._1e4477_solid_color_background_icolorpalette
        Panel1.Controls.Add(btnLogOut)
        Panel1.Controls.Add(Panel11)
        Panel1.Controls.Add(Panel10)
        Panel1.Controls.Add(Panel9)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(btnBilling)
        Panel1.Controls.Add(btnAppointment)
        Panel1.Controls.Add(btnPets)
        Panel1.Controls.Add(btnPetOwners)
        Panel1.Controls.Add(pnlBilling)
        Panel1.Controls.Add(PnlAppointment)
        Panel1.Controls.Add(PnlPets)
        Panel1.Controls.Add(pnlPetOwners)
        Panel1.Controls.Add(btnDashboard)
        Panel1.Controls.Add(Panel3)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 27)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 624)
        Panel1.TabIndex = 14
        ' 
        ' btnLogOut
        ' 
        btnLogOut.BackColor = Color.Transparent
        btnLogOut.Dock = DockStyle.Bottom
        btnLogOut.FlatAppearance.BorderSize = 0
        btnLogOut.FlatStyle = FlatStyle.Flat
        btnLogOut.ForeColor = SystemColors.ControlLightLight
        btnLogOut.Image = My.Resources.Resources.icons8_log_out_301
        btnLogOut.ImageAlign = ContentAlignment.MiddleLeft
        btnLogOut.Location = New Point(0, 569)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Padding = New Padding(12, 0, 0, 0)
        btnLogOut.Size = New Size(200, 55)
        btnLogOut.TabIndex = 51
        btnLogOut.Text = " Log-Out"
        btnLogOut.TextAlign = ContentAlignment.MiddleLeft
        btnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLogOut.UseVisualStyleBackColor = False
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = SystemColors.ControlLightLight
        Panel11.Location = New Point(0, 307)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(11, 45)
        Panel11.TabIndex = 50
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = SystemColors.ControlLightLight
        Panel10.Location = New Point(0, 256)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(11, 45)
        Panel10.TabIndex = 49
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = SystemColors.ControlLightLight
        Panel9.Location = New Point(0, 200)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(10, 47)
        Panel9.TabIndex = 48
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.ControlLightLight
        Panel6.Location = New Point(0, 148)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(10, 42)
        Panel6.TabIndex = 47
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ControlLightLight
        Panel5.Location = New Point(0, 93)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(10, 42)
        Panel5.TabIndex = 46
        ' 
        ' btnBilling
        ' 
        btnBilling.BackColor = Color.Transparent
        btnBilling.Dock = DockStyle.Top
        btnBilling.FlatAppearance.BorderSize = 0
        btnBilling.FlatStyle = FlatStyle.Flat
        btnBilling.ForeColor = SystemColors.ControlLightLight
        btnBilling.Image = CType(resources.GetObject("btnBilling.Image"), Image)
        btnBilling.ImageAlign = ContentAlignment.MiddleLeft
        btnBilling.Location = New Point(0, 307)
        btnBilling.Name = "btnBilling"
        btnBilling.Padding = New Padding(12, 0, 0, 0)
        btnBilling.Size = New Size(200, 55)
        btnBilling.TabIndex = 45
        btnBilling.Text = " Billing"
        btnBilling.TextAlign = ContentAlignment.MiddleLeft
        btnBilling.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBilling.UseVisualStyleBackColor = False
        ' 
        ' btnAppointment
        ' 
        btnAppointment.BackColor = Color.Transparent
        btnAppointment.Dock = DockStyle.Top
        btnAppointment.FlatAppearance.BorderSize = 0
        btnAppointment.FlatStyle = FlatStyle.Flat
        btnAppointment.ForeColor = SystemColors.ControlLightLight
        btnAppointment.Image = My.Resources.Resources.icons8_calendar_24__1_
        btnAppointment.ImageAlign = ContentAlignment.MiddleLeft
        btnAppointment.Location = New Point(0, 252)
        btnAppointment.Name = "btnAppointment"
        btnAppointment.Padding = New Padding(12, 0, 0, 0)
        btnAppointment.Size = New Size(200, 55)
        btnAppointment.TabIndex = 44
        btnAppointment.Text = " Appointment"
        btnAppointment.TextAlign = ContentAlignment.MiddleLeft
        btnAppointment.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAppointment.UseVisualStyleBackColor = False
        ' 
        ' btnPets
        ' 
        btnPets.BackColor = Color.Transparent
        btnPets.Dock = DockStyle.Top
        btnPets.FlatAppearance.BorderSize = 0
        btnPets.FlatStyle = FlatStyle.Flat
        btnPets.ForeColor = SystemColors.ControlLightLight
        btnPets.Image = My.Resources.Resources.icons8_paw_30
        btnPets.ImageAlign = ContentAlignment.MiddleLeft
        btnPets.Location = New Point(0, 197)
        btnPets.Name = "btnPets"
        btnPets.Padding = New Padding(12, 0, 0, 0)
        btnPets.Size = New Size(200, 55)
        btnPets.TabIndex = 43
        btnPets.Text = " Pets"
        btnPets.TextAlign = ContentAlignment.MiddleLeft
        btnPets.TextImageRelation = TextImageRelation.ImageBeforeText
        btnPets.UseVisualStyleBackColor = False
        ' 
        ' btnPetOwners
        ' 
        btnPetOwners.BackColor = Color.Transparent
        btnPetOwners.Dock = DockStyle.Top
        btnPetOwners.FlatAppearance.BorderSize = 0
        btnPetOwners.FlatStyle = FlatStyle.Flat
        btnPetOwners.ForeColor = SystemColors.ControlLightLight
        btnPetOwners.Image = My.Resources.Resources.icons8_user_30
        btnPetOwners.ImageAlign = ContentAlignment.MiddleLeft
        btnPetOwners.Location = New Point(0, 142)
        btnPetOwners.Name = "btnPetOwners"
        btnPetOwners.Padding = New Padding(12, 0, 0, 0)
        btnPetOwners.Size = New Size(200, 55)
        btnPetOwners.TabIndex = 42
        btnPetOwners.Text = "Pet Owners"
        btnPetOwners.TextAlign = ContentAlignment.MiddleLeft
        btnPetOwners.TextImageRelation = TextImageRelation.ImageBeforeText
        btnPetOwners.UseVisualStyleBackColor = False
        ' 
        ' PnlPets
        ' 
        PnlPets.BackColor = SystemColors.ControlLightLight
        PnlPets.Location = New Point(0, 203)
        PnlPets.Name = "PnlPets"
        PnlPets.Size = New Size(10, 39)
        PnlPets.TabIndex = 39
        ' 
        ' pnlPetOwners
        ' 
        pnlPetOwners.BackColor = SystemColors.ControlLightLight
        pnlPetOwners.Location = New Point(0, 148)
        pnlPetOwners.Name = "pnlPetOwners"
        pnlPetOwners.Size = New Size(10, 39)
        pnlPetOwners.TabIndex = 38
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.Transparent
        btnDashboard.Dock = DockStyle.Top
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.ForeColor = SystemColors.ControlLightLight
        btnDashboard.Image = My.Resources.Resources.icons8_home_23
        btnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        btnDashboard.Location = New Point(0, 87)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Padding = New Padding(12, 0, 0, 0)
        btnDashboard.Size = New Size(200, 55)
        btnDashboard.TabIndex = 35
        btnDashboard.Text = " Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Transparent
        Panel3.BackgroundImage = My.Resources.Resources._300b7530_1555_41b3_b69e_a8cbbbef9dd0
        Panel3.BackgroundImageLayout = ImageLayout.Stretch
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(200, 87)
        Panel3.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = My.Resources.Resources.internet_technology_blue_background_design_0070028_660340_661
        Panel2.Controls.Add(Label3)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1348, 27)
        Panel2.TabIndex = 13
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Sitka Heading", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(12, 5)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 18)
        Label3.TabIndex = 8
        Label3.Text = "Veterinary Official System"
        ' 
        ' pnlMain
        ' 
        pnlMain.BackgroundImage = My.Resources.Resources.colorful_gradient_abstract_background_colorful_pastel_design_vector
        pnlMain.BackgroundImageLayout = ImageLayout.Stretch
        pnlMain.Controls.Add(Panel4)
        pnlMain.Controls.Add(PictureBox6)
        pnlMain.Controls.Add(Button11)
        pnlMain.Controls.Add(PictureBox5)
        pnlMain.Controls.Add(Button10)
        pnlMain.Controls.Add(PictureBox2)
        pnlMain.Controls.Add(Button9)
        pnlMain.Controls.Add(PictureBox4)
        pnlMain.Controls.Add(Button8)
        pnlMain.Location = New Point(200, 66)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1148, 585)
        pnlMain.TabIndex = 16
        ' 
        ' Panel4
        ' 
        Panel4.BackgroundImage = My.Resources.Resources._1e4477_solid_color_background_icolorpalette1
        Panel4.Controls.Add(GroupBox4)
        Panel4.Controls.Add(PictureBox9)
        Panel4.Controls.Add(GroupBox3)
        Panel4.Controls.Add(PictureBox8)
        Panel4.Controls.Add(Button12)
        Panel4.Controls.Add(GroupBox2)
        Panel4.Controls.Add(PictureBox3)
        Panel4.Controls.Add(Button13)
        Panel4.Controls.Add(GroupBox1)
        Panel4.Controls.Add(PictureBox7)
        Panel4.Controls.Add(Label8)
        Panel4.Location = New Point(31, 149)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1078, 405)
        Panel4.TabIndex = 17
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = SystemColors.GradientActiveCaption
        GroupBox4.Controls.Add(Label12)
        GroupBox4.Controls.Add(Label14)
        GroupBox4.Location = New Point(753, 260)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(275, 94)
        GroupBox4.TabIndex = 89
        GroupBox4.TabStop = False
        GroupBox4.UseWaitCursor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = SystemColors.Highlight
        Label12.Location = New Point(6, 59)
        Label12.Name = "Label12"
        Label12.Size = New Size(261, 21)
        Label12.TabIndex = 2
        Label12.Text = "Scheduled: April 21,2025 at 1:00 pm"
        Label12.UseWaitCursor = True
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = SystemColors.ControlLightLight
        Label14.Image = My.Resources.Resources._1e4477_solid_color_background_icolorpalette2
        Label14.Location = New Point(8, 19)
        Label14.Name = "Label14"
        Label14.Size = New Size(62, 40)
        Label14.TabIndex = 0
        Label14.Text = "Inu"
        Label14.UseWaitCursor = True
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackColor = Color.Transparent
        PictureBox9.BackgroundImage = My.Resources.Resources._7997a3dd_c4f5_4331_a9f9_f6360dce07f91
        PictureBox9.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox9.BorderStyle = BorderStyle.FixedSingle
        PictureBox9.Location = New Point(622, 249)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(107, 105)
        PictureBox9.TabIndex = 88
        PictureBox9.TabStop = False
        PictureBox9.UseWaitCursor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = SystemColors.GradientActiveCaption
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Location = New Point(753, 149)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(275, 94)
        GroupBox3.TabIndex = 87
        GroupBox3.TabStop = False
        GroupBox3.UseWaitCursor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.Highlight
        Label9.Location = New Point(6, 59)
        Label9.Name = "Label9"
        Label9.Size = New Size(270, 21)
        Label9.TabIndex = 2
        Label9.Text = "Scheduled: April 21,2025 at 12:30 pm"
        Label9.UseWaitCursor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ControlLightLight
        Label10.Image = My.Resources.Resources._1e4477_solid_color_background_icolorpalette
        Label10.Location = New Point(8, 19)
        Label10.Name = "Label10"
        Label10.Size = New Size(82, 40)
        Label10.TabIndex = 0
        Label10.Text = "Tako"
        Label10.UseWaitCursor = True
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.Transparent
        PictureBox8.BackgroundImage = My.Resources.Resources.istockphoto_1069546882_612x612
        PictureBox8.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox8.BorderStyle = BorderStyle.FixedSingle
        PictureBox8.Location = New Point(622, 138)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(105, 105)
        PictureBox8.TabIndex = 86
        PictureBox8.TabStop = False
        PictureBox8.UseWaitCursor = True
        ' 
        ' Button12
        ' 
        Button12.BackgroundImage = My.Resources.Resources._1e4477_solid_color_background_icolorpalette1
        Button12.Font = New Font("Sitka Display", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button12.ForeColor = SystemColors.ControlLightLight
        Button12.Location = New Point(930, 361)
        Button12.Name = "Button12"
        Button12.Size = New Size(99, 30)
        Button12.TabIndex = 85
        Button12.Text = "Next"
        Button12.UseVisualStyleBackColor = True
        Button12.UseWaitCursor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.GradientInactiveCaption
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Location = New Point(753, 33)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(275, 94)
        GroupBox2.TabIndex = 84
        GroupBox2.TabStop = False
        GroupBox2.UseWaitCursor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = SystemColors.Highlight
        Label11.Location = New Point(6, 59)
        Label11.Name = "Label11"
        Label11.Size = New Size(269, 21)
        Label11.TabIndex = 2
        Label11.Text = "Scheduled: April 21,2025 at 11:00 am"
        Label11.UseWaitCursor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = SystemColors.ControlLightLight
        Label13.Image = My.Resources.Resources._1e4477_solid_color_background_icolorpalette
        Label13.Location = New Point(6, 19)
        Label13.Name = "Label13"
        Label13.Size = New Size(84, 40)
        Label13.TabIndex = 0
        Label13.Text = "Belle"
        Label13.UseWaitCursor = True
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImage = My.Resources.Resources.istockphoto_510059912_612x612
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.BorderStyle = BorderStyle.FixedSingle
        PictureBox3.Location = New Point(620, 22)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(107, 105)
        PictureBox3.TabIndex = 83
        PictureBox3.TabStop = False
        PictureBox3.UseWaitCursor = True
        ' 
        ' Button13
        ' 
        Button13.BackgroundImage = My.Resources.Resources._1e4477_solid_color_background_icolorpalette
        Button13.Font = New Font("Sitka Display", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button13.ForeColor = SystemColors.ControlLightLight
        Button13.Location = New Point(509, 360)
        Button13.Name = "Button13"
        Button13.Size = New Size(99, 30)
        Button13.TabIndex = 82
        Button13.Text = "View"
        Button13.UseVisualStyleBackColor = True
        Button13.UseWaitCursor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.GradientInactiveCaption
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Location = New Point(301, 161)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(301, 193)
        GroupBox1.TabIndex = 81
        GroupBox1.TabStop = False
        GroupBox1.UseWaitCursor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Green
        Label2.Location = New Point(10, 157)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 21)
        Label2.TabIndex = 4
        Label2.Text = "Bill: On-Hold"
        Label2.UseWaitCursor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.BorderStyle = BorderStyle.FixedSingle
        Label7.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ActiveCaption
        Label7.Location = New Point(6, 63)
        Label7.Name = "Label7"
        Label7.Size = New Size(226, 32)
        Label7.TabIndex = 3
        Label7.Text = "Owner: Juan Dela Cruz"
        Label7.UseWaitCursor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.Highlight
        Label6.Location = New Point(6, 136)
        Label6.Name = "Label6"
        Label6.Size = New Size(269, 21)
        Label6.TabIndex = 2
        Label6.Text = "Scheduled: April 21,2025 at 10:00 am"
        Label6.UseWaitCursor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.Highlight
        Label5.Location = New Point(6, 111)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 25)
        Label5.TabIndex = 1
        Label5.Text = "Check-up"
        Label5.UseWaitCursor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Image = My.Resources.Resources._1e4477_solid_color_background_icolorpalette1
        Label4.Location = New Point(6, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 40)
        Label4.TabIndex = 0
        Label4.Text = "Edgar"
        Label4.UseWaitCursor = True
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.Transparent
        PictureBox7.BackgroundImage = My.Resources.Resources.istockphoto_157653757_612x612
        PictureBox7.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox7.BorderStyle = BorderStyle.FixedSingle
        PictureBox7.Location = New Point(20, 80)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(275, 274)
        PictureBox7.TabIndex = 80
        PictureBox7.TabStop = False
        PictureBox7.UseWaitCursor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Sitka Heading", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ControlLightLight
        Label8.Location = New Point(20, 22)
        Label8.Name = "Label8"
        Label8.RightToLeft = RightToLeft.No
        Label8.Size = New Size(373, 53)
        Label8.TabIndex = 79
        Label8.Text = "Today's Appointment"
        Label8.UseWaitCursor = True
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.Transparent
        PictureBox6.BackgroundImage = My.Resources.Resources.icons8_billing_50
        PictureBox6.BackgroundImageLayout = ImageLayout.Center
        PictureBox6.Location = New Point(826, 42)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(112, 62)
        PictureBox6.TabIndex = 66
        PictureBox6.TabStop = False
        PictureBox6.UseWaitCursor = True
        ' 
        ' Button11
        ' 
        Button11.BackColor = Color.Transparent
        Button11.BackgroundImage = My.Resources.Resources.images8
        Button11.FlatAppearance.BorderSize = 0
        Button11.FlatStyle = FlatStyle.Flat
        Button11.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button11.ForeColor = SystemColors.ControlLightLight
        Button11.Location = New Point(780, 29)
        Button11.Name = "Button11"
        Button11.Size = New Size(207, 101)
        Button11.TabIndex = 65
        Button11.Text = "BILLING"
        Button11.TextAlign = ContentAlignment.BottomCenter
        Button11.UseVisualStyleBackColor = False
        Button11.UseWaitCursor = True
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.BackgroundImage = My.Resources.Resources.icons8_appointment_50
        PictureBox5.BackgroundImageLayout = ImageLayout.Center
        PictureBox5.Location = New Point(605, 42)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(103, 62)
        PictureBox5.TabIndex = 64
        PictureBox5.TabStop = False
        PictureBox5.UseWaitCursor = True
        ' 
        ' Button10
        ' 
        Button10.BackColor = Color.Transparent
        Button10.BackgroundImage = My.Resources.Resources.images7
        Button10.FlatAppearance.BorderSize = 0
        Button10.FlatStyle = FlatStyle.Flat
        Button10.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button10.ForeColor = SystemColors.ControlLightLight
        Button10.Location = New Point(550, 29)
        Button10.Name = "Button10"
        Button10.Size = New Size(207, 101)
        Button10.TabIndex = 63
        Button10.Text = "APPOINTMENT"
        Button10.TextAlign = ContentAlignment.BottomCenter
        Button10.UseVisualStyleBackColor = False
        Button10.UseWaitCursor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = My.Resources.Resources.icons8_pets_64
        PictureBox2.BackgroundImageLayout = ImageLayout.Center
        PictureBox2.Location = New Point(367, 47)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(120, 62)
        PictureBox2.TabIndex = 62
        PictureBox2.TabStop = False
        PictureBox2.UseWaitCursor = True
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.Transparent
        Button9.BackgroundImage = My.Resources.Resources.images6
        Button9.FlatAppearance.BorderSize = 0
        Button9.FlatStyle = FlatStyle.Flat
        Button9.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button9.ForeColor = SystemColors.ControlLightLight
        Button9.Location = New Point(323, 29)
        Button9.Name = "Button9"
        Button9.Size = New Size(207, 101)
        Button9.TabIndex = 61
        Button9.Text = "PETS"
        Button9.TextAlign = ContentAlignment.BottomCenter
        Button9.UseVisualStyleBackColor = False
        Button9.UseWaitCursor = True
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.BackgroundImage = My.Resources.Resources.icons8_users_501
        PictureBox4.BackgroundImageLayout = ImageLayout.Center
        PictureBox4.Location = New Point(140, 45)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(119, 62)
        PictureBox4.TabIndex = 60
        PictureBox4.TabStop = False
        PictureBox4.UseWaitCursor = True
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Transparent
        Button8.BackgroundImage = My.Resources.Resources.images5
        Button8.FlatAppearance.BorderSize = 0
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button8.ForeColor = SystemColors.ControlLightLight
        Button8.Location = New Point(98, 29)
        Button8.Name = "Button8"
        Button8.Size = New Size(207, 101)
        Button8.TabIndex = 59
        Button8.Text = "OWNERS"
        Button8.TextAlign = ContentAlignment.BottomCenter
        Button8.UseVisualStyleBackColor = False
        Button8.UseWaitCursor = True
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1348, 651)
        Controls.Add(pnlSub)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(pnlMain)
        FormBorderStyle = FormBorderStyle.None
        Name = "Main"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main"
        pnlSub.ResumeLayout(False)
        pnlSub.PerformLayout()
        pnlBilling.ResumeLayout(False)
        PnlAppointment.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        pnlMain.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSub As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents pnlBilling As Panel
    Friend WithEvents PnlAppointment As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PnlPets As Panel
    Friend WithEvents pnlPetOwners As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents pnlMain As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnAppointment As Button
    Friend WithEvents btnPets As Button
    Friend WithEvents btnPetOwners As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents btnBilling As Button
    Friend WithEvents lblTItle As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Button8 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button9 As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Button11 As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Button10 As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Button12 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button13 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label8 As Label
End Class
