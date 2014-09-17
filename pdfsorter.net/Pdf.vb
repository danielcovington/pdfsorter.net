Imports Microsoft.VisualBasic

Public Class Pdf
    Private numberOfPages As Integer

    Public Sub New()
        Me.numberOfPages = 0
    End Sub

    Public Function getNumberOfPages() As Integer
        Return Me.numberOfPages
    End Function

End Class
