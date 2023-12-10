Module Module1

    Sub Main()
        Dim string1 As String = "mix"
        Dim string2 As String = "pod"
        Dim output1 As String = MixString(string1, string2)

        Dim string3 As String = "dog"
        Dim string4 As String = "dinner"
        Dim output2 As String = MixString(string3, string4)

        Console.WriteLine(output1)
        Console.WriteLine(output2)

        Console.ReadLine()
    End Sub

    Function MixString(a As String, b As String) As String

        If a.Length >= 2 AndAlso b.Length >= 2 Then

            Return b.Substring(0, 2) & a.Substring(2) & " " & a.Substring(0, 2) & b.Substring(2)
        Else

            Return ""
        End If
    End Function


End Module
