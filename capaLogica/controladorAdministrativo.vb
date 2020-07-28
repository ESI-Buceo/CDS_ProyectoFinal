Imports System.Data
Imports System.Windows.Forms
Imports capaDatos

Public Module controladorAdministrativo

    Public Function VarificarDocumentoDeIdentidad(ByVal docidentidad As String)
        Dim a As New ModeloAdministrativo
        Return a.VerificarDocumentoDeIdentidad(docidentidad)
    End Function

    Public Sub GuardarDatosAdmin(ByVal docId As String, email As String, nombres As String, apellidos As String, calle As String,
                                 numero As String, barrio As String, esquina As String, apartamento As String, fechaNac As String,
                                 activo As String, telefonos As DataGridView, numeroAdmin As String)
        'Guarda los datos del administrativo
        Dim a As New ModeloAdministrativo
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

    Private Sub guardarNuevoAdmin(ByVal a As ModeloAdministrativo)
        a.GuardarAdministrativo()
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

    Public Function buscarAdministrativo(ByVal cadenaSql As String)
        'Busca los administrativos que coinciden con los criterios de busqueda
        Dim m As New ModeloAdministrativo
        Return m.BuscarAdministativo(formatearSqlBuscquedaAdministrativo(cadenaSql))
    End Function

    Public Function BuscarAdministrativoPorDocumento(ByVal docidentidad As String)
        'Busca un administrativo por el numero de doc
        Dim a As New ModeloAdministrativo
        Return a.BuscarAdministrativoPorDocumento(docidentidad)
    End Function

    Private Function formatearSqlBuscquedaAdministrativo(ByVal datoString As String)
        'Elimina el ultimo and de la consulta
        If datoString IsNot Nothing Then
            Return datoString.Remove(datoString.Length - 4, 4)
        End If
        Return "p.nombres like '%%'"
    End Function

    Public Sub EliminiarAdmin(ByVal docIdentidad As String)
        Dim a As New ModeloAdministrativo
        a.eliminarAdministrativo(docIdentidad)
    End Sub
End Module
