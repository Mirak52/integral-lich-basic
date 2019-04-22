Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button2.Hide()
        Button3.Hide()
        If IsNumeric(IntegralA.Text) And IsNumeric(integralB.Text) And IsNumeric(numberN.Text) Then
            If IntegralA.Text >= 0 And integralB.Text > IntegralA.Text And numberN.Text > 0 And IsNumeric(Numbers.Text) Or Numbers.Text = Nothing Then
                If IsNumeric(xThree.Text) Or IsNumeric(xTwo.Text) Or IsNumeric(xOne.Text) Then
                    Dim xOneV As Double
                    Dim xTwoV As Double
                    Dim xThreeV As Double
                    Dim partCalc As Double
                    n = 0
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
                            y(i) = result
                        ElseIf Numbers.Text <> Nothing Then
                            partCalc = partCalc + Numbers.Text
                            y(i) = partCalc
                        End If
                        If i <> numberN.Text And i <> 0 Then
                            result = result + partCalc * 2
                            y(i) = partCalc
                        Else
                            result = result + partCalc
                            If y(i) = Nothing Then
                                y(i) = partCalc
                            End If

                        End If
                        x(i) = h * i
                        n = i
                    Next

                    result = result * (h / 2)
                    MathResult.Text = result
                    Button2.Show()
                    Button3.Show()
                Else
                    MathResult.Text = "Vyplňte čísla u X"
                End If
            Else
                MathResult.Text = "Prosím o kontrolu složitější příklady neumím"
            End If
        Else
            MathResult.Text = "Vyplňte čísla správně"
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Graph.Show()
        Graph.showChart()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim soubor
        SaveFileDialog1.ShowDialog()
        soubor = SaveFileDialog1.FileName
        FileOpen(1, soubor, OpenMode.Output)
        Write(1, n)
        For i = 0 To n
            Write(1, x(i))
            Write(1, y(i))
        Next
        FileClose(1)
    End Sub
End Class
