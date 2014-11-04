Imports ParkingSystem.Model
Imports ParkingSystem.BusinessLogic

Public Class FrmPlaya

    Public Property Playa As Playa

    Private Sub btnEspacioAgregar_Click(sender As Object, e As EventArgs) Handles btnEspacioAgregar.Click
        Dim frmEspacio As New FrmEspacio()
        If (frmEspacio.ShowDialog = Windows.Forms.DialogResult.OK) Then
            Me.Playa.Espacios.AddObject(frmEspacio.Espacio)
        End If

        Me.GridRefresh()

    End Sub

    Private Sub FrmPlaya_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Playa = New Playa()
        Me.InitializeGrid()
        Me.GridRefresh()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Playa.Direccion = Me.txtPlayaDireccion.Text
        Me.Playa.Nombre = Me.txtPlayaNombre.Text
        Me.Playa.HoraApertura = Me.mTxtHoraApertura.Text
        Me.Playa.HoraCierre = Me.mTxtHoraCierre.Text

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub GridRefresh()
        Me.dgvEspacios.DataSource = Nothing
        Me.dgvEspacios.DataSource = Me.Playa.Espacios
    End Sub

    Private Sub InitializeGrid()

        Dim dgvColumnEspacio As New DataGridViewTextBoxColumn()
        dgvColumnEspacio.HeaderText = "EspacioId"
        dgvColumnEspacio.Name = "EspacioId"
        dgvColumnEspacio.DataPropertyName = "EspacioId"
        dgvColumnEspacio.Visible = False

        Dim dgvColumnCodigo As New DataGridViewTextBoxColumn()
        dgvColumnCodigo.HeaderText = "Codigo"
        dgvColumnCodigo.Name = "Codigo"
        dgvColumnCodigo.DataPropertyName = "Codigo"
        dgvColumnCodigo.DisplayIndex = 0
        dgvColumnCodigo.Visible = True
        dgvColumnCodigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        Dim dgvColumnPiso As New DataGridViewTextBoxColumn()
        dgvColumnPiso.HeaderText = "Piso"
        dgvColumnPiso.Name = "Piso"
        dgvColumnPiso.DataPropertyName = "Piso"
        dgvColumnPiso.DisplayIndex = 1
        dgvColumnPiso.Visible = True
        dgvColumnPiso.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        Dim dgvColumnTamano As New DataGridViewTextBoxColumn()
        dgvColumnTamano.HeaderText = "Tamano"
        dgvColumnTamano.Name = "Tamano"
        dgvColumnTamano.DataPropertyName = "Tamano"
        dgvColumnTamano.DisplayIndex = 2
        dgvColumnTamano.Visible = True
        dgvColumnTamano.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        Dim dgvColumnTipo As New DataGridViewTextBoxColumn()
        dgvColumnTipo.HeaderText = "Tipo"
        dgvColumnTipo.Name = "Tipo"
        dgvColumnTipo.DataPropertyName = "Tipo"
        dgvColumnTipo.DisplayIndex = 3
        dgvColumnTipo.Visible = True
        dgvColumnTipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells


        Me.dgvEspacios.Columns.Add(dgvColumnEspacio)
        Me.dgvEspacios.Columns.Add(dgvColumnCodigo)
        Me.dgvEspacios.Columns.Add(dgvColumnPiso)
        Me.dgvEspacios.Columns.Add(dgvColumnTamano)
        Me.dgvEspacios.Columns.Add(dgvColumnTipo)

        Me.dgvEspacios.AutoGenerateColumns = False

    End Sub

    Private Sub dgvEspacios_DataSourceChanged(sender As Object, e As EventArgs) Handles dgvEspacios.DataSourceChanged

        For Each row As DataGridViewRow In Me.dgvEspacios.Rows

            Dim espacio As Espacio = row.DataBoundItem

            If (espacio.GetType Is GetType(CocheraMovil)) Then
                row.Cells("Tipo").Value = "Movil"
            Else
                row.Cells("Tipo").Value = "Fija"
            End If
        Next
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class