Public Class Program

    Public Shared Function Add(a As Integer, b As Integer)
        Return a + b
    End Function


    ''' <summary>
    ''' Prints Message
    ''' </summary>
    ''' <param name="message">message to print</param>
    ''' <returns>Language Name</returns>
    Public Sub Run(message As String)
        Console.WriteLine(message + " -From VisualBasic")
    End Sub

End Class
