Public Class Container

    Public Property Description As String
    Public Property Uploader As String
    Public Property ContainerVersion As Integer
    Public Property Encrypted As Boolean
    Public Property ConnectionInfo As Connection
    Public Property Packages As List(Of Package)
    Public Property MaxDownloadThreads As Integer
End Class
