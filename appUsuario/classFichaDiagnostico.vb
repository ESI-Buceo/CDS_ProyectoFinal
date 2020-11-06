Imports capaLogica

Public Class classFichaDiagnostico
    Public idDiagnostico As String
    Public fechaDiagnostico As String
    Public Patologia As String
    Public Ponderacion As Integer
    Public CantPatologias As Integer
    Public AltoPanelDiagnostico As Integer

    Private panel As New Panel
    Public Function crearFichaChat() As Panel
        panel.Width = 350
        panel.BorderStyle = BorderStyle.FixedSingle
        panel.Margin = New Padding(3, 2, 2, 0)
        panel.Controls.Add(labelTipo)
        panel.Controls.Add(labelDiagnostico)
        panel.Controls.Add(labelFecha)
        Return panel
    End Function

    Private Function labelTipo() As Label
        Dim tipo As New Label
        tipo.Text = VPatologiasDiagnosticadas
        tipo.ForeColor = Color.White
        tipo.BackColor = Color.FromArgb(197, 75, 86)
        tipo.AutoSize = False
        tipo.Width = 350
        tipo.Font = New Font("Product Sans", 12, FontStyle.Bold)
        tipo.Padding = New Padding(2)
        Return tipo
    End Function

    Private Function labelDiagnostico() As Label
        Dim diagnostico As New Label
        diagnostico.Text = "#" + Me.idDiagnostico
        diagnostico.ForeColor = Color.FromArgb(69, 75, 84)
        diagnostico.Font = New Font("Product Sans", 10, FontStyle.Bold)
        diagnostico.Location = New Point(5, 25)
        Return diagnostico
    End Function

    Private Function labelFecha() As Label
        Dim fechaHora As New Label
        fechaHora.Text = Me.fechaDiagnostico
        fechaHora.Font = New Font("Product Sans", 9)
        fechaHora.ForeColor = Color.FromArgb(69, 75, 84)
        fechaHora.Location = New Point(120, 25)
        fechaHora.AutoSize = True
        fechaHora.Width = 200
        Return fechaHora
    End Function

    Private Function labelPatologia(ByVal nombre As String, posicion As Integer) As Label
        Dim patologia As New Label
        patologia.Text = nombre
        patologia.Font = New Font("Product Sans Light", 11)
        patologia.ForeColor = Color.FromArgb(110, 196, 167)
        patologia.Location = New Point(10, posicion)
        patologia.AutoSize = False
        patologia.Width = 250
        Return patologia
    End Function

    Public Sub ListarPatologiasDelDiagnostico(ByVal tablaPatologias As DataTable)
        'Muestra la lista de patologias que contiene el diagnostico
        Dim posicion As Integer = 45
        Me.CantPatologias = tablaPatologias.Rows.Count - 1
        AltoPanelDiagnostico = CantPatologias * 20
        For Each patologia As DataRow In tablaPatologias.Rows
            panel.Controls.Add(labelPatologia(patologia("nombre"), posicion))
            posicion += 20
        Next
        adaptarAltoTarjeta()
    End Sub

    Private Sub adaptarAltoTarjeta()
        panel.Height = 80 + AltoPanelDiagnostico
    End Sub
End Class
