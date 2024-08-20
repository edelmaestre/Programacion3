
Imports System.IO
Public Class Form1


    Private ruta As String = Application.StartupPath & "\miarchivo.txt"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        gurdar(txtdatos.Text)
    End Sub

    Private Sub gurdar(datos As String)
        Dim sw As New StreamWriter(ruta, True)
        sw.WriteLine(datos)

        sw.Close()
    End Sub

   
    Private Sub txtdatos_TextChanged(sender As Object, e As EventArgs) Handles txtdatos.TextChanged

    End Sub
End Class
