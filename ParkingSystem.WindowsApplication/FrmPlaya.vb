Imports ParkingSystem.Model
Imports ParkingSystem.BusinessLogic

Public Class FrmPlaya

    Public Property Playa As Playa

    Private Sub btnEspacioAgregar_Click(sender As Object, e As EventArgs) Handles btnEspacioAgregar.Click
        Dim frmEspacio As New FrmEspacio()
        If (frmEspacio.ShowDialog = Windows.Forms.DialogResult.OK) Then
            Me.Playa.Espacios.Add(frmEspacio.Espacio)
        End If
    End Sub

    Private Sub FrmPlaya_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Playa = New Playa()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Playa.Direccion = Me.txtPlayaDireccion.Text
        Me.Playa.Nombre = Me.txtPlayaNombre.Text
        Me.Playa.HoraApertura = Me.mTxtHoraApertura.Text
        Me.Playa.HoraCierre = Me.mTxtHoraCierre.Text

        Dim playaLogic As New PlayaLogic
        playaLogic.Guardar(Me.Playa)

    End Sub
End Class