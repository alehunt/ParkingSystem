﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVehiculoIngresar
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
        Me.lblTipoVehiculoNombreValue = New System.Windows.Forms.Label()
        Me.lblTipoVehiculoValorEstadiaValue = New System.Windows.Forms.Label()
        Me.lblTipoVehiculoValorHoraValue = New System.Windows.Forms.Label()
        Me.lblTipoVehiculoValorEstadia = New System.Windows.Forms.Label()
        Me.lblTipoVehiculoValorHora = New System.Windows.Forms.Label()
        Me.lblTipoVehiculoNombre = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.chkAbono = New System.Windows.Forms.CheckBox()
        Me.gbPatente = New System.Windows.Forms.GroupBox()
        Me.mTxtPatente = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.gbPatente.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTipoVehiculoNombreValue)
        Me.GroupBox1.Controls.Add(Me.lblTipoVehiculoValorEstadiaValue)
        Me.GroupBox1.Controls.Add(Me.lblTipoVehiculoValorHoraValue)
        Me.GroupBox1.Controls.Add(Me.lblTipoVehiculoValorEstadia)
        Me.GroupBox1.Controls.Add(Me.lblTipoVehiculoValorHora)
        Me.GroupBox1.Controls.Add(Me.lblTipoVehiculoNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 129)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo Vehiculo"
        '
        'lblTipoVehiculoNombreValue
        '
        Me.lblTipoVehiculoNombreValue.AutoSize = True
        Me.lblTipoVehiculoNombreValue.Location = New System.Drawing.Point(131, 31)
        Me.lblTipoVehiculoNombreValue.Name = "lblTipoVehiculoNombreValue"
        Me.lblTipoVehiculoNombreValue.Size = New System.Drawing.Size(89, 13)
        Me.lblTipoVehiculoNombreValue.TabIndex = 6
        Me.lblTipoVehiculoNombreValue.Text = "TIPO VEHICULO"
        '
        'lblTipoVehiculoValorEstadiaValue
        '
        Me.lblTipoVehiculoValorEstadiaValue.AutoSize = True
        Me.lblTipoVehiculoValorEstadiaValue.Location = New System.Drawing.Point(128, 90)
        Me.lblTipoVehiculoValorEstadiaValue.Name = "lblTipoVehiculoValorEstadiaValue"
        Me.lblTipoVehiculoValorEstadiaValue.Size = New System.Drawing.Size(38, 13)
        Me.lblTipoVehiculoValorEstadiaValue.TabIndex = 5
        Me.lblTipoVehiculoValorEstadiaValue.Text = "##.##"
        '
        'lblTipoVehiculoValorHoraValue
        '
        Me.lblTipoVehiculoValorHoraValue.AutoSize = True
        Me.lblTipoVehiculoValorHoraValue.Location = New System.Drawing.Point(128, 61)
        Me.lblTipoVehiculoValorHoraValue.Name = "lblTipoVehiculoValorHoraValue"
        Me.lblTipoVehiculoValorHoraValue.Size = New System.Drawing.Size(38, 13)
        Me.lblTipoVehiculoValorHoraValue.TabIndex = 4
        Me.lblTipoVehiculoValorHoraValue.Text = "##.##"
        '
        'lblTipoVehiculoValorEstadia
        '
        Me.lblTipoVehiculoValorEstadia.AutoSize = True
        Me.lblTipoVehiculoValorEstadia.Location = New System.Drawing.Point(48, 90)
        Me.lblTipoVehiculoValorEstadia.Name = "lblTipoVehiculoValorEstadia"
        Me.lblTipoVehiculoValorEstadia.Size = New System.Drawing.Size(72, 13)
        Me.lblTipoVehiculoValorEstadia.TabIndex = 3
        Me.lblTipoVehiculoValorEstadia.Text = "Valor Estadia:"
        '
        'lblTipoVehiculoValorHora
        '
        Me.lblTipoVehiculoValorHora.AutoSize = True
        Me.lblTipoVehiculoValorHora.Location = New System.Drawing.Point(48, 61)
        Me.lblTipoVehiculoValorHora.Name = "lblTipoVehiculoValorHora"
        Me.lblTipoVehiculoValorHora.Size = New System.Drawing.Size(60, 13)
        Me.lblTipoVehiculoValorHora.TabIndex = 2
        Me.lblTipoVehiculoValorHora.Text = "Valor Hora:"
        '
        'lblTipoVehiculoNombre
        '
        Me.lblTipoVehiculoNombre.AutoSize = True
        Me.lblTipoVehiculoNombre.Location = New System.Drawing.Point(48, 32)
        Me.lblTipoVehiculoNombre.Name = "lblTipoVehiculoNombre"
        Me.lblTipoVehiculoNombre.Size = New System.Drawing.Size(31, 13)
        Me.lblTipoVehiculoNombre.TabIndex = 0
        Me.lblTipoVehiculoNombre.Text = "Tipo:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(13, 211)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(95, 34)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(177, 211)
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
        Me.mTxtPatente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mTxtPatente.Location = New System.Drawing.Point(52, 23)
        Me.mTxtPatente.Mask = "LLL-000"
        Me.mTxtPatente.Name = "mTxtPatente"
        Me.mTxtPatente.Size = New System.Drawing.Size(57, 21)
        Me.mTxtPatente.TabIndex = 7
        '
        'FrmVehiculoIngresar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 256)
        Me.Controls.Add(Me.gbPatente)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmVehiculoIngresar"
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
    Friend WithEvents lblTipoVehiculoNombre As System.Windows.Forms.Label
    Friend WithEvents lblTipoVehiculoValorEstadiaValue As System.Windows.Forms.Label
    Friend WithEvents lblTipoVehiculoValorHoraValue As System.Windows.Forms.Label
    Friend WithEvents lblTipoVehiculoValorEstadia As System.Windows.Forms.Label
    Friend WithEvents lblTipoVehiculoValorHora As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents chkAbono As System.Windows.Forms.CheckBox
    Friend WithEvents gbPatente As System.Windows.Forms.GroupBox
    Friend WithEvents mTxtPatente As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblTipoVehiculoNombreValue As System.Windows.Forms.Label
End Class
