<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pets
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
        DataGridView1 = New DataGridView()
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Button13 = New Button()
        Button1 = New Button()
        Label8 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(38, 119)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(1046, 389)
        DataGridView1.TabIndex = 77
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(254, 88)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(270, 23)
        TextBox1.TabIndex = 78
        TextBox1.Text = "Search..."
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(530, 88)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 79
        ComboBox1.Text = "Feline"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(657, 88)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(143, 23)
        ComboBox2.TabIndex = 80
        ComboBox2.Text = "Check-Up"
        ' 
        ' Button13
        ' 
        Button13.BackgroundImage = My.Resources.Resources._1e4477_solid_color_background_icolorpalette1
        Button13.Font = New Font("Sitka Display", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button13.ForeColor = SystemColors.ControlLightLight
        Button13.Location = New Point(984, 514)
        Button13.Name = "Button13"
        Button13.Size = New Size(99, 30)
        Button13.TabIndex = 81
        Button13.Text = "Edit"
        Button13.UseVisualStyleBackColor = True
        Button13.UseWaitCursor = True
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = My.Resources.Resources._1e4477_solid_color_background_icolorpalette1
        Button1.Font = New Font("Sitka Display", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(879, 514)
        Button1.Name = "Button1"
        Button1.Size = New Size(99, 30)
        Button1.TabIndex = 82
        Button1.Text = "View"
        Button1.UseVisualStyleBackColor = True
        Button1.UseWaitCursor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Sitka Heading", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ActiveCaption
        Label8.Location = New Point(38, 66)
        Label8.Name = "Label8"
        Label8.RightToLeft = RightToLeft.No
        Label8.Size = New Size(193, 47)
        Label8.TabIndex = 83
        Label8.Text = "Pet's Details"
        Label8.UseWaitCursor = True
        ' 
        ' Pets
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.colorful_gradient_abstract_background_colorful_pastel_design_vector2
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1167, 556)
        Controls.Add(Label8)
        Controls.Add(Button1)
        Controls.Add(Button13)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox1)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Pets"
        Text = "Pets"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button13 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
End Class
