<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRankingPatologias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRankingPatologias))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.picEncabezado = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dgvRankingPatologias = New System.Windows.Forms.DataGridView()
        Me.idPatologia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRankingPatologias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picEncabezado
        '
        Me.picEncabezado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.picEncabezado.Image = CType(resources.GetObject("picEncabezado.Image"), System.Drawing.Image)
        Me.picEncabezado.Location = New System.Drawing.Point(-3, 1)
        Me.picEncabezado.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.picEncabezado.Name = "picEncabezado"
        Me.picEncabezado.Size = New System.Drawing.Size(537, 99)
        Me.picEncabezado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picEncabezado.TabIndex = 4
        Me.picEncabezado.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(9, 107)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(606, 29)
        Me.lblTitulo.TabIndex = 6
        Me.lblTitulo.Text = "Ranking de patologias en los ultimos 12 meses moviles"
        '
        'dgvRankingPatologias
        '
        Me.dgvRankingPatologias.AllowUserToAddRows = False
        Me.dgvRankingPatologias.AllowUserToDeleteRows = False
        Me.dgvRankingPatologias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRankingPatologias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idPatologia, Me.colNombre, Me.colCant})
        Me.dgvRankingPatologias.Location = New System.Drawing.Point(12, 144)
        Me.dgvRankingPatologias.Name = "dgvRankingPatologias"
        Me.dgvRankingPatologias.ReadOnly = True
        Me.dgvRankingPatologias.RowTemplate.Height = 24
        Me.dgvRankingPatologias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRankingPatologias.Size = New System.Drawing.Size(509, 388)
        Me.dgvRankingPatologias.TabIndex = 7
        '
        'idPatologia
        '
        Me.idPatologia.DataPropertyName = "id"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.idPatologia.DefaultCellStyle = DataGridViewCellStyle1
        Me.idPatologia.HeaderText = "ID"
        Me.idPatologia.Name = "idPatologia"
        Me.idPatologia.ReadOnly = True
        Me.idPatologia.Width = 50
        '
        'colNombre
        '
        Me.colNombre.DataPropertyName = "nombre"
        Me.colNombre.HeaderText = "Patologia"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.ReadOnly = True
        Me.colNombre.Width = 300
        '
        'colCant
        '
        Me.colCant.DataPropertyName = "cantidad"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCant.DefaultCellStyle = DataGridViewCellStyle2
        Me.colCant.HeaderText = "Cantidad"
        Me.colCant.Name = "colCant"
        Me.colCant.ReadOnly = True
        '
        'frmRankingPatologias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 545)
        Me.Controls.Add(Me.dgvRankingPatologias)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.picEncabezado)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRankingPatologias"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Ranking Patologias"
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRankingPatologias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picEncabezado As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents dgvRankingPatologias As DataGridView
    Friend WithEvents idPatologia As DataGridViewTextBoxColumn
    Friend WithEvents colNombre As DataGridViewTextBoxColumn
    Friend WithEvents colCant As DataGridViewTextBoxColumn
End Class
