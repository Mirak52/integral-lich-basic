Public Class Form1
    Dim xOneV As Integer
    Dim xTwoV As Integer
    Dim xThreeV As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(IntegralA.Text) And IsNumeric(integralB.Text) And IsNumeric(numberN.Text) Then
            If IntegralA.Text >= 0 And integralB.Text > IntegralA.Text And numberN.Text > 0 Then
                If IsNumeric(xThree.Text) Or IsNumeric(xTwo.Text) Or IsNumeric(xOne.Text) Then
                    If xOne.Text <> Nothing Then
                        xOneV = xOne.Text
                    End If
                    If xTwo.Text <> Nothing Then
                        xTwoV = xTwo.Text
                    End If
                    If xThree.Text <> Nothing Then
                        xThreeV = xThree.Text
                    End If
                    Dim result As Integer = 0
                    Dim h As Double = (integralB.Text - IntegralA.Text) / numberN.Text
                    For i As Integer = 1 To numberN.Text
                        If xOneV <> Nothing Then
                            result = result + (h * i)
                        End If


                    Next
                    MathResult.Text = result

                    If Numbers.Text = Nothing Then

                    End If
                Else
                    MathResult.Text = "Vyplňte čísla u X"
                End If
            Else
                MathResult.Text = "Horní index musí být větší než dolní"
        End If
        Else
        MathResult.Text = "Vyplňte čísla správně"
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
