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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.picEs = New System.Windows.Forms.PictureBox()
        Me.picEn = New System.Windows.Forms.PictureBox()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picClose
        '
        Me.picClose.BackColor = System.Drawing.Color.Transparent
        Me.picClose.Image = Global.appGestion.My.Resources.Resources.close
        Me.picClose.Location = New System.Drawing.Point(472, 13)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(22, 22)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picClose.TabIndex = 1
        Me.picClose.TabStop = False
        '
        'picEs
        '
        Me.picEs.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.picEs.Image = Global.appGestion.My.Resources.Resources.icono_ES
        Me.picEs.Location = New System.Drawing.Point(12, 14)
        Me.picEs.Name = "picEs"
        Me.picEs.Size = New System.Drawing.Size(35, 35)
        Me.picEs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picEs.TabIndex = 3
        Me.picEs.TabStop = False
        '
        'picEn
        '
        Me.picEn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.picEn.Image = Global.appGestion.My.Resources.Resources.icono_EN
        Me.picEn.Location = New System.Drawing.Point(55, 14)
        Me.picEn.Name = "picEn"
        Me.picEn.Size = New System.Drawing.Size(35, 35)
        Me.picEn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picEn.TabIndex = 4
        Me.picEn.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.appGestion.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(519, 715)
        Me.ControlBox = False
        Me.Controls.Add(Me.picEn)
        Me.Controls.Add(Me.picEs)
        Me.Controls.Add(Me.picClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picClose As PictureBox
    Friend WithEvents picEs As PictureBox
    Friend WithEvents picEn As PictureBox
End Class
