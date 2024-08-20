
Public Class LogicaContactosClass
    Private l As List(Of ContactoClass)
    Private ruta As String
    Sub New(_ruta As String)
        ruta = _ruta
        actualizar()
    End Sub
    Public Function guardarDatos(c As ContactoClass) As String
        Dim arc As New ArchivoContactos(ruta)
        Return arc.guardar(Join(c.datos, ";"))
    End Function

    Public Function leer() As List(Of ContactoClass)
        'Dim lst As New List(Of ContactoClass)

        Dim arc As New ArchivoContactos(ruta)
        'For Each obj As ContactoClass In arc.leer
        'lst.Add(New ContactoClass(Type(obj, String)))
        'Next

        Return arc.leer
    End Function
    'Public Function adicionar(c As ContactoClass) As Boolean
    '    ' validacion
    '    Try
    '        l.Add(c)
    '        Return True
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function
    Sub actualizar()
        l = New ArchivoContactos(ruta).leer
    End Sub
    Public Function contacto(i As Integer) As ContactoClass
        actualizar()
        Return (l(i))
    End Function
    Public Function cuantos() As Integer
        actualizar()
        Return l.Count
    End Function

    Public Function eliminar(i As Integer) As Boolean
        Try
            actualizar()
            l.RemoveAt(i)
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Function buscarContacto(buscado As String) As Integer
        Dim i As Integer
        Try
            actualizar()
            For i = 0 To l.Count - 1
                If l(i).Identificacion = buscado Then
                    Return i
                End If
            Next
            Return -1
        Catch ex As Exception
            Return -1
        End Try

    End Function

End Class
