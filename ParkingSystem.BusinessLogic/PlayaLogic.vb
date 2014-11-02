Imports ParkingSystem.Model
Imports ParkingSystem.DataAccess

Public Class PlayaLogic

    Public Function Listar() As ICollection(Of Playa)
        Return PlayaDataAccess.Listar()
    End Function

End Class
