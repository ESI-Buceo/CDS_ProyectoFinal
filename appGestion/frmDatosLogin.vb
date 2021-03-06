﻿Imports capaLogica

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
            validarConexion()
        Else
            MsgBox(VLoginIncorrecto, vbInformation, VErrorAcceso)
        End If
    End Sub

    Private Sub validarConexion()
        'Verifica y valida el archivo de conexion
        Try
            cargarConfiguracion()
        Catch ex As Exception
            MsgBox(VErrorArchivo, vbCritical, VAvisoError)
            End
        End Try
    End Sub

    Private Sub validarCredenciales()
        'Valida las credenciales ingrsadas 
        Try
            cargarAdminitrativo(controladorAdministrativo.ValidarAdministrativo(txtDocIdentidad.Text, txtPassword.Text))
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
        PASSWORD = txtPassword.Text
    End Sub

    Private Sub cargarFormulario()
        frmPrincipal.Show()
        frmLogin.Hide()
        Me.Hide()
    End Sub

    Public Sub cargarTextos()
        lblDocIdentidad.Text = VDocDeIdentidad
        lblPassword.Text = VPassword
        btnGestionIngresar.Text = VIngesar
        lblAyuda.Text = VAyuda
    End Sub

    Private Sub cargarConfiguracion()
        'Lee la configuracion de inicio
        archivoConf = Application.StartupPath & "\config.ini"
        DRIVE = ControladorArchivoIni.leerConfiguracion("Server", "Drive")
        IPSERVER = ControladorArchivoIni.leerConfiguracion("Server", "ip")
        DBASE = ControladorArchivoIni.leerConfiguracion("Server", "dbase")

        If ControladorConfiguracion.cargarConfiguracion(DRIVE, IPSERVER, DBASE) Then
            validarCredenciales()
        Else
            MsgBox(VErrorArchivo, vbCritical, VAvisoError)
            End
        End If
    End Sub

    Private Sub lblAyuda_Click(sender As Object, e As EventArgs) Handles lblAyuda.Click
        Process.Start(Application.StartupPath & "\Triage - Gestión.chm")
    End Sub
End Class