Public Class Form1

    Public state(1) As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker1.WorkerReportsProgress = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If BackgroundWorker1.IsBusy <> True Then
            BackgroundWorker1.RunWorkerAsync()
        End If



    End Sub

    Public Sub analyze_File(ByRef path As String, ByRef worker As System.ComponentModel.BackgroundWorker)

        Dim input_array(,) As String = Build_String_Array_From_Inputfile(path, worker)
        Dim filename As String = System.IO.Path.GetFileName(path)

       

    End Sub



  
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        navigate_Folder_Structure("E:\OneDrive\Documents\School\Thesis\Force Feedback\run_documents\Driving_Data\S102\S102_Baseline1", BackgroundWorker1)
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
                    ProgressBar1.Style = ProgressBarStyle.Marquee
                Case 2
                    Label_state.Text = "Building Array..."
                    ProgressBar1.Style = ProgressBarStyle.Continuous
                Case 3
                    Label_state.Text = "Analyzing File"
                Case 4
                    Label_state.Text = "Writting Output"
            End Select

        End If

        ProgressBar1.Value = e.ProgressPercentage

    End Sub
End Class
