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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblLeyendaEspera = New System.Windows.Forms.Label()
        Me.lblLeyendaEmail = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.appGestion.My.Resources.Resources.email
        Me.PictureBox1.Location = New System.Drawing.Point(28, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblLeyendaEspera
        '
        Me.lblLeyendaEspera.AutoSize = True
        Me.lblLeyendaEspera.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeyendaEspera.Location = New System.Drawing.Point(94, 21)
        Me.lblLeyendaEspera.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLeyendaEspera.Name = "lblLeyendaEspera"
        Me.lblLeyendaEspera.Size = New System.Drawing.Size(83, 20)
        Me.lblLeyendaEspera.TabIndex = 1
        Me.lblLeyendaEspera.Text = "Espera..."
        '
        'lblLeyendaEmail
        '
        Me.lblLeyendaEmail.AutoSize = True
        Me.lblLeyendaEmail.Location = New System.Drawing.Point(94, 46)
        Me.lblLeyendaEmail.Name = "lblLeyendaEmail"
        Me.lblLeyendaEmail.Size = New System.Drawing.Size(134, 20)
        Me.lblLeyendaEmail.TabIndex = 2
        Me.lblLeyendaEmail.Text = "Enviando email..."
        '
        'frmLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 81)
        Me.Controls.Add(Me.lblLeyendaEmail)
        Me.Controls.Add(Me.lblLeyendaEspera)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLoading"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLoading"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblLeyendaEspera As Label
    Friend WithEvents lblLeyendaEmail As Label
End Class
