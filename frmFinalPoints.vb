Public Class frmFinalPoints

    Private Sub frmFinalPoints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPlayer1.Text = frmOpening.intPlayer1.ToString
        lblPlayer2.Text = frmOpening.intPlayer2.ToString
        lblPlayer3.Text = frmOpening.intPlayer3.ToString
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frmOpening.Show()
        Me.Hide()
    End Sub

    Private Sub btnScores_Click(sender As Object, e As EventArgs) Handles btnScores.Click
        lblPlayer1.Text = frmOpening.intPlayer1.ToString
        lblPlayer2.Text = frmOpening.intPlayer2.ToString
        lblPlayer3.Text = frmOpening.intPlayer3.ToString
    End Sub
End Class