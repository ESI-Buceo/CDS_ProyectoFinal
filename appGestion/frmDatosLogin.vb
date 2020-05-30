Public Class frmDatosLogin
    Private Sub datosLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
    End Sub

    Private Sub btnGestionIngresar_Click(sender As Object, e As EventArgs) Handles btnGestionIngresar.Click
        frmPrincipal.Show()
        frmLogin.Hide()
        Me.Hide()
    End Sub
End Class