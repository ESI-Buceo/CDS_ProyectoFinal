Imports capaLogica

Public Class frmLoginRegistrado
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        USUARIO = txtDocumento.Text
        PASSWD = "Pa." & txtPassword.Text
        validarCredenciales()
    End Sub

    Private Sub validarCredenciales()
        'Valida los datos ingresados
        Try
            identificarPaciente(controladorPacientes.identificarPaciente(USUARIO, PASSWD))
            Me.Hide()
        Catch ex As Exception
            MsgBox("Error de usuario o contraseña, verifica.", vbExclamation, "Error al ingresar")
            txtDocumento.Select()
        End Try
    End Sub

    Private Sub cargarFormularios()
        frmPrincipal.panelCabecera.Visible = True
        frmPrincipal.PanelDeConsulta.Visible = True
        frmPrincipal.panelActivo = frmPrincipal.PanelDeConsulta
    End Sub

    Private Sub identificarPaciente(ByVal datos As DataTable)
        'Identifica al paciente
        cargarFormularios()
        frmPrincipal.lblPacienteNombre.Text = datos.Rows(0)("nombres")
    End Sub
End Class