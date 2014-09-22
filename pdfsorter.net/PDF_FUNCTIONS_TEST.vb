Imports System.Text
Imports NUnit.Framework
Imports pdfsorter.net.Pdf
Imports System


<TestFixture()> _
Public Class PDF_FUNCTIONS_TEST

    <Test()> _
    Public Sub CreateDocumentsFromPDFRetunsA_Collection()

        Assert.That(CreateDocumentsFromPDF(), [Is].InstanceOf(Of Collection))

    End Sub

    <Test()> _
    Public Sub CreateA_DocumentClass()
        Dim DocumentClass As New Document

        Assert.That(DocumentClass, [Is].InstanceOf(Of Document))

    End Sub
End Class