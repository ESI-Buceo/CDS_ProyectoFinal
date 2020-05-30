<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaSintomas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaSintomas))
        Me.picEncabezado = New System.Windows.Forms.PictureBox()
        Me.lblEscribirSintoma = New System.Windows.Forms.Label()
        Me.txtNombreSintoma = New System.Windows.Forms.TextBox()
        Me.dgvListaSintomas = New System.Windows.Forms.DataGridView()
        Me.colSintomaID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSintomaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCerrar = New System.Windows.Forms.Button()
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListaSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picEncabezado
        '
        Me.picEncabezado.Image = CType(resources.GetObject("picEncabezado.Image"), System.Drawing.Image)
        Me.picEncabezado.Location = New System.Drawing.Point(-5, 1)
        Me.picEncabezado.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.picEncabezado.Name = "picEncabezado"
        Me.picEncabezado.Size = New System.Drawing.Size(432, 68)
        Me.picEncabezado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picEncabezado.TabIndex = 3
        Me.picEncabezado.TabStop = False
        Me.picEncabezado.UseWaitCursor = True
        '
        'lblEscribirSintoma
        '
        Me.lblEscribirSintoma.AutoSize = True
        Me.lblEscribirSintoma.Location = New System.Drawing.Point(13, 89)
        Me.lblEscribirSintoma.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEscribirSintoma.Name = "lblEscribirSintoma"
        Me.lblEscribirSintoma.Size = New System.Drawing.Size(166, 22)
        Me.lblEscribirSintoma.TabIndex = 4
        Me.lblEscribirSintoma.Text = "Escribe el sintoma"
        '
        'txtNombreSintoma
        '
        Me.txtNombreSintoma.Location = New System.Drawing.Point(17, 123)
        Me.txtNombreSintoma.Name = "txtNombreSintoma"
        Me.txtNombreSintoma.Size = New System.Drawing.Size(395, 28)
        Me.txtNombreSintoma.TabIndex = 5
        '
        'dgvListaSintomas
        '
        Me.dgvListaSintomas.AllowUserToAddRows = False
        Me.dgvListaSintomas.AllowUserToDeleteRows = False
        Me.dgvListaSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaSintomas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSintomaID, Me.colSintomaNombre})
        Me.dgvListaSintomas.Location = New System.Drawing.Point(17, 167)
        Me.dgvListaSintomas.Name = "dgvListaSintomas"
        Me.dgvListaSintomas.ReadOnly = True
        Me.dgvListaSintomas.RowTemplate.Height = 24
        Me.dgvListaSintomas.Size = New System.Drawing.Size(395, 307)
        Me.dgvListaSintomas.TabIndex = 6
        '
        'colSintomaID
        '
        Me.colSintomaID.HeaderText = "ID"
        Me.colSintomaID.Name = "colSintomaID"
        Me.colSintomaID.ReadOnly = True
        '
        'colSintomaNombre
        '
        Me.colSintomaNombre.HeaderText = "NOMBRE"
        Me.colSintomaNombre.Name = "colSintomaNombre"
        Me.colSintomaNombre.ReadOnly = True
        Me.colSintomaNombre.Width = 230
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(292, 490)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(120, 35)
        Me.btnCerrar.TabIndex = 7
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'frmListaSintomas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 543)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.dgvListaSintomas)
        Me.Controls.Add(Me.txtNombreSintoma)
        Me.Controls.Add(Me.lblEscribirSintoma)
        Me.Controls.Add(Me.picEncabezado)
        Me.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmListaSintomas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lista de Sintomas"
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListaSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picEncabezado As PictureBox
    Friend WithEvents lblEscribirSintoma As Label
    Friend WithEvents txtNombreSintoma As TextBox
    Friend WithEvents dgvListaSintomas As DataGridView
    Friend WithEvents btnCerrar As Button
    Friend WithEvents colSintomaID As DataGridViewTextBoxColumn
    Friend WithEvents colSintomaNombre As DataGridViewTextBoxColumn
End Class
