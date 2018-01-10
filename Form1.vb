Public Class Form1

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        MessageBox.Show("D&D Companion Tool" & vbCrLf & "Developed by Mitchell Bath" & vbCrLf & "---")
    End Sub

    Private Sub btnHealth1_Click(sender As Object, e As EventArgs) Handles btnHealth1.Click
        Health.Show()
    End Sub

    Private Sub btnNewParty_Click(sender As Object, e As EventArgs) Handles btnNewParty.Click
        PartyBuilder.Show()
    End Sub

    Private Sub btnD4_Click(sender As Object, e As EventArgs) Handles btnD4.Click
        DiceRoll(4)
    End Sub
    Public Sub DiceRoll(sides)
        lblDiceOutput.Text = CInt(Math.Ceiling(Rnd() * sides))
    End Sub

    Private Sub btnD6_Click(sender As Object, e As EventArgs) Handles btnD6.Click
        DiceRoll(6)
    End Sub

    Private Sub btnD8_Click(sender As Object, e As EventArgs) Handles btnD8.Click
        DiceRoll(8)
    End Sub

    Private Sub btnD10_Click(sender As Object, e As EventArgs) Handles btnD10.Click
        DiceRoll(10)
    End Sub

    Private Sub btnD12_Click(sender As Object, e As EventArgs) Handles btnD12.Click
        DiceRoll(12)
    End Sub

    Private Sub btnD20_Click(sender As Object, e As EventArgs) Handles btnD20.Click
        DiceRoll(20)
    End Sub

    Private Sub btnCustomRoll_Click(sender As Object, e As EventArgs) Handles btnCustomRoll.Click
        Dim intTemp As Integer
        For j = 1 To CInt(txtNumOfDice.Text)
            intTemp = intTemp + CInt(Math.Ceiling(Rnd() * CInt(txtNumOfSides.Text)))
        Next
        lblDiceOutput.Text = intTemp
    End Sub
End Class
