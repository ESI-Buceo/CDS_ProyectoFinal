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

    Private Sub btnVerMedico_Click(sender As Object, e As EventArgs) Handles btnVerMedico.Click
        frmMedico.MdiParent = Me
        frmMedico.Show()
    End Sub

    Private Sub MedicoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MedicoToolStripMenuItem1.Click
        frmMedico.MdiParent = Me
        frmMedico.Show()

    End Sub

    Private Sub EmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem.Click
        frmAdministrativo.MdiParent = Me
        frmAdministrativo.Show()
    End Sub

    Private Sub BtnVerUsuario_Click(sender As Object, e As EventArgs) Handles BtnVerUsuario.Click
        frmPaciente.MdiParent = Me
        frmPaciente.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem1.Click
        frmPaciente.MdiParent = Me
        frmPaciente.Show()
    End Sub

    Private Sub ListarMedicosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarMedicosToolStripMenuItem.Click
        frmListaDeMedicos.MdiParent = Me
        frmListaDeMedicos.Show()
    End Sub

    Private Sub ListarUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarUsuariosToolStripMenuItem.Click
        frmListaDePacientes.MdiParent = Me
        frmListaDePacientes.Show()
    End Sub

    Private Sub ListarPatologiasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarPatologiasToolStripMenuItem.Click
        frmListaDePatologias.MdiParent = Me
        frmListaDePatologias.Show()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'System.Threading.Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo(My.Settings.lang)
        'CargarIdioma()
    End Sub
End Class
