<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatosLogin
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
        Me.lblNumeroGestor = New System.Windows.Forms.Label()
        Me.txtNumeroGestor = New System.Windows.Forms.TextBox()
        Me.lblPasswordGestor = New System.Windows.Forms.Label()
        Me.txtPasswordGestor = New System.Windows.Forms.TextBox()
        Me.btnGestionIngresar = New System.Windows.Forms.Button()
        Me.lblLinkRecPassword = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'lblNumeroGestor
        '
        Me.lblNumeroGestor.AutoSize = True
        Me.lblNumeroGestor.ForeColor = System.Drawing.Color.White
        Me.lblNumeroGestor.Location = New System.Drawing.Point(62, 116)
        Me.lblNumeroGestor.Name = "lblNumeroGestor"
        Me.lblNumeroGestor.Size = New System.Drawing.Size(173, 23)
        Me.lblNumeroGestor.TabIndex = 0
        Me.lblNumeroGestor.Text = "Numero de Gestor"
        '
        'txtNumeroGestor
        '
        Me.txtNumeroGestor.BackColor = System.Drawing.Color.White
        Me.txtNumeroGestor.Location = New System.Drawing.Point(62, 142)
        Me.txtNumeroGestor.Name = "txtNumeroGestor"
        Me.txtNumeroGestor.Size = New System.Drawing.Size(177, 30)
        Me.txtNumeroGestor.TabIndex = 1
        '
        'lblPasswordGestor
        '
        Me.lblPasswordGestor.AutoSize = True
        Me.lblPasswordGestor.ForeColor = System.Drawing.Color.White
        Me.lblPasswordGestor.Location = New System.Drawing.Point(62, 187)
        Me.lblPasswordGestor.Name = "lblPasswordGestor"
        Me.lblPasswordGestor.Size = New System.Drawing.Size(98, 23)
        Me.lblPasswordGestor.TabIndex = 2
        Me.lblPasswordGestor.Text = "Password"
        '
        'txtPasswordGestor
        '
        Me.txtPasswordGestor.Location = New System.Drawing.Point(62, 211)
        Me.txtPasswordGestor.Name = "txtPasswordGestor"
        Me.txtPasswordGestor.Size = New System.Drawing.Size(177, 30)
        Me.txtPasswordGestor.TabIndex = 3
        '
        'btnGestionIngresar
        '
        Me.btnGestionIngresar.BackColor = System.Drawing.Color.White
        Me.btnGestionIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnGestionIngresar.FlatAppearance.BorderSize = 2
        Me.btnGestionIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGestionIngresar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGestionIngresar.Location = New System.Drawing.Point(62, 255)
        Me.btnGestionIngresar.Name = "btnGestionIngresar"
        Me.btnGestionIngresar.Size = New System.Drawing.Size(177, 38)
        Me.btnGestionIngresar.TabIndex = 4
        Me.btnGestionIngresar.Text = "Ingresar"
        Me.btnGestionIngresar.UseVisualStyleBackColor = False
        '
        'lblLinkRecPassword
        '
        Me.lblLinkRecPassword.AutoSize = True
        Me.lblLinkRecPassword.LinkColor = System.Drawing.Color.White
        Me.lblLinkRecPassword.Location = New System.Drawing.Point(62, 318)
        Me.lblLinkRecPassword.Name = "lblLinkRecPassword"
        Me.lblLinkRecPassword.Size = New System.Drawing.Size(229, 23)
        Me.lblLinkRecPassword.TabIndex = 5
        Me.lblLinkRecPassword.TabStop = True
        Me.lblLinkRecPassword.Text = "Olvidaste tu contraseña?"
        '
        'frmDatosLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(317, 390)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblLinkRecPassword)
        Me.Controls.Add(Me.btnGestionIngresar)
        Me.Controls.Add(Me.txtPasswordGestor)
        Me.Controls.Add(Me.lblPasswordGestor)
        Me.Controls.Add(Me.txtNumeroGestor)
        Me.Controls.Add(Me.lblNumeroGestor)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmDatosLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "datosLogin"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumeroGestor As Label
    Friend WithEvents txtNumeroGestor As TextBox
    Friend WithEvents lblPasswordGestor As Label
    Friend WithEvents txtPasswordGestor As TextBox
    Friend WithEvents btnGestionIngresar As Button
    Friend WithEvents lblLinkRecPassword As LinkLabel
End Class
