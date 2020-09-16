Imports System.ComponentModel
Imports System.Windows.Forms

Public Class frmPrincipal
    Private Sub PatologiasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmPatologias.Click
        frmPatologia.MdiParent = Me
        frmPatologia.BringToFront()
        frmPatologia.Show()
    End Sub

    Private Sub SintomasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmSintomas.Click
        frmSintomas.MdiParent = Me
        frmSintomas.BringToFront()
        frmSintomas.Show()
    End Sub

    Private Sub btnVerPatologia_Click(sender As Object, e As EventArgs) Handles btnVerPatologia.Click
        frmPatologia.MdiParent = Me
        frmPatologia.BringToFront()
        frmPatologia.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmSalir.Click
        End
    End Sub

    Private Sub btnVerMedico_Click(sender As Object, e As EventArgs) Handles btnVerMedico.Click
        frmMedico.MdiParent = Me
        frmMedico.Show()
    End Sub

    Private Sub MedicoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles tsmMedico.Click
        frmMedico.MdiParent = Me
        frmMedico.Show()

    End Sub

    Private Sub EmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmAdministrativo.Click
        frmAdministrativo.MdiParent = Me
        frmAdministrativo.Show()
    End Sub

    Private Sub BtnVerUsuario_Click(sender As Object, e As EventArgs) Handles BtnVerUsuario.Click
        frmPaciente.MdiParent = Me
        frmPaciente.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles tsmPaciente.Click
        frmPaciente.MdiParent = Me
        frmPaciente.Show()
    End Sub

    Private Sub ListarMedicosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmListaMedicos.Click
        frmListaDeMedicos.MdiParent = Me
        frmListaDeMedicos.Show()
    End Sub

    Private Sub ListarUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmListaPacientes.Click
        frmListaDePacientes.MdiParent = Me
        frmListaDePacientes.Show()
    End Sub

    Private Sub ListarPatologiasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmListaPatologias.Click
        frmListaDePatologias.MdiParent = Me
        frmListaDePatologias.Show()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTextos()
    End Sub

    Private Sub frmPrincipal_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub ListarSintomasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmListaSintomas.Click
        frmListaDeSintomas.MdiParent = Me
        frmListaDeSintomas.Show()
    End Sub

    Private Sub RanquinDePatologiasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmRankingPat.Click
        frmRankingPatologias.MdiParent = Me
        frmRankingPatologias.Show()
    End Sub

    Private Sub LogDelSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmInformeDiagnosticos.Click
        frmDiagnosticosGenerados.MdiParent = Me
        frmDiagnosticosGenerados.Show()
    End Sub

    Private Sub CambioDeContraseñaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmCambioPass.Click
        frmCambiarPass.MdiParent = Me
        frmCambiarPass.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmAcercade.Click
        frmAcercaDe.ShowDialog()
    End Sub

    Private Sub Ultimos12MesesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmInformeChatMeses.Click
        frmInformeChats.MdiParent = Me
        frmInformeChats.Show()
        frmInformeChats.CargarChatDoceMeses()
    End Sub

    Private Sub PorMesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmInformechatMes.Click
        frmInformeChats.MdiParent = Me
        frmInformeChats.Show()
        frmInformeChats.CargarChatDelMes()
    End Sub

    Private Sub btnVerInforme_Click(sender As Object, e As EventArgs) Handles btnVerInforme.Click
        frmMenuInformes.MdiParent = Me
        frmMenuInformes.Show()
    End Sub

    Private Sub cargarTextos()
        tsmAdministrativos.Text = VAdministrativos
        tsmAdministrativo.Text = VAdministrativo
        tsmListaAdministrativos.Text = VListaAdministrativos
        tsmParametros.Text = VParametrosSistema
        tsmCambioPass.Text = VCambiarPassword
        tsmSalir.Text = VSalir
        tsmMedicos.Text = VMedicos
        tsmMedico.Text = VVerMedico
        tsmListaMedicos.Text = VListaMedicos
        tsmPacientes.Text = VPacientes
        tsmPaciente.Text = VVerPaciente
        tsmListaPacientes.Text = VListaPacientes
        tsmDiagnosticos.Text = VDiagnosticos
        tsmPatologias.Text = VPatologias
        tsmListaPatologias.Text = VListaPatologias
        tsmSintomas.Text = VSintomas
        tsmListaSintomas.Text = VListaSintomas
        tsmImportarDatosCSV.Text = VImportarArchivo
        tsmInformes.Text = VInformes
        tsmRankingPat.Text = VRankingPatologias
        tsmInformeDiagnosticos.Text = VDiagnosticosOtorgados
        tsmInformeDeChat.Text = VTituloInformeChat
        tsmInformeChatMeses.Text = VSubTituloInformeChatMeses
        tsmInformechatMes.Text = VSubTituloInformeChatMes
        tsmAyuda.Text = VAyuda
        tsmAcercade.Text = VAcercaDe
        tsmVerAyuda.Text = VAyuda
        btnVerMedico.Text = VMedicos
        BtnVerUsuario.Text = VPacientes
        btnVerPatologia.Text = VPatologias
        btnVerInforme.Text = VVerInformes
        tssLabelEstado.Text = VUsuario
        tssLabelServidor.Text = VServidor
        tssDBaseLabel.Text = VBaseDeDatos
        tssBaseDeDatos.Text = DBASE
        tssServidorIp.Text = IPSERVER
    End Sub

    Private Sub tsmImportarDatosCSV_Click(sender As Object, e As EventArgs) Handles tsmImportarDatosCSV.Click
        frmLeerArchivo.MdiParent = Me
        frmLeerArchivo.Show()
    End Sub

    Private Sub tsmParametros_Click(sender As Object, e As EventArgs) Handles tsmParametros.Click
        frmParametros.MdiParent = Me
        frmParametros.Show()
    End Sub

    Private Sub tsmVerAyuda_Click(sender As Object, e As EventArgs) Handles tsmVerAyuda.Click
        Process.Start("D:\ESI 2020\Doc Proyecto\Segunda Entrega\Triage - Gestion.chm")
    End Sub

    Private Sub tsmListaAdministrativos_Click(sender As Object, e As EventArgs) Handles tsmListaAdministrativos.Click
        frmListaDeAdministrativos.MdiParent = Me
        frmListaDeAdministrativos.Show()
    End Sub

End Class
