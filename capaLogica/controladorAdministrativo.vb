Imports System.Data
Imports System.Windows.Forms
Imports capaDatos

Public Module controladorAdministrativo

    Public Function VarificarDocumentoDeIdentidad(ByVal docidentidad As String, uid As String, pwd As String)
        Dim a As New ModeloAdministrativo(uid, pwd)
        Return a.VerificarDocumentoDeIdentidad(docidentidad)
    End Function

    Public Sub GuardarDatosAdmin(ByVal docId As String, email As String, nombres As String, apellidos As String, calle As String,
                                 numero As String, barrio As String, esquina As String, apartamento As String, fechaNac As String,
                                 activo As String, telefonos As DataGridView, numeroAdmin As String, uid As String, pwd As String)
        'Guarda los datos del administrativo
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
        a.Activo = activo
        a.Telefonos = cargarGridTelefonosADataTable(telefonos)
        a.GuardarAdministrativo()
    End Sub

    Public Sub CrearUsuarioBD(ByVal docidentidad As String, uid As String, pwd As String)
        Dim a As New ModeloAdministrativo(uid, pwd)
        a.Documento = docidentidad
        a.crearUsuarioBD()
    End Sub

    Private Function cargarGridTelefonosADataTable(ByVal telefonos As DataGridView) As DataTable
        'Carga la lista de telefonos
        Dim listaTelefonos As New DataTable
        listaTelefonos = TryCast(telefonos.DataSource, DataTable)
        Return listaTelefonos
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

    Private Function formatearSqlBuscquedaAdministrativo(ByVal datoString As String)
        'Elimina el ultimo and de la consulta
        If datoString IsNot Nothing Then
            Return datoString.Remove(datoString.Length - 4, 4)
        End If
        Return "p.nombres like '%%'"
    End Function

    Public Function EliminiarAdmin(ByVal docIdentidad As String, uid As String, pwd As String)
        Dim a As New ModeloAdministrativo(uid, pwd)
        Return a.EliminarAdministrativo(docIdentidad)
    End Function

    Public Function ValidarAdministrativo(ByVal uid As String, pwd As String) As DataTable
        Dim a As New ModeloAdministrativo(uid, pwd)
        Return a.ValidarAdministrativo(uid)
    End Function

    Public Sub eliminiarUsuarioBD(ByVal docidentidad As String, uid As String, pwd As String)
        Dim a As New ModeloAdministrativo(uid, pwd)
        a.EliminarUsuarioBD(docidentidad)
    End Sub

End Module