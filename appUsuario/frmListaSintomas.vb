Imports capaLogica

Public Class frmListaSintomas

    Private Sub frmListaSintomas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dgvSintomas.DataSource = ControladorSintomas.ListarSintomas(UCase(frmPrincipal.txtSintoma.Text))
            dgvSintomas.Columns.Item(0).Visible = False
            dgvSintomas.Columns.Item(1).Width = 200
            dgvSintomas.Columns.Item(2).Visible = False
        Catch ex As Exception
            MsgBox("No se puede cargar la lista de sintomas")
        End Try
    End Sub

    Private Sub sintomaSeleccionado(ByVal idSintoma As Integer, sintomaNombre As String)
        'Este metodo envia la informacion del sintoma seleccionado al formulario principal
        If ValidarSintomaSeleccionado(idSintoma, frmPrincipal.ListaSintomasSeleccionados) Then
            frmPrincipal.sintomaSeleccionado = True
            frmPrincipal.ListaSintomasSeleccionados.Add(idSintoma)
            frmPrincipal.txtSintoma.Text = sintomaNombre
        Else
            MsgBox("El sintoma ya esta ingresado")
        End If
        Me.Dispose()
    End Sub

    Private Sub dgvSintomas_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSintomas.CellMouseClick
        If e.RowIndex >= 0 Then
            sintomaSeleccionado(dgvSintomas.Item(0, e.RowIndex).Value, dgvSintomas.Item(1, e.RowIndex).Value)
        End If
    End Sub

End Class