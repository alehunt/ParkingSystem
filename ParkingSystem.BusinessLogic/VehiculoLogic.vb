Imports ParkingSystem.Model
Imports ParkingSystem.DataAccess
Imports ParkingSystem.Model.Enums

Public Class VehiculoLogic

    Public Function ObtenerTipoPorTamano(pTamano As Tamano) As TipoVehiculo

        Dim nombreVehiculo As String = String.Empty
        Select Case pTamano
            Case Tamano.Chico
                nombreVehiculo = "Moto"
            Case Tamano.Mediano
                nombreVehiculo = "Automovil"
            Case Tamano.Grande
                nombreVehiculo = "Camioneta"
        End Select

        Return TipoVehiculoDataAccess.ObtenerPorNombre(nombreVehiculo)
    End Function

    Public Function ListarTipos() As ICollection(Of TipoVehiculo)
        Return TipoVehiculoDataAccess.Listar()
    End Function

    Public Function ObtenerPorPatente(pPatente As String) As Vehiculo
        Return VehiculoDataAccess.ObtenerPorPatente(pPatente)
    End Function

    Sub Guardar(vehiculo As Vehiculo)

        Dim vehiculoExistente As Vehiculo = Me.ObtenerPorPatente(vehiculo.Patente)

        'Si ya se encontraba generada esa patente
        If (Not vehiculoExistente Is Nothing) Then
            vehiculo.VehiculoId = vehiculoExistente.VehiculoId
        End If

        If (vehiculo.VehiculoId = 0) Then
            VehiculoDataAccess.Guardar(vehiculo)
        Else
            VehiculoDataAccess.Modificar(vehiculo)
        End If
    End Sub

End Class
