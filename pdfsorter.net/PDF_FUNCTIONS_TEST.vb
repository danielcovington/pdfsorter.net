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

End Class