Imports capaLogica
Public Class frmPatologia

    Private Sub mnuBtnAgregar_Click(sender As Object, e As EventArgs) Handles mnuBtnAgregar.Click
        opcionesMenu.ClickEnBotonAgregar(toolsMenuPatologia)
        limpiarControlesDeFormulario()
        habilitarAgregarSintomaYSignos()
        txtPatologiaNombre.Select()
        colorearCamposRqueridos()

    End Sub

    'Guarda los datos de la patologia o los modifica
    Private Sub mnuBtnGuardar_Click(sender As Object, e As EventArgs) Handles mnuBtnGuardar.Click
        Try
            ControladorPatologias.AltaPatologia(txtPatologiaNombre.Text, cbPatologiaPonderacion.Text, txtPatologiaDescipcion.Text, chkActiva.CheckState)
            MsgBox("Patologia creada con exito")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        opcionesMenu.ClickEnBotonGuardar(toolsMenuPatologia)
        colorPorDefectoTextoBox()
        deshabilitarAgregarSintomaYSignos()

    End Sub

    Private Sub mnuBtnCancelar_Click(sender As Object, e As EventArgs) Handles mnuBtnCancelar.Click
        opcionesMenu.ClickEnBotonCancelar(toolsMenuPatologia)
        tabDatosPatologia.SelectTab(tabDatos)
        colorPorDefectoTextoBox()
        deshabilitarAgregarSintomaYSignos()

    End Sub

    Private Sub mnuBtnNueva_Click(sender As Object, e As EventArgs) Handles mnuBtnNueva.Click
        opcionesMenu.ClickEnBotonNueva(toolsMenuPatologia)
        tabDatosPatologia.SelectTab(tabDatos)
        limpiarControlesDeFormulario()
        txtPatologiaNombre.Select()
        deshabilitarAgregarSintomaYSignos()

    End Sub

    Private Sub mnuBtnBuscar_Click(sender As Object, e As EventArgs) Handles mnuBtnBuscar.Click
        opcionesMenu.ClickEnBotonBuscar(toolsMenuPatologia)
        tabDatosPatologia.SelectTab(tabPatologiaBusqueda)
        dgvListaDePatologias.DataSource = ControladorPatologias.ListarPatologias(txtPatologiaNombre.Text)
        dgvListaDePatologias.Columns(2).Visible = False
        dgvListaDePatologias.Columns(1).Width = 300

    End Sub

    Private Sub mnuBtnModificar_Click(sender As Object, e As EventArgs) Handles mnuBtnModificar.Click
        opcionesMenu.ClickEnBotonModificar(toolsMenuPatologia)
        colorearCamposRqueridos()
        txtPatologiaNombre.Select()
        habilitarAgregarSintomaYSignos()

    End Sub

    Private Sub mnuBtnBorrar_Click(sender As Object, e As EventArgs) Handles mnuBtnBorrar.Click
        opcionesMenu.ClickEnBotonBorrar(toolsMenuPatologia)

    End Sub

    ' colorea los campos requeridos
    Private Sub colorearCamposRqueridos()
        txtPatologiaNombre.BackColor = Color.Beige
        cbPatologiaPonderacion.BackColor = Color.Beige
        txtPatologiaDescipcion.BackColor = Color.Beige

    End Sub

    ' colorea los campos edidables
    Private Sub colorPorDefectoTextoBox()
        txtPatologiaNombre.BackColor = Color.White
        cbPatologiaPonderacion.BackColor = Color.White
        txtPatologiaDescipcion.BackColor = Color.White

    End Sub

    Private Sub btnAgregarSintoma_Click(sender As Object, e As EventArgs)
        'agrega sintomas a la lista de sintomas
    End Sub

    Private Sub habilitarAgregarSintomaYSignos()
        'habilita los botons para agregar sintomas y signos
        btnAgregarSigno.Enabled = True
        btnAgregarSintoma.Enabled = True

    End Sub

    Private Sub deshabilitarAgregarSintomaYSignos()
        'deshabilita los botons para agregar sintomas y signos
        btnAgregarSigno.Enabled = False
        btnAgregarSintoma.Enabled = False

    End Sub

    Private Sub limpiarControlesDeFormulario()
        txtPatologiaID.Text = ""
        txtPatologiaNombre.Text = ""
        txtPatologiaDescipcion.Text = ""
        cbPatologiaPonderacion.Text = ""
        dgvSintomasPatologia.Rows.Clear()
        dgvSignosPatologia.Rows.Clear()

    End Sub

    Private Sub dgvListaDePatologias_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListaDePatologias.RowHeaderMouseClick
        opcionesMenu.ClickEnListado(toolsMenuPatologia)
        tabDatosPatologia.SelectTab(tabDatos)
        txtPatologiaID.Text = dgvListaDePatologias.Item(0, e.RowIndex).Value
        txtPatologiaNombre.Text = dgvListaDePatologias.Item(1, e.RowIndex).Value
        txtPatologiaDescipcion.Text = dgvListaDePatologias.Item(3, e.RowIndex).Value
        cbPatologiaPonderacion.Text = dgvListaDePatologias.Item(2, e.RowIndex).Value
        chkActiva.Checked = dgvListaDePatologias.Item(4, e.RowIndex).Value

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAgregarSigno_Click(sender As Object, e As EventArgs) Handles btnAgregarSigno.Click
        'agrega signos a la lista de signos
    End Sub

    Private Sub btnAgregarSintoma_Click_1(sender As Object, e As EventArgs) Handles btnAgregarSintoma.Click
        frmListaSintomas.MdiParent = frmPrincipal
        frmListaSintomas.Show()
    End Sub

    Private Sub cbPatologiaPonderacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPatologiaPonderacion.SelectedIndexChanged

    End Sub

    Private Sub txtPatologiaNombre_TextChanged(sender As Object, e As EventArgs) Handles txtPatologiaNombre.TextChanged

    End Sub

    Private Sub chkActiva_CheckedChanged(sender As Object, e As EventArgs) Handles chkActiva.CheckedChanged

    End Sub
End Class