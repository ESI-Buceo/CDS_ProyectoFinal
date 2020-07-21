Public Class claseTabSintoma
    Public Nombresintoma As String

    Public Function FichaSintoma() As Label
        Dim ficha As New Label
        ficha.AutoSize = True
        ficha.BackColor = Color.Green
        ficha.ForeColor = Color.White
        ficha.Padding = New Padding(5)
        ficha.Text = Nombresintoma
        Return ficha
    End Function
End Class
