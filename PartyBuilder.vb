Public Class PartyBuilder
    Public strPlayers As New List(Of String)
    Private Sub btnPartyBuilderCancel_Click(sender As Object, e As EventArgs) Handles btnPartyBuilderCancel.Click
        Me.Close()
    End Sub

    Private Sub btnPartyBuilderConfirm_Click(sender As Object, e As EventArgs) Handles btnPartyBuilderConfirm.Click
        strPlayers.Add(txtPlayerName.Text)
        Form1.UpdateForm()
        Me.Close()
    End Sub
End Class