Public Class ListaAlquilerClass

    Shared ListaALquiler As ArrayList


    Public Property listaA() As ArrayList
        Get
            Return ListaALquiler
        End Get
        Set(value As ArrayList)
            ListaALquiler = value
        End Set
    End Property

    Public Function Agregar(alq As Alquiler_Class) As String

        Try
            listaA.Add(alq)
            Return " SE AGREGO CORRECTAMENTE"
        Catch ex As Exception
            Return "NO SE AGREGO"
        End Try
    End Function

    Public Function ConsultarA() As ArrayList
        Return listaA
    End Function

    Public Function BUSCARPORDIAS(dia As Date) As String
        Try
            For j = 0 To listaA.Count - 1
                If (CType(listaA.Item(j), Alquiler_Class).FECHA_ALQULER = dia) Then
                    Return j
                End If
            Next
        Catch ex As Exception
            Return -1
        End Try
        Return -1
    End Function

    Public Function BUSCARPORMES(mes As Date) As String
        Try
            For j = 0 To listaA.Count - 1
                If (CType(listaA.Item(j), Alquiler_Class).FECHA_ALQULER = mes) Then
                    Return j
                End If
            Next
        Catch ex As Exception
            Return -1
        End Try
        Return -1
    End Function


End Class
