Public Class Vehiculo
    Implements ICollectable


#Region "Private Members"
    Private mTipo As TipoVehiculo
    Private mPatente As String
    Private mAbono As Boolean
    Private mVehiculoId As Integer
#End Region

#Region "Properties"
    Public Property VehiculoId() As Integer
        Get
            Return mVehiculoId
        End Get
        Set(ByVal value As Integer)
            mVehiculoId = value
        End Set
    End Property

    Public Property Abono() As Boolean
        Get
            Return mAbono
        End Get
        Set(ByVal value As Boolean)
            mAbono = value
        End Set
    End Property

    Public Property Patente() As String
        Get
            Return mPatente
        End Get
        Set(ByVal value As String)
            mPatente = value
        End Set
    End Property

    Public Property Tipo() As TipoVehiculo
        Get
            Return mTipo
        End Get
        Set(ByVal value As TipoVehiculo)
            mTipo = value
        End Set
    End Property
#End Region

#Region "ICollectable"
    Public Property Index As Integer Implements ICollectable.Index
    Public Property State As ICollectable.States Implements ICollectable.State
#End Region
End Class
