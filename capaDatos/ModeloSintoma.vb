Imports System.Data.Odbc
Public Class ModeloSintoma
    Inherits ModeloConexion

    Public ID As Integer
    Public Nombre As String
    Public Estado As Boolean

    Public lector As OdbcDataReader

    Public Sub GuardarSintoma()

        If Me.ID = 0 Then
            comando.CommandText = "INSERT INTO sintoma (nombre, activo) VALUES ( '" & Me.Nombre & "', " & Me.Estado & " )"

        Else
            comando.CommandText = "INSERT INTO sintoma (id,nombre, activo) VALUES ( " & Me.ID & " ,'" & Me.Nombre & "', " & Me.Estado & " ) ON DUPLICATE KEY UPDATE nombre ='" & Me.Nombre & "', activo= " & Me.Estado

        End If
        comando.ExecuteNonQuery()

    End Sub

    Public Sub BorrarSintoma()
        comando.CommandText = "DELETE FROM sintoma  WHERE Id = " & Me.ID & " "
        comando.ExecuteNonQuery()

    End Sub

    Public Function TraeDatosSintomasDeBD() As DataTable
        Dim tabla As New DataTable
        comando.CommandText = "Select * FROM sintoma WHERE activo = 1 "
        lector = comando.ExecuteReader()
        tabla.Load(lector)
        Return tabla
    End Function

    Public Function TraeDatosSintomasDeBD(sintoma As String) As DataTable
        Dim tabla As New DataTable
        comando.CommandText = "Select * FROM sintoma WHERE activo = 1 And nombre Like '%" + sintoma + "%'"
        lector = comando.ExecuteReader()
        tabla.Load(lector)
        Return tabla
    End Function


    Public Function listarSintomasXPatologia(ByVal idPatologia As String) As DataTable
        ' lista los sintomas vinculados a una patologia
        Dim tabla As New DataTable
        comando.CommandText = "SELECT a.idSintoma, s.nombre FROM asociados a JOIN sintoma s ON s.id = a.idSintoma WHERE a.idPatologia=" & idPatologia
        reader = comando.ExecuteReader()
        tabla.Load(reader)
        Return tabla
    End Function

End Class
