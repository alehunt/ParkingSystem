Imports ParkingSystem.Model
Imports ParkingSystem.BusinessLogic

Public Class FrmPlayaAdministrar

    Public Sub New(pPlaya As Playa)
        Me.InitializeComponent()

        Me.Playa = pPlaya
    End Sub

    Private Property Playa As Playa
    Private Property PlayaLogic As New PlayaLogic


    Private Sub FrmPlayaAdministrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Playa.Nombre

        If (Me.Playa.HoraApertura > DateTime.Now.ToShortTimeString Or Me.Playa.HoraCierre < DateTime.Now.ToShortTimeString()) Then
            Me.btnVehiculoEgresar.Enabled = False
            Me.btnVehiculoIngresar.Enabled = False
        End If


        Me.InitializeGrid()
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

        Dim dgvColumnSituacion As New DataGridViewTextBoxColumn()
        dgvColumnSituacion.HeaderText = "Situacion"
        dgvColumnSituacion.Name = "Situacion"
        dgvColumnSituacion.DisplayIndex = 3
        dgvColumnSituacion.ValueType = GetType(String)
        dgvColumnSituacion.Visible = True
        dgvColumnSituacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        Dim dgvColumnVehiculo As New DataGridViewTextBoxColumn()
        dgvColumnVehiculo.HeaderText = "Vehiculo"
        dgvColumnVehiculo.Name = "Vehiculo"
        dgvColumnVehiculo.DataPropertyName = "Vehiculo"
        dgvColumnVehiculo.DisplayIndex = 4
        dgvColumnVehiculo.ValueType = GetType(Vehiculo)
        dgvColumnVehiculo.Visible = False

        Dim dgvColumnPatente As New DataGridViewTextBoxColumn()
        dgvColumnPatente.HeaderText = "Patente"
        dgvColumnPatente.Name = "Patente"
        dgvColumnPatente.DisplayIndex = 5
        dgvColumnPatente.ValueType = GetType(String)
        dgvColumnPatente.Visible = True

        Dim dgvColumnAbono As New DataGridViewTextBoxColumn()
        dgvColumnAbono.HeaderText = "Abono"
        dgvColumnAbono.Name = "Abono"
        dgvColumnAbono.DisplayIndex = 6
        dgvColumnAbono.ValueType = GetType(Boolean)
        dgvColumnAbono.Visible = True

        Dim dgvColumnHoraEntrada As New DataGridViewTextBoxColumn()
        dgvColumnHoraEntrada.HeaderText = "Hora de Entrada"
        dgvColumnHoraEntrada.Name = "HoraEntrada"
        dgvColumnHoraEntrada.DisplayIndex = 7
        dgvColumnHoraEntrada.ValueType = GetType(String)
        dgvColumnHoraEntrada.Visible = True

        Me.dgvEspacios.Columns.Add(dgvColumnEspacio)
        Me.dgvEspacios.Columns.Add(dgvColumnCodigo)
        Me.dgvEspacios.Columns.Add(dgvColumnPiso)
        Me.dgvEspacios.Columns.Add(dgvColumnTamano)
        Me.dgvEspacios.Columns.Add(dgvColumnSituacion)
        Me.dgvEspacios.Columns.Add(dgvColumnVehiculo)
        Me.dgvEspacios.Columns.Add(dgvColumnPatente)
        Me.dgvEspacios.Columns.Add(dgvColumnAbono)
        Me.dgvEspacios.Columns.Add(dgvColumnHoraEntrada)

        Me.dgvEspacios.AutoGenerateColumns = False
    End Sub

    Private Sub dgvEspacios_DataSourceChanged(sender As Object, e As EventArgs) Handles dgvEspacios.DataSourceChanged

        For Each row As DataGridViewRow In Me.dgvEspacios.Rows

            Dim espacio As Espacio = row.DataBoundItem

            If (espacio.Vehiculo Is Nothing) Then
                row.Cells("Situacion").Value = "Vacio"
            Else
                row.Cells("Situacion").Value = "Ocupado"
                row.Cells("Patente").Value = espacio.Vehiculo.Patente
                row.Cells("Abono").Value = espacio.Vehiculo.Abono
            End If

            If (espacio Is GetType(CocheraMovil)) Then
                Dim horaEntrada As DateTime? = DirectCast(espacio, CocheraMovil).HoraEntrada
                row.Cells("HoraEntrada").Value = IIf(horaEntrada.HasValue, horaEntrada.Value.ToShortTimeString, "")
            End If
        Next

    End Sub

    Private Sub dgvEspacios_SelectionChanged(sender As Object, e As EventArgs) Handles dgvEspacios.SelectionChanged

        If (Me.dgvEspacios.SelectedRows.Count > 0) Then
            Dim row As DataGridViewRow = Me.dgvEspacios.SelectedRows(0)
            Dim espacio As Espacio = row.DataBoundItem
            Me.EspacioDesocupado(espacio.Vehiculo Is Nothing)
        End If

    End Sub

    Private Sub EspacioDesocupado(pDesocupado As Boolean)
        Me.btnVehiculoIngresar.Enabled = pDesocupado
        Me.btnVehiculoEgresar.Enabled = Not pDesocupado
    End Sub

    Private Sub btnVehiculoIngresar_Click(sender As Object, e As EventArgs) Handles btnVehiculoIngresar.Click
        Dim frmVehiculoIngresar As New FrmVehiculoIngresar()
        If (frmVehiculoIngresar.ShowDialog = Windows.Forms.DialogResult.OK) Then
            Dim vehiculoIngresado As Vehiculo = frmVehiculoIngresar.Vehiculo
            Dim espacioSeleccionado As Espacio = Me.dgvEspacios.SelectedRows(0).DataBoundItem
            espacioSeleccionado.Vehiculo = vehiculoIngresado
        End If

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.PlayaLogic.Guardar(Me.Playa)
    End Sub
End Class