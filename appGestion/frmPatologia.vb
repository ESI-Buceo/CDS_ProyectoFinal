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
        If ControladorValidaciones.ValidarCampoVacio(txtPatologiaNombre.Text) _
            And ControladorValidaciones.ValidarPonderacion(cbPatologiaPonderacion.Text) _
            And ControladorValidaciones.ValidarCampoVacio(txtPatologiaDescipcion.Text) _
            And ControladorValidaciones.ValidarListaCargada(dgvSintomasPatologia) Then
            guardarInformacionPatologia()
        Else
            MsgBox("Falta informacion para guardar la patologia, verifica", vbInformation, "Falta de informacion")
        End If
    End Sub

    Private Sub guardarInformacionPatologia()
        'Guarda la informacion de la patologia
        Try
            ControladorPatologias.AltaPatologia(txtPatologiaID.Text, txtPatologiaNombre.Text, cbPatologiaPonderacion.Text,
                                                txtPatologiaDescipcion.Text, chkActiva.CheckState, dgvSintomasPatologia, USUARIO, PASSWORD)
            opcionesMenu.ClickEnBotonGuardar(toolsMenuPatologia)
            colorPorDefectoTextoBox()
            deshabilitarAgregarSintoma()
            MsgBox("Dato guardado correctamente")
        Catch ex As Exception
            MsgBox("Error al guarda la informacion de patologia", vbCritical, "Error")
        End Try
    End Sub

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
            MsgBox("Error al buscar patologias", vbCritical, "Error")
        End Try
    End Sub

    Private Sub mnuBtnModificar_Click(sender As Object, e As EventArgs) Handles mnuBtnModificar.Click
        opcionesMenu.ClickEnBotonModificar(toolsMenuPatologia)
        txtPatologiaNombre.Select()
        colorearCamposRqueridos()
        habilitarAgregarSintoma()
    End Sub

    Private Sub mnuBtnBorrar_Click(sender As Object, e As EventArgs) Handles mnuBtnBorrar.Click
        'Borra logicamente una patologia
        Try
            ControladorPatologias.BorrarPatologia(txtPatologiaID.Text, USUARIO, PASSWORD)
            opcionesMenu.ClickEnBotonBorrar(toolsMenuPatologia)
            limpiarControlesDeFormulario()
            MsgBox("Patología eliminada con exito")
        Catch ex As Exception
            MsgBox("Error al borrar la patologia", vbCritical, "Error")
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
            MsgBox("Error al listar sintomas", vbCritical, "Error")
        End Try
    End Sub

    Private Sub btnAgregarSintoma_Click_1(sender As Object, e As EventArgs) Handles btnAgregarSintoma.Click
        frmListaSintomas.MdiParent = frmPrincipal
        frmListaSintomas.Show()
    End Sub

    Private Sub lblEmergencia_MouseMove(sender As Object, e As MouseEventArgs) Handles lblEmergencia.MouseMove
        tttPonderacion.Show("EMERGENCIA", lblEmergencia, 1000)
    End Sub

    Private Sub lblUrgencia_MouseMove(sender As Object, e As MouseEventArgs) Handles lblUrgencia.MouseMove
        tttPonderacion.Show("URGENCIA", lblUrgencia, 1000)
    End Sub

    Private Sub lblUrgenciaMenor_MouseMove(sender As Object, e As MouseEventArgs) Handles lblUrgenciaMenor.MouseMove
        tttPonderacion.Show("URGENCIA MENOR", lblUrgenciaMenor, 1000)
    End Sub

    Private Sub lblSinUrgencia_MouseMove(sender As Object, e As MouseEventArgs) Handles lblSinUrgencia.MouseMove
        tttPonderacion.Show("SIN URGENCIA", lblSinUrgencia, 1000)
    End Sub

End Class