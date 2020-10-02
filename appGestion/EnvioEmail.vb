Imports System.Net.Mail
Imports capaLogica

Public Module EnvioEmail

    Public Function EnviarEmail(ByRef documento As String, pass As String, direccionEmailDestino As String, asunto As String, tituloEmail As String, descripcion As String)
        Dim email As New MailMessage
        Dim smtp As New SmtpClient
        Dim logo As Image = My.Resources.logo_App
        Dim datosConexion As New DataTable
        cargarLoading()
        datosConexion = LeerConfiguracionEmail()
        If datosConexion.Rows(0).Item("de").ToString <> Nothing Then

            email.From = New MailAddress(datosConexion.Rows(0).Item("de").ToString)
            email.To.Add(direccionEmailDestino)
            email.Subject = asunto
            email.IsBodyHtml = True
            email.Body = "<HTML><body>
                            <h2>" + tituloEmail + "</h2>
                            <span>" + descripcion + "</span>
                            <h4> " + VDocumento + ": " + documento + "</h4>
                            <h5> " + VPassword + ":" + pass + "</5><br>
                            <span>" + VGraciasPorPreferinos + "</span>
                            <h4>" + VElEquipoDe + " Vida Sana</h4>
                        </body></HTML>"

            smtp.Port = datosConexion.Rows(0).Item("puerto").ToString
            smtp.Host = datosConexion.Rows(0).Item("servidorSalida").ToString
            smtp.UseDefaultCredentials = False
            smtp.EnableSsl = datosConexion.Rows(0).Item("emailssl").ToString
            smtp.Credentials = New Net.NetworkCredential(datosConexion.Rows(0).Item("de").ToString, datosConexion.Rows(0).Item("credencial").ToString)

            Try
                smtp.Send(email)
                MsgBox(VEmailEnviadoCorrectamente, vbInformation, VAviso)
                descargarLoading()
                Return True
            Catch ex As Exception
                MsgBox(VErrorEnvioDeEmail, vbCritical, VAvisoError)
                descargarLoading()
                Return False
            End Try
        Else
            MsgBox(VElEnvioDeChatDeshabilitado, vbInformation, VAviso)
            descargarLoading()
            Return False
        End If

    End Function

    Private Function LeerConfiguracionEmail()
        Try
            Return ControladorConfiguracion.LeerConfiguracionEmail(USUARIO, PASSWORD)
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
        Return False
    End Function

    Private Sub cargarLoading()
        frmLoading.Show()
        frmLoading.Refresh()
    End Sub

    Private Sub descargarLoading()
        frmLoading.Dispose()
    End Sub
End Module

