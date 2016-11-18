Public Enum FTPDataType
    ''' <summary>
    ''' ASCII transfer
    ''' </summary>
    ASCII
    ''' <summary>
    ''' Binary transfer
    ''' </summary>
    <Xml.Serialization.XmlEnum("default")>
    Binary
    <Xml.Serialization.XmlEnum("")>
    DefaultAlias = Binary
End Enum