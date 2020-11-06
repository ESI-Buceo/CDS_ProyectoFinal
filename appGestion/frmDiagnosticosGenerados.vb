Imports capaLogica

Public Class frmDiagnosticosGenerados
    Private Sub frmDiagnosticosGenerados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTextos()
        traerDatosGrafico()
    End Sub

    Private Sub traerDatosGrafico()
        Try
            cargarDatosGrafico(ControladorInformes.DiagnosticosBrindados(USUARIO, PASSWORD))
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub cargarDatosGrafico(ByVal tablaDatos As DataTable)
        For Each datos As DataRow In tablaDatos.Rows
            chartDiagnosticos.Series(VDiagnosticos).Points.AddXY(datos("Mes"), datos("Cantidad"))
        Next
    End Sub

    Private Sub cargarTextos()
        Me.Text = VInformeDiagnosticosGenerados
        lblTitulo.Text = VDiagnosticoSGenerados
        lblSubTitulo.Text = VSubTtitulosDiagnosticosGenerados
        chartDiagnosticos.Series.Item(0).Name = VDiagnosticos
        chartDiagnosticos.ChartAreas.Item("ChartArea1").AxisX.Title = VMeses
    End Sub
End Class