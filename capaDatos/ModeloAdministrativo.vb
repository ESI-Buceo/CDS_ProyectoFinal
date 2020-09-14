Imports capaDatos
Public Class ModeloAdministrativo
    Inherits ModeloPersona

    Public NumeroEmpleado As Integer
    Public RangoIpAdministrativo As String
    Public TablaAdmin As New DataTable

    Public Sub New(ByVal uid As String, pwd As String)
        MyBase.New(uid, pwd)
    End Sub

    Public Function VerificarDocumentoDeIdentidad(ByVal docidentidad As String)
        'Valida la existencia del documento
        Comando.CommandText = "SELECT docidentidad FROM persona WHERE docidentidad =" & docidentidad
        Return Comando.ExecuteScalar
    End Function

    Public Sub GuardarAdministrativo()
        'guarda los datos de un administrativo nuevo
        Try
            Comando.CommandText = "SET AUTOCOMMIT = OFF;"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "START TRANSACTION;"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "LOCK TABLE persona WRITE, administrativo WRITE, telefono WRITE"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "INSERT INTO persona (docidentidad, mail, nombres, apellidos, calle, numero, barrio, esquina, apartamento, fechaNacimiento, activo) 
                                        VALUES(" & Me.Documento & ", '" & Me.Email & "', '" & Me.Nombres & "', '" & Me.Apellidos & "','" & Me.Calle & "', '" & Me.Numero & "', 
                                                '" & Me.Barrio & "', '" & Me.Esquina & "', '" & Me.Apartamento & "', '" & Me.FechaNacimiento & "', activo = 1) 
                                        ON DUPLICATE KEY UPDATE 
                                                mail='" & Me.Email & "', nombres='" & Me.Nombres & "', apellidos='" & Me.Apellidos & "', calle ='" & Me.Calle & "', numero='" & Me.Numero & "',
                                                barrio='" & Me.Barrio & "', esquina='" & Me.Esquina & "', apartamento='" & Me.Apartamento & "', fechaNacimiento='" & Me.FechaNacimiento & "'"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "INSERT IGNORE INTO administrativo VALUES(" & Me.Documento & ", " & Me.NumeroEmpleado & ") ON DUPLICATE KEY UPDATE ndeempleado=" & Me.NumeroEmpleado
            Comando.ExecuteNonQuery()

            Comando.CommandText = "DELETE FROM telefono WHERE docidentidad=" & Me.Documento
            Comando.ExecuteNonQuery()

            For Each Telefono In Me.Telefonos.Rows
                If Telefono("Telefono").ToString.Length > 1 Then
                    Comando.CommandText = "INSERT INTO telefono VALUES(" & Me.Documento & ", '" & Telefono("Telefono").ToString & "')"
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
        'Crea el usuario en la base de datos
        Dim gestorPass As String = "Ge." & Me.Documento
        Comando.CommandText = "GRANT ALL PRIVILEGES ON *.* TO '" & Me.Documento & "'@'" & Me.RangoIpAdministrativo & "' IDENTIFIED BY '" & gestorPass & "' WITH GRANT OPTION"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "GRANT SELECT, INSERT, UPDATE ON dbTriage.persona TO '" & Me.Documento & "'@'" & Me.RangoIpAdministrativo & "'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "GRANT SELECT, INSERT, UPDATE, DELETE ON dbTriage.telefono TO '" & Me.Documento & "'@'" & Me.RangoIpAdministrativo & "'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "GRANT SELECT, INSERT, UPDATE ON dbTriage.administrativo TO '" & Me.Documento & "'@'" & Me.RangoIpAdministrativo & "'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "GRANT SELECT, INSERT, UPDATE ON dbTriage.medico TO '" & Me.Documento & "'@'" & Me.RangoIpAdministrativo & "'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "GRANT SELECT, INSERT, UPDATE ON dbTriage.paciente TO '" & Me.Documento & "'@'" & Me.RangoIpAdministrativo & "'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "GRANT SELECT, INSERT, UPDATE, DELETE ON dbTriage.preexistentes TO '" & Me.Documento & "'@'" & Me.RangoIpAdministrativo & "'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "GRANT SELECT, INSERT, UPDATE ON dbTriage.sintoma TO '" & Me.Documento & "'@'" & Me.RangoIpAdministrativo & "'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "GRANT SELECT, INSERT, UPDATE ON dbTriage.patologia TO '" & Me.Documento & "'@'" & Me.RangoIpAdministrativo & "'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "GRANT SELECT, INSERT, UPDATE, DELETE ON dbTriage.asociados TO '" & Me.Documento & "'@'" & Me.RangoIpAdministrativo & "'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "GRANT SELECT, INSERT, UPDATE, DELETE ON dbTriage.setting TO '" & Me.Documento & "'@'" & Me.RangoIpAdministrativo & "'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "FLUSH PRIVILEGES"
        Comando.ExecuteNonQuery()
    End Sub

    Public Function BuscarAdministativo(ByVal stringSql As String)
        Comando.CommandText = "SELECT a.docidentidad DOCUMENTO, p.mail EMAIL, p.nombres NOMBRES, p.apellidos APELLIDOS, p.fechaRegistro FECHREG, a.ndeempleado NEMPLEADO, p.activo ACTIVO 
                                FROM administrativo a 
                                JOIN persona p ON p.docidentidad = a.docidentidad WHERE " & stringSql
        Reader = Comando.ExecuteReader
        TablaAdmin.Load(Reader)
        CerrarConexion()
        Return TablaAdmin
    End Function

    Public Function BuscarAdministrativoPorDocumento(ByVal docidentidad As String)
        Comando.CommandText = "SELECT a.docidentidad as documento, p.mail as mail, p.nombres as nombres, p.apellidos as apellidos, p.calle as calle, p.numero as numero, p.barrio as barrio, 
                                p.esquina as esquina, p.apartamento as apto, p.fechaNacimiento as fechaNac, p.activo as activo, p.fechaRegistro as fechReg, a.ndeempleado as ndeempleado, t.telefono as telefono 
                                FROM administrativo a 
                                INNER JOIN persona p ON p.docidentidad = a.docidentidad 
                                LEFT JOIN telefono t ON t.docidentidad = a.docidentidad
                                WHERE a.docidentidad =" & docidentidad
        Reader = Comando.ExecuteReader
        TablaAdmin.Load(Reader)
        CerrarConexion()
        Return TablaAdmin
    End Function

    Public Function CambiarEstadoAdmin(ByVal docidentidad As String, estado As String)
        Comando.CommandText = "UPDATE persona SET activo=" & estado & " WHERE docidentidad=" & docidentidad
        Comando.ExecuteNonQuery()
        CerrarConexion()
        Return True
    End Function

    Public Sub EliminarUsuarioBD(ByVal docidentidad As String)
        Comando.CommandText = "DROP USER '" & docidentidad & "'@'" & Me.RangoIpAdministrativo & "'"
        Comando.ExecuteNonQuery()
    End Sub

    Public Function ValidarAdministrativo(ByVal uid As String)
        Comando.CommandText = "SELECT p.docidentidad documento, p.nombres nombres, p.apellidos apellidos
                                FROM persona p
                                JOIN administrativo a ON a.docidentidad = p.docidentidad 
                                WHERE p.docidentidad =" & uid
        Reader = Comando.ExecuteReader
        TablaAdmin.Load(Reader)
        CerrarConexion()
        Return TablaAdmin
    End Function

    Public Sub CambiarPassword(ByVal pass As String)
        Comando.CommandText = "ALTER USER '" & Me.Documento & "'@'" & Me.RangoIpAdministrativo & "' IDENTIFIED BY '" & "Ge." & pass & "'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "FLUSH PRIVILEGES"
        Comando.ExecuteNonQuery()

    End Sub

    Public Function ListarAdministrativos(ByVal estado As String)
        'Lista los administratvos segun su estado
        Comando.CommandText = "SELECT p.docidentidad, a.ndeempleado, p.nombres, p.apellidos, p.mail, p.fechaRegistro, p.activo
                                FROM persona p
                                JOIN administrativo a ON a.docidentidad = p.docidentidad
                                WHERE p.activo =" & estado
        Reader = Comando.ExecuteReader
        TablaAdmin.Load(Reader)
        CerrarConexion()
        Return TablaAdmin
    End Function

    Public Function ListarAdministrativos()
        'Lista todos los administrativos
        Comando.CommandText = "SELECT p.docidentidad, a.ndeempleado, p.nombres, p.apellidos, p.mail, p.fechaRegistro, p.activo
                                FROM persona p
                                JOIN administrativo a ON a.docidentidad = p.docidentidad"
        Reader = Comando.ExecuteReader
        TablaAdmin.Load(Reader)
        CerrarConexion()
        Return TablaAdmin
    End Function

    Public Function ListarTelefonos(ByVal docidentidad As String)
        'Lista los telefonos de un administativo especifico
        Dim tablaTelefonos As New DataTable
        Comando.CommandText = "SELECT telefono FROM telefono WHERE docidentidad = " & docidentidad
        Reader = Comando.ExecuteReader
        tablaTelefonos.Load(Reader)
        CerrarConexion()
        Return tablaTelefonos
    End Function
End Class
