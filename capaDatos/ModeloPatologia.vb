Imports System.Data.Odbc

Public Class ModeloPatologia


    Public Id As Integer
    Public Nombre As String
    Public Ponderacion As Integer
    Public Descripcion As String
    Public Activo As Integer
    Public ListaDeSintomasAsociados As List(Of ModeloSintoma)

    Public Sub GuaradrPatologia()
        ' guarda nueva patologia
        Dim c As New ModeloConexion
        Dim sqlTexto As String
        c.conectar()

        If Me.Id = 0 Then sqlTexto = "last_insert_id()" Else sqlTexto = Me.Id
        Try
            c.Comando.CommandText = "SET AUTOCOMMIT = OFF;"
            c.Comando.ExecuteNonQuery()

            c.Comando.CommandText = "START TRANSACTION;"
            c.Comando.ExecuteNonQuery()

            c.Comando.CommandText = "INSERT INTO patologia (id, nombre, ponderacion, descripcion) VALUES (" & Me.Id & ", '" & Me.Nombre & "', " & Me.Ponderacion & ", '" & Me.Descripcion & "') ON DUPLICATE KEY UPDATE nombre ='" & Me.Nombre & "', ponderacion =" & Me.Ponderacion & ", descripcion='" & Me.Descripcion & "', activo= " & Me.Activo
            c.Comando.ExecuteNonQuery()

            c.Comando.CommandText = "DELETE FROM asociados WHERE idPatologia =" & Me.Id
            c.Comando.ExecuteNonQuery()

            'recorre la lista de sintomas asociados a la patologia
            For Each sintoma In ListaDeSintomasAsociados
                c.Comando.CommandText = "INSERT INTO asociados VALUES ( " & sqlTexto & " , " & sintoma.ID & ", 1 )"
                c.Comando.ExecuteNonQuery()
            Next

            c.Comando.CommandText = "COMMIT;"
            c.Comando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
            c.Comando.CommandText = "ROLLBACK;"
            c.Comando.ExecuteNonQuery()

        End Try
    End Sub


    Public Sub EliminarPatologia()
        'eliminacion logica de la patologa 
        Dim c As New ModeloConexion
        c.conectar()
        c.Comando.CommandText = "UPDATE patologia set activo = 0 WHERE id = " & Me.Id & ""
        c.Comando.ExecuteNonQuery()
        c.CerrarConexion()
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
        Dim c As New ModeloConexion
        Dim tabla As New DataTable
        c.conectar()
        Try
            c.Comando.CommandText = "SELECT * FROM patologia WHERE activo = 1 "
            c.Reader = c.Comando.ExecuteReader()
            tabla.Load(c.Reader)
            Return tabla
        Catch ex As Exception
            Return tabla
        End Try
    End Function


    Public Function BuscarPatologiaPorNombre(ByVal nombre As String) As DataTable
        'trae de la base de datos las patolgias registadas
        Dim c As New ModeloConexion
        Dim tabla As New DataTable
        c.conectar()
        c.Comando.CommandText = "SELECT * FROM patologia WHERE activo = 1 AND nombre like '%" + nombre + "%'"
        c.Reader = c.Comando.ExecuteReader()
        tabla.Load(c.Reader)
        Return tabla
        c.CerrarConexion()
    End Function


    Public Function BuscarPatologiaPorID(ByVal id As Integer)
        Dim c As New ModeloConexion
        c.conectar()
        c.Comando.CommandText = "SELECT * FROM patologia WHERE id = " & id
        c.Reader = c.Comando.ExecuteReader()
        Return crearObjetoPatologia(c.Reader)
        c.CerrarConexion()
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
