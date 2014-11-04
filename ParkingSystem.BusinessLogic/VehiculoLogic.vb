Imports ParkingSystem.Model
Imports ParkingSystem.DataAccess

Public Class VehiculoLogic

    Public Function ListarTipos() As ICollection(Of TipoVehiculo)
        Return TipoVehiculoDataAccess.Listar()
    End Function

    Shared Function ObtenerPorPatente(pPatente As String) As Vehiculo
        Return VehiculoDataAccess.ObtenerPorPatente(pPatente)
    End Function

End Class
