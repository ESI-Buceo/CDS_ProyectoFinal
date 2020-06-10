Imports capaDatos
Public Class ModeloSignos
    Public ID As String
    Public Concepto As String
    Public Intensidad As String
    Public Estado As Boolean
    Public ListaSignos As List(Of Single)

    Public Function guardarSigno()
        'guarda los datos del signo
        Return True
    End Function

    Public Function eliminarSigno(ByVal id As Integer)
        'marca un signo como inhabilitado
        Return True
    End Function

    Public Function listarSignos()
        'lista todos los signos
        Return ListaSignos
    End Function

    Private Function validarConcepto()
        'valida que no existan caracteres raros
        Return True
    End Function

    Private Function validarIntensidad()
        'valida que sea numero
        Return True
    End Function

    Private Function validarEstado()
        'valida que el estado sea true o false
        Return True
    End Function
End Class
