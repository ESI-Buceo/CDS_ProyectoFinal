Imports capaLogica

Public Class frmLeerArchivo

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        abrirBuscarArchivo()
    End Sub

    Private Sub abrirBuscarArchivo()
        opfArchivoCsv.Filter = "CSV files (*.csv)|*.csv"
        opfArchivoCsv.ShowDialog()
        mostrarNombreArchivo()
    End Sub

    Private Sub mostrarNombreArchivo()
        lblNombreArchivo.Text = opfArchivoCsv.FileName
        marcarBotonRecuperar()
    End Sub

    Private Sub marcarBotonRecuperar()
        btnRecuperar.Select()
    End Sub

    Private Sub cargarDatosEnGrid(ByVal archivo As String)
        'Recorre el archivo seleccionado
        dgvDatosCSV.Columns.Clear()
        ' Lee la primera linea y la toma como encabezado de columna
        Dim cabecera As String = IO.File.ReadLines(archivo)(0)
        Dim columnas As String() = cabecera.Split(",")
        dgvDatosCSV.ColumnCount = columnas.Count
        'Asigna nombre a los encabezados
        For i = 0 To columnas.Count - 1
            dgvDatosCSV.Columns(i).Name = columnas(i)
        Next

        'Recorre el resto de las lineas del arhivo
        For i = 1 To IO.File.ReadLines(archivo).Count - 1
            Dim fila As String() = IO.File.ReadLines(archivo)(i).Split(",")
            dgvDatosCSV.Rows.Add(fila)
        Next

    End Sub

    Private Sub btnRecuperar_Click(sender As Object, e As EventArgs) Handles btnRecuperar.Click
        Me.Height = 714
        cargarDatosEnGrid(opfArchivoCsv.FileName)
    End Sub

    Private Sub cmbDestino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDestino.SelectedIndexChanged
        btnRecuperar.Enabled = True
    End Sub

    Private Sub frmLeerArchivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 324
        cargarTextos()
    End Sub

    Private Sub btnGuardarEnBD_Click(sender As Object, e As EventArgs) Handles btnGuardarEnBD.Click
        'Valida la informacion antes de ser exportada a la base de datos
        If ControladorValidaciones.ValidarDatosAExportar(dgvDatosCSV) And cmbDestino.Text IsNot Nothing Then
            evaluarFormatoDatosAImportar(cmbDestino.Text)
        Else
            MsgBox(VFaltanDatosParaPoderImportar, vbCritical, VAvisoError)
        End If
    End Sub

    Private Sub evaluarFormatoDatosAImportar(ByVal destino As String)
        'Verifica si las columas que se van a importar corresponden al tipo de elemento
        If destino.Equals(VPatologias) Then validarColumnasDeDestinoPatologias()
        If destino.Equals(VSintomas) Then validarColumnasDeDestinoSintomas()
    End Sub

    Private Sub validarColumnasDeDestinoPatologias()
        'Si el formato de los datos a importar es correcto los importa
        Try
            If ControladorValidaciones.ValidarCantidadCamposPatologias(dgvDatosCSV) Then
                ControladorPatologias.ExportarDatosADB(USUARIO, PASSWORD, dgvDatosCSV)
                MsgBox(VImportacionExitosa, vbInformation, VAviso)
            Else
                MsgBox(VFormatoIncorrectoParaImportar, vbInformation, VAviso)
            End If
        Catch ex As Exception
            MsgBox(VErrorExportarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub validarColumnasDeDestinoSintomas()
        'Si el formato de los datos a importar es correcto los importa
        Try
            If ControladorValidaciones.ValidarCantidadCamposSintomas(dgvDatosCSV) Then
                ControladorSintomas.ExportarDatosADB(USUARIO, PASSWORD, dgvDatosCSV)
                MsgBox(VImportacionExitosa, vbInformation, VAviso)
            Else
                MsgBox(VFormatoIncorrectoParaImportar, vbInformation, VAviso)
            End If
        Catch ex As Exception
            MsgBox(VErrorExportarDatos, vbCritical, VAvisoError)
        End Try

    End Sub

    Private Sub cargarTextos()
        Me.Text = VImportarArchivo
        gbBuscarArchivo.Text = VOrigenDestino
        lblDestino.Text = VDestino
        cmbDestino.Items.Clear()
        cmbDestino.Items.Add(VSintomas)
        cmbDestino.Items.Add(VPatologias)
        btnBuscar.Text = VBuscar
        btnRecuperar.Text = VRecuperar
        btnGuardarEnBD.Text = VExportaraDB
    End Sub
End Class