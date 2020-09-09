<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParametros))
        Me.picEncabezado = New System.Windows.Forms.PictureBox()
        Me.gbParametros = New System.Windows.Forms.GroupBox()
        Me.cbLenguaje = New System.Windows.Forms.ComboBox()
        Me.lblLenguaje = New System.Windows.Forms.Label()
        Me.lblDescIdiomaSistema = New System.Windows.Forms.Label()
        Me.lblLengSistema = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbParametros.SuspendLayout()
        Me.SuspendLayout()
        '
        'picEncabezado
        '
        Me.picEncabezado.Image = CType(resources.GetObject("picEncabezado.Image"), System.Drawing.Image)
        Me.picEncabezado.Location = New System.Drawing.Point(-11, -1)
        Me.picEncabezado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picEncabezado.Name = "picEncabezado"
        Me.picEncabezado.Size = New System.Drawing.Size(799, 79)
        Me.picEncabezado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picEncabezado.TabIndex = 4
        Me.picEncabezado.TabStop = False
        '
        'gbParametros
        '
        Me.gbParametros.Controls.Add(Me.cbLenguaje)
        Me.gbParametros.Controls.Add(Me.lblLenguaje)
        Me.gbParametros.Controls.Add(Me.lblDescIdiomaSistema)
        Me.gbParametros.Controls.Add(Me.lblLengSistema)
        Me.gbParametros.Location = New System.Drawing.Point(21, 111)
        Me.gbParametros.Name = "gbParametros"
        Me.gbParametros.Size = New System.Drawing.Size(744, 172)
        Me.gbParametros.TabIndex = 5
        Me.gbParametros.TabStop = False
        Me.gbParametros.Text = "Opciones de Configuracion"
        '
        'cbLenguaje
        '
        Me.cbLenguaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLenguaje.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cbLenguaje.FormattingEnabled = True
        Me.cbLenguaje.Location = New System.Drawing.Point(121, 94)
        Me.cbLenguaje.Name = "cbLenguaje"
        Me.cbLenguaje.Size = New System.Drawing.Size(93, 28)
        Me.cbLenguaje.TabIndex = 7
        '
        'lblLenguaje
        '
        Me.lblLenguaje.AutoSize = True
        Me.lblLenguaje.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblLenguaje.Location = New System.Drawing.Point(23, 98)
        Me.lblLenguaje.Name = "lblLenguaje"
        Me.lblLenguaje.Size = New System.Drawing.Size(82, 20)
        Me.lblLenguaje.TabIndex = 6
        Me.lblLenguaje.Text = "Lenguaje:"
        '
        'lblDescIdiomaSistema
        '
        Me.lblDescIdiomaSistema.Location = New System.Drawing.Point(20, 60)
        Me.lblDescIdiomaSistema.Name = "lblDescIdiomaSistema"
        Me.lblDescIdiomaSistema.Size = New System.Drawing.Size(702, 30)
        Me.lblDescIdiomaSistema.TabIndex = 5
        Me.lblDescIdiomaSistema.Text = "Idioma del sistema, este cambio requiere reiniciar la aplicacion."
        '
        'lblLengSistema
        '
        Me.lblLengSistema.AutoSize = True
        Me.lblLengSistema.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLengSistema.Location = New System.Drawing.Point(20, 33)
        Me.lblLengSistema.Name = "lblLengSistema"
        Me.lblLengSistema.Size = New System.Drawing.Size(186, 24)
        Me.lblLengSistema.TabIndex = 4
        Me.lblLengSistema.Text = "Idioma del Sistema"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(631, 302)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(134, 47)
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.Text = "Button1"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'frmParametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 366)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.gbParametros)
        Me.Controls.Add(Me.picEncabezado)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmParametros"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmParametros"
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbParametros.ResumeLayout(False)
        Me.gbParametros.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picEncabezado As PictureBox
    Friend WithEvents gbParametros As GroupBox
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblLengSistema As Label
    Friend WithEvents lblDescIdiomaSistema As Label
    Friend WithEvents lblLenguaje As Label
    Friend WithEvents cbLenguaje As ComboBox
End Class
