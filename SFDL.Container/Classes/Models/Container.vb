Public Class Container

    Public Property Description As String = String.Empty
    Public Property Uploader As String = String.Empty
    Public Property ContainerVersion As Integer = 0
    Public Property Encrypted As Boolean = False
    Public Property Connection As Connection
    Public Property Packages As New List(Of Package)
    Public Property MaxDownloadThreads As Integer = 3
End Class
