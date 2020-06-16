Public Class ModeloMedico
    Inherits ModeloPersona

    Public NumeroMedico As Integer
    Public ListaMedicos As New List(Of ModeloMedico)

    Public Function GuardarMedico()
        'guarda los datos del medico
        Return True
    End Function

    Public Function EliminarMedico(ByVal numeroMedico As Integer)
        'marca un medico como inhabilitado
        Return True
    End Function

    Public Function ListarMedicos()
        'lista todos los medicos
        Return ListaMedicos
    End Function

    Private Function validarNumeroMedico()
        'valida que el numero de medico sea numerico
        Return True
    End Function

End Class
