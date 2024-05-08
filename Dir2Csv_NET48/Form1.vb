Imports System.IO
Imports System.Text

Public Class Form1
	Private _isRunning As Boolean = False
	Private Sub RunningMode(isRunning As Boolean)
		_isRunning = isRunning
		GroupBox1.Enabled = Not isRunning
		GroupBox2.Enabled = Not isRunning
	End Sub
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.Text = Application.ProductName
		TextBox1.Clear()
		TextBox2.Clear()
		Label1.Text = ""

		With ProgressBar1
			.Minimum = 0
			.Maximum = 100
			.Value = 0
		End With
	End Sub
	Private Function browseFolder() As String
		Dim ret As String = ""

		Dim fbd As New FolderBrowserDialog

		With fbd
			.Reset()
			.RootFolder = Environment.SpecialFolder.MyComputer
			.SelectedPath = Environment.CurrentDirectory
		End With

		If fbd.ShowDialog() = DialogResult.OK Then
			ret = fbd.SelectedPath
		End If

		Return ret
	End Function
	Private Sub btnBrowseFolder_Click(sender As Object, e As EventArgs) Handles btnBrowseFolder.Click
		Dim x As String = browseFolder().Trim

		If Not String.IsNullOrEmpty(x) Then
			TextBox1.Clear()
			TextBox1.Text = x
		End If
	End Sub
	Private Function browseFile() As String
		Dim ret As String = ""

		Dim ofd As New OpenFileDialog()

		With ofd
			.Reset()
			.Multiselect = False

			.InitialDirectory = Environment.CurrentDirectory
			.RestoreDirectory = True

			.DefaultExt = "txt"
			.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
			.FilterIndex = 0
		End With

		If ofd.ShowDialog() = DialogResult.OK Then
			ret = ofd.FileName
		End If

		Return ret
	End Function
	Private Sub btnBrowseFile_Click(sender As Object, e As EventArgs) Handles btnBrowseFile.Click
		Dim filePath As String = browseFile().Trim

		If Not String.IsNullOrEmpty(filePath) Then
			Dim freader As New FileReader

			TextBox1.Clear()
			TextBox1.Text = freader.Read(filePath)
		End If

	End Sub
	Private Sub btnClear1_Click(sender As Object, e As EventArgs) Handles btnClear1.Click
		TextBox1.Clear()
	End Sub
	Private Sub btnClear2_Click(sender As Object, e As EventArgs) Handles btnClear2.Click
		TextBox2.Clear()
	End Sub
	Private Function saveAs() As String
		Dim ret As String = ""

		Dim sfd As New SaveFileDialog()

		With sfd
			.Reset()
			.CheckFileExists = False
			.CheckPathExists = True

			.InitialDirectory = Environment.CurrentDirectory
			.RestoreDirectory = True

			.DefaultExt = "csv"
			.Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt|All files (*.*)|*.*"
			.FilterIndex = 0
		End With

		If sfd.ShowDialog() = DialogResult.OK Then
			ret = sfd.FileName
		End If

		Return ret
	End Function
	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
		Dim filePath As String = saveAs().Trim

		If Not String.IsNullOrEmpty(filePath) Then
			TextBox2.Clear()
			TextBox2.Text = filePath
		End If
	End Sub
	Private Sub btnOpenFolder_Click(sender As Object, e As EventArgs) Handles btnOpenFolder.Click
		Dim targetPath As String = TextBox2.Text.Trim

		If String.IsNullOrEmpty(targetPath) Then
			MessageBox.Show("the exporting result has not yet specified", "Open the exporting result folder", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
		Else
			targetPath = Path.GetDirectoryName(targetPath)
			Process.Start("explorer.exe", targetPath)
		End If
	End Sub
	Private Sub btnStartStop_Click(sender As Object, e As EventArgs) Handles btnStartStop.Click
		RunningMode(True)

		Try
			If chkInputBeforeRun() Then
				If chkOutputFileBeforeRun(TextBox2.Text) Then
					With ProgressBar1
						.Value = 0
						.Minimum = 0
						.Maximum = 0
					End With

					scan()
				End If
			End If

		Catch ex As Exception

		End Try

		Label1.Text = $"done ... {Date.Now:d-MMM-yyyy HH:mm:ss}"

		RunningMode(False)
	End Sub
	Private Function chkInputBeforeRun() As Boolean
		Dim ret As Boolean = False
		Dim s As String = TextBox1.Text.Trim

		If String.IsNullOrEmpty(s) Then
			MessageBox.Show("no target folder(s) to operate", "Check the target folder(s) to operate", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		Else
			ret = True
		End If

		Return ret
	End Function
	Private Function chkOutputFileBeforeRun(outputFilePath As String) As Boolean
		Dim ret As Boolean = False
		Dim title As String = "Check the loacation of the exporting result file"

		Dim p As String = outputFilePath.Trim

		If String.IsNullOrEmpty(p) Then
			MessageBox.Show($"result file = '{p}'{vbCrLf}{vbCrLf}invalid file path", title, MessageBoxButtons.OK, MessageBoxIcon.Error)
		ElseIf Not Directory.Exists(Path.GetDirectoryName(p)) Then
			MessageBox.Show($"result file = '{p}'{vbCrLf}{vbCrLf}invalid path or path not exist", title, MessageBoxButtons.OK, MessageBoxIcon.Error)
		ElseIf File.Exists(p) Then
			ret = MessageBox.Show($"result file = '{p}' already exist{vbCrLf}{vbCrLf}do you want to append the existing one ?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes
		Else
			ret = True
		End If

		Return ret
	End Function
	Private Sub scan()
		Dim sb As New StringBuilder
		sb.Append(TextBox1.Text.Trim)
		If sb.Length = 0 Then Return

		Dim pos() As Integer = {0, 0, 0, 0}
		pos(0) = 0
		pos(1) = sb.ToString.IndexOf(vbLf, pos(0))
		pos(2) = sb.Length
		pos(3) = pos(1) - pos(0) + 1

		Dim path As String = ""

		While pos(0) < pos(2)
			pos(1) = sb.ToString.IndexOf(Environment.NewLine, pos(0))
			If pos(1) = -1 Then
				pos(1) = pos(2)
			End If

			path = sb.ToString(pos(0), pos(1) - pos(0))

			scan(path, chkSubFolder.Checked)

			pos(0) = pos(1) + Environment.NewLine.Length
		End While

		Return
	End Sub
	Private Sub scan(path As String, Optional subfolders As Boolean = False)
		Dim p As String = path.Trim

		If String.IsNullOrEmpty(p) Then Return

		Dim di As New DirectoryInfo(p)

		If di.Exists Then
			Label1.Text = p
			ProgressBar1.Maximum += di.GetFiles.Length

			Using sw As New StreamWriter(TextBox2.Text, True)

				Try
					sw.WriteLine(writeHeader(","))

					For Each f As FileInfo In di.GetFiles
						'Debug.Print(write(f, ","))

						sw.WriteLine(write(f, ","))

						ProgressBar1.Value += 1
						Application.DoEvents()
					Next

				Catch ex As Exception

				End Try

			End Using

			If subfolders Then
				For Each d As DirectoryInfo In di.GetDirectories
					scan(d.FullName, subfolders)
				Next
			End If
		End If

	End Sub
	Private Function writeHeader(Optional separator As String = " ") As String
		Dim headers() As String = {"Path", "FileName", "Size", "Created Date", "Modified Date"}
		Return String.Join(separator, headers)
	End Function
	Private Function write(f As FileInfo, Optional separator As String = " ") As String
		Return String.Join(separator, f.DirectoryName, f.Name, f.Length.ToString, f.CreationTime.ToString("d-MMM-yy HH:mm:ss"), f.LastWriteTime.ToString("d-MMM-yy HH:mm:ss"))
	End Function


End Class
