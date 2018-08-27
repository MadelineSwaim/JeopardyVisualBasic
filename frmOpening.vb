Public Class frmOpening
    Public intPlayer1 As Integer = 0
    Public intPlayer2 As Integer = 0
    Public intPlayer3 As Integer = 0
    Private Sub frmOpening_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("C:\Users\mrene\OneDrive\Panels\Jeopardy Panel\JeopardyProgram\JeopardyOpening.wav")
    End Sub

    Private Sub btnBoard1_Click(sender As Object, e As EventArgs) Handles btnBoard1.Click
        intPlayer1 = 0
        intPlayer2 = 0
        intPlayer3 = 0
        frmOldAnime.Show()
        Me.Hide()
    End Sub

    
    Private Sub btnBoard2_Click(sender As Object, e As EventArgs) Handles btnBoard2.Click
        intPlayer1 = 0
        intPlayer2 = 0
        intPlayer3 = 0
        frmNewAnime.Show()
        Me.Hide()
    End Sub

   
    Private Sub btnBoard3_Click(sender As Object, e As EventArgs) Handles btnBoard3.Click
        intPlayer1 = 0
        intPlayer2 = 0
        intPlayer3 = 0
        frmCartoons.Show()
        Me.Hide()
    End Sub

    Private Sub btnBoard4_Click(sender As Object, e As EventArgs) Handles btnBoard4.Click
        intPlayer1 = 0
        intPlayer2 = 0
        intPlayer3 = 0
        frmSciFiBoard.Show()
        Me.Hide()
    End Sub

    Private Sub btnBoard5_Click(sender As Object, e As EventArgs) Handles btnBoard5.Click
        intPlayer1 = 0
        intPlayer2 = 0
        intPlayer3 = 0
        frmShoujo.Show()
        Me.Hide()
    End Sub

    Private Sub btnBoard6_Click(sender As Object, e As EventArgs) Handles btnBoard6.Click
        intPlayer1 = 0
        intPlayer2 = 0
        intPlayer3 = 0
        frmShonen.Show()
        Me.Hide()
    End Sub
End Class
