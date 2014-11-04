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

    Shared Sub Guardar(vehiculo As Vehiculo)
        Dim proximoId As Integer = Database.ObtenerId("Vehiculo") + 1

        Dim command As String = "INSERT INTO VEHICULO (VehiculoId, Patente, Abono, TipoVehiculoId) " & _
                                "VALUES(" & proximoId & ", '" & vehiculo.Patente & "'," & IIf(vehiculo.Abono, 1, 0) & "," & vehiculo.Tipo.TipoVehiculoId & ")"

        Try
            Database.ExecuteNonQuery(command)
            vehiculo.VehiculoId = proximoId
            vehiculo.State = ICollectable.States.Unchanged
        Catch ex As Exception
            Throw New ApplicationException("Ocurrio un error al insertar un vehiculo ", ex)
        End Try
    End Sub

    Shared Sub Modificar(vehiculo As Vehiculo)
        Dim command As String = "Update Vehiculo Set Abono = " & IIf(vehiculo.Abono, 1, 0) & ", TipoVehiculoId = " & vehiculo.Tipo.TipoVehiculoId & _
                                " Where VehiculoId = " & vehiculo.VehiculoId

        Try
            Database.ExecuteNonQuery(command)
            vehiculo.State = ICollectable.States.Unchanged
        Catch ex As Exception
            Throw New ApplicationException("Ocurrio un error al insertar un vehiculo ", ex)
        End Try

    End Sub

End Class
