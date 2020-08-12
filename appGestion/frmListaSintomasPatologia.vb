Public Class frmListaSintomasPatologia
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Public Sub listaSintomas(ByVal tablaSintomas As DataTable)
        For Each sintomas As DataRow In tablaSintomas.Rows
            flpSintomasXPatologias.Controls.Add(crearPanelSintoma(sintomas("nombre").ToString))
        Next
    End Sub

    Private Function crearPanelSintoma(ByVal nombre As String)
        Dim panel As New Panel
        panel.Height = 30
        panel.Padding = New Padding(20)
        panel.BackColor = Color.FromArgb(110, 196, 167)
        panel.Controls.Add(nombreSintoma(nombre))
        Return panel
    End Function

    Private Function nombreSintoma(ByVal nombre As String)
        Dim label As New Label
        label.Text = nombre
        label.AutoSize = True
        label.Font = New Drawing.Font("Arial", 10.2)
        label.Padding = New Padding(5)
        label.ForeColor = Color.White
        Return label
    End Function

End Class