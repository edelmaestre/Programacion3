Public Class ListaPersonaClass

    Shared ListaPersonas As New ArrayList

    Public Property listaP As ArrayList
        Get
            Return ListaPersonas
        End Get
        Set(value As ArrayList)
            ListaPersonas = value
        End Set
    End Property

    Public Function Agregar(per As PersonaClass) As String

        Try
            listaP.Add(per)
            Return " SE AGREGO CORRECTAMENTE"
        Catch ex As Exception
            Return "NO SE AGREGO"
        End Try
    End Function
    Public Function buscarceduca(ced As Long) As Integer
        Try

            For h As Integer = 0 To listaP.Count - 1
                If CType(listaP.Item(h), PersonaClass).CEDULA = ced Then
                    Return h
                End If
            Next

            Return -1
        Catch ex As Exception
            Return -1
        End Try
    End Function


    Public Function elimninar(cedu As Long) As String
        Dim k As Integer

        k = buscarceduca(cedu)
        Try
            listaP.RemoveAt(k)
            Return "ESTUDIANTE ELIMINADO"
        Catch ex As Exception
            Return "ERROR AL ELIMINAR"
        End Try

    End Function


    Public Function modificar(k As Integer, per As PersonaClass) As String

        CType(listaP.Item(k), PersonaClass).CEDULA = per.CEDULA
        CType(listaP.Item(k), PersonaClass).NOMBRE = per.NOMBRE
        CType(listaP.Item(k), PersonaClass).SEXO = per.SEXO


        Return "EL ESTUDIANTE HA SIDO MODIFICADO"


    End Function


    Public Function ConsultarP() As ArrayList
        Return listaP
    End Function

End Class
