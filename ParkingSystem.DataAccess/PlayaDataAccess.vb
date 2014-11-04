Imports ParkingSystem.Model
Imports System.Data.SqlClient

Public Class PlayaDataAccess

    Public Shared Function Listar() As ICollection(Of Playa)

        Dim playasList As ICollection(Of Playa) = New List(Of Playa)

        Dim playasDs As DataSet = Database.ExecuteDataset("Select PlayaId, Direccion, Nombre, HoraApertura, HoraCierre from Playa")

        For Each playaRow As DataRow In playasDs.Tables(0).Rows
            Dim playaNew As New Playa(New Lazy(Of CollectionGeneric(Of Espacio))(Function()
                                                                                     Return EspacioDataAccess.ListarPorPlaya(playaRow("PlayaId"))
                                                                                 End Function))
            playaNew.Id = playaRow("PlayaId")
            playaNew.Direccion = playaRow("Direccion")
            playaNew.Nombre = playaRow("Nombre")
            playaNew.HoraApertura = playaRow("HoraApertura")
            playaNew.HoraCierre = playaRow("HoraCierre")
            playasList.Add(playaNew)

        Next

        Return playasList
    End Function

    Shared Sub Guardar(playa As Playa)
        Throw New NotImplementedException
    End Sub

End Class
