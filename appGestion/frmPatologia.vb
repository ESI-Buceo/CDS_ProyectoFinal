Imports capaLogica
Public Class frmPatologia

    Private Sub mnuBtnAgregar_Click(sender As Object, e As EventArgs) Handles mnuBtnAgregar.Click
        opcionesMenu.ClickEnBotonAgregar(toolsMenuPatologia)
        limpiarControlesDeFormulario()
        txtPatologiaID.Text = 0
        habilitarAgregarSintomaYSignos()
        txtPatologiaNombre.Select()
        colorearCamposRqueridos()
        ControladorPatologias.crearDataTableSintomasXPatologia()

    End Sub

    'Guarda los datos de la patologia
    Private Sub mnuBtnGuardar_Click(sender As Object, e As EventArgs) Handles mnuBtnGuardar.Click
        opcionesMenu.ClickEnBotonGuardar(toolsMenuPatologia)
        colorPorDefectoTextoBox()
        deshabilitarAgregarSintomaYSignos()
        limpiarControlesDeFormulario()

        Try
            ControladorPatologias.AltaPatologia(txtPatologiaID.Text, txtPatologiaNombre.Text, cbPatologiaPonderacion.Text, txtPatologiaDescipcion.Text, chkActiva.CheckState, dgvSintomasPatologia)
            MsgBox("Dato guardado correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub mnuBtnCancelar_Click(sender As Object, e As EventArgs) Handles mnuBtnCancelar.Click
        opcionesMenu.ClickEnBotonCancelar(toolsMenuPatologia)
        tabDatosPatologia.SelectTab(tabDatos)
        colorPorDefectoTextoBox()
        deshabilitarAgregarSintomaYSignos()
        limpiarControlesDeFormulario()
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
        txtPatologiaNombre.Select()
        colorearCamposRqueridos()
        habilitarAgregarSintomaYSignos()
    End Sub


    Private Sub mnuBtnBorrar_Click(sender As Object, e As EventArgs) Handles mnuBtnBorrar.Click
        opcionesMenu.ClickEnBotonBorrar(toolsMenuPatologia)
        limpiarControlesDeFormulario()

        Try
            ControladorPatologias.BorrarPatologia(txtPatologiaID.Text)
            MsgBox("Patología eliminada con exito")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
        txtPatologiaID.Text = "0"
        txtPatologiaNombre.Text = ""
        txtPatologiaDescipcion.Text = ""
        cbPatologiaPonderacion.Text = ""
        dgvSintomasPatologia.DataSource = ""
        dgvSignosPatologia.DataSource = ""
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
        dgvSintomasPatologia.DataSource = ControladorPatologias.cargarSintomaPorPatologia(txtPatologiaID.Text)
        dgvSintomasPatologia.Columns(0).Visible = False
        dgvSintomasPatologia.Columns(1).Width = 150
    End Sub


    Private Sub btnAgregarSigno_Click(sender As Object, e As EventArgs) Handles btnAgregarSigno.Click
        'agrega signos a la lista de signos
    End Sub


    Private Sub btnAgregarSintoma_Click_1(sender As Object, e As EventArgs) Handles btnAgregarSintoma.Click
        frmListaSintomas.MdiParent = frmPrincipal
        frmListaSintomas.Show()
    End Sub


End Class