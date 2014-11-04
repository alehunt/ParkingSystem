Imports ParkingSystem.Model
Imports ParkingSystem.DataAccess
Imports System.Transactions

Public Class PlayaLogic

    Public Function Listar() As ICollection(Of Playa)
        Return PlayaDataAccess.Listar()
    End Function

    Sub Guardar(playa As Playa)

        Try
            Using scope As New TransactionScope()
                PlayaDataAccess.Guardar(playa)

                Dim espacioLogic As New EspacioLogic

                For Each espacio In playa.Espacios
                    espacio.PlayaId = playa.PlayaId
                    espacioLogic.Guardar(espacio)
                Next


                scope.Complete()
            End Using
        Catch ex As Exception
            Throw New ApplicationException("Ocurrio un error intentando grabar la playa..")
        End Try

    End Sub

    Sub Eliminar(playa As Playa)
        Dim espacioLogic As New EspacioLogic

        Try
            Using scope As New TransactionScope()
                'Elimino todos los espacios relacionados a la playa
                espacioLogic.EliminarPorPlaya(playa.PlayaId)

                'Una vez eliminados puedo eliminar la playa
                PlayaDataAccess.Eliminar(playa)

                scope.Complete()
            End Using
        Catch ex As Exception
            Throw New ApplicationException("Ocurrio un error intentando eliminar la playa..")
        End Try

    End Sub

End Class
