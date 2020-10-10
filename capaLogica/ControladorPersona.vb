Imports System.Text
Imports capaDatos

Public Module ControladorPersona

    Public Function generarPassword()
        'Genera una nueva contraseña
        Dim caracteres As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
        Dim res As New StringBuilder()
        Dim rnd As New Random()
        For i = 0 To 5
            res.Append(caracteres(rnd.[Next](caracteres.Length)))
        Next

        Return "Vs." + res.ToString()

    End Function

    Public Sub CambiarPassword(ByVal docidentidad As String, pass As String, rangoIP As String, uid As String, pwd As String)
        Dim a As New ModeloPersona(uid, pwd)
        a.Documento = docidentidad
        a.RangoIP = rangoIP
        a.CambiarPassword(pass)

    End Sub

End Module
