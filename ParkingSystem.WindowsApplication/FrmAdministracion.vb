Imports ParkingSystem.BusinessLogic
Imports ParkingSystem.Model

Public Class FrmAdministracion

    Private Property Playas As ICollection(Of Playa)

    Private Sub FrmPlayaAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim playaLogic As New PlayaLogic
        Me.InitializeGrid()

        Try
            Me.Playas = playaLogic.Listar()
            Me.RefreshGrid()

        Catch ex As Exception
            MsgBox("Ocurrió un error en la carga de las Playas de estacionamiento.")
        End Try
        
    End Sub

    Private Sub RefreshGrid()
        Me.dgvPlayas.DataSource = Nothing
        Me.dgvPlayas.DataSource = Playas
        Me.dgvPlayas.Refresh()

    End Sub

    Private Sub InitializeGrid()
        Dim dgvColumnId As New DataGridViewTextBoxColumn()
        dgvColumnId.HeaderText = ""
        dgvColumnId.Name = "Id"
        dgvColumnId.Visible = False

        Dim dgvColumnNombre As New DataGridViewTextBoxColumn()
        dgvColumnNombre.HeaderText = "Nombre"
        dgvColumnNombre.Name = "Nombre"
        dgvColumnNombre.DataPropertyName = "Nombre"
        dgvColumnNombre.DisplayIndex = 0
        dgvColumnNombre.Visible = True
        dgvColumnNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        Dim dgvColumnDireccion As New DataGridViewTextBoxColumn()
        dgvColumnDireccion.HeaderText = "Direccion"
        dgvColumnDireccion.Name = "Direccion"
        dgvColumnDireccion.DataPropertyName = "Direccion"
        dgvColumnDireccion.DisplayIndex = 1
        dgvColumnDireccion.Visible = True
        dgvColumnDireccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        Dim dgvColumnHoraApertura As New DataGridViewTextBoxColumn()
        dgvColumnHoraApertura.HeaderText = "HoraApertura"
        dgvColumnHoraApertura.Name = "HoraApertura"
        dgvColumnHoraApertura.DataPropertyName = "HoraApertura"
        dgvColumnHoraApertura.DisplayIndex = 2
        dgvColumnHoraApertura.Visible = True
        dgvColumnHoraApertura.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        Dim dgvColumnHoraCierre As New DataGridViewTextBoxColumn()
        dgvColumnHoraCierre.HeaderText = "HoraCierre"
        dgvColumnHoraCierre.Name = "HoraCierre"
        dgvColumnHoraCierre.DataPropertyName = "HoraCierre"
        dgvColumnHoraCierre.DisplayIndex = 3
        dgvColumnHoraCierre.Visible = True
        dgvColumnHoraCierre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells


        Me.dgvPlayas.Columns.Add(dgvColumnId)
        Me.dgvPlayas.Columns.Add(dgvColumnNombre)
        Me.dgvPlayas.Columns.Add(dgvColumnDireccion)
        Me.dgvPlayas.Columns.Add(dgvColumnHoraApertura)
        Me.dgvPlayas.Columns.Add(dgvColumnHoraCierre)
        Me.dgvPlayas.AutoGenerateColumns = False
    End Sub

    Private Sub btnPlayaAdministrar_Click(sender As Object, e As EventArgs) Handles btnPlayaAdministrar.Click

        If (Me.dgvPlayas.SelectedRows.Count > 0) Then
            Dim playaSeleccionada As Playa = Me.dgvPlayas.SelectedRows(0).DataBoundItem

            Dim frmPlayaAdministrar As New FrmPlayaAdministrar(playaSeleccionada)
            frmPlayaAdministrar.ShowDialog()

        End If

    End Sub

  
    Private Sub btnPlayaGenerar_Click(sender As Object, e As EventArgs) Handles btnPlayaGenerar.Click

        Dim frmPlaya As New FrmPlaya()
        If (frmPlaya.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Dim playaGenerada As Playa = frmPlaya.Playa
            Dim playaLogic As New PlayaLogic
            playaLogic.Guardar(playaGenerada)
            Me.Playas.Add(playaGenerada)
            Me.RefreshGrid()
        End If

    End Sub
End Class