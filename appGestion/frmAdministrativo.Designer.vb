<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdministrativo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdministrativo))
        Me.picEncabezado = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.mnuAgregar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.mnuGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.mnuCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.mnuBuscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.mnuBorrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton()
        Me.mnuEditar = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabDatos = New System.Windows.Forms.TabPage()
        Me.tabBusqueda = New System.Windows.Forms.TabPage()
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picEncabezado
        '
        Me.picEncabezado.Image = CType(resources.GetObject("picEncabezado.Image"), System.Drawing.Image)
        Me.picEncabezado.Location = New System.Drawing.Point(0, 0)
        Me.picEncabezado.Name = "picEncabezado"
        Me.picEncabezado.Size = New System.Drawing.Size(1059, 79)
        Me.picEncabezado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picEncabezado.TabIndex = 0
        Me.picEncabezado.TabStop = False
        Me.picEncabezado.UseWaitCursor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton9, Me.mnuAgregar, Me.ToolStripSeparator1, Me.ToolStripButton7, Me.mnuGuardar, Me.ToolStripSeparator2, Me.ToolStripButton8, Me.mnuCancelar, Me.ToolStripSeparator5, Me.ToolStripButton10, Me.mnuBuscar, Me.ToolStripSeparator3, Me.ToolStripButton11, Me.mnuBorrar, Me.ToolStripSeparator4, Me.ToolStripButton12, Me.mnuEditar})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 82)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1059, 44)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        Me.ToolStrip1.UseWaitCursor = True
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Enabled = False
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(29, 29)
        Me.ToolStripButton9.Text = "ToolStripButton9"
        '
        'mnuAgregar
        '
        Me.mnuAgregar.Image = CType(resources.GetObject("mnuAgregar.Image"), System.Drawing.Image)
        Me.mnuAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuAgregar.Name = "mnuAgregar"
        Me.mnuAgregar.Size = New System.Drawing.Size(97, 29)
        Me.mnuAgregar.Text = "Agregar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Enabled = False
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(29, 29)
        Me.ToolStripButton7.Text = "ToolStripButton7"
        '
        'mnuGuardar
        '
        Me.mnuGuardar.Enabled = False
        Me.mnuGuardar.Image = CType(resources.GetObject("mnuGuardar.Image"), System.Drawing.Image)
        Me.mnuGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuGuardar.Name = "mnuGuardar"
        Me.mnuGuardar.Size = New System.Drawing.Size(98, 29)
        Me.mnuGuardar.Text = "Guardar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Enabled = False
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(29, 29)
        Me.ToolStripButton8.Text = "ToolStripButton8"
        '
        'mnuCancelar
        '
        Me.mnuCancelar.Enabled = False
        Me.mnuCancelar.Image = CType(resources.GetObject("mnuCancelar.Image"), System.Drawing.Image)
        Me.mnuCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuCancelar.Name = "mnuCancelar"
        Me.mnuCancelar.Size = New System.Drawing.Size(104, 29)
        Me.mnuCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Enabled = False
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.Size = New System.Drawing.Size(29, 29)
        Me.ToolStripButton10.Text = "ToolStripButton10"
        '
        'mnuBuscar
        '
        Me.mnuBuscar.Image = CType(resources.GetObject("mnuBuscar.Image"), System.Drawing.Image)
        Me.mnuBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBuscar.Name = "mnuBuscar"
        Me.mnuBuscar.Size = New System.Drawing.Size(90, 29)
        Me.mnuBuscar.Text = "Buscar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton11.Enabled = False
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.Size = New System.Drawing.Size(29, 29)
        Me.ToolStripButton11.Text = "ToolStripButton11"
        '
        'mnuBorrar
        '
        Me.mnuBorrar.Enabled = False
        Me.mnuBorrar.Image = CType(resources.GetObject("mnuBorrar.Image"), System.Drawing.Image)
        Me.mnuBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBorrar.Name = "mnuBorrar"
        Me.mnuBorrar.Size = New System.Drawing.Size(85, 29)
        Me.mnuBorrar.Text = "Borrar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton12.Enabled = False
        Me.ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"), System.Drawing.Image)
        Me.ToolStripButton12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.Size = New System.Drawing.Size(29, 29)
        Me.ToolStripButton12.Text = "ToolStripButton12"
        '
        'mnuEditar
        '
        Me.mnuEditar.Enabled = False
        Me.mnuEditar.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuEditar.Image = CType(resources.GetObject("mnuEditar.Image"), System.Drawing.Image)
        Me.mnuEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuEditar.Name = "mnuEditar"
        Me.mnuEditar.Size = New System.Drawing.Size(106, 29)
        Me.mnuEditar.Text = "Modificar"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabDatos)
        Me.TabControl1.Controls.Add(Me.tabBusqueda)
        Me.TabControl1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(20, 135)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1024, 397)
        Me.TabControl1.TabIndex = 2
        Me.TabControl1.UseWaitCursor = True
        '
        'tabDatos
        '
        Me.tabDatos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabDatos.Location = New System.Drawing.Point(4, 28)
        Me.tabDatos.Name = "tabDatos"
        Me.tabDatos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDatos.Size = New System.Drawing.Size(1016, 365)
        Me.tabDatos.TabIndex = 0
        Me.tabDatos.Text = "Datos"
        Me.tabDatos.UseWaitCursor = True
        '
        'tabBusqueda
        '
        Me.tabBusqueda.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabBusqueda.Location = New System.Drawing.Point(4, 28)
        Me.tabBusqueda.Name = "tabBusqueda"
        Me.tabBusqueda.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBusqueda.Size = New System.Drawing.Size(1016, 365)
        Me.tabBusqueda.TabIndex = 1
        Me.tabBusqueda.Text = "Busqueda"
        Me.tabBusqueda.UseWaitCursor = True
        '
        'frmAdministrativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 554)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.picEncabezado)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdministrativo"
        Me.Text = "Administrativo"
        Me.UseWaitCursor = True
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picEncabezado As PictureBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton9 As ToolStripButton
    Friend WithEvents mnuAgregar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents mnuGuardar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents mnuCancelar As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton10 As ToolStripButton
    Friend WithEvents mnuBuscar As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton11 As ToolStripButton
    Friend WithEvents mnuBorrar As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripButton12 As ToolStripButton
    Friend WithEvents mnuEditar As ToolStripButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabDatos As TabPage
    Friend WithEvents tabBusqueda As TabPage
End Class
