﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSintomas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSintomas))
        Me.picEncabezado = New System.Windows.Forms.PictureBox()
        Me.toolsMenuSintoma = New System.Windows.Forms.ToolStrip()
        Me.mnuBtnAgregar = New System.Windows.Forms.ToolStripButton()
        Me.tabSeparador = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tabSeparador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBtnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.tabSeperador2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBtnNueva = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBtnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.tabSeparador3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBtnBorrar = New System.Windows.Forms.ToolStripButton()
        Me.tabSeparador4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBtnModificar = New System.Windows.Forms.ToolStripButton()
        Me.tabDatosSintomas = New System.Windows.Forms.TabControl()
        Me.tabDatos = New System.Windows.Forms.TabPage()
        Me.txtSintomaID = New System.Windows.Forms.TextBox()
        Me.lblSintomaID = New System.Windows.Forms.Label()
        Me.chkSintomaEstado = New System.Windows.Forms.CheckBox()
        Me.txtSintomaNombre = New System.Windows.Forms.TextBox()
        Me.lblSintomaEstado = New System.Windows.Forms.Label()
        Me.lblSintomaNombre = New System.Windows.Forms.Label()
        Me.tabBusqueda = New System.Windows.Forms.TabPage()
        Me.dgSintomas = New System.Windows.Forms.DataGridView()
        Me.sintomaID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sintmaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sintomaIntensidad = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.sintomaEstado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolsMenuSintoma.SuspendLayout()
        Me.tabDatosSintomas.SuspendLayout()
        Me.tabDatos.SuspendLayout()
        Me.tabBusqueda.SuspendLayout()
        CType(Me.dgSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picEncabezado
        '
        Me.picEncabezado.Image = CType(resources.GetObject("picEncabezado.Image"), System.Drawing.Image)
        Me.picEncabezado.Location = New System.Drawing.Point(0, 1)
        Me.picEncabezado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picEncabezado.Name = "picEncabezado"
        Me.picEncabezado.Size = New System.Drawing.Size(906, 79)
        Me.picEncabezado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picEncabezado.TabIndex = 1
        Me.picEncabezado.TabStop = False
        Me.picEncabezado.UseWaitCursor = True
        '
        'toolsMenuSintoma
        '
        Me.toolsMenuSintoma.AutoSize = False
        Me.toolsMenuSintoma.Dock = System.Windows.Forms.DockStyle.None
        Me.toolsMenuSintoma.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolsMenuSintoma.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolsMenuSintoma.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.toolsMenuSintoma.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBtnAgregar, Me.tabSeparador, Me.mnuBtnGuardar, Me.tabSeparador1, Me.mnuBtnCancelar, Me.tabSeperador2, Me.mnuBtnNueva, Me.ToolStripSeparator1, Me.mnuBtnBuscar, Me.tabSeparador3, Me.mnuBtnBorrar, Me.tabSeparador4, Me.mnuBtnModificar})
        Me.toolsMenuSintoma.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.toolsMenuSintoma.Location = New System.Drawing.Point(12, 84)
        Me.toolsMenuSintoma.Name = "toolsMenuSintoma"
        Me.toolsMenuSintoma.Size = New System.Drawing.Size(894, 44)
        Me.toolsMenuSintoma.TabIndex = 2
        Me.toolsMenuSintoma.UseWaitCursor = True
        '
        'mnuBtnAgregar
        '
        Me.mnuBtnAgregar.Image = CType(resources.GetObject("mnuBtnAgregar.Image"), System.Drawing.Image)
        Me.mnuBtnAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuBtnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBtnAgregar.Name = "mnuBtnAgregar"
        Me.mnuBtnAgregar.Size = New System.Drawing.Size(97, 29)
        Me.mnuBtnAgregar.Text = "Agregar"
        Me.mnuBtnAgregar.ToolTipText = "Agrega un nuevo registro"
        '
        'tabSeparador
        '
        Me.tabSeparador.Name = "tabSeparador"
        Me.tabSeparador.Size = New System.Drawing.Size(6, 23)
        '
        'mnuBtnGuardar
        '
        Me.mnuBtnGuardar.Enabled = False
        Me.mnuBtnGuardar.Image = CType(resources.GetObject("mnuBtnGuardar.Image"), System.Drawing.Image)
        Me.mnuBtnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuBtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBtnGuardar.Name = "mnuBtnGuardar"
        Me.mnuBtnGuardar.Size = New System.Drawing.Size(98, 29)
        Me.mnuBtnGuardar.Text = "Guardar"
        Me.mnuBtnGuardar.ToolTipText = "Guarda los cambios"
        '
        'tabSeparador1
        '
        Me.tabSeparador1.Name = "tabSeparador1"
        Me.tabSeparador1.Size = New System.Drawing.Size(6, 23)
        '
        'mnuBtnCancelar
        '
        Me.mnuBtnCancelar.Enabled = False
        Me.mnuBtnCancelar.Image = CType(resources.GetObject("mnuBtnCancelar.Image"), System.Drawing.Image)
        Me.mnuBtnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuBtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBtnCancelar.Name = "mnuBtnCancelar"
        Me.mnuBtnCancelar.Size = New System.Drawing.Size(104, 29)
        Me.mnuBtnCancelar.Text = "Cancelar"
        Me.mnuBtnCancelar.ToolTipText = "Cancela los cambios"
        '
        'tabSeperador2
        '
        Me.tabSeperador2.Name = "tabSeperador2"
        Me.tabSeperador2.Size = New System.Drawing.Size(6, 23)
        '
        'mnuBtnNueva
        '
        Me.mnuBtnNueva.Image = CType(resources.GetObject("mnuBtnNueva.Image"), System.Drawing.Image)
        Me.mnuBtnNueva.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuBtnNueva.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBtnNueva.Name = "mnuBtnNueva"
        Me.mnuBtnNueva.Size = New System.Drawing.Size(83, 29)
        Me.mnuBtnNueva.Text = "Nueva"
        Me.mnuBtnNueva.ToolTipText = "Inicia una nueva busqueda"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'mnuBtnBuscar
        '
        Me.mnuBtnBuscar.Enabled = False
        Me.mnuBtnBuscar.Image = CType(resources.GetObject("mnuBtnBuscar.Image"), System.Drawing.Image)
        Me.mnuBtnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuBtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBtnBuscar.Name = "mnuBtnBuscar"
        Me.mnuBtnBuscar.Size = New System.Drawing.Size(90, 29)
        Me.mnuBtnBuscar.Text = "Buscar"
        Me.mnuBtnBuscar.ToolTipText = "Buscar registros"
        '
        'tabSeparador3
        '
        Me.tabSeparador3.Name = "tabSeparador3"
        Me.tabSeparador3.Size = New System.Drawing.Size(6, 23)
        '
        'mnuBtnBorrar
        '
        Me.mnuBtnBorrar.Enabled = False
        Me.mnuBtnBorrar.Image = CType(resources.GetObject("mnuBtnBorrar.Image"), System.Drawing.Image)
        Me.mnuBtnBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuBtnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBtnBorrar.Name = "mnuBtnBorrar"
        Me.mnuBtnBorrar.Size = New System.Drawing.Size(85, 29)
        Me.mnuBtnBorrar.Text = "Borrar"
        Me.mnuBtnBorrar.ToolTipText = "Borrar el registro en pantalla"
        '
        'tabSeparador4
        '
        Me.tabSeparador4.Name = "tabSeparador4"
        Me.tabSeparador4.Size = New System.Drawing.Size(6, 23)
        '
        'mnuBtnModificar
        '
        Me.mnuBtnModificar.Enabled = False
        Me.mnuBtnModificar.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuBtnModificar.Image = CType(resources.GetObject("mnuBtnModificar.Image"), System.Drawing.Image)
        Me.mnuBtnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuBtnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBtnModificar.Name = "mnuBtnModificar"
        Me.mnuBtnModificar.Size = New System.Drawing.Size(106, 29)
        Me.mnuBtnModificar.Text = "Modificar"
        Me.mnuBtnModificar.ToolTipText = "Modificar el registro en pantalla"
        '
        'tabDatosSintomas
        '
        Me.tabDatosSintomas.Controls.Add(Me.tabDatos)
        Me.tabDatosSintomas.Controls.Add(Me.tabBusqueda)
        Me.tabDatosSintomas.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabDatosSintomas.Location = New System.Drawing.Point(15, 130)
        Me.tabDatosSintomas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabDatosSintomas.Name = "tabDatosSintomas"
        Me.tabDatosSintomas.SelectedIndex = 0
        Me.tabDatosSintomas.Size = New System.Drawing.Size(881, 239)
        Me.tabDatosSintomas.TabIndex = 3
        Me.tabDatosSintomas.UseWaitCursor = True
        '
        'tabDatos
        '
        Me.tabDatos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabDatos.Controls.Add(Me.txtSintomaID)
        Me.tabDatos.Controls.Add(Me.lblSintomaID)
        Me.tabDatos.Controls.Add(Me.chkSintomaEstado)
        Me.tabDatos.Controls.Add(Me.txtSintomaNombre)
        Me.tabDatos.Controls.Add(Me.lblSintomaEstado)
        Me.tabDatos.Controls.Add(Me.lblSintomaNombre)
        Me.tabDatos.Location = New System.Drawing.Point(4, 28)
        Me.tabDatos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabDatos.Name = "tabDatos"
        Me.tabDatos.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabDatos.Size = New System.Drawing.Size(873, 207)
        Me.tabDatos.TabIndex = 0
        Me.tabDatos.Text = "Datos"
        Me.tabDatos.UseWaitCursor = True
        '
        'txtSintomaID
        '
        Me.txtSintomaID.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtSintomaID.Location = New System.Drawing.Point(164, 24)
        Me.txtSintomaID.Name = "txtSintomaID"
        Me.txtSintomaID.ReadOnly = True
        Me.txtSintomaID.Size = New System.Drawing.Size(83, 27)
        Me.txtSintomaID.TabIndex = 10
        Me.txtSintomaID.Text = "0"
        Me.txtSintomaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSintomaID.UseWaitCursor = True
        '
        'lblSintomaID
        '
        Me.lblSintomaID.AutoSize = True
        Me.lblSintomaID.Location = New System.Drawing.Point(103, 24)
        Me.lblSintomaID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSintomaID.Name = "lblSintomaID"
        Me.lblSintomaID.Size = New System.Drawing.Size(31, 19)
        Me.lblSintomaID.TabIndex = 9
        Me.lblSintomaID.Text = "ID:"
        Me.lblSintomaID.UseWaitCursor = True
        '
        'chkSintomaEstado
        '
        Me.chkSintomaEstado.AutoSize = True
        Me.chkSintomaEstado.Checked = True
        Me.chkSintomaEstado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSintomaEstado.Location = New System.Drawing.Point(164, 112)
        Me.chkSintomaEstado.Name = "chkSintomaEstado"
        Me.chkSintomaEstado.Size = New System.Drawing.Size(18, 17)
        Me.chkSintomaEstado.TabIndex = 8
        Me.chkSintomaEstado.UseVisualStyleBackColor = True
        Me.chkSintomaEstado.UseWaitCursor = True
        '
        'txtSintomaNombre
        '
        Me.txtSintomaNombre.Location = New System.Drawing.Point(164, 66)
        Me.txtSintomaNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSintomaNombre.MaxLength = 25
        Me.txtSintomaNombre.Name = "txtSintomaNombre"
        Me.txtSintomaNombre.Size = New System.Drawing.Size(276, 27)
        Me.txtSintomaNombre.TabIndex = 4
        Me.txtSintomaNombre.UseWaitCursor = True
        '
        'lblSintomaEstado
        '
        Me.lblSintomaEstado.AutoSize = True
        Me.lblSintomaEstado.Location = New System.Drawing.Point(25, 114)
        Me.lblSintomaEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSintomaEstado.Name = "lblSintomaEstado"
        Me.lblSintomaEstado.Size = New System.Drawing.Size(109, 19)
        Me.lblSintomaEstado.TabIndex = 2
        Me.lblSintomaEstado.Text = "HABILITADO:"
        Me.lblSintomaEstado.UseWaitCursor = True
        '
        'lblSintomaNombre
        '
        Me.lblSintomaNombre.AutoSize = True
        Me.lblSintomaNombre.Location = New System.Drawing.Point(51, 66)
        Me.lblSintomaNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSintomaNombre.Name = "lblSintomaNombre"
        Me.lblSintomaNombre.Size = New System.Drawing.Size(83, 19)
        Me.lblSintomaNombre.TabIndex = 1
        Me.lblSintomaNombre.Text = "NOMBRE:"
        Me.lblSintomaNombre.UseWaitCursor = True
        '
        'tabBusqueda
        '
        Me.tabBusqueda.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabBusqueda.Controls.Add(Me.dgSintomas)
        Me.tabBusqueda.Location = New System.Drawing.Point(4, 28)
        Me.tabBusqueda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabBusqueda.Name = "tabBusqueda"
        Me.tabBusqueda.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabBusqueda.Size = New System.Drawing.Size(873, 207)
        Me.tabBusqueda.TabIndex = 1
        Me.tabBusqueda.Text = "Busqueda"
        Me.tabBusqueda.UseWaitCursor = True
        '
        'dgSintomas
        '
        Me.dgSintomas.AllowUserToAddRows = False
        Me.dgSintomas.AllowUserToDeleteRows = False
        Me.dgSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSintomas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sintomaID, Me.sintmaNombre, Me.sintomaIntensidad, Me.sintomaEstado})
        Me.dgSintomas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSintomas.Location = New System.Drawing.Point(3, 2)
        Me.dgSintomas.Margin = New System.Windows.Forms.Padding(4)
        Me.dgSintomas.Name = "dgSintomas"
        Me.dgSintomas.ReadOnly = True
        Me.dgSintomas.Size = New System.Drawing.Size(867, 203)
        Me.dgSintomas.TabIndex = 0
        Me.dgSintomas.UseWaitCursor = True
        '
        'sintomaID
        '
        Me.sintomaID.HeaderText = "ID"
        Me.sintomaID.Name = "sintomaID"
        Me.sintomaID.ReadOnly = True
        '
        'sintmaNombre
        '
        Me.sintmaNombre.HeaderText = "NOMBRE"
        Me.sintmaNombre.Name = "sintmaNombre"
        Me.sintmaNombre.ReadOnly = True
        Me.sintmaNombre.Width = 250
        '
        'sintomaIntensidad
        '
        Me.sintomaIntensidad.HeaderText = "INTENSIDAD"
        Me.sintomaIntensidad.Name = "sintomaIntensidad"
        Me.sintomaIntensidad.ReadOnly = True
        Me.sintomaIntensidad.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.sintomaIntensidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'sintomaEstado
        '
        Me.sintomaEstado.HeaderText = "ESTADO"
        Me.sintomaEstado.Name = "sintomaEstado"
        Me.sintomaEstado.ReadOnly = True
        Me.sintomaEstado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.sintomaEstado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'frmSintomas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 380)
        Me.Controls.Add(Me.tabDatosSintomas)
        Me.Controls.Add(Me.toolsMenuSintoma)
        Me.Controls.Add(Me.picEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmSintomas"
        Me.ShowInTaskbar = False
        Me.Text = "SINTOMAS"
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolsMenuSintoma.ResumeLayout(False)
        Me.toolsMenuSintoma.PerformLayout()
        Me.tabDatosSintomas.ResumeLayout(False)
        Me.tabDatos.ResumeLayout(False)
        Me.tabDatos.PerformLayout()
        Me.tabBusqueda.ResumeLayout(False)
        CType(Me.dgSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picEncabezado As PictureBox
    Friend WithEvents toolsMenuSintoma As ToolStrip
    Friend WithEvents mnuBtnAgregar As ToolStripButton
    Friend WithEvents tabSeparador As ToolStripSeparator
    Friend WithEvents mnuBtnGuardar As ToolStripButton
    Friend WithEvents tabSeparador1 As ToolStripSeparator
    Friend WithEvents mnuBtnCancelar As ToolStripButton
    Friend WithEvents tabSeperador2 As ToolStripSeparator
    Friend WithEvents mnuBtnBuscar As ToolStripButton
    Friend WithEvents tabSeparador3 As ToolStripSeparator
    Friend WithEvents mnuBtnBorrar As ToolStripButton
    Friend WithEvents tabSeparador4 As ToolStripSeparator
    Friend WithEvents mnuBtnModificar As ToolStripButton
    Friend WithEvents tabDatosSintomas As TabControl
    Friend WithEvents tabDatos As TabPage
    Friend WithEvents txtSintomaNombre As TextBox
    Friend WithEvents lblSintomaEstado As Label
    Friend WithEvents lblSintomaNombre As Label
    Friend WithEvents dgSintomas As DataGridView
    Friend WithEvents chkSintomaEstado As CheckBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuBtnNueva As ToolStripButton
    Friend WithEvents tabBusqueda As TabPage
    Friend WithEvents lblSintomaID As Label
    Friend WithEvents txtSintomaID As TextBox
    Friend WithEvents sintomaID As DataGridViewTextBoxColumn
    Friend WithEvents sintmaNombre As DataGridViewTextBoxColumn
    Friend WithEvents sintomaIntensidad As DataGridViewCheckBoxColumn
    Friend WithEvents sintomaEstado As DataGridViewCheckBoxColumn
End Class
