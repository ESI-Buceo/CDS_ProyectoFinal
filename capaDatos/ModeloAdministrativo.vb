Imports capaDatos
Public Class ModeloAdministrativo
    Inherits ModeloPersona

    Public NumeroEmpleado As Integer

    Public Function VerificarDocumentoDeIdentidad(ByVal docidentidad As String)
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

            Comando.CommandText = "INSERT INTO persona (docidentidad, mail, nombres, apellidos, calle, numero, barrio, esquina, apartamento, fechaNacimiento, activo) 
                                        VALUES(" & Me.Documento & ", '" & Me.Email & "', '" & Me.Nombres & "', '" & Me.Apellidos & "','" & Me.Calle & "', '" & Me.Numero & "', 
                                                '" & Me.Barrio & "', '" & Me.Esquina & "', '" & Me.Apartamento & "', '" & Me.FechaNacimiento & "', activo =1) 
                                        ON DUPLICATE KEY UPDATE 
                                                mail='" & Me.Email & "', nombres='" & Me.Nombres & "', apellidos='" & Me.Apellidos & "', calle ='" & Me.Calle & "', numero='" & Me.Numero & "',
                                                barrio='" & Me.Barrio & "', esquina='" & Me.Esquina & "', apartamento='" & Me.Apartamento & "', fechaNacimiento='" & Me.FechaNacimiento & "', activo =" & Me.Activo
            Comando.ExecuteNonQuery()

            guardarEnCategoriaAdministrativo()
            guardarTelefonos()

            Comando.CommandText = "COMMIT;"
            Comando.ExecuteNonQuery()

            'crearUsuarioBD()

        Catch ex As Exception
            MsgBox(ex.Message)
            Comando.CommandText = "ROLLBACK;"
            Comando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub guardarEnCategoriaAdministrativo()
        'Guarda el registro del administrativo en la categoria administrativo
        Comando.CommandText = "INSERT INTO administrativo VALUES(" & Me.Documento & ", " & Me.NumeroEmpleado & ") ON DUPLICATE KEY UPDATE ndeempleado=" & Me.NumeroEmpleado
        Comando.ExecuteNonQuery()
    End Sub

    Private Sub crearUsuarioBD()
        'Crea el usuario en la base de datos
        Dim gestorPass As String = "Ge." & Me.Documento
        Try
            Comando.CommandText = "CREATE USER '" & Me.Documento & "'@'192.168.1.%' IDENTIFIED BY '" & gestorPass & "'"
            Comando.ExecuteNonQuery()
            crearPermisosAdministrativo()
        Catch ex As Exception
            MsgBox("No se pudo crear el usuario!", vbCritical, "ERROR")
        End Try

    End Sub

    Private Sub crearPermisosAdministrativo()
        'Otorga permiso para crear usuarios y reload de mysql
        Comando.CommandText = "GRANT CREATE USER, RELOAD ON *.* TO '" & Me.Documento & "'@'192.168.1.%'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "GRANT SELECT, INSERT, UPDATE ON dbTriage.persona TO '" & Me.Documento & "'@'192.168.1.%'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "GRANT SELECT, INSERT, UPDATE ON dbTriage.telefono TO '" & Me.Documento & "'@'192.168.1.%'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "GRANT SELECT, INSERT, UPDATE ON dbTriage.administrativo TO '" & Me.Documento & "'@'192.168.1.%'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "GRANT SELECT, INSERT, UPDATE ON dbTriage.medico TO '" & Me.Documento & "'@'192.168.1.%'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "GRANT SELECT, INSERT, UPDATE ON dbTriage.paciente TO '" & Me.Documento & "'@'192.168.1.%'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "GRANT SELECT, INSERT, UPDATE ON dbTriage.preexistentes TO '" & Me.Documento & "'@'192.168.1.%'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "GRANT SELECT, INSERT, UPDATE ON dbTriage.sintoma TO '" & Me.Documento & "'@'192.168.1.%'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "GRANT SELECT, INSERT, UPDATE ON dbTriage.patologia TO '" & Me.Documento & "'@'192.168.1.%'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "GRANT SELECT, INSERT, UPDATE ON dbTriage.asociados TO '" & Me.Documento & "'@'192.168.1.%'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "FLUSH PRIVILEGES"
        Comando.ExecuteNonQuery()
    End Sub

    Private Sub guardarTelefonos()
        Comando.CommandText = "DELETE FROM telefono WHERE docidentidad=" & Me.Documento
        Comando.ExecuteNonQuery()

        For Each Telefono In Me.Telefonos.Rows
            If Telefono("Telefono").ToString.Length > 1 Then
                Comando.CommandText = "INSERT INTO telefono VALUES(" & Me.Documento & ", '" & Telefono("Telefono").ToString & "')"
                Comando.ExecuteNonQuery()
            End If
        Next
    End Sub

    Public Function BuscarAdministativo(ByVal stringSql As String)
        Dim tablaMedicos As New DataTable
        Comando.CommandText = "SELECT a.docidentidad DOCUMENTO, p.mail EMAIL, p.nombres NOMBRES, p.apellidos APELLIDOS, p.fechaRegistro FECHREG, a.ndeempleado NEMPLEADO, p.activo ACTIVO 
                                FROM administrativo a 
                                JOIN persona p ON p.docidentidad = a.docidentidad WHERE " & stringSql
        Reader = Comando.ExecuteReader
        tablaMedicos.Load(Reader)
        Return tablaMedicos
    End Function

    Public Function BuscarAdministrativoPorDocumento(ByVal docidentidad As String)
        Dim tablaDatosAdministrativo As New DataTable
        Comando.CommandText = "SELECT a.docidentidad as documento, p.mail as mail, p.nombres as nombres, p.apellidos as apellidos, p.calle as calle, p.numero as numero, p.barrio as barrio, 
                                p.esquina as esquina, p.apartamento as apto, p.fechaNacimiento as fechaNac, p.activo as activo, p.fechaRegistro as fechReg, a.ndeempleado as ndeempleado, t.telefono as telefono 
                                FROM administrativo a 
                                INNER JOIN persona p ON p.docidentidad = a.docidentidad 
                                LEFT JOIN telefono t ON t.docidentidad = a.docidentidad
                                WHERE a.docidentidad =" & docidentidad
        Reader = Comando.ExecuteReader
        tablaDatosAdministrativo.Load(Reader)
        Return tablaDatosAdministrativo
    End Function

    Public Sub EliminarAdministrativo(ByVal docidentidad As String)
        Comando.CommandText = "UPDATE persona SET activo=0 WHERE docidentidad=" & docidentidad
        Comando.ExecuteNonQuery()
        EliminarUsuarioBD(docidentidad)
    End Sub

    Public Sub EliminarUsuarioBD(ByVal docidentidad As String)
        Comando.CommandText = "DROP USER '" & docidentidad & "'@'192.168.1.%'"
        Comando.ExecuteNonQuery()
    End Sub
End Class
