Module textReaderModule
    Public Function Build_String_Array_From_Inputfile(ByRef inputFilename As String) As String(,)
        Dim numLines As Integer = 0
        Dim longestLine As Integer = 0

        'analyze the text file to determine the required array dimensions 
        Using lineCounter As New Microsoft.VisualBasic.FileIO.TextFieldParser(inputFilename)
            lineCounter.TextFieldType = FileIO.FieldType.Delimited
            lineCounter.SetDelimiters(vbTab, ",")

            While Not lineCounter.EndOfData
                Dim currentLineLength As Integer
                currentLineLength = lineCounter.ReadFields().Length

                If currentLineLength > longestLine Then
                    longestLine = currentLineLength
                End If

                numLines = numLines + 1
            End While

        End Using

        'dimension the output array based on the size requirements determined above
        Dim outputArray(numLines - 1, longestLine - 1) As String


        Using myReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(inputFilename)

            myReader.TextFieldType = FileIO.FieldType.Delimited
            myReader.SetDelimiters(",", vbTab)


            Dim currentRow As String()
            Dim index, elementNumber As Integer
            index = 0
            elementNumber = 0

            While Not myReader.EndOfData

                'read the current row into a string array 
                currentRow = myReader.ReadFields

                For Each element In currentRow
                    'add each item in the currentRow string array to the output array
                    outputArray(index, elementNumber) = element
                    elementNumber = elementNumber + 1
                Next

                'move to the next index in the array
                elementNumber = 0
                index = index + 1
            End While

        End Using

        Return outputArray

    End Function
End Module
