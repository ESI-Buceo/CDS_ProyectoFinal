Imports System.ComponentModel
Imports System.Windows.Forms

Public Class frmPrincipal
    Private Sub PatologiasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatologiasToolStripMenuItem.Click
        frmPatologia.MdiParent = Me
        frmPatologia.BringToFront()
        frmPatologia.Show()
    End Sub

    Private Sub SintomasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SintomasToolStripMenuItem.Click
        frmSintomas.MdiParent = Me
        frmSintomas.BringToFront()
        frmSintomas.Show()
    End Sub

    Private Sub btnVerPatologia_Click(sender As Object, e As EventArgs) Handles btnVerPatologia.Click
        frmPatologia.MdiParent = Me
        frmPatologia.BringToFront()
        frmPatologia.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub BtnVerUsuario_Click(sender As Object, e As EventArgs) Handles BtnVerUsuario.Click
    End Sub

    Private Sub MedicoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MedicoToolStripMenuItem1.Click
        frmMedico.MdiParent = Me
        frmMedico.Show()
    End Sub

    Private Sub btnVerMedico_Click(sender As Object, e As EventArgs) Handles btnVerMedico.Click
        frmMedico.MdiParent = Me
        frmMedico.Show()
    End Sub
End Class
