Imports System.Data.Odbc
Public MustInherit Class ModeloConexion
    Public Driver As String = "MySQL ODBC 8.0 ANSI Driver"
    Public Port As String = "3306"
    'Public Database As String = "dbTriage"
    Public Database As String = "dbPrueba"
    Public Server As String = My.Settings.IPServer
    Public conexion As New OdbcConnection

    Public Comando As New OdbcCommand
    Public Reader As OdbcDataReader

    Public Sub New(ByVal usuario As String, pass As String)
        conexion.ConnectionString = "DRIVER=" + Me.Driver +
                                    ";UID=" + usuario +
                                    ";PWD=" + pass +
                                    ";PORT=" + Me.Port +
                                    ";DATABASE=" + Me.Database +
                                    ";SERVER=" + Me.Server
        conexion.Open()
        Me.Comando.Connection = conexion
    End Sub

    Public Sub CerrarConexion()
        Me.conexion.Close()
    End Sub
End Class
