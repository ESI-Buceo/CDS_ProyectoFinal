<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblBienvenido = New System.Windows.Forms.Label()
        Me.lblLeyenda = New System.Windows.Forms.Label()
        Me.lblDocumento = New System.Windows.Forms.Label()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.chkRecordar = New System.Windows.Forms.CheckBox()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLogo
        '
        Me.picLogo.Image = Global.appMedico.My.Resources.Resources.logo_App
        Me.picLogo.Location = New System.Drawing.Point(74, 46)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(306, 96)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'lblBienvenido
        '
        Me.lblBienvenido.AutoSize = True
        Me.lblBienvenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenido.Location = New System.Drawing.Point(173, 174)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(109, 25)
        Me.lblBienvenido.TabIndex = 1
        Me.lblBienvenido.Text = "Bienvenido"
        '
        'lblLeyenda
        '
        Me.lblLeyenda.Location = New System.Drawing.Point(96, 203)
        Me.lblLeyenda.Name = "lblLeyenda"
        Me.lblLeyenda.Size = New System.Drawing.Size(262, 43)
        Me.lblLeyenda.TabIndex = 2
        Me.lblLeyenda.Text = "Ingresa tus credenciales para acceder al sistema"
        Me.lblLeyenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDocumento
        '
        Me.lblDocumento.AutoSize = True
        Me.lblDocumento.Location = New System.Drawing.Point(132, 277)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(190, 20)
        Me.lblDocumento.TabIndex = 3
        Me.lblDocumento.Text = "Documento de identidad"
        '
        'txtDocumento
        '
        Me.txtDocumento.Location = New System.Drawing.Point(136, 307)
        Me.txtDocumento.MaxLength = 9
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(183, 27)
        Me.txtDocumento.TabIndex = 4
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(142, 353)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(171, 20)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Ingresa tu contraseña"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(136, 382)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(183, 27)
        Me.txtPassword.TabIndex = 6
        '
        'btnIngresar
        '
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIngresar.Location = New System.Drawing.Point(136, 453)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(182, 52)
        Me.btnIngresar.TabIndex = 7
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'chkRecordar
        '
        Me.chkRecordar.AutoSize = True
        Me.chkRecordar.Location = New System.Drawing.Point(136, 420)
        Me.chkRecordar.Name = "chkRecordar"
        Me.chkRecordar.Size = New System.Drawing.Size(178, 24)
        Me.chkRecordar.TabIndex = 9
        Me.chkRecordar.Text = "Recordar mis datos"
        Me.chkRecordar.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnIngresar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 575)
        Me.Controls.Add(Me.chkRecordar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtDocumento)
        Me.Controls.Add(Me.lblDocumento)
        Me.Controls.Add(Me.lblLeyenda)
        Me.Controls.Add(Me.lblBienvenido)
        Me.Controls.Add(Me.picLogo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLogin"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso al sistema"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblBienvenido As Label
    Friend WithEvents lblLeyenda As Label
    Friend WithEvents lblDocumento As Label
    Friend WithEvents txtDocumento As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents chkRecordar As CheckBox
End Class
