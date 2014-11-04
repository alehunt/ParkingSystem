<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPlayaAdministrar
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
        Me.dgvEspacios = New System.Windows.Forms.DataGridView()
        Me.btnVehiculoIngresar = New System.Windows.Forms.Button()
        Me.btnVehiculoEgresar = New System.Windows.Forms.Button()
        CType(Me.dgvEspacios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEspacios
        '
        Me.dgvEspacios.AllowUserToAddRows = False
        Me.dgvEspacios.AllowUserToDeleteRows = False
        Me.dgvEspacios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEspacios.Location = New System.Drawing.Point(12, 12)
        Me.dgvEspacios.MultiSelect = False
        Me.dgvEspacios.Name = "dgvEspacios"
        Me.dgvEspacios.ReadOnly = True
        Me.dgvEspacios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEspacios.Size = New System.Drawing.Size(677, 302)
        Me.dgvEspacios.TabIndex = 0
        '
        'btnVehiculoIngresar
        '
        Me.btnVehiculoIngresar.Location = New System.Drawing.Point(12, 320)
        Me.btnVehiculoIngresar.Name = "btnVehiculoIngresar"
        Me.btnVehiculoIngresar.Size = New System.Drawing.Size(269, 51)
        Me.btnVehiculoIngresar.TabIndex = 1
        Me.btnVehiculoIngresar.Text = "Ingresar Vehiculo"
        Me.btnVehiculoIngresar.UseVisualStyleBackColor = True
        '
        'btnVehiculoEgresar
        '
        Me.btnVehiculoEgresar.Location = New System.Drawing.Point(410, 320)
        Me.btnVehiculoEgresar.Name = "btnVehiculoEgresar"
        Me.btnVehiculoEgresar.Size = New System.Drawing.Size(279, 51)
        Me.btnVehiculoEgresar.TabIndex = 2
        Me.btnVehiculoEgresar.Text = "Egresar Vehiculo"
        Me.btnVehiculoEgresar.UseVisualStyleBackColor = True
        '
        'FrmPlayaAdministrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 373)
        Me.Controls.Add(Me.btnVehiculoEgresar)
        Me.Controls.Add(Me.btnVehiculoIngresar)
        Me.Controls.Add(Me.dgvEspacios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmPlayaAdministrar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvEspacios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvEspacios As System.Windows.Forms.DataGridView
    Friend WithEvents btnVehiculoIngresar As System.Windows.Forms.Button
    Friend WithEvents btnVehiculoEgresar As System.Windows.Forms.Button
End Class
