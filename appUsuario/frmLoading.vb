Imports capaLogica

Public Class frmLoading
    Private Sub frmLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTextos()
        picLoader.Image = My.Resources.loading
    End Sub

    Private Sub lblCancel_Click(sender As Object, e As EventArgs) Handles lblCancel.Click
        Dim respuesta As Integer
        respuesta = MsgBox(VSeguroDeCerrarSesion, vbQuestion & vbYesNo, VAvisoCierreSesion)
        If respuesta = 6 Then
            marcarSolicitudCancelada()
            frmPrincipal.restablecerAPanelDeConsulta()
            Me.Dispose()
        End If
    End Sub

    Private Sub marcarSolicitudCancelada()
        Try
            ControladorSesion.CancelarSesionDeChat(USUARIO, PASSWD)
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VError)
        End Try
    End Sub

    Private Sub cargarTextos()
        lblEsperaMedico.Text = VEsperandoMedico
        lblCancel.Text = VCancelar
    End Sub
End Class