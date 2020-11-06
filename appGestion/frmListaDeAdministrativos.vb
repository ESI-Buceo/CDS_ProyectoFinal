Imports capaLogica

Public Class frmListaDeAdministrativos
    Private Sub frmListaDeAdministrativos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTextos()
        lblTipo.Text = VSoloActivos
        listarActivos()
    End Sub

    Private Sub listarActivos()
        'Lista solo los administrativos activos
        Try
            dgvListaAdmin.DataSource = controladorAdministrativo.ListarAdministrativos(1, USUARIO, PASSWORD)
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub listarInactivos()
        'lista solo los administrativos inactivos
        Try
            dgvListaAdmin.DataSource = controladorAdministrativo.ListarAdministrativos(0, USUARIO, PASSWORD)
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub listarTodos()
        'lista todos los administrativos
        Try
            dgvListaAdmin.DataSource = controladorAdministrativo.ListarAdministrativos(USUARIO, PASSWORD)
            colorearEliminados()
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Public Sub colorearEliminados()
        'Colorea los medicos inactivos
        For i = 0 To dgvListaAdmin.Rows.Count - 1
            If dgvListaAdmin.Rows.Item(i).Cells("colActivo").Value.ToString = 0 Then
                dgvListaAdmin.Rows(i).DefaultCellStyle.BackColor = Color.Red
                dgvListaAdmin.Rows(i).DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub cargarTextos()
        Me.Text = VListaAdministrativos
        dgvListaAdmin.Columns("colDocumento").HeaderText = VDocumento.ToUpper
        dgvListaAdmin.Columns("colNDeEmpleado").HeaderText = VNEmpleado.ToUpper
        dgvListaAdmin.Columns("colNombres").HeaderText = VNombres.ToUpper
        dgvListaAdmin.Columns("colApellidos").HeaderText = VApellidos.ToUpper
        dgvListaAdmin.Columns("colEmail").HeaderText = VEmail.ToUpper
        dgvListaAdmin.Columns("colTelefonos").HeaderText = VTelefonos.ToUpper
        dgvListaAdmin.Columns("colFechRegistro").HeaderText = VFecha.ToUpper
        dgvListaAdmin.Columns("colActivo").HeaderText = Vactivo.ToUpper
        mnuBtnSoloActivos.Text = VSoloActivos
        mnuBtnSoloInactivos.Text = VSoloInactivos
        mnuBtnTodos.Text = VListarTodos
    End Sub

    Private Sub mnuBtnSoloActivos_Click(sender As Object, e As EventArgs) Handles mnuBtnSoloActivos.Click
        mnuBtnSoloActivos.Text = VSoloActivos
        lblTipo.Text = VSoloActivos
        listarActivos()
    End Sub

    Private Sub mnuBtnSoloInactivos_Click(sender As Object, e As EventArgs) Handles mnuBtnSoloInactivos.Click
        mnuBtnSoloInactivos.Text = VSoloInactivos
        lblTipo.Text = VSoloInactivos
        listarInactivos()
    End Sub

    Private Sub mnuBtnTodos_Click(sender As Object, e As EventArgs) Handles mnuBtnTodos.Click
        mnuBtnTodos.Text = VListarTodos
        lblTipo.Text = VListaAdministrativos
        listarTodos()
    End Sub

    Private Sub dgvListaAdmin_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaAdmin.CellContentClick
        'Lista los telefonos
        If e.ColumnIndex.ToString = 0 Then
            mostrarTelefonosDelMedico(e.RowIndex)
        End If
    End Sub

    Private Sub mostrarTelefonosDelMedico(ByVal row As Integer)
        'Muestra los telefonos del medico seleccionado
        Try
            frmListaTelefonos.dgvListaTelefonos.DataSource = controladorAdministrativo.ListarTelefonos(dgvListaAdmin.Item(1, row).Value, USUARIO, PASSWORD)
            frmListaTelefonos.ShowDialog()
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub
End Class