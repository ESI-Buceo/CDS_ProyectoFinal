Imports System.Data.Odbc
Public Class ModeloSintoma
    Inherits ModeloConexion

    Public ID As Integer
    Public Nombre As String
    Public Estado As Boolean


    Public Sub GuardarSintoma()
        Try
            comando.CommandText = "INSERT INTO sintoma (id,nombre, activo) VALUES ( " & Me.ID & " ,'" & Me.Nombre & "', " & Me.Estado & " ) ON DUPLICATE KEY UPDATE nombre ='" & Me.Nombre & "', activo= " & Me.Estado
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub BorrarSintoma()
        ' eliminiacion logica de sintoma
        comando.CommandText = "DELETE FROM sintoma  WHERE Id = " & Me.ID & " "
        comando.ExecuteNonQuery()
    End Sub

    Public Function TraeDatosSintomasDeBD() As DataTable
        Dim tabla As New DataTable
        comando.CommandText = "Select * FROM sintoma WHERE activo = 1 "
        reader = comando.ExecuteReader()
        tabla.Load(reader)
        Return tabla
    End Function

    Public Function TraeDatosSintomasDeBD(sintoma As String) As DataTable
        Dim tabla As New DataTable
        comando.CommandText = "Select * FROM sintoma WHERE activo = 1 And nombre Like '%" + sintoma + "%'"
        reader = comando.ExecuteReader()
        tabla.Load(reader)
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
