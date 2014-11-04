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
            playaNew.PlayaId = playaRow("PlayaId")
            playaNew.Direccion = playaRow("Direccion")
            playaNew.Nombre = playaRow("Nombre")
            playaNew.HoraApertura = playaRow("HoraApertura")
            playaNew.HoraCierre = playaRow("HoraCierre")
            playasList.Add(playaNew)

        Next

        Return playasList
    End Function

    Shared Sub Guardar(playa As Playa)

        Dim proximoId As Integer = Database.ObtenerId("Playa") + 1

        Dim command As String = "INSERT INTO PLAYA(PlayaId, Nombre, Direccion, HoraApertura, HoraCierre) " & _
                                "VALUES(" & proximoId & ", '" & playa.Nombre & "', '" & playa.Direccion & "', '" & _
                                CDate(playa.HoraApertura).ToString("HH:mm:ss") & "' , '" & CDate(playa.HoraCierre).ToString("HH:mm:ss") & "')"

        Try
            Database.ExecuteNonQuery(command)
            playa.PlayaId = proximoId
        Catch ex As Exception
            Throw New ApplicationException("Ocurrio un error al insertar un vehiculo ", ex)
        End Try
    End Sub

    Shared Sub Eliminar(playa As Playa)
        Dim command As String = "Delete from Playa where PlayaId = " & playa.PlayaId

        Try
            Database.ExecuteNonQuery(command)
        Catch ex As Exception
            Throw New ApplicationException("Hubo un fallo al crear una cochera movil", ex)
        End Try
    End Sub

End Class
