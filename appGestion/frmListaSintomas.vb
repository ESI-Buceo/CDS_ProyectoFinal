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
    End Sub



End Class