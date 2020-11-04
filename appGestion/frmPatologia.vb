Imports capaLogica

Public Class frmPatologia
    Public sintomasDePatologia As New DataTable

    Private Sub mnuBtnAgregar_Click(sender As Object, e As EventArgs) Handles mnuBtnAgregar.Click
        opcionesMenu.ClickEnBotonAgregar(toolsMenuPatologia)
        limpiarControlesDeFormulario()
        habilitarAgregarSintoma()
        txtPatologiaNombre.Select()
        colorearCamposRqueridos()
        formatoListaDeSintomas()
    End Sub

    Private Sub formatoListaDeSintomas()
        dgvSintomasPatologia.DataSource = ControladorPatologias.CrearDataTableSintomasXPatologia(sintomasDePatologia)
        dgvSintomasPatologia.Columns.Item(1).Width = 200
        dgvSintomasPatologia.Columns.Item(0).Visible = False
    End Sub

    Private Sub mnuBtnGuardar_Click(sender As Object, e As EventArgs) Handles mnuBtnGuardar.Click
        'Guarda los datos de la patologia
        validarNombre()
    End Sub

    Private Sub validarNombre()
        If ControladorValidaciones.ValidarCampoVacio(txtPatologiaNombre.Text) Then
            validarPonderacion()
        Else
            MsgBox(VNombresInvalidos, vbInformation, VAviso)
            txtPatologiaNombre.Select()
        End If
    End Sub

    Private Sub validarPonderacion()
        If ControladorValidaciones.ValidarPonderacion(cbPatologiaPonderacion.Text) Then
            validarDescripcion()
        Else
            MsgBox(VPonderacionNoVacio, vbInformation, VAviso)
            cbPatologiaPonderacion.Select()
        End If
    End Sub

    Private Sub validarDescripcion()
        If ControladorValidaciones.ValidarCampoVacio(txtPatologiaDescipcion.Text) Then
            validarListaSintomas()
        Else
            MsgBox(VCampoNoVacio, vbInformation, VAviso)
            txtPatologiaDescipcion.Select()
        End If
    End Sub

    Private Sub validarListaSintomas()
        If ControladorValidaciones.ValidarListaCargada(dgvSintomasPatologia) Then
            guardarInformacionPatologia()
        Else
            MsgBox(VListaSintomasVacia, vbInformation, VAviso)
            btnAgregarSintoma.Select()
        End If
    End Sub

    Private Sub guardarInformacionPatologia()
        'Guarda la informacion de la patologia
        Try
            ControladorPatologias.AltaPatologia(txtPatologiaID.Text, txtPatologiaNombre.Text, cbPatologiaPonderacion.Text,
                                                txtPatologiaDescipcion.Text, chkActiva.CheckState, listaDeSintomas, USUARIO, PASSWORD)
            opcionesMenu.ClickEnBotonGuardar(toolsMenuPatologia)
            colorPorDefectoTextoBox()
            deshabilitarAgregarSintoma()
            MsgBox(VDatosGuardadosConExito, vbInformation, VAviso)
        Catch ex As Exception
            MsgBox(VErrorAlGuardar, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Function listaDeSintomas()
        'Genera una lista con los sintomas del datagridview
        Dim listaSintomas As New List(Of Integer)
        For s = 0 To dgvSintomasPatologia.Rows.Count - 1
            listaSintomas.Add(dgvSintomasPatologia.Item(0, s).Value)
        Next
        Return listaSintomas
    End Function

    Private Sub mnuBtnCancelar_Click(sender As Object, e As EventArgs) Handles mnuBtnCancelar.Click
        opcionesMenu.ClickEnBotonCancelar(toolsMenuPatologia)
        tabDatosPatologia.SelectTab(tabDatos)
        colorPorDefectoTextoBox()
        deshabilitarAgregarSintoma()
    End Sub

    Private Sub mnuBtnNueva_Click(sender As Object, e As EventArgs) Handles mnuBtnNueva.Click
        opcionesMenu.ClickEnBotonNueva(toolsMenuPatologia)
        tabDatosPatologia.SelectTab(tabDatos)
        limpiarControlesDeFormulario()
        txtPatologiaNombre.Select()
        deshabilitarAgregarSintoma()
    End Sub

    Private Sub mnuBtnBuscar_Click(sender As Object, e As EventArgs) Handles mnuBtnBuscar.Click
        'Lista las patologias
        opcionesMenu.ClickEnBotonBuscar(toolsMenuPatologia)
        tabDatosPatologia.SelectTab(tabPatologiaBusqueda)
        Try
            dgvListaDePatologias.DataSource = ControladorPatologias.ListarPatologias(txtPatologiaNombre.Text, USUARIO, PASSWORD)
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub mnuBtnModificar_Click(sender As Object, e As EventArgs) Handles mnuBtnModificar.Click
        opcionesMenu.ClickEnBotonModificar(toolsMenuPatologia)
        txtPatologiaNombre.Select()
        colorearCamposRqueridos()
        habilitarAgregarSintoma()
    End Sub

    Private Sub mnuBtnBorrar_Click(sender As Object, e As EventArgs) Handles mnuBtnBorrar.Click
        borrarPAtologia()
    End Sub

    Private Sub borrarPAtologia()
        'Borra logicamente una patologia
        Try
            ControladorPatologias.cambiarEstadoPatologia(txtPatologiaID.Text, 0, USUARIO, PASSWORD)
            opcionesMenu.ClickEnBotonBorrar(toolsMenuPatologia)
            limpiarControlesDeFormulario()
            MsgBox(VRegistroEliminado, vbInformation, VAviso)
        Catch ex As Exception
            MsgBox(VErrorBorrarRegistro, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub colorearCamposRqueridos()
        ' colorea los campos requeridos
        txtPatologiaNombre.BackColor = Color.Beige
        cbPatologiaPonderacion.BackColor = Color.Beige
        txtPatologiaDescipcion.BackColor = Color.Beige

    End Sub

    Private Sub colorPorDefectoTextoBox()
        ' colorea los campos edidables
        txtPatologiaNombre.BackColor = Color.White
        cbPatologiaPonderacion.BackColor = Color.White
        txtPatologiaDescipcion.BackColor = Color.White

    End Sub

    Private Sub habilitarAgregarSintoma()
        'habilita los botons para agregar sintomas y signos
        btnAgregarSintoma.Enabled = True
        dgvSintomasPatologia.Enabled = True
    End Sub

    Private Sub deshabilitarAgregarSintoma()
        'deshabilita los botons para agregar sintomas y signos
        btnAgregarSintoma.Enabled = False
        dgvSintomasPatologia.Enabled = False
    End Sub

    Private Sub limpiarControlesDeFormulario()
        txtPatologiaID.Text = "0"
        txtPatologiaNombre.Text = ""
        txtPatologiaDescipcion.Text = ""
        cbPatologiaPonderacion.Text = ""
        dgvSintomasPatologia.DataSource = ""
    End Sub

    Private Sub dgvListaDePatologias_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListaDePatologias.RowHeaderMouseClick
        opcionesMenu.ClickEnListado(toolsMenuPatologia)
        tabDatosPatologia.SelectTab(tabDatos)
        txtPatologiaID.Text = dgvListaDePatologias.Item(0, e.RowIndex).Value
        txtPatologiaNombre.Text = dgvListaDePatologias.Item(1, e.RowIndex).Value
        txtPatologiaDescipcion.Text = dgvListaDePatologias.Item(3, e.RowIndex).Value
        cbPatologiaPonderacion.Text = dgvListaDePatologias.Item(2, e.RowIndex).Value
        chkActiva.Checked = dgvListaDePatologias.Item(4, e.RowIndex).Value
        cargarListaSintomasDePatologia()
    End Sub

    Private Sub cargarListaSintomasDePatologia()
        'Carga la lista de sintomas de la patologia
        Try
            sintomasDePatologia = ControladorPatologias.CargarSintomaPorPatologia(txtPatologiaID.Text, sintomasDePatologia, USUARIO, PASSWORD)
            dgvSintomasPatologia.DataSource = sintomasDePatologia
            dgvSintomasPatologia.Columns(0).Visible = False
            dgvSintomasPatologia.Columns(1).Width = 150
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub btnAgregarSintoma_Click_1(sender As Object, e As EventArgs) Handles btnAgregarSintoma.Click
        frmListaSintomas.MdiParent = frmPrincipal
        frmListaSintomas.Show()
    End Sub

    Private Sub lblEmergencia_MouseMove(sender As Object, e As MouseEventArgs) Handles lblEmergencia.MouseMove
        tttPonderacion.Show(VEmergencia.ToUpper, lblEmergencia, 1000)
    End Sub

    Private Sub lblUrgencia_MouseMove(sender As Object, e As MouseEventArgs) Handles lblUrgencia.MouseMove
        tttPonderacion.Show(VUrgencia.ToUpper, lblUrgencia, 1000)
    End Sub

    Private Sub lblUrgenciaMenor_MouseMove(sender As Object, e As MouseEventArgs) Handles lblUrgenciaMenor.MouseMove
        tttPonderacion.Show(VUrgenciaMenor.ToUpper, lblUrgenciaMenor, 1000)
    End Sub

    Private Sub lblSinUrgencia_MouseMove(sender As Object, e As MouseEventArgs) Handles lblSinUrgencia.MouseMove
        tttPonderacion.Show(VSinUrgencia.ToUpper, lblSinUrgencia, 1000)
    End Sub

    Private Sub frmPatologia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTextos()
    End Sub

    Private Sub cargarTextos()
        Me.Text = VPatologias.ToUpper
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
        tabPatologiaBusqueda.Text = VBusqueda
        lblPatologiaNombre.Text = VNombre.ToUpper
        lblPatologiaPonderacion.Text = VPonderacion.ToUpper
        lblPatologiaDescripcion.Text = VDescripcion.ToUpper
        lblSintomas.Text = VSintomas.ToUpper
        btnAgregarSintoma.Text = VAgregar
        tttPonderacion.ToolTipTitle = VInformacionPatologias
        dgvListaDePatologias.Columns(1).HeaderText = VNombre.ToUpper
        dgvListaDePatologias.Columns(2).HeaderText = VDescripcion.ToUpper
        dgvListaDePatologias.Columns(3).HeaderText = VPonderacion.ToUpper
        dgvListaDePatologias.Columns(4).HeaderText = Vactivo.ToUpper
    End Sub
End Class