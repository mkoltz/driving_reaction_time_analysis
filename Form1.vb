Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        navigate_Folder_Structure("E:\OneDrive\Documents\School\Thesis\Force Feedback\run_documents\Driving_Data\S102\S102_Baseline1", BackgroundWorker1)

    End Sub

    Public Sub analyze_File(ByRef filename As String, ByRef worker As System.ComponentModel.BackgroundWorker)

        Dim input_array(,) As String = Build_String_Array_From_Inputfile(filename)


    End Sub

End Class
