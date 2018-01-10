Public Class Health
    Private Sub btnHealthFormClose_Click(sender As Object, e As EventArgs) Handles btnHealthFormClose.Click
        Me.Close()
    End Sub

    Private Sub btnHPUp_Click(sender As Object, e As EventArgs) Handles btnHPUp.Click
        Try
            txtHealth.Text = (Convert.ToInt32(txtHealth.Text) + 1)
        Catch ex As Exception
            MessageBox.Show("Health must be a number.")
        End Try
    End Sub

    Private Sub btnHPDown_Click(sender As Object, e As EventArgs) Handles btnHPDown.Click
        Try
            txtHealth.Text = (Convert.ToInt32(txtHealth.Text) - 1)
        Catch ex As Exception
            MessageBox.Show("Maximum health must be a number.")
        End Try
    End Sub
End Class