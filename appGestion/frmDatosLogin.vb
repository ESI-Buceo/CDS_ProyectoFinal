Imports capaLogica

Public Class frmDatosLogin
    Private Sub datosLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
    End Sub

    Private Sub btnGestionIngresar_Click(sender As Object, e As EventArgs) Handles btnGestionIngresar.Click
        Try
            cargarAdminitrativo(controladorAdministrativo.ValidarAdministrativo(txtDocIdentidad.Text, "Ge." + txtPassword.Text))
            frmPrincipal.Show()
            frmLogin.Hide()
            Me.Hide()
            cargarCredenciales(txtDocIdentidad.Text, "Ge." + txtPassword.Text)
        Catch ex As Exception
            MsgBox("Documento de identidad o contraseña incorrectos, verifica", vbInformation, "Error de Acceso")
        End Try
    End Sub

    Private Sub cargarAdminitrativo(ByVal datosAdministrativo As DataTable)
        frmPrincipal.tssLabelGestor.Text = datosAdministrativo.Rows(0)("apellidos") + ", " + datosAdministrativo.Rows(0)("nombres")
    End Sub

    Private Sub cargarCredenciales(ByVal uid As String, pwd As String)
        USUARIO = uid
        PASSWORD = pwd
    End Sub
End Class