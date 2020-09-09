<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaPatologiasSintomas
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
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.flpPatologiasPorSintoma = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(221, 264)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(92, 36)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'flpPatologiasPorSintoma
        '
        Me.flpPatologiasPorSintoma.AutoScroll = True
        Me.flpPatologiasPorSintoma.Location = New System.Drawing.Point(9, 11)
        Me.flpPatologiasPorSintoma.Name = "flpPatologiasPorSintoma"
        Me.flpPatologiasPorSintoma.Size = New System.Drawing.Size(304, 238)
        Me.flpPatologiasPorSintoma.TabIndex = 3
        '
        'frmListaPatologiasSintomas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 306)
        Me.Controls.Add(Me.flpPatologiasPorSintoma)
        Me.Controls.Add(Me.btnCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmListaPatologiasSintomas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Patologias por Sintomas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCerrar As Button
    Friend WithEvents flpPatologiasPorSintoma As FlowLayoutPanel
End Class
