
Imports System.IO



Public Class Form1
    Private ruta As String = Application.StartupPath & "\myArchivo.txt"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BottGuardar.Click


        guardar(TextDatos.Text)

    End Sub

    Sub guardar(datos As String)
        Dim sw As New StreamWriter(ruta, True)
        sw.WriteLine(datos)
        sw.Close()

    End Sub

    Sub Leer()
        Dim linea As String
        Dim sr As New StreamReader(ruta)
        Listado.Items.Clear()

        Do While Not sr.EndOfStream
            linea = sr.ReadLine
            Listado.Items.Add(linea)

        Loop
        sr.Close()

    End Sub


    Private Sub TextDatos_TextChanged(sender As Object, e As EventArgs) Handles TextDatos.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtLeer_Click(sender As Object, e As EventArgs) Handles ButtLeer.Click
        Leer()

    End Sub



    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Listado.SelectedIndexChanged

    End Sub
End Class
