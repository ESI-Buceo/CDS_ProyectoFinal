Imports capaLogica

Public Class frmAdministrativo
    Dim agregar As Boolean

    Private Sub mnuBtnAgregar_Click(sender As Object, e As EventArgs) Handles mnuBtnAgregar.Click
        ClickEnBotonAgregar(toolsMenuAdmin)
        tabOpcionAdmin.SelectTab(tabDatos)
        agregar = True
        habilitarDocumento()
        colorearDocumento()
        vaciarControles()
        habilitarControlesDeEdicion()
        cargarFechaDeHoy()
    End Sub

    Private Sub controlAgregarActivo()
        agregar = True
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
        dgvListaTelefonos.DataSource = controladorAdministrativo.crearTablaTelefonos()
    End Sub

    Private Sub habilitarControlesDeEdicion()
        'Habilita la lista de telefonos
        dgvListaTelefonos.Enabled = True
        btnAgregarTelefono.Enabled = True
        btnEliminarTelefono.Enabled = True
        colorearCamposRequeridos()
    End Sub

    Private Sub deshabilitarControlesDeEdicion()
        'Habilita la lista de telefonos
        dgvListaTelefonos.Enabled = False
        btnAgregarTelefono.Enabled = False
        btnEliminarTelefono.Enabled = False

        agregar = False
        restaurarColorCampos()
    End Sub

    Private Sub mnuBtnGuardar_Click(sender As Object, e As EventArgs) Handles mnuBtnGuardar.Click
        'valida antesde ingresar la informacion del administrativo
        If ControladorValidaciones.validarFormatoDocumento(txtDocIdentidad.Text) And ControladorValidaciones.validarNombres(txtNombres.Text) _
            And ControladorValidaciones.validarApellidos(txtApellidos.Text) And ControladorValidaciones.ValidarEmail(txtEmail.Text) _
            And ControladorValidaciones.ValidarFechaNacimiento(dtpFechaNac.Value) And ControladorValidaciones.validarNumeroEmpleado(txtNumAdmin.Text) Then
            validarSiEsNuevo()
        Else
            MsgBox(VFaltanDatosRequeridos, vbInformation, VAviso)
        End If
    End Sub

    Private Sub validarSiEsNuevo()
        'Si es nuevo verifica que el documento no este registrado
        If agregar Then
            validarDocumentoDeIdentidad()
        Else
            guardarDatosAdministrativo()
        End If
    End Sub

    Private Sub guardarDatosAdministrativo()
        'guarda la informacion del administrativo
        Try
            If controladorAdministrativo.GuardarDatosAdmin(txtDocIdentidad.Text, txtEmail.Text, txtNombres.Text, txtApellidos.Text,
                               txtCalle.Text, txtNumeroCalle.Text, txtBarrio.Text, txtEsquina.Text, txtApto.Text,
                               Format(dtpFechaNac.Value, "yyyy-MM-dd"), listaDeTelefonos, txtNumAdmin.Text, USUARIO, PASSWORD) Then
                opcionesMenu.ClickEnBotonGuardar(toolsMenuAdmin)
                guardadoConExito()
                deshabilitarControlesDeEdicion()
            Else
                MsgBox(VErrorAlGuardar, vbCritical, VAvisoError)
            End If
        Catch ex As Exception
            MsgBox(VErrorAlGuardar, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Function listaDeTelefonos()
        'Recorre el array para entregar una lista de telefonos
        Dim telefonos As New List(Of String)
        For t = 0 To dgvListaTelefonos.Rows.Count - 1
            telefonos.Add(dgvListaTelefonos.Item(0, t).Value)
        Next
        Return telefonos
    End Function

    Private Sub guardadoConExito()
        'Mensaje de guardo con exito
        MsgBox(VDatosGuardadosConExito, vbInformation, VAviso)
        deshablitaDocumento()
        restaurarColorCampos()
    End Sub

    Private Sub deshabilitarListaTelefonos()
        'Deshabilita la lista de telefonos
        dgvListaTelefonos.Enabled = False
    End Sub

    Private Sub mnuBtnCancelar_Click(sender As Object, e As EventArgs) Handles mnuBtnCancelar.Click
        'Cancela los procesos activos
        opcionesMenu.ClickEnBotonCancelar(toolsMenuAdmin)
        deshablitaDocumento()
        deshabilitarControlesDeEdicion()
        desactivarPassword()
        tabOpcionAdmin.SelectTab(tabDatos)
    End Sub

    Private Sub mnuBtnNueva_Click(sender As Object, e As EventArgs) Handles mnuBtnNueva.Click
        'Habilita para una nueva busqueda
        opcionesMenu.ClickEnBotonNueva(toolsMenuAdmin)
        agregar = False
        crearTablaTelefonoParaDataGrid()
        vaciarControles()
        habilitarDocumento()
        txtDocIdentidad.Select()
        marcarCamposParaBusqueda()
    End Sub

    Private Sub marcarCamposParaBusqueda()
        'Marca los campos por los que se puede buscar
        txtDocIdentidad.BackColor = Color.FromArgb(247, 241, 210)
        txtNumAdmin.BackColor = Color.FromArgb(247, 241, 210)
        txtNombres.BackColor = Color.FromArgb(247, 241, 210)
        txtApellidos.BackColor = Color.FromArgb(247, 241, 210)
    End Sub

    Private Sub mnuBtnBuscar_Click(sender As Object, e As EventArgs) Handles mnuBtnBuscar.Click
        'Buscar un administrativo de acuerdo a los datos ingresados 
        opcionesMenu.ClickEnBotonBuscar(toolsMenuAdmin)
        tabOpcionAdmin.SelectTab(tabBusqueda)
        formarCadenaDeBusqueda()
    End Sub

    Private Sub mnuBtnBorrar_Click(sender As Object, e As EventArgs) Handles mnuBtnBorrar.Click
        'Dispara el proceso de eliminacion logica
        Dim respuesta As Integer
        respuesta = MsgBox(VseguroEliminiarRegistro, vbQuestion & vbYesNo, VAvisoAlerta)
        If respuesta = 6 Then
            borrarAdministrativo()
        End If
    End Sub

    Private Sub borrarAdministrativo()
        'Procesa baja de administrativo
        Try
            If controladorAdministrativo.cambiarEstadoAdmin(txtDocIdentidad.Text, 0, USUARIO, PASSWORD) Then
                opcionesMenu.ClickEnBotonBorrar(toolsMenuAdmin)
                MsgBox(VRegistroEliminado, vbInformation, VAviso)
                eliminarAdmnistrativoBD()
            End If
        Catch ex As Exception
            MsgBox(VErrorBorrarRegistro, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub eliminarAdmnistrativoBD()
        'Elimina el usuario de la base de datos
        Try
            controladorAdministrativo.eliminiarUsuarioBD(txtDocIdentidad.Text, USUARIO, PASSWORD)
        Catch ex As Exception
            MsgBox(VErrorBorrarRegistro, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub mnuBtnModificar_Click(sender As Object, e As EventArgs) Handles mnuBtnModificar.Click
        'Habilita la modificacion del administrativo en pantalla
        opcionesMenu.ClickEnBotonModificar(toolsMenuAdmin)
        habilitarControlesDeEdicion()
        deshablitaDocumento()
        agregar = False
    End Sub

    Private Sub colorearCamposRequeridos()
        'Colorea los campos requeridos con amarillo
        txtNombres.BackColor = Color.FromArgb(247, 241, 210)
        txtApellidos.BackColor = Color.FromArgb(247, 241, 210)
        txtEmail.BackColor = Color.FromArgb(247, 241, 210)
        dtpFechaNac.CalendarTitleBackColor = Color.FromArgb(247, 241, 210)
        txtNumAdmin.BackColor = Color.FromArgb(247, 241, 210)
    End Sub

    Private Sub restaurarColorCampos()
        'Recorre y colorea todos los textbox del tabDatos
        For Each controles As Control In Me.tabDatos.Controls
            If TypeOf controles Is TextBox Then
                controles.BackColor = Color.White
            End If
        Next
    End Sub

    Private Sub vaciarControles()
        'Recorre y vacia todos los textbos del tabDatos
        For Each controles As Control In Me.tabDatos.Controls
            If TypeOf controles Is TextBox Then
                controles.Text = Nothing
            End If
        Next
        dtpFechaNac.Value = "01/01/1900"
        crearTablaTelefonoParaDataGrid()
    End Sub

    Private Sub cargarFechaDeHoy()
        'Carga la fecha del dia de hoy
        txtFechaRegistro.Text = Format(CDate(Now), "dd/MM/yyyy")
    End Sub

    Private Sub dgvListaAdministrador_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListaAdministrador.RowHeaderMouseClick
        'Evento al hacer clic en la lista de administrativos que muestra los datos del mismo
        ClickEnListado(toolsMenuAdmin)
        Try
            mostrarDatosDelAdmin(controladorAdministrativo.BuscarAdministrativoPorDocumento(dgvListaAdministrador.Item(0, e.RowIndex).Value, USUARIO, PASSWORD))
            restaurarColorCampos()
            tabOpcionAdmin.SelectTab(tabDatos)
            deshablitaDocumento()
            validarBotonBorrar(dgvListaAdministrador.Item(6, e.RowIndex).Value)
            txtNombres.Select()
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbExclamation, VAviso)
        End Try
    End Sub

    Private Sub validarBotonBorrar(ByVal activo As String)
        'Si ya esta eliminado el boton queda deshabilitado
        If activo = 0 Then
            mnuBtnBorrar.Enabled = False
            mnuBtnModificar.Enabled = False
            mnuBtnReactivar.Enabled = True
            mnuBtnCancelar.Enabled = False
            mnuBtnNueva.Enabled = True
            mnuBtnAgregar.Enabled = True
            desactivarPassword()
        Else
            mnuBtnCancelar.Enabled = True
            mnuBtnModificar.Enabled = True
            mnuBtnReactivar.Enabled = False
            activarBotonPassword()
        End If
    End Sub

    Private Sub mostrarDatosDelAdmin(ByVal datosAdministrativo As DataTable)
        'Carga todos los datos del administrativo elegido
        txtDocIdentidad.Text = datosAdministrativo.Rows(0).Item("documento").ToString
        txtFechaRegistro.Text = Format(datosAdministrativo.Rows(0).Item("fechReg"), "dd/MM/yyyy").ToString
        txtNumAdmin.Text = datosAdministrativo.Rows(0).Item("ndeempleado").ToString
        dtpFechaNac.Value = Format(datosAdministrativo.Rows(0).Item("fechaNac"), "dd/MM/yyyy").ToString
        txtNombres.Text = datosAdministrativo.Rows(0).Item("nombres").ToString
        txtApellidos.Text = datosAdministrativo.Rows(0).Item("apellidos").ToString
        txtEmail.Text = datosAdministrativo.Rows(0).Item("mail").ToString
        txtCalle.Text = datosAdministrativo.Rows(0).Item("calle").ToString
        txtNumeroCalle.Text = datosAdministrativo(0).Item("numero").ToString
        txtApto.Text = datosAdministrativo.Rows(0).Item("apto").ToString
        txtEsquina.Text = datosAdministrativo.Rows(0).Item("esquina").ToString
        txtBarrio.Text = datosAdministrativo.Rows(0).Item("barrio").ToString
        cargarTelefonos(datosAdministrativo)
    End Sub

    Private Sub cargarTelefonos(ByVal telefonos As DataTable)
        'Carga los telefonos del administrativo elegido
        cargarGridTelefonos(controladorAdministrativo.crearTablaTelefonos(), telefonos)
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

    Private Sub btnAgregarTelefono_Click(sender As Object, e As EventArgs) Handles btnAgregarTelefono.Click
        'Habilita el ingreso de un nuevo telefono en el grid
        dgvListaTelefonos.AllowUserToAddRows = True
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
                stringDeBusqueda += crearCadenaDeBusquedaAdministrativo(controles.Name, controles.Text) & " AND "
            End If
        Next
        lanzarBusquedaAdministrativo(stringDeBusqueda)
    End Sub

    Private Sub lanzarBusquedaAdministrativo(ByVal stringDeBusqueda As String)
        'Muestra el resultado del proceso de busqueda
        Try
            dgvListaAdministrador.DataSource = controladorAdministrativo.buscarAdministrativo(stringDeBusqueda, USUARIO, PASSWORD)
            colorearEliminados(dgvListaAdministrador)
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
        'Valida que el documento de identida no exista
        Try
            If controladorAdministrativo.VarificarDocumentoDeIdentidad(txtDocIdentidad.Text, USUARIO, PASSWORD) IsNot Nothing Then
                MsgBox(VDocumentoExiste, vbInformation, VAviso)
                txtDocIdentidad.Select()
            Else
                guardarDatosAdministrativo()
            End If
        Catch ex As Exception
            MsgBox(VErrorVerificarDocumento, vbCritical, VAvisoError)
            cancelarProcesoDeIngreso()
        End Try
    End Sub

    Private Sub cancelarProcesoDeIngreso()
        ClickEnBotonCancelar(toolsMenuAdmin)
        deshablitaDocumento()
        deshabilitarControlesDeEdicion()
        vaciarControles()
    End Sub

    Private Sub frmAdministrativo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTexto()
    End Sub

    Private Sub mnuBtnReactivar_Click(sender As Object, e As EventArgs) Handles mnuBtnReactivar.Click
        ClickEnBotonReactivar(toolsMenuAdmin)
        confirmarReActivacionAdmin()
    End Sub

    Private Sub confirmarReActivacionAdmin()
        'Solicita confirmacion para reactivar el registro
        Dim respuesta As Integer
        respuesta = MsgBox(VSeguroReactivarCuenta, vbQuestion & vbYesNo, VAvisoAlerta)
        If respuesta = 6 Then
            reactivarCuentaAdmin()
        End If
    End Sub

    Private Sub reactivarCuentaAdmin()
        'Ejecuta el proceso de reactivacion del medico
        Try
            If controladorAdministrativo.CambiarEstadoAdmin(txtDocIdentidad.Text, 1, USUARIO, PASSWORD) Then
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
            EnviarEmail(txtDocIdentidad.Text, controladorAdministrativo.CrearUsuarioBD(txtDocIdentidad.Text, USUARIO, PASSWORD), txtEmail.Text, VAsuntoAltaCuenta, VBuenasNoticias, VTuCuentaActivada)
            ClickEnBotonCancelar(toolsMenuAdmin)
        Catch ex As Exception
            MsgBox(VErrorCrearUsuario, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub cargarTexto()
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
        mnuBtnReactivar.Text = VActivar
        mnuBtnReactivar.ToolTipText = VToolsBotonReactivar
        tabDatos.Text = VDato
        tabBusqueda.Text = VBusqueda
        lblDocIdentidad.Text = VDocumento
        lblFechaReg.Text = VFecha
        lblFechaNacM.Text = VFechaNac
        lblNumeroEmpleado.Text = VNEmpleado
        lblNombreM.Text = VNombres
        lblApellidosM.Text = VApellidos
        lblEmailM.Text = VEmail
        lblOtrosDatos.Text = VOtrosDatos.ToUpper
        lblDireccionM.Text = VDireccion
        lblNumeroCalleM.Text = VNum
        lblAptoM.Text = VApto
        lblEsquinaM.Text = VEsquina
        lblBarrioM.Text = VBarrio
        lblTelefonos.Text = VTelefonos.ToUpper
        dgvListaTelefonos.Columns(0).HeaderText = VTelefonos
        Me.Text = VAdministrativo.ToUpper
        dgvListaAdministrador.Columns(0).HeaderText = VDocumento
        dgvListaAdministrador.Columns(1).HeaderText = VNEmpleado
        dgvListaAdministrador.Columns(2).HeaderText = VNombres
        dgvListaAdministrador.Columns(3).HeaderText = VApellidos
        dgvListaAdministrador.Columns(4).HeaderText = VEmail
        dgvListaAdministrador.Columns(5).HeaderText = VFecha
        dtpFechaNac.Format = DateTimePickerFormat.Custom
        dtpFechaNac.CustomFormat = Nothing
        btnRestPass.Text = VRestablecerPassword
    End Sub

    Private Sub btnRestPass_Click(sender As Object, e As EventArgs) Handles btnRestPass.Click
        'Confirma la generacion de un nuevo password para el usuario en pantalla
        Dim respuesta As Integer
        respuesta = MsgBox(VMensajeRestablecerPassword, vbQuestion + vbYesNo, VAvisoAlerta)
        If respuesta = 6 Then
            generarNuevaPassword()
        End If
    End Sub

    Private Sub generarNuevaPassword()
        'Cambia la contraseña del usuario en la bd
        Try
            Dim newPass As String = ControladorPersona.generarPassword()
            ControladorPersona.CambiarPassword(txtDocIdentidad.Text, newPass,
                                               ControladorConfiguracion.leerRangoIpGestion(USUARIO, PASSWORD),
                                               USUARIO, PASSWORD)
            enviarEmailNuevoPassword(newPass)
        Catch ex As Exception
            MsgBox(VErrorCambiarPassword, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub enviarEmailNuevoPassword(ByVal nuevoPass As String)
        'Notifica al usuario por email del nuevo password
        EnviarEmail(txtDocIdentidad.Text, nuevoPass, txtEmail.Text,
        VRecuperacionAsunto, VRecuperacionTitulo, VRecuperacionDescipcion)
    End Sub

    Private Sub activarBotonPassword()
        btnRestPass.Enabled = True
    End Sub

    Private Sub desactivarPassword()
        btnRestPass.Enabled = False
    End Sub
End Class