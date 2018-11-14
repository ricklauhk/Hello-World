Public Class Form1

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim rdn(4) As RadioButton
        Dim i As Integer
        TextBox1.Text = ""
        rdn(0) = RadioButton1
        rdn(1) = RadioButton2
        rdn(2) = RadioButton3
        rdn(3) = RadioButton4
        rdn(4) = RadioButton5
        For i = 0 To 4
            If rdn(i).Checked Then
                TextBox1.Text += rdn(i).Text
            End If
        Next

    End Sub
End Class
