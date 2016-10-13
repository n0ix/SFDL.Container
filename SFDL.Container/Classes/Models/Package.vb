Public Class Package
    Public Property Name As String = String.Empty
    Public Property FileList As New List(Of FileItem)
    Public Property BulkFolderMode As Boolean = False
    Public Property BulkFolderList As New List(Of BulkFolder)
End Class
