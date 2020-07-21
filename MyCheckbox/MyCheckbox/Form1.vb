Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = False Then
            MessageBox.Show("Please Select Option !")
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True Then
            MessageBox.Show("Your Age Is Under 15 And Under 25 .")
        ElseIf CheckBox1.Checked = True Then
            MessageBox.Show("Your Age Is Under 15 .")
        ElseIf CheckBox2.Checked = True Then
            MessageBox.Show("Your Age Is Under 25 .")
        ElseIf CheckBox3.Checked = True Then
            MessageBox.Show("Your Age Is Over 25 .")
        End If
    End Sub
End Class
