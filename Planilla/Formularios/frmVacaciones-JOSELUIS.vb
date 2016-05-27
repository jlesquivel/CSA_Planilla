Public Class frmVacaciones

    Private _id As Integer
    Private _saldo As Integer

    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
            Me.Vacacion_regTableAdapter.FillBy(Me.DsVacaciones.Vacacion_reg, _id)
        End Set
    End Property


    Public Sub New(pid_vacaciones, psaldo)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        _id = pid_vacaciones
        _saldo = psaldo
        Me.Vacacion_regTableAdapter.FillBy(Me.DsVacaciones.Vacacion_reg, _id)
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        If Not Traslape_Fechas_Grid() Then
            Dim diasD As Integer = DateDiff(DateInterval.Day, DateTimeInput1.Value, DateTimeInput2.Value) + 1
            Vacacion_regTableAdapter.Insertar(_id, diasD, nota.Text, DateTimeInput1.Value, DateTimeInput2.Value, motivo.Text)
            Vacacion_regTableAdapter.FillBy(Me.DsVacaciones.Vacacion_reg, _id)
            _saldo = _saldo - diasD
            DiasSaldo.Value = _saldo
        End If
    End Sub

    Private Sub DateTimeInput1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimeInput1.ValueChanged
        If Not Traslape_Fechas_Grid() Then
            DiasRango.Value = dias()
        End If
    End Sub

    Private Sub DateTimeInput2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimeInput2.ValueChanged
        If Not Traslape_Fechas_Grid() Then
            DiasRango.Value = dias()
        End If
    End Sub
    Private Function dias() As Integer
        Dim saldox As Integer = DateDiff(DateInterval.Day, DateTimeInput1.Value, DateTimeInput2.Value) + 1
        ButtonX1.Visible = _saldo >= saldox
        Return (saldox)
    End Function

    Private Sub frmVacaciones_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        DiasSaldo.Value = _saldo
        ButtonX1.Visible = (_saldo > 0)
        motivo.Text = "Vacaciones"
        If _saldo > 0 Then
            DateTimeInput1.Value = Now
            DateTimeInput2.Value = DateAdd(DateInterval.Day, _saldo - 1, Now)
        End If
    End Sub

    Private Function Traslape_Fechas_Grid() As Boolean
        Dim _traslape As Boolean = False

        If DataGridViewX1.RowCount > 0 Then
            Dim fdg_ini, fdg_fin As Date
            Dim traslape As Boolean = False

            For i As Integer = 0 To DataGridViewX1.RowCount - 1
                fdg_ini = DataGridViewX1.Item("fechaI", i).Value
                fdg_fin = DataGridViewX1.Item("fechaF", i).Value

                If Traslape_Fecha(DateTimeInput1.Value, DateTimeInput2.Value, fdg_ini, fdg_fin) Then
                    traslape = True
                    MsgBox("Existe traslape de fecha ", MsgBoxStyle.Exclamation)
                    _traslape = True
                    Exit For
                End If
            Next
        End If
        Return _traslape
    End Function

    Private Function Traslape_Fecha(ByVal period1_start As Date, ByVal period1_end As Date, ByVal period2_start As Date, ByVal period2_end As Date)

        If Date.Compare(period1_start, period2_end) <= 0 And Date.Compare(period1_end, period2_start) >= 0 Then
            Return True
        End If
        Return False

    End Function

End Class

