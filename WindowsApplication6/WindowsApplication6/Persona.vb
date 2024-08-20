Public Class Persona
    Private nom As String
    Private movi As Integer
    Public Property nombre() As String
        Get
            Return nom
        End Get
        Set(ByVal value As String)
            nom = value
        End Set
    End Property
    Public Property movimientos() As Integer
        Get
            Return movi
        End Get
        Set(ByVal value As Integer)
            movi = value
        End Set
    End Property

End Class
