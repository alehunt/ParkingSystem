Imports ParkingSystem.Model

Public Class VehiculoDataAccess

    Public Shared Function Obtener(pVehiculoId As Integer) As Vehiculo

        Dim vehiculo As Vehiculo = Nothing
        Dim vehiculoDs As DataSet = Database.ExecuteDataset("Select VehiculoId, Patente, Abono, TipoVehiculoId from Vehiculo where VehiculoId = " & pVehiculoId)

        If (Not IsNothing(vehiculoDs) AndAlso vehiculoDs.Tables.Count > 0 AndAlso vehiculoDs.Tables(0).Rows.Count > 0) Then
            Dim dataRow As DataRow = vehiculoDs.Tables(0).Rows(0)
            vehiculo = New Vehiculo()
            vehiculo.VehiculoId = dataRow("VehiculoId")
            vehiculo.Patente = dataRow("Patente")
            vehiculo.Abono = dataRow("Abono")
            vehiculo.Tipo = TipoVehiculoDataAccess.Obtener(dataRow("TipoVehiculoId"))
            vehiculo.State = ICollectable.States.Unchanged
        End If

        Return vehiculo
    End Function

    Shared Function ObtenerPorPatente(pPatente As String) As Vehiculo
        Dim vehiculo As Vehiculo = Nothing
        Dim vehiculoDs As DataSet = Database.ExecuteDataset("Select VehiculoId, Patente, Abono, TipoVehiculoId from Vehiculo where Patente = '" & pPatente & "'")

        If (Not IsNothing(vehiculoDs) AndAlso vehiculoDs.Tables.Count > 0 AndAlso vehiculoDs.Tables(0).Rows.Count > 0) Then
            Dim dataRow As DataRow = vehiculoDs.Tables(0).Rows(0)
            vehiculo = New Vehiculo()
            vehiculo.VehiculoId = dataRow("VehiculoId")
            vehiculo.Patente = dataRow("Patente")
            vehiculo.Abono = dataRow("Abono")
            vehiculo.Tipo = TipoVehiculoDataAccess.Obtener(dataRow("TipoVehiculoId"))
            vehiculo.State = ICollectable.States.Unchanged
        End If

        Return vehiculo
    End Function

End Class
