Public Class Vehiculo

#Region "Private Members"
    Private mTipo As TipoVehiculo
    Private mPatente As String
    Private mAbono As Boolean
#End Region

#Region "Properties"
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

End Class
