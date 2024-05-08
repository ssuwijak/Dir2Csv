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
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.chkSubFolder = New System.Windows.Forms.CheckBox()
		Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
		Me.btnClear1 = New System.Windows.Forms.Button()
		Me.btnBrowseFile = New System.Windows.Forms.Button()
		Me.btnBrowseFolder = New System.Windows.Forms.Button()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.btnOpenFolder = New System.Windows.Forms.Button()
		Me.btnStartStop = New System.Windows.Forms.Button()
		Me.btnClear2 = New System.Windows.Forms.Button()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.chkSubFolder)
		Me.GroupBox1.Controls.Add(Me.ProgressBar1)
		Me.GroupBox1.Controls.Add(Me.btnClear1)
		Me.GroupBox1.Controls.Add(Me.btnBrowseFile)
		Me.GroupBox1.Controls.Add(Me.btnBrowseFolder)
		Me.GroupBox1.Controls.Add(Me.TextBox1)
		Me.GroupBox1.Location = New System.Drawing.Point(4, 5)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(554, 259)
		Me.GroupBox1.TabIndex = 6
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Target Folder(s) :"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(6, 212)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(39, 13)
		Me.Label1.TabIndex = 13
		Me.Label1.Text = "Label1"
		'
		'chkSubFolder
		'
		Me.chkSubFolder.AutoSize = True
		Me.chkSubFolder.Location = New System.Drawing.Point(253, 23)
		Me.chkSubFolder.Name = "chkSubFolder"
		Me.chkSubFolder.Size = New System.Drawing.Size(114, 17)
		Me.chkSubFolder.TabIndex = 12
		Me.chkSubFolder.Text = "include sub-folders"
		Me.chkSubFolder.UseVisualStyleBackColor = True
		'
		'ProgressBar1
		'
		Me.ProgressBar1.Location = New System.Drawing.Point(6, 228)
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.ProgressBar1.Size = New System.Drawing.Size(540, 21)
		Me.ProgressBar1.TabIndex = 10
		'
		'btnClear1
		'
		Me.btnClear1.Location = New System.Drawing.Point(425, 19)
		Me.btnClear1.Name = "btnClear1"
		Me.btnClear1.Size = New System.Drawing.Size(121, 23)
		Me.btnClear1.TabIndex = 7
		Me.btnClear1.Text = "Clear"
		Me.btnClear1.UseVisualStyleBackColor = True
		'
		'btnBrowseFile
		'
		Me.btnBrowseFile.Location = New System.Drawing.Point(126, 19)
		Me.btnBrowseFile.Name = "btnBrowseFile"
		Me.btnBrowseFile.Size = New System.Drawing.Size(121, 23)
		Me.btnBrowseFile.TabIndex = 6
		Me.btnBrowseFile.Text = "Multi-Folders Upload"
		Me.btnBrowseFile.UseVisualStyleBackColor = True
		'
		'btnBrowseFolder
		'
		Me.btnBrowseFolder.Location = New System.Drawing.Point(6, 19)
		Me.btnBrowseFolder.Name = "btnBrowseFolder"
		Me.btnBrowseFolder.Size = New System.Drawing.Size(114, 23)
		Me.btnBrowseFolder.TabIndex = 5
		Me.btnBrowseFolder.Text = "Single Folder"
		Me.btnBrowseFolder.UseVisualStyleBackColor = True
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(6, 48)
		Me.TextBox1.Multiline = True
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.TextBox1.Size = New System.Drawing.Size(540, 161)
		Me.TextBox1.TabIndex = 4
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.btnOpenFolder)
		Me.GroupBox2.Controls.Add(Me.btnStartStop)
		Me.GroupBox2.Controls.Add(Me.btnClear2)
		Me.GroupBox2.Controls.Add(Me.TextBox2)
		Me.GroupBox2.Controls.Add(Me.btnSave)
		Me.GroupBox2.Location = New System.Drawing.Point(4, 270)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(554, 83)
		Me.GroupBox2.TabIndex = 7
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Exporting Result :"
		'
		'btnOpenFolder
		'
		Me.btnOpenFolder.Location = New System.Drawing.Point(126, 19)
		Me.btnOpenFolder.Name = "btnOpenFolder"
		Me.btnOpenFolder.Size = New System.Drawing.Size(114, 23)
		Me.btnOpenFolder.TabIndex = 9
		Me.btnOpenFolder.Text = "Open"
		Me.btnOpenFolder.UseVisualStyleBackColor = True
		'
		'btnStartStop
		'
		Me.btnStartStop.Location = New System.Drawing.Point(432, 19)
		Me.btnStartStop.Name = "btnStartStop"
		Me.btnStartStop.Size = New System.Drawing.Size(114, 23)
		Me.btnStartStop.TabIndex = 8
		Me.btnStartStop.Text = "Start"
		Me.btnStartStop.UseVisualStyleBackColor = True
		'
		'btnClear2
		'
		Me.btnClear2.Location = New System.Drawing.Point(312, 19)
		Me.btnClear2.Name = "btnClear2"
		Me.btnClear2.Size = New System.Drawing.Size(114, 23)
		Me.btnClear2.TabIndex = 7
		Me.btnClear2.Text = "Clear"
		Me.btnClear2.UseVisualStyleBackColor = True
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(6, 48)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(540, 20)
		Me.TextBox2.TabIndex = 6
		'
		'btnSave
		'
		Me.btnSave.Location = New System.Drawing.Point(6, 19)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(114, 23)
		Me.btnSave.TabIndex = 5
		Me.btnSave.Text = "Save As"
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(563, 368)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents btnClear1 As Button
	Friend WithEvents btnBrowseFile As Button
	Friend WithEvents btnBrowseFolder As Button
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents btnSave As Button
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents ProgressBar1 As ProgressBar
	Friend WithEvents chkSubFolder As CheckBox
	Friend WithEvents Label1 As Label
	Friend WithEvents btnClear2 As Button
	Friend WithEvents btnStartStop As Button
	Friend WithEvents btnOpenFolder As Button
End Class
