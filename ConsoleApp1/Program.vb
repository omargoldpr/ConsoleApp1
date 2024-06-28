Imports System

Module Program
    Sub Main()
        Dim address As New Address("123 Main St", "Anytown", "12345")
        Dim job As New Job("Software Engineer", "Tech Corp", 90000D)
        Dim person As New Person("John Doe", 30, address, job)

        person.DisplayInfo()

        Console.ReadLine()
    End Sub
End Module

