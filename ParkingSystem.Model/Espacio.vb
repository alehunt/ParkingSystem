Imports ParkingSystem.Model.Enums

Public MustInherit Class Espacio
    Implements ICollectable

#Region "Private Properties"

    Private mCodigo As String
    Private mPiso As Integer
    Private mVehiculo As Vehiculo
    Private mTamano As Tamano
    Private mPlayaId As Integer
    Private mEspacioId As Integer

#End Region

#Region "Properties"
    Public Property PlayaId() As Integer
        Get
            Return mPlayaId
        End Get
        Set(ByVal value As Integer)
            mPlayaId = value
        End Set
    End Property

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
            Me.State = ICollectable.States.Modified
            mVehiculo = value
        End Set
    End Property

    Public ReadOnly Property PorcentajeValor() As Decimal
        Get
            Dim porcentajePiso As Decimal = 90

            If (Me.Piso < 10) Then
                porcentajePiso = Me.Piso * 10
            End If

            Return 100 - porcentajePiso
        End Get
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

    Public Property EspacioId() As Integer
        Get
            Return mEspacioId
        End Get
        Set(ByVal value As Integer)
            mEspacioId = value
        End Set
    End Property

#End Region


#Region "ICollectable"
    Private mIndex As Integer
    Public Property Index() As Integer Implements ICollectable.Index
        Get
            Return mIndex
        End Get
        Set(ByVal value As Integer)
            mIndex = value
        End Set
    End Property

    Private mState As ICollectable.States
    Public Property State() As ICollectable.States Implements ICollectable.State
        Get
            Return mState
        End Get
        Set(ByVal value As ICollectable.States)
            mState = value
        End Set
    End Property


#End Region

End Class


