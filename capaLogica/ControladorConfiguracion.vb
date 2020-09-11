Imports capaDatos

Public Module ControladorConfiguracion
    Public Function cargarConfiguracion(ByVal drive As String, ip As String)
        If drive IsNot Nothing And ip IsNot Nothing Then
            ModeloConexion.Driver = drive
            ModeloConexion.ipServer = ip
            Return True
        End If
        Return False
    End Function

End Module
