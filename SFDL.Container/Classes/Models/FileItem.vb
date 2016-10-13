Public Class FileItem
    Public Property FileName As String = String.Empty
    Public Property DirectoryRoot As String = String.Empty
    Public Property DirectoryPath As String = String.Empty
    Public Property FullPath As String = String.Empty
    Public Property FileSize As Long = 0
    Public Property HashType As HashType = HashType.None
    Public Property FileHash As String = String.Empty
    Public Property PackageName As String = String.Empty
End Class
