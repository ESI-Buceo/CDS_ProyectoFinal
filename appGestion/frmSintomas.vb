Imports capaLogica

Public Class frmSintomas

    Private Sub mnuBtnCancelar_Click(sender As Object, e As EventArgs) Handles mnuBtnCancelar.Click
        opcionesMenu.ClickEnBotonCancelar(toolsMenuSintoma)
        tabDatosSintomas.SelectTab(tabDatos)
        colorPorDefectoTextBox()
    End Sub

    Private Sub mnuBtnBuscar_Click(sender As Object, e As EventArgs) Handles mnuBtnBuscar.Click
        'Busca un sintoma por el nombre
        Try
            dgSintomas.DataSource = ControladorSintomas.ListarSintomas(UCase(txtSintomaNombre.Text), USUARIO, PASSWORD)
            opcionesMenu.ClickEnBotonBuscar(toolsMenuSintoma)
            tabDatosSintomas.SelectTab(tabBusqueda)
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub mnuBtnModificar_Click(sender As Object, e As EventArgs) Handles mnuBtnModificar.Click
        opcionesMenu.ClickEnBotonModificar(toolsMenuSintoma)
        marcarTextBoxRequeridos()
        txtSintomaNombre.Select()
        tabDatosSintomas.SelectTab(tabDatos)

    End Sub

    Private Sub mnuBtnNueva_Click(sender As Object, e As EventArgs) Handles mnuBtnNueva.Click
        opcionesMenu.ClickEnBotonNueva(toolsMenuSintoma)
        limpiarTextBox()
        txtSintomaNombre.Select()
        tabDatosSintomas.SelectTab(tabDatos)
    End Sub

    Private Sub mnuBtnAgregar_Click(sender As Object, e As EventArgs) Handles mnuBtnAgregar.Click
        opcionesMenu.ClickEnBotonAgregar(toolsMenuSintoma)
        limpiarTextBox()
        txtSintomaNombre.Select()
        tabDatosSintomas.SelectTab(tabDatos)
        marcarTextBoxRequeridos()
    End Sub

    Private Sub mnuBtnGuardar_Click(sender As Object, e As EventArgs) Handles mnuBtnGuardar.Click

        Try
            ControladorSintomas.GuardarSintomas(txtSintomaID.Text, txtSintomaNombre.Text, chkSintomaEstado.CheckState, USUARIO, PASSWORD)
            opcionesMenu.ClickEnBotonGuardar(toolsMenuSintoma)
            colorPorDefectoTextBox()
            mensajeOk()
        Catch ex As Exception
            mensajeError()
        End Try
        limpiarTextBox()
    End Sub

    Private Sub mnuBtnBorrar_Click(sender As Object, e As EventArgs) Handles mnuBtnBorrar.Click
        'Borra logicamente el sintoma que esta en pantalla
        Try
            ControladorSintomas.BorrarSintomas(txtSintomaID.Text, USUARIO, PASSWORD)
            opcionesMenu.ClickEnBotonBorrar(toolsMenuSintoma)
            limpiarTextBox()
            MessageBox.Show(VRegistroEliminado, VAviso, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(VErrorBorrarRegistro, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub dgSintomas_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgSintomas.RowHeaderMouseClick
        opcionesMenu.ClickEnListado(toolsMenuSintoma)
        tabDatosSintomas.SelectTab(tabDatos)
        txtSintomaID.Text = dgSintomas.Item(0, e.RowIndex).Value
        txtSintomaNombre.Text = dgSintomas.Item(1, e.RowIndex).Value
        chkSintomaEstado.Checked = dgSintomas.Item(2, e.RowIndex).Value
    End Sub

    Private Sub limpiarTextBox()
        txtSintomaID.Text = "0"
        txtSintomaNombre.Text = ""
        chkSintomaEstado.CheckState = CheckState.Checked
    End Sub

    Private Sub mensajeError()
        MessageBox.Show(VErrorAlGuardar & txtSintomaNombre.Text)
    End Sub

    Private Sub mensajeOk()
        MsgBox(VDatosGuardadosConExito, vbInformation, VAviso)
    End Sub

    Private Sub campoVacio()
        MsgBox(VFaltanDatosRequeridos, vbExclamation, VAvisoError)
    End Sub

    Private Sub marcarTextBoxRequeridos()
        txtSintomaNombre.BackColor = Color.Beige
    End Sub

    Private Sub colorPorDefectoTextBox()
        txtSintomaNombre.BackColor = Color.White
    End Sub

    Private Sub frmSintomas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTextos()
    End Sub

    Private Sub cargarTextos()
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
        Me.Text = VSintomas.ToUpper
        lblSintomaNombre.Text = VNombre.ToUpper
        lblSintomaEstado.Text = VHabilitado.ToUpper
        tabDatos.Text = VDato
        tabBusqueda.Text = VBusqueda
        dgSintomas.Columns(1).HeaderText = VNombre.ToUpper
        dgSintomas.Columns(2).HeaderText = Vactivo.ToUpper
    End Sub

End Class