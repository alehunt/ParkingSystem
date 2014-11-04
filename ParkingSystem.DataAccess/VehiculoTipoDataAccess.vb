Imports ParkingSystem.Model

Public Class TipoVehiculoDataAccess

    Public Shared Function Obtener(pTipoVehiculoId As Integer) As TipoVehiculo

        Dim tipoVehiculo As TipoVehiculo = Nothing
        Dim tipoVehiculoDs As DataSet = Database.ExecuteDataset("Select TipoVehiculoId, Nombre, ValorHora, ValorEstadia from TipoVehiculo where TipoVehiculoId = " & pTipoVehiculoId)

        If (Not IsNothing(tipoVehiculoDs) AndAlso tipoVehiculoDs.Tables.Count > 0 AndAlso tipoVehiculoDs.Tables(0).Rows.Count > 0) Then
            Dim dataRow As DataRow = tipoVehiculoDs.Tables(0).Rows(0)
            tipoVehiculo = New TipoVehiculo
            tipoVehiculo.TipoVehiculoId = dataRow("TipoVehiculoId")
            tipoVehiculo.Nombre = dataRow("Nombre")
            tipoVehiculo.ValorEstadia = dataRow("ValorEstadia")
            tipoVehiculo.ValorHora = dataRow("ValorHora")
        End If

        Return tipoVehiculo
    End Function


    Public Shared Function ObtenerPorNombre(pNombre As String) As TipoVehiculo
        Dim tipoVehiculo As TipoVehiculo = Nothing
        Dim tipoVehiculoDs As DataSet = Database.ExecuteDataset("Select TipoVehiculoId, Nombre, ValorHora, ValorEstadia from TipoVehiculo where Nombre = '" & pNombre & "'")

        If (Not IsNothing(tipoVehiculoDs) AndAlso tipoVehiculoDs.Tables.Count > 0 AndAlso tipoVehiculoDs.Tables(0).Rows.Count > 0) Then
            Dim dataRow As DataRow = tipoVehiculoDs.Tables(0).Rows(0)
            tipoVehiculo = New TipoVehiculo
            tipoVehiculo.TipoVehiculoId = dataRow("TipoVehiculoId")
            tipoVehiculo.Nombre = dataRow("Nombre")
            tipoVehiculo.ValorEstadia = dataRow("ValorEstadia")
            tipoVehiculo.ValorHora = dataRow("ValorHora")
        End If

        Return tipoVehiculo
    End Function


    Public Shared Function Listar() As ICollection(Of TipoVehiculo)

        Dim tipoVehiculoList As New List(Of TipoVehiculo)
        Dim tipoVehiculoDs As DataSet = Database.ExecuteDataset("Select TipoVehiculoId, Nombre, ValorHora, ValorEstadia from TipoVehiculo ")

        For Each dataRow As DataRow In tipoVehiculoDs.Tables(0).Rows
            Dim tipoVehiculo = New TipoVehiculo
            tipoVehiculo.TipoVehiculoId = dataRow("TipoVehiculoId")
            tipoVehiculo.Nombre = dataRow("Nombre")
            tipoVehiculo.ValorEstadia = dataRow("ValorEstadia")
            tipoVehiculo.ValorHora = dataRow("ValorHora")
            tipoVehiculoList.Add(tipoVehiculo)
        Next

        Return tipoVehiculoList
    End Function


End Class
