﻿Imports capaLogica

Public Class claseFichaChat

    Public Foto As String
    Public Nombre As String
    Public Mensaje As String
    Public Minutos As String
    Public Ponderacion As Integer
    Public IdChat As String
    Public IdPaciente As String
    Public estado As String

    Private Const colorEmergenciaR As Integer = 193
    Private Const colorEmergenciaG As Integer = 141
    Private Const colorEmergenciaB As Integer = 41

    Private Const colorUrgenciaR As Integer = 210
    Private Const colorUrgenciaG As Integer = 214
    Private Const colorUrgenciaB As Integer = 47

    Private Const colorUrgenciaMenorR As Integer = 64
    Private Const colorUrgenciaMenorG As Integer = 142
    Private Const colorUrgenciaMenorB As Integer = 67

    Private Const colorSinUrgenciaR As Integer = 56
    Private Const colorSinUrgenciaG As Integer = 61
    Private Const colorSinUrgenciaB As Integer = 140

    Private f As New Panel
    Public Function crearFichaChat() As Panel
        f.Width = 347
        f.Height = 70
        f.Name = Me.IdChat
        f.BackColor = colorPonderacion()
        f.Margin = New Padding(3, 2, 2, 0)
        f.Controls.Add(imgFoto)
        f.Controls.Add(nombrePaciente)
        f.Controls.Add(mensajePaciente)
        f.Controls.Add(horaEnviado)
        AddHandler f.Click, AddressOf MostrarChat
        Return f
    End Function

    Private Function imgFoto() As PictureBox
        Dim img As New PictureBox
        img.Width = 40
        img.Height = 40
        img.Image = My.Resources.usuario
        img.SizeMode = PictureBoxSizeMode.StretchImage
        img.Location = New Point(10, 10)
        Return img
    End Function

    Private Function nombrePaciente() As Label
        Dim nombre As New Label
        nombre.Text = Me.Nombre
        nombre.ForeColor = Color.White
        nombre.AutoSize = False
        nombre.Width = 200
        nombre.Font = New Font("Product Sans", 12, FontStyle.Bold)
        nombre.Location = New Point(60, 10)
        AddHandler nombre.Click, AddressOf MostrarChat
        Return nombre
    End Function

    Private Function horaEnviado() As Label
        Dim hora As New Label
        hora.Text = Me.Minutos
        hora.Font = New Font("Product Sans", 10)
        hora.ForeColor = Color.White
        hora.Location = New Point(300, 10)
        hora.AutoSize = True
        hora.Width = 200
        Return hora
    End Function

    Private Function mensajePaciente() As Label
        Dim msg As New Label
        msg.Text = Me.Mensaje
        msg.Font = New Font("Product Sans Light", 11)
        msg.ForeColor = Color.White
        msg.Location = New Point(60, 30)
        msg.AutoSize = False
        msg.Width = 250
        AddHandler msg.Click, AddressOf MostrarChat
        Return msg
    End Function

    Private Function colorPonderacion() As Color
        Dim color As Color
        If Me.Ponderacion = 40 Then
            color = Color.FromArgb(colorEmergenciaR, colorEmergenciaG, colorEmergenciaB)
        ElseIf Me.Ponderacion < 40 And Me.Ponderacion >= 30 Then
            color = Color.FromArgb(colorUrgenciaR, colorUrgenciaG, colorUrgenciaB)
        ElseIf Me.Ponderacion < 30 And Me.Ponderacion >= 20 Then
            color = Color.FromArgb(colorUrgenciaMenorR, colorUrgenciaMenorG, colorUrgenciaMenorB)
        Else
            color = Color.FromArgb(colorSinUrgenciaR, colorSinUrgenciaG, colorSinUrgenciaB)
        End If
        Return color
    End Function

    Public Sub MostrarChat()
        'Cambia el estado de la sesion de chat
        datosGlobales.IDPACIENTE = Me.IdPaciente
        validarMensajeDeInicio()
        mostrarDatosChat()
    End Sub

    Private Sub validarMensajeDeInicio()
        'Verifica si tiene que enviar el mensaje de inicio de sesion
        Try
            ControladorChat.MensajeInicioDeSesion(Me.IdChat, USUARIO, PASSWD, IdPaciente)
        Catch ex As Exception
            MsgBox("Error al enviar el mensaje de inicio", vbCritical, "Error")
        End Try
    End Sub

    Private Sub mostrarDatosChat()
        'Muestra los datos del chat
        IDSESION = Me.IdChat
        frmPrincipal.txtMensajes.Clear()
        frmPrincipal.txtMensaje.Enabled = True
        frmPrincipal.MostrarPanelMensajes()
        frmPrincipal.DeshabilitarPanelPendientes()
        frmPrincipal.DeshabilitarPanelEnEspera()
        frmPrincipal.cargarDatosDelPaciente()
        frmPrincipal.chequearMensajesRecibidos()
        vuelveDeEspera()
        f.Visible = False
    End Sub

    Private Sub vuelveDeEspera()
        If Me.estado = 2 Then
            frmPrincipal.recibirTodosLosMensajes()
        End If
    End Sub
End Class
