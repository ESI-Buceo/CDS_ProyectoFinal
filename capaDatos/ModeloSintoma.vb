Imports System.Data.Odbc
Public Class ModeloSintoma
    Inherits ModeloConexion

    Public ID As Integer
    Public Nombre As String
    Public Estado As Boolean

    Public lector As OdbcDataReader

    Public Sub GuardarSintoma()
        Dim activo As Byte

        If Me.Estado = True Then
            activo = 1
        Else
            activo = 0
        End If
        comando.CommandText = "INSERT INTO sintoma (nombre, activo) VALUES('" & Me.Nombre & "', " & activo & " )"
        comando.ExecuteNonQuery()

    End Sub

    Public Sub ModificarSintoma()
        Dim activo As Byte

        If Me.Estado = True Then
            activo = 1
        Else
            activo = 0
        End If
        comando.CommandText = "UPDATE sintoma  SET nombre='" & Me.Nombre & "', activo=" & activo & " WHERE Id = " & Me.ID & " "
        comando.ExecuteNonQuery()

    End Sub

    Public Sub BorrarSintoma()
        comando.CommandText = "DELETE FROM sintoma  WHERE Id = " & Me.ID & " "
        comando.ExecuteNonQuery()

    End Sub

    Public Function eliminarSintoma(ByVal id As Integer) As Boolean
        'elimina sintoma o lo marca como 0 - inhabilitado
        Return True
    End Function

    Public Function TraeDatosSintomasDeBD() As DataTable
        Dim tabla As New DataTable
        comando.CommandText = "SELECT * FROM sintoma WHERE activo = 1 "
        lector = comando.ExecuteReader()
        tabla.Load(lector)
        Return tabla
    End Function

    Public Function TraeDatosSintomasDeBD(sintoma As String) As DataTable
        Dim tabla As New DataTable
        comando.CommandText = "SELECT * FROM sintoma WHERE activo = 1 AND nombre like '%" + sintoma + "%'"
        lector = comando.ExecuteReader()
        tabla.Load(lector)
        Return tabla
    End Function

End Class
