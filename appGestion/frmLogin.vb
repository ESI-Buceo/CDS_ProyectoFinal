Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmDatosLogin.MdiParent = Me
        frmDatosLogin.Show()
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        End
    End Sub

    Private Sub picEs_Click(sender As Object, e As EventArgs) Handles picEs.Click
        establecerIdioma("Spanish")
    End Sub

    Private Sub picEn_Click(sender As Object, e As EventArgs) Handles picEn.Click
        establecerIdioma("Ingles")
    End Sub

    Private Sub establecerIdioma(ByVal idioma As String)
        GuardarIdioma(idioma)
        CargarIdioma()
        frmDatosLogin.cargarTextos()
        frmDatosLogin.Refresh()
    End Sub
End Class
