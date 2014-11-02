Imports ParkingSystem.BusinessLogic
Imports ParkingSystem.Model

Public Class FrmPlayaAdministracion

    Private Sub FrmPlayaAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim playaLogic As New PlayaLogic
        Dim playas As ICollection(Of Playa) = playaLogic.Listar()

        Me.dgvPlayas.DataSource = playas
        Me.dgvPlayas.Columns.Remove("Id")
        Me.dgvPlayas.Columns("Nombre").DisplayIndex = 0
        Me.dgvPlayas.Columns("Direccion").DisplayIndex = 1
        Me.dgvPlayas.Columns("HoraApertura").DisplayIndex = 2
        Me.dgvPlayas.Columns("HoraCierre").DisplayIndex = 3
        Me.dgvPlayas.Refresh()
    End Sub
End Class