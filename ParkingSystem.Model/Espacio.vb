Imports ParkingSystem.Model.Enums

Public MustInherit Class Espacio

#Region "Private Properties"
    Private mCodigo As String
    Private mPiso As Integer
    Private mPorcentajeValor As Decimal
    Private mVehiculo As Vehiculo
    Private mTamano As Tamano
#End Region

#Region "Properties"
    Public Property Tamano() As Tamano
        Get
            Return mTamano
        End Get
        Set(ByVal value As Tamano)
            mTamano = value
        End Set
    End Property

    Public Property Vehiculo() As Vehiculo
        Get
            Return mVehiculo
        End Get
        Set(ByVal value As Vehiculo)
            mVehiculo = value
        End Set
    End Property

    Public Property PorcentajeValor() As Decimal
        Get
            Return mPorcentajeValor
        End Get
        Set(ByVal value As Decimal)
            mPorcentajeValor = value
        End Set
    End Property

    Public Property Piso() As Integer
        Get
            Return mPiso
        End Get
        Set(ByVal value As Integer)
            mPiso = value
        End Set
    End Property

    Public Property Codigo() As String
        Get
            Return mCodigo
        End Get
        Set(ByVal value As String)
            mCodigo = value
        End Set
    End Property
#End Region
End Class


