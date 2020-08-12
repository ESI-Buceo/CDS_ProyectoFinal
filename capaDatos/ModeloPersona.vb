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
    Public Telefonos As DataTable
    Public Password As String
    Public FechaNacimiento As String
    Public Activo As Boolean
    Public FechaRegistro As String

    Public Sub New(ByVal uid As String, pwd As String)
        MyBase.New(uid, pwd)
    End Sub
End Class