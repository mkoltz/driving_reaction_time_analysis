Module FolderStructureNavigation

    Public numFiles As Integer = 0

    Public Sub navigate_Folder_Structure(ByRef rootDirectory As String, ByRef outputFilename As String, ByVal worker As System.ComponentModel.BackgroundWorker)

        If My.Computer.FileSystem.GetDirectories(rootDirectory).Count > 0 Then

            For Each folder As String In My.Computer.FileSystem.GetDirectories(rootDirectory)
                navigate_Folder_Structure(folder, outputFilename, worker)
            Next

        Else
            For Each file As String In My.Computer.FileSystem.GetFiles(rootDirectory)

                Call Form1.analyze_File(file, outputFilename, worker)

            Next
        End If

    End Sub


    Public Sub count_files(ByRef rootDirectory As String, ByVal worker As System.ComponentModel.BackgroundWorker)
        If My.Computer.FileSystem.GetDirectories(rootDirectory).Count > 0 Then

            For Each folder As String In My.Computer.FileSystem.GetDirectories(rootDirectory)
                count_files(folder, worker)
            Next

        Else
            For Each file As String In My.Computer.FileSystem.GetFiles(rootDirectory)

                numFiles += 1

            Next
        End If
    End Sub

End Module
