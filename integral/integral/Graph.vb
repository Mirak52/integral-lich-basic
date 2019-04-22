Public Class Graph
    Public Function showChart()
        Dim test As Array = x.ToArray
        Dim test2 As Array = y.ToArray
        Me.Chart1.Series("Křivka").Points.Clear()

        For i = 0 To n
            Me.Chart1.Series("Křivka").Points.AddXY(x(i), y(i))
        Next
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button3.Click
        Chart1.Printing.PrintPreview()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Chart1.Printing.Print(True)
    End Sub
End Class