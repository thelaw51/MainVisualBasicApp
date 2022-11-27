Imports System.Runtime.InteropServices
Imports System.Security.Cryptography.X509Certificates


Public Class Calculator
#Region "General variables"
    Dim Total1 As Integer
    Dim Total2 As Integer
#End Region
#Region "Properties"
    Private but As Button
    Public Property LastBut As Button     'tracks what the last button that was pressed was
        Get
            Return but
        End Get
        Set(value As Button)
            but = value
        End Set
    End Property

    Private Total As Integer
    Public Property RunningTotal() As Integer    'keeps a track of the running total
        Get
            Return Total
        End Get
        Set(value As Integer)
            Total = value
        End Set
    End Property
#End Region
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error Closing form")
        End Try
    End Sub

    Private Sub UpdateLastBut(LastBut As Button)
        Me.LastBut = LastBut
    End Sub
    Private Sub UpdateTotal(calbut As Button)
        Try
            For index = 1 To 9
                If Me.LastBut.Name.Contains("Add") Then
                    Me.RunningTotal += index
                ElseIf Me.LastBut.Name.Contains("Subtract") Then

                ElseIf Me.LastBut.Name.Contains("Multiply") Then

                ElseIf Me.LastBut.Name.Contains("Divide") Then
                End If

            Next
        Catch ex As Exception
            MessageBox.Show("Error Updating total")
        End Try
    End Sub

    Private Sub NumButton_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click
        Try
            Dim calbut As Button = sender
            If lblTotal.Text = "0" Then
                lblTotal.Text = calbut.Text
            Else
                lblTotal.Text += calbut.Text
            End If
        Catch ex As Exception
            MessageBox.Show("Error pressing num button")
        End Try
    End Sub

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Activated
        lblClock.Text = My.Computer.Clock.LocalTime.TimeOfDay.ToString()
    End Sub

    Private Sub CurrentTimeTimer_Tick(sender As Object, e As EventArgs) Handles CurrentTimeTimer.Tick
        lblClock.Text = My.Computer.Clock.LocalTime.TimeOfDay.ToString()
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Try
            Dim calbut As Button = sender
            Total1 = Val(lblTotal.Text)
        Catch ex As Exception
            MessageBox.Show("Error Getting sum total")
        End Try
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, btnSubtract.Click, btnMultiply.Click, btnDivide.Click
        If sender.Name.Contains("Add") Then
            lblTotal.Text += "+"
        ElseIf sender.Name.Contains("Subtract") Then
            lblTotal.Text += "-"
        ElseIf sender.Name.Contains("Multiply") Then
            lblTotal.Text += "*"
        ElseIf sender.Name.Contains("Divide") Then
            lblTotal.Text += "/"
        End If
    End Sub
End Class