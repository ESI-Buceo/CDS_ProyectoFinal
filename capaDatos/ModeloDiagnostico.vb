
Public Class ModeloDiagnostico
    Public Id As Integer
    Public idPaciente As Integer
    Public IdPatologia As Integer
    Public FechaHora As String
    Public Prioridad As Integer

    Public Function guardarDiagnostico(ByRef diagnostico As ModeloDiagnostico) As Boolean
        'codigo para guardar el diagnostico en la base de datos
        Return True
    End Function

End Class
