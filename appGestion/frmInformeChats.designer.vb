<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformeChats
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInformeChats))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.picEncabezado = New System.Windows.Forms.PictureBox()
        Me.lblSubTitulo = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.chartChat = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.grpBoxMesAno = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.cmbAno = New System.Windows.Forms.ComboBox()
        Me.lblAno = New System.Windows.Forms.Label()
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartChat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBoxMesAno.SuspendLayout()
        Me.SuspendLayout()
        '
        'picEncabezado
        '
        Me.picEncabezado.Image = CType(resources.GetObject("picEncabezado.Image"), System.Drawing.Image)
        Me.picEncabezado.Location = New System.Drawing.Point(0, -1)
        Me.picEncabezado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picEncabezado.Name = "picEncabezado"
        Me.picEncabezado.Size = New System.Drawing.Size(985, 79)
        Me.picEncabezado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picEncabezado.TabIndex = 5
        Me.picEncabezado.TabStop = False
        '
        'lblSubTitulo
        '
        Me.lblSubTitulo.AutoSize = True
        Me.lblSubTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTitulo.Location = New System.Drawing.Point(13, 119)
        Me.lblSubTitulo.Name = "lblSubTitulo"
        Me.lblSubTitulo.Size = New System.Drawing.Size(150, 20)
        Me.lblSubTitulo.TabIndex = 8
        Me.lblSubTitulo.Text = "subtitulodelinforme"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 91)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(156, 25)
        Me.lblTitulo.TabIndex = 7
        Me.lblTitulo.Text = "Chat Generados"
        '
        'chartChat
        '
        ChartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea1.Name = "ChartArea1"
        Me.chartChat.ChartAreas.Add(ChartArea1)
        Legend1.Alignment = System.Drawing.StringAlignment.Far
        Legend1.DockedToChartArea = "ChartArea1"
        Legend1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Legend1.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chartChat.Legends.Add(Legend1)
        Me.chartChat.Location = New System.Drawing.Point(13, 174)
        Me.chartChat.Name = "chartChat"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.Legend = "Legend1"
        Series1.Name = "Chats"
        Me.chartChat.Series.Add(Series1)
        Me.chartChat.Size = New System.Drawing.Size(956, 527)
        Me.chartChat.TabIndex = 9
        Me.chartChat.Text = "Chart1"
        '
        'grpBoxMesAno
        '
        Me.grpBoxMesAno.Controls.Add(Me.btnBuscar)
        Me.grpBoxMesAno.Controls.Add(Me.cmbMes)
        Me.grpBoxMesAno.Controls.Add(Me.lblMes)
        Me.grpBoxMesAno.Controls.Add(Me.cmbAno)
        Me.grpBoxMesAno.Controls.Add(Me.lblAno)
        Me.grpBoxMesAno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBoxMesAno.Location = New System.Drawing.Point(496, 83)
        Me.grpBoxMesAno.Name = "grpBoxMesAno"
        Me.grpBoxMesAno.Size = New System.Drawing.Size(474, 74)
        Me.grpBoxMesAno.TabIndex = 10
        Me.grpBoxMesAno.TabStop = False
        Me.grpBoxMesAno.Text = "Mes y Año de Consulta"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(341, 28)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(103, 33)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'cmbMes
        '
        Me.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cmbMes.Location = New System.Drawing.Point(254, 30)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(78, 28)
        Me.cmbMes.TabIndex = 3
        '
        'lblMes
        '
        Me.lblMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMes.Location = New System.Drawing.Point(182, 34)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(66, 20)
        Me.lblMes.TabIndex = 2
        Me.lblMes.Text = "Mes:"
        Me.lblMes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbAno
        '
        Me.cmbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAno.FormattingEnabled = True
        Me.cmbAno.Items.AddRange(New Object() {"2020", "2021", "2022", "2023", "2024", "2025"})
        Me.cmbAno.Location = New System.Drawing.Point(67, 30)
        Me.cmbAno.Name = "cmbAno"
        Me.cmbAno.Size = New System.Drawing.Size(109, 28)
        Me.cmbAno.TabIndex = 1
        '
        'lblAno
        '
        Me.lblAno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAno.Location = New System.Drawing.Point(6, 34)
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Size = New System.Drawing.Size(55, 20)
        Me.lblAno.TabIndex = 0
        Me.lblAno.Text = "Año:"
        Me.lblAno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmInformeChats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 724)
        Me.Controls.Add(Me.grpBoxMesAno)
        Me.Controls.Add(Me.chartChat)
        Me.Controls.Add(Me.lblSubTitulo)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.picEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmInformeChats"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Informe de Chats"
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartChat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBoxMesAno.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picEncabezado As PictureBox
    Friend WithEvents lblSubTitulo As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents chartChat As DataVisualization.Charting.Chart
    Friend WithEvents grpBoxMesAno As GroupBox
    Friend WithEvents cmbAno As ComboBox
    Friend WithEvents lblAno As Label
    Friend WithEvents lblMes As Label
    Friend WithEvents cmbMes As ComboBox
    Friend WithEvents btnBuscar As Button
End Class
