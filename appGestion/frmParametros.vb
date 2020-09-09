Imports capaLogica

Public Class frmParametros
    Private Sub frmParametros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTextos()
    End Sub

    Private Sub cargarTextos()
        Me.Text = VParametrosSistema.ToUpper
        gbParametros.Text = VParametrosSistema
        btnCerrar.Text = VCerrar
        lblLengSistema.Text = VIdiomaSistema
        lblDescIdiomaSistema.Text = VDescIdiomaSistema
        lblLenguaje.Text = VLenguaje
        cbLenguaje.Items.Clear()
        cbLenguaje.Items.Add(VEspanol)
        cbLenguaje.Items.Add(VIngles)
        mostrarIdiomaActual()
    End Sub

    Private Sub mostrarIdiomaActual()
        If My.Settings.lenguaje.Equals("es") Then
            cbLenguaje.SelectedItem = VEspanol
        Else
            cbLenguaje.SelectedItem = VIngles
        End If
    End Sub

    Private Sub cbLenguaje_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLenguaje.SelectedIndexChanged
        If cbLenguaje.Text <> idiomaCorto(My.Settings.lenguaje) Then
            confirmarCambioDeIdioma()
        End If

    End Sub

    Private Sub confirmarCambioDeIdioma()
        'Selecciona el idioma del sistema
        Dim respuesta As Integer

        respuesta = MsgBox(VEstecambioRequiereReiniciarLaAplicacion, vbQuestion & vbYesNo, VAviso)
        If respuesta = 6 Then
            guardarIdioma()
        Else
            cbLenguaje.SelectedText = My.Settings.lenguaje
        End If
    End Sub

    Private Sub guardarIdioma()
        'Guarda la configuracino
        lang.GuardarIdioma(cbLenguaje.Text)
        End
    End Sub

    Private Function idiomaCorto(ByVal idioma As String)
        Select Case idioma
            Case "es" : Return "Español"
            Case "en" : Return "English"
        End Select
    End Function

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub
End Class