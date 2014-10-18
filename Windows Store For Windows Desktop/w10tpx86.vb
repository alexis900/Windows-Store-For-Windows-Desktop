Public Class w10tpx86

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.TextBox1.Text = "http://go.microsoft.com/fwlink/?LinkId=510226"
        Form2.TextBox2.Text = "C:\Downloads\WindowsTechnicalPreview-x86-EN-US.iso"
        Form2.ShowDialog()
    End Sub
End Class