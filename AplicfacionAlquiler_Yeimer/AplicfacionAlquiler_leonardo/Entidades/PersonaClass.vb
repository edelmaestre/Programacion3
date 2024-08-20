Public Class PersonaClass

    Private nom As String
    Private ced As Long
    Private sex As Char

    Public Property NOMBRE() As String
        Get
            Return nom
        End Get
        Set(value As String)
            nom = value
        End Set
    End Property

    Public Property CEDULA() As Long
        Get
            Return ced
        End Get
        Set(value As Long)
            ced = value
        End Set
    End Property

    Public Property SEXO() As Char
        Get
            Return sex
        End Get
        Set(value As Char)
            sex = value
        End Set
    End Property

End Class
