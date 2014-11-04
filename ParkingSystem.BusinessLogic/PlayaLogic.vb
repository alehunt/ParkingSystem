Imports ParkingSystem.Model
Imports ParkingSystem.DataAccess

Public Class PlayaLogic

    Public Function Listar() As ICollection(Of Playa)
        Return PlayaDataAccess.Listar()
    End Function

    Sub Guardar(playa As Playa)
        PlayaDataAccess.Guardar(playa)









    End Sub

End Class
