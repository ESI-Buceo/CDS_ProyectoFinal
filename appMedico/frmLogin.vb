﻿Imports capaLogica

Public Class frmLogin
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If ControladorValidaciones.ValidarFormatoDocumento(txtDocumento.Text) And txtPassword.TextLength > 0 Then
            validarConexion()
        End If
    End Sub

    Private Sub validarConexion()
        'Verifica y valida el archivo de conexion
        Try
            cargarConfiguracion()
        Catch ex As Exception
            MsgBox(VErrorVerificarEstadoSesion, vbCritical, VErrorVerificarEstadoSesion)
            End
        End Try
    End Sub

    Private Sub validarCredenciales()
        'Valida las credenciales del medico
        Try
            identificarMedico(ControladorMedico.identificarMedico(txtDocumento.Text, txtPassword.Text))
            setearUsuario()
        Catch ex As Exception
            MsgBox(VErrorDeLogin, vbExclamation, VErrorAcceso)
            txtDocumento.Select()
        End Try
    End Sub

    Private Sub setearUsuario()
        'Carga los datos en las variables globales
        USUARIO = txtDocumento.Text
        PASSWD = txtPassword.Text
        recordarDatos()
        cargarFormulario()
    End Sub

    Private Sub identificarMedico(ByVal datosMedico As DataTable)
        frmPrincipal.lblNombreMedico.Text = datosMedico.Rows(0)("apellidos")
    End Sub

    Private Sub cargarFormulario()
        frmPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarIdioma()
        cargarTextos()
        txtDocumento.Text = My.Settings.user
        txtPassword.Text = My.Settings.pass
        chkRecordar.CheckState = My.Settings.recordar
    End Sub

    Private Sub recordarDatos()
        If chkRecordar.CheckState Then
            My.Settings.user = txtDocumento.Text
            My.Settings.pass = txtPassword.Text
            My.Settings.recordar = chkRecordar.CheckState
        Else
            My.Settings.user = ""
            My.Settings.pass = ""
            My.Settings.recordar = 0
        End If
        My.Settings.Save()
    End Sub

    Private Sub cargarTextos()
        Me.Text = VIngresoAlSistema.ToUpper
        lblBienvenido.Text = VBienvenido
        lblLeyenda.Text = VLeyendaLogin
        lblDocumento.Text = VDocumento
        lblPassword.Text = VPassword
        chkRecordar.Text = VRecordarMisDatos
        btnIngresar.Text = VIngresar
    End Sub

    Private Sub cargarConfiguracion()
        archivoConf = Application.StartupPath & "\config.ini"
        DRIVE = ControladorArchivoIni.leerConfiguracion("Server", "Drive")
        IPSERVER = ControladorArchivoIni.leerConfiguracion("Server", "ip")
        DBASE = ControladorArchivoIni.leerConfiguracion("Server", "dbase")

        If ControladorConfiguracion.cargarConfiguracion(DRIVE, IPSERVER, DBASE) Then
            validarCredenciales()
        Else
            MsgBox(VErrorLeerArchivoConfiguracion, vbCritical, VError)
            End
        End If
    End Sub

    Private Sub picEs_Click(sender As Object, e As EventArgs) Handles picEs.Click
        seleccionDeIdioma("es")
    End Sub

    Private Sub seleccionDeIdioma(ByVal idioma As String)
        'Establece el idioma para la aplicacion
        EstablecerIdioma(idioma)
        cargarIdioma()
        cargarTextos()
    End Sub

    Private Sub picEn_Click(sender As Object, e As EventArgs) Handles picEn.Click
        seleccionDeIdioma("en")
    End Sub

    Private Sub lblAyuda_Click(sender As Object, e As EventArgs) Handles lblAyuda.Click
        Process.Start(Application.StartupPath & "\Triage - medico.chm")
    End Sub
End Class