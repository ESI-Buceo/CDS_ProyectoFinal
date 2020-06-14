Imports capaLogica
Public Class frmListaSintomas
    Private filaDeSintomas As Integer

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub txtNombreSintoma_TextChanged(sender As Object, e As EventArgs) Handles txtNombreSintoma.TextChanged
    End Sub

    Private Sub dgvListaSintomas_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListaSintomas.RowHeaderMouseDoubleClick
        'selecciona el renglon donde se hace doble click para agregar a la lista de sintomas de la patologia
        frmPatologia.dgvSintomasPatologia.DataSource = ControladorSintomas.agregarSintomaAPatologia(dgvListaSintomas.Item(0, e.RowIndex).Value, dgvListaSintomas.Item(1, e.RowIndex).Value)
        Me.Dispose()

    End Sub

    Private Sub frmListaSintomas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvListaSintomas.DataSource = ControladorSintomas.listarSintomas()
        dgvListaSintomas.Columns.Item(1).Width = 350
    End Sub

    Private Sub dgvListaSintomas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaSintomas.CellContentClick

    End Sub
End Class