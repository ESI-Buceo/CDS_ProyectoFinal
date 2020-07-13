Imports capaLogica
Public Class frmPrincipal
    Dim panelActivo As Panel
    Public ListaSintomasSeleccionados As New List(Of Integer)
    Public sintomaSeleccionado As Boolean = False

    Private Sub btnIniciarAutenticado_Click(sender As Object, e As EventArgs) Handles btnIniciarAutenticado.Click
        frmLoginRegistrado.ShowDialog()
    End Sub

    Private Sub btnIngresarInvitado_Click(sender As Object, e As EventArgs) Handles btnIngresarInvitado.Click
        frmLoginInvitado.ShowDialog()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelActivo = PanelDeConsulta
    End Sub

    Private Sub btnHistoria_Click(sender As Object, e As EventArgs) Handles btnHistoria.Click
        cambiarPanel(PanelDeConsulta)
        clickBotonHistoria()
    End Sub

    Private Sub btnChat_Click(sender As Object, e As EventArgs) Handles btnChat.Click
        'cambiarPanel(panelDeChat)
        clickBotonChat()
    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        cambiarPanel(PanelDeConsulta)
        clicBotonConsulta()
    End Sub

    Private Sub cambiarPanel(ByRef panel As Panel)
        panelActivo.Visible = False
        panelActivo = panel
        panelActivo.Visible = True
    End Sub

    Private Sub btnComenzar_Click(sender As Object, e As EventArgs) Handles btnComenzar.Click
        iniciarConsulta()
    End Sub

    Private Sub txtSintoma_GotFocus(sender As Object, e As EventArgs) Handles txtSintoma.GotFocus
        txtSintoma.Text = ""
        txtSintoma.ForeColor = Color.Gray
    End Sub

    Private Sub btnSiguienteSintoma_Click(sender As Object, e As EventArgs) Handles btnSiguienteSintoma.Click
        If sintomaSeleccionado Then
            opcionIngresarMasSintomas()
        Else
            frmListaSintomas.ShowDialog()
        End If
    End Sub

    Private Sub opcionIngresarMasSintomas()
        If ListaSintomasSeleccionados.Count > 1 Then
            lblPregunta.Text = "Deseas ingresar un nuevo sintoma?"
            preguntarPorNuevoSintoma()
        Else
            nuevaPregunta()
        End If
    End Sub

    Private Sub nuevaPregunta()
        lblPregunta.Text = ControladorDiagnostico.NuevoMensaje()
        txtSintoma.Select()
        sintomaSeleccionado = False
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        lblPregunta.Width = 370
        lblPregunta.Height = 200
        lblPregunta.AutoSize = False
        lblPregunta.Text = "Presiona Ver Informe para que podamos generarte un diagnostico de acuerdo a los sintomas que has ingresado. No dejes de consultara tu medico via chat, recuerda que este diagnostico no sustituye la consulta a un profesional."
        panelBotonSiNo.Visible = False
        btnVerInforme.Visible = True
    End Sub

    Private Sub btnSi_Click(sender As Object, e As EventArgs) Handles btnSi.Click
        seguirIngresandoSintomas()
        nuevaPregunta()
    End Sub

    Private Sub preguntarPorNuevoSintoma()
        panelBotonSiNo.Visible = True
        txtSintoma.Visible = False
        lblLine.Visible = False
        btnSiguienteSintoma.Visible = False
    End Sub

    Private Sub seguirIngresandoSintomas()
        panelBotonSiNo.Visible = False
        txtSintoma.Visible = True
        lblLine.Visible = True
        btnSiguienteSintoma.Visible = True
    End Sub

    Private Sub linkSaberMas_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkSaberMas.LinkClicked
        frmSobreElCliente.ShowDialog()
    End Sub

    Private Sub btnNuevaConsulta_Click(sender As Object, e As EventArgs) Handles btnNuevaConsulta.Click
        iniciarConsulta()
    End Sub

    Private Sub btnVerInforme_Click_1(sender As Object, e As EventArgs) Handles btnVerInforme.Click
        mensajeDeEsperaProcesoDeDiagnostico()
    End Sub

    Private Sub mensajeDeEsperaProcesoDeDiagnostico()
        lblPregunta.Text = "Aguarda mientras preparamos tu informe..."
        btnVerInforme.Visible = False
        Me.Refresh()
        crearInformeDiagnostico()
    End Sub

    Private Sub crearInformeDiagnostico()
        'Evalua resultado informe de diagnostico
        Dim patologiasParaDiagnostico As New DataTable
        patologiasParaDiagnostico = ControladorDiagnostico.CrearInformeDiagnostico(ListaSintomasSeleccionados)
        If patologiasParaDiagnostico.Rows.Count = 0 Then
            lblPregunta.Text = "No existen patologias con los sintomas que has ingresado !"
            btnVerInforme.Visible = False
            btnNuevaConsulta.Visible = True
            Me.Refresh()
        Else
            mostrarInformeDiagnostico(patologiasParaDiagnostico)
        End If
    End Sub

    Private Sub mostrarInformeDiagnostico(ByRef patologiaParaDiagnostico As DataTable)
        'Muestra el informe de diagostico
        Try
            lblPregunta.Text = "Hemos preparado el siguiente informe para ti de acuerdo a los sintomas que has ingresado. Por favor inicia una conversacion por chat con el medico."
            flPanelDiagnostico.Visible = True
            For Each patologias As DataRow In patologiaParaDiagnostico.Rows
                Dim panel As New PanelPatologia With {.nombre = patologias("nombre"), .descipcion = patologias("descripcion")}
                flPanelDiagnostico.Controls.Add(panel.CrearPanelPatologia)
            Next
            botonesMostrarDiagnostico()
        Catch ex As Exception
            MsgBox("Se genero un error y no se genero el informe de diagnostico")
        End Try
    End Sub

    Private Sub botonesMostrarDiagnostico()
        btnVerInforme.Visible = False
        btnNuevaConsulta.Visible = True
        'btnIniciarChat.Visible = True
    End Sub

    Private Sub clicBotonConsulta()
        PanelDeConsulta.Visible = True
        btnConsulta.Image = My.Resources.btnConsultaSelect
        btnChat.Image = My.Resources.btnChat
        btnHistoria.Image = My.Resources.btnReloj
        btnConsulta.ForeColor = Color.FromArgb(44, 55, 137)
        btnChat.ForeColor = Color.FromArgb(127, 127, 127)
        btnHistoria.ForeColor = Color.FromArgb(127, 127, 127)
    End Sub

    Private Sub clickBotonChat()
        btnChat.Image = My.Resources.btnChatSelect
        btnHistoria.Image = My.Resources.btnReloj
        btnConsulta.Image = My.Resources.btnConsulta
        btnChat.ForeColor = Color.FromArgb(44, 55, 137)
        btnConsulta.ForeColor = Color.FromArgb(127, 127, 127)
        btnHistoria.ForeColor = Color.FromArgb(127, 127, 127)
    End Sub

    Private Sub clickBotonHistoria()
        btnHistoria.Image = My.Resources.btnRelojSelect
        btnChat.Image = My.Resources.btnChat
        btnConsulta.Image = My.Resources.btnConsulta
        btnHistoria.ForeColor = Color.FromArgb(44, 55, 137)
        btnChat.ForeColor = Color.FromArgb(127, 127, 127)
        btnConsulta.ForeColor = Color.FromArgb(127, 127, 127)
    End Sub

    Private Sub iniciarConsulta()
        lblPregunta.Text = "Cuentanos cual es tu princial malestar...?"
        panelDeSintomas.Visible = True
        flPanelDiagnostico.Visible = False
        lblMensaje.Visible = False
        btnComenzar.Visible = False
        lblPregunta.Visible = True
        btnSiguienteSintoma.Visible = True
        txtSintoma.Visible = True
        btnNuevaConsulta.Visible = False
        lblLine.Visible = True
        sintomaSeleccionado = False
        flPanelDiagnostico.Controls.Clear()
        PanelPatologia.id = 0
        txtSintoma.Select()
        ListaSintomasSeleccionados.Clear()
    End Sub
End Class