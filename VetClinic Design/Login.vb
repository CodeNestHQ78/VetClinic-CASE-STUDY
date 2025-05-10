Public Class Login

    ' Replace with your desired size


    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Size = New Size(905, 470)
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim iExit As DialogResult

        iExit = MessageBox.Show("Are you sure you want to exit?", "Veterinary Clinic System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            openCon()
            MsgBox("Connected!")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occurred!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End Try


    End Sub


End Class
