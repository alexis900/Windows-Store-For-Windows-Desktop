Public Class w10tpx64

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.TextBox1.Text = "http://go.microsoft.com/fwlink/?LinkId=510225"
        Form2.TextBox2.Text = "C:\Downloads\WindowsTechnicalPreview-x64-EN-US.iso"
        Form2.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.TextBox1.Text = "http://go.microsoft.com/fwlink/?LinkId=510227"
        Form2.TextBox2.Text = "C:\Downloads\WindowsTechnicalPreview-x64-EN-UK.iso"
        Form2.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.TextBox1.Text = "http://go.microsoft.com/fwlink/?LinkId=510229"
        Form2.TextBox2.Text = "C:\Downloads\WindowsTechnicalPreview-x64-ZH-CN.iso"
        Form2.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.TextBox1.Text = "http://go.microsoft.com/fwlink/?LinkId=510231"
        Form2.TextBox2.Text = "C:\Downloads\WindowsTechnicalPreview-x64-PT-BR.iso"
        Form2.ShowDialog()
    End Sub
End Class