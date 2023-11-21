Public Class Level
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Close()
    End Sub

    Private Sub Ok_Click(sender As Object, e As EventArgs) Handles Ok.Click
        'segun la opcion del radiobutton, tiene sun limite de fallos.
        If RadioButton3.Checked Then
            Form1.maxFails = 6
        ElseIf RadioButton2.Checked Then
            Form1.maxFails = 8
        Else
            Form1.maxFails = 10
        End If
        Close()
    End Sub
End Class