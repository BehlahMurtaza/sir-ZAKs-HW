Module Module1

    Sub Main()
        Dim inputString As String = "This dinner is not that bad!"

        Dim output As String = ReplaceNotBad(inputString)

        Console.WriteLine(output)

        Console.ReadLine()
    End Sub

    Function ReplaceNotBad(inputString As String) As String
        Dim indexOfNot As Integer = inputString.IndexOf("not")

        Dim indexOfBad As Integer = inputString.IndexOf("bad")

        If indexOfNot <> -1 AndAlso indexOfBad <> -1 AndAlso indexOfBad > indexOfNot Then
            Return inputString.Substring(0, indexOfNot) & "good" & inputString.Substring(indexOfBad + 3)
        Else

            Return inputString
        End If
    End Function

End Module
