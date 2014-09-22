Public Class Document
    Private intPageNumber As Int16
    Private strPageText As String

    Public Property PageNumber() As Int16
        Get
            PageNumber = intPageNumber
        End Get

        Set(value As Int16)
            intPageNumber = value
        End Set
    End Property

    Public Property PageText() As String
        Get
            PageText = strPageText

        End Get
        Set(value As String)
            strPageText = value
        End Set
    End Property

End Class
