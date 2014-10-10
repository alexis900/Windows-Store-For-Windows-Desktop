Public Class AboutThis

    Private Sub AboutThis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LabelVersion.Text = String.Format("Versión {0}", My.Application.Info.Version.ToString)
        Me.LabelProductName.Text = My.Application.Info.ProductName
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Visible = False
        Button2.Visible = True
        'Linux
        Form1.Button15.Visible = True
        'Windows
        Form1.Button26.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Visible = False
        Button1.Visible = True
        'Linux
        Form1.Button15.Visible = False
        'Windows
        Form1.Button26.Visible = False
    End Sub
End Class