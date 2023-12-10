Module Module1

    Sub Main()
        Dim inputStr As String
        Console.Write("Enter a string: ")
        inputStr = Console.ReadLine()

        Dim charToReplace As Char
        Console.Write("Enter the character to replace: ")
        charToReplace = Console.ReadKey().KeyChar
        Console.WriteLine()

        Dim replacementChar As Char
        Console.Write("Enter the replacement character: ")
        replacementChar = Console.ReadKey().KeyChar
        Console.WriteLine()


        Dim resultString As String

        Console.WriteLine($"Result:{resultString}")
        Console.ReadLine()
    End Sub

End Module
