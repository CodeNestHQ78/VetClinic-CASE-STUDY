Imports System.Configuration
Imports System.IO
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml

Public Class PetOwners
    'sex variable to handle the value of when you click the radiobutton and what you click go to database
    Dim sex As String
    ''genderBind variable to bind the value of the radiobutton this will be putting the txtGenderBind.text
    Dim sexBind As String
    Private Sub PetOwners_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Para hindi makita yung textbox sa mismong UI natin
        txtsexBind.Visible = False
        txtID.Visible = False
        'To load the table sa datagridview natin
        loadTable()

    End Sub

    Private Sub radMale_CheckedChanged(sender As Object, e As EventArgs) Handles radMale.CheckedChanged
        sex = "Male"
    End Sub

    Private Sub radFemale_CheckedChanged(sender As Object, e As EventArgs) Handles radFemale.CheckedChanged
        sex = "Female"
    End Sub

    'Fucntion to validate the input and error handling 
    Function ValidateInputs() As Boolean
        Dim age As Integer

        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Please enter owner's name!", "Validation", MessageBoxButtons.OK)
            Return False
        End If
        'Pag may number o special character (like @, #), mag-e-error sya
        If IsNumeric(txtName.Text) Or System.Text.RegularExpressions.Regex.IsMatch(txtName.Text, "^\d+$") Then
            MessageBox.Show("Please enter letters only", "Invalid Input", MessageBoxButtons.OK)
            txtName.Clear()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtAge.Text) Then
            MessageBox.Show("Please enter age.", "Validation", MessageBoxButtons.OK)
            Return False
        End If
        'Pag may letters o special character (like @, #), mag-e-error sya
        If Not Integer.TryParse(txtAge.Text, age) Or Not System.Text.RegularExpressions.Regex.IsMatch(txtAge.Text, "^\d+$") Then
            MessageBox.Show("Age must be a number!", "Invalid input", MessageBoxButtons.OK)
            txtAge.Clear()
            Return False
        End If
        'linagyan ko ng limit yung age hanggang 1 - 120 lang 
        If Not Integer.TryParse(txtAge.Text, age) Or age < 1 Or age > 120 Then
            MessageBox.Show("Please enter a valid age between 1 and 120!", "Validation", MessageBoxButtons.OK)
            Return False
        End If
        If Not radMale.Checked And Not radFemale.Checked Then
            MessageBox.Show("Please select gender.", "Validation", MessageBoxButtons.OK)
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtContact.Text) Then
            MessageBox.Show("Please enter contact number", "Contact", MessageBoxButtons.OK)
            Return False
        End If
        'Using RegEx to use only numbers. Pag may letters o symbols mag eerror
        If Not System.Text.RegularExpressions.Regex.IsMatch(txtContact.Text, "^\d+$") Then
            MessageBox.Show("Contact number should contain only numbers", "Validation", MessageBoxButtons.OK)
            txtContact.Clear()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtAddress.Text) Then
            MessageBox.Show("Please enter address.", "Address", MessageBoxButtons.OK)
            Return False
        End If
        'Dito pwede lahat mapa special character pero hindi sya pwede all numbers lang 
        If System.Text.RegularExpressions.Regex.IsMatch(txtAddress.Text, "^\d+$") Then
            MessageBox.Show("It should not contain only numbers", "Invalid Input", MessageBoxButtons.OK)
            txtAddress.Clear()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtPetName.Text) Then
            MessageBox.Show("Please enter pet name", "Pet Name", MessageBoxButtons.OK)
            Return False
        End If
        If IsNumeric(txtPetName.Text) Or Not System.Text.RegularExpressions.Regex.IsMatch(txtPetName.Text, "^\w+$") Then
            MessageBox.Show("Please enter letters only", "Invalid Input", MessageBoxButtons.OK)
            Return False
        End If
        If cmbPetType.SelectedItem = Nothing Then
            MessageBox.Show("Please select pet type", "Pet Type", MessageBoxButtons.OK)
            Return False
        End If

        'Kapag nag true yung mga validation and error isasave nya na sa database
        'pero kapag hinde mag eeror kung ano yung mali
        Return True
    End Function



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'validate yung mga inimput mo then kapag nag fails sya edi irereturn nya lang
        If Not ValidateInputs() Then
            Return
        End If

        Try
            'To initialize the connection
            cmd.Connection = con
            'This command text dito natin lagay yung sql query natin for insert info
            'Insert into this is where you put the table name and the values
            cmd.CommandText = "INSERT INTO vet_clinic(`Name`, `Age`, `Sex`, `Contact`, `Address`, `PetName`,`PetType`) 
             VALUES ( '" & txtName.Text & "', '" & txtAge.Text & "', '" & sex & "', '" & txtContact.Text & "', '" & txtAddress.Text & "',
               '" & txtPetName.Text & "', '" & cmbPetType.SelectedItem & "') "

            openCon()
            'To excute the commandtext
            cmd.ExecuteNonQuery()
            'To inform us that the data is successfully added
            MsgBox("Successfully Added Record!")

            'clear fields
            con.Close()
            txtName.Clear()
            txtAge.Clear()
            radMale.Checked = False
            radFemale.Checked = False
            txtContact.Clear()
            txtAddress.Clear()
            txtPetName.Clear()
            cmbPetType.SelectedItem = Nothing
            'Automatic na mag refresh yung datagridview natin kapag nag insert tayo ulet ng bagong record
            loadTable()

        Catch ex As Exception
            'To inform us what will be the error
            MessageBox.Show(ex.Message, "Error Occurred!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try


    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            'condition para kapag si txtSearch eh empty Or wala tayong nilagay na value iki-clear nya yung mga controls
            'note iba yung databindings clear sa txtname.clear, Databindings clear is to clear the data sa dataset while txt.clear is to clear the text in the textbox

            ' Check nya if may laman ba Or wala yung seachbox natin kapag walang laman iki-clear nya yung mga controls tapos babalik nya sa dati yung mga record 
            If String.IsNullOrWhiteSpace(txtSearch.Text) Then
                txtName.Clear()
                txtAge.Clear()
                radMale.Checked = False
                radFemale.Checked = False
                txtContact.Clear()
                txtAddress.Clear()
                txtPetName.Clear()
                cmbPetType.SelectedItem = Nothing
                txtsexBind.Clear()
                loadTable()
                Return
            End If

            ApplyFilters()
            'Get the commandtext and e-execute nya
            adapter.SelectCommand = cmd
            'Need natin i-clear bago tayo mag lagay ulet ng panibagong data
            data.Clear()
            'Dito papasok yung data na galing sa database then eto yung name
            'Imaginary data set wherein List gets all the data na nakuha ni adapter(method) sa record tapos ilalagay nya sa kanya which is si List
            adapter.Fill(data, "List")

            'Databindings gets the data in the data set and binds it to the controls
            'first parameter need natin identify kung anong kind na data yung kukunin natin "Text"
            txtName.DataBindings.Add("Text", data, "List.Name")
            'need to clear the databindings because have different value ang isang data for us to get the new value
            txtName.DataBindings.Clear()

            txtAge.DataBindings.Add("Text", data, "List.Age")
            txtAge.DataBindings.Clear()

            'Third parameter is the name of the column in the database
            txtsexBind.DataBindings.Add("Text", data, "List.Sex")
            txtsexBind.DataBindings.Clear()
            'Nakuha natin yung value ni txtsexBind gamit yung databindings 
            'Dito eh ilalagay natin si txtsexBind sa variable na sexBind dahil si sexBind sya yung maghahandle ng value 
            sexBind = txtsexBind.Text

            'Gumamit ako ng condition dito para ma check natin kung anong value ni sexBind tapos palalabasin nya sa control
            If sexBind = "Male" Then
                radMale.Checked = True
            ElseIf sexBind = "Female" Then
                radFemale.Checked = True
            End If

            txtContact.DataBindings.Add("Text", data, "List.Contact")
            txtContact.DataBindings.Clear()

            txtAddress.DataBindings.Add("Text", data, "List.Address")
            txtAddress.DataBindings.Clear()

            txtPetName.DataBindings.Add("Text", data, "List.PetName")
            txtPetName.DataBindings.Clear()

            cmbPetType.DataBindings.Add("Text", data, "List.PetType")
            cmbPetType.DataBindings.Clear()



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occurred!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    'Gumamit ako ng nitong function para hindi ko na ulitin yung code sa pag search at pag select kung anong type ba sya 
    'Agng purpose nito e para magamit ko ng sabay yung seach and combobox
    Private Sub ApplyFilters()
        Try
            'Dito e kinukuha nya yung pinili mong pet sa combobox
            Dim selectedType As String = If(ComboBox1.SelectedItem, "").ToString()
            'Get the name that you type in the txtsearch
            Dim searchName As String = txtSearch.Text.Trim()

            cmd.Connection = con

            cmd.CommandText = "SELECT * FROM vet_clinic WHERE (PetType = @PetType OR @PetType = '') AND (Name LIKE @SearchName OR @SearchName = '') "
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@PetType", selectedType)
            cmd.Parameters.AddWithValue("@SearchName", "%" & searchName & "%")

            'Gumawa ako ng datatable para dun ko ilagay yung mga record galing sa database, tas i-aasign ko to dun sa datagridview
            Dim dt As New DataTable()
            adapter.SelectCommand = cmd
            adapter.Fill(dt)
            dgvOwnersdetails.DataSource = dt


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occurred!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub ComboBox1_DropDown(sender As Object, e As EventArgs) Handles ComboBox1.DropDown

        ApplyFilters()

    End Sub
    'Method na to para kunin yung mga record sa database at ilalagay nya ito sa mga controls
    Private Sub BindControls(row As DataRow)
        txtName.Text = row("Name").ToString()
        txtAge.Text = row("Age").ToString()

        'Dito hinahandle nya yung sa gender
        sex = row("Sex").ToString()
        If sex = "Male" Then
            radMale.Checked = True

        ElseIf sex = "Female" Then
            radFemale.Checked = True
        End If

        txtContact.Text = row("Contact").ToString()
        txtAddress.Text = row("Address").ToString()
        txtPetName.Text = row("PetName").ToString()
        cmbPetType.Text = row("PetType").ToString()
    End Sub


    'To get the record from the table and magiging part pa rin dito si adapter kase sya yung responsible sa pag fetch ng data sa database
    Sub loadTable()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM vet_clinic"
            adapter.SelectCommand = cmd
            Table.Clear()
            adapter.Fill(Table)
            dgvOwnersdetails.DataSource = Table
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occurred!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


    'get the records na nasa datagridview when double click
    Private Sub dgvOwnersdetails_DoubleClick(sender As Object, e As EventArgs) Handles dgvOwnersdetails.DoubleClick
        'eto yung hahanapin ni delete function at update function para maupadate okaya naman makapag delete
        txtID.Text = dgvOwnersdetails.Item("ID", dgvOwnersdetails.CurrentRow.Index).Value

        'sa loob ng item kuhanin natin sa column name sa datagridview tapos ilalabas nya sa control
        txtName.Text = dgvOwnersdetails.Item("Name", dgvOwnersdetails.CurrentRow.Index).Value
        txtAge.Text = dgvOwnersdetails.Item("Age", dgvOwnersdetails.CurrentRow.Index).Value
        txtContact.Text = dgvOwnersdetails.Item("Contact", dgvOwnersdetails.CurrentRow.Index).Value
        txtAddress.Text = dgvOwnersdetails.Item("Address", dgvOwnersdetails.CurrentRow.Index).Value
        txtPetName.Text = dgvOwnersdetails.Item("PetName", dgvOwnersdetails.CurrentRow.Index).Value
        cmbPetType.Text = dgvOwnersdetails.Item("PetType", dgvOwnersdetails.CurrentRow.Index).Value
        'Handle the value sa datagridview
        Dim s As String

        s = dgvOwnersdetails.Item("Sex", dgvOwnersdetails.CurrentRow.Index).Value


        If s = "Male" Then
            radMale.Checked = True
        ElseIf s = "Female" Then
            radFemale.Checked = True
        End If

        txtSearch.Text = dgvOwnersdetails.Item("Name", dgvOwnersdetails.CurrentRow.Index).Value

    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Not ValidateInputs() Then
            Return
        End If
        'Same as INSERT FUCNTION ang dumagdag lang e yung WHERE CLAUSE kapag walang ganto ang mangyayari dyan e mag a-update lahat ng nasa datagrid mo at tsaka sa database mo
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE vet_clinic SET Name = '" & txtName.Text & "', Age = '" & txtAge.Text & "', Sex = '" & sex & "',
                Contact = '" & txtContact.Text & "', Address = '" & txtAddress.Text & "',PetName = '" & txtPetName.Text & "', PetType = '" & cmbPetType.SelectedItem & "'
                WHERE ID = @ID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@ID", txtID.Text)

            'Execute the update command
            openCon()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Successfully Updated Record!")

            Call loadTable()
            txtName.Clear()
            txtAge.Clear()
            radMale.Checked = False
            radFemale.Checked = False
            txtContact.Clear()
            txtAddress.Clear()
            txtPetName.Clear()
            cmbPetType.SelectedItem = Nothing
            txtsexBind.Clear()
            txtSearch.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occurred!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


    'Code para sa pagdelete gawin yun ID na nasa txtID.text
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        '"DELETE FROM vet_clinic eto yung pag delete sa database table natin
        'WHERE ID = @ID" eto naman dedelete nya yung record na match sa id na nilagay mo or double click mo
        Try
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM vet_clinic WHERE ID = @ID"
            cmd.Parameters.Clear()
            'Kinukuha yung ID mula dun sa txtID.Text natin tapos pinapasa sa SQL command
            cmd.Parameters.AddWithValue("@ID", txtID.Text)

            If MessageBox.Show("Are you sure you want to delete this record?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                'E-execute nya na yung deletion
                openCon()
                cmd.ExecuteNonQuery()
                con.Close()
                'notify natin si user
                MsgBox("Successfully Deleted Record!")
            Else
                Return
            End If
            'Kapag na successfully deleted na sya eh clear nya yung mga controls
            Call loadTable()
            txtName.Clear()
            txtAge.Clear()
            radMale.Checked = False
            radFemale.Checked = False
            txtContact.Clear()
            txtAddress.Clear()
            txtPetName.Clear()
            cmbPetType.SelectedItem = Nothing
            txtsexBind.Clear()
            txtSearch.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occurred!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class