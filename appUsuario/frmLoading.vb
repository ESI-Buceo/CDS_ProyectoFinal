Public Class frmLoading
    Private Sub frmLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picLoader.Image = My.Resources.loading
    End Sub

    Private Sub lblCancel_Click(sender As Object, e As EventArgs) Handles lblCancel.Click
        Dim respuesta As Integer
        respuesta = MsgBox("Seguro de cancelar la solicitud de chat?", vbQuestion & vbYesNo, "Cancelar Sesion")
        If respuesta = 6 Then
            frmPrincipal.restablecerAPanelDeConsulta()
            Me.Dispose()
        End If
    End Sub
End Class