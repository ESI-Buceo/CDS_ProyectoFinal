Public Class ModeloMedico
    Inherits ModeloPersona

    Public NumeroMedico As String

    Public Function VerificarDocumentoDeIdentidad(ByVal docidentidad As String)
        Comando.CommandText = "SELECT docidentidad FROM persona WHERE docidentidad =" & docidentidad
        Return Comando.ExecuteScalar
    End Function

    Public Sub GuardarDatosMedico()
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

            guardarEnMEdico()
            guardarTelefonos()

            Comando.CommandText = "COMMIT;"
            Comando.ExecuteNonQuery()

            'CrearUsuarioBD()
        Catch ex As Exception
            Comando.CommandText = "ROLLBACK;"
            Comando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub guardarEnMEdico()
        Comando.CommandText = "INSERT INTO medico VALUES(" & Me.Documento & ", " & Me.NumeroMedico & ") ON DUPLICATE KEY UPDATE ndemedico=" & Me.NumeroMedico
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

    Public Sub CrearUsuarioBD()
        Dim medicoPass As String = "Me." & Me.Documento
        Try
            Comando.CommandText = "CREATE USER '" & Me.Documento & "'@'192.168.1.%' IDENTIFIED BY '" & medicoPass & "'"
            Comando.ExecuteNonQuery()
            CrearPermisosMedico()
        Catch ex As Exception
            MsgBox("No se pudo crear el usuario", vbCritical, "ERROR")
        End Try

    End Sub

    Public Sub CrearPermisosMedico()
        Comando.CommandText = "GRANT SELECT ON dbTriage.persona TO '" & Me.Documento & "'@'192.168.1.%'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "GRANT SELECT ON dbTriage.paciente TO '" & Me.Documento & "'@'192.168.1.%'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "GRANT SELECT ON dbTriage.preexistentes TO '" & Me.Documento & "'@'192.168.1.%'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "GRANT SELECT, UPDATE ON dbTriage.sesion TO '" & Me.Documento & "'@'192.168.1.%'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "GRANT SELECT ON dbTriage.sintoma TO '" & Me.Documento & "'@'192.168.1.%'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "GRANT SELECT, INSERT ON dbTriage.chat TO '" & Me.Documento & "'@'192.168.1.%'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "GRANT SELECT ON dbTriage.recibe TO '" & Me.Documento & "'@'192.168.1.%'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "GRANT SELECT ON dbTriage.tiene TO '" & Me.Documento & "'@'192.168.1.%'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "FLUSH PRIVILEGES"
        Comando.ExecuteNonQuery()
    End Sub

    Public Function BuscarMedico(ByVal stringSql As String)
        Dim tablaMedicos As New DataTable
        Comando.CommandText = "SELECT m.docidentidad DOCUMENTO, p.mail EMAIL, p.nombres NOMBRES, p.apellidos APELLIDOS, p.fechaRegistro FECHREG, m.ndemedico NMEDICO, p.activo ACTIVO 
                                FROM medico m 
                                JOIN persona p ON p.docidentidad = m.docidentidad WHERE " & stringSql
        Reader = Comando.ExecuteReader
        tablaMedicos.Load(Reader)
        Return tablaMedicos
    End Function

    Public Sub EliminarMedico(ByVal docidentidad As String)
        Comando.CommandText = "UPDATE persona SET actico = 0 WHERE docidentidad =" & docidentidad
        Comando.ExecuteNonQuery()
        EliminarUsuarioBD(docidentidad)
    End Sub

    Public Function buscarMedicoPorDocumento(ByVal docIdentidad As String)
        Dim tablaDatos As New DataTable
        Comando.CommandText = "SELECT m.docidentidad as documento, p.mail as mail, p.nombres as nombres, p.apellidos as apellidos, p.calle as calle, p.numero as numero, p.barrio as barrio, 
                                p.esquina as esquina, p.apartamento as apto, p.fechaNacimiento as fechaNac, p.activo as activo, p.fechaRegistro as fechReg, m.ndemedico as nmedico, t.telefono as telefono 
                                FROM medico m 
                                INNER JOIN persona p ON p.docidentidad = m.docidentidad 
                                LEFT JOIN telefono t ON t.docidentidad = m.docidentidad
                                WHERE m.docidentidad =" & docIdentidad
        Reader = Comando.ExecuteReader
        tablaDatos.Load(Reader)
        Return tablaDatos
    End Function

    Public Sub EliminarUsuarioBD(ByVal docidentidad As String)
        Comando.CommandText = "DROP '" & Me.Documento & "' FROM mysql.user"
        Comando.ExecuteNonQuery()
    End Sub
End Class
