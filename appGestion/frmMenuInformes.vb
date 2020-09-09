Public Class frmMenuInformes
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        ejectuarInforme()
    End Sub

    Private Sub ejectuarInforme()
        'Recorre y vacia todos los textbox del tabDatos
        For Each control As RadioButton In Me.grpBoxInformes.Controls
            If control.Checked Then
                abrirInforme(control.Tag)
            End If
        Next
    End Sub

    Private Sub abrirInforme(ByVal informe As String)
        Select Case informe
            Case 1
                frmRankingPatologias.MdiParent = frmPrincipal
                frmRankingPatologias.Show()
            Case 2
                frmDiagnosticosGenerados.MdiParent = frmPrincipal
                frmDiagnosticosGenerados.Show()
            Case 3
                frmInformeChats.MdiParent = frmPrincipal
                frmInformeChats.Show()
                frmInformeChats.CargarChatDoceMeses()
            Case 4
                frmInformeChats.MdiParent = frmPrincipal
                frmInformeChats.Show()
                frmInformeChats.CargarChatDelMes()
        End Select
    End Sub

    Private Sub frmMenuInformes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = VInformes.ToUpper
        rndBtnRankingPat.Text = VRankingPatologias
        rndBtnDiagnosticosOto.Text = VDiagnosticosOtorgados
        rndbtnChatMeses.Text = VSubTituloInformeChatMeses
        rndBtnChatMes.Text = VSubTituloInformeChatMes
        btnConfirmar.Text = VConfirmar
        grpBoxInformes.Text = VSeleccionaInforme
    End Sub
End Class