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

        Catch ex As Exception
            Comando.CommandText = "ROLLBACK;"
            Comando.ExecuteNonQuery()
        End Try
    End Sub


    Public Sub EliminarPatologia()
        'eliminacion logica de la patologa 
        Comando.CommandText = "UPDATE patologia set activo = 0 WHERE id = " & Me.Id & ""
        Comando.ExecuteNonQuery()
        CerrarConexion()
    End Sub

    Public Function BuscarPatologiaPorNombre(ByVal nombre As String) As DataTable
        'trae de la base de datos las patolgias registadas
        Dim tabla As New DataTable
        Comando.CommandText = "SELECT * FROM patologia WHERE activo = 1 AND nombre like '%" + nombre + "%'"
        Reader = Comando.ExecuteReader()
        tabla.Load(Reader)
        CerrarConexion()
        Return tabla
    End Function


    Public Function BuscarPatologiaPorID(ByVal id As Integer)
        Comando.CommandText = "SELECT * FROM patologia WHERE id = " & id
        Reader = Comando.ExecuteReader()
        tablaPatologiasParaDiagnostico.Load(Reader)
        CerrarConexion()
        Return tablaPatologiasParaDiagnostico
    End Function

    Public Function listarPatologias()
        Dim tablaPatologias As New DataTable
        Comando.CommandText = "SELECT DISTINCT(p.id), p.nombre, p.ponderacion, p.activo 
                                FROM patologia p 
                                JOIN asociados a ON a.idPatologia = p.id"
        Reader = Comando.ExecuteReader
        tablaPatologias.Load(Reader)
        CerrarConexion()
        Return tablaPatologias
    End Function

    Public Function listarPatologias(ByVal activo As String)
        Dim tablaPatologias As New DataTable
        Comando.CommandText = "SELECT DISTINCT(p.id), p.nombre, p.ponderacion, p.activo 
                                FROM patologia p 
                                JOIN asociados a ON a.idPatologia = p.id 
                                WHERE p.activo =" & activo
        Reader = Comando.ExecuteReader
        tablaPatologias.Load(Reader)
        CerrarConexion()
        Return tablaPatologias
    End Function
End Class
