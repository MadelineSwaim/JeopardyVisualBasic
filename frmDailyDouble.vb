Public Class frmDailyDouble

    Private Sub frmDailyDouble_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("C:\Users\mrene\OneDrive\Panels\Jeopardy Panel\JeopardyProgram\JeopardyDailyDouble.wav")
    End Sub

    Private Sub btnCont_Click(sender As Object, e As EventArgs) Handles btnCont.Click
        frmAnsBoard.Show()
        Me.Hide()
    End Sub

    
    Private Sub btnSound_Click(sender As Object, e As EventArgs) Handles btnSound.Click
        My.Computer.Audio.Play("C:\Users\mrene\OneDrive\Panels\Jeopardy Panel\JeopardyProgram\JeopardyDailyDouble.wav")
    End Sub
End Class