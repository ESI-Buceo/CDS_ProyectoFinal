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
            MsgBox("El sintoma ya existe", vbExclamation, "AVISO")
        End If
    End Sub

    Private Sub frmListaSintomas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvListaSintomas.DataSource = ControladorSintomas.ListarSintomas()
        dgvListaSintomas.Columns.Item(1).Width = 350
    End Sub

End Class