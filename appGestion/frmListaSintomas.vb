Imports capaLogica
Public Class frmListaSintomas
    Private filaDeSintomas As Integer

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub dgvListaSintomas_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListaSintomas.RowHeaderMouseDoubleClick
        'selecciona el renglon donde se hace doble click para agregar a la lista de sintomas de la patologia
        If ControladorPatologias.ValidarIngresoDeSintomaEnPatologia(dgvListaSintomas.Item(0, e.RowIndex).Value, frmPatologia.sintomasDePatologia) = False Then
            frmPatologia.dgvSintomasPatologia.DataSource = ControladorPatologias.AgregarSintomaAPatologia(dgvListaSintomas.Item(0, e.RowIndex).Value, dgvListaSintomas.Item(1, e.RowIndex).Value, frmPatologia.sintomasDePatologia)
            frmPatologia.dgvSintomasPatologia.Columns.Item(0).Visible = False
            Me.Dispose()
        Else
            MsgBox(VElSintomaYaExiste, vbExclamation, VAviso)
        End If
    End Sub

    Private Sub frmListaSintomas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTextos()
        cargarListaSintomas()
    End Sub

    Private Sub cargarListaSintomas()
        Try
            dgvListaSintomas.DataSource = ControladorSintomas.ListarSintomas(USUARIO, PASSWORD)
            dgvListaSintomas.Columns.Item(1).Width = 330
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub txtNombreSintoma_TextChanged(sender As Object, e As EventArgs) Handles txtNombreSintoma.TextChanged
        'Lista los sintomas
        Try
            dgvListaSintomas.DataSource = ControladorSintomas.ListarSintomas(txtNombreSintoma.Text, USUARIO, PASSWORD)
            dgvListaSintomas.Columns.Item(1).Width = 330
            dgvListaSintomas.Columns.Item(2).Visible = False
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub cargarTextos()
        Me.Text = VListaSintomas
        dgvListaSintomas.Columns(1).HeaderText = VSintomas
        btnCerrar.Text = VCerrar
    End Sub
End Class