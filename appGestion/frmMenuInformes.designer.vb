<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuInformes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuInformes))
        Me.picEncabezado = New System.Windows.Forms.PictureBox()
        Me.grpBoxInformes = New System.Windows.Forms.GroupBox()
        Me.rndBtnChatMes = New System.Windows.Forms.RadioButton()
        Me.rndbtnChatMeses = New System.Windows.Forms.RadioButton()
        Me.rndBtnDiagnosticosOto = New System.Windows.Forms.RadioButton()
        Me.rndBtnRankingPat = New System.Windows.Forms.RadioButton()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBoxInformes.SuspendLayout()
        Me.SuspendLayout()
        '
        'picEncabezado
        '
        Me.picEncabezado.Image = CType(resources.GetObject("picEncabezado.Image"), System.Drawing.Image)
        Me.picEncabezado.Location = New System.Drawing.Point(-13, -1)
        Me.picEncabezado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picEncabezado.Name = "picEncabezado"
        Me.picEncabezado.Size = New System.Drawing.Size(438, 79)
        Me.picEncabezado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picEncabezado.TabIndex = 5
        Me.picEncabezado.TabStop = False
        '
        'grpBoxInformes
        '
        Me.grpBoxInformes.Controls.Add(Me.rndBtnChatMes)
        Me.grpBoxInformes.Controls.Add(Me.rndbtnChatMeses)
        Me.grpBoxInformes.Controls.Add(Me.rndBtnDiagnosticosOto)
        Me.grpBoxInformes.Controls.Add(Me.rndBtnRankingPat)
        Me.grpBoxInformes.Location = New System.Drawing.Point(21, 96)
        Me.grpBoxInformes.Name = "grpBoxInformes"
        Me.grpBoxInformes.Size = New System.Drawing.Size(382, 228)
        Me.grpBoxInformes.TabIndex = 6
        Me.grpBoxInformes.TabStop = False
        Me.grpBoxInformes.Text = "Selecciona el Informe"
        '
        'rndBtnChatMes
        '
        Me.rndBtnChatMes.AutoSize = True
        Me.rndBtnChatMes.Location = New System.Drawing.Point(25, 164)
        Me.rndBtnChatMes.Name = "rndBtnChatMes"
        Me.rndBtnChatMes.Size = New System.Drawing.Size(131, 24)
        Me.rndBtnChatMes.TabIndex = 3
        Me.rndBtnChatMes.Tag = "4"
        Me.rndBtnChatMes.Text = "Chat por mes"
        Me.rndBtnChatMes.UseVisualStyleBackColor = True
        '
        'rndbtnChatMeses
        '
        Me.rndbtnChatMeses.AutoSize = True
        Me.rndbtnChatMeses.Location = New System.Drawing.Point(25, 123)
        Me.rndbtnChatMeses.Name = "rndbtnChatMeses"
        Me.rndbtnChatMeses.Size = New System.Drawing.Size(205, 24)
        Me.rndbtnChatMeses.TabIndex = 2
        Me.rndbtnChatMeses.Tag = "3"
        Me.rndbtnChatMeses.Text = "Chat Ultimos 12 meses"
        Me.rndbtnChatMeses.UseVisualStyleBackColor = True
        '
        'rndBtnDiagnosticosOto
        '
        Me.rndBtnDiagnosticosOto.AutoSize = True
        Me.rndBtnDiagnosticosOto.Location = New System.Drawing.Point(25, 82)
        Me.rndBtnDiagnosticosOto.Name = "rndBtnDiagnosticosOto"
        Me.rndBtnDiagnosticosOto.Size = New System.Drawing.Size(211, 24)
        Me.rndBtnDiagnosticosOto.TabIndex = 1
        Me.rndBtnDiagnosticosOto.Tag = "2"
        Me.rndBtnDiagnosticosOto.Text = "Diagnosticos Otorgados"
        Me.rndBtnDiagnosticosOto.UseVisualStyleBackColor = True
        '
        'rndBtnRankingPat
        '
        Me.rndBtnRankingPat.AutoSize = True
        Me.rndBtnRankingPat.Checked = True
        Me.rndBtnRankingPat.Location = New System.Drawing.Point(25, 41)
        Me.rndBtnRankingPat.Name = "rndBtnRankingPat"
        Me.rndBtnRankingPat.Size = New System.Drawing.Size(196, 24)
        Me.rndBtnRankingPat.TabIndex = 0
        Me.rndBtnRankingPat.TabStop = True
        Me.rndBtnRankingPat.Tag = "1"
        Me.rndBtnRankingPat.Text = "Ranking de Patologias"
        Me.rndBtnRankingPat.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(281, 331)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(122, 39)
        Me.btnConfirmar.TabIndex = 4
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'frmMenuInformes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 381)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.grpBoxInformes)
        Me.Controls.Add(Me.picEncabezado)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMenuInformes"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Menu de Informes"
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBoxInformes.ResumeLayout(False)
        Me.grpBoxInformes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picEncabezado As PictureBox
    Friend WithEvents grpBoxInformes As GroupBox
    Friend WithEvents rndBtnRankingPat As RadioButton
    Friend WithEvents rndBtnDiagnosticosOto As RadioButton
    Friend WithEvents rndBtnChatMes As RadioButton
    Friend WithEvents rndbtnChatMeses As RadioButton
    Friend WithEvents btnConfirmar As Button
End Class
