Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(IntegralA.Text) And IsNumeric(integralB.Text) And IsNumeric(numberN.Text) Then
            If IntegralA.Text >= 0 And integralB.Text > IntegralA.Text And numberN.Text > 0 Then
                If IsNumeric(xThree.Text) Or IsNumeric(xTwo.Text) Or IsNumeric(xOne.Text) Then
                    Dim xOneV As Double
                    Dim xTwoV As Double
                    Dim xThreeV As Double
                    Dim partCalc As Double

                    If xOne.Text <> Nothing Then
                        xOneV = xOne.Text
                    End If
                    If xTwo.Text <> Nothing Then
                        xTwoV = xTwo.Text
                    End If
                    If xThree.Text <> Nothing Then
                        xThreeV = xThree.Text
                    End If
                    Dim result As Double = 0

                    Dim h As Double = (integralB.Text - IntegralA.Text) / numberN.Text
                    For i As Integer = 0 To numberN.Text
                        partCalc = 0
                        If xOneV <> Nothing Then
                            partCalc = partCalc + (h * i) * xOneV
                        End If
                        If xTwoV <> Nothing Then
                            partCalc = partCalc + (h * i) * (h * i) * xTwoV
                        End If
                        If xThreeV <> Nothing Then
                            partCalc = partCalc + (h * i) * (h * i) * (h * i) * xThreeV
                        End If

                        If Numbers.Text <> Nothing And i = 0 Then
                            result = result + Numbers.Text
                        ElseIf Numbers.Text <> Nothing Then
                            partCalc = partCalc + Numbers.Text
                        End If
                        If i <> numberN.Text And i <> 0 Then
                            result = result + partCalc * 2
                        Else
                            result = result + partCalc
                        End If

                    Next

                    result = result * (h / 2)
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
