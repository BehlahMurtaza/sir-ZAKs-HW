Module Module1

    Sub Main()
        Dim donutsCount1 As Integer = 5
        Dim donutsCount2 As Integer = 23

        Dim output1 As String = FormatDonuts(donutsCount1)
        Dim output2 As String = FormatDonuts(donutsCount2)

        Console.WriteLine(output1)
        Console.WriteLine(output2)

        Console.ReadLine()
    End Sub


    Function FormatDonuts(count As Integer) As String
        If count >= 10 Then
            Return "Number of donuts: many"
        Else
            Return $"Number of donuts: {count}"
        End If
        End Sub
    End Function
End Module
