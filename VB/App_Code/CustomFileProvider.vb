Imports DevExpress.Web
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Web

Public Class CustomFileProvider
    Inherits PhysicalFileSystemProvider

    Public Sub New(ByVal rootFolder As String)
        MyBase.New(rootFolder)
    End Sub
    
    Public Overrides Function GetFolders(ByVal parentFolder As FileManagerFolder) As IEnumerable(Of FileManagerFolder)
        Dim folders As New List(Of FileManagerFolder)(MyBase.GetFolders(parentFolder))
        Return folders.OrderByDescending(Function(a) a.Name)
    End Function
End Class
