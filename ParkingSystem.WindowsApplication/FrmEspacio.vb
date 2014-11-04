Imports ParkingSystem.Model.Enums
Imports ParkingSystem.Model

Public Class FrmEspacio

    Public Property Espacio As Espacio

    Private Sub FrmEspacio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cbTamano.DataSource = [Enum].GetValues(GetType(Tamano))
        Me.rbMovil.Checked = True
    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If (Me.ValidarEspacio()) Then
            If (Me.rbFija.Checked) Then
                Me.Espacio = New CocheraFija()
                Dim out As Decimal
                Decimal.TryParse(Me.mTxtValorMes.Text, out)
                DirectCast(Me.Espacio, CocheraFija).ValorMes = out
            ElseIf (Me.rbMovil.Checked) Then
                Me.Espacio = New CocheraMovil
            End If

            Me.Espacio.Tamano = Me.cbTamano.SelectedItem
            Me.Espacio.Codigo = Me.txtCodigo.Text
            Me.Espacio.Piso = Me.nupPiso.Value

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub rbFija_CheckedChanged(sender As Object, e As EventArgs) Handles rbFija.CheckedChanged
        Me.mTxtValorMes.Enabled = Me.rbFija.Checked
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function ValidarEspacio() As Boolean

        Dim espacioValido As Boolean = True

        If String.IsNullOrEmpty(Me.txtCodigo.Text) Then
            espacioValido = False
            MsgBox("Debe ingresar un código.")
        End If

        If (espacioValido AndAlso Me.rbFija.Checked AndAlso Me.mTxtValorMes.Text.Trim.Count <= 0) Then
            espacioValido = False
            MsgBox("Debe cargar un valor mensual de la cochera fija.")
        End If

        Return espacioValido

    End Function

End Class