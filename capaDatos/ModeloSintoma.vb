Imports System.Data.Odbc
Public Class ModeloSintoma

    Public ID As Integer
    Public Nombre As String
    Public Estado As Boolean


    Public Sub GuardarSintoma()
        Dim c As New ModeloConexion
        c.conectar()
        c.Comando.CommandText = "INSERT INTO sintoma (id,nombre, activo) VALUES ( " & Me.ID & " ,'" & Me.Nombre & "', " & Me.Estado & " ) ON DUPLICATE KEY UPDATE nombre ='" & Me.Nombre & "', activo= " & Me.Estado
        c.Comando.ExecuteNonQuery()
    End Sub

    Public Sub BorrarSintoma()
        ' eliminiacion logica de sintoma
        Dim c As New ModeloConexion
        c.conectar()
        c.Comando.CommandText = "DELETE FROM sintoma  WHERE Id = " & Me.ID & " "
        c.Comando.ExecuteNonQuery()
    End Sub

    Public Function TraeDatosSintomasDeBD() As DataTable
        Dim c As New ModeloConexion
        Dim tabla As New DataTable
        c.conectar()
        c.Comando.CommandText = "Select * FROM sintoma WHERE activo = 1 "
        c.Reader = c.Comando.ExecuteReader()
        tabla.Load(c.Reader)
        c.CerrarConexion()
        Return tabla
    End Function

    Public Function TraeDatosSintomasDeBD(sintoma As String) As DataTable
        Dim c As New ModeloConexion
        Dim tabla As New DataTable
        c.conectar()
        c.Comando.CommandText = "Select * FROM sintoma WHERE activo = 1 And nombre Like '%" + sintoma + "%'"
        c.Reader = c.Comando.ExecuteReader()
        tabla.Load(c.Reader)
        c.CerrarConexion()
        Return tabla
    End Function

    Public Function ListarSintomasXPatologia(ByVal idPatologia As String) As DataTable
        ' lista los sintomas vinculados a una patologia
        Dim c As New ModeloConexion
        Dim tabla As New DataTable
        c.conectar()
        c.Comando.CommandText = "SELECT a.idSintoma, s.nombre FROM asociados a JOIN sintoma s ON s.id = a.idSintoma WHERE a.idPatologia=" & idPatologia
        c.Reader = c.Comando.ExecuteReader()
        tabla.Load(c.Reader)
        c.CerrarConexion()
        Return tabla
    End Function

End Class
