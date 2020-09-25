Public Class Form1
    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        Dim i As Integer
        Dim numsum As Integer
        numsum = 0
        For i = 2 To 20 Step 2
            numsum = numsum + i
        Next
        lblResults.Text = numsum
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        listEvenAndTotal.Items.Clear()
        Dim a As Boolean
        For i = 2 To 20 Step 2
            If i Mod 2 = 0 Then
                a = False
            Else
                a = True
            End If
            If a = True Then
                listEvenAndTotal.Items.Add(i)
            End If
        Next
    End Sub
End Class
