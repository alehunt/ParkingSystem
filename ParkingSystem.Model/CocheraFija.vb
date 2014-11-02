Public Class CocheraFija
    Inherits Espacio

#Region "Private Members"
    Private mValorMes As Decimal
#End Region

#Region "Properties"
    Public Property ValorMes() As Decimal
        Get
            Return mValorMes
        End Get
        Set(ByVal value As Decimal)
            mValorMes = value
        End Set
    End Property
#End Region


End Class
