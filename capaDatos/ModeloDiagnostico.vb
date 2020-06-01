Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class ModeloDiagnostico
    Public Id As Integer
    Public IdPatologia As String
    Public FechaHora As String
    Public Prioridad As Integer

    Public Function guardarDiagnostico(ByRef diagnostico As ModeloDiagnostico) As Boolean
        'codigo para guardar el diagnostico en la base de datos
        Return True
    End Function

End Class
