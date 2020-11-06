Imports capaLogica

Public Class frmListaDePatologias
    Private Sub frmListaDePatologias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTextos()
        ListarPatologias()
    End Sub

    Private Sub listarPatologias()
        'Carga de forma predeterminada las patologias activas
        listarSoloActivos()
    End Sub

    Private Sub mnuBtnSoloActivos_Click(sender As Object, e As EventArgs) Handles mnuBtnSoloActivos.Click
        listarSoloActivos()
    End Sub

    Private Sub listarSoloActivos()
        'Muestra solo los casos activos
        Try
            cargarGridPatologias(ControladorPatologias.ListaDePatologias("1", USUARIO, PASSWORD))
            lblTipo.Text = VSoloActivos
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub mnuBtnSoloInactivos_Click(sender As Object, e As EventArgs) Handles mnuBtnSoloInactivos.Click
        listarSoloInactivos()
    End Sub

    Private Sub listarSoloInactivos()
        'Muestra patologias inactivas
        Try
            cargarGridPatologias(ControladorPatologias.ListaDePatologias("0", USUARIO, PASSWORD))
            lblTipo.Text = VSoloInactivos
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub mnuBtnTodos_Click(sender As Object, e As EventArgs) Handles mnuBtnTodos.Click
        listarTodos()
    End Sub

    Private Sub listarTodos()
        'Muestra todas las patologias
        Try
            lblTipo.Text = VListarTodos
            cargarGridPatologias(ControladorPatologias.ListaDePatologias(USUARIO, PASSWORD))
            colorearEliminados()
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub cargarGridPatologias(ByVal datos As DataTable)
        'Carga la infrormacion en el datagrid
        dgvListaPatologias.DataSource = datos
    End Sub

    Public Sub colorearEliminados()
        'Colorea los medicos inactivos
        For i = 0 To dgvListaPatologias.Rows.Count - 1
            If dgvListaPatologias.Rows.Item(i).Cells("colActivo").Value.ToString = 0 Then
                dgvListaPatologias.Rows(i).DefaultCellStyle.BackColor = Color.Red
                dgvListaPatologias.Rows(i).DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub dgvListaPatologias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaPatologias.CellContentClick
        If e.ColumnIndex.ToString = 0 Then
            listarSintomasDeLaPatologia(e.RowIndex)
        End If
    End Sub

    Private Sub listarSintomasDeLaPatologia(ByVal row As Integer)
        'lista los sintomas de la patologia
        Try
            frmListaSintomasPatologia.listaSintomas(ControladorSintomas.ListarSintomasDePatologia(dgvListaPatologias.Item(1, row).Value, USUARIO, PASSWORD))
            frmListaSintomasPatologia.ShowDialog()
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub cargarTextos()
        Me.Text = VListaPatologias.ToUpper
        mnuBtnSoloActivos.Text = VSoloActivos
        mnuBtnSoloInactivos.Text = VSoloInactivos
        mnuBtnTodos.Text = VSoloActivos
        lblTipo.Text = VSoloActivos
        dgvListaPatologias.Columns(1).HeaderText = VNombre
        dgvListaPatologias.Columns(2).HeaderText = VPonderacion
        dgvListaPatologias.Columns(3).HeaderText = VSintomas
        dgvListaPatologias.Columns(4).HeaderText = Vactivo
    End Sub
End Class