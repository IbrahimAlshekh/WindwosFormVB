Public Class Intro
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles exercise1.Click
        Dim form = New Soru1()

        form.ShowDialog()

        Me.Hide()

    End Sub

    Private Sub exercise2_Click(sender As Object, e As EventArgs) Handles exercise2.Click
        Dim form As New Soru2

        form.ShowDialog()

        Me.Hide()

    End Sub

    Private Sub exercise3_Click(sender As Object, e As EventArgs) Handles exercise3.Click
        Dim form As New Soru3

        form.ShowDialog()

        Me.Hide()

    End Sub
End Class
