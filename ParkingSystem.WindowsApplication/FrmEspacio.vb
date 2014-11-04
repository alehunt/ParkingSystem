Imports ParkingSystem.Model.Enums
Imports ParkingSystem.Model

Public Class FrmEspacio

    Public Property Espacio As Espacio

    Private Sub FrmEspacio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cbTamano.DataSource = [Enum].GetValues(GetType(Tamano))
    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If (Me.rbFija.Checked) Then
            Me.Espacio = New CocheraFija()
            DirectCast(Me.Espacio, CocheraFija).ValorMes = Me.mTxtValorMes.Text
        ElseIf (Me.rbMovil.Checked) Then
            Me.Espacio = New CocheraMovil
        End If

        Me.Espacio.Codigo = Me.txtCodigo.Text
        Me.Espacio.Piso = Me.nupPiso.Value


        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class