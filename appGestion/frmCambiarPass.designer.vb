<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambiarPass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCambiarPass))
        Me.picEncabezado = New System.Windows.Forms.PictureBox()
        Me.lblNuevoPass = New System.Windows.Forms.Label()
        Me.lblRePass = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtRePass = New System.Windows.Forms.TextBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picEncabezado
        '
        Me.picEncabezado.Image = CType(resources.GetObject("picEncabezado.Image"), System.Drawing.Image)
        Me.picEncabezado.Location = New System.Drawing.Point(-18, 0)
        Me.picEncabezado.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.picEncabezado.Name = "picEncabezado"
        Me.picEncabezado.Size = New System.Drawing.Size(599, 99)
        Me.picEncabezado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picEncabezado.TabIndex = 4
        Me.picEncabezado.TabStop = False
        '
        'lblNuevoPass
        '
        Me.lblNuevoPass.Location = New System.Drawing.Point(59, 127)
        Me.lblNuevoPass.Name = "lblNuevoPass"
        Me.lblNuevoPass.Size = New System.Drawing.Size(149, 20)
        Me.lblNuevoPass.TabIndex = 6
        Me.lblNuevoPass.Text = "Nueva contraseña:"
        Me.lblNuevoPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRePass
        '
        Me.lblRePass.Location = New System.Drawing.Point(12, 171)
        Me.lblRePass.Name = "lblRePass"
        Me.lblRePass.Size = New System.Drawing.Size(196, 20)
        Me.lblRePass.TabIndex = 7
        Me.lblRePass.Text = "Reescribe la contraseña:"
        Me.lblRePass.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(214, 127)
        Me.txtPass.MaxLength = 9
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(179, 27)
        Me.txtPass.TabIndex = 8
        '
        'txtRePass
        '
        Me.txtRePass.Location = New System.Drawing.Point(214, 168)
        Me.txtRePass.MaxLength = 9
        Me.txtRePass.Name = "txtRePass"
        Me.txtRePass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRePass.Size = New System.Drawing.Size(179, 27)
        Me.txtRePass.TabIndex = 9
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(439, 121)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(130, 39)
        Me.btnConfirmar.TabIndex = 10
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'frmCambiarPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 235)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.txtRePass)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.lblRePass)
        Me.Controls.Add(Me.lblNuevoPass)
        Me.Controls.Add(Me.picEncabezado)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCambiarPass"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Cambio de contraseña"
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picEncabezado As PictureBox
    Friend WithEvents lblNuevoPass As Label
    Friend WithEvents lblRePass As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtRePass As TextBox
    Friend WithEvents btnConfirmar As Button
End Class
