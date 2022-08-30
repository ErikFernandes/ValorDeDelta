Public Class Fundo
    Sub Clean()

        valorA.Text = ""
        valorB.Text = ""
        valorC.Text = ""

    End Sub
    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click

        Dim result As Decimal

        Try

            result = Double.Parse(valorB.Text ^ 2 - 4 * valorA.Text * valorC.Text)
            MessageBox.Show($"O valor de Delta é {result}", CStr("Resultado"))


        Catch

            MessageBox.Show("Que isso jovem?", CStr("Erro"))
            Clean()

        End Try

    End Sub
    Private Sub Egg_Click(sender As Object, e As EventArgs) Handles Egg.Click
        Form2.Show()

    End Sub


End Class
