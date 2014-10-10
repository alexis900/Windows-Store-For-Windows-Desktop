Public Class WindowsVer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.TextBox1.Text = "http://go.microsoft.com/fwlink/?LinkId=510225"
        Form2.TextBox2.Text = "C:\Downloads\WindowsTechnicalPreview-x64-EN-US.iso"
        Form2.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.TextBox1.Text = "http://go.microsoft.com/fwlink/?LinkId=510226"
        Form2.TextBox2.Text = "C:\Downloads\WindowsTechnicalPreview-x86-EN-US.iso"
        Form2.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Copy()
        MsgBox("The key is in the clipboard, paste in the installator")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim webAddress As String = "http://windows.microsoft.com/en-us/windows/preview"
        Process.Start(webAddress)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim webAddress As String = "http://windows.microsoft.com/en-us/windows/preview"
        Process.Start(webAddress)
    End Sub
End Class