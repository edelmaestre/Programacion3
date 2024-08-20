
Module Module1

    Dim proyecto(20) As String
    Dim presupuesto(20) As Integer
    Dim interventor(20) As String
    Dim ejecucion(20) As Integer
    Dim estado(20) As String
    Dim nel As Integer = 0
    Sub Main()
        menu()
    End Sub

    Sub menu()

        Dim op As Integer
        Do
            Console.Clear()
            Console.SetCursorPosition(16, 6) : Console.Write(" M E N U   P R I N C I P A L ")
            Console.SetCursorPosition(14, 8) : Console.Write("1. LLenar proyecto v.1")
            Console.SetCursorPosition(14, 10) : Console.Write("2. Llenar proyecto v.2 ")
            Console.SetCursorPosition(14, 12) : Console.Write("3. Llenar proyecto v.3")
            Console.SetCursorPosition(14, 14) : Console.Write("4.agregar proyecto v.1")
            Console.SetCursorPosition(14, 16) : Console.Write("5. Agregar proyecto v.2")
            Console.SetCursorPosition(14, 18) : Console.Write("6. consultar proyecto v.1 ")
            Console.SetCursorPosition(14, 20) : Console.Write("7. cosultar proyecto v.2")
            Console.SetCursorPosition(14, 22) : Console.Write("8. eliminar proyecto v.1")
            Console.SetCursorPosition(44, 8) : Console.Write("9. eliminar proyecto v.1")
            Console.SetCursorPosition(44, 10) : Console.Write("10. modificar proyecto ")
            Console.SetCursorPosition(44, 12) : Console.Write("11. SALIR")
            Console.SetCursorPosition(14, 14) : Console.Write("Digite una opcion...")

            Console.SetCursorPosition(37, 27) : op = Console.ReadLine()
            Select Case op
                Case 1
                    llenar()

                Case 2
                    llenar_v02()
                Case 3
                    llenar_v03()
                Case 4
                     'agregar()
                Case 5
                    'agregar_v02()
                Case 6
                    '´consultar()
                Case 7
                    'consultar_v02()
                Case 8
                    'eliminar()
                Case 9
                    'eliminar_02()
                Case 10
                    modificar()
                Case 11
                    Console.Clear()
                    Console.SetCursorPosition(10, 25) : Console.Write("¡Gracias :)!")
                    Console.ReadKey()
                    Exit Do
            End Select

        Loop While True





    End Sub



    Sub llenar()
        Console.Clear()
        Console.Write("Cuantos proyectos desea ingresar:")
        nel = Console.ReadLine()
        If (nel < 0 Or nel > 20) Then
            Console.WriteLine("Error, verifique el numero a introducir")
        End If

        For i = 1 To nel

            Console.SetCursorPosition(16, 5) : Console.Write("****** L L E N A R  D A T O S  D E L  P R O Y E C T O ******")
            Console.SetCursorPosition(14, 8) : Console.Write("Nombre : ")
            Console.SetCursorPosition(38, 8) : Console.Write("Presupuesto: ")
            Console.SetCursorPosition(14, 10) : Console.Write("Interventor: ")
            Console.SetCursorPosition(38, 10) : Console.Write("Ejecucion: ")
            Console.SetCursorPosition(24, 8) : proyecto(i) = Console.ReadLine
            Console.SetCursorPosition(53, 8) : presupuesto(i) = Console.ReadLine
            Console.SetCursorPosition(29, 10) : interventor(i) = Console.ReadLine
            Console.SetCursorPosition(53, 10) : ejecucion(i) = Console.ReadLine
            If (presupuesto(nel) - ejecucion(nel) = 0) Then
                estado(nel) = "finalizado"
            Else
                If (presupuesto(nel) > ejecucion(nel)) Then
                    estado(nel) = "Procesando"
                Else
                    If (ejecucion(nel) = 0) Then
                        estado(nel) = "Sin Iniciar "
                    End If

                End If

            End If


        Next

        Console.ReadKey()

    End Sub

    Sub llenar_v02()

        Dim mas As Char = "s"

        While (mas = "s") And (nel < 20)
            Console.Clear()
            nel = nel + 1
            If nel > 20 Then
                Console.SetCursorPosition(14, 14) : Console.Write("Error, ya los vectores estan llenos :( ")

            End If
            Console.SetCursorPosition(16, 5) : Console.Write("****** A G R E G A R  P R O Y E C T O ******")
            Console.SetCursorPosition(14, 8) : Console.Write("Nombre : ")
            Console.SetCursorPosition(38, 8) : Console.Write("Presupuesto: ")
            Console.SetCursorPosition(14, 10) : Console.Write("Interventor: ")
            Console.SetCursorPosition(38, 10) : Console.Write("Ejecucion: ")

            Console.SetCursorPosition(24, 8) : proyecto(nel) = Console.ReadLine
            Console.SetCursorPosition(53, 8) : presupuesto(nel) = Console.ReadLine
            Console.SetCursorPosition(29, 10) : interventor(nel) = Console.ReadLine
            Console.SetCursorPosition(53, 10) : ejecucion(nel) = Console.ReadLine


            If (presupuesto(nel) - ejecucion(nel) = 0) Then
                estado(nel) = "finalizado"
            Else
                If (presupuesto(nel) > ejecucion(nel)) Then
                    estado(nel) = "Procesando"
                Else
                    If (ejecucion(nel) = 0) Then
                        estado(nel) = "Sin Iniciar "
                    End If

                End If

            End If

            Console.SetCursorPosition(14, 14) : Console.Write("¡¡ Su proyecto ha si guardado exitosamente :) !!: ")
            Console.SetCursorPosition(14, 16) : Console.Write("desea introducir otro proyecto?: ")
            Console.SetCursorPosition(14, 17) : mas = Console.ReadLine()


            ' Console.ReadKey()

        End While



    End Sub
    Sub llenar_v03()


        Dim mas As Char = "s"

        While (mas = "s" And nel <= 3)
            Console.Clear()

            If nel > 3 Then
                Console.SetCursorPosition(14, 14) : Console.Write("Error, ya los vectores estan llenos :( ")

            End If
            Console.SetCursorPosition(16, 5) : Console.Write("****** A G R E G A R  P R O Y E C T O ******")
            Console.SetCursorPosition(14, 8) : Console.Write("Nombre : ")
            Console.SetCursorPosition(38, 8) : Console.Write("Presupuesto: ")
            Console.SetCursorPosition(14, 10) : Console.Write("Interventor: ")
            Console.SetCursorPosition(38, 10) : Console.Write("Ejecucion: ")

            Console.SetCursorPosition(24, 8) : proyecto(nel) = Console.ReadLine
            Console.SetCursorPosition(53, 8) : presupuesto(nel) = Console.ReadLine
            Console.SetCursorPosition(29, 10) : interventor(nel) = Console.ReadLine
            Console.SetCursorPosition(53, 10) : ejecucion(nel) = Console.ReadLine

            nel = nel + 1
            Console.SetCursorPosition(14, 14) : Console.Write("¡¡ Su proyecto ha si guardado exitosamente :) !!: ")
            Console.SetCursorPosition(14, 16) : Console.Write("desea introducir otro proyecto?: " & mas)
            Console.ReadKey()

        End While

    End Sub

    Sub consultar()
        Dim n As String
        Dim encon As Char
        Dim mas As Char

        Do

            Console.SetCursorPosition(16, 5) : Console.Write("****** C O N S U L T A R   P R O Y E C T O  ******")
            Console.SetCursorPosition(14, 8) : Console.Write("Nombre del proyecto a consultar: ")
            Console.SetCursorPosition(34, 8) : n = Console.ReadLine()


            Console.Clear()
            For index = 1 To 10
                If n = proyecto(index) Then
                    Console.SetCursorPosition(16, 5) : Console.Write("******D A T O S  D E L  P R O Y E C T O  ******")
                    Console.SetCursorPosition(14, 8) : Console.Write("Nombre : " & proyecto(index))
                    Console.SetCursorPosition(38, 8) : Console.Write("Presupuesto: " & presupuesto(index))
                    Console.SetCursorPosition(14, 10) : Console.Write("Interventor: " & interventor(index))
                    Console.SetCursorPosition(38, 10) : Console.Write("Ejecucion: " & ejecucion(index))
                    Console.SetCursorPosition(38, 10) : Console.Write("Ejecucion: " & estado(index))
                    encon = "n"
                End If
            Next

            If encon = "N " Then
                Console.WriteLine(" NO  está matriculado ese alumno …. ")
            End If
            Console.Write(" Desea seguir Consultando  Información de  Alumnos  ? ")
            mas = Console.ReadLine()

        Loop While (mas = "n")



    End Sub

    Sub consultar_v02()
        Dim n As String
        Dim mas As Char
        Do
            Console.WriteLine(“  **** CONSULTA INFORMACION DE ESTUDIANTES  **** ”)
            Console.WriteLine(“ CODIGO A  CONSULTAR ??  ”)
            n = Console.ReadLine()
            Dim pos As Integer
            Dim Encontro As Char = "n"
            Dim i As Integer = 1
            While (i <= nel And Encontro = "n")
                If n = proyecto(i) Then
                    Console.Write("******D A T O S  D E L  P R O Y E C T O  ******")
                    Console.Write("Nombre : " & proyecto(i))
                    Console.Write("Presupuesto: " & presupuesto(i))
                    Console.Write("Interventor: " & interventor(i))
                    Console.Write("Ejecucion: " & ejecucion(i))
                    Console.Write("Ejecucion: " & estado(i))
                    pos = i
                    Encontro = " S "
                Else
                    i = i + 1
                End If
            End While

            If Encontro = " n " Then
                Console.WriteLine(“ NO  está matriculado ese alumno …. “)
            End If
            Console.WriteLine(“ Desea seguir Consultando  Información de  Alumnos  ? “)
            mas = Console.ReadLine()
        Loop While (mas = "n")
    End Sub
    Sub eliminar()
        Dim mas As Char = "s"
        Dim n As String
        Dim encontro As Char
        Dim i As Integer
        Dim pos As Integer
        Dim seguro As Char
        While mas = "s"
            Console.WriteLine(“  **** BORRAR  INFORMACION DE PROYECTOS **** ”)
            Console.WriteLine(“ CODIGO del proyecto que desea Retirar de la lista ??  ”)
            n = Console.ReadLine
            encontro = "n"
            i = 1
            While i <= nel And encontro = "n"
                If n = proyecto(i) Then
                    Console.Write("******D A T O S  D E L  P R O Y E C T O  ******")
                    Console.Write("Nombre : " & proyecto(i))
                    Console.Write("Presupuesto: " & presupuesto(i))
                    Console.Write("Interventor: " & interventor(i))
                    Console.Write("Ejecucion: " & ejecucion(i))
                    Console.Write("Ejecucion: " & estado(i))
                    pos = i
                    encontro = "s"
                    Console.WriteLine(“ Está seguro de Retirar  este  Alumno de la Clase ?? [ S/N ] ……..”)
                    seguro = Console.ReadLine()
                    If seguro = "s" Then
                        If pos = nel Then
                            nel = nel - 1
                        Else
                            For index = pos + 1 To nel
                                proyecto(i) = proyecto(i)
                                presupuesto(i - 1) = presupuesto(i)
                                interventor(i - 1) = interventor(i)
                                ejecucion(i - 1) = ejecucion(i)
                                estado(i - 1) = estado(i)
                            Next
                        End If
                    End If
                Else
                    i = i + 1
                End If
            End While
        End While
        If encontro = "n" Then
            Console.WriteLine("el proyecto no existe ")
        End If
        Console.WriteLine("deseas seguir eliminando proyectos : [s/n] ")
        mas = Console.ReadLine()

    End Sub
    Sub eliminar_v02()
        Dim mas As Char = "s"
        Dim n As String
        Dim encontro As Char
        Dim i As Integer
        Dim pos As Integer
        Dim seguro As Char
        While mas = "s"
            Console.WriteLine(“  **** BORRAR  INFORMACION DE PROYECTOS **** ”)
            Console.WriteLine(“ NOMBRE del proyecto que desea Retirar de la lista ??  ”)
            n = Console.ReadLine
            encontro = "n"
            i = 1
            While i <= nel And encontro = "n"
                If n = proyecto(i) Then
                    Console.Write("******D A T O S  D E L  P R O Y E C T O  ******")
                    Console.Write("Nombre : " & proyecto(i))
                    Console.Write("Presupuesto: " & presupuesto(i))
                    Console.Write("Interventor: " & interventor(i))
                    Console.Write("Ejecucion: " & ejecucion(i))
                    Console.Write("Ejecucion: " & estado(i))
                    pos = i
                    encontro = "s"
                Else
                    i = i + 1
                End If

                If encontro = "n" Then
                    Console.WriteLine("el proyecto no existe ")
                Else
                    Console.WriteLine("esta seguro de eliminar el proyecto ")
                    seguro = Console.ReadLine()
                    If seguro = "s" Then

                        If pos = nel Then
                            nel = nel - 1
                        Else
                            For index = pos + 1 To nel
                                proyecto(i) = proyecto(i)
                                presupuesto(i - 1) = presupuesto(i)
                                interventor(i - 1) = interventor(i)
                                ejecucion(i - 1) = ejecucion(i)
                                estado(i - 1) = estado(i)
                            Next
                        End If
                    End If
                End If
            End While
            Console.WriteLine("deseas seguir eliminando proyectos : [s/n] ")
            mas = Console.ReadLine()
        End While

    End Sub


    Sub modificar()
        



    End Sub

End Module

