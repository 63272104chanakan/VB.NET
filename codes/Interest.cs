Imports System
Module Interest

    Public deposit, rate As Double
    Sub Main()
        Dim year1, year2 As Double
        rate = 0.02
        deposit = 10000

        year1 = deposit * (1 + rate)
        REM Console.WriteLine("First year = {0}", year1)
        year2 = deposit * (1 + rate)
        Console.WriteLine("First year = {0:c}", year2)
        Console.ReadLine()


    End Sub

End Module