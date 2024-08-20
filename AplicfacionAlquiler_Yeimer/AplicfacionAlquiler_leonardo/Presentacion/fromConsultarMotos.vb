Public Class fromConsultarMotos

    Private Sub fromConsultarMotos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrillaPersona()
    End Sub

    Public Sub cargarGrillaPersona()

        grillaMotos.Rows.Clear()
        For Each Obj As Object In LISTASMOTOS.ConsultarM
            Dim mot As New MotosClass
            mot = CType(Obj, MotosClass)
            grillaMotos.Rows.Add(mot.PLACA, mot.MODELO, mot.KILOMETRAJE, mot.DESCIPCION)
        Next


    End Sub

End Class