

Module PDF_FUNCTIONS
    Sub main()

    End Sub
    Function CreateDocumentsFromPDF()

        Dim PdfLibrary As Object
        Dim comType As Type
        Dim Documents As New Collection
        comType = Nothing
        'Accounts For 32 bit and 64 bit builds----------------------------------------
        If IntPtr.Size = 4 Then
            comType = Type.GetTypeFromProgID("DebenuPDFLibraryAX1013.PDFLibrary")
        End If
        If IntPtr.Size = 8 Then
            comType = Type.GetTypeFromProgID("DebenuPDFLibrary64AX1013.PDFLibrary")
        End If
        If comType IsNot Nothing Then
            PdfLibrary = Activator.CreateInstance(comType)
        End If
        '-----------------------------------------------------------------------------

        If PdfLibrary.UnlockKey("j564z3wi9i66k93cp3r798b3y") <> 1 Then
            CreateDocumentsFromPDF = Nothing
            Exit Function
        End If
        PdfLibrary.loadfromFile("knoBill.pdf", "")

        CreateDocumentsFromPDF = Documents

    End Function
End Module
