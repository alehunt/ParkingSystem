<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEspacio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblPiso = New System.Windows.Forms.Label()
        Me.lblTamano = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.nupPiso = New System.Windows.Forms.NumericUpDown()
        Me.cbTamano = New System.Windows.Forms.ComboBox()
        Me.gbTipo = New System.Windows.Forms.GroupBox()
        Me.rbFija = New System.Windows.Forms.RadioButton()
        Me.rbMovil = New System.Windows.Forms.RadioButton()
        Me.mTxtValorMes = New System.Windows.Forms.MaskedTextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.nupPiso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(24, 39)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Codigo"
        '
        'lblPiso
        '
        Me.lblPiso.AutoSize = True
        Me.lblPiso.Location = New System.Drawing.Point(24, 67)
        Me.lblPiso.Name = "lblPiso"
        Me.lblPiso.Size = New System.Drawing.Size(27, 13)
        Me.lblPiso.TabIndex = 1
        Me.lblPiso.Text = "Piso"
        '
        'lblTamano
        '
        Me.lblTamano.AutoSize = True
        Me.lblTamano.Location = New System.Drawing.Point(24, 101)
        Me.lblTamano.Name = "lblTamano"
        Me.lblTamano.Size = New System.Drawing.Size(46, 13)
        Me.lblTamano.TabIndex = 2
        Me.lblTamano.Text = "Tamano"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(91, 36)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(120, 20)
        Me.txtCodigo.TabIndex = 3
        '
        'nupPiso
        '
        Me.nupPiso.Location = New System.Drawing.Point(91, 65)
        Me.nupPiso.Name = "nupPiso"
        Me.nupPiso.Size = New System.Drawing.Size(120, 20)
        Me.nupPiso.TabIndex = 4
        '
        'cbTamano
        '
        Me.cbTamano.FormattingEnabled = True
        Me.cbTamano.Location = New System.Drawing.Point(91, 98)
        Me.cbTamano.Name = "cbTamano"
        Me.cbTamano.Size = New System.Drawing.Size(121, 21)
        Me.cbTamano.TabIndex = 5
        '
        'gbTipo
        '
        Me.gbTipo.Controls.Add(Me.mTxtValorMes)
        Me.gbTipo.Controls.Add(Me.rbMovil)
        Me.gbTipo.Controls.Add(Me.rbFija)
        Me.gbTipo.Location = New System.Drawing.Point(218, 19)
        Me.gbTipo.Name = "gbTipo"
        Me.gbTipo.Size = New System.Drawing.Size(190, 100)
        Me.gbTipo.TabIndex = 6
        Me.gbTipo.TabStop = False
        Me.gbTipo.Text = "Tipo"
        '
        'rbFija
        '
        Me.rbFija.AutoSize = True
        Me.rbFija.Location = New System.Drawing.Point(107, 20)
        Me.rbFija.Name = "rbFija"
        Me.rbFija.Size = New System.Drawing.Size(41, 17)
        Me.rbFija.TabIndex = 0
        Me.rbFija.TabStop = True
        Me.rbFija.Text = "Fija"
        Me.rbFija.UseVisualStyleBackColor = True
        '
        'rbMovil
        '
        Me.rbMovil.AutoSize = True
        Me.rbMovil.Location = New System.Drawing.Point(30, 20)
        Me.rbMovil.Name = "rbMovil"
        Me.rbMovil.Size = New System.Drawing.Size(50, 17)
        Me.rbMovil.TabIndex = 1
        Me.rbMovil.TabStop = True
        Me.rbMovil.Text = "Movil"
        Me.rbMovil.UseVisualStyleBackColor = True
        '
        'mTxtValorMes
        '
        Me.mTxtValorMes.Location = New System.Drawing.Point(84, 48)
        Me.mTxtValorMes.Mask = "99999"
        Me.mTxtValorMes.Name = "mTxtValorMes"
        Me.mTxtValorMes.Size = New System.Drawing.Size(100, 20)
        Me.mTxtValorMes.TabIndex = 2
        Me.mTxtValorMes.ValidatingType = GetType(Integer)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(28, 142)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(184, 52)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(218, 142)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(172, 52)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'FrmEspacio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 217)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.gbTipo)
        Me.Controls.Add(Me.cbTamano)
        Me.Controls.Add(Me.nupPiso)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblTamano)
        Me.Controls.Add(Me.lblPiso)
        Me.Controls.Add(Me.lblCodigo)
        Me.Name = "FrmEspacio"
        Me.Text = "Espacio"
        CType(Me.nupPiso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTipo.ResumeLayout(False)
        Me.gbTipo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblPiso As System.Windows.Forms.Label
    Friend WithEvents lblTamano As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents nupPiso As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbTamano As System.Windows.Forms.ComboBox
    Friend WithEvents gbTipo As System.Windows.Forms.GroupBox
    Friend WithEvents mTxtValorMes As System.Windows.Forms.MaskedTextBox
    Friend WithEvents rbMovil As System.Windows.Forms.RadioButton
    Friend WithEvents rbFija As System.Windows.Forms.RadioButton
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
