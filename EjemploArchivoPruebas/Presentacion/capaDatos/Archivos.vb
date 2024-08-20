Imports System.IO
Public Class Archivos
    Private r As String
    Public ReadOnly Property ruta As String
        Get
            Return r
        End Get
    End Property
    Sub New(ruta As String)
        r = ruta
    End Sub
    Function guardar(datos As String) As String
        Try
            '1. abrir para escritura
            Dim sw As New StreamWriter(ruta, True)
            '2 operacion
            sw.WriteLine(datos)
            '3. cerrar el flujo - guardar en disco
            sw.Close()
            Return "se agregaron los datos satisfactoriamente ..!"
        Catch ex As Exception
            Return "error al guardar!:Fguardar" & vbCrLf & ex.Message
        End Try
    End Function


End Class
