Imports capaLogica

Public Class frmHistoriaChat

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Public Sub traerHistoriaConversacion(ByVal idSesion As String)
        'Trae todos los mensajes de la sesion seleccionada
        Try
            recorreMensajesRecibidos(ControladorChat.RecibirTodosMensajes(idSesion, USUARIO, PASSWD))
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VError)
        End Try
    End Sub

    Private Sub recorreMensajesRecibidos(ByVal tablaMensajes As DataTable)
        'recorre los mensajes recividos
        For i = 0 To tablaMensajes.Rows.Count - 1
            identifiarColorearMensaje(tablaMensajes(i)("emisor"), tablaMensajes(i)("mensaje"), tablaMensajes(i)("fechaHora"))
        Next
    End Sub

    Private Sub identifiarColorearMensaje(ByVal emisor As String, mensaje As String, fechahora As String)
        'Muestra y colorea los mensajes dependiente de origen y destino
        If emisor.Equals("P") Then
            rtbMensajes.SelectionColor = Color.FromArgb(110, 196, 167)
            rtbMensajes.AppendText(fechahora + "- " & Vtu & " ->  " & mensaje & vbNewLine)
        ElseIf emisor.Equals("M") Then
            rtbMensajes.SelectionColor = Color.FromArgb(69, 75, 84)
            rtbMensajes.AppendText(fechahora + "- " & VDoctor & " -> " & mensaje & vbNewLine)
        End If
    End Sub
End Class