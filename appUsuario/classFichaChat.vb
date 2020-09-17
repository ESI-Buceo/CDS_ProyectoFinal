Public Class classFichaChat
    Public Id As String
    Public Fecha As String
    Public DocNombre As String
    Private fichaChat As New Panel

    Public Function crarFichaChat() As Panel
        fichaChat.Width = 350
        fichaChat.Height = 70
        fichaChat.BorderStyle = BorderStyle.FixedSingle
        fichaChat.Margin = New Padding(3, 2, 2, 0)
        fichaChat.BackColor = Color.FromArgb(247, 247, 247)
        fichaChat.Controls.Add(labelID)
        fichaChat.Controls.Add(labelFecha)
        fichaChat.Controls.Add(labelNombreMedico)
        fichaChat.Controls.Add(avatarMedico)
        Return fichaChat
    End Function

    Private Function avatarMedico() As PictureBox
        Dim imagen As New PictureBox
        imagen.Height = 40
        imagen.Width = 40
        imagen.SizeMode = PictureBoxSizeMode.StretchImage
        imagen.Image = My.Resources.docMas
        imagen.Location = New Point(10, 10)
        Return imagen
    End Function

    Private Function labelID() As Label
        Dim lblID As New Label
        lblID.Text = "#" + Me.Id
        lblID.Font = New Font("Product Sans", 11, FontStyle.Bold)
        lblID.Padding = New Padding(2)
        lblID.ForeColor = Color.FromArgb(110, 196, 167)
        lblID.Location = New Point(80, 10)
        lblID.Cursor = Cursors.Hand
        AddHandler lblID.Click, AddressOf mostrarChat
        Return lblID
    End Function

    Private Function labelFecha() As Label
        Dim lblFecha As New Label
        lblFecha.Text = Me.Fecha
        lblFecha.Font = New Font("Product Sans", 10)
        lblFecha.ForeColor = Color.FromArgb(69, 75, 84)
        lblFecha.Location = New Point(190, 10)
        lblFecha.AutoSize = True
        lblFecha.Width = 200
        Return lblFecha
    End Function

    Private Function labelNombreMedico() As Label
        Dim nm As New Label
        nm.Text = Me.DocNombre
        nm.AutoSize = True
        nm.Location = New Point(80, 30)
        nm.Font = New Font("Product Sans", 11)
        nm.ForeColor = Color.FromArgb(69, 75, 84)
        Return nm
    End Function

    Private Sub mostrarChat()
        frmHistoriaChat.traerHistoriaConversacion(Me.Id)
        frmHistoriaChat.Text = VHistoricoChat & " - #" + Me.Id + " - " + Me.Fecha
        frmHistoriaChat.ShowDialog()
        frmHistoriaChat.rtbMensajes.ResetText()
    End Sub

End Class
