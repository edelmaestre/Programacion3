Public Class fromPersonas
    Dim k As Integer
    Dim j As Integer

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtCedula.Clear()
        txtNombre.Clear()
        cboSexo.ResetText()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        guardar()
    End Sub


    Sub guardar()

        Dim per As New PersonaClass

        per.CEDULA = txtCedula.Text
        per.NOMBRE = txtNombre.Text
        per.SEXO = cboSexo.SelectedItem

        MsgBox(LISTASPERSONAS.Agregar(per), MsgBoxStyle.Information, AcceptButton)

    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Buscar()
    End Sub
    Sub Buscar()

        Dim per As New PersonaClass
        Dim ced As Long
        ced = InputBox("DIGITE LA CEDULA")
        k = LISTASPERSONAS.buscarceduca(Long.Parse(ced))
        If (k = -1) Then
            MsgBox("CEDULA NO REGISTRADA", MsgBoxStyle.Information, AcceptButton)
        Else


            txtCedula.Text = CType(LISTASPERSONAS.listaP.Item(k), PersonaClass).CEDULA.ToString
            txtNombre.Text = CType(LISTASPERSONAS.listaP.Item(k), PersonaClass).NOMBRE.ToString
            'cboSexo.Text(CType((Form1.LISTASPERSONAS.listaP.Item(k), PersonaClass).SEXO.ToString)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminar()
    End Sub

    Sub eliminar()
        Dim ced As Long
        ced = InputBox("DIGITE LA CEDUAL : ")

        MsgBox(LISTASPERSONAS.elimninar(ced), MsgBoxStyle.Information, AcceptButton)


    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        modificar()
    End Sub


    Sub modificar()

        Dim per As New PersonaClass

        If (j = -1) Then
            MsgBox("DEBE REALIZAR UNA BUSUQEDA", MsgBoxStyle.Information, AcceptButton)
        Else
            per.CEDULA = txtCedula.Text
            per.NOMBRE = txtNombre.Text
            per.SEXO = cboSexo.SelectedItem
            MsgBox(LISTASPERSONAS.modificar(j, per))
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

   
    Private Sub txtCedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCedula.KeyPress
        Solonuemros(e)
    End Sub


    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        SoloCaracter(e)
    End Sub
End Class