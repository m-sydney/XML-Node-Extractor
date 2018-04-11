<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnXmlFile = New System.Windows.Forms.Button()
        Me.tbxXMLFile = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.tbxXMLPath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLoadXMLNode = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnXmlFile
        '
        Me.btnXmlFile.Location = New System.Drawing.Point(199, 12)
        Me.btnXmlFile.Name = "btnXmlFile"
        Me.btnXmlFile.Size = New System.Drawing.Size(120, 23)
        Me.btnXmlFile.TabIndex = 0
        Me.btnXmlFile.Text = "XML File"
        Me.btnXmlFile.UseVisualStyleBackColor = True
        '
        'tbxXMLFile
        '
        Me.tbxXMLFile.Location = New System.Drawing.Point(6, 12)
        Me.tbxXMLFile.Name = "tbxXMLFile"
        Me.tbxXMLFile.Size = New System.Drawing.Size(186, 22)
        Me.tbxXMLFile.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(6, 115)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(313, 164)
        Me.ListBox1.TabIndex = 2
        '
        'tbxXMLPath
        '
        Me.tbxXMLPath.Location = New System.Drawing.Point(6, 57)
        Me.tbxXMLPath.Name = "tbxXMLPath"
        Me.tbxXMLPath.Size = New System.Drawing.Size(310, 22)
        Me.tbxXMLPath.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "XML Path"
        '
        'btnLoadXMLNode
        '
        Me.btnLoadXMLNode.Location = New System.Drawing.Point(6, 81)
        Me.btnLoadXMLNode.Name = "btnLoadXMLNode"
        Me.btnLoadXMLNode.Size = New System.Drawing.Size(120, 23)
        Me.btnLoadXMLNode.TabIndex = 5
        Me.btnLoadXMLNode.Text = "Load Node(s)"
        Me.btnLoadXMLNode.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 303)
        Me.Controls.Add(Me.btnLoadXMLNode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbxXMLPath)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.tbxXMLFile)
        Me.Controls.Add(Me.btnXmlFile)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnXmlFile As Button
    Friend WithEvents tbxXMLFile As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents tbxXMLPath As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLoadXMLNode As Button
End Class
