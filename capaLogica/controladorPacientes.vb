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

    Public Sub GuardarDatosPaciente(ByVal docidentidad As String, email As String, nombres As String, apellidos As String,
                               calle As String, numero As String, barrio As String, esquina As String, apartamento As String,
                               fechaNac As String, activo As String, Telefonos As DataGridView, PreExistentes As DataGridView,
                                    uid As String, pwd As String)
        'Guarda la informacion del paciente
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
        p.Telefonos = cargarGridTelefonosADataTable(Telefonos)
        p.TablaPreExistente = cargarGridPreExistentesADataTable(PreExistentes)
        p.GuardarDatosPaciente()
    End Sub

    Public Sub CrearUsuarioBD(ByVal docidentidad As String, uid As String, pwd As String)
        'Crea el usuario en la base de datos
        Dim p As New ModeloPaciente(uid, pwd)
        p.Documento = docidentidad
        p.CrearUsuarioBD()
    End Sub

    Private Function cargarGridTelefonosADataTable(ByVal telefonos As DataGridView) As DataTable
        'Carga la lista de telefonos
        Dim TablaTelefonos As New DataTable
        TablaTelefonos = TryCast(telefonos.DataSource, DataTable)
        Return TablaTelefonos
    End Function

    Public Sub eliminiarPacienteBD(ByVal docidentidad As String, uid As String, pwd As String)
        'Eliminia el usuario de la base de datos
        Dim p As New ModeloPaciente(uid, pwd)
        p.EliminarUsuarioBD(docidentidad)
    End Sub

    Private Function cargarGridPreExistentesADataTable(ByVal preexistentes As DataGridView) As DataTable
        'Carga la lista de telefonos
        Dim TablaPreExistentes As New DataTable
        TablaPreExistentes = TryCast(preexistentes.DataSource, DataTable)
        Return TablaPreExistentes
    End Function

    Public Sub EliminiarPaciente(ByVal docIdentidad As String, uid As String, pwd As String)
        'Elimina logicamente a un medico
        Dim p As New ModeloPaciente(uid, pwd)
        p.EliminarPaciente(docIdentidad)
    End Sub

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

    Private Function formatearSqlBuscquedaPaciente(ByVal datoString As String)
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
