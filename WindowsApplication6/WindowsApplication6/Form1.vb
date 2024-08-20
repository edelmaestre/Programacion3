Public Class Form1
    Private cont As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button2.Text = "" Then
            Button2.Text = Button1.Text
            Button1.Text = ""
        ElseIf Button5.Text = "" Then
            Button5.Text = Button1.Text
            Button1.Text = ""
        End If
        resuelto()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button1.Text = "" Then
            Button1.Text = Button2.Text
            Button2.Text = ""
        ElseIf Button3.Text = "" Then
            Button3.Text = Button2.Text
            Button2.Text = ""
        ElseIf Button6.Text = "" Then
            Button6.Text = Button2.Text
            Button2.Text = ""
        End If
        resuelto()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button2.Text = "" Then
            Button2.Text = Button3.Text
            Button3.Text = ""
        ElseIf Button4.Text = "" Then
            Button4.Text = Button3.Text
            Button3.Text = ""
        ElseIf Button7.Text = "" Then
            Button7.Text = Button3.Text
            Button3.Text = ""
        End If
        resuelto()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button3.Text = "" Then
            Button3.Text = Button4.Text
            Button4.Text = ""
        ElseIf Button8.Text = "" Then
            Button8.Text = Button4.Text
            Button4.Text = ""
        End If
        resuelto()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Button1.Text = "" Then
            Button1.Text = Button5.Text
            Button5.Text = ""
        ElseIf Button6.Text = "" Then
            Button6.Text = Button5.Text
            Button5.Text = ""
        ElseIf Button9.Text = "" Then
            Button9.Text = Button5.Text
            Button5.Text = ""
        End If
        resuelto()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Button2.Text = "" Then
            Button2.Text = Button6.Text
            Button6.Text = ""
        ElseIf Button5.Text = "" Then
            Button5.Text = Button6.Text
            Button6.Text = ""
        ElseIf Button7.Text = "" Then
            Button7.Text = Button6.Text
            Button6.Text = ""
        ElseIf Button10.Text = "" Then
            Button10.Text = Button6.Text
            Button6.Text = ""
        End If
        resuelto()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Button3.Text = "" Then
            Button3.Text = Button7.Text
            Button7.Text = ""
        ElseIf Button6.Text = "" Then
            Button6.Text = Button7.Text
            Button7.Text = ""
        ElseIf Button8.Text = "" Then
            Button8.Text = Button7.Text
            Button7.Text = ""
        ElseIf Button11.Text = "" Then
            Button11.Text = Button7.Text
            Button7.Text = ""
        End If
        resuelto()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Button4.Text = "" Then
            Button4.Text = Button8.Text
            Button8.Text = ""
        ElseIf Button7.Text = "" Then
            Button7.Text = Button8.Text
            Button8.Text = ""
        ElseIf Button12.Text = "" Then
            Button12.Text = Button8.Text
            Button8.Text = ""

        End If
        resuelto()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Button5.Text = "" Then
            Button5.Text = Button9.Text
            Button9.Text = ""
        ElseIf Button10.Text = "" Then
            Button10.Text = Button9.Text
            Button9.Text = ""
        ElseIf Button13.Text = "" Then
            Button13.Text = Button9.Text
            Button9.Text = ""
        End If
        resuelto()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If Button6.Text = "" Then
            Button6.Text = Button10.Text
            Button10.Text = ""
        ElseIf Button9.Text = "" Then
            Button9.Text = Button10.Text
            Button10.Text = ""
        ElseIf Button11.Text = "" Then
            Button11.Text = Button10.Text
            Button10.Text = ""
        ElseIf Button14.Text = "" Then
            Button14.Text = Button10.Text
            Button10.Text = ""
        End If
        resuelto()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Button7.Text = "" Then
            Button7.Text = Button11.Text
            Button11.Text = ""
        ElseIf Button10.Text = "" Then
            Button10.Text = Button11.Text
            Button11.Text = ""
        ElseIf Button12.Text = "" Then
            Button12.Text = Button11.Text
            Button11.Text = ""
        ElseIf Button15.Text = "" Then
            Button15.Text = Button11.Text
            Button11.Text = ""
        End If
        resuelto()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If Button8.Text = "" Then
            Button8.Text = Button12.Text
            Button12.Text = ""
        ElseIf Button11.Text = "" Then
            Button11.Text = Button12.Text
            Button12.Text = ""
        ElseIf Button16.Text = "" Then
            Button16.Text = Button12.Text
            Button12.Text = ""
        End If
        resuelto()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If Button9.Text = "" Then
            Button9.Text = Button13.Text
            Button13.Text = ""
        ElseIf Button14.Text = "" Then
            Button14.Text = Button13.Text
            Button13.Text = ""
        End If
        resuelto()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If Button10.Text = "" Then
            Button10.Text = Button14.Text
            Button14.Text = ""
        ElseIf Button13.Text = "" Then
            Button13.Text = Button14.Text
            Button14.Text = ""
        ElseIf Button15.Text = "" Then
            Button15.Text = Button14.Text
            Button14.Text = ""
        End If
        resuelto()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If Button11.Text = "" Then
            Button11.Text = Button15.Text
            Button15.Text = ""
        ElseIf Button14.Text = "" Then
            Button14.Text = Button15.Text
            Button15.Text = ""
        ElseIf Button16.Text = "" Then
            Button16.Text = Button15.Text
            Button15.Text = ""
        End If
        resuelto()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If Button12.Text = "" Then
            Button12.Text = Button16.Text
            Button16.Text = ""
        ElseIf Button15.Text = "" Then
            Button15.Text = Button16.Text
            Button16.Text = ""

        End If
        resuelto()
    End Sub

    Sub resuelto()
        If Button1.Text = "1" And Button2.Text = "2" And Button3.Text = "3" And
             Button4.Text = "4" And Button5.Text = "5" And Button6.Text = "6" And
             Button7.Text = "7" And Button8.Text = "8" And Button9.Text = "9" And
             Button10.Text = "10" And Button11.Text = "11" And Button12.Text = "12" And
             Button13.Text = "13" And Button14.Text = "14" And Button15.Text = "15" Then
            MsgBox(" ¡¡FELICITACIONES!! lo has hecho en " & cont & " clicks")
        End If
        cont = cont + 1

    End Sub



    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        revolver()
    End Sub
    Sub revolver()
        Registrarse.ShowDialog()
        Dim v(15), i, j, RN As Integer
        Dim flag As Boolean

        flag = False
        i = 1
        v(j) = 1
        Do While i <= 15
            Randomize()
            RN = CInt(Int((15 * Rnd()) + 1))

            For j = 1 To i
                If (v(j) = RN) Then
                    flag = True
                    Exit For
                End If
            Next

            If flag = True Then
                flag = False
            Else
                v(i) = RN
                i = i + 1
            End If
        Loop

        Button1.Text = v(1)
        Button2.Text = v(2)
        Button3.Text = v(3)
        Button4.Text = v(4)
        Button5.Text = v(5)
        Button6.Text = v(6)
        Button7.Text = v(7)
        Button8.Text = v(8)
        Button9.Text = v(9)
        Button10.Text = v(10)
        Button11.Text = v(11)
        Button12.Text = v(12)
        Button13.Text = v(13)
        Button14.Text = v(14)
        Button15.Text = v(15)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Guardar(cont, Registrarse.txtnombre.Text)
    End Sub

    Sub Guardar(c As Integer, n As String)
        Dim lista As New ArrayList()
        Dim p As New Persona
        p.nombre = n
        p.movimientos = c
        lista.Add(p)
        MsgBox("Tu partida esta registrada..!!")
    End Sub
End Class
