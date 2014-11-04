Imports ParkingSystem.BusinessLogic
Imports ParkingSystem.Model

Public Class FrmVehiculoIngresar

    Public Property Vehiculo As Vehiculo

    Private Sub FrmVehiculoIngresar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim vehiculoLogic As New VehiculoLogic
        Me.Vehiculo = New Vehiculo()

        Me.cbTipoVehiculo.ValueMember = "TipoVehiculoId"
        Me.cbTipoVehiculo.DisplayMember = "Nombre"
        Me.cbTipoVehiculo.DataSource = vehiculoLogic.ListarTipos()
        Me.cbTipoVehiculo.SelectedIndex = 0
    End Sub

    Private Sub cbTipoVehiculo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoVehiculo.SelectedIndexChanged
        If (Me.cbTipoVehiculo.SelectedIndex >= 0) Then
            Me.CargarTipoVehiculoSeleccionado()

        End If
    End Sub

    Private Sub btnBuscarPatente_Click(sender As Object, e As EventArgs) Handles btnBuscarPatente.Click
        If (String.IsNullOrEmpty(Me.txtPatente.Text)) Then
            MsgBox("Por favor ingrese alguna patente para buscar..")
        Else
            Dim vehiculoEncontrado As Vehiculo = VehiculoLogic.ObtenerPorPatente(Me.txtPatente.Text)

            If (Not vehiculoEncontrado Is Nothing) Then
                Me.CargarVehiculo(vehiculoEncontrado)
            End If
        End If

    End Sub

    Private Sub CargarVehiculo(vehiculoEncontrado As Model.Vehiculo)
        Me.cbTipoVehiculo.SelectedItem = vehiculoEncontrado.Tipo
        Me.CargarTipoVehiculoSeleccionado()
        Me.chkAbono.Checked = vehiculoEncontrado.Abono
    End Sub

    Private Sub CargarTipoVehiculoSeleccionado()
        Dim tipoVehiculo As TipoVehiculo = Me.cbTipoVehiculo.SelectedItem
        Me.lblTipoVehiculoValorEstadiaValue.Text = tipoVehiculo.ValorEstadia.ToString("##.##")
        Me.lblTipoVehiculoValorHoraValue.Text = tipoVehiculo.ValorHora.ToString("##.##")
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class