Public Class frmAcercaDe
    Private Sub frmAcercaDe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTextos()
    End Sub

    Private Sub cargarTextos()
        Me.Text = VAcercaDe
        lblDesc.Text = VSoftwareGestionMedica

    End Sub
End Class