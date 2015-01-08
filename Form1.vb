Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        navigate_Folder_Structure("E:\OneDrive\Documents\School\Thesis\Force Feedback\run_documents\Driving_Data\S102\S102_Baseline1", BackgroundWorker1)

    End Sub

    Public Sub analyze_File(ByRef path As String, ByRef worker As System.ComponentModel.BackgroundWorker)

        Dim input_array(,) As String = Build_String_Array_From_Inputfile(path)

        Dim filename As String = System.IO.Path.GetFileName(path)

        Using writer As New System.IO.StreamWriter("E:\OneDrive\Documents\School\Thesis\Force Feedback\run_documents\Driving_Data\S102\sampled\" & filename, False)

            Dim time, xPos, yPos, sAngle As Double
            Dim counter As Byte = 0
            Dim track_started As Boolean = False

            For x As Integer = 1 To input_array.GetUpperBound(0)

                If input_array(x, 5) = input_array(input_array.GetUpperBound(0), 5) Then
                    track_started = True
                End If


                If track_started Then
                    If counter < 14 Then

                        time = time + input_array(x, 0)
                        xPos = xPos + input_array(x, 1)
                        yPos = yPos + input_array(x, 2)
                        sAngle = sAngle + input_array(x, 4)
                        counter += 1

                    End If


                    If (counter = 14) Then
                        time = Math.Round(time / 14, 0)
                        xPos = Math.Round(xPos / 14, 2)
                        yPos = Math.Round(yPos / 14, 2)
                        sAngle = Math.Round(sAngle / 14, 1)

                        writer.WriteLine(time & vbTab & xPos & vbTab & yPos & vbTab & sAngle)
                        counter = 0
                        time = 0
                        xPos = 0
                        yPos = 0
                        sAngle = 0

                    End If
                End If

            Next

            time = Math.Round(time / counter, 0)
            xPos = Math.Round(xPos / counter, 2)
            yPos = Math.Round(yPos / counter, 2)
            sAngle = Math.Round(sAngle / counter, 1)

            writer.WriteLine(time & vbTab & xPos & vbTab & yPos & vbTab & sAngle)
            counter = 0
            time = 0
            xPos = 0
            yPos = 0
            sAngle = 0

        End Using

    End Sub

End Class
