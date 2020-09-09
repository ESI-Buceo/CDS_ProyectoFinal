Imports capaLogica

Public Class frmListaDePacientes
    Private Sub frmListaDePacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTextos()
        listarSoloActivos()
    End Sub

    Private Sub mnuBtnSoloActivos_Click(sender As Object, e As EventArgs) Handles mnuBtnSoloActivos.Click
        listarSoloActivos()
    End Sub

    Private Sub listarSoloActivos()
        'carga lista de pacientes activos
        Try
            dgvListaPacientes.DataSource = controladorPacientes.ListarPacientes(1, USUARIO, PASSWORD)
            lblTipo.Text = VSoloActivos
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub mnuBtnSoloInactivos_Click(sender As Object, e As EventArgs) Handles mnuBtnSoloInactivos.Click
        listarSoloInactivos()
    End Sub

    Private Sub listarSoloInactivos()
        'Carga lista de pacientes inactivos
        Try
            dgvListaPacientes.DataSource = controladorPacientes.ListarPacientes(0, USUARIO, PASSWORD)
            lblTipo.Text = VSoloInactivos
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub mnuBtnTodos_Click(sender As Object, e As EventArgs) Handles mnuBtnTodos.Click
        listarTodos()
    End Sub

    Private Sub listarTodos()
        'Lista todos los pacientes
        Try
            dgvListaPacientes.DataSource = controladorPacientes.ListarPacientes(USUARIO, PASSWORD)
            colorearEliminados()
            lblTipo.Text = VListarTodos
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Public Sub colorearEliminados()
        'Colorea los medicos inactivos
        For i = 0 To dgvListaPacientes.Rows.Count - 1
            If dgvListaPacientes.Rows.Item(i).Cells("colActivo").Value.ToString = 0 Then
                dgvListaPacientes.Rows(i).DefaultCellStyle.BackColor = Color.Red
                dgvListaPacientes.Rows(i).DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub dgvListaPacientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaPacientes.CellContentClick
        'Carga la lisa de telefonos del paciente
        If e.ColumnIndex = 0 Then
            mostrarTelefonosPaciente(e.RowIndex)
        End If
    End Sub

    Private Sub mostrarTelefonosPaciente(ByVal row As Integer)
        'Muestra los telefonos del paciente seleccionado
        Try
            frmListaTelefonos.dgvListaTelefonos.DataSource = controladorPacientes.ListarTelefonos(dgvListaPacientes.Item(1, row).Value, USUARIO, PASSWORD)
            frmListaTelefonos.ShowDialog()
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub cargarTextos()
        Me.Text = VListaPacientes.ToUpper
        mnuBtnSoloActivos.Text = VSoloActivos
        mnuBtnSoloInactivos.Text = VSoloInactivos
        mnuBtnTodos.Text = VListarTodos
        dgvListaPacientes.Columns(0).HeaderText = VDocumento
        dgvListaPacientes.Columns(1).HeaderText = VNombres
        dgvListaPacientes.Columns(2).HeaderText = VApellidos
        dgvListaPacientes.Columns(3).HeaderText = VEmail
        dgvListaPacientes.Columns(4).HeaderText = VTelefonos
        dgvListaPacientes.Columns(5).HeaderText = VFecha
    End Sub

End Class