Imports capaLogica

Public Class frmInformeChats

    Public Sub CargarChatDoceMeses()
        'Carga los chat de los ultimos 12 meses moviles
        lblTitulo.Text = VTituloInformeChat
        lblSubTitulo.Text = VSubTituloInformeChatMeses
        ocultarPanelDeMesAno()
        cargarGraficoChatMeses()
    End Sub

    Public Sub CargarChatDelMes()
        'Carga los chat de un mes especifico
        mostrarPanelDeMesAno()
    End Sub

    Private Sub mostrarPanelDeMesAno()
        grpBoxMesAno.Visible = True
    End Sub

    Private Sub ocultarPanelDeMesAno()
        grpBoxMesAno.Visible = False
    End Sub

    Private Sub cargarGraficoChatMeses()
        Try
            cargarDatosGrafico(ControladorInformes.CantidadDeChatMeses(USUARIO, PASSWORD), "Mes")
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub cargarGraficoChatMes()
        Try
            cargarDatosGrafico(ControladorInformes.CantidadDeChatMes(USUARIO, PASSWORD, cmbAno.Text, cmbMes.Text), "Dia")
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub cargarDatosGrafico(ByVal tablaDatos As DataTable, columna As String)
        For Each datos As DataRow In tablaDatos.Rows
            chartChat.Series("Chats").Points.AddXY(datos(columna), datos("Cantidad"))
        Next
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If cmbAno.Text IsNot Nothing And cmbMes IsNot Nothing Then
            chartChat.Series.Clear()
            chartChat.Series.Add("Chats")
            chartChat.Series("Chats").ChartType = DataVisualization.Charting.SeriesChartType.Line
            cargarGraficoChatMes()
        End If
    End Sub

    Private Sub frmInformeChats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTextos()
    End Sub

    Private Sub cargarTextos()
        Me.Text = VInformeDeChat.ToUpper
        lblTitulo.Text = VTituloInformeChat
        lblSubTitulo.Text = VSubTituloInformeChatMes
        grpBoxMesAno.Text = VMesAnoConsulta
        lblAno.Text = VAno
        lblMes.Text = VMes
        btnBuscar.Text = VBuscar
    End Sub
End Class