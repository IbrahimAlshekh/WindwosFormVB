Imports System.IO

Public Class Soru2

    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click

        Dim startNumber As Integer = ilkSayi.Text
        Dim endNumbber As Integer = ikinciSayi.Text


        If startNumber > 0 And endNumbber > 0 Then

            Dim userDirPath As String = Environ("USERPROFILE") & "\Downloads\"

            'tek sayıların
            Dim oddFileWriter As New StreamWriter(userDirPath & "tek.txt")
            'cift sayıların
            Dim evenFileWriter As New StreamWriter(userDirPath & "cift.txt")

            Dim oddSum As Integer = 0
            Dim evenSum As Integer = 0

            For i As Integer = startNumber To endNumbber

                If (i Mod 2 = 0) Then

                    evenFileWriter.Write(i & ", ")
                    evenSum += i
                Else

                    oddFileWriter.Write(i & ", ")
                    oddSum += i
                End If

            Next

            evenFileWriter.WriteLine("Sum: " & evenSum)
            evenFileWriter.Close()
            MessageBox.Show("Dosya tek.txt " & userDirPath & " klasörüne kaydedildi")

            oddFileWriter.WriteLine("Sum: " & oddSum)
            MessageBox.Show("Dosya cift.txt " & userDirPath & " klasörüne kaydedildi")
            oddFileWriter.Close()
        Else
            MessageBox.Show("lütfen bir başlangıç ve bitiş numarası girin")
        End If

    End Sub
End Class