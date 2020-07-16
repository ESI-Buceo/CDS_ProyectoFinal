Public Class frmLoading
    Private Sub frmLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picLoader.Image = My.Resources.loading
    End Sub

    Private Sub lblCancel_Click(sender As Object, e As EventArgs) Handles lblCancel.Click
        Me.Dispose()
    End Sub
End Class