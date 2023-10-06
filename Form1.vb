Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ListBox.Items.Add(TextBox1.Text.Trim)
        Label.Text = TextBox1.Text.Trim
    End Sub

    Private Sub ListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox.SelectedIndexChanged
        Dim word As String = ListBox.Text.Trim()
        If Not ListBox.Items.Contains(word) Then
            ListBox.Items.Add(word)
        Else
            MessageBox.Show("items already Exists")
        End If
    End Sub

    Private Sub RdToLower_CheckedChanged(sender As Object, e As EventArgs) Handles RdToLower.CheckedChanged
        Label.Text = Label.Text.ToLower()
    End Sub

    Private Sub RdToUpper_CheckedChanged(sender As Object, e As EventArgs) Handles RdToUpper.CheckedChanged
        Label.Text = Label.Text.ToUpper()
    End Sub

    Private Sub RdPurple_CheckedChanged(sender As Object, e As EventArgs) Handles RdPurple.CheckedChanged
        Label.ForeColor = Color.Purple
    End Sub

    Private Sub RdBlue_CheckedChanged(sender As Object, e As EventArgs) Handles RdBlue.CheckedChanged
        Label.ForeColor = Color.Blue
    End Sub
End Class
