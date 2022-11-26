Public Class MainMenu

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Activated
        lblClock.Text = My.Computer.Clock.LocalTime.TimeOfDay.ToString()
    End Sub

    Private Sub CurrentTimeTimer_Tick(sender As Object, e As EventArgs) Handles CurrentTimeTimer.Tick
        lblClock.Text = My.Computer.Clock.LocalTime.TimeOfDay.ToString()
    End Sub

    Private Sub btnSlotMachine_Click(sender As Object, e As EventArgs) Handles btnSlotMachine.Click
        Dim SlotMachine As New SlotMachine()
        SlotMachine.Show()
    End Sub

    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click
        Dim Calculator As New Calculator()
        Calculator.Show()
    End Sub
End Class
