Imports capaLogica

Public Class frmListaDePatologias
    Private Sub frmListaDePatologias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Carga de forma predeterminada las patologias activas
        Try
            cargarGridPatologias(ControladorPatologias.ListaDePatologias(1, USUARIO, PASSWORD))
        Catch ex As Exception
            MsgBox("Error al listar patologias", vbCritical, "Error")
        End Try
    End Sub

    Private Sub mnuBtnSoloActivos_Click(sender As Object, e As EventArgs) Handles mnuBtnSoloActivos.Click
        'Muestra solo los casos activos
        Try
            cargarGridPatologias(ControladorPatologias.ListaDePatologias(1, USUARIO, PASSWORD))
            lblTipo.Text = "Solo activas"
        Catch ex As Exception
            MsgBox("Error al listar patologias", vbCritical, "Error")
        End Try
    End Sub

    Private Sub mnuBtnSoloInactivos_Click(sender As Object, e As EventArgs) Handles mnuBtnSoloInactivos.Click
        'Muestra patologias inactivas
        Try
            cargarGridPatologias(ControladorPatologias.ListaDePatologias(0, USUARIO, PASSWORD))
            lblTipo.Text = "Solo inactivas"
        Catch ex As Exception
            MsgBox("Error al listar patologias", vbCritical, "Error")
        End Try
    End Sub

    Private Sub mnuBtnTodos_Click(sender As Object, e As EventArgs) Handles mnuBtnTodos.Click
        'Muestra todas las patologias
        Try
            lblTipo.Text = "Todas las patologias"
            cargarGridPatologias(ControladorPatologias.ListaDePatologias(USUARIO, PASSWORD))
            colorearEliminados()
        Catch ex As Exception
            MsgBox("Error al listar patologias", vbCritical, "Error")
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
        'Carga lista de sintomas por patologias
        If e.ColumnIndex.ToString = 0 Then
            Try
                frmListaSintomasPatologia.listaSintomas(ControladorSintomas.ListarSintomasDePatologia(dgvListaPatologias.Item(1, e.RowIndex).Value, USUARIO, PASSWORD))
                frmListaSintomasPatologia.ShowDialog()
            Catch ex As Exception
                MsgBox("Error al cargar lista de sintomas")
            End Try
        End If
    End Sub
End Class