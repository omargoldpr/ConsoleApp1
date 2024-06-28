Imports System.Net
Imports Microsoft.VisualBasic

Public Class Address
    Private _street As String
    Private _city As String
    Private _zipCode As String

    Public Sub New(street As String, city As String, zipCode As String)
        _street = street
        _city = city
        _zipCode = zipCode
    End Sub

    Public Property Street As String
        Get
            Return _street
        End Get
        Set(value As String)
            _street = value
        End Set
    End Property

    Public Property City As String
        Get
            Return _city
        End Get
        Set(value As String)
            _city = value
        End Set
    End Property

    Public Property ZipCode As String
        Get
            Logger.LogMethodCall(Me.GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, $"_zipCode={_zipCode},", _zipCode)
            Return _zipCode
        End Get
        Set(value As String)
            Logger.LogMethodCall(Me.GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, $"_zipCode={_zipCode}")
            _zipCode = value
        End Set
    End Property

    Public ReadOnly Property FullAddress As String
        Get
            Dim result As String = _street & ", " & _city & " " & _zipCode
            Logger.LogMethodCall(Me.GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, $"_street={_street}, _city={_city}, _zipCode={_zipCode}", result)
            Return result
        End Get
    End Property
End Class
