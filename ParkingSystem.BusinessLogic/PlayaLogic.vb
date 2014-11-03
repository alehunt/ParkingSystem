Imports ParkingSystem.Model
Imports ParkingSystem.DataAccess

Public Class PlayaLogic

    Public Function Listar() As ICollection(Of Playa)
        Return PlayaDataAccess.Listar()
    End Function

    Sub Guardar(playa As Playa)
        Throw New NotImplementedException
    End Sub

End Class
