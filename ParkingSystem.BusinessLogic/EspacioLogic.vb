Imports ParkingSystem.DataAccess
Imports ParkingSystem.Model

Public Class EspacioLogic

    Public Sub Guardar(espacio As Model.Espacio)

        If (Not espacio.Vehiculo Is Nothing) Then
            Dim vehiculoLogic As New VehiculoLogic
            vehiculoLogic.Guardar(espacio.Vehiculo)
        End If

        If (espacio.EspacioId = 0) Then
            EspacioDataAccess.Guardar(espacio)

            If (espacio.GetType Is GetType(CocheraMovil)) Then
                EspacioDataAccess.Guardar(DirectCast(espacio, CocheraMovil))
            End If

            If (espacio.GetType Is GetType(CocheraFija)) Then
                EspacioDataAccess.Guardar(DirectCast(espacio, CocheraFija))
            End If
        Else
            EspacioDataAccess.Modificar(espacio)

            If (espacio.GetType Is GetType(CocheraMovil)) Then
                Dim cocheraMovil As CocheraMovil = DirectCast(espacio, CocheraMovil)
                EspacioDataAccess.Modificar(cocheraMovil)
            End If

        End If

    End Sub

    Function GetMontoAbonar(espacio As Espacio) As Decimal

        Dim monto As Decimal = 0

        If (espacio.GetType() Is GetType(CocheraFija)) Then
            Dim cocheraFija As CocheraFija = DirectCast(espacio, CocheraFija)
            monto = cocheraFija.ValorMes
        ElseIf (espacio.GetType() Is GetType(CocheraMovil)) Then
            Dim cocheraMovil As CocheraMovil = DirectCast(espacio, CocheraMovil)

            Dim differenceInHours As Integer = (DateTime.Now - cocheraMovil.HoraEntrada.Value).Hours + 1

            If differenceInHours > 5 Then
                monto = cocheraMovil.Vehiculo.Tipo.ValorEstadia
            Else
                monto = cocheraMovil.Vehiculo.Tipo.ValorHora * differenceInHours
            End If
        End If

        Return monto
    End Function

    Sub EliminarPorPlaya(playaId As Integer)
        EspacioDataAccess.EliminarCocheraFijaPorPlaya(playaId)
        EspacioDataAccess.EliminarCocheraMovilPorPlaya(playaId)
        EspacioDataAccess.EliminarEspacioPorPlaya(playaId)
    End Sub

    Function GetTipoPago(espacio As Espacio) As String

        Dim tipoPago As String = "Ya Abono"

        If (Not espacio.Vehiculo.Abono) Then

            If (espacio.GetType() Is GetType(CocheraFija)) Then
                tipoPago = "Abono Mensual"

            ElseIf (espacio.GetType() Is GetType(CocheraMovil)) Then
                tipoPago = "Abono Por Hora"
            End If
        End If

        Return tipoPago
    End Function


End Class
