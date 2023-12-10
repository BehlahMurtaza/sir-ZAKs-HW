Module Module1

    Sub Main()
        Dim inputStr As String
        Console.Write("Enter a string: ")
        inputStr = Console.ReadLine()

        Dim charToCount As Char
        Console.Write("Enter a character to count: ")
        charToCount = Console.ReadKey().KeyChar
        Console.WriteLine()

        CountAndOutput(inputStr, charToCount)

        Console.ReadLine()
    End Sub

    Private Sub CountAndOutput(inputStr As String, charToCount As Char)
        Throw New NotImplementedException()
    End Sub
End Module
