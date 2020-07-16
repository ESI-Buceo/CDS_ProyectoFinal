<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoading
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
        Me.lblCancel = New System.Windows.Forms.Label()
        Me.lblEsperaMedico = New System.Windows.Forms.Label()
        Me.picLoader = New System.Windows.Forms.PictureBox()
        CType(Me.picLoader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCancel
        '
        Me.lblCancel.AutoSize = True
        Me.lblCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCancel.Location = New System.Drawing.Point(152, 170)
        Me.lblCancel.Name = "lblCancel"
        Me.lblCancel.Size = New System.Drawing.Size(76, 20)
        Me.lblCancel.TabIndex = 1
        Me.lblCancel.Text = "Cancelar"
        '
        'lblEsperaMedico
        '
        Me.lblEsperaMedico.AutoSize = True
        Me.lblEsperaMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEsperaMedico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblEsperaMedico.Location = New System.Drawing.Point(104, 20)
        Me.lblEsperaMedico.Name = "lblEsperaMedico"
        Me.lblEsperaMedico.Size = New System.Drawing.Size(160, 20)
        Me.lblEsperaMedico.TabIndex = 2
        Me.lblEsperaMedico.Text = "Esperando medico..."
        '
        'picLoader
        '
        Me.picLoader.Location = New System.Drawing.Point(108, 56)
        Me.picLoader.Name = "picLoader"
        Me.picLoader.Size = New System.Drawing.Size(156, 102)
        Me.picLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLoader.TabIndex = 3
        Me.picLoader.TabStop = False
        '
        'frmLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(392, 207)
        Me.ControlBox = False
        Me.Controls.Add(Me.picLoader)
        Me.Controls.Add(Me.lblEsperaMedico)
        Me.Controls.Add(Me.lblCancel)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmLoading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TransparencyKey = System.Drawing.SystemColors.ActiveBorder
        CType(Me.picLoader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCancel As Label
    Friend WithEvents lblEsperaMedico As Label
    Friend WithEvents picLoader As PictureBox
End Class
