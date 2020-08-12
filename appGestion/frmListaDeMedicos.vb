Imports System.Drawing.Printing
Imports capaLogica

Public Class frmListaDeMedicos

    Private Sub frmListaDeMedicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'carga lista de medicos activos por defecto
        Try
            dgvListaMedicos.DataSource = ControladorMedico.ListarMedicos(1, USUARIO, PASSWORD)
            lblTipo.Text = "Solo activos"
        Catch ex As Exception
            MsgBox("Error al cargar lista de medicos", vbCritical, "Error")
        End Try
    End Sub

    Private Sub listarMedicosActivos()
        'Filtra de la lista de medicos los activos
        Try
            dgvListaMedicos.DataSource = ControladorMedico.ListarMedicos(1, USUARIO, PASSWORD)
        Catch ex As Exception
            MsgBox("Error al listar los medicos", vbCritical, "Error")
        End Try
    End Sub

    Private Sub listarMedicosInactivos()
        'Filtra de la lista de medicos los inactivos
        Try
            dgvListaMedicos.DataSource = ControladorMedico.ListarMedicos(0, USUARIO, PASSWORD)
        Catch ex As Exception
            MsgBox("Error al listar los medicos", vbCritical, "Error")
        End Try

    End Sub

    Private Sub listarTodosLosMedicos()
        'Lista todos los medicos
        Try
            dgvListaMedicos.DataSource = ControladorMedico.ListarMedicos(USUARIO, PASSWORD)
            colorearEliminados()
        Catch ex As Exception
            MsgBox("Error al listar los medicos", vbCritical, "Error")
        End Try
    End Sub

    Private Sub mnuBtnSoloInactivos_Click(sender As Object, e As EventArgs) Handles mnuBtnSoloInactivos.Click
        lblTipo.Text = "Solo inactivos"
        listarMedicosInactivos()
    End Sub

    Private Sub mnuBtnSoloActivos_Click(sender As Object, e As EventArgs) Handles mnuBtnSoloActivos.Click
        lblTipo.Text = "Solo activos"
        listarMedicosActivos()
    End Sub

    Public Sub colorearEliminados()
        'Colorea los medicos inactivos
        For i = 0 To dgvListaMedicos.Rows.Count - 1
            If dgvListaMedicos.Rows.Item(i).Cells("colActivo").Value.ToString = 0 Then
                dgvListaMedicos.Rows(i).DefaultCellStyle.BackColor = Color.Red
                dgvListaMedicos.Rows(i).DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub mnuBtnTodos_Click(sender As Object, e As EventArgs) Handles mnuBtnTodos.Click
        lblTipo.Text = "Listar todos"
        listarTodosLosMedicos()
    End Sub

    Private Sub dgvListaMedicos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaMedicos.CellContentClick
        'Lista los telefonos del medico
        If e.ColumnIndex.ToString = 0 Then
            Try
                frmListaTelefonos.dgvListaTelefonos.DataSource = ControladorMedico.ListarTelefonos(dgvListaMedicos.Item(1, e.RowIndex).Value, USUARIO, PASSWORD)
                frmListaTelefonos.ShowDialog()
            Catch ex As Exception
                MsgBox("Error al cargar lista de telefonos")
            End Try
        End If
    End Sub
End Class