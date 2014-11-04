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

            espacio.EspacioId = espacioRow("EspacioId")
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

    Shared Sub Modificar(espacio As Espacio)

        Dim vehiculoId As String = "Null"

        If (Not espacio.Vehiculo Is Nothing) Then
            vehiculoId = espacio.Vehiculo.VehiculoId
        End If

        Dim command As String = "UPDATE Espacio SET Codigo = '" & espacio.Codigo & "'," & _
                        " Piso =  " & espacio.Piso & "," & _
                        " Tamano =  '" & espacio.Tamano.ToString() & "'," & _
                        " VehiculoId = " & vehiculoId & _
                        " WHERE EspacioId = " & espacio.EspacioId

        Try
            Database.ExecuteNonQuery(command)
        Catch ex As Exception
            Throw New ApplicationException("Hubo un fallo al modificar un espacio", ex)
        End Try


    End Sub

    Shared Sub Modificar(cocheraMovil As CocheraMovil)


        Dim horaEntrada As String = DBNull.Value.ToString
        Dim horaSalida As String = DBNull.Value.ToString

        If (cocheraMovil.HoraEntrada.HasValue) Then
            horaEntrada = cocheraMovil.HoraEntrada.Value.ToString("HH:mm:ss")
        End If

        If (cocheraMovil.HoraSalida.HasValue) Then
            horaSalida = cocheraMovil.HoraSalida.Value.ToString("HH:mm:ss")
        End If

        Dim command As String = "UPDATE CocheraMovil SET HoraEntrada = '" & horaEntrada & "'" & _
                                ", HoraSalida = '" & horaSalida & "'" & _
                                " WHERE EspacioId = " & cocheraMovil.EspacioId

        Try
            Database.ExecuteNonQuery(command)
        Catch ex As Exception
            Throw New ApplicationException("Hubo un fallo al modificar un espacio", ex)
        End Try
    End Sub


    Shared Sub Guardar(espacio As Espacio)

        Dim proximoId = Database.ObtenerId("Espacio") + 1

        Dim vehiculoId As String = "Null"

        If (Not espacio.Vehiculo Is Nothing) Then
            vehiculoId = espacio.Vehiculo.VehiculoId
        End If

        Dim command As String = "Insert Into Espacio (EspacioId, PlayaId, Codigo, Piso,Tamano, VehiculoId) " & _
                                "Values(" & proximoId & ", " & espacio.PlayaId & ", '" & espacio.Codigo & "', " & _
                                espacio.Piso & ", '" & espacio.Tamano.ToString() & "', " & vehiculoId & ")"

        Try
            Database.ExecuteNonQuery(command)
            espacio.EspacioId = proximoId
        Catch ex As Exception
            Throw New ApplicationException("Hubo un fallo al crear un espacio", ex)
        End Try
    End Sub


    Shared Sub Guardar(cocheraMovil As CocheraMovil)

        Dim command As String = "Insert Into CocheraMovil(EspacioId) " & _
                                "Values(" & cocheraMovil.EspacioId & ")"

        Try
            Database.ExecuteNonQuery(command)
        Catch ex As Exception
            Throw New ApplicationException("Hubo un fallo al crear una cochera movil", ex)
        End Try
    End Sub

    Shared Sub Guardar(cocheraFija As CocheraFija)

        Dim command As String = "Insert Into CocheraFija(EspacioId, ValorMes) " & _
                                "Values(" & cocheraFija.EspacioId & ", " & cocheraFija.ValorMes & ")"

        Try
            Database.ExecuteNonQuery(command)
        Catch ex As Exception
            Throw New ApplicationException("Hubo un fallo al crear una cochera movil", ex)
        End Try
    End Sub

    Shared Sub EliminarEspacioPorPlaya(playaId As Integer)
        Dim command As String = "Delete from Espacio where PlayaId = " & playaId

        Try
            Database.ExecuteNonQuery(command)
        Catch ex As Exception
            Throw New ApplicationException("Hubo un fallo al crear una cochera movil", ex)
        End Try
    End Sub

    Shared Sub EliminarCocheraFijaPorPlaya(playaId As Integer)
        Dim command As String = "Delete from CocheraFija where EspacioId in (Select EspacioId from Espacio where PlayaId = " & playaId & ")"

        Try
            Database.ExecuteNonQuery(command)
        Catch ex As Exception
            Throw New ApplicationException("Hubo un fallo al eliminar las cocheras fijas", ex)
        End Try
    End Sub


    Shared Sub EliminarCocheraMovilPorPlaya(playaId As Integer)
        Dim command As String = "Delete from CocheraMovil where EspacioId in (Select EspacioId from Espacio where PlayaId = " & playaId & ")"

        Try
            Database.ExecuteNonQuery(command)
        Catch ex As Exception
            Throw New ApplicationException("Hubo un fallo al eliminar las cocheras moviles", ex)
        End Try
    End Sub

End Class
