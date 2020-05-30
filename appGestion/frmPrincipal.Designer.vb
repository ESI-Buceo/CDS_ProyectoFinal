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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MisDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParametrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambioDeContraseñaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarMedicosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatologiasSintomasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatologiasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarPatologiasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SintomasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarSintomasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImportarArchivoCVSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SignosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarSignosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RanquinDePatologiasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogDelSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.btnVerMedico = New System.Windows.Forms.ToolStripButton()
        Me.BtnVerUsuario = New System.Windows.Forms.ToolStripButton()
        Me.btnVerPatologia = New System.Windows.Forms.ToolStripButton()
        Me.btnVerInforme = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.MedicoToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.PatologiasSintomasToolStripMenuItem, Me.InformesToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(1014, 31)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadoToolStripMenuItem, Me.MisDatosToolStripMenuItem, Me.ParametrosToolStripMenuItem, Me.CambioDeContraseñaToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(136, 27)
        Me.SistemaToolStripMenuItem.Text = "&Administrativo"
        '
        'EmpleadoToolStripMenuItem
        '
        Me.EmpleadoToolStripMenuItem.Image = CType(resources.GetObject("EmpleadoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EmpleadoToolStripMenuItem.Name = "EmpleadoToolStripMenuItem"
        Me.EmpleadoToolStripMenuItem.Size = New System.Drawing.Size(266, 28)
        Me.EmpleadoToolStripMenuItem.Text = "Adminisativo"
        '
        'MisDatosToolStripMenuItem
        '
        Me.MisDatosToolStripMenuItem.Image = CType(resources.GetObject("MisDatosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MisDatosToolStripMenuItem.Name = "MisDatosToolStripMenuItem"
        Me.MisDatosToolStripMenuItem.Size = New System.Drawing.Size(266, 28)
        Me.MisDatosToolStripMenuItem.Text = "Mis datos"
        '
        'ParametrosToolStripMenuItem
        '
        Me.ParametrosToolStripMenuItem.Image = CType(resources.GetObject("ParametrosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ParametrosToolStripMenuItem.Name = "ParametrosToolStripMenuItem"
        Me.ParametrosToolStripMenuItem.Size = New System.Drawing.Size(266, 28)
        Me.ParametrosToolStripMenuItem.Text = "Parametros del sistema"
        '
        'CambioDeContraseñaToolStripMenuItem
        '
        Me.CambioDeContraseñaToolStripMenuItem.Image = CType(resources.GetObject("CambioDeContraseñaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CambioDeContraseñaToolStripMenuItem.Name = "CambioDeContraseñaToolStripMenuItem"
        Me.CambioDeContraseñaToolStripMenuItem.Size = New System.Drawing.Size(266, 28)
        Me.CambioDeContraseñaToolStripMenuItem.Text = "Cambio de contraseña"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(263, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(266, 28)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'MedicoToolStripMenuItem
        '
        Me.MedicoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MedicoToolStripMenuItem1, Me.ListarMedicosToolStripMenuItem})
        Me.MedicoToolStripMenuItem.Name = "MedicoToolStripMenuItem"
        Me.MedicoToolStripMenuItem.Size = New System.Drawing.Size(87, 27)
        Me.MedicoToolStripMenuItem.Text = "&Medicos"
        '
        'MedicoToolStripMenuItem1
        '
        Me.MedicoToolStripMenuItem1.Image = CType(resources.GetObject("MedicoToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.MedicoToolStripMenuItem1.Name = "MedicoToolStripMenuItem1"
        Me.MedicoToolStripMenuItem1.Size = New System.Drawing.Size(196, 28)
        Me.MedicoToolStripMenuItem1.Text = "Medico"
        '
        'ListarMedicosToolStripMenuItem
        '
        Me.ListarMedicosToolStripMenuItem.Image = CType(resources.GetObject("ListarMedicosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListarMedicosToolStripMenuItem.Name = "ListarMedicosToolStripMenuItem"
        Me.ListarMedicosToolStripMenuItem.Size = New System.Drawing.Size(196, 28)
        Me.ListarMedicosToolStripMenuItem.Text = "Listar medicos"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem1, Me.ListarUsuariosToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(95, 27)
        Me.UsuariosToolStripMenuItem.Text = "&Pacientes"
        '
        'UsuariosToolStripMenuItem1
        '
        Me.UsuariosToolStripMenuItem1.Image = CType(resources.GetObject("UsuariosToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.UsuariosToolStripMenuItem1.Name = "UsuariosToolStripMenuItem1"
        Me.UsuariosToolStripMenuItem1.Size = New System.Drawing.Size(216, 28)
        Me.UsuariosToolStripMenuItem1.Text = "Paciente"
        '
        'ListarUsuariosToolStripMenuItem
        '
        Me.ListarUsuariosToolStripMenuItem.Image = CType(resources.GetObject("ListarUsuariosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListarUsuariosToolStripMenuItem.Name = "ListarUsuariosToolStripMenuItem"
        Me.ListarUsuariosToolStripMenuItem.Size = New System.Drawing.Size(216, 28)
        Me.ListarUsuariosToolStripMenuItem.Text = "Listar pacientes"
        '
        'PatologiasSintomasToolStripMenuItem
        '
        Me.PatologiasSintomasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatologiasToolStripMenuItem, Me.ListarPatologiasToolStripMenuItem, Me.ToolStripSeparator2, Me.SintomasToolStripMenuItem, Me.ListarSintomasToolStripMenuItem, Me.ToolStripSeparator3, Me.ImportarArchivoCVSToolStripMenuItem, Me.ToolStripSeparator4, Me.SignosToolStripMenuItem, Me.ListarSignosToolStripMenuItem})
        Me.PatologiasSintomasToolStripMenuItem.Name = "PatologiasSintomasToolStripMenuItem"
        Me.PatologiasSintomasToolStripMenuItem.Size = New System.Drawing.Size(112, 27)
        Me.PatologiasSintomasToolStripMenuItem.Text = "&Dianosticos"
        '
        'PatologiasToolStripMenuItem
        '
        Me.PatologiasToolStripMenuItem.Image = CType(resources.GetObject("PatologiasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PatologiasToolStripMenuItem.Name = "PatologiasToolStripMenuItem"
        Me.PatologiasToolStripMenuItem.Size = New System.Drawing.Size(251, 28)
        Me.PatologiasToolStripMenuItem.Text = "Patologias"
        '
        'ListarPatologiasToolStripMenuItem
        '
        Me.ListarPatologiasToolStripMenuItem.Image = CType(resources.GetObject("ListarPatologiasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListarPatologiasToolStripMenuItem.Name = "ListarPatologiasToolStripMenuItem"
        Me.ListarPatologiasToolStripMenuItem.Size = New System.Drawing.Size(251, 28)
        Me.ListarPatologiasToolStripMenuItem.Text = "Listar patologias"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(248, 6)
        '
        'SintomasToolStripMenuItem
        '
        Me.SintomasToolStripMenuItem.Image = CType(resources.GetObject("SintomasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SintomasToolStripMenuItem.Name = "SintomasToolStripMenuItem"
        Me.SintomasToolStripMenuItem.Size = New System.Drawing.Size(251, 28)
        Me.SintomasToolStripMenuItem.Text = "Sintomas"
        '
        'ListarSintomasToolStripMenuItem
        '
        Me.ListarSintomasToolStripMenuItem.Image = CType(resources.GetObject("ListarSintomasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListarSintomasToolStripMenuItem.Name = "ListarSintomasToolStripMenuItem"
        Me.ListarSintomasToolStripMenuItem.Size = New System.Drawing.Size(251, 28)
        Me.ListarSintomasToolStripMenuItem.Text = "Listar sintomas"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(248, 6)
        '
        'ImportarArchivoCVSToolStripMenuItem
        '
        Me.ImportarArchivoCVSToolStripMenuItem.Name = "ImportarArchivoCVSToolStripMenuItem"
        Me.ImportarArchivoCVSToolStripMenuItem.Size = New System.Drawing.Size(251, 28)
        Me.ImportarArchivoCVSToolStripMenuItem.Text = "Importar archivo CVS"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(248, 6)
        '
        'SignosToolStripMenuItem
        '
        Me.SignosToolStripMenuItem.Image = CType(resources.GetObject("SignosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SignosToolStripMenuItem.Name = "SignosToolStripMenuItem"
        Me.SignosToolStripMenuItem.Size = New System.Drawing.Size(251, 28)
        Me.SignosToolStripMenuItem.Text = "Signos"
        '
        'ListarSignosToolStripMenuItem
        '
        Me.ListarSignosToolStripMenuItem.Image = CType(resources.GetObject("ListarSignosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListarSignosToolStripMenuItem.Name = "ListarSignosToolStripMenuItem"
        Me.ListarSignosToolStripMenuItem.Size = New System.Drawing.Size(251, 28)
        Me.ListarSignosToolStripMenuItem.Text = "Listar signos"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RanquinDePatologiasToolStripMenuItem, Me.LogDelSistemaToolStripMenuItem})
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(93, 27)
        Me.InformesToolStripMenuItem.Text = "&Informes"
        '
        'RanquinDePatologiasToolStripMenuItem
        '
        Me.RanquinDePatologiasToolStripMenuItem.Image = CType(resources.GetObject("RanquinDePatologiasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RanquinDePatologiasToolStripMenuItem.Name = "RanquinDePatologiasToolStripMenuItem"
        Me.RanquinDePatologiasToolStripMenuItem.Size = New System.Drawing.Size(259, 28)
        Me.RanquinDePatologiasToolStripMenuItem.Text = "Ranquin de patologias "
        '
        'LogDelSistemaToolStripMenuItem
        '
        Me.LogDelSistemaToolStripMenuItem.Image = CType(resources.GetObject("LogDelSistemaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogDelSistemaToolStripMenuItem.Name = "LogDelSistemaToolStripMenuItem"
        Me.LogDelSistemaToolStripMenuItem.Size = New System.Drawing.Size(259, 28)
        Me.LogDelSistemaToolStripMenuItem.Text = "Log del sistema"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(71, 27)
        Me.AyudaToolStripMenuItem.Text = "&Ayuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(176, 28)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'ToolStrip
        '
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnVerMedico, Me.BtnVerUsuario, Me.btnVerPatologia, Me.btnVerInforme})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 31)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(1014, 77)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'btnVerMedico
        '
        Me.btnVerMedico.Image = CType(resources.GetObject("btnVerMedico.Image"), System.Drawing.Image)
        Me.btnVerMedico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnVerMedico.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVerMedico.Name = "btnVerMedico"
        Me.btnVerMedico.Size = New System.Drawing.Size(88, 74)
        Me.btnVerMedico.Text = "Ver Medico"
        Me.btnVerMedico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnVerUsuario
        '
        Me.BtnVerUsuario.Image = CType(resources.GetObject("BtnVerUsuario.Image"), System.Drawing.Image)
        Me.BtnVerUsuario.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnVerUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnVerUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnVerUsuario.Name = "BtnVerUsuario"
        Me.BtnVerUsuario.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.BtnVerUsuario.Size = New System.Drawing.Size(88, 74)
        Me.BtnVerUsuario.Text = "Ver Usuario"
        Me.BtnVerUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnVerPatologia
        '
        Me.btnVerPatologia.Image = CType(resources.GetObject("btnVerPatologia.Image"), System.Drawing.Image)
        Me.btnVerPatologia.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnVerPatologia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVerPatologia.Name = "btnVerPatologia"
        Me.btnVerPatologia.Size = New System.Drawing.Size(101, 74)
        Me.btnVerPatologia.Text = "Ver Patologia"
        Me.btnVerPatologia.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVerPatologia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnVerInforme
        '
        Me.btnVerInforme.Image = CType(resources.GetObject("btnVerInforme.Image"), System.Drawing.Image)
        Me.btnVerInforme.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnVerInforme.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVerInforme.Name = "btnVerInforme"
        Me.btnVerInforme.Size = New System.Drawing.Size(84, 74)
        Me.btnVerInforme.Text = "Informes"
        Me.btnVerInforme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 637)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1014, 25)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(54, 20)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1014, 662)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPrincipal"
        Me.Text = "TRIAGE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MisDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParametrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CambioDeContraseñaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PatologiasSintomasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListarMedicosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListarUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PatologiasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarPatologiasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents SintomasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarSintomasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnVerMedico As ToolStripButton
    Friend WithEvents BtnVerUsuario As ToolStripButton
    Friend WithEvents btnVerPatologia As ToolStripButton
    Friend WithEvents btnVerInforme As ToolStripButton
    Friend WithEvents RanquinDePatologiasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogDelSistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ImportarArchivoCVSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SignosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarSignosToolStripMenuItem As ToolStripMenuItem
End Class
