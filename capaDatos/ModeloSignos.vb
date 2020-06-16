Imports capaDatos
Public Class ModeloSignos
    Inherits ModeloConexion

    Public ID As String
    Public Concepto As String
    Public Intensidad As String
    Public Estado As Boolean
    Public ListaSignos As List(Of Single)

    Public Function GuardarSigno()
        'guarda los datos del signo
        Return True
    End Function

    Public Function EliminarSigno(ByVal id As Integer)
        'marca un signo como inhabilitado
        Return True
    End Function

    Public Function ListarSignos()
        'lista todos los signos
        Return ListaSignos
    End Function

End Class
