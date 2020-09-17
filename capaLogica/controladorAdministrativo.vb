Imports System.Data
Imports System.Windows.Forms
Imports capaDatos

Public Module controladorAdministrativo

    Public Function VerificarDocumentoDeIdentidad(ByVal docidentidad As String, uid As String, pwd As String)
        Dim a As New ModeloAdministrativo(uid, pwd)
        Return a.VerificarDocumentoDeIdentidad(docidentidad)
    End Function

    Public Function GuardarDatosAdmin(ByVal docId As String, email As String, nombres As String, apellidos As String, calle As String,
                                 numero As String, barrio As String, esquina As String, apartamento As String, fechaNac As String,
                                 telefonos As List(Of Integer), numeroAdmin As String, uid As String, pwd As String)
        'Guarda los datos del administrativo
        Try
            Dim a As New ModeloAdministrativo(uid, pwd)
            a.Documento = docId
            a.Email = email
            a.Nombres = nombres
            a.Apellidos = apellidos
            a.Calle = calle
            a.Numero = numero
            a.Barrio = barrio
            a.Esquina = esquina
            a.Apartamento = apartamento
            a.FechaNacimiento = fechaNac
            a.NumeroEmpleado = numeroAdmin
            a.Telefonos = telefonos
            a.GuardarAdministrativo()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function CrearUsuarioBD(ByVal docidentidad As String, uid As String, pwd As String)
        Try
            Dim a As New ModeloAdministrativo(uid, pwd)
            a.Documento = docidentidad
            a.RangoIpAdministrativo = ControladorConfiguracion.leerRangoIpGestion(uid, pwd)
            a.CrearUsuarioBD()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function crearCadenaDeBusquedaAdministrativo(ByVal campoABuscar As String, datoABuscar As String)
        'Crea la cadena de consulta de acuerdo a los datos ingresados para ello
        Select Case campoABuscar
            Case "txtDocIdentidad" : Return "p.docidentidad=" & datoABuscar
            Case "txtNumAdmin" : Return "a.ndeempleado=" & datoABuscar
            Case "txtNombres" : Return "p.nombres LIKE '%" & datoABuscar & "%'"
            Case "txtApellidos" : Return "p.apellidos LIKE '%" & datoABuscar & "%'"
        End Select
        Return ""
    End Function

    Public Function buscarAdministrativo(ByVal cadenaSql As String, uid As String, pwd As String)
        'Busca los administrativos que coinciden con los criterios de busqueda
        Dim m As New ModeloAdministrativo(uid, pwd)
        Return m.BuscarAdministativo(formatearSqlBuscquedaAdministrativo(cadenaSql))
    End Function

    Public Function BuscarAdministrativoPorDocumento(ByVal docidentidad As String, uid As String, pwd As String)
        'Busca un administrativo por el numero de doc
        Dim a As New ModeloAdministrativo(uid, pwd)
        Return a.BuscarAdministrativoPorDocumento(docidentidad)
    End Function

    Public Function crearTablaTelefonos()
        'Crea la tabla que alimenta el datagrid de telefonos
        Dim tablaTel As New DataTable
        tablaTel.Columns.Add("Telefono")
        Return tablaTel
    End Function

    Public Function formatearSqlBuscquedaAdministrativo(ByVal datoString As String)
        'Elimina el ultimo and de la consulta
        If datoString IsNot Nothing Then
            Return datoString.Remove(datoString.Length - 4, 4)
        End If
        Return "p.nombres like '%%'"
    End Function

    Public Function cambiarEstadoAdmin(ByVal docIdentidad As String, estado As String, uid As String, pwd As String)
        Dim a As New ModeloAdministrativo(uid, pwd)
        Return a.CambiarEstadoAdmin(docIdentidad, estado)
    End Function

    Public Function ValidarAdministrativo(ByVal uid As String, pwd As String) As DataTable
        Dim a As New ModeloAdministrativo(uid, pwd)
        Return a.ValidarAdministrativo(uid)
    End Function

    Public Function eliminiarUsuarioBD(ByVal docidentidad As String, uid As String, pwd As String)
        Try
            Dim a As New ModeloAdministrativo(uid, pwd)
            a.RangoIpAdministrativo = ControladorConfiguracion.leerRangoIpGestion(uid, pwd)
            a.EliminarUsuarioBD(docidentidad)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function CambiarPassword(ByVal pass As String, uid As String, pwd As String)
        Try
            Dim a As New ModeloAdministrativo(uid, pwd)
            a.Documento = uid
            a.RangoIpAdministrativo = ControladorConfiguracion.leerRangoIpGestion(uid, pwd)
            a.CambiarPassword(pass)
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function ListarAdministrativos(ByVal estado As String, uid As String, pwd As String)
        'Lista los administrativos por estado
        Dim a As New ModeloAdministrativo(uid, pwd)
        Return a.ListarAdministrativos(estado)
    End Function

    Public Function ListarAdministrativos(ByVal uid As String, pwd As String)
        'Lista todos los administrativos
        Dim a As New ModeloAdministrativo(uid, pwd)
        Return a.ListarAdministrativos()
    End Function

    Public Function ListarTelefonos(ByVal docidentidad As String, uid As String, pwd As String)
        Dim a As New ModeloAdministrativo(uid, pwd)
        Return a.ListarTelefonos(docidentidad)
    End Function

End Module