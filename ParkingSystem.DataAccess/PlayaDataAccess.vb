Imports ParkingSystem.Model
Imports System.Data.SqlClient

Public Class PlayaDataAccess

    Public Shared Function Listar() As ICollection(Of Playa)

        Dim playasList As ICollection(Of Playa) = New List(Of Playa)

        Dim playasDs As DataSet = Database.ExecuteDataset("Select Id, Direccion, Nombre, HoraApertura, HoraCierre from Playa")

        For Each playaRow As DataRow In playasDs.Tables(0).Rows
            Dim playa As New Playa
            playa.Id = playaRow("Id")
            playa.Direccion = playaRow("Direccion")
            playa.Nombre = playaRow("Nombre")
            playa.HoraApertura = playaRow("HoraApertura")
            playa.HoraCierre = playaRow("HoraCierre")
            playasList.Add(playa)
        Next

        Return playasList
    End Function

End Class
