Module Module1

    Sub Main()
        Dim inputString1 As String = "babble"
        Dim inputString2 As String = "alpha"

        Dim output1 As String = FixStart(inputString1)
        Dim output2 As String = FixStart(inputString2)

        Console.WriteLine(output1)
        Console.WriteLine(output2)

        Console.ReadLine()
    End Sub

    Function FixStart(inputString As String) As String
        If inputString.Length < 2 Then
            Return inputString
        Else
            Dim firstChar As Char = inputString(0)

            Dim resultString As String = firstChar & inputString.Substring(1).Replace(firstChar, "*")

            Return resultString
        End If

    End Function

End Module
