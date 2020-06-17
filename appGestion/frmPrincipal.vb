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

End Class
