Imports Microsoft.VisualBasic

Public Class Person
    Private _name As String
    Private _age As Integer
    Private _address As Address
    Private _job As Job

    Public Sub New(name As String, age As Integer, address As Address, job As Job)
        _name = name
        _age = age
        _address = address
        _job = job
    End Sub

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Age As Integer
        Get
            Return _age
        End Get
        Set(value As Integer)
            _age = value
        End Set
    End Property

    Public Property Address As Address
        Get
            Return _address
        End Get
        Set(value As Address)
            _address = value
        End Set
    End Property

    Public Property Job As Job
        Get
            Return _job
        End Get
        Set(value As Job)
            _job = value
        End Set
    End Property

    Public Sub DisplayInfo()
        Dim result As Integer = 10
        Console.WriteLine("Name: " & _name)
        Console.WriteLine("Age: " & _age)
        Console.WriteLine("Address: " & _address.FullAddress)
        Console.WriteLine("Job: " & _job.JobTitle & " at " & _job.Company)
        Logger.LogMethodCall(Me.GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, $"name={_name}, age={_age}, address={_address.FullAddress}, job = {_job.JobTitle}", result.ToString())
    End Sub
End Class

