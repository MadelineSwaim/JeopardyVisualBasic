<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDailyDouble
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDailyDouble))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCont = New System.Windows.Forms.Button()
        Me.btnSound = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1201, 642)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnCont
        '
        Me.btnCont.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCont.Font = New System.Drawing.Font("Perpetua Titling MT", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCont.ForeColor = System.Drawing.Color.White
        Me.btnCont.Location = New System.Drawing.Point(626, 660)
        Me.btnCont.Name = "btnCont"
        Me.btnCont.Size = New System.Drawing.Size(280, 69)
        Me.btnCont.TabIndex = 1
        Me.btnCont.Text = "Continue"
        Me.btnCont.UseVisualStyleBackColor = False
        '
        'btnSound
        '
        Me.btnSound.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnSound.Font = New System.Drawing.Font("Perpetua Titling MT", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSound.ForeColor = System.Drawing.Color.White
        Me.btnSound.Location = New System.Drawing.Point(261, 660)
        Me.btnSound.Name = "btnSound"
        Me.btnSound.Size = New System.Drawing.Size(280, 69)
        Me.btnSound.TabIndex = 2
        Me.btnSound.Text = "Sound"
        Me.btnSound.UseVisualStyleBackColor = False
        '
        'frmDailyDouble
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1225, 742)
        Me.Controls.Add(Me.btnSound)
        Me.Controls.Add(Me.btnCont)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmDailyDouble"
        Me.Text = "frmDailyDouble"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCont As System.Windows.Forms.Button
    Friend WithEvents btnSound As System.Windows.Forms.Button
End Class
