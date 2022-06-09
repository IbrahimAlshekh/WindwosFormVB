<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Soru2
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ilkSayi = New System.Windows.Forms.TextBox()
        Me.ikinciSayi = New System.Windows.Forms.TextBox()
        Me.calculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ilk Sayi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ikinci sayi"
        '
        'ilkSayi
        '
        Me.ilkSayi.Location = New System.Drawing.Point(121, 51)
        Me.ilkSayi.Name = "ilkSayi"
        Me.ilkSayi.Size = New System.Drawing.Size(213, 23)
        Me.ilkSayi.TabIndex = 3
        '
        'ikinciSayi
        '
        Me.ikinciSayi.Location = New System.Drawing.Point(121, 95)
        Me.ikinciSayi.Name = "ikinciSayi"
        Me.ikinciSayi.Size = New System.Drawing.Size(213, 23)
        Me.ikinciSayi.TabIndex = 4
        '
        'calculate
        '
        Me.calculate.Location = New System.Drawing.Point(121, 161)
        Me.calculate.Name = "calculate"
        Me.calculate.Size = New System.Drawing.Size(213, 23)
        Me.calculate.TabIndex = 5
        Me.calculate.Text = "hesapla"
        Me.calculate.UseVisualStyleBackColor = True
        '
        'ex2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 234)
        Me.Controls.Add(Me.calculate)
        Me.Controls.Add(Me.ikinciSayi)
        Me.Controls.Add(Me.ilkSayi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ex2"
        Me.Text = "Soru 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ilkSayi As TextBox
    Friend WithEvents ikinciSayi As TextBox
    Friend WithEvents calculate As Button
End Class
