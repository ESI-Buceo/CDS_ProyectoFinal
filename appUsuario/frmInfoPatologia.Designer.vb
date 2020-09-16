<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfoPatologia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInfoPatologia))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPatologia = New System.Windows.Forms.Label()
        Me.lblPatDesc = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(540, 206)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblPatologia
        '
        Me.lblPatologia.AutoSize = True
        Me.lblPatologia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatologia.Location = New System.Drawing.Point(12, 220)
        Me.lblPatologia.Name = "lblPatologia"
        Me.lblPatologia.Size = New System.Drawing.Size(77, 25)
        Me.lblPatologia.TabIndex = 1
        Me.lblPatologia.Text = "Label1"
        '
        'lblPatDesc
        '
        Me.lblPatDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatDesc.Location = New System.Drawing.Point(14, 256)
        Me.lblPatDesc.Name = "lblPatDesc"
        Me.lblPatDesc.Size = New System.Drawing.Size(508, 269)
        Me.lblPatDesc.TabIndex = 2
        Me.lblPatDesc.Text = "Label1"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(430, 562)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(92, 39)
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'frmInfoPatologia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 613)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.lblPatDesc)
        Me.Controls.Add(Me.lblPatologia)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmInfoPatologia"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPatologia As Label
    Friend WithEvents lblPatDesc As Label
    Friend WithEvents btnCerrar As Button
End Class
