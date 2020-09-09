Imports System.Data.Odbc

Public Class ModeloPatologia
    Inherits ModeloConexion

    Public Id As Integer
    Public Nombre As String
    Public Ponderacion As Integer
    Public Descripcion As String
    Public Activo As Integer
    Public ListaDeSintomasAsociados As List(Of Integer)
    Public tablaPatologiasParaDiagnostico As New DataTable
    Public TablaPatologia As New DataTable

    Public Sub New(ByVal uid As String, pwd As String)
        MyBase.New(uid, pwd)
    End Sub

    Public Sub GuaradrPatologia()
        ' guarda nueva patologia
        Dim sqlTexto As String

        If Me.Id = 0 Then sqlTexto = "last_insert_id()" Else sqlTexto = Me.Id
        Try
            Comando.CommandText = "SET AUTOCOMMIT = OFF;"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "START TRANSACTION;"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "LOCK TABLE patologia WRITE, asociados WRITE"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "INSERT INTO patologia (id, nombre, ponderacion, descripcion) VALUES (" & Me.Id & ", '" & Me.Nombre & "', " & Me.Ponderacion & ", '" & Me.Descripcion & "') 
                                ON DUPLICATE KEY UPDATE nombre ='" & Me.Nombre & "', ponderacion =" & Me.Ponderacion & ", descripcion='" & Me.Descripcion & "', activo= " & Me.Activo
            Comando.ExecuteNonQuery()

            Comando.CommandText = "DELETE FROM asociados WHERE idPatologia =" & Me.Id
            Comando.ExecuteNonQuery()

            'recorre la lista de sintomas asociados a la patologia
            For Each sintoma In ListaDeSintomasAsociados
                Comando.CommandText = "INSERT INTO asociados VALUES ( " & sqlTexto & " , " & sintoma & ")"
                Comando.ExecuteNonQuery()
            Next

            Comando.CommandText = "UNLOCK TABLES"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "COMMIT;"
            Comando.ExecuteNonQuery()

            conexion.Close()
        Catch ex As Exception
            Comando.CommandText = "ROLLBACK;"
            Comando.ExecuteNonQuery()
        End Try
    End Sub

    Public Sub CambiarEstadoPatologia(ByVal id As String, estado As String)
        'eliminacion logica de la patologa 
        Comando.CommandText = "UPDATE patologia set activo = " & estado & " WHERE id = " & id & ""
        Comando.ExecuteNonQuery()
        CerrarConexion()
    End Sub

    Public Function BuscarPatologiaPorNombre(ByVal nombre As String) As DataTable
        'trae de la base de datos las patolgias registadas
        Comando.CommandText = "SELECT * FROM patologia WHERE activo = 1 AND nombre like '%" + nombre + "%'"
        Reader = Comando.ExecuteReader()
        TablaPatologia.Load(Reader)
        CerrarConexion()
        Return TablaPatologia
    End Function

    Public Function listarPatologias()
        'Lista las patologias
        Comando.CommandText = "SELECT DISTINCT(p.id), p.nombre, p.ponderacion, p.activo 
                                FROM patologia p 
                                JOIN asociados a ON a.idPatologia = p.id"
        Reader = Comando.ExecuteReader
        TablaPatologia.Load(Reader)
        CerrarConexion()
        Return TablaPatologia
    End Function

    Public Function ListarPatologias(ByVal activo As String)
        'Lista las patologias por estado
        Comando.CommandText = "SELECT DISTINCT(p.id), p.nombre, p.ponderacion, p.activo 
                                FROM patologia p 
                                JOIN asociados a ON a.idPatologia = p.id 
                                WHERE p.activo =" & activo
        Reader = Comando.ExecuteReader
        TablaPatologia.Load(Reader)
        CerrarConexion()
        Return TablaPatologia
    End Function

    Public Function ListarPatologias(ByVal idSintomas As Integer)
        'Lista las patologias por sintoma
        Comando.CommandText = "SELECT p.nombre FROM asociados a
                                JOIN patologia p ON p.id = a.idPatologia 
                                WHERE a.IdSintoma = " & idSintomas
        Reader = Comando.ExecuteReader()
        TablaPatologia.Load(Reader)
        conexion.Close()
        Return TablaPatologia
    End Function

    Public Function ListarPatologiasDeDiagnostico(ByVal idDiagnostico As String)
        'Muestra al paciente las patologias de sus diagnosticos
        Comando.CommandText = "SELECT DISTINCT(p.nombre) FROM tiene t 
                                JOIN patologia p ON p.id = t.idPatologia 
                                WHERE t.idDiagnostico =" & idDiagnostico
        Reader = Comando.ExecuteReader
        TablaPatologia.Load(Reader)
        conexion.Close()
        Return TablaPatologia
    End Function
End Class
