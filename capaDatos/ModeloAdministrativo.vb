Imports capaDatos
Public Class ModeloAdministrativo
    Inherits ModeloPersona

    Public NumeroEmpleado As Integer
    Public listaDeEmpleados As New List(Of ModeloAdministrativo)

    Public Function GuardarAdministrativo()
        'guarda los datos de un empleado
        Return True
    End Function

    Public Function eliminarAdministrativo(ByVal numeroEmpleado As Integer)
        'modifica el estado de un empleado
        Return True
    End Function


    Private Function validarNumeroAdministrativo()
        'valida que el numero de empleado no contenga caracteres raros y sea un numero
        Return True
    End Function

    Public Function listarEmpleados()
        'lista todos los empleados
        Return listaDeEmpleados
    End Function


End Class
