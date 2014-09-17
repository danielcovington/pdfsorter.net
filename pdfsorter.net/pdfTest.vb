Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports pdfsorter.net.Pdf

<TestClass()> Public Class PdfTest

    <TestMethod()> Public Sub NewPdfHasZeroPagesWhenInitializedTest()
        Dim testPdf As Pdf = New Pdf()
        Assert.AreEqual(testPdf.GetNumberOfPages(), 0)
    End Sub

End Class