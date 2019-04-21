Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not IsNumeric(xThree.Text) Or Not IsNumeric(xTwo.Text) Then
            Result.Text = "Zadejte rozsah integrálu!"
        ElseIf Not IsNumeric(IntegralA.Text) Or Not IsNumeric(integralB.Text) Or Not IsNumeric(numberN.Text) Then
            Result.Text = "Zadejte číslo pro X"
        Else
            Result.Text = "Error"
        End If

    End Sub
End Class
