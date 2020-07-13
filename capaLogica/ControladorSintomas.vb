Imports System.Data
Imports capaDatos
Public Module ControladorSintomas

    Public Function ListarSintomas() As DataTable
        ' Lista los sintomas que estan en la base de datos
        Dim s As New ModeloSintoma
        Return s.TraeDatosSintomasDeBD()
    End Function

    Public Function ListarSintomas(nombre As String) As DataTable
        'Busca los sintomas por nombre
        Dim s As New ModeloSintoma
        Return s.TraeDatosSintomasDeBD(nombre)
    End Function

    Public Sub GuardarSintomas(ID As String, Nombre As String, Estado As Boolean)
        'Guarda los datos de un sintoma
        Dim s As New ModeloSintoma
        s.ID = ID
        s.Nombre = Nombre
        s.Estado = Estado
        s.GuardarSintoma()
    End Sub

    Public Sub BorrarSintomas(Id As String)
        'Eliminacion logica de un sintoma
        Dim s As New ModeloSintoma
        s.ID = Id
        s.BorrarSintoma()
    End Sub

End Module
