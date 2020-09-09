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
        If ControladorValidaciones.ValidarFormatoDocumento(txtDocIdentidad.Text) And ControladorValidaciones.ValidarNombres(txtNombres.Text) _
            And ControladorValidaciones.ValidarApellidos(txtApellidos.Text) And ControladorValidaciones.ValidarEmail(txtEmail.Text) _
            And ControladorValidaciones.ValidarFechaNacimiento(dtpFechaNac.Value) Then
            validarSiEsNuevo()
        Else
            MsgBox(VFaltanDatosRequeridos, vbInformation, VAviso)
        End If
    End Sub

    Private Sub validarSiEsNuevo()
        'Verifica si el documento ingresado ya existe
        If agregar Then
            validarDocumentoDeIdentidad()
        Else
            guardarDatosDelPaciente()
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
            MsgBox(VErrorAlGuardar, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub guardadoConExito()
        'Mensaje de guardo con exito
        MsgBox(VDatosGuardadosConExito, vbInformation, VAviso)
        deshablitaDocumento()
        restaurarColorCampos()
        agregarUsuarioABD()
    End Sub

    Private Sub agregarUsuarioABD()
        'Agrega el usuario a la base de datos
        If agregar Then
            Try
                controladorPacientes.CrearUsuarioBD(txtDocIdentidad.Text, USUARIO, PASSWORD)
            Catch ex As Exception
                MsgBox(VErrorCrearUsuario, vbCritical, VAvisoError)
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
        respuesta = MsgBox(VseguroEliminiarRegistro, vbQuestion & vbYesNo, VseguroEliminiarRegistro)
        If respuesta = 6 Then
            borrarPaciente()
        End If
    End Sub

    Private Sub borrarPaciente()
        'Procesa baja de paciente
        Try
            controladorPacientes.CambiarEstadoPaciente(txtDocIdentidad.Text, 0, USUARIO, PASSWORD)
            ClickEnBotonBorrar(toolsMenuPaciente)
            MsgBox(VRegistroEliminado, vbInformation, VAviso)
            eliminarPacienteDeBD()
        Catch ex As Exception
            MsgBox(VErrorBorrarRegistro, vbCritical, VAviso)
        End Try
    End Sub

    Private Sub eliminarPacienteDeBD()
        'Elimina el usuario de la base de datos
        Try
            controladorPacientes.eliminiarPacienteBD(txtDocIdentidad.Text, USUARIO, PASSWORD)
            validarBotonBorrar(0)
        Catch ex As Exception
            MsgBox(VErrorBorrarUsuario, vbCritical, VAvisoError)
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
        rtbMensajes.Clear()
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
            MsgBox(VErrorRecuperarDatos, vbExclamation, VAviso)
        End Try
    End Sub

    Private Sub validarBotonBorrar(ByVal activo As String)
        'Activar y desactivar botones si ya esta eliminado
        If activo = 0 Then
            mnuBtnBorrar.Enabled = False
            mnuBtnModificar.Enabled = False
            mnuReactivar.Enabled = True
            mnuBtnCancelar.Enabled = False
            mnuBtnNueva.Enabled = True
            mnuBtnAgregar.Enabled = True
            chkActivo.Visible = True
        Else
            mnuBtnCancelar.Enabled = True
            mnuBtnModificar.Enabled = True
            mnuReactivar.Enabled = False
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
        cargarOtrosDatosDelPaciente(datosDelPaciente.Rows(0).Item("documento").ToString)
    End Sub

    Private Sub cargarOtrosDatosDelPaciente(ByVal documento As String)
        'Carga mas informacion del paciente
        cantidadDeDiagnosticosRecibidos(documento)
        cantidadDeChatsRealizados(documento)
        mostrarHistoriaDeChat(documento)
        listarDiagnosticosRecibidos(documento)
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
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
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
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
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
                MsgBox(VDocumentoExiste, vbInformation, VAviso)
                txtDocIdentidad.Select()
            Else
                guardarDatosDelPaciente()
            End If
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub cancelarProcesoDeIngreso()
        ClickEnBotonCancelar(toolsMenuPaciente)
        deshablitaDocumento()
        deshabilitarControlesDeEdicion()
        vaciarControles()
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

    Private Sub frmPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTextos()
    End Sub

    Private Sub cargarTextos()
        Me.Text = VPacientes.ToUpper
        mnuBtnAgregar.Text = VAgregar
        mnuBtnAgregar.ToolTipText = VToolBotonAgregar
        mnuBtnGuardar.Text = VGuardar
        mnuBtnGuardar.ToolTipText = VToolBotonGuardar
        mnuBtnCancelar.Text = VCancelar
        mnuBtnCancelar.ToolTipText = VToolBotonCancelar
        mnuBtnNueva.Text = VNueva
        mnuBtnNueva.ToolTipText = VToolBotonNueva
        mnuBtnBuscar.Text = VBuscar
        mnuBtnBuscar.ToolTipText = VToolBotonBuscar
        mnuBtnBorrar.Text = VBorrar
        mnuBtnBorrar.ToolTipText = VToolBotonBorrar
        mnuBtnModificar.Text = VModificar
        mnuBtnModificar.ToolTipText = VToolBotonModificar
        tabDatos.Text = VDato
        tabBusqueda.Text = VBusqueda
        tabHistoria.Text = VRegistrosHistoricos
        lblDocIdentidad.Text = VDocumento
        lblFechaReg.Text = VFecha
        lblFechaNacM.Text = VFechaNac
        lblNombres.Text = VNombres
        lblApellidosM.Text = VApellidos
        lblEmailM.Text = VEmail
        lblOtrosDatos.Text = VOtrosDatos.ToUpper
        lblDireccionM.Text = VDireccion
        lblNumeroCalleM.Text = VNum
        lblAptoM.Text = VApto
        lblEsquinaM.Text = VEsquina
        lblBarrioM.Text = VBarrio
        lblTelefonos.Text = VTelefonos
        dgvListaTelefonos.Columns(0).HeaderText = VTelefonos
        dgvListaPreExistentes.Columns(0).HeaderText = VPreExistentes
        chkActivo.Text = Vactivo
        lblTelefonos.Text = VTelefonos.ToUpper
        lblEnfermedades.Text = VEnfermedades.ToUpper
        dgvListaPacientes.Columns(0).HeaderText = VDocumento.ToUpper
        dgvListaPacientes.Columns(1).HeaderText = VNombres
        dgvListaPacientes.Columns(2).HeaderText = VApellidos
        dgvListaPacientes.Columns(3).HeaderText = VEmail
        dgvListaPacientes.Columns(4).HeaderText = VFecha
        gbEstadisticas.Text = VDatosEstadisticos
        lblDiagnosticos.Text = VDiagnosticos
        lblChats.Text = VChats
        lblDescCantDiag.Text = VCantidadDeDiagnosticosRecibos
        lblDetChatRealizados.Text = VCantidaChatRealizados
        gbHistoricoChats.Text = VHistoricoDeChats
        dgvHistoriaChat.Columns(0).HeaderText = VFecha
        dgvHistoriaChat.Columns(1).HeaderText = VSesion.ToUpper
        dgvHistoriaChat.Columns(2).HeaderText = VMedico.ToUpper
        gbListaDiagnosticos.Text = VDiagnosticoSGenerados
        gbVerChat.Text = VVerChat
        dgvHistoriaDiagnosticos.Columns(0).HeaderText = VDiagnosticos.ToUpper
        dgvHistoriaDiagnosticos.Columns(1).HeaderText = VFecha
        dgvHistoriaDiagnosticos.Columns(2).HeaderText = VPonderacion.ToUpper
    End Sub

    Private Sub cantidadDeDiagnosticosRecibidos(ByVal documento As String)
        'Muestra el numero de diagnosticos recidos por el paciente
        Try
            txtCantDiag.Text = ControladorDiagnostico.CantidadDeDiagnosticos(USUARIO, PASSWORD, documento)
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub cantidadDeChatsRealizados(ByVal documento As String)
        'Muestra el numero de chat que ha realizado el paciente
        Try
            txtCantChat.Text = ControladorChat.CantidadDeChats(USUARIO, PASSWORD, documento)
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub mostrarHistoriaDeChat(ByVal documento As String)
        'Muestra la lisa de chat 
        Try
            dgvHistoriaChat.DataSource = ControladorChat.ListaHistoricaChatPaciente(USUARIO, PASSWORD, documento)
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub dgvHistoriaChat_RowLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHistoriaChat.RowLeave
        'Muestra la conversacion de chat
        Try
            recorreMensajesRecibidos(ControladorChat.RecibirTodosMensajes(dgvHistoriaChat.Item(0, e.RowIndex).Value,
                                                                          USUARIO, PASSWORD), dgvHistoriaChat.Item(2, e.RowIndex).Value)
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub recorreMensajesRecibidos(ByVal tablaMensajes As DataTable, doctor As String)
        'recorre los mensajes recividos
        rtbMensajes.ResetText()
        For i = 0 To tablaMensajes.Rows.Count - 1
            identifiarColorearMensaje(tablaMensajes(i)("emisor"), tablaMensajes(i)("mensaje"), doctor)
        Next
    End Sub

    Private Sub identifiarColorearMensaje(ByVal emisor As String, mensaje As String, doctor As String)
        'Muestra y colorea los mensajes dependiente de origen y destino
        If emisor.Equals("P") Then
            rtbMensajes.SelectionColor = Color.FromArgb(110, 196, 167)
            rtbMensajes.AppendText(txtApellidos.Text & " ->  " & mensaje & vbNewLine)
        ElseIf emisor.Equals("M") Then
            rtbMensajes.SelectionColor = Color.FromArgb(69, 75, 84)
            rtbMensajes.AppendText("Dr. " & doctor & " -> " & mensaje & vbNewLine)
        End If
    End Sub

    Private Sub listarDiagnosticosRecibidos(ByVal documento As String)
        'Lista los diagnosticos que recibio el usuario
        Try
            dgvHistoriaDiagnosticos.DataSource = ControladorDiagnostico.TraerDiagnosticos(USUARIO, PASSWORD, documento)
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub mnuReactivar_Click(sender As Object, e As EventArgs) Handles mnuReactivar.Click
        confirmarReActivarCuenta()
    End Sub

    Private Sub confirmarReActivarCuenta()
        'Solicita confirmacion para reactivar
        Dim respuesta As Integer
        respuesta = MsgBox(VSeguroReactivarCuenta, vbQuestion & vbYesNo, VAvisoAlerta)
        If respuesta = 6 Then
            reactivarCuentaPaciente()
        End If
    End Sub

    Private Sub reactivarCuentaPaciente()
        'Ejecuta el proceso de reactivacio
        Try
            If controladorPacientes.CambiarEstadoPaciente(txtDocIdentidad.Text, 1, USUARIO, PASSWORD) Then
                crearUsuarioBD()
                MsgBox(VReactivacionCuentaExitosa, vbInformation, VAviso)
            End If
        Catch ex As Exception
            MsgBox(VErrorAlGuardar, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub crearUsuarioBD()
        'Crea el usuario en la base de datos
        Try
            controladorPacientes.CrearUsuarioBD(txtDocIdentidad.Text, USUARIO, PASSWORD)
            ClickEnBotonCancelar(toolsMenuPaciente)
        Catch ex As Exception
            MsgBox(VErrorCrearUsuario, vbCritical, VAvisoError)
        End Try
    End Sub
End Class