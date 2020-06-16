Imports System.Data.Odbc
Public MustInherit Class ModeloConexion

    Public driver As String = "MySQL ODBC 5.3 ANSI Driver"
    Public uid As String = "u876920732_proyectocds"
    Public pwd As String = "npvtcADR"
    Public port As String = "3306"
    Public database As String = "u876920732_dbTriage"
    Public server As String = "213.190.6.127"

    Public conexion As New OdbcConnection("DRIVER=" + Me.driver +
                                       ";UID=" + Me.uid +
                                       ";PWD=" + Me.pwd +
                                       ";PORT=" + Me.port +
                                       ";DATABASE=" + Me.database +
                                       ";SERVER=" + Me.server)
    Public comando As New OdbcCommand
    Public reader As OdbcDataReader

    Public Sub New()
        Me.conexion.Open()
        Me.comando.Connection = Me.conexion
    End Sub

    Public Sub cerrarConexion()
        Me.conexion.Close()
    End Sub
End Class
