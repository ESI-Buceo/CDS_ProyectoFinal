Imports System.Data.Odbc

Public Class ModeloChat
    Inherits ModeloConexion

    Public idSesion As String
    Public docidentidadPaciente As String
    Public docidentidadMedico As String
    Public emisor As String
    Public mensaje As String

    Public Sub New(ByVal uid As String, pwd As String)
        MyBase.New(uid, pwd)
    End Sub


    Public Function RecibirMensajes(ByVal emisor As String)
        Dim tablaMensajes As New DataTable
        Comando.CommandText = "SELECT * FROM chat WHERE idSesion = " & ModeloDiagnostico.CodigoDiagnostico & " AND leido = 0 AND emisor <> '" & emisor & "'"
        Reader = Comando.ExecuteReader
        tablaMensajes.Load(Reader)
        CerrarConexion()
        Return tablaMensajes
    End Function


    Public Function RecibirMensajes(ByVal idSesion As String, emisor As String)
        'Lo utiliza la app del paciente
        Dim tablaMensajes As New DataTable
        Comando.CommandText = "SELECT * FROM chat WHERE idSesion = " & idSesion & " AND leido = 0 AND emisor <> '" & emisor & "'"
        Reader = Comando.ExecuteReader
        tablaMensajes.Load(Reader)
        CerrarConexion()
        Return tablaMensajes
    End Function


    Public Function RecibirTodosMensajes(ByVal idSesion As String)
        Dim tablaMensajes As New DataTable
        Comando.CommandText = "SELECT * FROM chat WHERE idSesion = " & idSesion
        Reader = Comando.ExecuteReader
        tablaMensajes.Load(Reader)
        CerrarConexion()
        Return tablaMensajes
    End Function
End Class
