Imports capaLogica

Public Class frmListaDeSintomas
    Private Sub frmListarSintomas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTextos()
        listarSintomas(1)
    End Sub

    Private Sub mnuBtnSoloActivos_Click(sender As Object, e As EventArgs) Handles mnuBtnSoloActivos.Click
        ListarSintomas(1)
        lblTipo.Text = VSoloActivos
    End Sub

    Private Sub mnuBtnSoloInactivos_Click(sender As Object, e As EventArgs) Handles mnuBtnSoloInactivos.Click
        listarSintomas(0)
        lblTipo.Text = VSoloInactivos
    End Sub

    Private Sub mnuBtnTodos_Click(sender As Object, e As EventArgs) Handles mnuBtnTodos.Click
        ListarTodosLosSintomas()
        lblTipo.Text = VListarTodos
    End Sub

    Private Sub listarSintomas(ByVal estado As Integer)
        Try
            dgvListaDeSintomas.DataSource = ControladorSintomas.ListarSintomas(estado, USUARIO, PASSWORD)
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Public Sub colorearEliminados()
        'Colorea los medicos inactivos
        For i = 0 To dgvListaDeSintomas.Rows.Count - 1
            If dgvListaDeSintomas.Rows.Item(i).Cells("colActivo").Value.ToString = 0 Then
                dgvListaDeSintomas.Rows(i).DefaultCellStyle.BackColor = Color.Red
                dgvListaDeSintomas.Rows(i).DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub dgvListaDeSintomas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaDeSintomas.CellContentClick
        'Carga lista de patologias por sintomas
        If e.ColumnIndex.ToString = 0 Then
            frmListaPatologiasSintomas.ListarPatologias(dgvListaDeSintomas.Item(1, e.RowIndex).Value)
            frmListaPatologiasSintomas.ShowDialog()
        End If
    End Sub

    Private Sub ListarTodosLosSintomas()
        Try
            dgvListaDeSintomas.DataSource = ControladorSintomas.ListarTodosLosSintomas(USUARIO, PASSWORD)
            colorearEliminados()
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub cargarTextos()
        Me.Text = VListaSintomas.ToUpper
        mnuBtnSoloActivos.Text = VSoloActivos
        mnuBtnSoloInactivos.Text = VSoloInactivos
        mnuBtnTodos.Text = VListarTodos
        lblTipo.Text = VSoloActivos
        dgvListaDeSintomas.Columns(1).HeaderText = VNombre
        dgvListaDeSintomas.Columns(2).HeaderText = VPatologias
    End Sub
End Class