Module Module1

    Sub Main()
        Dim inputStr As String
        Console.Write("Enter a string: ")
        inputStr = Console.ReadLine()

        Dim vowelsCount As Dictionary(Of Char, Integer) = CountVowels(inputStr)

        For Each kvp As KeyValuePair(Of Char, Integer) In vowelsCount
            Console.WriteLine($"Count of {kvp.Key}: {kvp.Value}")
        Next

        Console.ReadLine()
    End Sub

    Function CountVowels(inputString As String) As Dictionary(Of Char, Integer)
        Dim vowels As Char() = {"a", "e", "i", "o", "u", "A", "E", "I", "O", "U"}

        Dim vowelsCount As New Dictionary(Of Char, Integer)()

        For Each c As Char In inputString
            If vowels.Contains(c) Then
                If vowelsCount.ContainsKey(c) Then
                    vowelsCount(c) += 1
                Else
                    vowelsCount(c) = 1
                End If
            End If
        Next

        Return vowelsCount
    End Function
End Module

