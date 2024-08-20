Public Class fromAlquiler
    Dim k As Integer
    Dim j As Integer

    Private Sub fromAlquiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub cargarGrillaPersona()

        grillaAlquiler.Rows.Clear()
        For Each Obj As Object In LISTASPERSONAS.ConsultarP
            Dim per As New PersonaClass
            per = CType(Obj, PersonaClass)

            grillaAlquiler.Rows.Add(per.CEDULA, per.NOMBRE, per.SEXO)

        Next


    End Sub

    Sub buscar()


        Dim cod As Long
        Dim K As Integer


        cod = InputBox("DIGITE LA PLACA : ")
        K = LISTASMOTOS.buscarplaca(Long.Parse(cod))
        If (K = -1) Then
            MsgBox("EL ESTUDIANTE NO HA SIDO REGISTRADO", MsgBoxStyle.Information, AcceptButton)
        Else
            cargarGrillaPersona()
        End If
        j = K
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscar()
    End Sub
End Class