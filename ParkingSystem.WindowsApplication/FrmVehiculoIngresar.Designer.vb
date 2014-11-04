<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.txtPatente = New System.Windows.Forms.TextBox()
        Me.btnBuscarPatente = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTipoVehiculoValorEstadiaValue = New System.Windows.Forms.Label()
        Me.lblTipoVehiculoValorHoraValue = New System.Windows.Forms.Label()
        Me.lblTipoVehiculoValorEstadia = New System.Windows.Forms.Label()
        Me.lblTipoVehiculoValorHora = New System.Windows.Forms.Label()
        Me.cbTipoVehiculo = New System.Windows.Forms.ComboBox()
        Me.lblTipoVehiculoNombre = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.chkAbono = New System.Windows.Forms.CheckBox()
        Me.gbPatente = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.gbPatente.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPatente
        '
        Me.txtPatente.Location = New System.Drawing.Point(13, 25)
        Me.txtPatente.Name = "txtPatente"
        Me.txtPatente.Size = New System.Drawing.Size(100, 20)
        Me.txtPatente.TabIndex = 1
        '
        'btnBuscarPatente
        '
        Me.btnBuscarPatente.Location = New System.Drawing.Point(13, 58)
        Me.btnBuscarPatente.Name = "btnBuscarPatente"
        Me.btnBuscarPatente.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarPatente.TabIndex = 2
        Me.btnBuscarPatente.Text = "Buscar"
        Me.btnBuscarPatente.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTipoVehiculoValorEstadiaValue)
        Me.GroupBox1.Controls.Add(Me.lblTipoVehiculoValorHoraValue)
        Me.GroupBox1.Controls.Add(Me.lblTipoVehiculoValorEstadia)
        Me.GroupBox1.Controls.Add(Me.lblTipoVehiculoValorHora)
        Me.GroupBox1.Controls.Add(Me.cbTipoVehiculo)
        Me.GroupBox1.Controls.Add(Me.lblTipoVehiculoNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 129)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo Vehiculo"
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
        'cbTipoVehiculo
        '
        Me.cbTipoVehiculo.FormattingEnabled = True
        Me.cbTipoVehiculo.Location = New System.Drawing.Point(131, 29)
        Me.cbTipoVehiculo.Name = "cbTipoVehiculo"
        Me.cbTipoVehiculo.Size = New System.Drawing.Size(99, 21)
        Me.cbTipoVehiculo.TabIndex = 1
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
        Me.btnAceptar.Location = New System.Drawing.Point(12, 250)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(95, 34)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(176, 250)
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
        Me.chkAbono.Location = New System.Drawing.Point(131, 27)
        Me.chkAbono.Name = "chkAbono"
        Me.chkAbono.Size = New System.Drawing.Size(57, 17)
        Me.chkAbono.TabIndex = 6
        Me.chkAbono.Text = "Abono"
        Me.chkAbono.UseVisualStyleBackColor = True
        '
        'gbPatente
        '
        Me.gbPatente.Controls.Add(Me.btnBuscarPatente)
        Me.gbPatente.Controls.Add(Me.chkAbono)
        Me.gbPatente.Controls.Add(Me.txtPatente)
        Me.gbPatente.Location = New System.Drawing.Point(12, 10)
        Me.gbPatente.Name = "gbPatente"
        Me.gbPatente.Size = New System.Drawing.Size(259, 99)
        Me.gbPatente.TabIndex = 7
        Me.gbPatente.TabStop = False
        Me.gbPatente.Text = "Patente"
        '
        'FrmVehiculoIngresar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 297)
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
    Friend WithEvents txtPatente As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarPatente As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTipoVehiculoNombre As System.Windows.Forms.Label
    Friend WithEvents cbTipoVehiculo As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoVehiculoValorEstadiaValue As System.Windows.Forms.Label
    Friend WithEvents lblTipoVehiculoValorHoraValue As System.Windows.Forms.Label
    Friend WithEvents lblTipoVehiculoValorEstadia As System.Windows.Forms.Label
    Friend WithEvents lblTipoVehiculoValorHora As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents chkAbono As System.Windows.Forms.CheckBox
    Friend WithEvents gbPatente As System.Windows.Forms.GroupBox
End Class
