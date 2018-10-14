Public Class Form1
    Dim dice As Integer
    Dim random As Random

    Private Sub TmrTimer_Tick(sender As Object, e As EventArgs) Handles TmrTimer.Tick
        random = New Random
        PrgProgressBar.Increment(5)

        If PrgProgressBar.Value = 100 Then
            TmrTimer.Stop()
            PrgProgressBar.Value = 0


        Else
            dice = random.Next(1, 21)

            If dice = 1 Then
                PicDice.Image = My.Resources.D20_1
            ElseIf dice = 2 Then
                PicDice.Image = My.Resources.D20_2
            ElseIf dice = 3 Then
                PicDice.Image = My.Resources.D20_3
            ElseIf dice = 4 Then
                PicDice.Image = My.Resources.D20_4
            ElseIf dice = 5 Then
                PicDice.Image = My.Resources.D20_5
            ElseIf dice = 6 Then
                PicDice.Image = My.Resources.D20_6
            ElseIf dice = 7 Then
                PicDice.Image = My.Resources.D20_7
            ElseIf dice = 8 Then
                PicDice.Image = My.Resources.D20_8
            ElseIf dice = 9 Then
                PicDice.Image = My.Resources.D20_9
            ElseIf dice = 10 Then
                PicDice.Image = My.Resources.D20_10
            ElseIf dice = 11 Then
                PicDice.Image = My.Resources.D20_11
            ElseIf dice = 12 Then
                PicDice.Image = My.Resources.D20_12
            ElseIf dice = 13 Then
                PicDice.Image = My.Resources.D20_13
            ElseIf dice = 14 Then
                PicDice.Image = My.Resources.D20_14
            ElseIf dice = 15 Then
                PicDice.Image = My.Resources.D20_15
            ElseIf dice = 16 Then
                PicDice.Image = My.Resources.D20_16
            ElseIf dice = 17 Then
                PicDice.Image = My.Resources.D20_17
            ElseIf dice = 18 Then
                PicDice.Image = My.Resources.D20_18
            ElseIf dice = 19 Then
                PicDice.Image = My.Resources.D20_19
            ElseIf dice = 20 Then
                PicDice.Image = My.Resources.D20_20
            End If

        End If

    End Sub

    Private Sub BtnButton_Click(sender As Object, e As EventArgs) Handles BtnButton.Click
        TmrTimer.Start()
    End Sub

    Private Sub PicDice_Click(sender As Object, e As EventArgs) Handles PicDice.Click

    End Sub
End Class
