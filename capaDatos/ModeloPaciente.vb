Public Class ModeloPaciente
    Inherits ModeloPersona

    Public TablaPreExistente As DataTable

    Public Sub New(ByVal uid As String, pwd As String)
        MyBase.New(uid, pwd)
    End Sub

    Public Function VerificarDocumentoDeIdentidad(ByVal docidentidad As String)
        Comando.CommandText = "SELECT docidentidad FROM persona WHERE docidentidad=" & docidentidad
        Return Comando.ExecuteScalar
        CerrarConexion()
    End Function

    Public Sub GuardarDatosPaciente()
        Try
            Comando.CommandText = "SET AUTOCOMMIT = OFF;"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "START TRANSACTION;"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "LOCK TABLE persona WRITE, paciente WRITE, telefono WRITE, preexistentes WRITE"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "INSERT INTO persona (docidentidad, mail, nombres, apellidos, calle, numero, barrio, esquina, apartamento, fechaNacimiento, activo) 
                                        VALUES(" & Me.Documento & ", '" & Me.Email & "', '" & Me.Nombres & "', '" & Me.Apellidos & "','" & Me.Calle & "', '" & Me.Numero & "', 
                                                '" & Me.Barrio & "', '" & Me.Esquina & "', '" & Me.Apartamento & "', '" & Me.FechaNacimiento & "', activo =1) 
                                        ON DUPLICATE KEY UPDATE 
                                                mail='" & Me.Email & "', nombres='" & Me.Nombres & "', apellidos='" & Me.Apellidos & "', calle ='" & Me.Calle & "', numero='" & Me.Numero & "',
                                                barrio='" & Me.Barrio & "', esquina='" & Me.Esquina & "', apartamento='" & Me.Apartamento & "', fechaNacimiento='" & Me.FechaNacimiento & "', activo =" & Me.Activo
            Comando.ExecuteNonQuery()

            Comando.CommandText = "INSERT IGNORE INTO paciente VALUES(" & Me.Documento & ")"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "DELETE FROM telefono WHERE docidentidad=" & Me.Documento
            Comando.ExecuteNonQuery()

            For Each Telefono In Me.Telefonos.Rows
                If Telefono("Telefono").ToString.Length > 1 Then
                    Comando.CommandText = "INSERT INTO telefono VALUES(" & Me.Documento & ", '" & Telefono("Telefono").ToString & "')"
                    Comando.ExecuteNonQuery()
                End If
            Next

            Comando.CommandText = "DELETE FROM preexistentes WHERE docidentidad=" & Me.Documento
            Comando.ExecuteNonQuery()

            For Each PreExistentes In Me.TablaPreExistente.Rows
                If PreExistentes("preExistentes").ToString.Length > 1 Then
                    Comando.CommandText = "INSERT INTO preexistentes VALUES(" & Me.Documento & ", '" & PreExistentes("preExistentes").ToString & "')"
                    Comando.ExecuteNonQuery()
                End If
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

    Public Sub CrearUsuarioBD()
        Try
            Dim pacientePass As String = "Pa." & Me.Documento
            Comando.CommandText = "CREATE USER '" & Me.Documento & "'@'%' IDENTIFIED BY '" & pacientePass & "'"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT SELECT ON dbTriage.persona TO '" & Me.Documento & "'@'%'"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT SELECT ON dbTriage.medico TO '" & Me.Documento & "'@'%'"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT SELECT ON dbTriage.paciente TO '" & Me.Documento & "'@'%'"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT SELECT ON dbTriage.telefono TO '" & Me.Documento & "'@'%'"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT SELECT, INSERT, UPDATE ON dbTriage.sesion TO '" & Me.Documento & "'@'%'"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT SELECT ON dbTriage.sintoma TO '" & Me.Documento & "'@'%'"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT SELECT ON dbTriage.patologia TO '" & Me.Documento & "'@'%'"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT SELECT, INSERT, UPDATE ON dbTriage.chat TO '" & Me.Documento & "'@'%'"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT SELECT, INSERT ON dbTriage.diagnostico TO '" & Me.Documento & "'@'%'"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT INSERT ON dbTriage.recibe TO '" & Me.Documento & "'@'%'"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT INSERT ON dbTriage.tiene TO '" & Me.Documento & "'@'%'"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT SELECT ON dbTriage.asociados TO '" & Me.Documento & "'@'%'"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "FLUSH PRIVILEGES"
            Comando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("No se pudo crear el usuario paciente", vbCritical, "Error de Usuario")
        End Try

    End Sub

    Public Function BuscarPaciente(ByVal stringSql As String)
        Dim tablaPacientes As New DataTable
        Comando.CommandText = "SELECT p2.docidentidad DOCUMENTO, p.mail EMAIL, p.nombres NOMBRES, p.apellidos APELLIDOS, p.fechaRegistro FECHREG, p.activo ACTIVO 
                                FROM paciente p2 
                                JOIN persona p ON p.docidentidad = p2.docidentidad WHERE " & stringSql
        Reader = Comando.ExecuteReader
        tablaPacientes.Load(Reader)
        CerrarConexion()
        Return tablaPacientes
    End Function

    Public Sub EliminarPaciente(ByVal docidentidad As String)
        Comando.CommandText = "UPDATE persona SET activo = 0 WHERE docidentidad =" & docidentidad
        Comando.ExecuteNonQuery()
        EliminarUsuarioBD(docidentidad)
    End Sub

    Public Sub EliminarUsuarioBD(ByVal docidentidad As String)
        Comando.CommandText = "DROP '" & Me.Documento & "' FROM mysql.user"
        Comando.ExecuteNonQuery()
        CerrarConexion()
    End Sub

    Public Function buscarPacientePorDocumento(ByVal docIdentidad As String)
        Dim tablaDatos As New DataTable
        Comando.CommandText = "SELECT p.docidentidad as documento, p2.mail as mail, p2.nombres as nombres, p2.apellidos as apellidos, p2.calle as calle, p2.numero as numero, p2.barrio as barrio, 
                                p2.esquina as esquina, p2.apartamento as apto, p2.fechaNacimiento as fechaNac, p2.activo as activo, p2.fechaRegistro as fechReg, t.telefono as telefono
                                FROM paciente p 
                                INNER JOIN persona p2 ON p2.docidentidad = p.docidentidad 
                                LEFT JOIN telefono t ON t.docidentidad = p.docidentidad
                                WHERE p.docidentidad =" & docIdentidad
        Reader = Comando.ExecuteReader
        tablaDatos.Load(Reader)
        CerrarConexion()
        Return tablaDatos
    End Function

    Public Function DatosPaciente(ByVal idSesion As String)
        Dim tablaDatosPaciente As New DataTable
        Comando.CommandText = "SELECT p2.docidentidad DOC, p2.nombres NOMBRE, p2.apellidos APELLIDO, p2.mail EMAIL, p2.calle CALLE, p2.numero NUM, p2.barrio BARRIO, p2.esquina ESQUINA, p2.apartamento APTO, p2.fechaNacimiento FECHANAC ,p2.fechaRegistro FECHREGISTRO 
                               FROM recibe r 
                               JOIN paciente p ON p.docidentidad = r.idPaciente 
                               JOIN persona p2 ON p2.docidentidad = p.docidentidad 
                               WHERE r.idDiagnostico=" & idSesion
        Reader = Comando.ExecuteReader()
        tablaDatosPaciente.Load(Reader)
        CerrarConexion()
        Return tablaDatosPaciente
    End Function

    Public Function CargarPreExistentes()
        Dim tablaPreExistentes As New DataTable
        Comando.CommandText = "SELECT preexistente PREEXISTENTE FROM preexistentes WHERE docidentidad =" & Me.Documento
        Reader = Comando.ExecuteReader
        tablaPreExistentes.Load(Reader)
        CerrarConexion()
        Return tablaPreExistentes
    End Function

    Public Function ListarPacientes()
        Dim tablaPacientes As New DataTable
        Comando.CommandText = "SELECT p.docidentidad,  pe.nombres, pe.apellidos, pe.mail, pe.activo, pe.fechaRegistro FROM paciente p JOIN persona pe ON pe.docidentidad = p.docidentidad"
        Reader = Comando.ExecuteReader
        tablaPacientes.Load(Reader)
        CerrarConexion()
        Return tablaPacientes
    End Function

    Public Function ListarPacientes(ByVal activo As String)
        Dim tablaPacientes As New DataTable
        Comando.CommandText = "SELECT p.docidentidad,  pe.nombres, pe.apellidos, pe.mail, pe.activo, pe.fechaRegistro FROM paciente p JOIN persona pe ON pe.docidentidad = p.docidentidad WHERE pe.activo =" & activo
        Reader = Comando.ExecuteReader
        tablaPacientes.Load(Reader)
        CerrarConexion()
        Return tablaPacientes
    End Function

    Public Function ListarTelefonos(ByVal docidentidad As String)
        Dim tablaTelefonos As New DataTable
        Comando.CommandText = "SELECT telefono FROM telefono WHERE docidentidad =" & docidentidad
        Reader = Comando.ExecuteReader
        tablaTelefonos.Load(Reader)
        CerrarConexion()
        Return tablaTelefonos
    End Function
End Class
