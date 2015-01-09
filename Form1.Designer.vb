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
        Me.Button_start = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label_state = New System.Windows.Forms.Label()
        Me.label_filename = New System.Windows.Forms.Label()
        Me.TextBox_signLocationFile = New System.Windows.Forms.TextBox()
        Me.TextBox_outputFile = New System.Windows.Forms.TextBox()
        Me.TextBox_inputFolder = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Label_overalProgress = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button_inputFolderBrowse = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog_inputFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog_signFile = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog_outputFile = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_start
        '
        Me.Button_start.Location = New System.Drawing.Point(435, 183)
        Me.Button_start.Name = "Button_start"
        Me.Button_start.Size = New System.Drawing.Size(75, 23)
        Me.Button_start.TabIndex = 0
        Me.Button_start.Text = "Start"
        Me.Button_start.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(27, 57)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(530, 10)
        Me.ProgressBar1.TabIndex = 1
        '
        'Label_state
        '
        Me.Label_state.AutoSize = True
        Me.Label_state.Location = New System.Drawing.Point(82, 41)
        Me.Label_state.Name = "Label_state"
        Me.Label_state.Size = New System.Drawing.Size(16, 13)
        Me.Label_state.TabIndex = 2
        Me.Label_state.Text = "---"
        '
        'label_filename
        '
        Me.label_filename.AutoSize = True
        Me.label_filename.Location = New System.Drawing.Point(82, 25)
        Me.label_filename.Name = "label_filename"
        Me.label_filename.Size = New System.Drawing.Size(16, 13)
        Me.label_filename.TabIndex = 3
        Me.label_filename.Text = "---"
        '
        'TextBox_signLocationFile
        '
        Me.TextBox_signLocationFile.Location = New System.Drawing.Point(26, 133)
        Me.TextBox_signLocationFile.Name = "TextBox_signLocationFile"
        Me.TextBox_signLocationFile.Size = New System.Drawing.Size(484, 20)
        Me.TextBox_signLocationFile.TabIndex = 4
        Me.TextBox_signLocationFile.Text = "E:\OneDrive\Documents\School\Thesis\Force Feedback\run_documents\LCTSigns.txt"
        '
        'TextBox_outputFile
        '
        Me.TextBox_outputFile.Location = New System.Drawing.Point(26, 82)
        Me.TextBox_outputFile.Name = "TextBox_outputFile"
        Me.TextBox_outputFile.Size = New System.Drawing.Size(484, 20)
        Me.TextBox_outputFile.TabIndex = 5
        Me.TextBox_outputFile.Text = "E:\OneDrive\Documents\School\Thesis\Force Feedback\run_documents\reactionTime2.tx" & _
    "t"
        '
        'TextBox_inputFolder
        '
        Me.TextBox_inputFolder.Location = New System.Drawing.Point(26, 33)
        Me.TextBox_inputFolder.Name = "TextBox_inputFolder"
        Me.TextBox_inputFolder.Size = New System.Drawing.Size(484, 20)
        Me.TextBox_inputFolder.TabIndex = 6
        Me.TextBox_inputFolder.Text = "E:\OneDrive\Documents\School\Thesis\Force Feedback\run_documents\Driving_Data\S10" & _
    "2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Filename:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Status:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Overall:"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(29, 108)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(528, 11)
        Me.ProgressBar2.TabIndex = 10
        '
        'Label_overalProgress
        '
        Me.Label_overalProgress.AutoSize = True
        Me.Label_overalProgress.Location = New System.Drawing.Point(82, 92)
        Me.Label_overalProgress.Name = "Label_overalProgress"
        Me.Label_overalProgress.Size = New System.Drawing.Size(16, 13)
        Me.Label_overalProgress.TabIndex = 11
        Me.Label_overalProgress.Text = "---"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label_overalProgress)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.ProgressBar2)
        Me.GroupBox1.Controls.Add(Me.Label_state)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.label_filename)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 212)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 132)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Process Status"
        '
        'Button_inputFolderBrowse
        '
        Me.Button_inputFolderBrowse.Location = New System.Drawing.Point(516, 31)
        Me.Button_inputFolderBrowse.Name = "Button_inputFolderBrowse"
        Me.Button_inputFolderBrowse.Size = New System.Drawing.Size(75, 23)
        Me.Button_inputFolderBrowse.TabIndex = 13
        Me.Button_inputFolderBrowse.Text = "Browse"
        Me.Button_inputFolderBrowse.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(516, 82)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Browse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(516, 131)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Browse"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Input Directory"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Output File"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Sign Data File"
        '
        'OpenFileDialog_signFile
        '
        Me.OpenFileDialog_signFile.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 356)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button_inputFolderBrowse)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox_inputFolder)
        Me.Controls.Add(Me.TextBox_outputFile)
        Me.Controls.Add(Me.TextBox_signLocationFile)
        Me.Controls.Add(Me.Button_start)
        Me.Name = "Form1"
        Me.Text = "Reaction Time"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_start As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label_state As System.Windows.Forms.Label
    Friend WithEvents label_filename As System.Windows.Forms.Label
    Friend WithEvents TextBox_signLocationFile As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_outputFile As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_inputFolder As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label_overalProgress As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_inputFolderBrowse As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog_inputFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog_signFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog_outputFile As System.Windows.Forms.SaveFileDialog

End Class
