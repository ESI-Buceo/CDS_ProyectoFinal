Imports capaLogica
Public Class frmPrincipal
    Dim panelActivo As Panel
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

    Private Sub btnComenzar_Click(sender As Object, e As EventArgs) Handles btnComenzar.Click
        panelDeSintomas.Visible = True
        txtSintoma.Select()
    End Sub

    Private Sub txtSintoma_GotFocus(sender As Object, e As EventArgs) Handles txtSintoma.GotFocus
        txtSintoma.Text = ""
        txtSintoma.ForeColor = Color.Gray
    End Sub

    Private Sub btnSiguienteSintoma_Click(sender As Object, e As EventArgs) Handles btnSiguienteSintoma.Click
        If sintomaSeleccionado Then
            nuevaPregunta()
        Else
            frmListaSintomas.ShowDialog()
        End If
    End Sub

    Private Sub nuevaPregunta()
        lblPregunta.Text = ControladorDiagnostico.NuevoMensaje()
        txtSintoma.Select()
        sintomaSeleccionado = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ControladorDiagnostico.CrearInformeDiagnostico()
        For Each patologias In DevolverListaPatologiasDiagnostico()
            MsgBox(patologias.nombre)
        Next
    End Sub
End Class