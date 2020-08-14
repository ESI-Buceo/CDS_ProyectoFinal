Imports capaLogica

Public Class frmLogin
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If ControladorValidaciones.ValidarFormatoDocumento(txtDocumento.Text) And txtPassword.TextLength > 0 Then
            validarCredenciales()
        End If
    End Sub

    Private Sub validarCredenciales()
        'Valida las credenciales del medico
        Try
            identificarMedico(ControladorMedico.identificarMedico(txtDocumento.Text, "Me." & txtPassword.Text))
            setearUsuario()
        Catch ex As Exception
            MsgBox("Error de usuario o contraseña, verifica.", vbExclamation, "Error al ingresar")
            txtDocumento.Select()
        End Try
    End Sub

    Private Sub setearUsuario()
        'Carga los datos en las variables globales
        USUARIO = txtDocumento.Text
        PASSWD = "Me." & txtPassword.Text
        cargarFormulario()
    End Sub

    Private Sub identificarMedico(ByVal datosMedico As DataTable)
        frmPrincipal.lblNombreMedico.Text = datosMedico.Rows(0)("apellidos")
    End Sub

    Private Sub cargarFormulario()
        frmPrincipal.Show()
        Me.Hide()
    End Sub
End Class