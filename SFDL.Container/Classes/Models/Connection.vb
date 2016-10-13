Public Class Connection
    Public Property Host As String = String.Empty
    Public Property Port As Integer = 21
    Public Property Username As String = String.Empty
    Public Property Password As String = String.Empty
    Public Property AuthRequired As Boolean = False
    Public Property DataConnectionType As FTPDataConnectionType = FTPDataConnectionType.Passive
    Public Property DataType As FTPDataType = FTPDataType.Binary
    Public Property CharacterEncoding As CharacterEncoding = CharacterEncoding.Standard
    'Public Property ListMethod As FTPListOption = FTPListOption.NameList 'Evtl. entfernen
    'Public Property SpecialServerMode As Boolean = False
    Public Property SSLProtocol As Security.Authentication.SslProtocols = Security.Authentication.SslProtocols.None
    Public Property ConnectTimeout As Integer = 10
    Public Property CommandTimeout As Integer = 10

End Class
