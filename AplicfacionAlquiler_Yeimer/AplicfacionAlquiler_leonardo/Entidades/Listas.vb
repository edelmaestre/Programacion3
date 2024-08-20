Module Listas

    Public LISTASPERSONAS As New ListaPersonaClass
    Public LISTASMOTOS As New ListaMotosClass
    Public LISTASALQUILER As New ListaAlquilerClass

    Public Sub Solonuemros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Public Sub SoloCaracter(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub



End Module
