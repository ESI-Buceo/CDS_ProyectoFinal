Imports capaLogica

Public Class frmRankingPatologias

    Private Sub ejecutarConsulta()
        Try
            dgvRankingPatologias.DataSource = ControladorInformes.RankingPatologias(USUARIO, PASSWORD)
        Catch ex As Exception
            MsgBox("Error al leer informacion", vbCritical, "Error")
        End Try
    End Sub

    Private Sub frmRankingPatologias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTextos()
        ejecutarConsulta()
    End Sub

    Private Sub cargarTextos()
        Me.Text = VRankingPatologias.ToUpper
        lblTitulo.Text = VPatologiasDiagnosticadas
        dgvRankingPatologias.Columns(1).HeaderText = VPatologias
        dgvRankingPatologias.Columns(2).HeaderText = VCantidad

    End Sub
End Class