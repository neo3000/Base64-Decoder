Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            RichTextBox2.Text = ""
            Dim Base64Text As Byte() = System.Text.Encoding.UTF8.GetBytes(RichTextBox1.Text)
            RichTextBox2.Text = Convert.ToBase64String(Base64Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            RichTextBox1.Text = ""
            Dim ClearText As Byte() = Convert.FromBase64String(RichTextBox2.Text)
            RichTextBox1.Text = System.Text.Encoding.UTF8.GetString(ClearText)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        RichTextBox1.Text = ""
        RichTextBox2.Text = ""
    End Sub

    Private Sub Form1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F1
                    Button1_Click(sender, e)
                Case Keys.F2
                    Button2_Click(sender, e)
                Case Keys.F3
                    Button3_Click(sender, e)
                Case Else
            End Select
        Catch ex As Exception
        End Try
    End Sub
End Class
