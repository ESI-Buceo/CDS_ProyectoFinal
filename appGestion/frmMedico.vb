Imports capaLogica

Public Class frmMedico
    Dim agregar As Boolean

    Private Sub mnuBtnAgregar_Click(sender As Object, e As EventArgs) Handles mnuBtnAgregar.Click
        'Habilita el ingreso de un nuevo medico
        ClickEnBotonAgregar(toolsMenuMedico)
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

    Private Sub deshablitaDocumento()
        'Deshabilita el textbox de documento
        txtDocIdentidad.Enabled = False
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
        colorearCamposRequeridos()
    End Sub

    Private Sub deshabilitarControlesDeEdicion()
        'Habilita la lista de telefonos
        dgvListaTelefonos.Enabled = False
        btnAgregarTelefono.Enabled = False
        btnEliminarTelefono.Enabled = False
        restaurarColorCampos()
    End Sub

    Private Sub mnuBtnGuardar_Click(sender As Object, e As EventArgs) Handles mnuBtnGuardar.Click
        'Guarda la informacion del medico
        ClickEnBotonGuardar(toolsMenuMedico)
        Try
            GuardarDatosMedico(txtDocIdentidad.Text, txtEmail.Text, txtNombres.Text, txtApellidos.Text,
                               txtCalle.Text, txtNumeroCalle.Text, txtBarrio.Text, txtEsquina.Text, txtApto.Text,
                               Format(dtpFechaNac.Value, "yyyy-MM-dd"), chkActivo.CheckState, dgvListaTelefonos,
                               txtNumMedico.Text)
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
        'Cancela la operacion
        ClickEnBotonCancelar(toolsMenuMedico)
        deshablitaDocumento()
        deshabilitarControlesDeEdicion()
        tabOpcionesMedico.SelectTab(tabDatos)
    End Sub

    Private Sub mnuBtnNueva_Click(sender As Object, e As EventArgs) Handles mnuBtnNueva.Click
        'Habilita para una nueva busqueda
        ClickEnBotonNueva(toolsMenuMedico)
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
        ClickEnBotonBuscar(toolsMenuMedico)
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
            ControladorMedico.EliminiarMedico(txtDocIdentidad.Text)
            ClickEnBotonBorrar(toolsMenuMedico)
            MsgBox("Medico eliminado con exito !", vbInformation, "Aviso")
        Catch ex As Exception
            MsgBox("Error al eliminar el medico", vbCritical, "Aviso")
        End Try
    End Sub

    Private Sub mnuBtnModificar_Click(sender As Object, e As EventArgs) Handles mnuBtnModificar.Click
        'Habilita la modificacion del medico en pantalla
        ClickEnBotonModificar(toolsMenuMedico)
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

    Private Sub cargarFechaDeHoy()
        'Carga la fecha del dia de hoy
        txtFechaRegistro.Text = Format(CDate(Now), "dd/MM/yyyy")
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

    Private Sub dgvListaMedicos_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListaMedicos.RowHeaderMouseClick
        'Evento al hacer clic en la lista de medicos que muestra los datos del mismo
        Try
            mostrarDatosDelMedico(ControladorMedico.buscarMedicoPorDocumento(dgvListaMedicos.Item(0, e.RowIndex).Value))
            ClickEnListado(toolsMenuMedico)
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
                stringDeBusqueda += crearCadenaDeBusquedaMedico(controles.Name, controles.Text) & " AND "
            End If
        Next
        lanzarBusquedaDeMedico(stringDeBusqueda)
    End Sub

    Private Sub lanzarBusquedaDeMedico(ByVal stringDeBusqueda As String)
        dgvListaMedicos.DataSource = ControladorMedico.buscarMedico(stringDeBusqueda)
        colorearEliminados(dgvListaMedicos)
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


    Private Sub validarDocumentoDeIdentidad()
        Try
            If ControladorMedico.VarificarDocumentoDeIdentidad(txtDocIdentidad.Text) IsNot Nothing Then
                MsgBox("El documento ingresado ya existe", vbInformation, "AVISO")
                cancelarProcesoDeIngreso()
            End If
        Catch ex As Exception
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
