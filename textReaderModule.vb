Module textReaderModule
    Public Function Build_String_Array_From_Inputfile(ByRef inputFilename As String, ByRef worker As System.ComponentModel.BackgroundWorker, ByVal lineLength As Integer) As String(,)
        Dim numLines As Integer = 0
        Dim longestLine As Integer = 0
        Dim filename As String = System.IO.Path.GetFileName(inputFilename)

        numLines = System.IO.File.ReadAllLines(inputFilename).Length

        Dim file() As String = System.IO.File.ReadAllLines(inputFilename)

        'dimension the output array based on the size requirements determined above
        Dim outputArray(numLines - 1, lineLength) As String

        worker.ReportProgress(0, {True, filename, 2})
        For x As Integer = 1 To file.GetUpperBound(0)
            Dim row() As String
            If lineLength = 6 Then
                row = file(x).Split(vbTab)
            Else
                row = file(x).Split(",")
            End If


            For y As Integer = 0 To row.GetUpperBound(0)
                outputArray(x, y) = row(y)
            Next
        Next

        Return outputArray

    End Function
End Module
