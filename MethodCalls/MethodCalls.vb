'Payden Hoskins
'Spring 2025


Option Strict On
Option Explicit On

Module MethodCalls

    Sub Main()
        Dim myLuckyNumber As Integer = 7
        Console.WriteLine("Hello From Sub Main!")
        Console.WriteLine($"My Lucky Number is {myLuckyNumber}!")
        MyOtherSub()
        Console.WriteLine($"My Lucky Number is {myLuckyNumber}!")
    End Sub

    Sub MyOtherSub()
        Dim myLuckyNumber As Integer = 5
        Console.WriteLine("Hello from MyOtherSub!")
        Console.WriteLine($"My Lucky Number is {myLuckyNumber}!")
        SubSandWich()
    End Sub

    Sub SubSandWich(ByVal myLuckyNumber As Integer)

        Console.WriteLine("Hello From Sandwich")
        Console.WriteLine($"My Lucky Number is {myLuckyNumber}")
    End Sub
End Module
