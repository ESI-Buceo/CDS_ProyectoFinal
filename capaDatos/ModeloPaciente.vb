Public Class ModeloPaciente
    Inherits ModeloPersona

    Public Fumador As Boolean
    Public Diabetico As Boolean
    Public Alcoholismo As Boolean
    Public Hipertencion As Boolean
    Public Obesidad As Boolean
    Public Alergico As Boolean
    Public ListaPecientes As New List(Of ModeloPaciente)

    Public Function guardarPaciente()
        'guarda datos del paciente
        Return True
    End Function

    Public Function eliminarPaciente(ByVal documento As Integer)
        'marca el paciente como inhabilitado
        Return True
    End Function

    Public Function listarPacientes()
        'lista todos los pacientes
        Return ListaPecientes
    End Function

    Private Function validarFumador()
        'valida si es true o false
        Return True
    End Function

    Private Function validarDiabetico()
        'validad si es true o false
        Return True
    End Function

    Private Function validarAlcoholismo()
        'validar si es true o false
        Return True
    End Function

    Private Function ValidarHipertencion()
        'valida que sea true o false
        Return True
    End Function

    Private Function validarObesidad()
        'valida si es true o false
        Return True
    End Function

    Private Function validarAlergico()
        'valida si es true o false
        Return True
    End Function

End Class
