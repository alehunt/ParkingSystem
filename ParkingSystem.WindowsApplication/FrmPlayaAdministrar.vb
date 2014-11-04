Imports ParkingSystem.Model
Imports ParkingSystem.BusinessLogic

Public Class FrmPlayaAdministrar

    Public Sub New(pPlaya As Playa)
        Me.InitializeComponent()
        Me.Playa = pPlaya
    End Sub

    Private Property Playa As Playa
    Private Property PlayaLogic As New PlayaLogic
    Private Property PlayaCerrada As Boolean = False


    Private Sub FrmPlayaAdministrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Playa.Nombre

        If (Me.Playa.HoraApertura <= DateTime.Now.ToShortTimeString And DateTime.Now.ToShortTimeString() <= Me.Playa.HoraCierre) Then
            Me.PlayaCerrar()
        End If

        Me.InitializeGrid()
        Me.RefreshGrid()

    End Sub

    Private Sub RefreshGrid()
        Me.dgvEspacios.DataSource = Nothing
        Me.dgvEspacios.DataSource = Me.Playa.Espacios
    End Sub

    Private Sub PlayaCerrar()
        Me.btnVehiculoEgresar.Enabled = False
        Me.btnVehiculoIngresar.Enabled = False
        Me.PlayaCerrada = True
        Me.btnAceptar.Enabled = False
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

        Dim dgvColumnSituacion As New DataGridViewTextBoxColumn()
        dgvColumnSituacion.HeaderText = "Situacion"
        dgvColumnSituacion.Name = "Situacion"
        dgvColumnSituacion.DisplayIndex = 4
        dgvColumnSituacion.ValueType = GetType(String)
        dgvColumnSituacion.Visible = True
        dgvColumnSituacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        Dim dgvColumnVehiculo As New DataGridViewTextBoxColumn()
        dgvColumnVehiculo.HeaderText = "Vehiculo"
        dgvColumnVehiculo.Name = "Vehiculo"
        dgvColumnVehiculo.DataPropertyName = "Vehiculo"
        dgvColumnVehiculo.DisplayIndex = 5
        dgvColumnVehiculo.ValueType = GetType(Vehiculo)
        dgvColumnVehiculo.Visible = False

        Dim dgvColumnPatente As New DataGridViewTextBoxColumn()
        dgvColumnPatente.HeaderText = "Patente"
        dgvColumnPatente.Name = "Patente"
        dgvColumnPatente.DisplayIndex = 6
        dgvColumnPatente.ValueType = GetType(String)
        dgvColumnPatente.Visible = True

        Dim dgvColumnAbono As New DataGridViewTextBoxColumn()
        dgvColumnAbono.HeaderText = "Abono"
        dgvColumnAbono.Name = "Abono"
        dgvColumnAbono.DisplayIndex = 7
        dgvColumnAbono.ValueType = GetType(Boolean)
        dgvColumnAbono.Visible = True

        Dim dgvColumnHoraEntrada As New DataGridViewTextBoxColumn()
        dgvColumnHoraEntrada.HeaderText = "Hora de Entrada"
        dgvColumnHoraEntrada.Name = "HoraEntrada"
        dgvColumnHoraEntrada.DisplayIndex = 8
        dgvColumnHoraEntrada.ValueType = GetType(String)
        dgvColumnHoraEntrada.Visible = True

        Me.dgvEspacios.Columns.Add(dgvColumnEspacio)
        Me.dgvEspacios.Columns.Add(dgvColumnCodigo)
        Me.dgvEspacios.Columns.Add(dgvColumnPiso)
        Me.dgvEspacios.Columns.Add(dgvColumnTamano)
        Me.dgvEspacios.Columns.Add(dgvColumnTipo)
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

            If (espacio.GetType Is GetType(CocheraMovil)) Then
                Dim horaEntrada As DateTime? = DirectCast(espacio, CocheraMovil).HoraEntrada
                If (horaEntrada.HasValue) And Not espacio.Vehiculo Is Nothing Then
                    row.Cells("HoraEntrada").Value = horaEntrada.Value.ToString("HH:mm:ss")
                End If
                row.Cells("Tipo").Value = "Movil"
            Else
                row.Cells("Tipo").Value = "Fija"
            End If
        Next

    End Sub

    Private Sub dgvEspacios_SelectionChanged(sender As Object, e As EventArgs) Handles dgvEspacios.SelectionChanged
        If (Not Me.PlayaCerrada) Then
            If (Me.dgvEspacios.SelectedRows.Count > 0) Then
                Dim row As DataGridViewRow = Me.dgvEspacios.SelectedRows(0)
                Dim espacio As Espacio = row.DataBoundItem
                Me.EspacioDesocupado(espacio.Vehiculo Is Nothing)
            End If
        End If

    End Sub

    Private Sub EspacioDesocupado(pDesocupado As Boolean)
        Me.btnVehiculoIngresar.Enabled = pDesocupado
        Me.btnVehiculoEgresar.Enabled = Not pDesocupado
    End Sub

    Private Sub btnVehiculoIngresar_Click(sender As Object, e As EventArgs) Handles btnVehiculoIngresar.Click
        Dim espacioSeleccionado As Espacio = Me.dgvEspacios.SelectedRows(0).DataBoundItem
        Dim frmVehiculoIngresar As New FrmVehiculoIngresar(espacioSeleccionado)

        If (frmVehiculoIngresar.ShowDialog = Windows.Forms.DialogResult.OK) Then
            Dim vehiculoIngresado As Vehiculo = frmVehiculoIngresar.Vehiculo

            Dim vehiculoExistente = Me.Playa.Espacios.Any(Function(x As Espacio)
                                                              Return Not x.Vehiculo Is Nothing AndAlso x.Vehiculo.Patente.ToUpper = vehiculoIngresado.Patente.ToUpper
                                                          End Function)
            If (Not vehiculoExistente) Then
                espacioSeleccionado.Vehiculo = vehiculoIngresado

                If (espacioSeleccionado.GetType Is GetType(CocheraMovil)) Then
                    DirectCast(espacioSeleccionado, CocheraMovil).HoraEntrada = DateTime.Now
                End If

                Dim espacioLogic As New EspacioLogic
                espacioLogic.Guardar(espacioSeleccionado)
                Me.RefreshGrid()
            Else
                MsgBox("Ya existe un vehiculo cargado en el establecimiento con la patente indicada.")
            End If
        End If

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs)
        Me.PlayaLogic.Guardar(Me.Playa)
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnVehiculoEgresar_Click(sender As Object, e As EventArgs) Handles btnVehiculoEgresar.Click
        Dim espacioSeleccionado As Espacio = Me.dgvEspacios.SelectedRows(0).DataBoundItem
        Dim frmVehiculoEgresar As New FrmVehiculoEgresar(espacioSeleccionado)

        If (frmVehiculoEgresar.ShowDialog = Windows.Forms.DialogResult.OK) Then
            espacioSeleccionado.Vehiculo = Nothing

            If (espacioSeleccionado.GetType Is GetType(CocheraMovil)) Then
                DirectCast(espacioSeleccionado, CocheraMovil).HoraSalida = DateTime.Now
            End If

            Dim espacioLogic As New EspacioLogic
            espacioLogic.Guardar(espacioSeleccionado)
            Me.RefreshGrid()
        End If
    End Sub

    Private Function btnAceptar() As Object
        Throw New NotImplementedException
    End Function

End Class