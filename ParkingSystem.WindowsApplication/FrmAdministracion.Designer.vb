﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdministracion
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
        Me.dgvPlayas = New System.Windows.Forms.DataGridView()
        Me.btnPlayaAdministrar = New System.Windows.Forms.Button()
        Me.btnPlayaGenerar = New System.Windows.Forms.Button()
        Me.btnPlayaEliminar = New System.Windows.Forms.Button()
        CType(Me.dgvPlayas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPlayas
        '
        Me.dgvPlayas.AllowUserToAddRows = False
        Me.dgvPlayas.AllowUserToDeleteRows = False
        Me.dgvPlayas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlayas.Location = New System.Drawing.Point(12, 12)
        Me.dgvPlayas.MultiSelect = False
        Me.dgvPlayas.Name = "dgvPlayas"
        Me.dgvPlayas.ReadOnly = True
        Me.dgvPlayas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPlayas.Size = New System.Drawing.Size(508, 188)
        Me.dgvPlayas.TabIndex = 0
        '
        'btnPlayaAdministrar
        '
        Me.btnPlayaAdministrar.Location = New System.Drawing.Point(330, 206)
        Me.btnPlayaAdministrar.Name = "btnPlayaAdministrar"
        Me.btnPlayaAdministrar.Size = New System.Drawing.Size(190, 42)
        Me.btnPlayaAdministrar.TabIndex = 1
        Me.btnPlayaAdministrar.Text = "Administrar"
        Me.btnPlayaAdministrar.UseVisualStyleBackColor = True
        '
        'btnPlayaGenerar
        '
        Me.btnPlayaGenerar.Location = New System.Drawing.Point(12, 205)
        Me.btnPlayaGenerar.Name = "btnPlayaGenerar"
        Me.btnPlayaGenerar.Size = New System.Drawing.Size(123, 42)
        Me.btnPlayaGenerar.TabIndex = 2
        Me.btnPlayaGenerar.Text = "Generar"
        Me.btnPlayaGenerar.UseVisualStyleBackColor = True
        '
        'btnPlayaEliminar
        '
        Me.btnPlayaEliminar.Location = New System.Drawing.Point(141, 205)
        Me.btnPlayaEliminar.Name = "btnPlayaEliminar"
        Me.btnPlayaEliminar.Size = New System.Drawing.Size(100, 43)
        Me.btnPlayaEliminar.TabIndex = 3
        Me.btnPlayaEliminar.Text = "Eliminar"
        Me.btnPlayaEliminar.UseVisualStyleBackColor = True
        '
        'FrmAdministracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 259)
        Me.Controls.Add(Me.btnPlayaEliminar)
        Me.Controls.Add(Me.btnPlayaGenerar)
        Me.Controls.Add(Me.btnPlayaAdministrar)
        Me.Controls.Add(Me.dgvPlayas)
        Me.MaximizeBox = False
        Me.Name = "FrmAdministracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estacionamientos"
        CType(Me.dgvPlayas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvPlayas As System.Windows.Forms.DataGridView
    Friend WithEvents btnPlayaAdministrar As System.Windows.Forms.Button
    Friend WithEvents btnPlayaGenerar As System.Windows.Forms.Button
    Friend WithEvents btnPlayaEliminar As System.Windows.Forms.Button
End Class
