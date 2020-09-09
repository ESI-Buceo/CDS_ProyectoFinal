Imports capaLogica

Public Class frmDatosLogin
    Private Sub datosLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarIdioma()
        cargarTextos()
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
    End Sub

    Private Sub btnGestionIngresar_Click(sender As Object, e As EventArgs) Handles btnGestionIngresar.Click
        'Accion que valida los datos ingresados
        If ControladorValidaciones.ValidarFormatoDocumento(txtDocIdentidad.Text) And txtDocIdentidad.Text.Length > 0 Then
            validarCredenciales()
        End If
    End Sub

    Private Sub validarCredenciales()
        'Valida las credenciales ingrsadas 
        Try
            cargarAdminitrativo(controladorAdministrativo.ValidarAdministrativo(txtDocIdentidad.Text, "Ge." + txtPassword.Text))
            setearUsuario()
        Catch ex As Exception
            MsgBox(VLoginIncorrecto, vbInformation, VErrorAcceso)
        End Try

    End Sub

    Private Sub cargarAdminitrativo(ByVal datosAdministrativo As DataTable)
        cargarFormulario()
        frmPrincipal.tssLabelGestor.Text = datosAdministrativo.Rows(0)("apellidos") + ", " + datosAdministrativo.Rows(0)("nombres")
    End Sub

    Private Sub setearUsuario()
        USUARIO = txtDocIdentidad.Text
        PASSWORD = "Ge." & txtPassword.Text
    End Sub

    Private Sub cargarFormulario()
        frmPrincipal.Show()
        frmLogin.Hide()
        Me.Hide()
    End Sub

    Private Sub cargarTextos()
        lblDocIdentidad.Text = VDocDeIdentidad
        lblPassword.Text = VPassword
        btnGestionIngresar.Text = VIngesar
    End Sub
End Class