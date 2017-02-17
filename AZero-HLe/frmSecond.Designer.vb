<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSecond
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
    Me.numberOfScore = New System.Windows.Forms.Label()
    Me.highestScore = New System.Windows.Forms.Label()
    Me.lowestScore = New System.Windows.Forms.Label()
    Me.avgScore = New System.Windows.Forms.Label()
    Me.numberOfCs = New System.Windows.Forms.Label()
    Me.txt1 = New System.Windows.Forms.TextBox()
    Me.txt2 = New System.Windows.Forms.TextBox()
    Me.txt3 = New System.Windows.Forms.TextBox()
    Me.txt4 = New System.Windows.Forms.TextBox()
    Me.txt5 = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'numberOfScore
    '
    Me.numberOfScore.AutoSize = True
    Me.numberOfScore.Location = New System.Drawing.Point(19, 47)
    Me.numberOfScore.Name = "numberOfScore"
    Me.numberOfScore.Size = New System.Drawing.Size(87, 13)
    Me.numberOfScore.TabIndex = 0
    Me.numberOfScore.Text = "Number of Score"
    '
    'highestScore
    '
    Me.highestScore.AutoSize = True
    Me.highestScore.Location = New System.Drawing.Point(32, 80)
    Me.highestScore.Name = "highestScore"
    Me.highestScore.Size = New System.Drawing.Size(74, 13)
    Me.highestScore.TabIndex = 1
    Me.highestScore.Text = "Highest Score"
    '
    'lowestScore
    '
    Me.lowestScore.AutoSize = True
    Me.lowestScore.Location = New System.Drawing.Point(32, 115)
    Me.lowestScore.Name = "lowestScore"
    Me.lowestScore.Size = New System.Drawing.Size(72, 13)
    Me.lowestScore.TabIndex = 2
    Me.lowestScore.Text = "Lowest Score"
    '
    'avgScore
    '
    Me.avgScore.AutoSize = True
    Me.avgScore.Location = New System.Drawing.Point(26, 141)
    Me.avgScore.Name = "avgScore"
    Me.avgScore.Size = New System.Drawing.Size(78, 13)
    Me.avgScore.TabIndex = 3
    Me.avgScore.Text = "Average Score"
    '
    'numberOfCs
    '
    Me.numberOfCs.AutoSize = True
    Me.numberOfCs.Location = New System.Drawing.Point(12, 173)
    Me.numberOfCs.Name = "numberOfCs"
    Me.numberOfCs.Size = New System.Drawing.Size(113, 13)
    Me.numberOfCs.TabIndex = 4
    Me.numberOfCs.Text = "Number of Cs or better"
    '
    'txt1
    '
    Me.txt1.Location = New System.Drawing.Point(127, 47)
    Me.txt1.Name = "txt1"
    Me.txt1.ReadOnly = True
    Me.txt1.Size = New System.Drawing.Size(100, 20)
    Me.txt1.TabIndex = 5
    Me.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'txt2
    '
    Me.txt2.Location = New System.Drawing.Point(127, 80)
    Me.txt2.Name = "txt2"
    Me.txt2.ReadOnly = True
    Me.txt2.Size = New System.Drawing.Size(100, 20)
    Me.txt2.TabIndex = 6
    Me.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'txt3
    '
    Me.txt3.Location = New System.Drawing.Point(127, 108)
    Me.txt3.Name = "txt3"
    Me.txt3.ReadOnly = True
    Me.txt3.Size = New System.Drawing.Size(100, 20)
    Me.txt3.TabIndex = 7
    Me.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'txt4
    '
    Me.txt4.Location = New System.Drawing.Point(127, 134)
    Me.txt4.Name = "txt4"
    Me.txt4.ReadOnly = True
    Me.txt4.Size = New System.Drawing.Size(100, 20)
    Me.txt4.TabIndex = 8
    Me.txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'txt5
    '
    Me.txt5.Location = New System.Drawing.Point(127, 166)
    Me.txt5.Name = "txt5"
    Me.txt5.ReadOnly = True
    Me.txt5.Size = New System.Drawing.Size(100, 20)
    Me.txt5.TabIndex = 9
    Me.txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(83, 20)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(110, 13)
    Me.Label1.TabIndex = 10
    Me.Label1.Text = "Quiz Scores Summary"
    '
    'frmSecond
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(292, 273)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.txt5)
    Me.Controls.Add(Me.txt4)
    Me.Controls.Add(Me.txt3)
    Me.Controls.Add(Me.txt2)
    Me.Controls.Add(Me.txt1)
    Me.Controls.Add(Me.numberOfCs)
    Me.Controls.Add(Me.avgScore)
    Me.Controls.Add(Me.lowestScore)
    Me.Controls.Add(Me.highestScore)
    Me.Controls.Add(Me.numberOfScore)
    Me.Name = "frmSecond"
    Me.Text = "Form2"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents numberOfScore As System.Windows.Forms.Label
  Friend WithEvents highestScore As System.Windows.Forms.Label
  Friend WithEvents lowestScore As System.Windows.Forms.Label
  Friend WithEvents avgScore As System.Windows.Forms.Label
  Friend WithEvents numberOfCs As System.Windows.Forms.Label
  Friend WithEvents txt1 As System.Windows.Forms.TextBox
  Friend WithEvents txt2 As System.Windows.Forms.TextBox
  Friend WithEvents txt3 As System.Windows.Forms.TextBox
  Friend WithEvents txt4 As System.Windows.Forms.TextBox
  Friend WithEvents txt5 As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
