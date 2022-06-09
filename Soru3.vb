Imports System.Data.SqlClient

Public Class Soru3


    Dim con As New SqlConnection("Data Source=ISM-MAIN-PC;Initial Catalog=WindowFormDB;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim sql As String
    Dim result As Integer

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        fillTable()

    End Sub

    Private Sub fillTable()
        Try
            con.Open()
            'create a new oledb dataadapter
            Dim dataAdapter As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM ogrenci", con)
            'create a new dataset
            Dim dataSet As New DataSet()
            'fill the datset
            dataAdapter.Fill(dataSet)
            'attach dataset to the datagrid
            personsTable.DataSource = dataSet.Tables(0)
            dataSet = Nothing
            dataAdapter = Nothing
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click

        Dim noteValue As Integer = note.Text
        Dim status As String

        If noteValue >= 60 Then
            status = "geçti"
        Else
            status = "geçmedi"
        End If

        sql = "INSERT INTO ogrenci (numara, ad, soyad, notu, status) VALUES ('" & number.Text & "','" & firstname.Text & "','" & lastname.Text & "','" & note.Text & "','" & status & "')"
        executeQuery(sql, "Veriler başarıyla eklendi")

        firstname.Clear()
        lastname.Clear()
        number.Clear()
        note.Clear()

        fillTable()
    End Sub


    Private Sub executeQuery(sql As String, message As String)
        Try
            con.Open()
            cmd = New SqlCommand
            With cmd
                .Connection = con
                .CommandText = sql
                result = .ExecuteNonQuery()
            End With
            If result > 0 Then
                MsgBox(message)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub personsTable_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles personsTable.CellMouseClick
        Dim rowindex As Integer = personsTable.CurrentRow.Index

        number.Text = personsTable.Rows(rowindex).Cells(0).Value.ToString()
        firstname.Text = personsTable.Rows(rowindex).Cells(1).Value.ToString()
        lastname.Text = personsTable.Rows(rowindex).Cells(2).Value.ToString()
        note.Text = personsTable.Rows(rowindex).Cells(3).Value.ToString()
        updateButton.Enabled = True
        saveButton.Enabled = False

        number.Enabled = False

    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click


        Dim noteValue As Integer = note.Text
        Dim status As String

        If noteValue >= 60 Then
            status = "geçti"
        Else
            status = "geçmedi"
        End If

        sql = "UPDATE ogrenci SET ad = '" & firstname.Text & "', soyad = '" & lastname.Text & "', notu =  '" & note.Text & "', status =  '" & status & "' WHERE numara = '" & number.Text & "'"
        executeQuery(sql, "Veriler başarıyla güncellendi")

        firstname.Clear()
        lastname.Clear()
        number.Clear()
        note.Clear()

        updateButton.Enabled = False
        saveButton.Enabled = True
        number.Enabled = True

        fillTable()
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        Dim rowindex As Integer = personsTable.CurrentRow.Index

        sql = "DELETE FROM ogrenci  WHERE numara = '" & personsTable.Rows(rowindex).Cells(0).Value.ToString() & "'"
        executeQuery(sql, "Veriler başarıyla silindi")

        fillTable()
    End Sub
End Class