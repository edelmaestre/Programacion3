Public Class Alquiler_Class

    Private PersonasA As ListaPersonaClass
    Private MotosA As ListaMotosClass
    Private fec As Date

    Public Property LISTAPERSONASa() As ListaPersonaClass
        Get
            Return PersonasA
        End Get
        Set(value As ListaPersonaClass)
            PersonasA = value
        End Set
    End Property

    Public Property LISTAMOTOSSa() As ListaMotosClass
        Get
            Return MotosA
        End Get
        Set(value As ListaMotosClass)
            MotosA = value
        End Set
    End Property

    Public Property FECHA_ALQULER() As Date
        Get
            Return fec
        End Get
        Set(value As Date)
            fec = value
        End Set
    End Property

End Class
