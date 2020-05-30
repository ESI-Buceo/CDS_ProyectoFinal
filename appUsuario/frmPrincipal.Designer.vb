<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.PanelInicio = New System.Windows.Forms.Panel()
        Me.btnIngresarInvitado = New System.Windows.Forms.Button()
        Me.btnIniciarAutenticado = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.PanelInicio.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelInicio
        '
        Me.PanelInicio.Controls.Add(Me.btnIngresarInvitado)
        Me.PanelInicio.Controls.Add(Me.btnIniciarAutenticado)
        Me.PanelInicio.Controls.Add(Me.picLogo)
        Me.PanelInicio.Location = New System.Drawing.Point(1, 42)
        Me.PanelInicio.Name = "PanelInicio"
        Me.PanelInicio.Size = New System.Drawing.Size(1145, 614)
        Me.PanelInicio.TabIndex = 0
        '
        'btnIngresarInvitado
        '
        Me.btnIngresarInvitado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresarInvitado.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnIngresarInvitado.Location = New System.Drawing.Point(412, 341)
        Me.btnIngresarInvitado.Name = "btnIngresarInvitado"
        Me.btnIngresarInvitado.Size = New System.Drawing.Size(322, 75)
        Me.btnIngresarInvitado.TabIndex = 3
        Me.btnIngresarInvitado.Text = "Ingresar como invitado"
        Me.btnIngresarInvitado.UseVisualStyleBackColor = True
        '
        'btnIniciarAutenticado
        '
        Me.btnIniciarAutenticado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniciarAutenticado.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnIniciarAutenticado.Location = New System.Drawing.Point(412, 245)
        Me.btnIniciarAutenticado.Name = "btnIniciarAutenticado"
        Me.btnIniciarAutenticado.Size = New System.Drawing.Size(322, 75)
        Me.btnIniciarAutenticado.TabIndex = 2
        Me.btnIniciarAutenticado.Text = "Usuario registrado"
        Me.btnIniciarAutenticado.UseVisualStyleBackColor = True
        '
        'picLogo
        '
        Me.picLogo.Image = Global.appUsuario.My.Resources.Resources.logo_App
        Me.picLogo.Location = New System.Drawing.Point(308, 15)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(530, 147)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 1
        Me.picLogo.TabStop = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1146, 658)
        Me.Controls.Add(Me.PanelInicio)
        Me.Font = New System.Drawing.Font("Product Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRIAGE"
        Me.PanelInicio.ResumeLayout(False)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelInicio As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnIngresarInvitado As Button
    Friend WithEvents btnIniciarAutenticado As Button
End Class
