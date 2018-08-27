<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpening
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpening))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBoard1 = New System.Windows.Forms.Button()
        Me.btnBoard2 = New System.Windows.Forms.Button()
        Me.btnBoard3 = New System.Windows.Forms.Button()
        Me.btnBoard4 = New System.Windows.Forms.Button()
        Me.btnBoard5 = New System.Windows.Forms.Button()
        Me.btnBoard6 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1149, 599)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnBoard1
        '
        Me.btnBoard1.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnBoard1.Font = New System.Drawing.Font("Perpetua Titling MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBoard1.ForeColor = System.Drawing.Color.Gold
        Me.btnBoard1.Location = New System.Drawing.Point(12, 617)
        Me.btnBoard1.Name = "btnBoard1"
        Me.btnBoard1.Size = New System.Drawing.Size(378, 106)
        Me.btnBoard1.TabIndex = 1
        Me.btnBoard1.Text = "Old Anime"
        Me.btnBoard1.UseVisualStyleBackColor = False
        '
        'btnBoard2
        '
        Me.btnBoard2.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnBoard2.Font = New System.Drawing.Font("Perpetua Titling MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBoard2.ForeColor = System.Drawing.Color.Gold
        Me.btnBoard2.Location = New System.Drawing.Point(396, 617)
        Me.btnBoard2.Name = "btnBoard2"
        Me.btnBoard2.Size = New System.Drawing.Size(378, 106)
        Me.btnBoard2.TabIndex = 2
        Me.btnBoard2.Text = "New Anime"
        Me.btnBoard2.UseVisualStyleBackColor = False
        '
        'btnBoard3
        '
        Me.btnBoard3.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnBoard3.Font = New System.Drawing.Font("Perpetua Titling MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBoard3.ForeColor = System.Drawing.Color.Gold
        Me.btnBoard3.Location = New System.Drawing.Point(781, 617)
        Me.btnBoard3.Name = "btnBoard3"
        Me.btnBoard3.Size = New System.Drawing.Size(380, 106)
        Me.btnBoard3.TabIndex = 3
        Me.btnBoard3.Text = "Cartoons"
        Me.btnBoard3.UseVisualStyleBackColor = False
        '
        'btnBoard4
        '
        Me.btnBoard4.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnBoard4.Font = New System.Drawing.Font("Perpetua Titling MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBoard4.ForeColor = System.Drawing.Color.Gold
        Me.btnBoard4.Location = New System.Drawing.Point(12, 728)
        Me.btnBoard4.Name = "btnBoard4"
        Me.btnBoard4.Size = New System.Drawing.Size(378, 106)
        Me.btnBoard4.TabIndex = 4
        Me.btnBoard4.Text = "Sci Fi"
        Me.btnBoard4.UseVisualStyleBackColor = False
        '
        'btnBoard5
        '
        Me.btnBoard5.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnBoard5.Font = New System.Drawing.Font("Perpetua Titling MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBoard5.ForeColor = System.Drawing.Color.Gold
        Me.btnBoard5.Location = New System.Drawing.Point(396, 728)
        Me.btnBoard5.Name = "btnBoard5"
        Me.btnBoard5.Size = New System.Drawing.Size(378, 106)
        Me.btnBoard5.TabIndex = 5
        Me.btnBoard5.Text = "Shoujo"
        Me.btnBoard5.UseVisualStyleBackColor = False
        '
        'btnBoard6
        '
        Me.btnBoard6.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnBoard6.Font = New System.Drawing.Font("Perpetua Titling MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBoard6.ForeColor = System.Drawing.Color.Gold
        Me.btnBoard6.Location = New System.Drawing.Point(783, 728)
        Me.btnBoard6.Name = "btnBoard6"
        Me.btnBoard6.Size = New System.Drawing.Size(378, 106)
        Me.btnBoard6.TabIndex = 6
        Me.btnBoard6.Text = "Shonen"
        Me.btnBoard6.UseVisualStyleBackColor = False
        '
        'frmOpening
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1173, 846)
        Me.Controls.Add(Me.btnBoard6)
        Me.Controls.Add(Me.btnBoard5)
        Me.Controls.Add(Me.btnBoard4)
        Me.Controls.Add(Me.btnBoard3)
        Me.Controls.Add(Me.btnBoard2)
        Me.Controls.Add(Me.btnBoard1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmOpening"
        Me.Text = "Opening"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnBoard1 As System.Windows.Forms.Button
    Friend WithEvents btnBoard2 As System.Windows.Forms.Button
    Friend WithEvents btnBoard3 As System.Windows.Forms.Button
    Friend WithEvents btnBoard4 As System.Windows.Forms.Button
    Friend WithEvents btnBoard5 As System.Windows.Forms.Button
    Friend WithEvents btnBoard6 As System.Windows.Forms.Button

End Class
