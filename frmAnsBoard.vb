Public Class frmAnsBoard
    Public strAnswer As String = ""
    Public intPoints As Integer = 0
    Private Sub frmAnsBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAnswer.Text = strAnswer
    End Sub

    Private Sub btnCorrect_Click(sender As Object, e As EventArgs) Handles btnCorrect.Click
        Dim intHold As Integer = 0
        If cmbPlayer.SelectedIndex = 0 Then
            intHold = frmOpening.intPlayer1 + intPoints
            frmOpening.intPlayer1 = intHold
            frmQuestionBoard.Show()
            Me.Hide()
        ElseIf cmbPlayer.SelectedIndex = 1 Then
            intHold = frmOpening.intPlayer2 + intPoints
            frmOpening.intPlayer2 = intHold
            frmQuestionBoard.Show()
            Me.Hide()
        ElseIf cmbPlayer.SelectedIndex = 2 Then
            intHold = frmOpening.intPlayer3 + intPoints
            frmOpening.intPlayer3 = intHold
            frmQuestionBoard.Show()
            Me.Hide()
        Else
            frmError.Show()
        End If
    End Sub

    Private Sub btnWrong_Click(sender As Object, e As EventArgs) Handles btnWrong.Click
        Dim intHold As Integer = 0
        If cmbPlayer.SelectedIndex = 0 Then
            intHold = frmOpening.intPlayer1 - intPoints
            frmOpening.intPlayer1 = intHold
        ElseIf cmbPlayer.SelectedIndex = 1 Then
            intHold = frmOpening.intPlayer2 - intPoints
            frmOpening.intPlayer2 = intHold
        ElseIf cmbPlayer.SelectedIndex = 2 Then
            intHold = frmOpening.intPlayer3 - intPoints
            frmOpening.intPlayer3 = intHold
        Else
            frmError.Show()
        End If
    End Sub

    
    Private Sub btnNoAns_Click(sender As Object, e As EventArgs) Handles btnNoAns.Click
        My.Computer.Audio.Play("C:\Users\mrene\OneDrive\Panels\Jeopardy Panel\JeopardyProgram\JeopardyTimesUp.wav")
        frmQuestionBoard.Show()
        Me.Hide()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtAnswer.Text = strAnswer
    End Sub
End Class