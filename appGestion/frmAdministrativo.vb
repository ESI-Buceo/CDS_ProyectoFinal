Imports capaLogica

Public Class frmAdministrativo
    Dim agregar As Boolean

    Private Sub mnuBtnAgregar_Click(sender As Object, e As EventArgs) Handles mnuBtnAgregar.Click
        ClickEnBotonAgregar(toolsMenuAdmin)
        agregar = True
        habilitarDocumento()
        colorearDocumento()
        chkActivo.Visible = False
        vaciarControles()
        habilitarControlesDeEdicion()
        cargarFechaDeHoy()
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

    Private Sub crearTablaTelefonoParaDataGrid()
        'Crea un datatable para el datagrid de telefonos
        dgvListaTelefonos.DataSource = crearTablaTelefonos()
    End Sub

    Private Sub habilitarControlesDeEdicion()
        'Habilita la lista de telefonos
        dgvListaTelefonos.Enabled = True
        btnAgregarTelefono.Enabled = True
        btnEliminarTelefono.Enabled = True
        txtDocIdentidad.Enabled = True
        chkActivo.Enabled = True
        colorearCamposRequeridos()
    End Sub

    Private Sub deshabilitarControlesDeEdicion()
        'Habilita la lista de telefonos
        dgvListaTelefonos.Enabled = False
        btnAgregarTelefono.Enabled = False
        btnEliminarTelefono.Enabled = False
        txtDocIdentidad.Enabled = False
        chkActivo.Visible = False
        restaurarColorCampos()
    End Sub

    Private Sub deshablitaDocumento()
        'Deshabilita el textbox de documento
        txtDocIdentidad.Enabled = False
    End Sub

    Private Sub mnuBtnGuardar_Click(sender As Object, e As EventArgs) Handles mnuBtnGuardar.Click
        'Guarda la informacion del medico
        ClickEnBotonGuardar(toolsMenuAdmin)
        Try
            controladorAdministrativo.GuardarDatosAdmin(txtDocIdentidad.Text, txtEmail.Text, txtNombres.Text, txtApellidos.Text,
                               txtCalle.Text, txtNumeroCalle.Text, txtBarrio.Text, txtEsquina.Text, txtApto.Text,
                               Format(dtpFechaNac.Value, "yyyy-MM-dd"), chkActivo.CheckState, dgvListaTelefonos,
                               txtNumAdmin.Text)
            deshabilitarControlesDeEdicion()
            guardadoConExito()
        Catch ex As Exception
            MsgBox("Error al guardar los datos del medico")
        End Try
    End Sub

    Private Sub guardadoConExito()
        'Mensaje de guardo con exito
        MsgBox("Datos guardado con exito", vbInformation, "Aviso")
        deshablitaDocumento()
        restaurarColorCampos()
    End Sub

    Private Sub deshabilitarListaTelefonos()
        'Deshabilita la lista de telefonos
        dgvListaTelefonos.Enabled = False
    End Sub

    Private Sub mnuBtnCancelar_Click(sender As Object, e As EventArgs) Handles mnuBtnCancelar.Click
        'Cancela los procesos activos
        ClickEnBotonCancelar(toolsMenuAdmin)
        deshablitaDocumento()
        deshabilitarControlesDeEdicion()
        tabOpcionAdmin.SelectTab(tabDatos)
    End Sub

    Private Sub mnuBtnNueva_Click(sender As Object, e As EventArgs) Handles mnuBtnNueva.Click
        'Habilita para una nueva busqueda
        ClickEnBotonNueva(toolsMenuAdmin)
        agregar = False
        crearTablaTelefonoParaDataGrid()
        vaciarControles()
        habilitarDocumento()
        txtDocIdentidad.Select()
        marcarCamposParaBusqueda()
    End Sub

    Private Sub mnuBtnBuscar_Click(sender As Object, e As EventArgs) Handles mnuBtnBuscar.Click
        'Buscar un administrativo de acuerdo a los datos ingresados 
        ClickEnBotonBuscar(toolsMenuAdmin)
        tabOpcionAdmin.SelectTab(tabBusqueda)
        formarCadenaDeBusqueda()
    End Sub

    Private Sub marcarCamposParaBusqueda()
        'Marca los campos por los que se puede buscar
        txtDocIdentidad.BackColor = Color.FromArgb(247, 241, 210)
        txtNumAdmin.BackColor = Color.FromArgb(247, 241, 210)
        txtNombres.BackColor = Color.FromArgb(247, 241, 210)
        txtApellidos.BackColor = Color.FromArgb(247, 241, 210)
    End Sub


    Private Sub mnuBtnBorrar_Click(sender As Object, e As EventArgs) Handles mnuBtnBorrar.Click
        'Dispara el proceso de eliminacion logica
        ClickEnBotonBorrar(toolsMenuAdmin)
        Dim confirmar As Integer
        confirmar = MsgBox("Seguro de eliminar al Administrativo?", vbQuestion & vbYesNo, "Confirmar")
        If confirmar = 6 Then
            borrarAdministrativo()
        End If
    End Sub
    Private Sub borrarAdministrativo()
        'Procesa baja de administrativo
        Try
            controladorAdministrativo.EliminiarAdmin(txtDocIdentidad.Text)
            ClickEnBotonBorrar(toolsMenuAdmin)
            MsgBox("Administrativo eliminado con exito !", vbInformation, "Aviso")
        Catch ex As Exception
            MsgBox("Error al eliminar el administrativo", vbCritical, "Aviso")
        End Try
    End Sub

    Private Sub mnuBtnModificar_Click(sender As Object, e As EventArgs) Handles mnuBtnModificar.Click
        'Habilita la modificacion del administrativo en pantalla
        ClickEnBotonModificar(toolsMenuAdmin)
        habilitarControlesDeEdicion()
        deshablitaDocumento()
        chkActivo.Visible = True
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
            mostrarDatosDelAdmin(controladorAdministrativo.BuscarAdministrativoPorDocumento(dgvListaAdministrador.Item(0, e.RowIndex).Value))
            restaurarColorCampos()
            tabOpcionAdmin.SelectTab(tabDatos)
            deshablitaDocumento()
            validarBotonBorrar(dgvListaAdministrador.Item(6, e.RowIndex).Value)
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
        chkActivo.CheckState = datosAdministrativo.Rows(0).Item("activo").ToString
        cargarTelefonos(datosAdministrativo)
    End Sub

    Private Sub cargarTelefonos(ByVal telefonos As DataTable)
        'Carga los telefonos del administrativo elegido
        Dim tablaTelefono As New DataTable
        tablaTelefono = crearTablaTelefonos()
        For t = 0 To telefonos.Rows.Count - 1
            Dim rowTel As DataRow = tablaTelefono.NewRow()
            rowTel("Telefono") = telefonos(t).Item("telefono").ToString
            tablaTelefono.Rows.Add(rowTel)
        Next
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
        dgvListaAdministrador.DataSource = controladorAdministrativo.buscarAdministrativo(stringDeBusqueda)
        colorearEliminados(dgvListaAdministrador)
        crearTablaTelefonoParaDataGrid()
    End Sub

    Public Sub colorearEliminados(ByRef lista As DataGridView)
        For i = 0 To lista.Rows.Count - 1
            If lista.Rows.Item(i).Cells("colActivo").Value.ToString = 0 Then
                lista.Rows(i).DefaultCellStyle.BackColor = Color.Red
                lista.Rows(i).DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub txtDocIdentidad_LostFocus(sender As Object, e As EventArgs) Handles txtDocIdentidad.LostFocus
        If agregar Then validarDocumentoDeIdentidad()
    End Sub

    Private Sub validarDocumentoDeIdentidad()
        Try
            If controladorAdministrativo.VarificarDocumentoDeIdentidad(txtDocIdentidad.Text) IsNot Nothing Then
                MsgBox("El documento ingresado ya existe", vbInformation, "AVISO")
                cancelarProcesoDeIngreso()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cancelarProcesoDeIngreso()
        ClickEnBotonCancelar(toolsMenuAdmin)
        deshablitaDocumento()
        deshabilitarControlesDeEdicion()
        vaciarControles()
    End Sub
End Class