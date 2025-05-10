<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PetOwners
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
        btnDelete = New Button()
        btnUpdate = New Button()
        Label10 = New Label()
        ComboBox1 = New ComboBox()
        txtSearch = New TextBox()
        dgvOwnersdetails = New DataGridView()
        Panel1 = New Panel()
        txtID = New TextBox()
        txtsexBind = New TextBox()
        PictureBox1 = New PictureBox()
        txtContact = New TextBox()
        Label1 = New Label()
        txtPetName = New TextBox()
        Label7 = New Label()
        btnAdd = New Button()
        cmbPetType = New ComboBox()
        Label4 = New Label()
        txtAddress = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        radFemale = New RadioButton()
        radMale = New RadioButton()
        txtAge = New TextBox()
        Label5 = New Label()
        txtName = New TextBox()
        Username = New Label()
        Label6 = New Label()
        CType(dgvOwnersdetails, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Sitka Display", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = SystemColors.ControlLightLight
        btnDelete.Image = My.Resources.Resources._1e4477_solid_color_background_icolorpalette
        btnDelete.Location = New Point(987, 523)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(99, 30)
        btnDelete.TabIndex = 77
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        btnDelete.UseWaitCursor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Sitka Display", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = SystemColors.ControlLightLight
        btnUpdate.Image = My.Resources.Resources._1e4477_solid_color_background_icolorpalette
        btnUpdate.Location = New Point(882, 523)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(99, 30)
        btnUpdate.TabIndex = 76
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        btnUpdate.UseWaitCursor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ActiveCaption
        Label10.Location = New Point(412, 57)
        Label10.Name = "Label10"
        Label10.Size = New Size(273, 37)
        Label10.TabIndex = 75
        Label10.Text = "Manage Pet Owners"
        Label10.TextAlign = ContentAlignment.TopCenter
        Label10.UseWaitCursor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Feline", "Reptile", "Canine"})
        ComboBox1.Location = New Point(970, 72)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(116, 23)
        ComboBox1.TabIndex = 74
        ComboBox1.Text = "Type"
        ComboBox1.UseWaitCursor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(691, 71)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(273, 23)
        txtSearch.TabIndex = 73
        txtSearch.Text = "Search..."
        txtSearch.UseWaitCursor = True
        ' 
        ' dgvOwnersdetails
        ' 
        dgvOwnersdetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvOwnersdetails.Location = New Point(412, 105)
        dgvOwnersdetails.Name = "dgvOwnersdetails"
        dgvOwnersdetails.Size = New Size(674, 412)
        dgvOwnersdetails.TabIndex = 72
        dgvOwnersdetails.UseWaitCursor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.images10
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(txtID)
        Panel1.Controls.Add(txtsexBind)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(txtContact)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtPetName)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(btnAdd)
        Panel1.Controls.Add(cmbPetType)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txtAddress)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(radFemale)
        Panel1.Controls.Add(radMale)
        Panel1.Controls.Add(txtAge)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txtName)
        Panel1.Controls.Add(Username)
        Panel1.Controls.Add(Label6)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(383, 595)
        Panel1.TabIndex = 78
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(80, 25)
        txtID.Name = "txtID"
        txtID.Size = New Size(59, 23)
        txtID.TabIndex = 106
        txtID.UseWaitCursor = True
        ' 
        ' txtsexBind
        ' 
        txtsexBind.Location = New Point(334, 572)
        txtsexBind.Name = "txtsexBind"
        txtsexBind.Size = New Size(59, 23)
        txtsexBind.TabIndex = 103
        txtsexBind.UseWaitCursor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.icons8_select_users_48
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(23, 72)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(63, 62)
        PictureBox1.TabIndex = 102
        PictureBox1.TabStop = False
        ' 
        ' txtContact
        ' 
        txtContact.Location = New Point(143, 264)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(185, 23)
        txtContact.TabIndex = 101
        txtContact.UseWaitCursor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Sitka Heading", 18F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(22, 258)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 35)
        Label1.TabIndex = 100
        Label1.Text = "Contact #"
        Label1.UseWaitCursor = True
        ' 
        ' txtPetName
        ' 
        txtPetName.Location = New Point(144, 347)
        txtPetName.Name = "txtPetName"
        txtPetName.Size = New Size(185, 23)
        txtPetName.TabIndex = 99
        txtPetName.UseWaitCursor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Sitka Heading", 18F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.ControlLightLight
        Label7.Location = New Point(22, 380)
        Label7.Name = "Label7"
        Label7.Size = New Size(115, 35)
        Label7.TabIndex = 98
        Label7.Text = "Pet Type:"
        Label7.UseWaitCursor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.BackgroundImage = My.Resources.Resources._1e4477_solid_color_background_icolorpalette
        btnAdd.Font = New Font("Sitka Display", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = SystemColors.ControlLightLight
        btnAdd.Location = New Point(22, 447)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(319, 39)
        btnAdd.TabIndex = 97
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        btnAdd.UseWaitCursor = True
        ' 
        ' cmbPetType
        ' 
        cmbPetType.FormattingEnabled = True
        cmbPetType.Items.AddRange(New Object() {"Feline", "Reptile", "Canine"})
        cmbPetType.Location = New Point(144, 392)
        cmbPetType.Name = "cmbPetType"
        cmbPetType.Size = New Size(102, 23)
        cmbPetType.TabIndex = 96
        cmbPetType.UseWaitCursor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Sitka Heading", 18F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(22, 335)
        Label4.Name = "Label4"
        Label4.Size = New Size(125, 35)
        Label4.TabIndex = 95
        Label4.Text = "Pet Name:"
        Label4.UseWaitCursor = True
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(144, 301)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(185, 23)
        txtAddress.TabIndex = 94
        txtAddress.UseWaitCursor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Sitka Heading", 18F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(23, 295)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 35)
        Label3.TabIndex = 93
        Label3.Text = "Address:"
        Label3.UseWaitCursor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Sitka Heading", 18F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(23, 223)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 35)
        Label2.TabIndex = 92
        Label2.Text = "Sex:"
        Label2.UseWaitCursor = True
        ' 
        ' radFemale
        ' 
        radFemale.AutoSize = True
        radFemale.BackColor = Color.Transparent
        radFemale.Font = New Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        radFemale.ForeColor = SystemColors.ControlLightLight
        radFemale.Location = New Point(231, 228)
        radFemale.Name = "radFemale"
        radFemale.Size = New Size(75, 27)
        radFemale.TabIndex = 91
        radFemale.TabStop = True
        radFemale.Text = "Female"
        radFemale.UseVisualStyleBackColor = False
        radFemale.UseWaitCursor = True
        ' 
        ' radMale
        ' 
        radMale.AutoSize = True
        radMale.BackColor = Color.Transparent
        radMale.Font = New Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        radMale.ForeColor = SystemColors.ControlLightLight
        radMale.Location = New Point(144, 228)
        radMale.Name = "radMale"
        radMale.Size = New Size(60, 27)
        radMale.TabIndex = 90
        radMale.TabStop = True
        radMale.Text = "Male"
        radMale.UseVisualStyleBackColor = False
        radMale.UseWaitCursor = True
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(144, 190)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(59, 23)
        txtAge.TabIndex = 89
        txtAge.UseWaitCursor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Sitka Heading", 18F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(22, 178)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 35)
        Label5.TabIndex = 88
        Label5.Text = "Age:"
        Label5.UseWaitCursor = True
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(144, 154)
        txtName.Name = "txtName"
        txtName.Size = New Size(185, 23)
        txtName.TabIndex = 87
        txtName.UseWaitCursor = True
        ' 
        ' Username
        ' 
        Username.AutoSize = True
        Username.BackColor = Color.Transparent
        Username.Font = New Font("Sitka Heading", 18F, FontStyle.Bold)
        Username.ForeColor = SystemColors.ControlLightLight
        Username.Location = New Point(22, 142)
        Username.Name = "Username"
        Username.Size = New Size(84, 35)
        Username.TabIndex = 86
        Username.Text = "Name:"
        Username.UseWaitCursor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Sitka Heading", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(91, 87)
        Label6.Name = "Label6"
        Label6.Size = New Size(221, 47)
        Label6.TabIndex = 85
        Label6.Text = "Owner Details"
        Label6.TextAlign = ContentAlignment.TopCenter
        Label6.UseWaitCursor = True
        ' 
        ' PetOwners
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.colorful_gradient_abstract_background_colorful_pastel_design_vector1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1183, 595)
        Controls.Add(Panel1)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(Label10)
        Controls.Add(ComboBox1)
        Controls.Add(txtSearch)
        Controls.Add(dgvOwnersdetails)
        FormBorderStyle = FormBorderStyle.None
        Name = "PetOwners"
        Text = "PetOwners"
        CType(dgvOwnersdetails, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvOwnersdetails As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPetName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents cmbPetType As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Username As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtsexBind As TextBox
    Friend WithEvents txtID As TextBox
End Class
