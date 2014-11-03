Public Class TipoVehiculo

#Region "Private Members"
    Private mTipoVehiculoId As Integer
    Private mNombre As String
    Private mValorHora As Decimal
    Private mValorEstadia As Decimal

#End Region

#Region "Properties"
    Public Property TipoVehiculoId() As Integer
        Get
            Return mTipoVehiculoId
        End Get
        Set(ByVal value As Integer)
            mTipoVehiculoId = value
        End Set
    End Property


    Public Property ValorEstadia() As Decimal
        Get
            Return mValorEstadia
        End Get
        Set(ByVal value As Decimal)
            mValorEstadia = value
        End Set
    End Property


    Public Property ValorHora() As Decimal
        Get
            Return mValorHora
        End Get
        Set(ByVal value As Decimal)
            mValorHora = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return mNombre
        End Get
        Set(ByVal value As String)
            mNombre = value
        End Set
    End Property
#End Region




End Class
