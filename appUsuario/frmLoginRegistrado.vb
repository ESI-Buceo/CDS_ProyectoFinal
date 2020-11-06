Imports capaLogica

Public Class frmLoginRegistrado
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If ControladorValidaciones.ValidarFormatoDocumento(txtDocumento.Text) And txtDocumento.Text > 0 Then
            validarConexion()
        End If
    End Sub

    Private Sub validarConexion()
        Try
            cargarConfiguracion()
        Catch ex As Exception
            MsgBox(VErrorArchivo, vbCritical, VError)
            End
        End Try
    End Sub

    Private Sub validarCredenciales()
        'Valida los datos ingresados
        Try
            identificarPaciente(controladorPacientes.identificarPaciente(txtDocumento.Text, txtPassword.Text))
            setearUsuario()
        Catch ex As Exception
            MsgBox(VErrorDatosAcceso, vbExclamation, VErrorAcceso)
            txtDocumento.Select()
        End Try
    End Sub

    Private Sub setearUsuario()
        'Carga los datos en variables globales
        USUARIO = txtDocumento.Text
        PASSWD = txtPassword.Text
        validarRecordarDatos()
        Me.Hide()
        cargarInformacionPaciente()
    End Sub

    Private Sub cargarInformacionPaciente()
        frmPrincipal.TraerDiagnosticos()
        frmPrincipal.TraerRegistroDeChat()
        frmPrincipal.CargarDatosDePaciente()
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
        frmPrincipal.Refresh()
    End Sub

    Private Sub cargarTextos()
        Me.Text = VIngresoAlSistema
        lblDocumento.Text = VDocumentoIdentidad
        lblPassword.Text = VPassword
        btnIngresar.Text = VIngresar
        chkRecordar.Text = VRecordarMisDatos
        lblLinkAyuda.Text = VAyuda
    End Sub

    Private Sub frmLoginRegistrado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarIdioma()
        cargarDatosUsuario()
        cargarTextos()
    End Sub

    Private Sub cargarDatosUsuario()
        txtDocumento.Text = My.Settings.user
        txtPassword.Text = My.Settings.pass
        chkRecordar.CheckState = My.Settings.remeber
    End Sub

    Private Sub validarRecordarDatos()
        If chkRecordar.CheckState Then
            recordarDatos()
        Else
            noRecordarDatos()
        End If
    End Sub

    Private Sub recordarDatos()
        My.Settings.user = txtDocumento.Text
        My.Settings.pass = txtPassword.Text
        My.Settings.remeber = chkRecordar.CheckState
        My.Settings.Save()
    End Sub

    Private Sub noRecordarDatos()
        My.Settings.user = ""
        My.Settings.pass = ""
        My.Settings.remeber = chkRecordar.CheckState
        My.Settings.Save()
    End Sub

    Private Sub cargarConfiguracion()
        'Carga la informacion de conexion
        archivoConf = Application.StartupPath & "\config.ini"
        DRIVE = ControladorArchivoIni.leerConfiguracion("Server", "Drive")
        IPSERVER = ControladorArchivoIni.leerConfiguracion("Server", "ip")
        DBASE = ControladorArchivoIni.leerConfiguracion("Server", "dbase")

        If ControladorConfiguracion.cargarConfiguracion(DRIVE, IPSERVER, DBASE) Then
            validarCredenciales()
        Else
            MsgBox(VErrorArchivo, vbCritical, VError)
            End
        End If
    End Sub

    Private Sub lblLinkAyuda_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblLinkAyuda.LinkClicked
        Process.Start(Application.StartupPath & "\Triage - Paciente.chm")
    End Sub
End Class