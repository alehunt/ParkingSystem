Imports ParkingSystem.Model

Public Class EspacioDataAccess

    Public Shared Function ListarPorPlaya(pPlayaId As Integer) As CollectionGeneric(Of Espacio)

        Dim espacioDs As DataSet = Database.ExecuteDataset("Select Espacio.EspacioId, PlayaId, Codigo, Piso, Tamano, VehiculoId, ValorMes, HoraEntrada, HoraSalida " & _
                                                           "from Espacio " & _
                                                           "left join CocheraFija on Espacio.EspacioId = CocheraFija.EspacioId " & _
                                                           "left join CocheraMovil on Espacio.EspacioId = CocheraMovil.EspacioId " & _
                                                           "where PlayaId = " & pPlayaId)

        Dim espaciosList As CollectionGeneric(Of Espacio) = New CollectionGeneric(Of Espacio)

        For Each espacioRow As DataRow In espacioDs.Tables(0).Rows

            Dim espacio As Espacio

            If (IsDBNull(espacioRow("ValorMes"))) Then
                espacio = New CocheraMovil()
                DirectCast(espacio, CocheraMovil).HoraEntrada = IIf(IsDBNull(espacioRow("HoraEntrada")), Nothing, espacioRow("HoraEntrada"))
                DirectCast(espacio, CocheraMovil).HoraSalida = IIf(IsDBNull(espacioRow("HoraSalida")), Nothing, espacioRow("HoraSalida"))
            Else
                espacio = New CocheraFija()
                DirectCast(espacio, CocheraFija).ValorMes = espacioRow("ValorMes")
            End If

            espacio.PlayaId = espacioRow("PlayaId")
            espacio.Codigo = espacioRow("Codigo")
            espacio.Piso = espacioRow("Piso")
            espacio.Tamano = [Enum].Parse(GetType(Enums.Tamano), espacioRow("Tamano"))

            If (Not IsDBNull(espacioRow("VehiculoId"))) Then
                espacio.Vehiculo = VehiculoDataAccess.Obtener(espacioRow("VehiculoId"))
            End If

            espacio.State = ICollectable.States.Unchanged
            espaciosList.Add(espacio)
        Next

        Return espaciosList
    End Function

End Class
