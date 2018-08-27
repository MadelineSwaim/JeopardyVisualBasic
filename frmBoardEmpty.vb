Public Class frmBoardEmpty
    Dim arrCat1Ans = New String() {"1:100", "1:200", "1:300", "1:400", "1:500"}
    Dim arrCat2Ans = New String() {"2:100", "2:200", "2:300", "2:400", "2:500"}
    Dim arrCat3Ans = New String() {"3:100", "3:200", "3:300", "3:400", "3:500"}
    Dim arrCat4Ans = New String() {"4:100", "4:200", "4:300", "4:400", "4:500"}
    Dim arrCat5Ans = New String() {"5:100", "5:200", "5:300", "5:400", "5:500"}
    Dim arrCat6Ans = New String() {"6:100", "6:200", "6:300", "6:400", "6:500"}

    Dim arrCat1Ques = New String() {"1:100", "1:200", "1:300", "1:400", "1:500"}
    Dim arrCat2Ques = New String() {"2:100", "2:200", "2:300", "2:400", "2:500"}
    Dim arrCat3Ques = New String() {"3:100", "3:200", "3:300", "3:400", "3:500"}
    Dim arrCat4Ques = New String() {"4:100", "4:200", "4:300", "4:400", "4:500"}
    Dim arrCat5Ques = New String() {"5:100", "5:200", "5:300", "5:400", "5:500"}
    Dim arrCat6Ques = New String() {"6:100", "6:200", "6:300", "6:400", "6:500"}

    Dim intCounter As Integer = 0
    Dim intDaDoCat As Integer = 0
    Dim intDaDoPt As Integer = 0

    Private Sub frmBoardEmpty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Static Generator As System.Random = New System.Random
        intDaDoCat = Generator.Next(1, 6)
        intDaDoPt = Generator.Next(1, 5)

    End Sub

    Private Sub btn100Cat1_Click(sender As Object, e As EventArgs) Handles btn100Cat1.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat1Ans(0)
        frmQuestionBoard.strQuestion = arrCat1Ques(0)
        If intDaDoCat = 1 And intDaDoPt = 1 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 200
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 100
        End If

        btn100Cat1.Enabled = False
        btn100Cat1.ForeColor = Color.White
    End Sub

    Private Sub btn100Cat2_Click(sender As Object, e As EventArgs) Handles btn100Cat2.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat2Ans(0)
        frmQuestionBoard.strQuestion = arrCat2Ques(0)
        If intDaDoCat = 2 And intDaDoPt = 1 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 200
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 100
        End If

        btn100Cat2.Enabled = False
        btn100Cat2.ForeColor = Color.White
    End Sub

    Private Sub btn100Cat3_Click(sender As Object, e As EventArgs) Handles btn100Cat3.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat3Ans(0)
        frmQuestionBoard.strQuestion = arrCat3Ques(0)
        If intDaDoCat = 3 And intDaDoPt = 1 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 200
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 100
        End If

        btn100Cat3.Enabled = False
        btn100Cat3.ForeColor = Color.White
    End Sub

    Private Sub btn100Cat4_Click(sender As Object, e As EventArgs) Handles btn100Cat4.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat4Ans(0)
        frmQuestionBoard.strQuestion = arrCat4Ques(0)
        If intDaDoCat = 4 And intDaDoPt = 1 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 200
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 100
        End If

        btn100Cat4.Enabled = False
        btn100Cat4.ForeColor = Color.White
    End Sub

    Private Sub btn100Cat5_Click(sender As Object, e As EventArgs) Handles btn100Cat5.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat5Ans(0)
        frmQuestionBoard.strQuestion = arrCat5Ques(0)
        If intDaDoCat = 5 And intDaDoPt = 1 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 200
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 100
        End If

        btn100Cat5.Enabled = False
        btn100Cat5.ForeColor = Color.White
    End Sub

    Private Sub btn100Cat6_Click(sender As Object, e As EventArgs) Handles btn100Cat6.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat6Ans(0)
        frmQuestionBoard.strQuestion = arrCat6Ques(0)
        If intDaDoCat = 6 And intDaDoPt = 1 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 200
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 100
        End If

        btn100Cat6.Enabled = False
        btn100Cat6.ForeColor = Color.White
    End Sub

    Private Sub btn200Cat1_Click(sender As Object, e As EventArgs) Handles btn200Cat1.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat1Ans(1)
        frmQuestionBoard.strQuestion = arrCat1Ques(1)
        If intDaDoCat = 1 And intDaDoPt = 2 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 400
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 200
        End If
        btn200Cat1.Enabled = False
        btn200Cat1.ForeColor = Color.White
    End Sub

    Private Sub btn200Cat2_Click(sender As Object, e As EventArgs) Handles btn200Cat2.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat2Ans(1)
        frmQuestionBoard.strQuestion = arrCat2Ques(1)
        If intDaDoCat = 2 And intDaDoPt = 2 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 400
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 200
        End If
        btn200Cat2.Enabled = False
        btn200Cat2.ForeColor = Color.White
    End Sub

    Private Sub btn200Cat3_Click(sender As Object, e As EventArgs) Handles btn200Cat3.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat3Ans(1)
        frmQuestionBoard.strQuestion = arrCat3Ques(1)
        If intDaDoCat = 3 And intDaDoPt = 2 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 400
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 200
        End If
        btn200Cat3.Enabled = False
        btn200Cat3.ForeColor = Color.White
    End Sub

    Private Sub btn200Cat4_Click(sender As Object, e As EventArgs) Handles btn200Cat4.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat4Ans(1)
        frmQuestionBoard.strQuestion = arrCat4Ques(1)
        If intDaDoCat = 4 And intDaDoPt = 2 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 400
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 200
        End If
        btn200Cat4.Enabled = False
        btn200Cat4.ForeColor = Color.White
    End Sub

    Private Sub btn200Cat5_Click(sender As Object, e As EventArgs) Handles btn200Cat5.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat5Ans(1)
        frmQuestionBoard.strQuestion = arrCat5Ques(1)
        If intDaDoCat = 5 And intDaDoPt = 2 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 400
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 200
        End If
        btn200Cat5.Enabled = False
        btn200Cat5.ForeColor = Color.White
    End Sub

    Private Sub btn200Cat6_Click(sender As Object, e As EventArgs) Handles btn200Cat6.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat6Ans(1)
        frmQuestionBoard.strQuestion = arrCat6Ques(1)
        If intDaDoCat = 6 And intDaDoPt = 2 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 400
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 200
        End If
        btn200Cat6.Enabled = False
        btn200Cat6.ForeColor = Color.White
    End Sub

    Private Sub btn300Cat1_Click(sender As Object, e As EventArgs) Handles btn300Cat1.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat1Ans(2)
        frmQuestionBoard.strQuestion = arrCat1Ques(2)
        If intDaDoCat = 1 And intDaDoPt = 3 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 600
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 300
        End If
        btn300Cat1.Enabled = False
        btn300Cat1.ForeColor = Color.White
    End Sub

    Private Sub btn300Cat2_Click(sender As Object, e As EventArgs) Handles btn300Cat2.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat2Ans(2)
        frmQuestionBoard.strQuestion = arrCat2Ques(2)
        If intDaDoCat = 2 And intDaDoPt = 3 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 600
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 300
        End If
        btn300Cat2.Enabled = False
        btn300Cat2.ForeColor = Color.White
    End Sub

    Private Sub btn300Cat3_Click(sender As Object, e As EventArgs) Handles btn300Cat3.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat3Ans(2)
        frmQuestionBoard.strQuestion = arrCat3Ques(2)
        If intDaDoCat = 3 And intDaDoPt = 3 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 600
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 300
        End If
        btn300Cat3.Enabled = False
        btn300Cat3.ForeColor = Color.White
    End Sub

    Private Sub btn300Cat4_Click(sender As Object, e As EventArgs) Handles btn300Cat4.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat4Ans(2)
        frmQuestionBoard.strQuestion = arrCat4Ques(2)
        If intDaDoCat = 4 And intDaDoPt = 3 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 600
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 300
        End If
        btn300Cat4.Enabled = False
        btn300Cat4.ForeColor = Color.White
    End Sub

    Private Sub btn300Cat5_Click(sender As Object, e As EventArgs) Handles btn300Cat5.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat5Ans(2)
        frmQuestionBoard.strQuestion = arrCat5Ques(2)
        If intDaDoCat = 5 And intDaDoPt = 3 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 600
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 300
        End If
        btn300Cat5.Enabled = False
        btn300Cat5.ForeColor = Color.White
    End Sub

    Private Sub btn300Cat6_Click(sender As Object, e As EventArgs) Handles btn300Cat6.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat6Ans(2)
        frmQuestionBoard.strQuestion = arrCat6Ques(2)
        If intDaDoCat = 6 And intDaDoPt = 3 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 600
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 300
        End If
        btn300Cat6.Enabled = False
        btn300Cat6.ForeColor = Color.White
    End Sub

    Private Sub btn400Cat1_Click(sender As Object, e As EventArgs) Handles btn400Cat1.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat1Ans(3)
        frmQuestionBoard.strQuestion = arrCat1Ques(3)
        If intDaDoCat = 1 And intDaDoPt = 4 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 800
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 400
        End If
        btn400Cat1.Enabled = False
        btn400Cat1.ForeColor = Color.White
    End Sub

    Private Sub btn400Cat2_Click(sender As Object, e As EventArgs) Handles btn400Cat2.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat2Ans(3)
        frmQuestionBoard.strQuestion = arrCat2Ques(3)
        If intDaDoCat = 2 And intDaDoPt = 4 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 800
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 400
        End If
        btn400Cat2.Enabled = False
        btn400Cat2.ForeColor = Color.White
    End Sub

    Private Sub btn400Cat3_Click(sender As Object, e As EventArgs) Handles btn400Cat3.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat3Ans(3)
        frmQuestionBoard.strQuestion = arrCat3Ques(3)
        If intDaDoCat = 3 And intDaDoPt = 4 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 800
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 400
        End If
        btn400Cat3.Enabled = False
        btn400Cat3.ForeColor = Color.White
    End Sub

    Private Sub btn400Cat4_Click(sender As Object, e As EventArgs) Handles btn400Cat4.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat4Ans(3)
        frmQuestionBoard.strQuestion = arrCat4Ques(3)
        If intDaDoCat = 4 And intDaDoPt = 4 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 800
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 400
        End If
        btn400Cat4.Enabled = False
        btn400Cat4.ForeColor = Color.White
    End Sub

    Private Sub btn400Cat5_Click(sender As Object, e As EventArgs) Handles btn400Cat5.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat5Ans(3)
        frmQuestionBoard.strQuestion = arrCat5Ques(3)
        If intDaDoCat = 5 And intDaDoPt = 4 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 800
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 400
        End If
        btn400Cat5.Enabled = False
        btn400Cat5.ForeColor = Color.White
    End Sub

    Private Sub btn400Cat6_Click(sender As Object, e As EventArgs) Handles btn400Cat6.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat6Ans(3)
        frmQuestionBoard.strQuestion = arrCat6Ques(3)
        If intDaDoCat = 6 And intDaDoPt = 4 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 800
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 400
        End If
        btn400Cat6.Enabled = False
        btn400Cat6.ForeColor = Color.White
    End Sub

    Private Sub btn500Cat1_Click(sender As Object, e As EventArgs) Handles btn500Cat1.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat1Ans(4)
        frmQuestionBoard.strQuestion = arrCat1Ques(4)
        If intDaDoCat = 1 And intDaDoPt = 5 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 1000
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 500
        End If
        btn500Cat1.Enabled = False
        btn500Cat1.ForeColor = Color.White
    End Sub

    Private Sub btn500Cat2_Click(sender As Object, e As EventArgs) Handles btn500Cat2.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat2Ans(4)
        frmQuestionBoard.strQuestion = arrCat2Ques(4)
        If intDaDoCat = 2 And intDaDoPt = 5 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 1000
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 500
        End If
        btn500Cat2.Enabled = False
        btn500Cat2.ForeColor = Color.White
    End Sub

    Private Sub btn500Cat3_Click(sender As Object, e As EventArgs) Handles btn500Cat3.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat3Ans(4)
        frmQuestionBoard.strQuestion = arrCat3Ques(4)
        If intDaDoCat = 3 And intDaDoPt = 5 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 1000
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 500
        End If
        btn500Cat3.Enabled = False
        btn500Cat3.ForeColor = Color.White
    End Sub

    Private Sub btn500Cat4_Click(sender As Object, e As EventArgs) Handles btn500Cat4.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat4Ans(4)
        frmQuestionBoard.strQuestion = arrCat4Ques(4)
        If intDaDoCat = 4 And intDaDoPt = 5 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 1000
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 500
        End If
        btn500Cat4.Enabled = False
        btn500Cat4.ForeColor = Color.White
    End Sub

    Private Sub btn500Cat5_Click(sender As Object, e As EventArgs) Handles btn500Cat5.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat5Ans(4)
        frmQuestionBoard.strQuestion = arrCat5Ques(4)
        If intDaDoCat = 5 And intDaDoPt = 5 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 1000
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 500
        End If
        btn500Cat5.Enabled = False
        btn500Cat5.ForeColor = Color.White
    End Sub

    Private Sub btn500Cat6_Click(sender As Object, e As EventArgs) Handles btn500Cat6.Click
        intCounter += 1
        frmAnsBoard.strAnswer = arrCat6Ans(4)
        frmQuestionBoard.strQuestion = arrCat6Ques(4)
        If intDaDoCat = 6 And intDaDoPt = 5 Then
            frmDailyDouble.Show()
            frmAnsBoard.intPoints = 1000
        Else
            frmAnsBoard.Show()
            frmAnsBoard.intPoints = 500
        End If
        btn500Cat6.Enabled = False
        btn500Cat6.ForeColor = Color.White
    End Sub

    Private Sub btnCategory1_Click(sender As Object, e As EventArgs) Handles btnCategory1.Click
        If intCounter = 30 Then
            frmFinalPoints.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnCategory2_Click(sender As Object, e As EventArgs) Handles btnCategory2.Click
        If intCounter = 30 Then
            frmFinalPoints.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnCategory3_Click(sender As Object, e As EventArgs) Handles btnCategory3.Click
        If intCounter = 30 Then
            frmFinalPoints.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnCategory4_Click(sender As Object, e As EventArgs) Handles btnCategory4.Click
        If intCounter = 30 Then
            frmFinalPoints.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnCategory5_Click(sender As Object, e As EventArgs) Handles btnCategory5.Click
        If intCounter = 30 Then
            frmFinalPoints.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnCategory6_Click(sender As Object, e As EventArgs) Handles btnCategory6.Click
            frmFinalPoints.Show()
            Me.Hide()
    End Sub

    
End Class