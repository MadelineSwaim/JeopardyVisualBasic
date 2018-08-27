<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnsBoard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.cmbPlayer = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCorrect = New System.Windows.Forms.Button()
        Me.btnWrong = New System.Windows.Forms.Button()
        Me.btnNoAns = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAnswer
        '
        Me.txtAnswer.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtAnswer.Font = New System.Drawing.Font("Perpetua Titling MT", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.ForeColor = System.Drawing.Color.White
        Me.txtAnswer.Location = New System.Drawing.Point(111, 85)
        Me.txtAnswer.Multiline = True
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(929, 311)
        Me.txtAnswer.TabIndex = 0
        Me.txtAnswer.Text = "This is a text box that will hold the answer for the selected Question."
        Me.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbPlayer
        '
        Me.cmbPlayer.Font = New System.Drawing.Font("Perpetua Titling MT", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPlayer.FormattingEnabled = True
        Me.cmbPlayer.Items.AddRange(New Object() {"Player 1", "Player 2", "Player 3"})
        Me.cmbPlayer.Location = New System.Drawing.Point(111, 509)
        Me.cmbPlayer.Name = "cmbPlayer"
        Me.cmbPlayer.Size = New System.Drawing.Size(168, 40)
        Me.cmbPlayer.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(123, 467)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Player"
        '
        'btnCorrect
        '
        Me.btnCorrect.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCorrect.Font = New System.Drawing.Font("Perpetua Titling MT", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCorrect.ForeColor = System.Drawing.Color.Black
        Me.btnCorrect.Location = New System.Drawing.Point(382, 491)
        Me.btnCorrect.Name = "btnCorrect"
        Me.btnCorrect.Size = New System.Drawing.Size(227, 68)
        Me.btnCorrect.TabIndex = 3
        Me.btnCorrect.Text = "Correct"
        Me.btnCorrect.UseVisualStyleBackColor = False
        '
        'btnWrong
        '
        Me.btnWrong.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnWrong.Font = New System.Drawing.Font("Perpetua Titling MT", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWrong.ForeColor = System.Drawing.Color.Black
        Me.btnWrong.Location = New System.Drawing.Point(640, 491)
        Me.btnWrong.Name = "btnWrong"
        Me.btnWrong.Size = New System.Drawing.Size(227, 68)
        Me.btnWrong.TabIndex = 4
        Me.btnWrong.Text = "Wrong"
        Me.btnWrong.UseVisualStyleBackColor = False
        '
        'btnNoAns
        '
        Me.btnNoAns.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnNoAns.Font = New System.Drawing.Font("Perpetua Titling MT", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNoAns.ForeColor = System.Drawing.Color.Black
        Me.btnNoAns.Location = New System.Drawing.Point(898, 491)
        Me.btnNoAns.Name = "btnNoAns"
        Me.btnNoAns.Size = New System.Drawing.Size(227, 68)
        Me.btnNoAns.TabIndex = 5
        Me.btnNoAns.Text = "Close"
        Me.btnNoAns.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnRefresh.Font = New System.Drawing.Font("Perpetua Titling MT", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.Black
        Me.btnRefresh.Location = New System.Drawing.Point(443, 11)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(227, 68)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'frmAnsBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(1167, 618)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnNoAns)
        Me.Controls.Add(Me.btnWrong)
        Me.Controls.Add(Me.btnCorrect)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbPlayer)
        Me.Controls.Add(Me.txtAnswer)
        Me.Name = "frmAnsBoard"
        Me.Text = "frmAnsBoard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents cmbPlayer As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCorrect As System.Windows.Forms.Button
    Friend WithEvents btnWrong As System.Windows.Forms.Button
    Friend WithEvents btnNoAns As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
End Class
