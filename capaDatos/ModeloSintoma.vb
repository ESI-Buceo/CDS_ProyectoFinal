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
        Comando.CommandText = "INSERT INTO sintoma (id,nombre, activo) VALUES ( " & Me.ID & " ,'" & Me.Nombre & "', " & Me.Estado & " ) ON DUPLICATE KEY UPDATE nombre ='" & Me.Nombre & "', activo= " & Me.Estado
        Comando.ExecuteNonQuery()
    End Sub

    Public Sub BorrarSintoma()
        ' eliminiacion logica de sintoma
        Comando.CommandText = "UPDATE sintoma  SET  activo = 0 WHERE Id = " & Me.ID & " "
        Comando.ExecuteNonQuery()
    End Sub

    Public Function TraeDatosSintomasDeBD() As DataTable
        Dim tabla As New DataTable
        Comando.CommandText = "Select * FROM sintoma WHERE activo = 1 "
        Reader = Comando.ExecuteReader()
        tabla.Load(Reader)
        CerrarConexion()
        Return tabla
    End Function

    Public Function TraeDatosSintomasDeBD(sintoma As String) As DataTable
        Dim tabla As New DataTable
        Comando.CommandText = "Select * FROM sintoma WHERE activo = 1 And nombre Like '%" + sintoma + "%'"
        Reader = Comando.ExecuteReader()
        tabla.Load(Reader)
        CerrarConexion()
        Return tabla
    End Function

    Public Function ListarSintomasXPatologia(ByVal idPatologia As String) As DataTable
        ' lista los sintomas vinculados a una patologia
        Dim tabla As New DataTable
        Comando.CommandText = "SELECT a.idSintoma, s.nombre Nombre FROM asociados a JOIN sintoma s ON s.id = a.idSintoma WHERE a.idPatologia=" & idPatologia
        Reader = Comando.ExecuteReader()
        tabla.Load(Reader)
        CerrarConexion()
        Return tabla
    End Function

    Public Function SintomasIngresadosPorPaciente(ByVal idSesion As String)
        Dim tablaSintomas As New DataTable
        Comando.CommandText = "SELECT DISTINCT(s.nombre) NOMBRE FROM tiene t JOIN sintoma s ON s.id = t.idSintoma WHERE t.idDiagnostico = " & idSesion
        Reader = Comando.ExecuteReader
        tablaSintomas.Load(Reader)
        CerrarConexion()
        Return tablaSintomas
    End Function

    Public Function ListarSintomas(ByVal estado As String)
        Comando.CommandText = "SELECT id, nombre, activo FROM sintoma WHERE activo =" & estado
        Reader = Comando.ExecuteReader
        tablaSintomas.Load(Reader)
        conexion.Close()
        Return tablaSintomas
    End Function

    Public Function ListarTodosLosSintomas()
        Comando.CommandText = "SELECT id, nombre, activo FROM sintoma"
        Reader = Comando.ExecuteReader
        TablaSintomas.Load(Reader)
        Return TablaSintomas
    End Function
End Class
