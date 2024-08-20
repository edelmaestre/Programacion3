Module Module1
    Sub main()
        Dim ruta As String = Application.StartupPath & "\prueba.txt"
        Dim c As New ContactoClass
        Dim gc As New LogicaContactosClass(ruta)
        'Dim arc As New ArchivoContactos(ruta)
        'c.Identificacion = 12345
        'c.Nombre = "Juan"
        'c.Telefono = "55555"
        'c.Sexo = "M"
        'c.FechaNacimiento = #9/9/1990#

        'Console.WriteLine(arc.guardar(Join(c.datos, ";")))
        'c.Identificacion = 8888
        'c.Nombre = "carlos"
        'c.Telefono = "578955"
        'c.Sexo = "M"
        'c.FechaNacimiento = #9/9/1998#
        'Console.WriteLine(gc.guardarDatos(c))

        'Console.WriteLine("cedula --- nombre")
        'For Each obj As ContactoClass In gc.leer
        '    Console.WriteLine(obj.Identificacion & " -- " & obj.Nombre)
        'Next
        Console.Write("cedula =")
        Dim ced As String
        ced = Console.ReadLine
        Dim i As Integer = gc.buscarContacto(ced)
        If i < 0 Then
            Console.WriteLine("no existe")
        Else
            c = gc.contacto(i)
            Console.WriteLine("cedula : " & c.Identificacion)
            Console.WriteLine("nombre : " & c.Nombre)
        End If

        Console.ReadKey()
    End Sub
End Module
