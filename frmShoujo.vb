﻿Public Class frmShoujo
    Dim arrCat1Ans = New String() {"This is where Tohru was living before Shigure and Yuki took her in.", "Yuki's nickname at school.", "They are the monkey in the zodiac.", "Momiji's White Day gift for Tohru.", "This character raised Kyo as his own son."}
    Dim arrCat2Ans = New String() {"Hunny's rabbit's name.", "The Younger Hitachiin twin.", "This is Haruhi's dad's professional name.", "Tamaki is half-Japanese and half this ethnicity.", "Mori is the national champion of this."}
    Dim arrCat3Ans = New String() {"Sakura's last name.", "The creator of the Clow Cards.", "The mysterious woman who helps Sakura win the Final Judgement.", "Sakura is given this item to win the Final Judgement.", "This character is featured ONLY in the anime, and does NOT appear in the manga."}
    Dim arrCat4Ans = New String() {"The name of the school.", "Yuki was this old when Kaname found her.", "Rima & Shiki's job.", "This character Kills Rido in the end.", "They are Yuki's birth parents."}
    Dim arrCat5Ans = New String() {"The kind of animal Haru finds and keeps.", "This character has the highest grades.", "Haru dumps a drink on Shizuku’s head for this reason.", "This is Natsume’s nickname for Shizuku.", "Shizuku’s nickname in grade school."}
    Dim arrCat6Ans = New String() {"The character Nozaki bases his female protagonist on in his manga.", "This is the best thing to stand on.", "Sakura and Nozaki hate this creature. ", "The name of Nozaki’s manga.", "The publisher of the manga."}

    Dim arrCat1Ques = New String() {"What is the significance of a tent?", "Who is Prince Yuki?", "Who is Ritsu?", "What is the significance of a trip to a Hot Springs Resort?", "Who is Kazuma?"}
    Dim arrCat2Ques = New String() {"Who is Usa-Chan or Bun-Bun?", "Who is Kaoru?", "Who is Ranka?", "What is French?", "What is Kendo?"}
    Dim arrCat3Ques = New String() {"What is Kinomoto?", "Who is Clow Reed?", "Who is Ms. Mizuki?", "What is the Bell of the Moon?", "Who is Meilin?"}
    Dim arrCat4Ques = New String() {"What is Cross Academy?", "What is the significance of 5?", "Who are Models?", "Who is Zero Kiryu?", "Who is Haruka and Juri?"}
    Dim arrCat5Ques = New String() {"What is a chicken? ", "Who is Haru?", "What is saying that his friends were just using him?", "Who is Mitty?", "Who is Dry Ice? "}
    Dim arrCat6Ques = New String() {"Who is Mikoto Mikoshiba?", "What are boxes?", "What is a Tanuki/Raccoon Dog?", "What is ‘Let’s Fall in Love’?", "What is Monthly Girl’s Romance?"}

    Dim intCounter As Integer = 0
    Dim intDaDoCat As Integer = 0
    Dim intDaDoPt As Integer = 0

    Private Sub frmShoujo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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