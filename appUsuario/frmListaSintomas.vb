Imports capaLogica

Public Class frmListaSintomas

    Private Sub frmListaSintomas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTextos()
        mostrarListaSintomas()
    End Sub

    Private Sub mostrarListaSintomas()
        'Lista los sintomas por nombre
        Try
            dgvSintomas.DataSource = ControladorSintomas.ListarSintomas(UCase(frmPrincipal.txtSintoma.Text), USUARIO, PASSWD)
            dgvSintomas.Columns.Item(0).Visible = False
            dgvSintomas.Columns.Item(1).Width = 200
            dgvSintomas.Columns.Item(2).Visible = False
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoErrorAccesoDatos)
        End Try
    End Sub

    Private Sub sintomaSeleccionado(ByVal idSintoma As Integer, sintomaNombre As String)
        'Verifica si el sintoma ya fue seleccionado
        Try
            If ControladorDiagnostico.ValidarSintomaSeleccionado(idSintoma, frmPrincipal.ListaSintomasSeleccionados) Then
                agregarSintomaSeleccionado(idSintoma, sintomaNombre)
            Else
                MsgBox(VElSintomaYaEstaIngresado, vbExclamation, VError)
            End If
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VErrorDatosAcceso)
        End Try
        Me.Dispose()
    End Sub

    Private Sub agregarSintomaSeleccionado(ByVal idSintoma As String, sintomaNombre As String)
        'Agrega el sintoma a la lista de sintomas
        frmPrincipal.sintomaSeleccionado = True
        frmPrincipal.ListaSintomasSeleccionados.Add(idSintoma)
        frmPrincipal.txtSintoma.Text = sintomaNombre
    End Sub

    Private Sub dgvSintomas_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSintomas.CellMouseClick
        If e.RowIndex >= 0 Then
            sintomaSeleccionado(dgvSintomas.Item(0, e.RowIndex).Value, dgvSintomas.Item(1, e.RowIndex).Value)
        End If
    End Sub

    Private Sub cargarTextos()
        Me.Text = VListaDeSintomas
        dgvSintomas.Columns("colNombre").HeaderText = VNombre
    End Sub
End Class