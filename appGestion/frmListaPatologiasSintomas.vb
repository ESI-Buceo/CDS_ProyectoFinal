Imports capaLogica

Public Class frmListaPatologiasSintomas

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Public Sub ListarPatologias(ByVal idSintoma As Integer)
        Try
            mostrarPatologias(ControladorPatologias.ListaDePatologias(idSintoma, USUARIO, PASSWORD))
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
            Me.Dispose()
        End Try
    End Sub

    Private Sub mostrarPatologias(ByVal tablaPatologias As DataTable)
        flpPatologiasPorSintoma.Controls.Clear()
        For Each patologia As DataRow In tablaPatologias.Rows
            flpPatologiasPorSintoma.Controls.Add(crearPanelPatologia(patologia("nombre")))
        Next
    End Sub

    Private Function crearPanelPatologia(ByVal nombre As String)
        Dim panel As New Panel
        panel.Height = 30
        panel.Padding = New Padding(20)
        panel.BackColor = Color.FromArgb(110, 196, 167)
        panel.Controls.Add(nombrePatologia(nombre))
        Return panel
    End Function

    Private Function nombrePatologia(ByVal nombre As String)
        Dim label As New Label
        label.Text = nombre
        label.AutoSize = True
        label.Font = New Drawing.Font("Arial", 10.2)
        label.Padding = New Padding(5)
        label.ForeColor = Color.White
        Return label
    End Function

    Private Sub frmListaPatologiasSintomas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTextos()
    End Sub

    Private Sub cargarTextos()
        Me.Text = VPatologiasPorSintoma
        btnCerrar.Text = VCerrar
    End Sub
End Class