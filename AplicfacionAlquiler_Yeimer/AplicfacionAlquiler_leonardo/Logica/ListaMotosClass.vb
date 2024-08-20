Public Class ListaMotosClass
    Shared ListaMotos As New ArrayList

    Public Property listaM As ArrayList
        Get
            Return ListaMotos
        End Get
        Set(value As ArrayList)
            ListaMotos = value
        End Set
    End Property

    Public Function Agregar(mot As MotosClass) As String

        Try
            listaM.Add(mot)
            Return " SE AGREGO CORRECTAMENTE"
        Catch ex As Exception
            Return "NO SE AGREGO"
        End Try
    End Function
    Public Function buscarplaca(cod As Long) As Integer
        Try

            For h As Integer = 0 To listaM.Count - 1
                If CType(listaM.Item(h), MotosClass).PLACA = cod Then
                    Return h
                End If
            Next

            Return -1
        Catch ex As Exception
            Return -1
        End Try
    End Function


    Public Function elimninar(pla As Long) As String
        Dim k As Integer

        k = buscarplaca(pla)
        Try
            listaM.RemoveAt(k)
            Return "ESTUDIANTE ELIMINADO"
        Catch ex As Exception
            Return "ERROR AL ELIMINAR"
        End Try

    End Function


    Public Function modificar(k As Integer, mot As MotosClass) As String

        CType(listaM.Item(k), MotosClass).PLACA = mot.PLACA
        CType(listaM.Item(k), MotosClass).MODELO = mot.MODELO
        CType(listaM.Item(k), MotosClass).DESCIPCION = mot.DESCIPCION
        CType(listaM.Item(k), MotosClass).KILOMETRAJE = mot.KILOMETRAJE

        Return "LA MOTO HA SIDO MODIFICADA"


    End Function


    Public Function ConsultarM() As ArrayList
        Return listaM
    End Function
End Class
