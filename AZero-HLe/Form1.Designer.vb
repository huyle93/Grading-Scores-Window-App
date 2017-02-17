<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    Me.btnSummary = New System.Windows.Forms.Button()
    Me.txtInput = New System.Windows.Forms.TextBox()
    Me.btnGetScores = New System.Windows.Forms.Button()
    Me.btnEnter = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.btnClear = New System.Windows.Forms.Button()
    Me.btnFile = New System.Windows.Forms.Button()
    Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
    Me.btnExit = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'btnSummary
    '
    Me.btnSummary.Location = New System.Drawing.Point(205, 109)
    Me.btnSummary.Name = "btnSummary"
    Me.btnSummary.Size = New System.Drawing.Size(75, 23)
    Me.btnSummary.TabIndex = 0
    Me.btnSummary.Text = "Summary"
    Me.btnSummary.UseVisualStyleBackColor = True
    '
    'txtInput
    '
    Me.txtInput.Location = New System.Drawing.Point(12, 112)
    Me.txtInput.Name = "txtInput"
    Me.txtInput.Size = New System.Drawing.Size(100, 20)
    Me.txtInput.TabIndex = 1
    Me.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'btnGetScores
    '
    Me.btnGetScores.Location = New System.Drawing.Point(121, 212)
    Me.btnGetScores.Name = "btnGetScores"
    Me.btnGetScores.Size = New System.Drawing.Size(75, 23)
    Me.btnGetScores.TabIndex = 2
    Me.btnGetScores.Text = "Get Scores"
    Me.btnGetScores.UseVisualStyleBackColor = True
    '
    'btnEnter
    '
    Me.btnEnter.Location = New System.Drawing.Point(121, 109)
    Me.btnEnter.Name = "btnEnter"
    Me.btnEnter.Size = New System.Drawing.Size(75, 23)
    Me.btnEnter.TabIndex = 3
    Me.btnEnter.Text = "Enter"
    Me.btnEnter.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 40)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(143, 13)
    Me.Label1.TabIndex = 4
    Me.Label1.Text = "Type a score and click Enter"
    '
    'btnClear
    '
    Me.btnClear.Location = New System.Drawing.Point(205, 40)
    Me.btnClear.Name = "btnClear"
    Me.btnClear.Size = New System.Drawing.Size(75, 23)
    Me.btnClear.TabIndex = 5
    Me.btnClear.Text = "Clear"
    Me.btnClear.UseVisualStyleBackColor = True
    '
    'btnFile
    '
    Me.btnFile.Location = New System.Drawing.Point(12, 212)
    Me.btnFile.Name = "btnFile"
    Me.btnFile.Size = New System.Drawing.Size(75, 23)
    Me.btnFile.TabIndex = 6
    Me.btnFile.Text = "File"
    Me.btnFile.UseVisualStyleBackColor = True
    '
    'OpenFileDialog1
    '
    Me.OpenFileDialog1.FileName = "OpenFileDialog1"
    '
    'btnExit
    '
    Me.btnExit.Location = New System.Drawing.Point(205, 212)
    Me.btnExit.Name = "btnExit"
    Me.btnExit.Size = New System.Drawing.Size(75, 23)
    Me.btnExit.TabIndex = 7
    Me.btnExit.Text = "Exit"
    Me.btnExit.UseVisualStyleBackColor = True
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(292, 273)
    Me.Controls.Add(Me.btnExit)
    Me.Controls.Add(Me.btnFile)
    Me.Controls.Add(Me.btnClear)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.btnEnter)
    Me.Controls.Add(Me.btnGetScores)
    Me.Controls.Add(Me.txtInput)
    Me.Controls.Add(Me.btnSummary)
    Me.Name = "Form1"
    Me.Text = "Quiz Score Program"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnSummary As System.Windows.Forms.Button
  Friend WithEvents txtInput As System.Windows.Forms.TextBox
  Friend WithEvents btnGetScores As System.Windows.Forms.Button
  Friend WithEvents btnEnter As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents btnClear As System.Windows.Forms.Button
  Friend WithEvents btnFile As System.Windows.Forms.Button
  Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
  Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
