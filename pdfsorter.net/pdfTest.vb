Imports System.Text
Imports NUnit.Framework
Imports pdfsorter.net.Pdf

<TestFixture()> _
Public Class PdfTest

    <Test()> _
    Public Sub NewPdfHasZeroPagesWhenInitializedTest()
        Dim testPdf As Pdf = New Pdf()
        Assert.AreEqual(testPdf.GetNumberOfPages(), 0)
    End Sub

End Class