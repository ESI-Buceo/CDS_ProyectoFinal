Imports capaLogica

Public Class frmMedico
    Dim agregar As Boolean

    Private Sub mnuBtnAgregar_Click(sender As Object, e As EventArgs) Handles mnuBtnAgregar.Click
        'Habilita el ingreso de un nuevo medico
        opcionesMenu.ClickEnBotonAgregar(toolsMenuMedico)
        agregar = True
        habilitarDocumento()
        colorearDocumento()
        chkActivo.Visible = False
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
        dgvListaTelefonos.DataSource = ControladorMedico.crearTablaTelefonos()
    End Sub

    Private Sub habilitarControlesDeEdicion()
        'Habilita la lista de telefonos
        dgvListaTelefonos.ReadOnly = False
        dgvListaTelefonos.Enabled = True
        btnAgregarTelefono.Enabled = True
        btnEliminarTelefono.Enabled = True
        colorearCamposRequeridos()
    End Sub

    Private Sub deshabilitarControlesDeEdicion()
        'deshabilita la lista de telefonos
        dgvListaTelefonos.Enabled = False
        btnAgregarTelefono.Enabled = False
        btnEliminarTelefono.Enabled = False
        agregar = False
        restaurarColorCampos()
    End Sub

    Private Sub mnuBtnGuardar_Click(sender As Object, e As EventArgs) Handles mnuBtnGuardar.Click
        'valida antes de ingresar la informacion del medico
        If ControladorValidaciones.validarFormatoDocumento(txtDocIdentidad.Text) And ControladorValidaciones.validarNombres(txtNombres.Text) _
            And ControladorValidaciones.validarApellidos(txtApellidos.Text) And ControladorValidaciones.ValidarEmail(txtEmail.Text) _
            And ControladorValidaciones.ValidarFechaNacimiento(dtpFechaNac.Value) And ControladorValidaciones.ValidarNumeroMedico(txtNumMedico.Text) Then
            guardarDatosDelMedico()
        Else
            MsgBox("Faltan datos requeridos o hay datos incorrectos, verifica.", vbInformation, "Aviso")
        End If
    End Sub

    Private Sub guardarDatosDelMedico()
        'Guarda la informacion del medico
        Try
            ControladorMedico.GuardarDatosMedico(txtDocIdentidad.Text, txtEmail.Text, txtNombres.Text, txtApellidos.Text,
                               txtCalle.Text, txtNumeroCalle.Text, txtBarrio.Text, txtEsquina.Text, txtApto.Text,
                               Format(dtpFechaNac.Value, "yyyy-MM-dd"), chkActivo.CheckState, dgvListaTelefonos,
                               txtNumMedico.Text, USUARIO, PASSWORD)
            opcionesMenu.ClickEnBotonGuardar(toolsMenuMedico)
            guardadoConExito()
            deshabilitarControlesDeEdicion()
        Catch ex As Exception
            MsgBox("Error al guardar los datos del medico")
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
                ControladorMedico.crearUsuarioBD(txtDocIdentidad.Text, USUARIO, PASSWORD)
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
        opcionesMenu.ClickEnBotonCancelar(toolsMenuMedico)
        deshablitaDocumento()
        deshabilitarControlesDeEdicion()
        tabOpcionesMedico.SelectTab(tabDatos)
        desactivarCheckActivo()
    End Sub

    Private Sub mnuBtnNueva_Click(sender As Object, e As EventArgs) Handles mnuBtnNueva.Click
        'Habilita para una nueva busqueda
        opcionesMenu.ClickEnBotonNueva(toolsMenuMedico)
        agregar = False
        crearTablaTelefonoParaDataGrid()
        vaciarControles()
        habilitarDocumento()
        txtDocIdentidad.Select()
        marcarCamposParaBusqueda()
    End Sub

    Private Sub marcarCamposParaBusqueda()
        txtDocIdentidad.BackColor = Color.FromArgb(247, 241, 210)
        txtNumMedico.BackColor = Color.FromArgb(247, 241, 210)
        txtNombres.BackColor = Color.FromArgb(247, 241, 210)
        txtApellidos.BackColor = Color.FromArgb(247, 241, 210)
    End Sub

    Private Sub mnuBtnBuscar_Click(sender As Object, e As EventArgs) Handles mnuBtnBuscar.Click
        'Dispara una nueva busqueda
        opcionesMenu.ClickEnBotonBuscar(toolsMenuMedico)
        tabOpcionesMedico.SelectTab(tabMedicoBusqueda)
        formarCadenaDeBusqueda()
    End Sub

    Private Sub mnuBtnBorrar_Click(sender As Object, e As EventArgs) Handles mnuBtnBorrar.Click
        'Borra el registro del medico en pantalla
        Dim respuesta As Integer
        respuesta = MsgBox("Seguro de eliminar el medico?", vbQuestion & vbYesNo, "Confirmar eliminacion")
        If respuesta = 6 Then
            borrarMedico()
        End If
    End Sub

    Private Sub borrarMedico()
        'Procesa baja de medico
        Try
            If ControladorMedico.EliminiarMedico(txtDocIdentidad.Text, USUARIO, PASSWORD) Then
                opcionesMenu.ClickEnBotonBorrar(toolsMenuMedico)
                MsgBox("Medico eliminado con exito !", vbInformation, "Aviso")
                eliminarMedicoDeBD()
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar el medico", vbCritical, "Aviso")
        End Try
    End Sub

    Private Sub eliminarMedicoDeBD()
        'Elimina el usuario de la base de datos
        Try
            ControladorMedico.eliminiarUsuarioBD(txtDocIdentidad.Text, USUARIO, PASSWORD)
        Catch ex As Exception
            MsgBox("No se puedo eliminiar el usuario de la base de datos", vbCritical, "ERROR")
        End Try
    End Sub

    Private Sub mnuBtnModificar_Click(sender As Object, e As EventArgs) Handles mnuBtnModificar.Click
        'Habilita la modificacion del medico en pantalla
        opcionesMenu.ClickEnBotonModificar(toolsMenuMedico)
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
        txtNumMedico.BackColor = Color.FromArgb(247, 241, 210)
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
        'Recorre y vacia todos los textbox del tabDatos
        For Each controles As Control In Me.tabDatos.Controls
            If TypeOf controles Is TextBox Then
                controles.Text = Nothing
            End If
        Next
        crearTablaTelefonoParaDataGrid()
    End Sub

    Private Sub cargarFechaDeHoy()
        'Carga la fecha del dia de hoy
        txtFechaRegistro.Text = Format(CDate(Now), "dd/MM/yyyy")
    End Sub

    Private Sub dgvListaMedicos_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListaMedicos.RowHeaderMouseClick
        'Evento al hacer clic en la lista de medicos que muestra los datos del mismo
        ClickEnListado(toolsMenuMedico)
        Try
            mostrarDatosDelMedico(ControladorMedico.buscarMedicoPorDocumento(dgvListaMedicos.Item(0, e.RowIndex).Value, USUARIO, PASSWORD))
            restaurarColorCampos()
            tabOpcionesMedico.SelectTab(tabDatos)
            deshablitaDocumento()
            validarBotonBorrar(dgvListaMedicos.Item(6, e.RowIndex).Value)
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

    Private Sub mostrarDatosDelMedico(ByVal datosDelMedico As DataTable)
        'Carga todos los datos del medico elegido
        txtDocIdentidad.Text = datosDelMedico.Rows(0).Item("documento").ToString
        txtFechaRegistro.Text = Format(datosDelMedico.Rows(0).Item("fechReg"), "dd/MM/yyyy").ToString
        txtNumMedico.Text = datosDelMedico.Rows(0).Item("nmedico").ToString
        dtpFechaNac.Value = Format(datosDelMedico.Rows(0).Item("fechaNac"), "dd/MM/yyyy").ToString
        txtNombres.Text = datosDelMedico.Rows(0).Item("nombres").ToString
        txtApellidos.Text = datosDelMedico.Rows(0).Item("apellidos").ToString
        txtEmail.Text = datosDelMedico.Rows(0).Item("mail").ToString
        txtCalle.Text = datosDelMedico.Rows(0).Item("calle").ToString
        txtNumeroCalle.Text = datosDelMedico(0).Item("numero").ToString
        txtApto.Text = datosDelMedico.Rows(0).Item("apto").ToString
        txtEsquina.Text = datosDelMedico.Rows(0).Item("esquina").ToString
        txtBarrio.Text = datosDelMedico.Rows(0).Item("barrio").ToString
        chkActivo.CheckState = datosDelMedico.Rows(0).Item("activo").ToString
        cargarTelefonos(datosDelMedico)
    End Sub

    Private Sub cargarTelefonos(ByVal telefonos As DataTable)
        'Carga los telefonos del medico elegido
        cargarGridTelefonos(ControladorMedico.crearTablaTelefonos(), telefonos)
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
                stringDeBusqueda += ControladorMedico.crearCadenaDeBusquedaMedico(controles.Name, controles.Text) & " AND "
            End If
        Next
        lanzarBusquedaDeMedico(stringDeBusqueda)
    End Sub

    Private Sub lanzarBusquedaDeMedico(ByVal stringDeBusqueda As String)
        'Lanza la busqueda del medico por los datos ingresados
        Try
            dgvListaMedicos.DataSource = ControladorMedico.buscarMedico(stringDeBusqueda, USUARIO, PASSWORD)
            colorearEliminados(dgvListaMedicos)
            crearTablaTelefonoParaDataGrid()
        Catch ex As Exception
            MsgBox("Error al buscar medico", vbCritical, "Error")
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
        'Verifica si ya existe el documento en la bd
        Try
            If ControladorMedico.VarificarDocumentoDeIdentidad(txtDocIdentidad.Text, USUARIO, PASSWORD) IsNot Nothing Then
                MsgBox("El documento ingresado ya existe. No se puede continuar", vbInformation, "AVISO")
                cancelarProcesoDeIngreso()
            End If
        Catch ex As Exception
            MsgBox("Error al verificar el documento", vbCritical, "Error")
            cancelarProcesoDeIngreso()
        End Try
    End Sub

    Private Sub cancelarProcesoDeIngreso()
        ClickEnBotonCancelar(toolsMenuMedico)
        deshablitaDocumento()
        deshabilitarControlesDeEdicion()
        vaciarControles()
    End Sub

    Private Sub txtDocIdentidad_LostFocus(sender As Object, e As EventArgs) Handles txtDocIdentidad.LostFocus
        If agregar Then validarDocumentoDeIdentidad()
    End Sub

End Class
