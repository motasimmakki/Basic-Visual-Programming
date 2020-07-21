Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MessageBox.Show("Please Select Your Gender !")
        ElseIf RadioButton1.Checked = True Then
            MessageBox.Show("You Are Male !")
        ElseIf RadioButton2.Checked = True Then
            MessageBox.Show("You Are Female !")
        End If
    End Sub
End Class
