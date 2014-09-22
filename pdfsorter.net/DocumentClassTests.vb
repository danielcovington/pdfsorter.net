Imports System.Text
Imports NUnit.Framework
Imports pdfsorter.net.Pdf
Imports System


<TestFixture()> _
Public Class DocumentClassTests
    <Test()> _
    Public Sub CreateA_DocumentClass()
        Dim DocumentClass As New Document
        Assert.That(DocumentClass, [Is].InstanceOf(Of Document))

    End Sub

    <Test()> _
    Public Sub SubDucumentHasAPageNumber()

        Dim DocumentClass As New Document
        DocumentClass.PageNumber = 1
        Assert.AreEqual(1, DocumentClass.PageNumber)

    End Sub


    <Test()> _
    Public Sub SubDucumentHasPageText()

        Dim DocumentClass As New Document
        DocumentClass.PageText = "This is a Test"
        Assert.IsNotEmpty(DocumentClass.PageText)

    End Sub
End Class
