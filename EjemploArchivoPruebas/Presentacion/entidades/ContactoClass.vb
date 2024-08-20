Public Class ContactoClass
    Private cod As String
    Public Property Identificacion As String
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
    Private tel As String
    Public Property Telefono As String
        Get
            Return tel
        End Get
        Set(value As String)
            tel = value
        End Set
    End Property
    Private sex As Char
    Public Property Sexo As Char
        Get
            Return sex
        End Get
        Set(value As Char)
            sex = value
        End Set
    End Property
    Private fecha As Date
    Public Property FechaNacimiento As Date
        Get
            Return fecha
        End Get
        Set(value As Date)
            fecha = value
        End Set
    End Property
    'Private cod_bar As Integer
    'Public Property Codigo_Barrio As Integer
    '    Get
    '        Return cod_bar
    '    End Get
    '    Set(value As Integer)
    '        cod_bar = value
    '    End Set
    'End Property

    ''' <summary>
    ''' Devuelve la edad del contacto
    ''' </summary>
    Public Function edad() As Byte
        Dim ed As Byte
        If Now.Month = fecha.Month And Now.Day < fecha.Day Then
            ed = (DateDiff("m", fecha, Now) / 12)
            ed = ed - 1
        Else
            ed = (DateDiff("m", fecha, Now) / 12)
        End If
        Return ed
    End Function
    Public Function datos() As String()
        Dim s(5) As String
        s(0) = Identificacion
        s(1) = Nombre
        s(2) = Telefono
        s(3) = Sexo
        s(4) = FechaNacimiento.ToShortDateString
        ' s(5) = Codigo_Barrio
        Return s
    End Function
    Sub New()
        MyBase.New()
    End Sub

    Sub New(linea As String)
        Identificacion = linea.Split(";")(0)
        Nombre = linea.Split(";")(1)
        Telefono = linea.Split(";")(2)
        Sexo = linea.Split(";")(3)
        FechaNacimiento = CDate(linea.Split(";")(4))
        'cod_bar = linea.Split(";")(5)
    End Sub

End Class
