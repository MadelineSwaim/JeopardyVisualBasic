Public Class frmSciFiBoard
    Dim arrCat1Ans = New String() {"This character shot first.", "Luke's aunt and uncle had this job on Tatooine", "C-3P0 is roughly fluent in this many languages.", "This species stole the plans to the Death Star.", "AT-AT stands for this."}
    Dim arrCat2Ans = New String() {"This actor played the 10th doctor.", "This companion was introduced in the episode 'Silence in the Library'", "The Christmas special of this year featured a spaceship called the Titanic.", "These antagonists are a race of alien cyborgs that were genetically modified from the Kaled race by Davros.", "The Cybermen were first introduced during this four part special in season 4."}
    Dim arrCat3Ans = New String() {"If you wore a red shirt in a story, it was likely this would happen to you.", "This is what the T in James T. Kirk stands for.", "The mission was supposed to last this long as per the opening monologue.", "This person told Nichelle Nichols that her role on Star Trek was important to the black community in general.", "This was the name of the man who existed in both the positive universe and the negative universe."}
    Dim arrCat4Ans = New String() {"This is where Captain Picard was born.", "Data's creator.", "Throughout the Enterprise, there is a system of maintenance shafts of this name that must be crawled through.", "Before the Enterprise, Captain Picard served as Lieutenant Commander of this starship.", "Main engineering is located on this deck."}
    Dim arrCat5Ans = New String() {"This member of the Serenity crew has a gun called Vera.", "This is what the ship Serenity is named after.", "This is the name of the planet that originated the Reavers.", "This future star had one of his first roles as the young Simon in 'Ariel'.", "Shepard Book give Kaylee this kind of fruit upon joining the crew of Serenity in the pilot."}
    Dim arrCat6Ans = New String() {"This series centers on the premise of a ring-shaped portal that enables rapid transportation to another portal located up to cosmic distances away.", "The main character in this series was captured by the Minbari and they thought he was the reincarnation of Valen.", "This series was originally created by Glen A. Larson in 1978.", "This was the first movie to ever have an official website. It was set up by Dean Devlin in 1994 and featured images, trailers and behind the scenes clips and actor information.", "This bounty hunter in The Empire Strikes Back is wearing an old costume from a Doctor Who episode."}

    Dim arrCat1Ques = New String() {"Who is Han Solo?", "What is Moisture farming?", "What is the significance of 6 million?", "What are Bothans?", "What is ‘All Terrain Armored Transport’?"}
    Dim arrCat2Ques = New String() {"Who is David Tennant?", "Who is River Song?", "What is the significance of 2007?", "What are Daleks?", "What is ‘The Tenth Planet’?"}
    Dim arrCat3Ques = New String() {"What characters died?", "What is Tiberius?", "What is the significance of 5 years?", "Who is Martin Luther King, Jr.?", "Who is Lazarus?"}
    Dim arrCat4Ques = New String() {"What is La Barre, France?", "Who is Noonian Soong?", "What are the Jefferies Tubes?", "What is USS Stargazer?", "What is the significance of 36?"}
    Dim arrCat5Ques = New String() {"Who is Jayne Cobb?", "What was a major battle in the War of Unification?", "What is Miranda?", "Who is Zac Efron?", "What is the significance of a Strawberry?"}
    Dim arrCat6Ques = New String() {"What is Stargate?", "What is Babylon 5?", "What is Battlestar Galactica?", "What is Stargate?", "Who is Bossk?"}

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