Imports capaLogica

Public Class frmCambiarPass
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If ControladorValidaciones.ValidarPassYRePass(txtPass.Text, txtRePass.Text) Then
            cambiarPassword(txtPass.Text)
        End If
    End Sub

    Private Sub cambiarPassword(ByVal pass As String)
        Try
            ControladorPersona.CambiarPassword(USUARIO, pass, ControladorConfiguracion.leerRangoIpGestion(USUARIO, PASSWORD), USUARIO, PASSWORD)
            MsgBox(VCambioPassSuccess, vbInformation, VCambiarPassword)
            PASSWORD = txtPass.Text
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(VCambioPassFailed, vbCritical, VCambiarPassword)
        End Try
    End Sub

    Private Sub frmCambiarPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTextos()
    End Sub

    Private Sub cargarTextos()
        Me.Text = VCambiarPassword
        lblNuevoPass.Text = VNuevoPassword
        lblRePass.Text = VReEscribeNuevoPassword
        btnConfirmar.Text = VConfirmar
    End Sub
End Class