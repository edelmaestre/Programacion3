Public Class PersonaClass
    Private ced As Long
    Public Property Cedula() As Long
        Get
            Return ced
        End Get
        Set(ByVal value As Long)
            ced = value
        End Set
    End Property
    Private nom As String
    Public Property Nombre As String
        Get
            Return nom
        End Get
        Set(value As String)
            If IsNothing(value) Then
                Throw New Exception("el nombre no puede ser nulo ...")
            End If
            nom = value
        End Set
    End Property
    Private tel As String
    Public Property Telefono() As String
        Get
            Return tel
        End Get
        Set(ByVal value As String)
            tel = value
        End Set
    End Property
    Private fecha As Date
    Public Property FechaNacimiento() As Date
        Get
            Return fecha
        End Get
        Set(ByVal value As Date)
            fecha = value
        End Set
    End Property
    Function edad()
        Return Now.Year - FechaNacimiento.Year
    End Function
End Class
