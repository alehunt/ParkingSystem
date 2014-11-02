Public Class Playa

#Region "Private Members"

    Private mNombre As String
    Private mDireccion As String
    Private mHoraApertura As DateTime
    Private mHoraCierre As DateTime
    Private mId As Integer

#End Region

#Region "Properties"
    Public Property Id() As Integer
        Get
            Return mId
        End Get
        Set(ByVal value As Integer)
            mId = value
        End Set
    End Property


    Public Property HoraCierre() As String
        Get
            Return mHoraCierre.ToShortTimeString()
        End Get
        Set(ByVal value As String)
            mHoraCierre = value
        End Set
    End Property

    Public Property HoraApertura() As String
        Get
            Return mHoraApertura.ToShortTimeString()
        End Get
        Set(ByVal value As String)
            mHoraApertura = value
        End Set
    End Property

    Public Property Direccion() As String
        Get
            Return mDireccion
        End Get
        Set(ByVal value As String)
            mDireccion = value
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
