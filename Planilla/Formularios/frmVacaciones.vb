Public Class frmVacaciones

    Private _id As Integer
    Private _saldo As Integer
    Private _id_emp As Integer

    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
            Me.Vacacion_regTableAdapter.FillBy(Me.DsVacaciones.Vacacion_reg, _id)
        End Set
    End Property


    Public Sub New(pid_vacaciones, psaldo, pid_emp)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        _id = pid_vacaciones
        _saldo = psaldo
        _id_emp = pid_emp
        Me.Vacacion_regTableAdapter.FillBy(Me.DsVacaciones.Vacacion_reg, _id)
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        If Not Traslape_Fechas_Grid() Then
            Dim diasD As Integer = DateDiff(DateInterval.Day, fechaI_ord.Value, fechaF_ord.Value) + 1
            Vacacion_regTableAdapter.Insertar(_id, diasD, nota.Text, fechaI_ord.Value, fechaF_ord.Value, motivo.Text, fechaI_Adic.Value, fechaF_Adic.Value)
            Vacacion_regTableAdapter.FillBy(Me.DsVacaciones.Vacacion_reg, _id)
            _saldo = _saldo - diasD
            DiasSaldo.Value = _saldo
        End If
    End Sub

    Private Sub DateTimeInput1_ValueChanged(sender As Object, e As EventArgs) Handles fechaI_ord.ValueChanged
        If Not Traslape_Fechas_Grid() Then
            DiasRango.Value = dias()
        End If
    End Sub

    Private Sub DateTimeInput2_ValueChanged(sender As Object, e As EventArgs) Handles fechaF_ord.ValueChanged
        If Not Traslape_Fechas_Grid() Then
            DiasRango.Value = dias()
        End If
    End Sub
    Private Function dias() As Integer
        Dim saldox As Integer = DateDiff(DateInterval.Day, fechaI_ord.Value, fechaF_ord.Value) + 1
        ButtonX1.Visible = _saldo >= saldox
        Return (saldox)
    End Function

    Private Function diasAdicionales() As Integer
        Dim saldox As Integer = DateDiff(DateInterval.Day, fechaI_Adic.Value, fechaF_Adic.Value) + 1
        Return (saldox)
    End Function

    Private Sub frmVacaciones_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        DiasSaldo.Value = _saldo
        ButtonX1.Visible = (_saldo > 0)
        motivo.Text = "Vacaciones"
        fechaI_ord.Value = Now
        fechaF_ord.Value = DateAdd(DateInterval.Day, _saldo - 1, Now)
    End Sub

    Private Function Traslape_Fechas_Grid() As Boolean
        If DataGridViewX1.RowCount > 0 Then
            Dim fdg_ini, fdg_fin As Date
            Dim traslape As Boolean = False

            For i As Integer = 0 To DataGridViewX1.RowCount - 1
                fdg_ini = DataGridViewX1.Item("fechaI", i).Value
                fdg_fin = DataGridViewX1.Item("fechaF", i).Value

                If Traslape_Fecha(fechaI_ord.Value, fechaF_ord.Value, fdg_ini, fdg_fin) Then
                    traslape = True
                    MsgBox("Existe traslape de fecha ", MsgBoxStyle.Exclamation)
                    Exit For
                End If
            Next
        End If
    End Function


    Private Function Traslape_Fecha(ByVal period1_start As Date, ByVal period1_end As Date, ByVal period2_start As Date, ByVal period2_end As Date)

        If Date.Compare(period1_start, period2_end) <= 0 And Date.Compare(period1_end, period2_start) >= 0 Then
            Return True
        End If
        Return False

    End Function
    Private Sub fechaI_Adic_ValueChanged(sender As Object, e As EventArgs) Handles fechaI_Adic.ValueChanged
        DiasRangoAdic.Value = diasAdicionales()
    End Sub

    Private Sub fechaF_Adic_ValueChanged(sender As Object, e As EventArgs) Handles fechaF_Adic.ValueChanged
        DiasRangoAdic.Value = diasAdicionales()
    End Sub

    Private Sub DataGridViewX1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewX1.RowHeaderMouseClick
        ' Crea Carta de Vacaciones

        Dim oVac As New cVacaciones
        oVac.carta(_id_emp, DataGridViewX1.CurrentRow.DataBoundItem.row, "")

    End Sub

End Class

