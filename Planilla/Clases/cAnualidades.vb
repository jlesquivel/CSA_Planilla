''' <summary>
''' Controla y calcula las anualidades automaticamente con base en los contratos
''' </summary>
Public Class cAnualidades
    Dim _promedio_salarios As Decimal



    Public Property PromSalario As Decimal
        Get
            Return _promedio_salarios
        End Get
        Set(value As Decimal)
        End Set
    End Property



End Class
