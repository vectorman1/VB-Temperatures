Public Class Temperatures

    Private Sub celsiusTextBoxKeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles celsiusTextBox.KeyUp
        Dim isDigit As Boolean = Char.IsDigit(ChrW(e.KeyValue))
        Dim isKeypadNum As Boolean = e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9
        Dim isUtility As Boolean = (e.KeyCode = Keys.Back Or e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Escape)
        If Not (isDigit Or isKeypadNum Or isUtility) Then
            MessageBox.Show("That's not numeric!")
            If celsiusTextBox.Text.Length > 0 Then
                celsiusTextBox.Text = celsiusTextBox.Text.Remove(celsiusTextBox.Text.Length - 1)
            End If
        End If
        Dim fahrenheitResult As Int64
        If celsiusTextBox.Text.Length > 0 Then
            fahrenheitResult = Math.Floor(Math.Floor(Convert.ToDouble(celsiusTextBox.Text) * 1.8) + 32)
        End If
        fahrenheitTextBox.Text = fahrenheitResult

    End Sub
    Private Sub fahrenheitTextBoxKeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fahrenheitTextBox.KeyUp
        Dim isDigit As Boolean = Char.IsDigit(ChrW(e.KeyValue))
        Dim isKeypadNum As Boolean = e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9
        Dim isUtility As Boolean = (e.KeyCode = Keys.Back Or e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Escape)
        If Not (isDigit Or isKeypadNum Or isUtility) Then
            MessageBox.Show("That's not numeric!")
            If fahrenheitTextBox.Text.Length > 0 Then
                fahrenheitTextBox.Text = fahrenheitTextBox.Text.Remove(fahrenheitTextBox.Text.Length - 1)
            End If
            fahrenheitTextBox.Text = fahrenheitTextBox.Text.Remove(fahrenheitTextBox.Text.Length - 1)
        End If
        Dim celsiusResult As Int64
        If fahrenheitTextBox.Text.Length > 0 Then
            celsiusResult = Math.Floor(((Convert.ToInt64(fahrenheitTextBox.Text) - 32) * 5) / 9)
        End If
        celsiusTextBox.Text = celsiusResult
    End Sub
End Class
