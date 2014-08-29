Imports System.Net

Public Class Form2
    Public WithEvents download As WebClient
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.FileSystem.CreateDirectory("C:\Downloads")
        Me.Width() = "672"
        Try
            download = New WebClient
            download.DownloadFileAsync(New Uri(TextBox1.Text), TextBox2.Text)
        Catch ex As Exception
            MsgBox("Error!" & ex.Message)
        End Try
    End Sub
    Private Sub download_DownloadProgressChanged(ByVal sender As System.Object, ByVal e As DownloadProgressChangedEventArgs) Handles download.DownloadProgressChanged
        Try
            Label3.Text = e.BytesReceived / 1000000 & " MB / " & e.TotalBytesToReceive / 1000000 & " MB"
            ProgressBar1.Value = e.ProgressPercentage
            Label4.Text = ProgressBar1.Value & "%"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ofd As New SaveFileDialog
        ofd.Filter = "All Files (*.*) |*.*"
        ofd.ShowDialog()
        TextBox2.Text = ofd.FileName
    End Sub

    Private Sub EditURLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditURLToolStripMenuItem.Click
        TextBox1.Enabled = True
        UneditURLToolStripMenuItem.Enabled = True
        EditURLToolStripMenuItem.Enabled = False
    End Sub

    Private Sub UneditURLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UneditURLToolStripMenuItem.Click
        TextBox1.Enabled = False
        UneditURLToolStripMenuItem.Enabled = False
        EditURLToolStripMenuItem.Enabled = True
    End Sub

    Private Sub DownloadsFolderToolStripMenuItem_Click(sender As Object, e As EventArgs)
        My.Computer.FileSystem.CreateDirectory(
  "C:\Downloads")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Width() = "594"
        Process.Start("explorer.exe", String.Format("/n, /e, {0}", TextBox2.Text))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start("explorer.exe", String.Format("/n, /e, {0}", "C:\Downloads"))
    End Sub
End Class