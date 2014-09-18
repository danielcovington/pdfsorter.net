Imports System.Text
Imports NUnit.Framework


<TestFixture()> _
Public Class PDF_FUNCTIONS_TEST

    <Test()> _
    Public Sub CreateDocumentsFromPDFRetunsSomething()
        Dim Somthing As Integer
        Somthing = CreateDocumentsFromPDF()
    End Sub

End Class