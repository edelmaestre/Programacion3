Public Class fromMotos
    Dim k As Integer
    Dim j As Integer
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        guardar()
    End Sub

    Sub guardar()

        Dim mot As New MotosClass

        mot.PLACA = txtPlaca.Text
        mot.MODELO = txtModelo.Text
        mot.KILOMETRAJE = txtKilometraje.Text
        mot.DESCIPCION = txtDescripcion.Text

        MsgBox(LISTASMOTOS.Agregar(mot), MsgBoxStyle.Information, AcceptButton)

    End Sub




    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtDescripcion.Clear()
        txtKilometraje.Clear()
        txtModelo.Clear()
        txtPlaca.Clear()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscar()
    End Sub

    Sub buscar()


        Dim cod As Long
        Dim K As Integer


        cod = InputBox("DIGITE LA PLACA : ")
        K = LISTASMOTOS.buscarplaca(Long.Parse(cod))
        If (K = -1) Then
            MsgBox("EL ESTUDIANTE NO HA SIDO REGISTRADO", MsgBoxStyle.Information, AcceptButton)
        Else
            txtPlaca.Text = CType(LISTASMOTOS.listaM.Item(K), MotosClass).PLACA.ToString
            txtKilometraje.Text = CType(LISTASMOTOS.listaM.Item(K), MotosClass).MODELO.ToString
            txtModelo.Text = CType(LISTASMOTOS.listaM.Item(K), MotosClass).KILOMETRAJE.ToString
            txtDescripcion.Text = CType(LISTASMOTOS.listaM.Item(K), MotosClass).DESCIPCION.ToString
        End If
        j = K
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminar()
    End Sub

    Sub eliminar()
        Dim placa As Long
        placa = InputBox("DIGITE LA PLACA : ")
        MsgBox(LISTASMOTOS.elimninar(placa), MsgBoxStyle.Information, AcceptButton)
    End Sub



    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        modificar()
    End Sub


    Sub modificar()
        Dim mot As New MotosClass
        If (j = -1) Then
            MessageBox.Show("DEBE REALIZAR UNA BUSUQEDA ")
        Else
            mot.PLACA = txtPlaca.Text
            mot.MODELO = txtModelo.Text
            mot.KILOMETRAJE = txtKilometraje.Text
            mot.DESCIPCION = txtDescripcion.Text
            MsgBox(LISTASMOTOS.modificar(j, mot), MsgBoxStyle.Information, AcceptButton)
        End If


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    
    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        SoloCaracter(e)
    End Sub

    Private Sub txtKilometraje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKilometraje.KeyPress
        Solonuemros(e)
    End Sub
End Class