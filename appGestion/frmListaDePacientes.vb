Imports capaLogica

Public Class frmListaDePacientes
    Private Sub frmListaDePacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'carga lista de pacientes activos por defecto
        Try
            dgvListaPacientes.DataSource = controladorPacientes.ListarPacientes(1, USUARIO, PASSWORD)
            lblTipo.Text = "Solo activos"
        Catch ex As Exception
            MsgBox("Error al listar pacientes", vbCritical, "Error")
        End Try
    End Sub

    Private Sub mnuBtnSoloActivos_Click(sender As Object, e As EventArgs) Handles mnuBtnSoloActivos.Click
        'carga lista de pacientes activos
        Try
            dgvListaPacientes.DataSource = controladorPacientes.ListarPacientes(1, USUARIO, PASSWORD)
            lblTipo.Text = "Solo activos"
        Catch ex As Exception
            MsgBox("Error al listar pacientes", vbCritical, "Error")
        End Try
    End Sub

    Private Sub mnuBtnSoloInactivos_Click(sender As Object, e As EventArgs) Handles mnuBtnSoloInactivos.Click
        'Carga lista de pacientes inactivos
        Try
            dgvListaPacientes.DataSource = controladorPacientes.ListarPacientes(0, USUARIO, PASSWORD)
            lblTipo.Text = "Solo inactivos"
        Catch ex As Exception
            MsgBox("Error al listar pacientes", vbCritical, "Error")
        End Try
    End Sub

    Private Sub mnuBtnTodos_Click(sender As Object, e As EventArgs) Handles mnuBtnTodos.Click
        Try
            dgvListaPacientes.DataSource = controladorPacientes.ListarPacientes(USUARIO, PASSWORD)
            colorearEliminados()
            lblTipo.Text = "Todos los pacientes"
        Catch ex As Exception
            MsgBox("Error al listar pacientes", vbCritical, "Error")
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
        If e.ColumnIndex.ToString = 0 Then
            Try
                frmListaTelefonos.dgvListaTelefonos.DataSource = controladorPacientes.ListarTelefonos(dgvListaPacientes.Item(1, e.RowIndex).Value, USUARIO, PASSWORD)
                frmListaTelefonos.ShowDialog()
            Catch ex As Exception
                MsgBox("Error al cargar lista de telefonos")
            End Try
        End If
    End Sub
End Class