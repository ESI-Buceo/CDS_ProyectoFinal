Imports System.Data
Imports System.Windows.Forms
Imports capaDatos

Public Module controladorPacientes

    Public Function identificarPaciente(ByVal uid As String, pwd As String)
        Dim p As New ModeloPaciente(uid, pwd)
        Return p.buscarPacientePorDocumento(uid)
    End Function

    Public Function VarificarDocumentoDeIdentidad(ByVal docidentidad As String, uid As String, pwd As String)
        'Valida la existencia o no del documento en la base de datos
        Dim a As New ModeloPaciente(uid, pwd)
        Return a.VerificarDocumentoDeIdentidad(docidentidad)
    End Function

    Public Function GuardarDatosPaciente(ByVal docidentidad As String, email As String, nombres As String, apellidos As String,
                               calle As String, numero As String, barrio As String, esquina As String, apartamento As String,
                               fechaNac As String, activo As String, telefonos As List(Of Integer), preExistentes As List(Of String),
                                    uid As String, pwd As String)
        'Guarda la informacion del paciente
        Try
            Dim p As New ModeloPaciente(uid, pwd)
            p.Documento = docidentidad
            p.Nombres = nombres
            p.Apellidos = apellidos
            p.Email = email
            p.Calle = calle
            p.Numero = numero
            p.Barrio = barrio
            p.Esquina = esquina
            p.Apartamento = apartamento
            p.FechaNacimiento = fechaNac
            p.Activo = activo
            p.Telefonos = telefonos
            p.ListaPreExistentes = preExistentes
            p.GuardarDatosPaciente()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function CrearUsuarioBD(ByVal docidentidad As String, uid As String, pwd As String)
        'Crea el usuario en la base de datos
        Try
            Dim p As New ModeloPaciente(uid, pwd)
            p.Documento = docidentidad
            p.RangoIpPaciente = ControladorConfiguracion.LeerRangoIpPacientes(uid, pwd)
            p.CrearUsuarioBD()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function eliminiarPacienteBD(ByVal docidentidad As String, uid As String, pwd As String)
        'Eliminia el usuario de la base de datos
        Try
            Dim p As New ModeloPaciente(uid, pwd)
            p.Documento = docidentidad
            p.RangoIpPaciente = ControladorConfiguracion.LeerRangoIpPacientes(uid, pwd)
            p.EliminarUsuarioBD(docidentidad)
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function CambiarEstadoPaciente(ByVal docIdentidad As String, estado As String, uid As String, pwd As String)
        'Elimina logicamente a un medico
        Dim p As New ModeloPaciente(uid, pwd)
        Return p.CambiarEstadoPaciente(docIdentidad, estado)
    End Function

    Public Function buscarPacientePorDocumento(ByVal docIdentidad As String, uid As String, pwd As String)
        'Busca medico por documento
        Dim p As New ModeloPaciente(uid, pwd)
        Return p.buscarPacientePorDocumento(docIdentidad)
    End Function

    Public Function crearTablaTelefonos()
        'Crea la tabla que alimenta el datagrid de telefonos
        Dim tablaTel As New DataTable
        tablaTel.Columns.Add("Telefono")
        Return tablaTel
    End Function

    Public Function crearTablaPreExistentes()
        'Crea la tabla que alimenta el datagrid de preExistentes
        Dim tablaPreExistentes As New DataTable
        tablaPreExistentes.Columns.Add("preExistentes")
        Return tablaPreExistentes
    End Function

    Public Function crearCadenaDeBusquedaPaciente(ByVal campoABuscar As String, datoABuscar As String)
        'Crea la cadena de consulta de acuerdo a los datos ingresados para ello
        Select Case campoABuscar
            Case "txtDocIdentidad" : Return "p.docidentidad=" & datoABuscar
            Case "txtNombres" : Return "p.nombres LIKE '%" & datoABuscar & "%'"
            Case "txtApellidos" : Return "p.apellidos LIKE '%" & datoABuscar & "%'"
        End Select
        Return ""
    End Function

    Public Function buscarPaciente(ByVal cadenaSql As String, uid As String, pwd As String)
        'Busca los medicos que coinciden con los criterios de busqueda
        Dim p As New ModeloPaciente(uid, pwd)
        Return p.BuscarPaciente(formatearSqlBuscquedaPaciente(cadenaSql))
    End Function

    Public Function formatearSqlBuscquedaPaciente(ByVal datoString As String)
        'Elimina el ultimo and de la consulta
        If datoString IsNot Nothing Then
            Return datoString.Remove(datoString.Length - 4, 4)
        End If
        Return "p.nombres like '%%'"
    End Function

    Public Function CargarEnfermedadesPreExistentes(ByVal docIdentidad As String, uid As String, pwd As String)
        'Devuele las enfermedades pre existentes que tiene el paciente
        Dim p As New ModeloPaciente(uid, pwd)
        p.Documento = docIdentidad
        Return p.CargarPreExistentes()
    End Function

    Public Function ListarPacientes(ByVal uid As String, pwd As String)
        'Lista todos los pacientes
        Dim p As New ModeloPaciente(uid, pwd)
        Return p.ListarPacientes
    End Function

    Public Function ListarPacientes(ByVal activo As String, uid As String, pwd As String)
        'Lista los pacientes por estado
        Dim p As New ModeloPaciente(uid, pwd)
        Return p.ListarPacientes(activo)
    End Function

    Public Function ListarTelefonos(ByVal docidentidad As String, uid As String, pwd As String)
        'Lista los telefonos de los pacientes
        Dim m As New ModeloMedico(uid, pwd)
        Return m.ListarTelefonos(docidentidad)
    End Function

End Module
