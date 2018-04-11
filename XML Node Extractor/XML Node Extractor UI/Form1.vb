Imports System.IO
Imports XML_Node_Extractor
Imports System.Xml.XPath
Imports System.Xml
Public Class Form1
    Private Handler As New FileHandler
    Private FilePath As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxXMLFile.ReadOnly = True
        tbxXMLPath.Enabled = False
        btnLoadXMLNode.Enabled = False
    End Sub
    Private Sub btnXmlFile_Click(sender As Object, e As EventArgs) Handles btnXmlFile.Click
        Dim Browser As New OpenFileDialog
        Browser.ShowDialog()
        FilePath = Browser.FileName

        Try
            tbxXMLFile.Text = Path.GetFileName(FilePath)
            Check(FilePath)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tbxXMLPath_TextChanged(sender As Object, e As EventArgs) Handles tbxXMLPath.TextChanged
        Dim pathlength As Integer = tbxXMLPath.Text.Length

        If (pathlength < 1) Then
            btnLoadXMLNode.Enabled = False
            lbxNodes.Items.Clear()
        Else
            btnLoadXMLNode.Enabled = True
        End If
    End Sub

    Private Sub btnLoadXMLNode_Click(sender As Object, e As EventArgs) Handles btnLoadXMLNode.Click
        lbxNodes.Items.Clear()
        Try
            Dim XPath As String = tbxXMLPath.Text
            For Each node As String In Handler.GetNodes(FilePath, XPath)
                lbxNodes.Items.Add(node)
            Next

        Catch XPathEx As XPathException
            MessageBox.Show("XPath provided is not a valid path")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Check(ByVal FilePath As String)
        If (Not tbxXMLFile.Text.Length().Equals(0) And Path.GetExtension(FilePath).ToLower.Substring(1) = "xml") Then
            tbxXMLPath.Enabled = True

        Else
            tbxXMLPath.Enabled = False
            btnLoadXMLNode.Enabled = False

            If (Not Path.GetExtension(FilePath).ToLower.Substring(1) = "xml") Then
                MessageBox.Show("Please make sure the selected file is of type XML.")
            End If
        End If
    End Sub


End Class
