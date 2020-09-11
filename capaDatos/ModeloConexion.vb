﻿Imports System.Data.Odbc
Public MustInherit Class ModeloConexion
    Public Shared Driver As String
    Public Shared ipServer As String
    Public Port As String = "3306"
    Public Database As String = "dbTriage"
    Public conexion As New OdbcConnection

    Public Comando As New OdbcCommand
    Public Reader As OdbcDataReader

    Public Sub New(ByVal usuario As String, pass As String)
        conexion.ConnectionString = "DRIVER=" + Driver +
                                    ";UID=" + usuario +
                                    ";PWD=" + pass +
                                    ";PORT=" + Me.Port +
                                    ";DATABASE=" + Me.Database +
                                    ";SERVER=" + ipServer
        conexion.Open()
        Me.Comando.Connection = conexion
    End Sub

    Public Sub CerrarConexion()
        Me.conexion.Close()
    End Sub
End Class
