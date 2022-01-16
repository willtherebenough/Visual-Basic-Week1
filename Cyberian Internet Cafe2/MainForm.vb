Imports System.Speech
Imports System.Speech.Synthesis
Public Class MainForm
    Const HOURLY_RATE As Double = 12.0
    Private Speaker As SpeechSynthesizer = New SpeechSynthesizer()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim hours As Integer
        Dim amount As Double
        Dim isConverted As Boolean
        isConverted = Integer.TryParse(hoursTextBox.Text, hours)
        amount = hours * HOURLY_RATE
        amountDueTextBox.Text = amount.ToString("C0")
        Speaker.SpeakAsync(amountDueTextBox.Text)
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        lastNameTextBox.Text = String.Empty
        firstNameTextBox.Text = String.Empty
        hoursTextBox.Text = String.Empty
        amountDueTextBox.Text = String.Empty
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
