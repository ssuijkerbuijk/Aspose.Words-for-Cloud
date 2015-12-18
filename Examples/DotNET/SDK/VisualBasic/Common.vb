Imports System.IO
Imports Aspose.Cloud

Class Common
    Public Shared APP_SID As String = ""
    Public Shared APP_KEY As String = ""
    Public Shared FOLDER As String = ""
    Public Shared STORAGE As String = ""

    Public Shared Function GetDataDir() As String
        Dim parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent
        Dim startDirectory As String = Nothing
        If parent IsNot Nothing Then
            Dim directoryInfo = parent.Parent
            If directoryInfo IsNot Nothing Then
                startDirectory = directoryInfo.FullName
            End If
        Else
            startDirectory = parent.FullName
        End If
        Return Path.Combine(startDirectory, "Data\")
    End Function
    Public Shared Sub UploadFile(fileName As String, subdirectory As String)
        ' The path to the documents directory.
        Dim dataDir As String = Common.GetDataDir()

        If subdirectory <> String.Empty Then
            dataDir = (dataDir & subdirectory) + "\"
        End If
        StorageService.File.UploadFile(dataDir & fileName, fileName, storage:=Common.STORAGE)
    End Sub
    Public Shared Function DownloadFile(fileName As String, subdirectory As String) As String
        ' The path to the documents directory.
        Dim dataDir As String = Common.GetDataDir()

        If subdirectory <> String.Empty Then
            dataDir = (dataDir & subdirectory) + "\"
        End If

        ' Download output file from cloud storage and save on local directory
        dataDir = dataDir & GetOutputFilePath(fileName, True)
        StorageService.File.DownloadFile(GetOutputFilePath(fileName, True), dataDir, 0, storage:=Common.STORAGE)

        Return dataDir
    End Function
    Public Shared Function GetOutputFilePath(inputFilePath As [String], withExtension As Boolean) As String
        Dim extension As String = Path.GetExtension(inputFilePath)
        Dim filename As String = Path.GetFileNameWithoutExtension(inputFilePath)
        If withExtension Then
            Return Convert.ToString(filename & Convert.ToString("_out_")) & extension
        Else
            Return filename & Convert.ToString("_out_")
        End If
    End Function
    Public Shared ReadOnly Property WordsService() As WordsService
        Get
            CheckCredentials()
            Dim w As New WordsService(APP_SID, APP_KEY)
            Return w
        End Get
    End Property

    Public Shared ReadOnly Property StorageService() As StorageService
        Get
            CheckCredentials()
            Dim s As New StorageService(APP_SID, APP_KEY)
            Return s
        End Get
    End Property

    Private Shared Sub CheckCredentials()
        If [String].IsNullOrEmpty(APP_SID) OrElse [String].IsNullOrEmpty(APP_KEY) Then
            Console.WriteLine("APP_SID and APP_KEY must have valid values. Check " + System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName + " for details.")
            Environment.[Exit](1)
        End If
    End Sub
End Class

