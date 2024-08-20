Public Class ListadoPersonasClass
    Private lista As New ArrayList
    Function agregar(p As Entidades.PersonaClass) As String
        Try
            lista.Add(p)
            Return "Se ha agregado bien " & p.Nombre
        Catch ex As Exception
            Return "NO Se ha agregado bien " & p.Nombre
        End Try
    End Function
    Function buscar(ced As Long) As Entidades.PersonaClass
        For Each obj As Object In lista
            If CType(obj, Entidades.PersonaClass).Cedula = ced Then
                Return CType(obj, Entidades.PersonaClass)
            End If
        Next
        Return Nothing
    End Function
    Function buscarPosicion(ced As Long) As Integer
        Dim i As Integer = -1
        For Each obj As Object In lista
            i += 1
            If CType(obj, Entidades.PersonaClass).Cedula = ced Then
                Return i
            End If
        Next
        Return i
    End Function
    Function eliminar(p As Entidades.PersonaClass) As String
        Try
            lista.RemoveAt(buscarPosicion(p.Cedula))
            Return "Se elimino la persona " & p.Nombre
        Catch ex As Exception
            Return "NO Se elimino la Cedula " & p.Cedula
        End Try
    End Function
    Function buscar(index As Integer) As Entidades.PersonaClass
        Try
            Return CType(lista.Item(index), Entidades.PersonaClass)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Function actualizar(ced As Long, p As Entidades.PersonaClass) As String
        Try
            Dim i As Integer = buscarPosicion(ced)
            lista.RemoveAt(i)
            lista.Insert(i, p)
            Return "se actualizo la persona " & p.Nombre
        Catch ex As Exception
            Return "NO se actualizo la persona con cedula " & p.Cedula
        End Try

    End Function
    Function totalContactos() As Integer
        Return lista.Count
    End Function
End Class
