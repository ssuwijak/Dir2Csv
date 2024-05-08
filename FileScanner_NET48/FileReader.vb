Imports System.IO
Imports System.Text

Public Class FileReader


	Public Function Read(filePath As String) As String
		Dim sb As New StringBuilder
		Using sr As New StreamReader(filePath, True)
			sb.Append(sr.ReadToEnd)
		End Using

		Return sb.ToString
	End Function
End Class
