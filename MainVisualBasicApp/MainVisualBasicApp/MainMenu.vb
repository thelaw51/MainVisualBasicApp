Public Class MainMenu
    Private Sub btnSlotMachine_Click(sender As Object, e As EventArgs) Handles btnSlotMachine.Click
        Dim SlotMachine As New SlotMachine()
        SlotMachine.Show()
    End Sub

    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click
        Dim Calculator As New Calculator()
        Calculator.Show()
    End Sub
End Class
