Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Module ControladorValidaciones

    Public Function ValidarFormatoDocumento(ByVal docidentidad As String)
        If docidentidad.Length >= 7 And docidentidad.Length <= 8 Then
            Return True
        End If
        Return False
    End Function

    Public Function ValidarCampoVacio(ByVal nombre As String)
        If nombre.Length = 0 Then
            Return False
        End If
        Return True
    End Function

    Public Function ValidarNombres(ByVal nombres As String)
        For Each letras In nombres.Replace(" ", "")
            If Not Char.IsLetter(letras) Or nombres.Length = 0 Then
                Return False
            End If
        Next
        Return True
    End Function

    Public Function ValidarApellidos(ByVal apellidos As String)
        For Each letras In apellidos.Replace(" ", "")
            If Not Char.IsLetter(letras) Or apellidos.Length = 0 Then
                Return False
            End If
        Next
        Return True
    End Function

    Public Function ValidarEmail(ByVal mail As String)
        If mail.Length > 0 Then
            Return Regex.IsMatch(mail,
                    "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
        End If
        Return False
    End Function

    Public Function ValidarNumeroMedico(ByVal nmedico As String)
        If nmedico.Length > 0 Then
            For Each numero In nmedico
                If Not Char.IsNumber(numero) Then
                    Return False
                End If
            Next
        End If
        Return True
    End Function

    Public Function ValidarNumeroEmpleado(ByVal ndeempleado As String)
        If ndeempleado.Length > 0 Then
            For Each numero In ndeempleado
                If Not Char.IsNumber(numero) Then
                    Return False
                End If
            Next
        End If
        Return True
    End Function

    Public Function ValidarFechaNacimiento(ByVal fechaNacimiento As String)
        Dim offset = New Date(1, 1, 1)
        Dim actual As Date = Date.Now
        Dim nacimiento As Date = Date.Parse(fechaNacimiento)
        Dim diferencia As TimeSpan = actual - nacimiento
        Dim anos = (offset + diferencia).Year
        If anos <= 18 Then
            Return False
        End If
        Return True
    End Function

    Public Function ValidarPonderacion(ByVal ponderacion As String)
        If ponderacion.Length = 0 Then
            Return False
        End If
        Return True
    End Function

    Public Function ValidarListaCargada(ByVal lista As DataGridView)
        If lista.Rows.Count = 0 Then
            Return False
        End If
        Return True
    End Function
End Module
