Imports capaDatos
Public MustInherit Class ModeloPersona
    Inherits ModeloConexion

    Public Documento As Integer
    Public Email As String
    Public Nombres As String
    Public Apellidos As String
    Public Calle As String
    Public Numero As String
    Public Barrio As String
    Public Esquina As String
    Public Apartamento As String
    Public Telefonos As New DataTable
    Public Password As String
    Public FechaNacimiento As String
    Public Activo As Boolean
    Public FechaRegistro As String

    Private Function validarDocumento()
        'valida el documento ingresado
        Return True
    End Function

    Private Function validarEmail()
        'validar direccion de email
        Return True
    End Function

    Private Function validarNombres()
        'valida que el nombre no tenga caracteres raros
        Return True
    End Function

    Private Function validarApellidos()
        'valida que los apellidos no tenga caracteres raros
        Return True
    End Function

    Private Function validarCalle()
        'valida que la calle no contecta caracteres raros
        Return True
    End Function

    Private Function validarNumero()
        'valida que el numero de puerta sea un numero
        Return True
    End Function

    Private Function validarBarrio()
        'valida que el barrio no tenga caracteres raros
        Return True
    End Function

    Private Function validarEsquina()
        'valida que no tenga caracteres raros
        Return True
    End Function

    Private Function validarApartamento()
        'valida que el apartamento no tenga caracteres raros
        Return True
    End Function

    Private Function validarTelefono()
        'valida que el telefono sea un numero, contenga menos de 9 digitos
        Return True
    End Function

    Private Function validarPassword()
        'valida que el password tenga mas de n caracteres y menos de n caracteres
        Return True
    End Function

    Private Function validarFechaNacimiento()
        'valida que la fecha de nacimiento sea valida
        Return True
    End Function

    Private Function validarEstado()
        'valida que el estado sea true o false
        Return True
    End Function

End Class

