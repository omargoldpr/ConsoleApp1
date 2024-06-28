Imports Microsoft.VisualBasic

Public Class Job
    Private _jobTitle As String
    Private _company As String
    Private _salary As Decimal

    Public Sub New(jobTitle As String, company As String, salary As Decimal)
        _jobTitle = jobTitle
        _company = company
        _salary = salary
    End Sub

    Public Property JobTitle As String
        Get
            Return _jobTitle
        End Get
        Set(value As String)
            _jobTitle = value
        End Set
    End Property

    Public Property Company As String
        Get
            Return _company
        End Get
        Set(value As String)
            _company = value
        End Set
    End Property

    Public Property Salary As Decimal
        Get
            Return _salary
        End Get
        Set(value As Decimal)
            _salary = value
        End Set
    End Property
End Class
