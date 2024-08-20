Public Class fromConsultarPersonas

    Public Sub cargarGrillaPersona()

        grillaConsultarPersonas.Rows.Clear()
        For Each Obj As Object In LISTASPERSONAS.ConsultarP
            Dim per As New PersonaClass
            per = CType(Obj, PersonaClass)

            grillaConsultarPersonas.Rows.Add(per.CEDULA, per.NOMBRE, per.SEXO)

        Next


    End Sub


    Private Sub fromConsultarPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrillaPersona()
    End Sub
End Class