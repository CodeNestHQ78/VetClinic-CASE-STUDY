Public Class Main


    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Size = New Size(1348, 651)

        pnlMain.Controls.Clear()


        Dim frm As New DashBoard()


        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill


        pnlMain.Controls.Add(frm)
        frm.Show()

        lblTItle.Text = "DASHBOARD"


        pnlMain.Controls.Clear()


        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill

        pnlMain.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPetOwners.Click

        pnlMain.Controls.Clear()


        Dim frm As New PetOwners()


        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill


        pnlMain.Controls.Add(frm)
        frm.Show()

        lblTItle.Text = "PET OWNERS"

        pnlMain.Controls.Clear()


        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill

        pnlMain.Controls.Add(frm)
        frm.Show()
    End Sub



    Private Sub btnPets_Click(sender As Object, e As EventArgs) Handles btnPets.Click

        pnlMain.Controls.Clear()


        Dim frm As New Pets()


        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill


        pnlMain.Controls.Add(frm)
        frm.Show()

        lblTItle.Text = "PETS"

        pnlMain.Controls.Clear()


        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill

        pnlMain.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub btnAppointment_Click(sender As Object, e As EventArgs) Handles btnAppointment.Click

        pnlMain.Controls.Clear()


        Dim frm As New Appointment()


        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill


        pnlMain.Controls.Add(frm)
        frm.Show()

        lblTItle.Text = "APPOINTMENT"

        pnlMain.Controls.Clear()


        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill

        pnlMain.Controls.Add(frm)
        frm.Show()
    End Sub


    Private Sub btnBilling_Click(sender As Object, e As EventArgs) Handles btnBilling.Click

        pnlMain.Controls.Clear()


        Dim frm As New Billing()


        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill


        pnlMain.Controls.Add(frm)
        frm.Show()

        lblTItle.Text = "BILLING"

        pnlMain.Controls.Clear()


        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill

        pnlMain.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        pnlMain.Controls.Clear()


        Dim frm As New PetOwners()


        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill


        pnlMain.Controls.Add(frm)
        frm.Show()

        lblTItle.Text = "PET OWNERS"

        pnlMain.Controls.Clear()


        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill

        pnlMain.Controls.Add(frm)
        frm.Show()
    End Sub


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        pnlMain.Controls.Clear()


        Dim frm As New Pets()


        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill


        pnlMain.Controls.Add(frm)
        frm.Show()

        lblTItle.Text = "PETS"

        pnlMain.Controls.Clear()


        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill

        pnlMain.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        pnlMain.Controls.Clear()


        Dim frm As New Appointment()


        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill


        pnlMain.Controls.Add(frm)
        frm.Show()

        lblTItle.Text = "APPOINTMENT"

        pnlMain.Controls.Clear()


        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill

        pnlMain.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        pnlMain.Controls.Clear()


        Dim frm As New Billing()


        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill


        pnlMain.Controls.Add(frm)
        frm.Show()

        lblTItle.Text = "BILLING"

        pnlMain.Controls.Clear()


        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill

        pnlMain.Controls.Add(frm)
        frm.Show()
    End Sub
End Class