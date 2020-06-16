Public Class PanelPatologia
    'Genera dinamicamente un panel con los datos de las patologias.

    Public Shared id As Integer
    Public nombre As String
    Public descipcion As String

    Public Function CrearPanelPatologia() As Panel
        Dim panel As New Panel
        id = id + 1
        panel.Location = New Point(0, 0)
        panel.Width = 310
        panel.Height = 150
        panel.Controls.Add(idPatologia)
        panel.BorderStyle = BorderStyle.FixedSingle
        panel.ForeColor = Color.FromArgb(185, 239, 219)
        panel.Controls.Add(nombrePatologia)
        panel.Controls.Add(descripcionPatologia)
        Return panel
    End Function

    Private Function idPatologia() As Label
        Dim lblPatologia As New Label
        lblPatologia.Padding = New Padding(5, 5, 5, 5)
        lblPatologia.Text = Me.id
        lblPatologia.ForeColor = Color.White
        lblPatologia.Font = New Font("Product Sans ", 12)
        lblPatologia.TextAlign = ContentAlignment.MiddleRight
        lblPatologia.Location = New Point(10, 5)
        lblPatologia.AutoSize = False
        lblPatologia.BackColor = Color.FromArgb(100, 157, 138)
        lblPatologia.Width = 80
        lblPatologia.Height = 30
        Return lblPatologia
    End Function

    Private Function nombrePatologia() As Label
        Dim lblNombre As New Label
        lblNombre.Padding = New Padding(5, 5, 5, 5)
        lblNombre.Text = Me.nombre
        lblNombre.ForeColor = Color.Gray
        lblNombre.Font = New Font("Product Sans Black", 13)
        lblNombre.Location = New Point(5, 35)
        lblNombre.Width = 280
        lblNombre.Height = 30
        lblNombre.AutoSize = False
        Return lblNombre
    End Function

    Private Function descripcionPatologia() As Label
        Dim lblDescripcion As New Label
        lblDescripcion.Padding = New Padding(5, 5, 5, 5)
        lblDescripcion.Text = Me.descipcion
        lblDescripcion.ForeColor = Color.FromArgb(100, 157, 138)
        lblDescripcion.Location = New Point(5, 60)
        lblDescripcion.AutoSize = False
        lblDescripcion.Width = 280
        lblDescripcion.Height = 80
        Return lblDescripcion
    End Function
End Class
