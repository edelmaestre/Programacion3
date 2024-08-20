Public Class BarriosClass
    Private cod As String
    Public Property Codigo_Barrio As String
        Get
            Return cod
        End Get
        Set(value As String)
            cod = value
        End Set
    End Property

    Private nom As String
    Public Property Nombre As String
        Get
            Return nom
        End Get
        Set(value As String)
            If value Is Nothing Or value.Length = 0 Then
                Throw New NullReferenceException("la cagaste...")
                Exit Property
            End If
            nom = value
        End Set
    End Property
    
    Public Function datos() As String()
        Dim s(1) As String
        s(0) = Codigo_Barrio
        s(1) = Nombre
        
        Return s
    End Function
    Sub New()
        MyBase.New()
    End Sub

    Sub New(s As String)
        Codigo_Barrio = s.Split(";")(0)
        Nombre = s.Split(";")(1)
    End Sub

End Class
