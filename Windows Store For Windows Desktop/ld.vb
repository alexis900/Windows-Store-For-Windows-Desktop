Public Class ld

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ubuntu.ShowDialog()

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Try
            System.Diagnostics.Process.Start("http://www.ubuntu.com")
        Catch
            'Code to hanle the error
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        androidx86.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.TextBox1.Text = "http://cznic.dl.sourceforge.net/project/elementaryos/stable/elementaryos-stable-i386.20130810.iso"
        Form2.TextBox2.Text = "C:\Downloads\elementaryos-stable-i386.20130810.iso"
        Form2.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.TextBox1.Text = "http://cznic.dl.sourceforge.net/project/elementaryos/stable/elementaryos-stable-amd64.20130810.iso"
        Form2.TextBox2.Text = "C:\Downloads\elementaryos-stable-amd64.20130810.iso"
        Form2.ShowDialog()
    End Sub
End Class