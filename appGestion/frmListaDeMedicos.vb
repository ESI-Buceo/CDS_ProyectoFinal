Imports System.Drawing.Printing
Imports capaLogica

Public Class frmListaDeMedicos

    Private Sub frmListaDeMedicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarListaDeMedicos()
        cargarTextos()
    End Sub

    Private Sub cargarListaDeMedicos()
        'carga lista de medicos activos por defecto
        Try
            dgvListaMedicos.DataSource = ControladorMedico.ListarMedicos(1, USUARIO, PASSWORD)
            lblTipo.Text = VSoloActivos
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub listarMedicosActivos()
        'Filtra de la lista de medicos los activos
        Try
            dgvListaMedicos.DataSource = ControladorMedico.ListarMedicos(1, USUARIO, PASSWORD)
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub listarMedicosInactivos()
        'Filtra de la lista de medicos los inactivos
        Try
            dgvListaMedicos.DataSource = ControladorMedico.ListarMedicos(0, USUARIO, PASSWORD)
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try

    End Sub

    Private Sub listarTodosLosMedicos()
        'Lista todos los medicos
        Try
            dgvListaMedicos.DataSource = ControladorMedico.ListarMedicos(USUARIO, PASSWORD)
            colorearEliminados()
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub mnuBtnSoloInactivos_Click(sender As Object, e As EventArgs) Handles mnuBtnSoloInactivos.Click
        lblTipo.Text = VSoloInactivos
        listarMedicosInactivos()
    End Sub

    Private Sub mnuBtnSoloActivos_Click(sender As Object, e As EventArgs) Handles mnuBtnSoloActivos.Click
        lblTipo.Text = VSoloActivos
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
        lblTipo.Text = VListarTodos
        listarTodosLosMedicos()
    End Sub

    Private Sub dgvListaMedicos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaMedicos.CellContentClick
        'Lista los telefonos del medico
        If e.ColumnIndex.ToString = 0 Then
            mostrarTelefonosDelMedico(e.RowIndex)
        End If
    End Sub

    Private Sub mostrarTelefonosDelMedico(ByVal row As Integer)
        'Muestra los telefonos del medico seleccionado
        Try
            frmListaTelefonos.dgvListaTelefonos.DataSource = ControladorMedico.ListarTelefonos(dgvListaMedicos.Item(1, row).Value, USUARIO, PASSWORD)
            frmListaTelefonos.ShowDialog()
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub cargarTextos()
        Me.Text = VListaDeMedicos
        dgvListaMedicos.Columns("colDocumento").HeaderText = VDocumento
        dgvListaMedicos.Columns("colNDeMedico").HeaderText = VNumeroMedico
        dgvListaMedicos.Columns("colNombres").HeaderText = VNombres
        dgvListaMedicos.Columns("colApellidos").HeaderText = VApellidos
        dgvListaMedicos.Columns("colEmail").HeaderText = VEmail
        dgvListaMedicos.Columns("colTelefonos").HeaderText = VTelefonos
        dgvListaMedicos.Columns("colFechRegistro").HeaderText = VFecha
        dgvListaMedicos.Columns("colActivo").HeaderText = Vactivo
        mnuBtnSoloActivos.Text = VSoloActivos
        mnuBtnSoloInactivos.Text = VSoloInactivos
        mnuBtnTodos.Text = VListarTodos
    End Sub

End Class