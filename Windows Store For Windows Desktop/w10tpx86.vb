Public Class w10tpx86

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.TextBox1.Text = "http://go.microsoft.com/fwlink/?LinkId=510226"
        Form2.TextBox2.Text = "C:\Downloads\WindowsTechnicalPreview-x64-EN-US.iso"
        Form2.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.TextBox1.Text = "http://go.microsoft.com/fwlink/?LinkId=510228"
        Form2.TextBox2.Text = "C:\Downloads\WindowsTechnicalPreview-x64-EN-UK.iso"
        Form2.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.TextBox1.Text = "http://go.microsoft.com/fwlink/?LinkId=510230"
        Form2.TextBox2.Text = "C:\Downloads\WindowsTechnicalPreview-x64-ZH-CN.iso"
        Form2.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.TextBox1.Text = "http://go.microsoft.com/fwlink/?LinkId=510232"
        Form2.TextBox2.Text = "C:\Downloads\WindowsTechnicalPreview-x64-PT-BR.iso"
        Form2.ShowDialog()
    End Sub
End Class