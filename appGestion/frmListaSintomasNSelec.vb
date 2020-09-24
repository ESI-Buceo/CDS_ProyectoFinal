Imports capaLogica

Public Class frmListaSintomasNSelec
    Private Sub frmListaSintomasNSelec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTextos()
        cargarSintomas()
    End Sub

    Private Sub cargarSintomas()
        'Carga los sintomas nunca seleccionados por los pacientes
        Try
            dgvListSintomas.DataSource = ControladorInformes.SintomasNuncaSeleccionados(USUARIO, PASSWORD)
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub cargarTextos()
        Me.Text = VSintomasNuncaSeleccionados.ToUpper
        lblTitulo.Text = VSintomasNuncaSeleccionados
        lblSubTitulo.Text = VSubTituloSintomas
        btnCerrar.Text = VCerrar
    End Sub
End Class