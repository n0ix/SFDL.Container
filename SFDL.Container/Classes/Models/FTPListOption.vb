Public Enum FTPListOption
    ''' <summary>
    ''' Load the modify date using MDTM when it could not
    ''' be parsed from the server listing. This only pertains
    ''' to servers that do not implement the MLSD command.
    ''' </summary>
    Modify = 1
    ''' <summary>
    ''' Load the file size using the SIZE command when it
    ''' could not be parsed from the server listing. This
    ''' only pertains to servers that do not support the
    ''' MLSD command.
    ''' </summary>
    Size = 2
    ''' <summary>
    ''' Combines the Modify and Size flags
    ''' </summary>
    SizeModify = Modify Or Size
    ''' <summary>
    ''' Show hidden/dot files. This only pertains to servers
    ''' that do not support the MLSD command. This option
    ''' makes use the non standard -a parameter to LIST to
    ''' tell the server to show hidden files. Since it's a
    ''' non-standard option it may not always work. MLSD listings
    ''' have no such option and whether or not a hidden file is
    ''' shown is at the discretion of the server.
    ''' </summary>
    AllFiles = 4
    ''' <summary>
    ''' Force the use of the NLST command even if MLSD
    ''' is supported by the server
    ''' </summary>
    ForceList = 8
    ''' <summary>
    ''' Use the NLST command instead of LIST for a reliable file listing
    ''' </summary>
    <Xml.Serialization.XmlEnum("default")>
    NameList = 16
    ''' <summary>
    ''' Combines the ForceList and NameList flags
    ''' </summary>
    ForceNameList = ForceList Or NameList
    ''' <summary>
    ''' Try to dereference symbolic links
    ''' </summary>
    DerefLinks = 32
    ''' <summary>
    ''' Sets the ForceList flag and uses `LS' instead of `LIST' as the
    ''' command for getting a directory listing. This option overrides
    ''' ForceNameList and ignores the AllFiles flag.
    ''' </summary>
    UseLS = 64 Or ForceList
    ''' <summary>
    ''' Adds the -r option to the list command. Some servers may not
    ''' support this feature.
    ''' </summary>
    Recursive = 128
    <Xml.Serialization.XmlEnum("")>
    DefaultAlias = NameList
End Enum