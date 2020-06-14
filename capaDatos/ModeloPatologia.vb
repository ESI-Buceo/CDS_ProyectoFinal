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
        comando.CommandText = "INSERT INTO patologia (id, nombre, ponderacion, descripcion, activo) VALUES 
                              (" & Me.Id & ",'" & Me.Nombre & "'," & Me.Ponderacion & ",'" & Me.Descripcion & "'," & Me.activo & ") ON DUPLICATE KEY UPDATE nombre = '" & Me.Nombre & "', ponderacion = " & Me.Ponderacion & ", descripcion = '" & Me.Descripcion & "', activo = " & Me.activo
        comando.ExecuteNonQuery()
    End Sub


    Public Sub eliminarPatologia()
        'elimina la patologa con el id
        comando.CommandText = "DELETE FROM patologia WHERE id = " & Me.Id & ""
        comando.ExecuteNonQuery()
    End Sub


    'Public Sub ModifcarPatologia()
    'modifica la patologia 
    ' comando.CommandText = "UPDATE patologia SET nombre = '" & Me.Nombre & "', ponderacion = " & Me.Ponderacion & ", 
    '   descripcion = '" & Me.Descripcion & "', activo = " & Me.activo & " WHERE id = " & Me.Id & ""
    '  comando.ExecuteNonQuery()
    'End Sub


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
