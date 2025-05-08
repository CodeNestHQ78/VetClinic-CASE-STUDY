Public Class Billing
    ' Structure para sa billing info ng mga pets
    Structure BillingInfo
        Public OwnerName As String
        Public PetName As String
        Public PetType As String
        Public IsCheckUp As Boolean
        Public IsVaccine As Boolean
        Public BillAmount As String
    End Structure

    ' Array para sa mga billing records at counters
    Dim billingRecords(99) As BillingInfo
    Dim recordCount As Integer = 0
    Dim currentIndex As Integer = -1

    Private WithEvents ListView1 As ListView

    Private Sub Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox2.Items.Clear()
        ComboBox2.Items.AddRange({"Feline", "Canine"})
        ComboBox2.SelectedIndex = 0

        ComboBox3.Items.Clear()
        ComboBox3.Items.AddRange({"400₱", "500₱", "1000₱", "1500₱"})
        ComboBox3.SelectedIndex = 0

        ComboBox1.Items.Clear()
        ComboBox1.Items.AddRange({"Feline", "Canine"})
        ComboBox1.SelectedIndex = 0

        Button5.Enabled = False ' Edit button
        Button1.Enabled = False ' View button

        ListView1 = DirectCast(Me.Controls.Find("ListView1", True).FirstOrDefault(), ListView)

        If ListView1 Is Nothing Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is ListView Then
                    ListView1 = DirectCast(ctrl, ListView)
                    Exit For
                End If
            Next
        End If

        If ListView1 Is Nothing Then
            ListView1 = New ListView()
            ListView1.Name = "ListView1"
            ListView1.Location = New Point(370, 115)
            ListView1.Size = New Size(610, 440)
            ListView1.View = View.Details
            ListView1.FullRowSelect = True
            ListView1.GridLines = True

            ListView1.Columns.Add("Owner", 120)
            ListView1.Columns.Add("Pet Name", 100)
            ListView1.Columns.Add("Pet Type", 100)
            ListView1.Columns.Add("Check-Up", 80)
            ListView1.Columns.Add("Vaccine", 80)
            ListView1.Columns.Add("Bill Amount", 100)

            Me.Controls.Add(ListView1)
        End If

        recordCount = 0 ' Ensure no records exist

        DisplayAllRecords()
    End Sub

    ' Wala nang sample records dito
    Private Sub AddSampleData()
    End Sub

    ' Para i-display lahat ng records sa ListView
    Private Sub DisplayAllRecords()
        If ListView1 IsNot Nothing Then
            ListView1.Items.Clear()

            For i As Integer = 0 To recordCount - 1
                Dim item As New ListViewItem(billingRecords(i).OwnerName)
                item.SubItems.Add(billingRecords(i).PetName)
                item.SubItems.Add(billingRecords(i).PetType)
                item.SubItems.Add(If(billingRecords(i).IsCheckUp, "Yes", "No"))
                item.SubItems.Add(If(billingRecords(i).IsVaccine, "Yes", "No"))
                item.SubItems.Add(billingRecords(i).BillAmount)
                item.Tag = i ' Store index para sa reference
                ListView1.Items.Add(item)
            Next
        End If
    End Sub

    ' Para i-filter ang records base sa search
    Private Sub FilterRecords()
        If ListView1 IsNot Nothing Then
            ListView1.Items.Clear()
            Dim searchText As String = TextBox1.Text.Trim().ToLower()
            Dim selectedPetType As String = ComboBox1.SelectedItem.ToString()

            For i As Integer = 0 To recordCount - 1
                ' Filter gamit ang pangalan at pet type
                If billingRecords(i).OwnerName.ToLower().Contains(searchText) AndAlso
                   (selectedPetType = "All" OrElse billingRecords(i).PetType = selectedPetType) Then
                    Dim item As New ListViewItem(billingRecords(i).OwnerName)
                    item.SubItems.Add(billingRecords(i).PetName)
                    item.SubItems.Add(billingRecords(i).PetType)
                    item.SubItems.Add(If(billingRecords(i).IsCheckUp, "Yes", "No"))
                    item.SubItems.Add(If(billingRecords(i).IsVaccine, "Yes", "No"))
                    item.SubItems.Add(billingRecords(i).BillAmount)
                    item.Tag = i ' Para sa reference
                    ListView1.Items.Add(item)
                End If
            Next
        End If
    End Sub

    Private Sub ClearFields()
        TextBox4.Clear() ' Owner name
        TextBox2.Clear() ' Pet name
        ComboBox2.SelectedIndex = 0 ' Pet type
        CheckBox1.Checked = False ' Check-up
        CheckBox2.Checked = False ' Vaccine
        ComboBox3.SelectedIndex = 0 ' Bill amount
    End Sub

    Private Sub LoadRecordToForm(index As Integer)
        If index >= 0 AndAlso index < recordCount Then
            TextBox4.Text = billingRecords(index).OwnerName
            TextBox2.Text = billingRecords(index).PetName
            ComboBox2.SelectedItem = billingRecords(index).PetType
            CheckBox1.Checked = billingRecords(index).IsCheckUp
            CheckBox2.Checked = billingRecords(index).IsVaccine
            ComboBox3.SelectedItem = billingRecords(index).BillAmount
            currentIndex = index ' Update current index
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        UpdateBillBasedOnServices()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        UpdateBillBasedOnServices()
    End Sub

    ' I-update yung bill based sa services na pinili
    ' I-update yung bill based sa services na pinili
    Private Sub UpdateBillBasedOnServices()
        Dim petType As String = ComboBox2.SelectedItem.ToString()
        Dim bill As Integer = 0

        If CheckBox1.Checked Then ' Check-up
            bill += If(petType = "Feline", 500, 400)
        End If

        If CheckBox2.Checked Then ' Vaccine
            bill += If(petType = "Feline", 1000, 1500)
        End If

        ComboBox3.SelectedItem = bill.ToString() & "₱"
    End Sub

    ' 🔄 Add this BELOW the method above
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        UpdateBillBasedOnServices()
    End Sub



    ' Save button - para mag-save ng bagong record o mag-update
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ' Checking kung may laman ang mga fields
        If String.IsNullOrWhiteSpace(TextBox4.Text) OrElse String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MessageBox.Show("Please enter both owner and pet names.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If currentIndex >= 0 Then
            billingRecords(currentIndex).OwnerName = TextBox4.Text
            billingRecords(currentIndex).PetName = TextBox2.Text
            billingRecords(currentIndex).PetType = ComboBox2.SelectedItem.ToString()
            billingRecords(currentIndex).IsCheckUp = CheckBox1.Checked
            billingRecords(currentIndex).IsVaccine = CheckBox2.Checked
            billingRecords(currentIndex).BillAmount = ComboBox3.SelectedItem.ToString()

            MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            currentIndex = -1
        Else
            If recordCount < billingRecords.Length Then
                billingRecords(recordCount).OwnerName = TextBox4.Text
                billingRecords(recordCount).PetName = TextBox2.Text
                billingRecords(recordCount).PetType = ComboBox2.SelectedItem.ToString()
                billingRecords(recordCount).IsCheckUp = CheckBox1.Checked
                billingRecords(recordCount).IsVaccine = CheckBox2.Checked
                billingRecords(recordCount).BillAmount = ComboBox3.SelectedItem.ToString()

                recordCount += 1
                MessageBox.Show("Record saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Maximum record limit reached.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        ClearFields()
        DisplayAllRecords()
        Button5.Enabled = False ' Disable Edit button
        Button1.Enabled = False ' Disable View button
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        FilterRecords()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        FilterRecords()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ListView1 IsNot Nothing AndAlso ListView1.SelectedItems.Count > 0 Then
            Dim index As Integer = CInt(ListView1.SelectedItems(0).Tag)
            LoadRecordToForm(index)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListView1 IsNot Nothing AndAlso ListView1.SelectedItems.Count > 0 Then
            Dim index As Integer = CInt(ListView1.SelectedItems(0).Tag)
            Dim record As BillingInfo = billingRecords(index)

            Dim details As String = "Owner: " & record.OwnerName & vbCrLf &
                                   "Pet Name: " & record.PetName & vbCrLf &
                                   "Pet Type: " & record.PetType & vbCrLf &
                                   "Check-Up: " & If(record.IsCheckUp, "Yes", "No") & vbCrLf &
                                   "Vaccine: " & If(record.IsVaccine, "Yes", "No") & vbCrLf &
                                   "Bill Amount: " & record.BillAmount

            MessageBox.Show(details, "Billing Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' ListView selection - para ma-enable ang edit at view buttons kapag may napili
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Button5.Enabled = (ListView1.SelectedItems.Count > 0) ' Enable Edit button pag may napili
        Button1.Enabled = (ListView1.SelectedItems.Count > 0) ' Enable View button pag may napili
    End Sub
End Class
