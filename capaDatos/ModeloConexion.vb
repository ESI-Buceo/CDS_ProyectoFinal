Imports System.Data.Odbc
Public MustInherit Class ModeloConexion
    Public Shared Driver As String = "MySQL ODBC 8.0 ANSI Driver"
    Public Shared ipServer As String = "192.168.5.50"
    Public Shared Database As String = "cds"
    Public Port As String = "3306"
    Public conexion As New OdbcConnection

    Public Comando As New OdbcCommand
    Public Reader As OdbcDataReader

    Public Sub New(ByVal usuario As String, pass As String)
        conexion.ConnectionString = "DRIVER=" + Driver +
                                    ";UID=" + usuario +
                                    ";PWD=" + pass +
                                    ";PORT=" + Me.Port +
                                    ";DATABASE=" + Database +
                                    ";SERVER=" + ipServer
        conexion.Open()
        Me.Comando.Connection = conexion
    End Sub

    Public Sub CerrarConexion()
        Me.conexion.Close()
    End Sub
End Class
