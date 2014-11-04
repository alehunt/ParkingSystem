Imports ParkingSystem.BusinessLogic
Imports ParkingSystem.Model
Imports System.Text.RegularExpressions
Imports ParkingSystem.Model.Enums

Public Class FrmVehiculoIngresar

    Public Property Vehiculo As Vehiculo
    Private Property VehiculoLogic As New VehiculoLogic
    Private Property Espacio As Espacio

    Public Sub New(pEspacio As Espacio)
        Me.InitializeComponent()

        Me.Espacio = pEspacio
        Me.Vehiculo = New Vehiculo()
        Me.Vehiculo.Tipo = Me.VehiculoLogic.ObtenerTipoPorTamano(pEspacio.Tamano)

    End Sub

    Private Sub FrmVehiculoIngresar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MostrarTipoVehiculo()
        Me.btnAceptar.Enabled = False
    End Sub

    Private Sub MostrarTipoVehiculo()
        Me.lblTipoVehiculoNombreValue.Text = Me.Vehiculo.Tipo.Nombre
        Me.lblTipoVehiculoValorEstadiaValue.Text = ((Me.Espacio.PorcentajeValor * Me.Vehiculo.Tipo.ValorEstadia) / 100).ToString("##.##")
        Me.lblTipoVehiculoValorHoraValue.Text = ((Me.Espacio.PorcentajeValor * Me.Vehiculo.Tipo.ValorHora) / 100).ToString("##.##")
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If (Me.ValidarVehiculo()) Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Function ValidarVehiculo() As Boolean
        Dim validated As Boolean = False

        If (Me.mTxtPatente.Text.Count = 7) Then
            Me.Vehiculo.Patente = Me.mTxtPatente.Text
            Me.Vehiculo.Abono = Me.chkAbono.Checked
            validated = True
        End If

        Return validated
    End Function

    Private Sub mTxtPatente_Validated(sender As Object, e As EventArgs) Handles mTxtPatente.Validated
        Me.btnAceptar.Enabled = Me.ValidarPatente(Me.mTxtPatente.Text)
    End Sub

    Private Function ValidarPatente(pPatente As String) As Boolean
        Dim patenteValida As Boolean = False

        If (Me.mTxtPatente.Text.Count = 7) Then
            patenteValida = True
        End If

        Return patenteValida
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class