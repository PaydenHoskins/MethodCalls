'Payden Hoskins
'Spring 2025


Option Strict On
Option Explicit On

Module MethodCalls

    Sub Main()
        Dim myLuckyNumber As Integer = 7
        Console.WriteLine("Hello From Sub Main!")
        Console.WriteLine($"My Lucky Number is {myLuckyNumber}!")
        Console.WriteLine()
        'MyOtherSub()
        'SandWich(myLuckyNumber)
        Marine(myLuckyNumber)
        Console.WriteLine($"My Lucky Number is {myLuckyNumber}!")
    End Sub

    Sub MyOtherSub()
        Dim myLuckyNumber As Integer = 5
        Console.WriteLine("Hello from MyOtherSub!")
        Console.WriteLine($"My Lucky Number is {myLuckyNumber}!")
        Console.WriteLine()

    End Sub

    Sub SandWich(ByVal myLuckyNumber As Integer)
        myLuckyNumber += 5
        Console.WriteLine("Hello From Sandwich")
        Console.WriteLine($"My Lucky Number is {myLuckyNumber}")
        Console.WriteLine()
    End Sub

    Sub Marine(ByRef myLuckyNumber As Integer)
        myLuckyNumber += 7
        Console.WriteLine("Hello From Marine")
        Console.WriteLine($"My Lucky Number is {myLuckyNumber}")
        Console.WriteLine()
    End Sub
End Module
