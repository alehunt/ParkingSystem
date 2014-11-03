Public Class CocheraMovil
    Inherits Espacio

#Region "Private Members"
    Private mHoraEntrada As DateTime?
    Private mHoraSalida As DateTime?
#End Region

#Region "Properties"
    Public Property HoraSalida() As DateTime?
        Get
            Return mHoraSalida
        End Get
        Set(ByVal value As DateTime?)
            mHoraSalida = value
        End Set
    End Property

    Public Property HoraEntrada() As DateTime?
        Get
            Return mHoraEntrada
        End Get
        Set(ByVal value As DateTime?)
            mHoraEntrada = value
        End Set
    End Property
#End Region


End Class
