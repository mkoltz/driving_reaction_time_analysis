Public Class Form1

    Public state(1) As String
    Dim startArray(10) As Integer
    Dim Trackarray(10, 18) As Array
    Dim numFilesProcessed As Integer = 0
    Dim outputFile As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker1.WorkerReportsProgress = True
        SaveFileDialog_outputFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        OpenFileDialog_signFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
    End Sub

    Public Sub setupSigns()

        Using lineCounter As New Microsoft.VisualBasic.FileIO.TextFieldParser(TextBox_signLocationFile.Text)
            lineCounter.TextFieldType = FileIO.FieldType.Delimited
            lineCounter.SetDelimiters(vbTab, ",")

            While Not lineCounter.EndOfData
                Dim currentLine As String()
                currentLine = lineCounter.ReadFields()
                Dim signArray(1) As Integer
                signArray(0) = currentLine(2)
                signArray(1) = currentLine(3)
                Trackarray(currentLine(0), currentLine(1)) = signArray
            End While

        End Using

    End Sub

    Private Sub Button_start_Click(sender As Object, e As EventArgs) Handles Button_start.Click
        outputFile = TextBox_outputFile.Text
        If BackgroundWorker1.IsBusy <> True Then
            BackgroundWorker1.RunWorkerAsync()
        End If

    End Sub

    Public Sub analyze_File(ByRef path As String, ByRef outputFile As String, ByRef worker As System.ComponentModel.BackgroundWorker)


        startArray(1) = 0
        startArray(2) = 3335
        startArray(3) = 6510
        startArray(4) = 9783
        startArray(5) = 12985
        startArray(6) = 16279
        startArray(7) = 19525
        startArray(8) = 22843
        startArray(9) = 26113
        startArray(10) = 29383

        setupSigns()

        worker.ReportProgress(0, {False, System.IO.Path.GetFileName(path), 3, numFilesProcessed})

        Dim count As Integer = 0
        Dim trackAverage As Double = 0
        Dim input_array(,) As String = Build_String_Array_From_Inputfile(path, worker)
        ' Dim input_array As ArrayList(,)
        Dim track As Byte = input_array(input_array.GetUpperBound(0), 5)

        Dim row As Integer = 1

        While input_array(row, 5) <> track
            row += 1
        End While

        worker.ReportProgress(0, {True, System.IO.Path.GetFileName(path), 3, numFilesProcessed})

        For signNum As Integer = 1 To 18

            Dim signVisible As Integer = Trackarray(track, signNum)(1) + startArray(track) - 80

            While input_array(row, 2) < signVisible
                row += 1
            End While

            Dim signVisibleTime As Double = input_array(row, 0)
            Dim angleReachedTime As Double

            Try
                While input_array(row, 4) < 3 And input_array(row, 4) > -3
                    row += 1
                End While
            
                angleReachedTime = input_array(row, 0)

            Catch ex As Exception
                angleReachedTime = signVisibleTime
            End Try

            Dim reactionTime As Double = angleReachedTime - signVisibleTime
            If (reactionTime > 100) Then
                trackAverage += reactionTime
                count += 1
            End If

            worker.ReportProgress((signNum / 18) * 100, {False, System.IO.Path.GetFileName(path), 3})
        Next

        trackAverage = Math.Round(trackAverage / count, 3)

        Using writer As New System.IO.StreamWriter(outputFile, True)
            writer.WriteLine(System.IO.Path.GetFileName(path) & vbTab & trackAverage & vbTab & count)
        End Using

        numFilesProcessed += 1
    End Sub


    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        FolderStructureNavigation.numFiles = 0
        numFilesProcessed = 0
        count_files(TextBox_inputFolder.Text, BackgroundWorker1)
        navigate_Folder_Structure(TextBox_inputFolder.Text, TextBox_outputFile.Text, BackgroundWorker1)
    End Sub

    Public newState As Boolean = False

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

        newState = e.UserState(0)
        'states
        '1 = counting lines 
        '2 = building array
        '3 = analyzing file 
        '4 = writing output

        If newState Then
            label_filename.Text = e.UserState(1)
            Select Case e.UserState(2)
                Case 1
                    Label_state.Text = "Counting Lines..."

                Case 2
                    Label_state.Text = "Building Array..."
                Case 3
                    Label_state.Text = "Analyzing File"

                Case 4
                    Label_state.Text = "Writting Output"
            End Select
        End If

        Try
            ProgressBar2.Value = (e.UserState(3) / numFiles) * 100
            Label_overalProgress.Text = e.UserState(3) & "/" & numFiles
        Catch ex As Exception

        End Try

        ProgressBar1.Value = e.ProgressPercentage

    End Sub

    Private Sub Button_inputFolderBrowse_Click(sender As Object, e As EventArgs) Handles Button_inputFolderBrowse.Click
        FolderBrowserDialog_inputFolder.SelectedPath = TextBox_inputFolder.Text

        Dim result As DialogResult = FolderBrowserDialog_inputFolder.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then
            TextBox_inputFolder.Text = FolderBrowserDialog_inputFolder.SelectedPath
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        SaveFileDialog_outputFile.InitialDirectory = System.IO.Path.GetDirectoryName(TextBox_outputFile.Text)

        Dim result As DialogResult = SaveFileDialog_outputFile.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then
            TextBox_outputFile.Text = SaveFileDialog_outputFile.FileName
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog_signFile.InitialDirectory = System.IO.Path.GetDirectoryName(TextBox_signLocationFile.Text)

        Dim result As DialogResult = OpenFileDialog_signFile.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then
            TextBox_signLocationFile.Text = OpenFileDialog_signFile.FileName
        End If

    End Sub
End Class
