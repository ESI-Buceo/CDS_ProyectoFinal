<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaDePacientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaDePacientes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.picEncabezado = New System.Windows.Forms.PictureBox()
        Me.toolsMenuLista = New System.Windows.Forms.ToolStrip()
        Me.mnuBtnSoloActivos = New System.Windows.Forms.ToolStripButton()
        Me.tabSeparador = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBtnSoloInactivos = New System.Windows.Forms.ToolStripButton()
        Me.tabSeparador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBtnTodos = New System.Windows.Forms.ToolStripButton()
        Me.tabSeperador2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblTipo = New System.Windows.Forms.ToolStripLabel()
        Me.dgvListaPacientes = New System.Windows.Forms.DataGridView()
        Me.colDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colApellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTelefonos = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colFechRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActivo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolsMenuLista.SuspendLayout()
        CType(Me.dgvListaPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picEncabezado
        '
        Me.picEncabezado.Image = CType(resources.GetObject("picEncabezado.Image"), System.Drawing.Image)
        Me.picEncabezado.Location = New System.Drawing.Point(-14, 0)
        Me.picEncabezado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picEncabezado.Name = "picEncabezado"
        Me.picEncabezado.Size = New System.Drawing.Size(988, 79)
        Me.picEncabezado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picEncabezado.TabIndex = 5
        Me.picEncabezado.TabStop = False
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
        Me.toolsMenuLista.TabIndex = 6
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
        'dgvListaPacientes
        '
        Me.dgvListaPacientes.AllowUserToAddRows = False
        Me.dgvListaPacientes.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaPacientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaPacientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDocumento, Me.colNombers, Me.colApellidos, Me.colEmail, Me.colTelefonos, Me.colFechRegistro, Me.colActivo})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListaPacientes.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvListaPacientes.Location = New System.Drawing.Point(6, 128)
        Me.dgvListaPacientes.Name = "dgvListaPacientes"
        Me.dgvListaPacientes.ReadOnly = True
        Me.dgvListaPacientes.RowTemplate.Height = 24
        Me.dgvListaPacientes.Size = New System.Drawing.Size(946, 388)
        Me.dgvListaPacientes.TabIndex = 7
        '
        'colDocumento
        '
        Me.colDocumento.DataPropertyName = "docidentidad"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDocumento.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDocumento.HeaderText = "Documento"
        Me.colDocumento.Name = "colDocumento"
        Me.colDocumento.ReadOnly = True
        '
        'colNombers
        '
        Me.colNombers.DataPropertyName = "nombres"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNombers.DefaultCellStyle = DataGridViewCellStyle3
        Me.colNombers.HeaderText = "Nombres"
        Me.colNombers.Name = "colNombers"
        Me.colNombers.ReadOnly = True
        Me.colNombers.Width = 150
        '
        'colApellidos
        '
        Me.colApellidos.DataPropertyName = "apellidos"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colApellidos.DefaultCellStyle = DataGridViewCellStyle4
        Me.colApellidos.HeaderText = "Apellidos"
        Me.colApellidos.Name = "colApellidos"
        Me.colApellidos.ReadOnly = True
        Me.colApellidos.Width = 150
        '
        'colEmail
        '
        Me.colEmail.DataPropertyName = "mail"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colEmail.DefaultCellStyle = DataGridViewCellStyle5
        Me.colEmail.HeaderText = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.ReadOnly = True
        Me.colEmail.Width = 200
        '
        'colTelefonos
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Wingdings 2", 12.0!, System.Drawing.FontStyle.Bold)
        Me.colTelefonos.DefaultCellStyle = DataGridViewCellStyle6
        Me.colTelefonos.HeaderText = "Telefonos"
        Me.colTelefonos.Name = "colTelefonos"
        Me.colTelefonos.ReadOnly = True
        Me.colTelefonos.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colTelefonos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colTelefonos.Text = "'"
        Me.colTelefonos.UseColumnTextForButtonValue = True
        Me.colTelefonos.Width = 80
        '
        'colFechRegistro
        '
        Me.colFechRegistro.DataPropertyName = "fechaRegistro"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colFechRegistro.DefaultCellStyle = DataGridViewCellStyle7
        Me.colFechRegistro.HeaderText = "Fecha Registro"
        Me.colFechRegistro.Name = "colFechRegistro"
        Me.colFechRegistro.ReadOnly = True
        Me.colFechRegistro.Width = 150
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
        'frmListaDePacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 528)
        Me.Controls.Add(Me.dgvListaPacientes)
        Me.Controls.Add(Me.toolsMenuLista)
        Me.Controls.Add(Me.picEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmListaDePacientes"
        Me.Text = "LISTA DE PACIENTES"
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolsMenuLista.ResumeLayout(False)
        Me.toolsMenuLista.PerformLayout()
        CType(Me.dgvListaPacientes, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvListaPacientes As DataGridView
    Friend WithEvents colDocumento As DataGridViewTextBoxColumn
    Friend WithEvents colNombers As DataGridViewTextBoxColumn
    Friend WithEvents colApellidos As DataGridViewTextBoxColumn
    Friend WithEvents colEmail As DataGridViewTextBoxColumn
    Friend WithEvents colTelefonos As DataGridViewButtonColumn
    Friend WithEvents colFechRegistro As DataGridViewTextBoxColumn
    Friend WithEvents colActivo As DataGridViewCheckBoxColumn
End Class
