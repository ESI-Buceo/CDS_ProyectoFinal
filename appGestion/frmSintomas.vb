Imports capaLogica

Public Class frmSintomas

    Private Sub mnuBtnCancelar_Click(sender As Object, e As EventArgs) Handles mnuBtnCancelar.Click
        opcionesMenu.ClickEnBotonCancelar(toolsMenuSintoma)
        tabDatosSintomas.SelectTab(tabDatos)
        colorPorDefectoTextBox()
        limpiarTextBox()
        txtSintomaID.Text = ""
    End Sub

    Private Sub mnuBtnBuscar_Click(sender As Object, e As EventArgs) Handles mnuBtnBuscar.Click
        opcionesMenu.ClickEnBotonBuscar(toolsMenuSintoma)
        tabDatosSintomas.SelectTab(tabBusqueda)
        dgSintomas.DataSource = ControladorSintomas.listarSintomas(UCase(txtSintomaNombre.Text))
        dgSintomas.Columns.Item(1).Width = 350
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
        txtSintomaID.Text = ""
    End Sub

    Private Sub mnuBtnAgregar_Click(sender As Object, e As EventArgs) Handles mnuBtnAgregar.Click
        opcionesMenu.ClickEnBotonAgregar(toolsMenuSintoma)
        limpiarTextBox()
        txtSintomaNombre.Select()
        tabDatosSintomas.SelectTab(tabDatos)
        marcarTextBoxRequeridos()
    End Sub

    Private Sub mnuBtnGuardar_Click(sender As Object, e As EventArgs) Handles mnuBtnGuardar.Click
        opcionesMenu.ClickEnBotonGuardar(toolsMenuSintoma)
        colorPorDefectoTextBox()
        Try
            ControladorSintomas.GuardarSintomas(txtSintomaID.Text, txtSintomaNombre.Text, chkSintomaEstado.CheckState)
            mensajeOk()
        Catch ex As Exception
            mensajeError()
        End Try
        limpiarTextBox()
        txtSintomaID.Text = ""
    End Sub

    Private Sub mnuBtnBorrar_Click(sender As Object, e As EventArgs) Handles mnuBtnBorrar.Click
        Try
            ControladorSintomas.BorrarSintomas(txtSintomaID.Text)
            MessageBox.Show("Registro Eliminado Correctamente!", "Sintoma Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox("Error! ")
        End Try
        limpiarTextBox()
        txtSintomaID.Text = ""
    End Sub

    Private Sub dgSintomas_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgSintomas.RowHeaderMouseClick
        opcionesMenu.ClickEnListado(toolsMenuSintoma)
        tabDatosSintomas.SelectTab(tabDatos)
        txtSintomaID.Text = dgSintomas.Item(0, e.RowIndex).Value
        txtSintomaNombre.Text = dgSintomas.Item(1, e.RowIndex).Value
        chkSintomaEstado.Checked = dgSintomas.Item(2, e.RowIndex).Value
    End Sub

    Private Sub limpiarTextBox()
        txtSintomaNombre.Text = ""
        chkSintomaEstado.CheckState = CheckState.Checked
    End Sub

    Private Sub mensajeError()
        MessageBox.Show("Error : No se pudo guardar" & txtSintomaNombre.Text)

    End Sub

    Private Sub mensajeOk()
        MessageBox.Show("Sintoma : " & txtSintomaNombre.Text & " Ingresado", "Registro Guardado Correctamente!", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub campoVacio()
        MessageBox.Show("Nombre no puede estar vacío!", "Error, Campo  Vacío", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub marcarTextBoxRequeridos()
        txtSintomaNombre.BackColor = Color.Beige
    End Sub

    Private Sub colorPorDefectoTextBox()
        txtSintomaNombre.BackColor = Color.White
    End Sub

    Private Sub chkSintomaEstado_CheckedChanged(sender As Object, e As EventArgs) Handles chkSintomaEstado.CheckedChanged

    End Sub

    Private Sub txtSintomaID_TextChanged(sender As Object, e As EventArgs) Handles txtSintomaID.TextChanged

    End Sub
End Class