﻿Module MultplicationTable

    Sub Main()
        Dim userInput As Integer
        Dim result As String

        Console.WriteLine("Please enter a number you want a multiplication table of.")
        userInput = CInt(Console.ReadLine())
        Console.WriteLine($"Enjoy your {userInput} X {userInput} Multiplication Table:")

        For i As Integer = 1 To userInput

            For d As Integer = 1 To userInput

                result = CStr(i * d)
                result = result.PadLeft(4)
                Console.Write(result)

            Next

            Console.WriteLine()

        Next

    End Sub

End Module
