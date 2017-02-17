Public Class Form1
  Private mylist As List(Of Integer)
  Dim str As String
  Dim count As Integer

  Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
    Dim inValue As Double
    If IsNumeric(txtInput.Text) Then
      inValue = CDbl(txtInput.Text)
      mylist.Add(inValue)
      count += 1
    Else
      MessageBox.Show("Please enter a number!")
    End If
    If inValue > 100 Then
      MessageBox.Show("Please enter smaller value")
    End If
  End Sub

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ' list or data is created here' 
    mylist = New List(Of Integer)
  End Sub

  Private Sub btnFile_Click(sender As Object, e As EventArgs) Handles btnFile.Click
    Dim dlgResult As DialogResult
    Dim sr As IO.StreamReader
    Try
      OpenFileDialog1.FileName = "Hello"
      OpenFileDialog1.CheckFileExists = False
      OpenFileDialog1.Filter = "Databasefiles(*.mdb)|*.mdb|TextFiles(*.txt)|*.txt|All Files(*.*)|*.*"
      'OpenFileDialog1.InitialDirectory = Application.StartupPath
      dlgResult = OpenFileDialog1.ShowDialog()
      sr = New IO.StreamReader(OpenFileDialog1.FileName)
    Catch ex As Exception
      If dlgResult = Windows.Forms.DialogResult.OK Then
        MessageBox.Show("My error message: " & OpenFileDialog1.FileName)
      End If
    End Try
  End Sub

  Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
    If MsgBox("Are you sure you want to exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
      Me.Close()
    End If
  End Sub

  Private Sub btnSummary_Click(sender As Object, e As EventArgs) Handles btnSummary.Click
    Dim refNewForm As frmSecond
    Dim CurrentHighest As Integer = 0
    Dim CurrentLowest As Integer = 0
    refNewForm = New frmSecond
    refNewForm.Text = "Second Form"
    'refNewForm.numberOfScore.Text = "Hello"
    'checking number of score
    refNewForm.txt1.Text += count.ToString()
    'checking highest score
    For Each item As Integer In mylist
      If item > CurrentHighest Then CurrentHighest = item
    Next
    refNewForm.txt2.Text = CurrentHighest.ToString
    'checking lowest score
    For Each item As Integer In mylist
      If CurrentHighest > item Then CurrentLowest = item
    Next
    refNewForm.txt3.Text = CurrentLowest.ToString
    'checking avg score
    Dim sum, avg As Integer
    If mylist.Count() >= 2 Then
      sum = mylist.Sum()
      avg = sum / 2
    Else
      For i As Integer = 0 To mylist.Count - 1
        avg = mylist(i)
      Next
    End If
    refNewForm.txt4.Text = avg.ToString
    refNewForm.txt4.Enabled = False
    'checking Cs
    Dim count2 As Integer = 0
    For Each item As Integer In mylist
      If item >= 70 Then
        count2 += 1
      End If
    Next
    refNewForm.txt5.Text = count2.ToString
    refNewForm.ShowDialog()
  End Sub

  Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInput.KeyPress
    Select Case e.KeyChar
      Case "0"c To "9"c, "0"c To "9"c, "0"c To "9"c
        If txtInput.Text.Count() >= 3 Then
          e.Handled = True
        End If
      Case "0"c To "9"c
        'digits OK
      Case ControlChars.Back
        'backspace OK
      Case "."c
        If txtInput.Text.Contains(".") Then
          e.Handled = True
        End If
      Case Else
        e.Handled = True
    End Select
  End Sub


  Private Sub btnGetScores_Click(sender As Object, e As EventArgs) Handles btnGetScores.Click
    If mylist IsNot Nothing AndAlso mylist.Count = 0 Then
      MessageBox.Show("Yo, there is no score yet!")
    Else
      str = String.Join(",", mylist)
      MessageBox.Show("Scores: " & str)
    End If
  End Sub

  Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
    mylist.Clear()
    txtInput.Clear()
  End Sub

  Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
  End Sub
End Class
