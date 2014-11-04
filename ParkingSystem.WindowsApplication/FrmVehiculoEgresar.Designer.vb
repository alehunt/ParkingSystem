<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVehiculoEgresar
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTipoPagoValue = New System.Windows.Forms.Label()
        Me.lblTipoPago = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.chkAbono = New System.Windows.Forms.CheckBox()
        Me.gbPatente = New System.Windows.Forms.GroupBox()
        Me.mTxtPatente = New System.Windows.Forms.MaskedTextBox()
        Me.lblMontoPago = New System.Windows.Forms.Label()
        Me.lblMontoPagoValue = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.gbPatente.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblMontoPagoValue)
        Me.GroupBox1.Controls.Add(Me.lblMontoPago)
        Me.GroupBox1.Controls.Add(Me.lblTipoPagoValue)
        Me.GroupBox1.Controls.Add(Me.lblTipoPago)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 104)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pago"
        '
        'lblTipoPagoValue
        '
        Me.lblTipoPagoValue.AutoSize = True
        Me.lblTipoPagoValue.Location = New System.Drawing.Point(69, 31)
        Me.lblTipoPagoValue.Name = "lblTipoPagoValue"
        Me.lblTipoPagoValue.Size = New System.Drawing.Size(65, 13)
        Me.lblTipoPagoValue.TabIndex = 6
        Me.lblTipoPagoValue.Text = "TIPO PAGO"
        '
        'lblTipoPago
        '
        Me.lblTipoPago.AutoSize = True
        Me.lblTipoPago.Location = New System.Drawing.Point(16, 31)
        Me.lblTipoPago.Name = "lblTipoPago"
        Me.lblTipoPago.Size = New System.Drawing.Size(31, 13)
        Me.lblTipoPago.TabIndex = 0
        Me.lblTipoPago.Text = "Tipo:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(13, 186)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(95, 34)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(177, 186)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 34)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'chkAbono
        '
        Me.chkAbono.AutoSize = True
        Me.chkAbono.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAbono.Enabled = False
        Me.chkAbono.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAbono.Location = New System.Drawing.Point(115, 27)
        Me.chkAbono.Name = "chkAbono"
        Me.chkAbono.Size = New System.Drawing.Size(57, 17)
        Me.chkAbono.TabIndex = 6
        Me.chkAbono.Text = "Abono"
        Me.chkAbono.UseVisualStyleBackColor = True
        '
        'gbPatente
        '
        Me.gbPatente.Controls.Add(Me.mTxtPatente)
        Me.gbPatente.Controls.Add(Me.chkAbono)
        Me.gbPatente.Location = New System.Drawing.Point(12, 10)
        Me.gbPatente.Name = "gbPatente"
        Me.gbPatente.Size = New System.Drawing.Size(259, 60)
        Me.gbPatente.TabIndex = 7
        Me.gbPatente.TabStop = False
        Me.gbPatente.Text = "Patente"
        '
        'mTxtPatente
        '
        Me.mTxtPatente.Enabled = False
        Me.mTxtPatente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mTxtPatente.Location = New System.Drawing.Point(52, 23)
        Me.mTxtPatente.Mask = "LLL-000"
        Me.mTxtPatente.Name = "mTxtPatente"
        Me.mTxtPatente.Size = New System.Drawing.Size(57, 21)
        Me.mTxtPatente.TabIndex = 7
        '
        'lblMontoPago
        '
        Me.lblMontoPago.AutoSize = True
        Me.lblMontoPago.Location = New System.Drawing.Point(16, 56)
        Me.lblMontoPago.Name = "lblMontoPago"
        Me.lblMontoPago.Size = New System.Drawing.Size(40, 13)
        Me.lblMontoPago.TabIndex = 7
        Me.lblMontoPago.Text = "Monto:"
        '
        'lblMontoPagoValue
        '
        Me.lblMontoPagoValue.AutoSize = True
        Me.lblMontoPagoValue.Location = New System.Drawing.Point(72, 56)
        Me.lblMontoPagoValue.Name = "lblMontoPagoValue"
        Me.lblMontoPagoValue.Size = New System.Drawing.Size(80, 13)
        Me.lblMontoPagoValue.TabIndex = 8
        Me.lblMontoPagoValue.Text = "MONTO PAGO"
        '
        'FrmVehiculoEgresar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 226)
        Me.Controls.Add(Me.gbPatente)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmVehiculoEgresar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vehiculo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbPatente.ResumeLayout(False)
        Me.gbPatente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTipoPago As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents chkAbono As System.Windows.Forms.CheckBox
    Friend WithEvents gbPatente As System.Windows.Forms.GroupBox
    Friend WithEvents mTxtPatente As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblTipoPagoValue As System.Windows.Forms.Label
    Friend WithEvents lblMontoPago As System.Windows.Forms.Label
    Friend WithEvents lblMontoPagoValue As System.Windows.Forms.Label
End Class
