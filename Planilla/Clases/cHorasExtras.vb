Public Class cHorasExtras

    Private categoria As Integer
    Private id_emp As Integer

    Private _extra As Decimal = 0
    Private _nocturna As Decimal = 0
    Private _mixta As Decimal = 0
    Private _rubro_horasExtras As Integer = 57

    Private conn As New conexionSQL
    Private data As ArrayList

    Dim dsHE As New ds2planilla
    Dim taHE As New ds2planillaTableAdapters.horas_extrasTableAdapter

#Region "métodos"
    Public Sub New(pcat As Integer)

    End Sub

    Public Sub New(pid_emp As String)
        If pid_emp IsNot Nothing Then
            id_emp = pid_emp
            data = conn.llena("exec HoraExtra " & pid_emp) ' consulta montos de horas extras
            _extra = IIf(IsDBNull(data(0)(2)), 0, data(0)(2))
            _nocturna = IIf(IsDBNull(data(0)(3)), 0, data(0)(3))
            _mixta = IIf(IsDBNull(data(0)(4)), 0, data(0)(4))
        End If
    End Sub

    Public Function Cargar_Horas_extras(fini As Date, ffin As Date) As ds2planilla.horas_extrasDataTable

        If id_emp > 0 Then
            taHE.FillById_emp(dsHE.horas_extras, id_emp, fini, ffin)
            Return dsHE.horas_extras
        End If
    End Function

    Public Function Rubro_HorasExtras() As Boolean
        Dim regs As ArrayList
        regs = conn.llena("exec RubroActivo " & id_emp.ToString & ", 57")
        Return (regs.Count > 0)
    End Function


#End Region

#Region "Propiedades"

    Public Property HoraExtra As Decimal
        Get
            Return _extra
        End Get
        Set(value As Decimal)
        End Set
    End Property

    Public Property HoraNocturna As Decimal
        Get
            Return _nocturna
        End Get
        Set(value As Decimal)
        End Set
    End Property

    Public Property HoraMixta As Decimal
        Get
            Return _mixta
        End Get
        Set(value As Decimal)
        End Set
    End Property
#End Region


End Class
