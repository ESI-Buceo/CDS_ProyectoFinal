<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLeerArchivo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLeerArchivo))
        Me.picEncabezado = New System.Windows.Forms.PictureBox()
        Me.opfArchivoCsv = New System.Windows.Forms.OpenFileDialog()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.gbBuscarArchivo = New System.Windows.Forms.GroupBox()
        Me.cmbDestino = New System.Windows.Forms.ComboBox()
        Me.lblDestino = New System.Windows.Forms.Label()
        Me.lblNombreArchivo = New System.Windows.Forms.Label()
        Me.btnRecuperar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvDatosCSV = New System.Windows.Forms.DataGridView()
        Me.btnGuardarEnBD = New System.Windows.Forms.Button()
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBuscarArchivo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDatosCSV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picEncabezado
        '
        Me.picEncabezado.Image = CType(resources.GetObject("picEncabezado.Image"), System.Drawing.Image)
        Me.picEncabezado.Location = New System.Drawing.Point(-19, 0)
        Me.picEncabezado.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.picEncabezado.Name = "picEncabezado"
        Me.picEncabezado.Size = New System.Drawing.Size(799, 99)
        Me.picEncabezado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picEncabezado.TabIndex = 4
        Me.picEncabezado.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(18, 225)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(105, 38)
        Me.btnBuscar.TabIndex = 7
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'gbBuscarArchivo
        '
        Me.gbBuscarArchivo.Controls.Add(Me.cmbDestino)
        Me.gbBuscarArchivo.Controls.Add(Me.lblDestino)
        Me.gbBuscarArchivo.Controls.Add(Me.lblNombreArchivo)
        Me.gbBuscarArchivo.Location = New System.Drawing.Point(18, 117)
        Me.gbBuscarArchivo.Name = "gbBuscarArchivo"
        Me.gbBuscarArchivo.Size = New System.Drawing.Size(749, 98)
        Me.gbBuscarArchivo.TabIndex = 8
        Me.gbBuscarArchivo.TabStop = False
        Me.gbBuscarArchivo.Text = "Origen y Destino"
        '
        'cmbDestino
        '
        Me.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDestino.FormattingEnabled = True
        Me.cmbDestino.Items.AddRange(New Object() {"Sintomas", "Patologias"})
        Me.cmbDestino.Location = New System.Drawing.Point(590, 32)
        Me.cmbDestino.Name = "cmbDestino"
        Me.cmbDestino.Size = New System.Drawing.Size(139, 28)
        Me.cmbDestino.TabIndex = 10
        '
        'lblDestino
        '
        Me.lblDestino.Location = New System.Drawing.Point(478, 35)
        Me.lblDestino.Name = "lblDestino"
        Me.lblDestino.Size = New System.Drawing.Size(106, 20)
        Me.lblDestino.TabIndex = 9
        Me.lblDestino.Text = "Destino"
        Me.lblDestino.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNombreArchivo
        '
        Me.lblNombreArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreArchivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNombreArchivo.Location = New System.Drawing.Point(19, 33)
        Me.lblNombreArchivo.Name = "lblNombreArchivo"
        Me.lblNombreArchivo.Size = New System.Drawing.Size(383, 51)
        Me.lblNombreArchivo.TabIndex = 8
        '
        'btnRecuperar
        '
        Me.btnRecuperar.Enabled = False
        Me.btnRecuperar.Location = New System.Drawing.Point(662, 225)
        Me.btnRecuperar.Name = "btnRecuperar"
        Me.btnRecuperar.Size = New System.Drawing.Size(105, 38)
        Me.btnRecuperar.TabIndex = 9
        Me.btnRecuperar.Text = "Recuperar"
        Me.btnRecuperar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvDatosCSV)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 286)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(747, 311)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'dgvDatosCSV
        '
        Me.dgvDatosCSV.AllowUserToAddRows = False
        Me.dgvDatosCSV.AllowUserToDeleteRows = False
        Me.dgvDatosCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatosCSV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDatosCSV.Location = New System.Drawing.Point(3, 23)
        Me.dgvDatosCSV.Name = "dgvDatosCSV"
        Me.dgvDatosCSV.ReadOnly = True
        Me.dgvDatosCSV.RowTemplate.Height = 24
        Me.dgvDatosCSV.Size = New System.Drawing.Size(741, 285)
        Me.dgvDatosCSV.TabIndex = 0
        '
        'btnGuardarEnBD
        '
        Me.btnGuardarEnBD.Location = New System.Drawing.Point(608, 607)
        Me.btnGuardarEnBD.Name = "btnGuardarEnBD"
        Me.btnGuardarEnBD.Size = New System.Drawing.Size(158, 41)
        Me.btnGuardarEnBD.TabIndex = 11
        Me.btnGuardarEnBD.Text = "Exportar a DB"
        Me.btnGuardarEnBD.UseVisualStyleBackColor = True
        '
        'frmLeerArchivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 665)
        Me.Controls.Add(Me.btnGuardarEnBD)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnRecuperar)
        Me.Controls.Add(Me.gbBuscarArchivo)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.picEncabezado)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLeerArchivo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Cargar archivo CSV"
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBuscarArchivo.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvDatosCSV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picEncabezado As PictureBox
    Friend WithEvents opfArchivoCsv As OpenFileDialog
    Friend WithEvents btnBuscar As Button
    Friend WithEvents gbBuscarArchivo As GroupBox
    Friend WithEvents lblNombreArchivo As Label
    Friend WithEvents btnRecuperar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnGuardarEnBD As Button
    Friend WithEvents dgvDatosCSV As DataGridView
    Friend WithEvents lblDestino As Label
    Friend WithEvents cmbDestino As ComboBox
End Class
