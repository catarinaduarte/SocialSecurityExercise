Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim valor As Decimal = TextBox1.Text

        MessageBox.Show("O valor da Segurança Social é: " + FormatCurrency(CalSS(valor)))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim valor As Decimal = TextBox2.Text

        MessageBox.Show("O valor do IRS é: " + FormatCurrency(CalIRS(valor)))
    End Sub
End Class
