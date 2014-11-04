Imports ParkingSystem.BusinessLogic
Imports ParkingSystem.Model
Imports System.Text.RegularExpressions
Imports ParkingSystem.Model.Enums

Public Class FrmVehiculoEgresar

    Private Property EspacioLogic As New EspacioLogic
    Private Property Espacio As Espacio

    Public Sub New(pEspacio As Espacio)
        Me.InitializeComponent()
        Me.Espacio = pEspacio
    End Sub

    Private Sub FrmVehiculoEgresar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.mTxtPatente.Text = Me.Espacio.Vehiculo.Patente
        Me.chkAbono.Checked = Me.Espacio.Vehiculo.Abono

        If (Espacio.GetType() Is GetType(CocheraFija)) Then
            Dim cocheraFija As CocheraFija = DirectCast(Me.Espacio, CocheraFija)
            Me.lblTipoPagoValue.Text = "Abono Mensual"
            Me.lblMontoPagoValue.Text = cocheraFija.ValorMes
        End If

        If (Espacio.GetType() Is GetType(CocheraMovil)) Then
            Dim cocheraMovil As CocheraMovil = DirectCast(Me.Espacio, CocheraMovil)

            Me.lblTipoPagoValue.Text = "Abono Movil"
            Me.lblMontoPagoValue.Text = Me.EspacioLogic.GetMontoAbonar(cocheraMovil)

        End If
    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class