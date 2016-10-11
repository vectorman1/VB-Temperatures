<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Temperatures
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.celsiusLabel = New System.Windows.Forms.Label()
        Me.fahrenheitLabel = New System.Windows.Forms.Label()
        Me.celsiusTextBox = New System.Windows.Forms.TextBox()
        Me.fahrenheitTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'celsiusLabel
        '
        Me.celsiusLabel.AutoSize = True
        Me.celsiusLabel.Location = New System.Drawing.Point(38, 23)
        Me.celsiusLabel.Name = "celsiusLabel"
        Me.celsiusLabel.Size = New System.Drawing.Size(43, 13)
        Me.celsiusLabel.TabIndex = 0
        Me.celsiusLabel.Text = "Celsius:"
        '
        'fahrenheitLabel
        '
        Me.fahrenheitLabel.AutoSize = True
        Me.fahrenheitLabel.Location = New System.Drawing.Point(21, 62)
        Me.fahrenheitLabel.Name = "fahrenheitLabel"
        Me.fahrenheitLabel.Size = New System.Drawing.Size(60, 13)
        Me.fahrenheitLabel.TabIndex = 1
        Me.fahrenheitLabel.Text = "Fahrenheit:"
        '
        'celsiusTextBox
        '
        Me.celsiusTextBox.Location = New System.Drawing.Point(88, 23)
        Me.celsiusTextBox.Name = "celsiusTextBox"
        Me.celsiusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.celsiusTextBox.TabIndex = 2
        '
        'fahrenheitTextBox
        '
        Me.fahrenheitTextBox.Location = New System.Drawing.Point(88, 62)
        Me.fahrenheitTextBox.Name = "fahrenheitTextBox"
        Me.fahrenheitTextBox.Size = New System.Drawing.Size(100, 20)
        Me.fahrenheitTextBox.TabIndex = 3
        '
        'Temperatures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 122)
        Me.Controls.Add(Me.fahrenheitTextBox)
        Me.Controls.Add(Me.celsiusTextBox)
        Me.Controls.Add(Me.fahrenheitLabel)
        Me.Controls.Add(Me.celsiusLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(230, 150)
        Me.MinimumSize = New System.Drawing.Size(230, 150)
        Me.Name = "Temperatures"
        Me.Text = "Temperatures"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents celsiusLabel As System.Windows.Forms.Label
    Friend WithEvents fahrenheitLabel As System.Windows.Forms.Label
    Friend WithEvents celsiusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents fahrenheitTextBox As System.Windows.Forms.TextBox

End Class
