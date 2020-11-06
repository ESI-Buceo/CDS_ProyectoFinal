<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaDePatologias
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaDePatologias))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.toolsMenuLista = New System.Windows.Forms.ToolStrip()
        Me.mnuBtnSoloActivos = New System.Windows.Forms.ToolStripButton()
        Me.tabSeparador = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBtnSoloInactivos = New System.Windows.Forms.ToolStripButton()
        Me.tabSeparador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBtnTodos = New System.Windows.Forms.ToolStripButton()
        Me.tabSeperador2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblTipo = New System.Windows.Forms.ToolStripLabel()
        Me.dgvListaPatologias = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.picEncabezado = New System.Windows.Forms.PictureBox()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPonderacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSintomas = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colActivo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.toolsMenuLista.SuspendLayout()
        CType(Me.dgvListaPatologias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolsMenuLista
        '
        Me.toolsMenuLista.AutoSize = False
        Me.toolsMenuLista.Dock = System.Windows.Forms.DockStyle.None
        Me.toolsMenuLista.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolsMenuLista.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolsMenuLista.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.toolsMenuLista.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBtnSoloActivos, Me.tabSeparador, Me.mnuBtnSoloInactivos, Me.tabSeparador1, Me.mnuBtnTodos, Me.tabSeperador2, Me.lblTipo})
        Me.toolsMenuLista.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.toolsMenuLista.Location = New System.Drawing.Point(6, 81)
        Me.toolsMenuLista.Name = "toolsMenuLista"
        Me.toolsMenuLista.Size = New System.Drawing.Size(958, 44)
        Me.toolsMenuLista.TabIndex = 7
        '
        'mnuBtnSoloActivos
        '
        Me.mnuBtnSoloActivos.Image = Global.appGestion.My.Resources.Resources.listaActivos
        Me.mnuBtnSoloActivos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuBtnSoloActivos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBtnSoloActivos.Name = "mnuBtnSoloActivos"
        Me.mnuBtnSoloActivos.Size = New System.Drawing.Size(126, 29)
        Me.mnuBtnSoloActivos.Text = "Solo Activos"
        Me.mnuBtnSoloActivos.ToolTipText = "Muestra solo los activos"
        '
        'tabSeparador
        '
        Me.tabSeparador.Name = "tabSeparador"
        Me.tabSeparador.Size = New System.Drawing.Size(6, 23)
        '
        'mnuBtnSoloInactivos
        '
        Me.mnuBtnSoloInactivos.Image = Global.appGestion.My.Resources.Resources.listaInactivos
        Me.mnuBtnSoloInactivos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuBtnSoloInactivos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBtnSoloInactivos.Name = "mnuBtnSoloInactivos"
        Me.mnuBtnSoloInactivos.Size = New System.Drawing.Size(139, 29)
        Me.mnuBtnSoloInactivos.Text = "Solo Inactivos"
        Me.mnuBtnSoloInactivos.ToolTipText = "Muestra solo los inactivos"
        '
        'tabSeparador1
        '
        Me.tabSeparador1.Name = "tabSeparador1"
        Me.tabSeparador1.Size = New System.Drawing.Size(6, 23)
        '
        'mnuBtnTodos
        '
        Me.mnuBtnTodos.Image = Global.appGestion.My.Resources.Resources.listarTodos
        Me.mnuBtnTodos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuBtnTodos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBtnTodos.Name = "mnuBtnTodos"
        Me.mnuBtnTodos.Size = New System.Drawing.Size(80, 29)
        Me.mnuBtnTodos.Text = "Todos"
        Me.mnuBtnTodos.ToolTipText = "Muestra todos los registros"
        '
        'tabSeperador2
        '
        Me.tabSeperador2.Name = "tabSeperador2"
        Me.tabSeperador2.Size = New System.Drawing.Size(6, 23)
        '
        'lblTipo
        '
        Me.lblTipo.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Padding = New System.Windows.Forms.Padding(10, 6, 0, 0)
        Me.lblTipo.Size = New System.Drawing.Size(56, 30)
        Me.lblTipo.Text = "tipo"
        '
        'dgvListaPatologias
        '
        Me.dgvListaPatologias.AllowUserToAddRows = False
        Me.dgvListaPatologias.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaPatologias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListaPatologias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaPatologias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colNombre, Me.colPonderacion, Me.colSintomas, Me.colActivo})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListaPatologias.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListaPatologias.Location = New System.Drawing.Point(6, 128)
        Me.dgvListaPatologias.Name = "dgvListaPatologias"
        Me.dgvListaPatologias.ReadOnly = True
        Me.dgvListaPatologias.RowTemplate.Height = 24
        Me.dgvListaPatologias.Size = New System.Drawing.Size(764, 388)
        Me.dgvListaPatologias.TabIndex = 8
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Sintomas"
        Me.DataGridViewImageColumn1.Image = Global.appGestion.My.Resources.Resources.listaSintomas
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.ToolTipText = "Muestra la lista de sintomas asociados"
        Me.DataGridViewImageColumn1.Width = 80
        '
        'picEncabezado
        '
        Me.picEncabezado.Image = CType(resources.GetObject("picEncabezado.Image"), System.Drawing.Image)
        Me.picEncabezado.Location = New System.Drawing.Point(-14, -1)
        Me.picEncabezado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picEncabezado.Name = "picEncabezado"
        Me.picEncabezado.Size = New System.Drawing.Size(784, 79)
        Me.picEncabezado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picEncabezado.TabIndex = 6
        Me.picEncabezado.TabStop = False
        '
        'colID
        '
        Me.colID.DataPropertyName = "id"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Width = 60
        '
        'colNombre
        '
        Me.colNombre.DataPropertyName = "nombre"
        Me.colNombre.HeaderText = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.ReadOnly = True
        Me.colNombre.Width = 250
        '
        'colPonderacion
        '
        Me.colPonderacion.DataPropertyName = "ponderacion"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colPonderacion.DefaultCellStyle = DataGridViewCellStyle2
        Me.colPonderacion.HeaderText = "Ponderacion"
        Me.colPonderacion.Name = "colPonderacion"
        Me.colPonderacion.ReadOnly = True
        Me.colPonderacion.Width = 120
        '
        'colSintomas
        '
        Me.colSintomas.HeaderText = "Sintomas"
        Me.colSintomas.Image = Global.appGestion.My.Resources.Resources.listaSintomas
        Me.colSintomas.Name = "colSintomas"
        Me.colSintomas.ReadOnly = True
        Me.colSintomas.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colSintomas.ToolTipText = "Muestra la lista de sintomas asociados"
        Me.colSintomas.Width = 80
        '
        'colActivo
        '
        Me.colActivo.DataPropertyName = "activo"
        Me.colActivo.HeaderText = "Activo"
        Me.colActivo.Name = "colActivo"
        Me.colActivo.ReadOnly = True
        Me.colActivo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colActivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colActivo.Visible = False
        '
        'frmListaDePatologias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 528)
        Me.Controls.Add(Me.dgvListaPatologias)
        Me.Controls.Add(Me.toolsMenuLista)
        Me.Controls.Add(Me.picEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmListaDePatologias"
        Me.Text = "LISTA DE PATOLOGIAS"
        Me.toolsMenuLista.ResumeLayout(False)
        Me.toolsMenuLista.PerformLayout()
        CType(Me.dgvListaPatologias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picEncabezado As PictureBox
    Friend WithEvents toolsMenuLista As ToolStrip
    Friend WithEvents mnuBtnSoloActivos As ToolStripButton
    Friend WithEvents tabSeparador As ToolStripSeparator
    Friend WithEvents mnuBtnSoloInactivos As ToolStripButton
    Friend WithEvents tabSeparador1 As ToolStripSeparator
    Friend WithEvents mnuBtnTodos As ToolStripButton
    Friend WithEvents tabSeperador2 As ToolStripSeparator
    Friend WithEvents lblTipo As ToolStripLabel
    Friend WithEvents dgvListaPatologias As DataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colNombre As DataGridViewTextBoxColumn
    Friend WithEvents colPonderacion As DataGridViewTextBoxColumn
    Friend WithEvents colSintomas As DataGridViewImageColumn
    Friend WithEvents colActivo As DataGridViewCheckBoxColumn
End Class
