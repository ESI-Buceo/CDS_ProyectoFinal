Public Class frmPrincipal
    Private Sub btnIniciarAutenticado_Click(sender As Object, e As EventArgs) Handles btnIniciarAutenticado.Click
        frmLoginRegistrado.ShowDialog()
    End Sub

    Private Sub btnIngresarInvitado_Click(sender As Object, e As EventArgs) Handles btnIngresarInvitado.Click
        frmLoginInvitado.ShowDialog()
    End Sub
End Class