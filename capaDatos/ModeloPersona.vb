Imports capaDatos
Public Class ModeloPersona
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
    Public Telefonos As List(Of String)
    Public Password As String
    Public FechaNacimiento As String
    Public Activo As Boolean
    Public FechaRegistro As String
    Public RangoIP As String

    Public Sub New(ByVal uid As String, pwd As String)
        MyBase.New(uid, pwd)
    End Sub

    Public Function VerificarDocumentoDeIdentidad(ByVal docidentidad As String)
        'Valida la existencia del documento
        Comando.CommandText = "SELECT docidentidad FROM persona WHERE docidentidad =" & docidentidad
        Return Comando.ExecuteScalar
    End Function

    Public Sub CambiarPassword(ByVal pass As String)
        'Cambio el password del usuario de la base de datos en mysql
        Comando.CommandText = "ALTER USER '" & Me.Documento & "'@'" & Me.RangoIP & "' IDENTIFIED BY '" & pass & "'"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "FLUSH PRIVILEGES"
        Comando.ExecuteNonQuery()

    End Sub
End Class