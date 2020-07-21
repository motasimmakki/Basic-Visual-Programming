Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'ListBox1.Items.Add("Mango")
        'ListBox1.Items.Add("Banana")
        'ListBox1.Items.Add("Pineapple")
        'ListBox1.Items.Add("Guava")
        'ListBox1.Items.Add("Strawberry")
        'ListBox1.Items.Add("Blueberry")
        'ListBox1.Items.Add("Cherry")
        'ListBox1.Items.Add("Litchi")
        'ListBox1.Items.Add("Dates")
        'ListBox1.Items.Add("Grapes")
        'ListBox1.Items.Clear()
        'ListBox1.Items.RemoveAt(0)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'ComboBox1.Items.Add("India")
        'ComboBox1.Items.Add("Sri Lanka")
        'ComboBox1.Items.Add("Bangladesh")
        'ComboBox1.Items.Add("Nepal")
        'ComboBox1.Items.Add("Afganistan")
        'ComboBox1.Items.Add("China")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strAdd As String
        strAdd = TextBox1.Text
        ListBox1.Items.Add(strAdd)
        ComboBox1.Items.Add(strAdd)
        TextBox1.Text = ""
    End Sub
End Class
