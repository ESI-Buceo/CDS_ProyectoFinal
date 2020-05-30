Imports System.ComponentModel
Imports System.Windows.Forms

Public Class frmPrincipal
    Private Sub PatologiasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatologiasToolStripMenuItem.Click
        frmPatologia.MdiParent = Me
        frmPatologia.Location = New Point(0, 0)
        frmPatologia.StartPosition = FormStartPosition.Manual
        frmPatologia.Show()
    End Sub

    Private Sub SintomasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SintomasToolStripMenuItem.Click
        frmSintomas.MdiParent = Me
        frmSintomas.Location = New Point(0, 0)
        frmSintomas.StartPosition = FormStartPosition.Manual
        frmSintomas.Show()
    End Sub

    Private Sub btnVerPatologia_Click(sender As Object, e As EventArgs) Handles btnVerPatologia.Click
        frmPatologia.MdiParent = Me
        frmPatologia.Location = New Point(0, 0)
        frmPatologia.StartPosition = FormStartPosition.Manual
        frmPatologia.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MsgBox("No se puede cerrar la aplicacion desde aqui", vbInformation, "Alerta")
        e.Cancel = True
    End Sub

End Class
