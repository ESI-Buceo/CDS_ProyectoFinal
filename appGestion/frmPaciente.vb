Imports capaLogica
Public Class frmPaciente

    Dim agregar As Boolean

    Private Sub mnuBtnAgregar_Click(sender As Object, e As EventArgs) Handles mnuBtnAgregar.Click
        'Habilita el ingreso de un nuevo paciente
        opcionesMenu.ClickEnBotonAgregar(toolsMenuPaciente)
        agregar = True
        habilitarDocumento()
        colorearDocumento()
        vaciarControles()
        controlAgregarActivo()
        habilitarControlesDeEdicion()
        cargarFechaDeHoy()
    End Sub

    Private Sub controlAgregarActivo()
        agregar = True
        chkActivo.Visible = False
    End Sub

    Private Sub colorearDocumento()
        'Colorea el textbox de documento para un nuevo ingreso
        txtDocIdentidad.BackColor = Color.FromArgb(234, 222, 164)
    End Sub

    Private Sub habilitarDocumento()
        'habilita el textbox de documento para un nuevo ingreso
        txtDocIdentidad.Enabled = True
        txtDocIdentidad.Select()
    End Sub

    Private Sub deshablitaDocumento()
        'Deshabilita el textbox de documento
        txtDocIdentidad.Enabled = False
    End Sub

    Private Sub crearTablaTelefonoParaDataGrid()
        'Crea un datatable para el datagrid de telefonos
        dgvListaTelefonos.DataSource = controladorPacientes.crearTablaTelefonos()
    End Sub

    Private Sub crearTablaPreExistentesParaDataGrid()
        'Crea un datatable para el datagrid de telefonos
        dgvListaPreExistentes.DataSource = controladorPacientes.crearTablaPreExistentes()
    End Sub

    Private Sub habilitarControlesDeEdicion()
        'Habilita la lista de telefonos
        dgvListaTelefonos.ReadOnly = False
        dgvListaPreExistentes.ReadOnly = False
        btnAgregarTelefono.Enabled = True
        btnAgregarEnfermedad.Enabled = True
        btnEliminarTelefono.Enabled = True
        btnEliminarEnfermedad.Enabled = True
        colorearCamposRequeridos()
    End Sub

    Private Sub deshabilitarControlesDeEdicion()
        'Habilita la lista de telefonos
        dgvListaTelefonos.ReadOnly = True
        dgvListaPreExistentes.ReadOnly = True
        btnAgregarTelefono.Enabled = False
        btnAgregarEnfermedad.Enabled = False
        btnEliminarTelefono.Enabled = False
        chkActivo.Visible = False
        agregar = False
        btnEliminarEnfermedad.Enabled = False
        restaurarColorCampos()
    End Sub

    Private Sub mnuBtnGuardar_Click(sender As Object, e As EventArgs) Handles mnuBtnGuardar.Click
        'valida antes de ingresar la informacion del paciente
        If ControladorValidaciones.validarFormatoDocumento(txtDocIdentidad.Text) And ControladorValidaciones.validarNombres(txtNombres.Text) _
            And ControladorValidaciones.validarApellidos(txtApellidos.Text) And ControladorValidaciones.ValidarEmail(txtEmail.Text) _
            And ControladorValidaciones.ValidarFechaNacimiento(dtpFechaNac.Value) Then
            guardarDatosDelPaciente()
        Else
            MsgBox("Faltan datos requeridos o hay datos incorrectos, verifica.", vbInformation, "Aviso")
        End If
    End Sub

    Private Sub guardarDatosDelPaciente()
        'Guarda los  datos del paciente
        Try
            controladorPacientes.GuardarDatosPaciente(txtDocIdentidad.Text, txtEmail.Text, txtNombres.Text, txtApellidos.Text,
                               txtCalle.Text, txtNumeroCalle.Text, txtBarrio.Text, txtEsquina.Text, txtApto.Text,
                               Format(dtpFechaNac.Value, "yyyy-MM-dd"), chkActivo.CheckState, dgvListaTelefonos, dgvListaPreExistentes, USUARIO, PASSWORD)
            opcionesMenu.ClickEnBotonGuardar(toolsMenuPaciente)
            guardadoConExito()
            deshabilitarControlesDeEdicion()
        Catch ex As Exception
            MsgBox("Error al guardar los datos del paciente")
        End Try
    End Sub

    Private Sub guardadoConExito()
        'Mensaje de guardo con exito
        MsgBox("Datos guardado con exito", vbInformation, "Aviso")
        deshablitaDocumento()
        restaurarColorCampos()
        agregarUsuarioABD()
    End Sub

    Private Sub agregarUsuarioABD()
        'Agrega el usuario a la base de datos
        If agregar Then
            Try
                controladorPacientes.crearUsuarioBD(txtDocIdentidad.Text, USUARIO, PASSWORD)
            Catch ex As Exception
                MsgBox("Error al crear el usuario en la base de datos", vbCritical, "ERROR")
            End Try
        End If
    End Sub

    Private Sub deshabilitarListaTelefonos()
        'Deshabilita la lista de telefonos
        dgvListaTelefonos.Enabled = False
    End Sub

    Private Sub mnuBtnCancelar_Click(sender As Object, e As EventArgs) Handles mnuBtnCancelar.Click
        'Cancela la operacion
        opcionesMenu.ClickEnBotonCancelar(toolsMenuPaciente)
        deshablitaDocumento()
        deshabilitarControlesDeEdicion()
        tabOpcionesPaciente.SelectTab(tabDatos)
        desactivarCheckActivo()
    End Sub

    Private Sub mnuBtnNueva_Click(sender As Object, e As EventArgs) Handles mnuBtnNueva.Click
        'Habilita para una nueva busqueda
        opcionesMenu.ClickEnBotonNueva(toolsMenuPaciente)
        agregar = False
        crearTablaTelefonoParaDataGrid()
        crearTablaPreExistentesParaDataGrid()
        vaciarControles()
        habilitarDocumento()
        txtDocIdentidad.Select()
        marcarCamposParaBusqueda()
    End Sub

    Private Sub marcarCamposParaBusqueda()
        txtDocIdentidad.BackColor = Color.FromArgb(247, 241, 210)
        txtNombres.BackColor = Color.FromArgb(247, 241, 210)
        txtApellidos.BackColor = Color.FromArgb(247, 241, 210)
    End Sub

    Private Sub mnuBtnBuscar_Click(sender As Object, e As EventArgs) Handles mnuBtnBuscar.Click
        'Dispara una nueva busqueda
        opcionesMenu.ClickEnBotonBuscar(toolsMenuPaciente)
        tabOpcionesPaciente.SelectTab(tabBusqueda)
        formarCadenaDeBusqueda()
    End Sub

    Private Sub mnuBtnBorrar_Click(sender As Object, e As EventArgs) Handles mnuBtnBorrar.Click
        'Borra el registro del paciente en pantalla
        Dim respuesta As Integer
        respuesta = MsgBox("Seguro de eliminar el Paciente?", vbQuestion & vbYesNo, "Confirmar eliminacion")
        If respuesta = 6 Then
            borrarPaciente()
        End If
    End Sub

    Private Sub borrarPaciente()
        'Procesa baja de paciente
        Try
            controladorPacientes.EliminiarPaciente(txtDocIdentidad.Text, USUARIO, PASSWORD)
            ClickEnBotonBorrar(toolsMenuPaciente)
            MsgBox("Paciente eliminado con exito !", vbInformation, "Aviso")
            eliminarPacienteDeBD()
        Catch ex As Exception
            MsgBox("Error al eliminar el paciente", vbCritical, "Aviso")
        End Try
    End Sub

    Private Sub eliminarPacienteDeBD()
        'Elimina el usuario de la base de datos
        Try
            controladorPacientes.eliminiarPacienteBD(txtDocIdentidad.Text, USUARIO, PASSWORD)
        Catch ex As Exception
            MsgBox("No se puedo eliminiar el usuario de la base de datos", vbCritical, "ERROR")
        End Try
    End Sub

    Private Sub mnuBtnModificar_Click(sender As Object, e As EventArgs) Handles mnuBtnModificar.Click
        'Habilita la modificacion del paciente en pantalla
        opcionesMenu.ClickEnBotonModificar(toolsMenuPaciente)
        habilitarControlesDeEdicion()
        deshablitaDocumento()
        agregar = False
        activarCheckActivo()
    End Sub

    Private Sub activarCheckActivo()
        chkActivo.Enabled = True
    End Sub

    Private Sub desactivarCheckActivo()
        chkActivo.Enabled = False
    End Sub

    Private Sub colorearCamposRequeridos()
        'Colorea los campos requeridos con amarillo
        txtNombres.BackColor = Color.FromArgb(247, 241, 210)
        txtApellidos.BackColor = Color.FromArgb(247, 241, 210)
        txtEmail.BackColor = Color.FromArgb(247, 241, 210)
        dtpFechaNac.CalendarTitleBackColor = Color.FromArgb(247, 241, 210)
    End Sub

    Private Sub restaurarColorCampos()
        'Recorre y colorea todos los textbox del tabDatos
        For Each controles As Control In Me.tabDatos.Controls
            If TypeOf controles Is TextBox Then
                controles.BackColor = Color.White
            End If
        Next
    End Sub

    Private Sub cargarFechaDeHoy()
        'Carga la fecha del dia de hoy
        txtFechaRegistro.Text = Format(CDate(Now), "dd/MM/yyyy")
    End Sub

    Private Sub vaciarControles()
        'Recorre y vacia todos los textbox del tabDatos
        For Each controles As Control In Me.tabDatos.Controls
            If TypeOf controles Is TextBox Then
                controles.Text = Nothing
            End If
        Next
        crearTablaTelefonoParaDataGrid()
        crearTablaPreExistentesParaDataGrid()
    End Sub

    Private Sub dgvListaPacientes_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListaPacientes.RowHeaderMouseClick
        'Evento al hacer clic en la lista de medicos que muestra los datos del mismo
        ClickEnListado(toolsMenuPaciente)
        Try
            mostrarDatosDelPaciente(controladorPacientes.buscarPacientePorDocumento(dgvListaPacientes.Item(0, e.RowIndex).Value, USUARIO, PASSWORD))
            restaurarColorCampos()
            tabOpcionesPaciente.SelectTab(tabDatos)
            deshablitaDocumento()
            validarBotonBorrar(dgvListaPacientes.Item(5, e.RowIndex).Value)
            habilitarListaSoloVisualizar(dgvListaTelefonos)
            habilitarListaSoloVisualizar(dgvListaPreExistentes)
            txtNombres.Select()
        Catch ex As Exception
            MsgBox("Error al cargar los datos del usuario", vbExclamation, "Aviso")
        End Try
    End Sub

    Private Sub validarBotonBorrar(ByVal activo As String)
        'Si ya esta eliminado el boton queda deshabilitado
        If activo = 0 Then
            mnuBtnBorrar.Enabled = False
            chkActivo.Visible = True
        Else
            chkActivo.Visible = False
        End If
    End Sub

    Private Sub mostrarDatosDelPaciente(ByVal datosDelPaciente As DataTable)
        'Carga todos los datos del medico elegido
        txtDocIdentidad.Text = datosDelPaciente.Rows(0).Item("documento").ToString
        txtFechaRegistro.Text = Format(datosDelPaciente.Rows(0).Item("fechReg"), "dd/MM/yyyy").ToString
        dtpFechaNac.Value = Format(datosDelPaciente.Rows(0).Item("fechaNac"), "dd/MM/yyyy").ToString
        txtNombres.Text = datosDelPaciente.Rows(0).Item("nombres").ToString
        txtApellidos.Text = datosDelPaciente.Rows(0).Item("apellidos").ToString
        txtEmail.Text = datosDelPaciente.Rows(0).Item("mail").ToString
        txtCalle.Text = datosDelPaciente.Rows(0).Item("calle").ToString
        txtNumeroCalle.Text = datosDelPaciente(0).Item("numero").ToString
        txtApto.Text = datosDelPaciente.Rows(0).Item("apto").ToString
        txtEsquina.Text = datosDelPaciente.Rows(0).Item("esquina").ToString
        txtBarrio.Text = datosDelPaciente.Rows(0).Item("barrio").ToString
        chkActivo.CheckState = datosDelPaciente.Rows(0).Item("activo").ToString
        crearTablaTelefonos(datosDelPaciente)
        crearTablaPreExistentes(txtDocIdentidad.Text)
    End Sub

    Private Sub crearTablaTelefonos(ByVal telefonos As DataTable)
        'Crea el datatabla que cargara los telefonos
        cargarGridTelefonos(controladorPacientes.crearTablaTelefonos(), telefonos)
    End Sub

    Private Sub cargarGridTelefonos(ByVal tablaTelefono As DataTable, telefonos As DataTable)
        'Carga la tabla con los telefonos registrados
        For t = 0 To telefonos.Rows.Count - 1
            Dim rowTel As DataRow = tablaTelefono.NewRow()
            rowTel("Telefono") = telefonos(t).Item("telefono").ToString
            tablaTelefono.Rows.Add(rowTel)
        Next
        mostrarTelefonosEnDataGrid(tablaTelefono)
    End Sub

    Private Sub mostrarTelefonosEnDataGrid(ByVal tablaTelefono As DataTable)
        'Carga el datagrid con los telefonos
        dgvListaTelefonos.DataSource = tablaTelefono
    End Sub

    Private Sub crearTablaPreExistentes(ByVal docidentidad As String)
        'Crea el datatabla que cargara las enfermedades pre existentes
        Try
            cargarGridPreExistentes(controladorPacientes.crearTablaPreExistentes(), controladorPacientes.CargarEnfermedadesPreExistentes(docidentidad, USUARIO, PASSWORD))
        Catch ex As Exception
            MsgBox("Error al cargar enfermedades pre existentes", vbCritical, "Error")
        End Try
    End Sub

    Private Sub cargarGridPreExistentes(ByVal tablaPreExistentes As DataTable, preExistentes As DataTable)
        'Carga en el dataGrid de preExistentes las enfermades registradas
        For t = 0 To preExistentes.Rows.Count - 1
            Dim rowPreExistentes As DataRow = tablaPreExistentes.NewRow()
            rowPreExistentes("preExistentes") = preExistentes(t).Item("PREEXISTENTE").ToString
            tablaPreExistentes.Rows.Add(rowPreExistentes)
        Next
        dgvListaPreExistentes.DataSource = tablaPreExistentes
    End Sub

    Private Sub mostrarEnfermedadesPreExistentesEnDataGrid(ByVal tablaPreExistentes As DataTable)
        'Carga el datagrid con las enfermedades pre existentes
        dgvListaPreExistentes.DataSource = tablaPreExistentes
    End Sub

    Private Sub btnAgregarTelefono_Click(sender As Object, e As EventArgs) Handles btnAgregarTelefono.Click
        'Habilita el ingreso de un nuevo telefono en el grid
        dgvListaTelefonos.AllowUserToAddRows = True

    End Sub

    Private Sub btnAgregarEnfermedad_Click(sender As Object, e As EventArgs) Handles btnAgregarEnfermedad.Click
        'Habilita el ingreso de un nuevo telefono en el grid
        dgvListaPreExistentes.AllowUserToAddRows = True
    End Sub

    Private Sub dgvListaTelefonos_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaTelefonos.CellValueChanged
        'Actualza el grid una vez ingresado un nuevo telefono
        dgvListaTelefonos.AllowUserToAddRows = False
    End Sub

    Private Sub btnEliminarTelefono_Click(sender As Object, e As EventArgs) Handles btnEliminarTelefono.Click
        'Eliminia el telefono seleccionado de la lista
        dgvListaTelefonos.Rows.Remove(dgvListaTelefonos.CurrentRow)
    End Sub

    Private Sub formarCadenaDeBusqueda()
        'Recorre y verifica los datos ingresados para la busqueda
        Dim stringDeBusqueda As String
        For Each controles As Control In Me.tabDatos.Controls
            If TypeOf controles Is TextBox And controles.Text <> Nothing Then
                stringDeBusqueda += crearCadenaDeBusquedaPaciente(controles.Name, controles.Text) & " AND "
            End If
        Next
        lanzarBusquedaDePaciente(stringDeBusqueda)
    End Sub

    Private Sub lanzarBusquedaDePaciente(ByVal stringDeBusqueda As String)
        'Lanza la busqueda del paciente por los campos ingresados
        Try
            dgvListaPacientes.DataSource = controladorPacientes.buscarPaciente(stringDeBusqueda, USUARIO, PASSWORD)
            colorearEliminados(dgvListaPacientes)
            crearTablaTelefonoParaDataGrid()
        Catch ex As Exception
            MsgBox("Error al buscar un paciente", vbCritical, "Error")
        End Try
    End Sub

    Public Sub colorearEliminados(ByRef lista As DataGridView)
        For i = 0 To lista.Rows.Count - 1
            If lista.Rows.Item(i).Cells("colActivo").Value.ToString = 0 Then
                lista.Rows(i).DefaultCellStyle.BackColor = Color.Red
                lista.Rows(i).DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub validarDocumentoDeIdentidad()
        'Valida que el documento ingresado no exista
        Try
            If controladorPacientes.VarificarDocumentoDeIdentidad(txtDocIdentidad.Text, USUARIO, PASSWORD) IsNot Nothing Then
                MsgBox("El documento ingresado ya existe. No se puede continuar", vbInformation, "AVISO")
                cancelarProcesoDeIngreso()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cancelarProcesoDeIngreso()
        ClickEnBotonCancelar(toolsMenuPaciente)
        deshablitaDocumento()
        deshabilitarControlesDeEdicion()
        vaciarControles()
    End Sub

    Private Sub txtDocIdentidad_LostFocus(sender As Object, e As EventArgs) Handles txtDocIdentidad.LostFocus
        If agregar Then validarDocumentoDeIdentidad()
    End Sub

    Private Sub btnEliminarEnfermedad_Click(sender As Object, e As EventArgs) Handles btnEliminarEnfermedad.Click
        dgvListaPreExistentes.Rows.Remove(dgvListaPreExistentes.CurrentRow)
    End Sub

    Private Sub habilitarListaSoloVisualizar(ByVal dgv As DataGridView)
        dgv.ReadOnly = True
    End Sub

    Private Sub dgvListaPreExistentes_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaPreExistentes.CellValueChanged
        'Actualza el grid una vez ingresado un nuevo telefono
        dgvListaPreExistentes.AllowUserToAddRows = False
    End Sub
End Class