Imports capaLogica

Public Class frmDatosLogin
    Private Sub datosLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
    End Sub

    Private Sub btnGestionIngresar_Click(sender As Object, e As EventArgs) Handles btnGestionIngresar.Click

        If ControladorValidaciones.ValidarFormatoDocumento(txtDocIdentidad.Text) And txtDocIdentidad.Text > 0 Then
            validarCredenciales()
        End If
    End Sub

    Private Sub validarCredenciales()
        'Valida las credenciales ingrsadas 
        Try
            cargarAdminitrativo(controladorAdministrativo.ValidarAdministrativo(txtDocIdentidad.Text, "Ge." + txtPassword.Text))
            setearUsuario()
        Catch ex As Exception
            MsgBox("Documento de identidad o contraseña incorrectos, verifica", vbInformation, "Error de Acceso")
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
End Class