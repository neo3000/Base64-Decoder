Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SaveFileDialog1.ShowDialog()
        TextBox1.Text = SaveFileDialog1.FileName
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim src As String = RichTextBox1.Text
            Dim bt64 As Byte() = System.Convert.FromBase64String(src)
            If IO.File.Exists(TextBox1.Text) Then
                IO.File.Delete(TextBox1.Text)
            End If
            Dim sw As New IO.FileStream(TextBox1.Text, IO.FileMode.Create)
            sw.Write(bt64, 0, bt64.Length)
            sw.Close()
            MsgBox("Fertig")
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
End Class
