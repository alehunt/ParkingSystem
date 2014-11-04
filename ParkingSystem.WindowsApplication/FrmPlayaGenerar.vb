Imports ParkingSystem.Model
Imports ParkingSystem.BusinessLogic

Public Class FrmPlayaGenerar

    Public Property Playa As Playa



    Private Sub btnEspacioAgregar_Click(sender As Object, e As EventArgs) Handles btnEspacioAgregar.Click
        Dim frmEspacio As New FrmEspacio()
        If (frmEspacio.ShowDialog = Windows.Forms.DialogResult.OK) Then
            Me.Playa.Espacios.AddObject(frmEspacio.Espacio)
        End If

        Me.GridRefresh()

    End Sub

    Private Sub FrmPlaya_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Playa = New Playa()
        Me.InitializeGrid()
        Me.GridRefresh()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If (Me.ValidarPlaya()) Then
            Me.Playa.Direccion = Me.txtPlayaDireccion.Text
            Me.Playa.Nombre = Me.txtPlayaNombre.Text
            Me.Playa.HoraApertura = Me.mTxtHoraApertura.Text
            Me.Playa.HoraCierre = Me.mTxtHoraCierre.Text

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub

    Private Sub GridRefresh()
        Me.dgvEspacios.DataSource = Nothing

        Me.dgvEspacios.DataSource = Me.Playa.Espacios.ToList()
        Me.dgvEspacios.Refresh()
    End Sub

    Private Sub InitializeGrid()

        Dim dgvColumnEspacio As New DataGridViewTextBoxColumn()
        dgvColumnEspacio.HeaderText = "EspacioId"
        dgvColumnEspacio.Name = "EspacioId"
        dgvColumnEspacio.DataPropertyName = "EspacioId"
        dgvColumnEspacio.Visible = False

        Dim dgvColumnCodigo As New DataGridViewTextBoxColumn()
        dgvColumnCodigo.HeaderText = "Codigo"
        dgvColumnCodigo.Name = "Codigo"
        dgvColumnCodigo.DataPropertyName = "Codigo"
        dgvColumnCodigo.DisplayIndex = 0
        dgvColumnCodigo.Visible = True
        dgvColumnCodigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        Dim dgvColumnPiso As New DataGridViewTextBoxColumn()
        dgvColumnPiso.HeaderText = "Piso"
        dgvColumnPiso.Name = "Piso"
        dgvColumnPiso.DataPropertyName = "Piso"
        dgvColumnPiso.DisplayIndex = 1
        dgvColumnPiso.Visible = True
        dgvColumnPiso.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        Dim dgvColumnTamano As New DataGridViewTextBoxColumn()
        dgvColumnTamano.HeaderText = "Tamano"
        dgvColumnTamano.Name = "Tamano"
        dgvColumnTamano.DataPropertyName = "Tamano"
        dgvColumnTamano.DisplayIndex = 2
        dgvColumnTamano.Visible = True
        dgvColumnTamano.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        Dim dgvColumnTipo As New DataGridViewTextBoxColumn()
        dgvColumnTipo.HeaderText = "Tipo"
        dgvColumnTipo.Name = "Tipo"
        dgvColumnTipo.DataPropertyName = "Tipo"
        dgvColumnTipo.DisplayIndex = 3
        dgvColumnTipo.Visible = True
        dgvColumnTipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells


        Me.dgvEspacios.Columns.Add(dgvColumnEspacio)
        Me.dgvEspacios.Columns.Add(dgvColumnCodigo)
        Me.dgvEspacios.Columns.Add(dgvColumnPiso)
        Me.dgvEspacios.Columns.Add(dgvColumnTamano)
        Me.dgvEspacios.Columns.Add(dgvColumnTipo)

        Me.dgvEspacios.AutoGenerateColumns = False

    End Sub

    Private Sub dgvEspacios_DataSourceChanged(sender As Object, e As EventArgs) Handles dgvEspacios.DataSourceChanged

        If (Me.dgvEspacios.RowCount > 0) Then
            For Each row As DataGridViewRow In Me.dgvEspacios.Rows

                Dim espacio As Espacio = row.DataBoundItem
                If (espacio.GetType Is GetType(CocheraMovil)) Then
                    row.Cells("Tipo").Value = "Movil"
                Else
                    row.Cells("Tipo").Value = "Fija"
                End If
            Next
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnEspacioElminar_Click(sender As Object, e As EventArgs) Handles btnEspacioElminar.Click
        If (Me.dgvEspacios.SelectedRows.Count >= 0) Then

            For Each selectedRow As DataGridViewRow In Me.dgvEspacios.SelectedRows
                Dim espacioSeleccionado As Espacio = selectedRow.DataBoundItem

                Me.Playa.Espacios.RemoveAt(espacioSeleccionado.Index)
            Next

            Me.GridRefresh()
        End If
    End Sub

    Private Function ValidarPlaya() As Boolean
        Dim playaValida As Boolean = True

        Dim dateOut As DateTime

        If Not DateTime.TryParse(Me.mTxtHoraApertura.Text, dateOut) Then
            playaValida = False
            MsgBox("Debe ingresar correctamente la hora de apertura")
        End If

        If playaValida And Not DateTime.TryParse(Me.mTxtHoraCierre.Text, dateOut) Then
            playaValida = False
            MsgBox("Debe ingresar correctamente la hora de cierre")
        End If

        If (playaValida And String.IsNullOrEmpty(Me.txtPlayaNombre.Text.Trim)) Then
            playaValida = False
            MsgBox("Debe ingresar un nombre para la playa")
        End If

        If (playaValida And String.IsNullOrEmpty(Me.txtPlayaDireccion.Text.Trim)) Then
            playaValida = False
            MsgBox("Debe ingresar una direccion para la playa")
        End If

        If (playaValida And Me.Playa.Espacios.Count <= 0) Then
            playaValida = False
            MsgBox("Debe cargar al menos un espacio.")
        End If

        Return playaValida

    End Function

End Class