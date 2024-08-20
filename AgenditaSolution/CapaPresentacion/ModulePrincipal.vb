Imports System.Console
Module ModulePrincipal
    Private listado As New CapaLogica.ListadoPersonasClass
    Sub Main()

        menu()
    End Sub

    Sub menu()
        Dim op As String
        Do
            Clear()
            SetCursorPosition(16, 5) : Write("M E N U   P R I N C I P A L ")
            SetCursorPosition(14, 8) : Write("1. Agregar")
            SetCursorPosition(14, 10) : Write("2. Listado General")
            SetCursorPosition(14, 12) : Write("3. buscar")
            SetCursorPosition(14, 14) : Write("4. salir")
            SetCursorPosition(14, 16) : Write("Digite opcion ( )")
            SetCursorPosition(29, 16) : op = ReadLine()
            Select Case op
                Case 1
                    agregar()
                Case 2
                    consultar()
                Case 3
                Case 4
                    Clear()
                    SetCursorPosition(14, 20) : Write("gracias por usar productos johnp ...")
                    ReadKey()
                    Exit Do
            End Select
        Loop While True
    End Sub

    Sub agregar()
        Dim p As New Entidades.PersonaClass
        Clear()
        SetCursorPosition(16, 5) : Write("CAPTURA DE DATOS")
        SetCursorPosition(14, 8) : Write("Cedula  :")
        SetCursorPosition(38, 8) : Write("Nombre  :")
        SetCursorPosition(14, 10) : Write("Telefono  :")
        SetCursorPosition(38, 10) : Write("Fecha  :")

        SetCursorPosition(25, 8) : p.Cedula = ReadLine()
        SetCursorPosition(48, 8) : p.Nombre = ReadLine()
        SetCursorPosition(25, 10) : p.Telefono = ReadLine()
        SetCursorPosition(48, 10) : p.FechaNacimiento = ReadLine()
        'Clear()
        SetCursorPosition(14, 14) : Write(listado.agregar(p))
        ReadKey()
    End Sub
    Sub consultar()
        Clear()

        SetCursorPosition(16, 5) : Write("LISTADO DE GENERAL ")
        SetCursorPosition(8, 7) : Write("-----------------------------------------")
        SetCursorPosition(10, 8) : Write("Cedula")
        SetCursorPosition(20, 8) : Write("Nombre")
        SetCursorPosition(30, 8) : Write("Telefono")
        SetCursorPosition(40, 8) : Write("Fecha")
        SetCursorPosition(8, 9) : Write("-----------------------------------------")

        For i As Integer = 0 To listado.totalContactos - 1
            SetCursorPosition(10, 10 + i) : Write(listado.buscar(i).Cedula)
            SetCursorPosition(20, 10 + i) : Write(listado.buscar(i).Nombre)
            SetCursorPosition(30, 10 + i) : Write(listado.buscar(i).Telefono)
            SetCursorPosition(40, 10 + i) : Write(listado.buscar(i).FechaNacimiento.ToShortDateString)
        Next
        ReadKey()
    End Sub
End Module
