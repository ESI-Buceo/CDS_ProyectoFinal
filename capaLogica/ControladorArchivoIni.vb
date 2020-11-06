Imports System.Runtime.InteropServices
Imports System.Text

Public Module ControladorArchivoIni
    <DllImport("kernel32")>
    Private Function GetPrivateProfileString(ByVal section As String, ByVal key As String, ByVal def As String, ByVal retVal As StringBuilder, ByVal size As Integer, ByVal filePath As String) As Integer
    End Function

    <DllImport("kernel32")>
    Private Function WritePrivateProfileString(ByVal section As String, key As String, Value As String, FilePath As String) As Integer
    End Function

    Public archivoConf As String

    Public Function leerConfiguracion(ByVal seccion As String, llave As String, Optional valorPorDefecto As String = "") As String
        Dim sb As New StringBuilder(500)
        If GetPrivateProfileString(seccion, llave, valorPorDefecto, sb, sb.Capacity, archivoConf) > 0 Then
            Return sb.ToString
        Else
            Return Nothing
        End If
    End Function

    Public Sub grabarConfiguracion(ByVal seccion As String, llave As String, valor As String)
        WritePrivateProfileString(seccion, llave, valor, archivoConf)
    End Sub


End Module