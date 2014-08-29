Public Class webbrowsers

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.TextBox1.Text = "https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7B3152A74F-5BAF-74F5-5D65-86E19C4B2B06%7D%26lang%3Des%26browser%3D4%26usagestats%3D0%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers/update2/installers/ChromeSetup.exe"
        Form2.TextBox2.Text = "C:\Downloads\ChromeSetup.exe"
        Form2.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.TextBox1.Text = "https://download.mozilla.org/?product=firefox-stub&os=win&lang=es-ES"
        Form2.TextBox2.Text = "C:\Downloads\Firefox Setup Stub Lastest.exe"
        Form2.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.TextBox1.Text = "http://dl.maxthon.com/online_install/mx4/mxsetup.exe"
        Form2.TextBox2.Text = "C:\Downloads\mxsetup.exe"
        Form2.ShowDialog()
    End Sub
End Class