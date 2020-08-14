Imports capaLogica

Public Class frmLoginRegistrado
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If ControladorValidaciones.ValidarFormatoDocumento(txtDocumento.Text) And txtDocumento.Text > 0 Then
            validarCredenciales()
        End If
    End Sub

    Private Sub validarCredenciales()
        'Valida los datos ingresados
        Try
            identificarPaciente(controladorPacientes.identificarPaciente(txtDocumento.Text, "Pa." + txtPassword.Text))
            setearUsuario()
        Catch ex As Exception
            MsgBox("Error de usuario o contraseña, verifica.", vbExclamation, "Error al ingresar")
            txtDocumento.Select()
        End Try
    End Sub

    Private Sub setearUsuario()
        'Carga los datos en variables globales
        USUARIO = txtDocumento.Text
        PASSWD = "Pa." & txtPassword.Text
        Me.Hide()
    End Sub

    Private Sub identificarPaciente(ByVal datos As DataTable)
        'Identifica al paciente
        cargarFormularios()
        frmPrincipal.lblPacienteNombre.Text = datos.Rows(0)("nombres")
    End Sub

    Private Sub cargarFormularios()
        frmPrincipal.panelCabecera.Visible = True
        frmPrincipal.PanelDeConsulta.Visible = True
        frmPrincipal.panelActivo = frmPrincipal.PanelDeConsulta
    End Sub


End Class