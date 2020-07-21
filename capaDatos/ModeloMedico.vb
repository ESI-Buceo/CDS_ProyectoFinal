Public Class ModeloMedico
    Inherits ModeloPersona

    Public NumeroMedico As String

    Public Function VerfificarDocumento(ByVal docidentidad As String)
        Comando.CommandText = "SELECT count(*) FROM medico WHERE docidentidad =" & docidentidad
        Return Comando.ExecuteScalar
    End Function

    Public Sub GuardarDatosMedico()
        Try
            Comando.CommandText = "SET AUTOCOMMIT = OFF;"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "START TRANSACTION;"
            Comando.ExecuteNonQuery()

            MsgBox(Me.FechaNacimiento)
            Comando.CommandText = "INSERT INTO persona (docidentidad, mail, nombres, apellidos, calle, numero, barrio, esquina, apartamento, fechaNacimiento, activo) 
                                        VALUES(" & Me.Documento & ", '" & Me.Email & "', '" & Me.Nombres & "', '" & Me.Apellidos & "','" & Me.Calle & "', '" & Me.Numero & "', '" & Me.Barrio & "', '" & Me.Esquina & "', '" & Me.Apartamento & "', '" & Me.FechaNacimiento & "', activo =1)"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "INSERT INTO medico VALUES(" & Me.Documento & ", " & Me.NumeroMedico & ")"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "DELETE FROM telefono WHERE docidentidad=" & Me.Documento
            Comando.ExecuteNonQuery()

            For Each Telefono In Me.Telefonos.Rows
                If Telefono("Telefono").ToString > 0 Then
                    Comando.CommandText = "INSERT INTO telefono VALUES(" & Me.Documento & ", '" & Telefono("Telefono").ToString & "')"
                    Comando.ExecuteNonQuery()
                End If
            Next
            Comando.CommandText = "COMMIT;"
            Comando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
            Comando.CommandText = "ROLLBACK;"
            Comando.ExecuteNonQuery()

        End Try
    End Sub

    Public Sub ModificarDatosMedico()
        Try
            Comando.CommandText = "SET AUTOCOMMIT = OFF;"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "START TRANSACTION;"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "UPDATE persona SET mail='" & Me.Email & "', nombres='" & Me.Nombres & "', apellidos='" & Me.Apellidos & "', 
                            calle ='" & Me.Calle & "', numero=" & Me.Numero & ", barrio='" & Me.Barrio & "', esquina='" & Me.Esquina & "', 
                            apartamento='" & Me.Apartamento & "', fechaNacimiento='" & Me.FechaNacimiento & "', activo =" & Me.Activo & " WHERE docidentidad=" & Me.Documento
            Comando.ExecuteNonQuery()

            Comando.CommandText = "UPDATE medico SET ndemedico=" & Me.NumeroMedico & " WHERE docidentidad=" & Me.Documento
            Comando.ExecuteNonQuery()

            Comando.CommandText = "DELETE FROM telefono WHERE docidentidad='" & Me.Documento & "'"
            Comando.ExecuteNonQuery()

            For Each Telefono In Me.Telefonos.Rows
                Comando.CommandText = "INSERT INTO telefono VALUES('" & Me.Documento & "', '" & Telefono("Telefono").ToString & "')"
                Comando.ExecuteNonQuery()
            Next

            Comando.CommandText = "COMMIT;"
            Comando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
            Comando.CommandText = "ROLLBACK;"
            Comando.ExecuteNonQuery()
        End Try
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

End Class
