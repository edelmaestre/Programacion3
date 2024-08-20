Public Class MotosClass
    Private plac As String
    Private mode As String
    Private des As String
    Private kilo As Integer

    Public Property PLACA() As String
        Get
            Return plac
        End Get
        Set(value As String)
            plac = value
        End Set
    End Property

    Public Property MODELO() As String
        Get
            Return mode
        End Get
        Set(value As String)
            mode = value
        End Set
    End Property

    Public Property DESCIPCION() As String
        Get
            Return des
        End Get
        Set(value As String)
            des = value
        End Set
    End Property

    Public Property KILOMETRAJE() As String
        Get
            Return kilo
        End Get
        Set(value As String)
            kilo = value
        End Set
    End Property
End Class
