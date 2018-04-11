Imports System.Xml
Imports System.Xml.XPath

Public Class FileHandler
    Public Function GetNodes(ByVal Path As String) As List(Of String)
        Dim Nodes As New List(Of String)
        Dim XMLDoc As New XmlDocument

        Try
            XMLDoc.Load("test.xml")
            Dim Root As XmlNode = XMLDoc.DocumentElement

            Dim NodeList As XmlNodeList = XMLDoc.SelectNodes("//File/Name")

            For Each node As XmlNode In NodeList
                Nodes.Add(node.OuterXml.ToLower)
            Next
        Catch XPathEx As XPathException
            Console.WriteLine(XPathEx.Message)
        Catch ex As Exception
            Console.WriteLine("Other exception")
        End Try

        Return Nodes
    End Function

End Class
