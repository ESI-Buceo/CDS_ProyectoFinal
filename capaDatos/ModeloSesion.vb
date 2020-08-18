Public Class ModeloSesion
    Inherits ModeloConexion

    Public IdSesion As String = ModeloDiagnostico.CodigoDiagnostico
    Public Prioridad As String = ModeloDiagnostico.Ponderacion
    Public Estado As String

    Public Sub New(ByVal uid As String, pwd As String)
        MyBase.New(uid, pwd)
    End Sub

    Public Sub GuardarSesion()
        'Guarda el inicio de una sesion con su prioridad
        Comando.CommandText = "INSERT INTO sesion (idSesion, prioridad) VALUES(" & Me.IdSesion & ", " & Me.Prioridad & ")"
        Comando.ExecuteNonQuery()
        CerrarConexion()
    End Sub

End Class
