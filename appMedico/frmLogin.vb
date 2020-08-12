Imports capaLogica

Public Class frmLogin
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If ControladorValidaciones.validarFormatoDocumento(txtDocumento.Text) And txtPassword.TextLength > 0 Then
            USUARIO = txtDocumento.Text
            PASSWD = "Me." & txtPassword.Text
            validarCredenciales()
        End If
    End Sub

    Private Sub validarCredenciales()
        'Valida las credenciales del medico
        Try
            identificarMedico(ControladorMedico.identificarMedico(USUARIO, PASSWD))
        Catch ex As Exception
            MsgBox("Error de usuario o contraseña, verifica.", vbExclamation, "Error al ingresar")
            txtDocumento.Select()
        End Try
    End Sub

    Private Sub identificarMedico(ByVal datosMedico As DataTable)
        cargarFormulario()
        frmPrincipal.lblNombreMedico.Text = datosMedico.Rows(0)("apellidos")
    End Sub

    Private Sub cargarFormulario()
        frmPrincipal.Show()
        Me.Hide()
    End Sub
End Class