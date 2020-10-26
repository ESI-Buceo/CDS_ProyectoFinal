<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDatosLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblDocIdentidad = New System.Windows.Forms.Label()
        Me.txtDocIdentidad = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnGestionIngresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDocIdentidad
        '
        Me.lblDocIdentidad.ForeColor = System.Drawing.Color.White
        Me.lblDocIdentidad.Location = New System.Drawing.Point(39, 102)
        Me.lblDocIdentidad.Name = "lblDocIdentidad"
        Me.lblDocIdentidad.Size = New System.Drawing.Size(220, 37)
        Me.lblDocIdentidad.TabIndex = 0
        Me.lblDocIdentidad.Text = "Numero de Gestor"
        Me.lblDocIdentidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDocIdentidad
        '
        Me.txtDocIdentidad.BackColor = System.Drawing.Color.White
        Me.txtDocIdentidad.Location = New System.Drawing.Point(62, 142)
        Me.txtDocIdentidad.Name = "txtDocIdentidad"
        Me.txtDocIdentidad.Size = New System.Drawing.Size(177, 30)
        Me.txtDocIdentidad.TabIndex = 1
        '
        'lblPassword
        '
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(62, 187)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(173, 23)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(62, 211)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(177, 30)
        Me.txtPassword.TabIndex = 3
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
        'frmDatosLogin
        '
        Me.AcceptButton = Me.btnGestionIngresar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(317, 390)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnGestionIngresar)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtDocIdentidad)
        Me.Controls.Add(Me.lblDocIdentidad)
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

    Friend WithEvents lblDocIdentidad As Label
    Friend WithEvents txtDocIdentidad As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnGestionIngresar As Button
End Class
