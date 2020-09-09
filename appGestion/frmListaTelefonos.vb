Public Class frmListaTelefonos
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub frmListaTelefonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvListaTelefonos.Columns(0).HeaderText = VTelefonos
        btnCerrar.Text = VCerrar
    End Sub
End Class