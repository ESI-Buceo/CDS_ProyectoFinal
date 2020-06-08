Imports capaLogica
Public Class frmListaSintomas
    Private Sub frmListaSintomas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvSintomas.DataSource = ControladorSintomas.listarSintomas(UCase(frmPrincipal.txtSintoma.Text))
        dgvSintomas.Columns.Item(0).Visible = False
        dgvSintomas.Columns.Item(1).Width = 200
        dgvSintomas.Columns.Item(2).Visible = False
    End Sub

    Private Sub dgvSintomas_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSintomas.RowHeaderMouseDoubleClick
        cargarSintomaADiagnostico(dgvSintomas.Item(0, e.RowIndex).Value, dgvSintomas.Item(1, e.RowIndex).Value)
    End Sub

    Private Sub cargarSintomaADiagnostico(ByVal idSintoma As Integer, sintomaNombre As String)
        'Este metodo envia la informacion del sintoma seleccionado para que sea guardado en el diagnostico
        If ControladorDiagnostico.validarSintomaSeleccionado(idSintoma, sintomaNombre) Then
            sintomaSeleccionado(idSintoma, sintomaNombre)
        Else
            MsgBox("El sintoma seleccionado ya esta ingresado")
        End If

    End Sub

    Private Sub sintomaSeleccionado(ByVal idSintoma As Integer, sintomaNombre As String)
        'Este metodo envia la informacion del sintoma seleccionado al formulario principal
        frmPrincipal.sintomaSeleccionado = True
        frmPrincipal.txtSintoma.Text = sintomaNombre
        Me.Dispose()
    End Sub
End Class