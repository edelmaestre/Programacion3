
Imports System.IO

Public Class ArchivoContactos
    Inherits Archivos
    Sub New(ruta As String)
        MyBase.New(ruta)
    End Sub
    Function leer() As List(Of ContactoClass)
        Dim lista As New List(Of ContactoClass)
        Dim sr As New StreamReader(ruta)
        Try

            Dim linea As String
            Do While Not sr.EndOfStream
                Dim c As New ContactoClass
                linea = sr.ReadLine
                c.Identificacion = linea.Split(";")(0)
                c.Nombre = linea.Split(";")(1)
                c.Telefono = linea.Split(";")(2)
                c.Sexo = linea.Split(";")(3)
                c.FechaNacimiento = linea.Split(";")(4)

                lista.Add(c)
            Loop
            sr.Close()
            Return lista
        Catch ex As Exception
            sr.close()
            Return Nothing
        End Try

    End Function
End Class
