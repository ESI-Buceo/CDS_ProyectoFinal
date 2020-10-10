Imports System.Data.Odbc
Public Class ModeloSintoma
    Inherits ModeloConexion

    Public ID As Integer
    Public Nombre As String
    Public Estado As Boolean
    Public TablaSintomas As New DataTable

    Public Sub New(ByVal uid As String, pwd As String)
        MyBase.New(uid, pwd)
    End Sub

    Public Sub GuardarSintoma()
        'Guarda los datos del sintoma
        Comando.CommandText = "INSERT INTO sintoma (id,nombre, activo) VALUES ( " & Me.ID & " ,'" & Me.Nombre & "', " & Me.Estado & " ) ON DUPLICATE KEY UPDATE nombre ='" & Me.Nombre & "', activo= " & Me.Estado
        Comando.ExecuteNonQuery()
    End Sub

    Public Sub BorrarSintoma()
        ' eliminiacion logica de sintoma
        Comando.CommandText = "UPDATE sintoma  SET  activo = 0 WHERE Id = " & Me.ID & " "
        Comando.ExecuteNonQuery()
    End Sub

    Public Function TraeDatosSintomasDeBD()
        'Lista todos los sintomas activos
        Comando.CommandText = "Select id, nombre FROM sintoma WHERE activo = 1 "
        Reader = Comando.ExecuteReader()
        TablaSintomas.Load(Reader)
        CerrarConexion()
        Return TablaSintomas
    End Function

    Public Function TraeDatosSintomasDeBD(sintoma As String)
        'Busca sintomas por el nombre
        Comando.CommandText = "Select * FROM sintoma WHERE activo = 1 And nombre Like '%" + sintoma + "%'"
        Reader = Comando.ExecuteReader()
        TablaSintomas.Load(Reader)
        CerrarConexion()
        Return TablaSintomas
    End Function

    Public Function ListarSintomasXPatologia(ByVal idPatologia As String) As DataTable
        ' lista los sintomas vinculados a una patologia
        Comando.CommandText = "SELECT a.idSintoma, s.nombre Nombre FROM asociados a 
                                JOIN sintoma s ON s.id = a.idSintoma 
                                WHERE a.idPatologia=" & idPatologia
        Reader = Comando.ExecuteReader()
        TablaSintomas.Load(Reader)
        CerrarConexion()
        Return TablaSintomas
    End Function

    Public Function SintomasIngresadosPorPaciente(ByVal idSesion As String)
        'Muestra los sintomas que ingreso el paciente
        Comando.CommandText = "SELECT DISTINCT(s.nombre) NOMBRE 
                                FROM tiene t 
                                JOIN sintoma s ON s.id = t.idSintoma 
                                WHERE t.idDiagnostico = " & idSesion
        Reader = Comando.ExecuteReader
        TablaSintomas.Load(Reader)
        CerrarConexion()
        Return TablaSintomas
    End Function

    Public Function ListarSintomas(ByVal estado As String)
        'Lista los sintomas por estado
        Comando.CommandText = "SELECT id, nombre, activo FROM sintoma WHERE activo =" & estado
        Reader = Comando.ExecuteReader
        TablaSintomas.Load(Reader)
        conexion.Close()
        Return TablaSintomas
    End Function

    Public Function ListarTodosLosSintomas()
        'Lista todos los sintomas ingresados
        Comando.CommandText = "SELECT id, nombre, activo FROM sintoma"
        Reader = Comando.ExecuteReader
        TablaSintomas.Load(Reader)
        Return TablaSintomas
    End Function

End Class

