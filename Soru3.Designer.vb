<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Soru3
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.number = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.firstname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lastname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.note = New System.Windows.Forms.TextBox()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.updateButton = New System.Windows.Forms.Button()
        Me.personsTable = New System.Windows.Forms.DataGridView()
        Me.deleteButton = New System.Windows.Forms.Button()
        CType(Me.personsTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numara"
        '
        'number
        '
        Me.number.Location = New System.Drawing.Point(68, 32)
        Me.number.Name = "number"
        Me.number.Size = New System.Drawing.Size(98, 23)
        Me.number.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(172, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ad"
        '
        'firstname
        '
        Me.firstname.Location = New System.Drawing.Point(200, 32)
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(113, 23)
        Me.firstname.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(319, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Soyad"
        '
        'lastname
        '
        Me.lastname.Location = New System.Drawing.Point(364, 32)
        Me.lastname.Name = "lastname"
        Me.lastname.Size = New System.Drawing.Size(113, 23)
        Me.lastname.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(492, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Notu"
        '
        'note
        '
        Me.note.Location = New System.Drawing.Point(526, 32)
        Me.note.Name = "note"
        Me.note.Size = New System.Drawing.Size(97, 23)
        Me.note.TabIndex = 7
        '
        'saveButton
        '
        Me.saveButton.Location = New System.Drawing.Point(644, 32)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(61, 23)
        Me.saveButton.TabIndex = 8
        Me.saveButton.Text = "Ekle"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'updateButton
        '
        Me.updateButton.Enabled = False
        Me.updateButton.Location = New System.Drawing.Point(711, 32)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Size = New System.Drawing.Size(63, 23)
        Me.updateButton.TabIndex = 9
        Me.updateButton.Text = "Güncelle"
        Me.updateButton.UseVisualStyleBackColor = True
        '
        'personsTable
        '
        Me.personsTable.AllowUserToAddRows = False
        Me.personsTable.AllowUserToDeleteRows = False
        Me.personsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.personsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.personsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.personsTable.Location = New System.Drawing.Point(12, 82)
        Me.personsTable.Name = "personsTable"
        Me.personsTable.ReadOnly = True
        Me.personsTable.RowTemplate.Height = 25
        Me.personsTable.Size = New System.Drawing.Size(762, 311)
        Me.personsTable.TabIndex = 10
        '
        'deleteButton
        '
        Me.deleteButton.Location = New System.Drawing.Point(699, 399)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(75, 23)
        Me.deleteButton.TabIndex = 11
        Me.deleteButton.Text = "Sil"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'Soru3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 432)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.personsTable)
        Me.Controls.Add(Me.updateButton)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.note)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lastname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.firstname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.number)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Soru3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Soru 3"
        CType(Me.personsTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents number As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents firstname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lastname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents note As TextBox
    Friend WithEvents saveButton As Button
    Friend WithEvents updateButton As Button
    Friend WithEvents personsTable As DataGridView
    Friend WithEvents deleteButton As Button
End Class
