Public Class Program

    ''' <summary>
    ''' Prints Message
    ''' </summary>
    ''' <param name="message">message to print</param>
    ''' <returns>Language Name</returns>
    Public Function Run(message As String) As String
        Console.WriteLine(message + " -From VisualBasic")
        Return "VisualBasic"
    End Function

End Class
