Public Class SlotMachine
    Private Sub btnPull_Click(sender As Object, e As EventArgs) Handles btnPull.Click
        If lblPullsCounter1.Text > 0 Then
            Dim Num1 As Integer
            Num1 = Int((9 * Rnd()) + 1)
            Dim Num2 As Integer
            Num2 = Int((9 * Rnd()) + 1)
            Dim Num3 As Integer
            Num3 = Int((9 * Rnd()) + 1)
            lblNum1.Text = Num1
            lblNum2.Text = Num2
            lblNum3.Text = Num3
            lblPullsCounter1.Text -= 1
            If lblNum1.Text = lblNum2.Text And lblNum2.Text = lblNum3.Text And lblNum1.Text <> 0 Then
                MessageBox.Show("Congrats you have won the jackpot!!!!!!!")
            End If
        End If

    End Sub

    Private Sub SlotMachine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPullsCounter1.Text = 5
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblPullsCounter1.Text = 5
        lblNum1.Text = 0
        lblNum2.Text = 0
        lblNum3.Text = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class