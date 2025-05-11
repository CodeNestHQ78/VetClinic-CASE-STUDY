Public Class Login

    ' Replace with your desired size
    Dim users(,) As String = {{"VetTech1", "amogus"}, {"a", "a"}, {"admin", "admin123"}}

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Size = New Size(905, 470)
        Dim userIN As String = TextBox1.Text
        Dim passIN As String = TextBox2.Text
        Dim isValid As Boolean = False

        ' Loop through the array to check login credentials
        For i As Integer = 0 To users.GetLength(0) - 1
            If userIN = users(i, 0) AndAlso passIN = users(i, 1) Then
                isValid = True
                Exit For
            End If
        Next

        ' Handle login outcome AFTER loop completes
        If isValid Then
            Main.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password.")
        End If

        Main.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()
        End
    End Sub








End Class
