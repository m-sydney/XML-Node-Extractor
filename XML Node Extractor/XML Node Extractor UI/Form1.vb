Imports System.IO
Imports System.Windows.Forms
Imports XML_Node_Extractor
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxXMLFile.ReadOnly = True
        tbxXMLPath.Enabled = False
        btnLoadXMLNode.Enabled = False
    End Sub
    Private Sub btnXmlFile_Click(sender As Object, e As EventArgs) Handles btnXmlFile.Click
        Dim Browser As New OpenFileDialog
        Browser.ShowDialog()
        Dim FilePath As String = Browser.FileName

        Try
            tbxXMLFile.Text = Path.GetFileName(FilePath)
            Check(FilePath)


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLoadXMLNode_Click(sender As Object, e As EventArgs) Handles btnLoadXMLNode.Click

    End Sub

    Private Sub Check(ByVal FilePath As String)
        If (Not tbxXMLFile.Text.Length().Equals(0) And Path.GetExtension(FilePath).ToLower.Substring(1) = "xml") Then
            tbxXMLPath.Enabled = True
            btnLoadXMLNode.Enabled = True
        Else
            tbxXMLPath.Enabled = False
            btnLoadXMLNode.Enabled = False

            If (Not Path.GetExtension(FilePath).ToLower.Substring(1) = "xml") Then
                MessageBox.Show("Please make sure the selected file is of type XML.")
            End If
        End If
    End Sub


End Class
