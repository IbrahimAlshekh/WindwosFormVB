Public Class Soru1
    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Dim noteText As Integer = note.Text

        If (noteText >= 60) Then


            MessageBox.Show("geçti")

        Else

            MessageBox.Show("geçmedi")

        End If

        Console.WriteLine(noteText)

        Dim mainForm As Form = New Intro

        mainForm.Show()

        Me.Close()


    End Sub
End Class