Imports System.Data.Odbc

Public Class ModeloPatologia
    Inherits ModeloConexion

    Public Id As Integer
    Public Nombre As String
    Public Ponderacion As Integer
    Public Descripcion As String
    Public activo As Integer
    Public ListaDeSintomasAsociados As List(Of ModeloSintoma)

    Public Sub GuaradrPatologia()
        ' guarda nueva patologia
        Dim sqlTexto As String
        If Me.Id = 0 Then sqlTexto = "last_insert_id()" Else sqlTexto = Me.Id
        Try
            comando.CommandText = "SET AUTOCOMMIT = OFF;"
            comando.ExecuteNonQuery()

            comando.CommandText = "START TRANSACTION;"
            comando.ExecuteNonQuery()

            comando.CommandText = "INSERT INTO patologia (id, nombre, ponderacion, descripcion) VALUES (" & Me.Id & ", '" & Me.Nombre & "', " & Me.Ponderacion & ", '" & Me.Descripcion & "') ON DUPLICATE KEY UPDATE nombre ='" & Me.Nombre & "', ponderacion =" & Me.Ponderacion & ", descripcion='" & Me.Descripcion & "', activo= " & Me.activo
            comando.ExecuteNonQuery()

            comando.CommandText = "DELETE FROM asociados WHERE idPatologia =" & Me.Id
            comando.ExecuteNonQuery()

            'recorre la lista de sintomas asociados a la patologia
            For Each sintoma In ListaDeSintomasAsociados
                comando.CommandText = "INSERT INTO asociados VALUES ( " & sqlTexto & " , " & sintoma.ID & ", 1 )"
                comando.ExecuteNonQuery()
            Next

            comando.CommandText = "COMMIT;"
            comando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
            comando.CommandText = "ROLLBACK;"
            comando.ExecuteNonQuery()

        End Try
    End Sub


    Public Sub eliminarPatologia()
        'eliminacion logica de la patologa 
        comando.CommandText = "UPDATE patologia set activo = 0 WHERE id = " & Me.Id & ""
        comando.ExecuteNonQuery()
    End Sub


    Private Function validarNombre() As Boolean
        'valida que el nombre no tenga caracteres raros
        Return True
    End Function


    Private Function validarDescripcion() As Boolean
        'valida que la descripcion no tenga codigos raros
        Return True
    End Function


    Private Function validarPonderacion() As Boolean
        'valida que la ponderacion sea numerica
        Return True
    End Function


    Private Function validarEstado() As Boolean
        'valida que el esado true o false
        Return True
    End Function


    Public Function TraeDatosPatologiasDeBD() As DataTable
        'trae de la base de datos las patolgias registadas
        Dim tabla As New DataTable

        Try
            comando.CommandText = "SELECT * FROM patologia WHERE activo = 1 "
            reader = comando.ExecuteReader()
            tabla.Load(reader)
            Return tabla
        Catch ex As Exception
            Return tabla
        End Try
    End Function


    Public Function BuscarPatologiaPorNombre(ByVal nombre As String) As DataTable
        'trae de la base de datos las patolgias registadas
        Dim tabla As New DataTable
        comando.CommandText = "SELECT * FROM patologia WHERE activo = 1 AND nombre like '%" + nombre + "%'"
        reader = comando.ExecuteReader()
        tabla.Load(reader)
        Return tabla
    End Function


    Public Function BuscarPatologiaPorID(ByVal id As Integer)
        comando.CommandText = "SELECT * FROM patologia WHERE id = " & id
        reader = comando.ExecuteReader()
        Return crearObjetoPatologia(reader)
    End Function


    Private Function crearObjetoPatologia(ByRef patologia As OdbcDataReader) As ModeloPatologia
        Dim datosPatologia As New ModeloPatologia
        patologia.Read()
        datosPatologia.Id = patologia(0)
        datosPatologia.Nombre = patologia(1)
        datosPatologia.Ponderacion = patologia(2)
        datosPatologia.Descripcion = patologia(3)
        Return datosPatologia
    End Function


End Class
