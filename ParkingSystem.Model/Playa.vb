Public Class Playa

#Region "Private Members"

    Private mPlayaId As Integer
    Private mNombre As String
    Private mDireccion As String
    Private mHoraApertura As DateTime
    Private mHoraCierre As DateTime

    Private mEspacios As Lazy(Of CollectionGeneric(Of Espacio))

    Public ReadOnly Property Espacios() As CollectionGeneric(Of Espacio)
        Get
            Return mEspacios.Value
        End Get
    End Property

#End Region


#Region "Constructors"
    Public Sub New()
        Me.mEspacios = New Lazy(Of CollectionGeneric(Of Espacio))(Function()
                                                                      Return New CollectionGeneric(Of Espacio)
                                                                  End Function)

    End Sub

    Public Sub New(pEspaciosLazy As Lazy(Of CollectionGeneric(Of Espacio)))
        Me.mEspacios = pEspaciosLazy
    End Sub
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


    Public Property HoraCierre() As String
        Get
            Return mHoraCierre.ToString("HH:mm:ss")
        End Get
        Set(ByVal value As String)
            mHoraCierre = value
        End Set
    End Property

    Public Property HoraApertura() As String
        Get
            Return mHoraApertura.ToString("HH:mm:ss")
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
