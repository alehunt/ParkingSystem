<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPlayaGenerar
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
        Me.gbPlaya = New System.Windows.Forms.GroupBox()
        Me.mTxtHoraCierre = New System.Windows.Forms.MaskedTextBox()
        Me.lblHoraCierre = New System.Windows.Forms.Label()
        Me.lblHoraApertura = New System.Windows.Forms.Label()
        Me.mTxtHoraApertura = New System.Windows.Forms.MaskedTextBox()
        Me.txtPlayaDireccion = New System.Windows.Forms.TextBox()
        Me.txtPlayaNombre = New System.Windows.Forms.TextBox()
        Me.lblPlayaDireccion = New System.Windows.Forms.Label()
        Me.lblPlayaNombre = New System.Windows.Forms.Label()
        Me.dgvEspacios = New System.Windows.Forms.DataGridView()
        Me.btnEspacioAgregar = New System.Windows.Forms.Button()
        Me.btnEspacioElminar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbPlaya.SuspendLayout()
        CType(Me.dgvEspacios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbPlaya
        '
        Me.gbPlaya.Controls.Add(Me.mTxtHoraCierre)
        Me.gbPlaya.Controls.Add(Me.lblHoraCierre)
        Me.gbPlaya.Controls.Add(Me.lblHoraApertura)
        Me.gbPlaya.Controls.Add(Me.mTxtHoraApertura)
        Me.gbPlaya.Controls.Add(Me.txtPlayaDireccion)
        Me.gbPlaya.Controls.Add(Me.txtPlayaNombre)
        Me.gbPlaya.Controls.Add(Me.lblPlayaDireccion)
        Me.gbPlaya.Controls.Add(Me.lblPlayaNombre)
        Me.gbPlaya.Location = New System.Drawing.Point(12, 13)
        Me.gbPlaya.Name = "gbPlaya"
        Me.gbPlaya.Size = New System.Drawing.Size(631, 100)
        Me.gbPlaya.TabIndex = 0
        Me.gbPlaya.TabStop = False
        Me.gbPlaya.Text = "Playa"
        '
        'mTxtHoraCierre
        '
        Me.mTxtHoraCierre.Location = New System.Drawing.Point(527, 61)
        Me.mTxtHoraCierre.Mask = "00:00"
        Me.mTxtHoraCierre.Name = "mTxtHoraCierre"
        Me.mTxtHoraCierre.Size = New System.Drawing.Size(40, 20)
        Me.mTxtHoraCierre.TabIndex = 7
        Me.mTxtHoraCierre.ValidatingType = GetType(Date)
        '
        'lblHoraCierre
        '
        Me.lblHoraCierre.AutoSize = True
        Me.lblHoraCierre.Location = New System.Drawing.Point(446, 64)
        Me.lblHoraCierre.Name = "lblHoraCierre"
        Me.lblHoraCierre.Size = New System.Drawing.Size(63, 13)
        Me.lblHoraCierre.TabIndex = 6
        Me.lblHoraCierre.Text = "Hora Cierre:"
        '
        'lblHoraApertura
        '
        Me.lblHoraApertura.AutoSize = True
        Me.lblHoraApertura.Location = New System.Drawing.Point(445, 33)
        Me.lblHoraApertura.Name = "lblHoraApertura"
        Me.lblHoraApertura.Size = New System.Drawing.Size(76, 13)
        Me.lblHoraApertura.TabIndex = 5
        Me.lblHoraApertura.Text = "Hora Apertura:"
        '
        'mTxtHoraApertura
        '
        Me.mTxtHoraApertura.Location = New System.Drawing.Point(527, 30)
        Me.mTxtHoraApertura.Mask = "00:00"
        Me.mTxtHoraApertura.Name = "mTxtHoraApertura"
        Me.mTxtHoraApertura.Size = New System.Drawing.Size(37, 20)
        Me.mTxtHoraApertura.TabIndex = 4
        Me.mTxtHoraApertura.ValidatingType = GetType(Date)
        '
        'txtPlayaDireccion
        '
        Me.txtPlayaDireccion.Location = New System.Drawing.Point(95, 58)
        Me.txtPlayaDireccion.Name = "txtPlayaDireccion"
        Me.txtPlayaDireccion.Size = New System.Drawing.Size(258, 20)
        Me.txtPlayaDireccion.TabIndex = 3
        '
        'txtPlayaNombre
        '
        Me.txtPlayaNombre.Location = New System.Drawing.Point(95, 30)
        Me.txtPlayaNombre.Name = "txtPlayaNombre"
        Me.txtPlayaNombre.Size = New System.Drawing.Size(175, 20)
        Me.txtPlayaNombre.TabIndex = 2
        '
        'lblPlayaDireccion
        '
        Me.lblPlayaDireccion.AutoSize = True
        Me.lblPlayaDireccion.Location = New System.Drawing.Point(18, 65)
        Me.lblPlayaDireccion.Name = "lblPlayaDireccion"
        Me.lblPlayaDireccion.Size = New System.Drawing.Size(55, 13)
        Me.lblPlayaDireccion.TabIndex = 1
        Me.lblPlayaDireccion.Text = "Direccion:"
        '
        'lblPlayaNombre
        '
        Me.lblPlayaNombre.AutoSize = True
        Me.lblPlayaNombre.Location = New System.Drawing.Point(18, 33)
        Me.lblPlayaNombre.Name = "lblPlayaNombre"
        Me.lblPlayaNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblPlayaNombre.TabIndex = 0
        Me.lblPlayaNombre.Text = "Nombre:"
        '
        'dgvEspacios
        '
        Me.dgvEspacios.AllowUserToAddRows = False
        Me.dgvEspacios.AllowUserToDeleteRows = False
        Me.dgvEspacios.AllowUserToResizeColumns = False
        Me.dgvEspacios.AllowUserToResizeRows = False
        Me.dgvEspacios.CausesValidation = False
        Me.dgvEspacios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEspacios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvEspacios.Location = New System.Drawing.Point(12, 119)
        Me.dgvEspacios.MultiSelect = False
        Me.dgvEspacios.Name = "dgvEspacios"
        Me.dgvEspacios.ReadOnly = True
        Me.dgvEspacios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvEspacios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEspacios.Size = New System.Drawing.Size(630, 156)
        Me.dgvEspacios.TabIndex = 1
        '
        'btnEspacioAgregar
        '
        Me.btnEspacioAgregar.Location = New System.Drawing.Point(13, 282)
        Me.btnEspacioAgregar.Name = "btnEspacioAgregar"
        Me.btnEspacioAgregar.Size = New System.Drawing.Size(120, 23)
        Me.btnEspacioAgregar.TabIndex = 2
        Me.btnEspacioAgregar.Text = "Agregar Espacio"
        Me.btnEspacioAgregar.UseVisualStyleBackColor = True
        '
        'btnEspacioElminar
        '
        Me.btnEspacioElminar.Location = New System.Drawing.Point(139, 281)
        Me.btnEspacioElminar.Name = "btnEspacioElminar"
        Me.btnEspacioElminar.Size = New System.Drawing.Size(104, 24)
        Me.btnEspacioElminar.TabIndex = 3
        Me.btnEspacioElminar.Text = "Eliminar Espacio"
        Me.btnEspacioElminar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(13, 326)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(269, 39)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(380, 326)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(262, 39)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'FrmPlayaGenerar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 368)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnEspacioElminar)
        Me.Controls.Add(Me.btnEspacioAgregar)
        Me.Controls.Add(Me.dgvEspacios)
        Me.Controls.Add(Me.gbPlaya)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmPlayaGenerar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gbPlaya.ResumeLayout(False)
        Me.gbPlaya.PerformLayout()
        CType(Me.dgvEspacios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbPlaya As System.Windows.Forms.GroupBox
    Friend WithEvents lblPlayaNombre As System.Windows.Forms.Label
    Friend WithEvents lblPlayaDireccion As System.Windows.Forms.Label
    Friend WithEvents txtPlayaDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayaNombre As System.Windows.Forms.TextBox
    Friend WithEvents mTxtHoraCierre As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblHoraCierre As System.Windows.Forms.Label
    Friend WithEvents lblHoraApertura As System.Windows.Forms.Label
    Friend WithEvents mTxtHoraApertura As System.Windows.Forms.MaskedTextBox
    Friend WithEvents dgvEspacios As System.Windows.Forms.DataGridView
    Friend WithEvents btnEspacioAgregar As System.Windows.Forms.Button
    Friend WithEvents btnEspacioElminar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
